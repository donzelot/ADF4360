using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ADF4360
{
	/// <summary>
	/// Главное окно приложения
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Генератор
		/// </summary>
		private Generator generator;

		/// <summary>
		/// Поток для свипирования
		/// </summary>
		private Thread thread;

		/// <summary>
		/// Делегат для асинхронного доступа к текстовому полю
		/// </summary>
		delegate void SetTextCallback(TextBox textBox, String text);

		/// <summary>
		/// Делегат для асинхронного включения/выключения компонента
		/// </summary>
		delegate void SetEnabledCallback(Control control, bool enabled);

		/// <summary>
		/// Делегат для асинхронной установки значения полосы прогресса свипирования
		/// </summary>
		/// <param name="percent"></param>
		delegate void SetPercentCallback(double percent);

		/// <summary>
		/// Конструктор
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			generator = new Generator();

			if (!generator.Find())
			{
				MessageBox.Show("Device not found!", "Error");
				Enabled = false;
			}
			else
			{
				generator.SetFrequency(1100, 200);
				UpdateLatches();
			}
		}

		/// <summary>
		/// Запись регистров
		/// </summary>
		private void writeButton_Click(object sender, EventArgs e)
		{
			double frequency = Double.Parse(rfoBox.Text);
			double pfd = Double.Parse(pfdBox.Text);
			generator.SetFrequency(frequency, pfd);

			UpdateLatches();
		}

		/// <summary>
		/// Обновление полей регистров
		/// </summary>
		private void UpdateLatches()
		{
			uint[] r = generator.GetR();

			SetText(nCounterBinBox, Convert.ToString(r[2], 2));
			SetText(nCounterHexBox, Convert.ToString(r[2], 16));
			SetText(controlBinBox, Convert.ToString(r[0], 2));
			SetText(controlHexBox, Convert.ToString(r[0], 16));
			SetText(rCounterBinBox, Convert.ToString(r[1], 2));
			SetText(rCounterHexBox, Convert.ToString(r[1], 16));
		}

		/// <summary>
		/// Запуск свипирования
		/// </summary>
		private void startButton_Click(object sender, EventArgs e)
		{
			thread = new Thread(new ThreadStart(this.Sweep));
			thread.Start();
		}

		/// <summary>
		/// Остановка свипирования
		/// </summary>
		private void stopButton_Click(object sender, EventArgs e)
		{
			SetEnabled(writeButton, true);
			SetEnabled(startButton, true);
			SetEnabled(stopButton, false);
			SetPercent(0);

			thread.Abort();
			UpdateLatches();
		}

		/// <summary>
		/// Асинхронная установка текста в текстовом поле
		/// </summary>
		private void SetText(TextBox textBox, String text)
		{
			if (textBox.InvokeRequired)
			{
				SetTextCallback callback = new SetTextCallback(SetText);
				this.Invoke(callback, new object[] { textBox, text });
			}
			else
			{
				textBox.Text = text;
			}
		}

		/// <summary>
		/// Асинхронное включение/выключение компонента
		/// </summary>
		/// <param name="control"></param>
		/// <param name="enabled"></param>
		private void SetEnabled(Control control, bool enabled)
		{
			if (InvokeRequired)
			{
				SetEnabledCallback callback = new SetEnabledCallback(SetEnabled);
				this.Invoke(callback, new object[] { control, enabled });
			}
			else
			{
				control.Enabled = enabled;
			}
		}

		/// <summary>
		/// Асинхронная установка значения полосы прогресса свипирования
		/// </summary>
		/// <param name="percent"></param>
		private void SetPercent(double percent)
		{
			if (InvokeRequired)
			{
				SetPercentCallback callback = new SetPercentCallback(SetPercent);
				this.Invoke(callback, new object[] { percent });
			}
			else
			{
				progressBar.Value = (int) percent;
			}
		}

		/// <summary>
		/// Цикл свипирования
		/// </summary>
		public void Sweep()
		{
			SetEnabled(writeButton, false);
			SetEnabled(startButton, false);
			SetEnabled(stopButton, true);

			double start = Double.Parse(startBox.Text);
			double stop = Double.Parse(stopBox.Text);
			double spacing = Double.Parse(spacingBox.Text);

			double frequency = start;
			while (frequency <= stop)
			{
				double percent = (stop - frequency) / (stop - start);
				SetPercent(100 - percent * 100);

				generator.SetFrequency(frequency, 200);
				UpdateLatches();
				frequency += spacing;
				//Thread.Sleep(50);
			}

			SetEnabled(writeButton, true);
			SetEnabled(startButton, true);
			SetEnabled(stopButton, false);
			SetPercent(0);
		}
	}
}
