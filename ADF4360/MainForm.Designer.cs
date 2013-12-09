namespace ADF4360
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.frequencyBox = new System.Windows.Forms.GroupBox();
			this.refInLabel = new System.Windows.Forms.Label();
			this.refInBox = new System.Windows.Forms.TextBox();
			this.pfdLabel = new System.Windows.Forms.Label();
			this.pfdBox = new System.Windows.Forms.TextBox();
			this.rfoLabel = new System.Windows.Forms.Label();
			this.rfoBox = new System.Windows.Forms.TextBox();
			this.sweepBox = new System.Windows.Forms.GroupBox();
			this.startBox = new System.Windows.Forms.TextBox();
			this.startLabel = new System.Windows.Forms.Label();
			this.stopBox = new System.Windows.Forms.TextBox();
			this.stopLabel = new System.Windows.Forms.Label();
			this.spacingBox = new System.Windows.Forms.TextBox();
			this.spacingLabel = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.startButton = new System.Windows.Forms.Button();
			this.stopButton = new System.Windows.Forms.Button();
			this.writeButton = new System.Windows.Forms.Button();
			this.nCounterBinBox = new System.Windows.Forms.TextBox();
			this.latchesBox = new System.Windows.Forms.GroupBox();
			this.controlBinBox = new System.Windows.Forms.TextBox();
			this.rCounterBinBox = new System.Windows.Forms.TextBox();
			this.nCounterLabel = new System.Windows.Forms.Label();
			this.controlLabel = new System.Windows.Forms.Label();
			this.rCounterLabel = new System.Windows.Forms.Label();
			this.nCounterHexBox = new System.Windows.Forms.TextBox();
			this.controlHexBox = new System.Windows.Forms.TextBox();
			this.rCounterHexBox = new System.Windows.Forms.TextBox();
			this.frequencyBox.SuspendLayout();
			this.sweepBox.SuspendLayout();
			this.latchesBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// frequencyBox
			// 
			this.frequencyBox.Controls.Add(this.writeButton);
			this.frequencyBox.Controls.Add(this.refInLabel);
			this.frequencyBox.Controls.Add(this.refInBox);
			this.frequencyBox.Controls.Add(this.pfdLabel);
			this.frequencyBox.Controls.Add(this.pfdBox);
			this.frequencyBox.Controls.Add(this.rfoLabel);
			this.frequencyBox.Controls.Add(this.rfoBox);
			this.frequencyBox.Location = new System.Drawing.Point(12, 12);
			this.frequencyBox.Name = "frequencyBox";
			this.frequencyBox.Size = new System.Drawing.Size(270, 160);
			this.frequencyBox.TabIndex = 0;
			this.frequencyBox.TabStop = false;
			this.frequencyBox.Text = "Frequency Settings";
			// 
			// refInLabel
			// 
			this.refInLabel.AutoSize = true;
			this.refInLabel.Location = new System.Drawing.Point(29, 76);
			this.refInLabel.Name = "refInLabel";
			this.refInLabel.Size = new System.Drawing.Size(129, 13);
			this.refInLabel.TabIndex = 8;
			this.refInLabel.Text = "REF IN Frequency (MHz):";
			// 
			// refInBox
			// 
			this.refInBox.Location = new System.Drawing.Point(164, 73);
			this.refInBox.Name = "refInBox";
			this.refInBox.ReadOnly = true;
			this.refInBox.Size = new System.Drawing.Size(100, 20);
			this.refInBox.TabIndex = 6;
			this.refInBox.Text = "10";
			this.refInBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pfdLabel
			// 
			this.pfdLabel.AutoSize = true;
			this.pfdLabel.Location = new System.Drawing.Point(46, 49);
			this.pfdLabel.Name = "pfdLabel";
			this.pfdLabel.Size = new System.Drawing.Size(112, 13);
			this.pfdLabel.TabIndex = 5;
			this.pfdLabel.Text = "PFD Frequency (kHz):";
			// 
			// pfdBox
			// 
			this.pfdBox.Location = new System.Drawing.Point(164, 46);
			this.pfdBox.Name = "pfdBox";
			this.pfdBox.Size = new System.Drawing.Size(100, 20);
			this.pfdBox.TabIndex = 3;
			this.pfdBox.Text = "200";
			this.pfdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// rfoLabel
			// 
			this.rfoLabel.AutoSize = true;
			this.rfoLabel.Location = new System.Drawing.Point(15, 22);
			this.rfoLabel.Name = "rfoLabel";
			this.rfoLabel.Size = new System.Drawing.Size(143, 13);
			this.rfoLabel.TabIndex = 1;
			this.rfoLabel.Text = "RF Output Frequency (MHz):";
			// 
			// rfoBox
			// 
			this.rfoBox.Location = new System.Drawing.Point(164, 19);
			this.rfoBox.Name = "rfoBox";
			this.rfoBox.Size = new System.Drawing.Size(100, 20);
			this.rfoBox.TabIndex = 0;
			this.rfoBox.Text = "1100";
			this.rfoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// sweepBox
			// 
			this.sweepBox.Controls.Add(this.stopButton);
			this.sweepBox.Controls.Add(this.startButton);
			this.sweepBox.Controls.Add(this.progressBar);
			this.sweepBox.Controls.Add(this.spacingLabel);
			this.sweepBox.Controls.Add(this.spacingBox);
			this.sweepBox.Controls.Add(this.stopLabel);
			this.sweepBox.Controls.Add(this.stopBox);
			this.sweepBox.Controls.Add(this.startLabel);
			this.sweepBox.Controls.Add(this.startBox);
			this.sweepBox.Location = new System.Drawing.Point(288, 12);
			this.sweepBox.Name = "sweepBox";
			this.sweepBox.Size = new System.Drawing.Size(240, 160);
			this.sweepBox.TabIndex = 1;
			this.sweepBox.TabStop = false;
			this.sweepBox.Text = "Frequency Sweep";
			// 
			// startBox
			// 
			this.startBox.Location = new System.Drawing.Point(134, 19);
			this.startBox.Name = "startBox";
			this.startBox.Size = new System.Drawing.Size(100, 20);
			this.startBox.TabIndex = 1;
			this.startBox.Text = "1000";
			this.startBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// startLabel
			// 
			this.startLabel.AutoSize = true;
			this.startLabel.Location = new System.Drawing.Point(12, 22);
			this.startLabel.Name = "startLabel";
			this.startLabel.Size = new System.Drawing.Size(116, 13);
			this.startLabel.TabIndex = 2;
			this.startLabel.Text = "Start Frequency (MHz):";
			// 
			// stopBox
			// 
			this.stopBox.Location = new System.Drawing.Point(134, 46);
			this.stopBox.Name = "stopBox";
			this.stopBox.Size = new System.Drawing.Size(100, 20);
			this.stopBox.TabIndex = 3;
			this.stopBox.Text = "1100";
			this.stopBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// stopLabel
			// 
			this.stopLabel.AutoSize = true;
			this.stopLabel.Location = new System.Drawing.Point(12, 49);
			this.stopLabel.Name = "stopLabel";
			this.stopLabel.Size = new System.Drawing.Size(116, 13);
			this.stopLabel.TabIndex = 4;
			this.stopLabel.Text = "Stop Frequency (MHz):";
			// 
			// spacingBox
			// 
			this.spacingBox.Location = new System.Drawing.Point(134, 73);
			this.spacingBox.Name = "spacingBox";
			this.spacingBox.Size = new System.Drawing.Size(100, 20);
			this.spacingBox.TabIndex = 5;
			this.spacingBox.Text = "1";
			this.spacingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// spacingLabel
			// 
			this.spacingLabel.AutoSize = true;
			this.spacingLabel.Location = new System.Drawing.Point(48, 76);
			this.spacingLabel.Name = "spacingLabel";
			this.spacingLabel.Size = new System.Drawing.Size(80, 13);
			this.spacingLabel.TabIndex = 6;
			this.spacingLabel.Text = "Spacing (MHz):";
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(6, 99);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(228, 10);
			this.progressBar.TabIndex = 7;
			// 
			// startButton
			// 
			this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.startButton.Location = new System.Drawing.Point(7, 115);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(110, 37);
			this.startButton.TabIndex = 8;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = false;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// stopButton
			// 
			this.stopButton.Enabled = false;
			this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stopButton.Location = new System.Drawing.Point(123, 115);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(110, 37);
			this.stopButton.TabIndex = 9;
			this.stopButton.Text = "Stop";
			this.stopButton.UseVisualStyleBackColor = false;
			this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
			// 
			// writeButton
			// 
			this.writeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.writeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.writeButton.Location = new System.Drawing.Point(164, 99);
			this.writeButton.Name = "writeButton";
			this.writeButton.Size = new System.Drawing.Size(100, 53);
			this.writeButton.TabIndex = 9;
			this.writeButton.Text = "Write";
			this.writeButton.UseVisualStyleBackColor = false;
			this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
			// 
			// nCounterBinBox
			// 
			this.nCounterBinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nCounterBinBox.Location = new System.Drawing.Point(12, 55);
			this.nCounterBinBox.Name = "nCounterBinBox";
			this.nCounterBinBox.ReadOnly = true;
			this.nCounterBinBox.Size = new System.Drawing.Size(160, 20);
			this.nCounterBinBox.TabIndex = 2;
			this.nCounterBinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// latchesBox
			// 
			this.latchesBox.Controls.Add(this.rCounterHexBox);
			this.latchesBox.Controls.Add(this.controlHexBox);
			this.latchesBox.Controls.Add(this.nCounterHexBox);
			this.latchesBox.Controls.Add(this.rCounterLabel);
			this.latchesBox.Controls.Add(this.controlLabel);
			this.latchesBox.Controls.Add(this.nCounterLabel);
			this.latchesBox.Controls.Add(this.rCounterBinBox);
			this.latchesBox.Controls.Add(this.nCounterBinBox);
			this.latchesBox.Controls.Add(this.controlBinBox);
			this.latchesBox.Location = new System.Drawing.Point(12, 178);
			this.latchesBox.Name = "latchesBox";
			this.latchesBox.Size = new System.Drawing.Size(516, 125);
			this.latchesBox.TabIndex = 5;
			this.latchesBox.TabStop = false;
			this.latchesBox.Text = "Latches";
			// 
			// controlBinBox
			// 
			this.controlBinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.controlBinBox.Location = new System.Drawing.Point(178, 55);
			this.controlBinBox.Name = "controlBinBox";
			this.controlBinBox.ReadOnly = true;
			this.controlBinBox.Size = new System.Drawing.Size(160, 20);
			this.controlBinBox.TabIndex = 6;
			this.controlBinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// rCounterBinBox
			// 
			this.rCounterBinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rCounterBinBox.Location = new System.Drawing.Point(344, 55);
			this.rCounterBinBox.Name = "rCounterBinBox";
			this.rCounterBinBox.ReadOnly = true;
			this.rCounterBinBox.Size = new System.Drawing.Size(160, 20);
			this.rCounterBinBox.TabIndex = 7;
			this.rCounterBinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nCounterLabel
			// 
			this.nCounterLabel.AutoSize = true;
			this.nCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nCounterLabel.Location = new System.Drawing.Point(8, 28);
			this.nCounterLabel.Name = "nCounterLabel";
			this.nCounterLabel.Size = new System.Drawing.Size(151, 24);
			this.nCounterLabel.TabIndex = 6;
			this.nCounterLabel.Text = "N Counter Latch:";
			// 
			// controlLabel
			// 
			this.controlLabel.AutoSize = true;
			this.controlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.controlLabel.Location = new System.Drawing.Point(174, 28);
			this.controlLabel.Name = "controlLabel";
			this.controlLabel.Size = new System.Drawing.Size(125, 24);
			this.controlLabel.TabIndex = 8;
			this.controlLabel.Text = "Control Latch:";
			// 
			// rCounterLabel
			// 
			this.rCounterLabel.AutoSize = true;
			this.rCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rCounterLabel.Location = new System.Drawing.Point(340, 28);
			this.rCounterLabel.Name = "rCounterLabel";
			this.rCounterLabel.Size = new System.Drawing.Size(150, 24);
			this.rCounterLabel.TabIndex = 7;
			this.rCounterLabel.Text = "R Counter Latch:";
			// 
			// nCounterHexBox
			// 
			this.nCounterHexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nCounterHexBox.Location = new System.Drawing.Point(12, 81);
			this.nCounterHexBox.Name = "nCounterHexBox";
			this.nCounterHexBox.ReadOnly = true;
			this.nCounterHexBox.Size = new System.Drawing.Size(160, 32);
			this.nCounterHexBox.TabIndex = 9;
			this.nCounterHexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// controlHexBox
			// 
			this.controlHexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.controlHexBox.Location = new System.Drawing.Point(178, 81);
			this.controlHexBox.Name = "controlHexBox";
			this.controlHexBox.ReadOnly = true;
			this.controlHexBox.Size = new System.Drawing.Size(160, 32);
			this.controlHexBox.TabIndex = 10;
			this.controlHexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// rCounterHexBox
			// 
			this.rCounterHexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rCounterHexBox.Location = new System.Drawing.Point(344, 81);
			this.rCounterHexBox.Name = "rCounterHexBox";
			this.rCounterHexBox.ReadOnly = true;
			this.rCounterHexBox.Size = new System.Drawing.Size(160, 32);
			this.rCounterHexBox.TabIndex = 11;
			this.rCounterHexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 313);
			this.Controls.Add(this.latchesBox);
			this.Controls.Add(this.sweepBox);
			this.Controls.Add(this.frequencyBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ADF4360 Tester";
			this.frequencyBox.ResumeLayout(false);
			this.frequencyBox.PerformLayout();
			this.sweepBox.ResumeLayout(false);
			this.sweepBox.PerformLayout();
			this.latchesBox.ResumeLayout(false);
			this.latchesBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox frequencyBox;
		private System.Windows.Forms.Label rfoLabel;
		private System.Windows.Forms.TextBox rfoBox;
		private System.Windows.Forms.Label pfdLabel;
		private System.Windows.Forms.TextBox pfdBox;
		private System.Windows.Forms.Label refInLabel;
		private System.Windows.Forms.TextBox refInBox;
		private System.Windows.Forms.GroupBox sweepBox;
		private System.Windows.Forms.TextBox startBox;
		private System.Windows.Forms.Label startLabel;
		private System.Windows.Forms.Label stopLabel;
		private System.Windows.Forms.TextBox stopBox;
		private System.Windows.Forms.TextBox spacingBox;
		private System.Windows.Forms.Label spacingLabel;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button stopButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button writeButton;
		private System.Windows.Forms.TextBox nCounterBinBox;
		private System.Windows.Forms.GroupBox latchesBox;
		private System.Windows.Forms.TextBox controlBinBox;
		private System.Windows.Forms.TextBox rCounterBinBox;
		private System.Windows.Forms.Label rCounterLabel;
		private System.Windows.Forms.Label controlLabel;
		private System.Windows.Forms.Label nCounterLabel;
		private System.Windows.Forms.TextBox rCounterHexBox;
		private System.Windows.Forms.TextBox controlHexBox;
		private System.Windows.Forms.TextBox nCounterHexBox;
	}
}

