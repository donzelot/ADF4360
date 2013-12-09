using CyUSB;
using System;

namespace ADF4360
{
	/// <summary>
	/// Генератор
	/// </summary>
	class Generator
	{
		/// <summary>
		/// Ссылка на USB устройство
		/// </summary>
		private CyFX2Device device;

		/// <summary>
		/// Список регистров
		/// </summary>
		private uint[] R;

		/// <summary>
		/// Построение регистров
		/// </summary>
		private void BuildRegisters(double frequency, double pfd)
		{
			int internalD2 = 0;
			int outputD2 = 0;
			int cpGain = 0;
			double refFreq = 10;
			double rCounter = (refFreq * 1000.0) / pfd;
			double n = (rCounter * frequency) / refFreq;
			int p = 0x10;
			int b = ((int)n) / p;
			int a = ((int)n) - (b * p);

			R[2] = (uint)(((((2.0 + (a * Math.Pow(2.0, 2.0))) + (b * Math.Pow(2.0, 8.0))) + (cpGain * Math.Pow(2.0, 21.0))) + (outputD2 * Math.Pow(2.0, 22.0))) + (internalD2 * Math.Pow(2.0, 23.0)));
		}

		/// <summary>
		/// Запись данных в регистр из буфера
		/// </summary>
		private void WriteAReg(int reg)
		{
			if (device != null)
			{
				device.ControlEndPt.Value = 0;
				device.ControlEndPt.Index = 0;

				int length = 5;
				byte[] buf = new byte[length];
				for (int i = 0; i < 4; i++)
					buf[i] = (byte)(this.R[reg] >> (i * 8));

				buf[4] = 0x20;
				device.ControlEndPt.XferData(ref buf, ref length);
			}
		}

		/// <summary>
		/// Конструктор
		/// </summary>
		public Generator()
		{
			this.device = null;
			this.R = new uint[3];

			R[0] = 0x4ff104;
			R[1] = 0x3000c9;
		}

		/// <summary>
		/// Поиск устройства
		/// </summary>
		public bool Find()
		{
			USBDeviceList usbDevices = new USBDeviceList(1);

			foreach (USBDevice d in usbDevices)
				if ((d.ProductID == 0xb40D) && (d.VendorID == 0x0456))
					device = d as CyFX2Device;

			bool loaded = false;
			if (device != null)
				loaded = device.LoadExternalRam("Resources\\ADF4360ExternalRAM.hex");
			else
				return false;

			if (loaded)
			{
				device.ControlEndPt.Target = 0;
				device.ControlEndPt.ReqType = 0x40;
				device.ControlEndPt.Direction = 0;
				device.ControlEndPt.ReqCode = 0xdd;
				device.ControlEndPt.Value = 0;
				device.ControlEndPt.Index = 0;

				return true;
			}

			return false;
		}

		/// <summary>
		/// Получение списка регистров
		/// </summary>
		public uint[] GetR()
		{
			return R;
		}

		/// <summary>
		/// Установка частоты
		/// </summary>
		public void SetFrequency(double frequency, double pfd)
		{
			BuildRegisters(frequency, pfd);

			WriteAReg(0);
			WriteAReg(1);
			WriteAReg(2);
		}
	}
}
