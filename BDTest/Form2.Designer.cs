namespace BDTest
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbUtcTime = new System.Windows.Forms.TextBox();
            this.Latitude = new System.Windows.Forms.TextBox();
            this.Longitude = new System.Windows.Forms.TextBox();
            this.lbUtcData = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.TextBox();
            this.ShowMap = new System.Windows.Forms.Button();
            this.OpenSerialPort = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UTCData = new System.Windows.Forms.Label();
            this.UTCTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PortName0 = new System.Windows.Forms.ComboBox();
            this.IbStatus = new System.Windows.Forms.Label();
            this.BandRate0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataBits0 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StopBits0 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Parity0 = new System.Windows.Forms.ComboBox();
            this.HandShake0 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CloseSerialPort = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 326);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(870, 22);
            this.statusStrip1.TabIndex = 45;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(505, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 323);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接收";
            // 
            // lbUtcTime
            // 
            this.lbUtcTime.Location = new System.Drawing.Point(71, 198);
            this.lbUtcTime.Name = "lbUtcTime";
            this.lbUtcTime.ReadOnly = true;
            this.lbUtcTime.Size = new System.Drawing.Size(100, 21);
            this.lbUtcTime.TabIndex = 43;
            // 
            // Latitude
            // 
            this.Latitude.Location = new System.Drawing.Point(70, 289);
            this.Latitude.Name = "Latitude";
            this.Latitude.ReadOnly = true;
            this.Latitude.Size = new System.Drawing.Size(100, 21);
            this.Latitude.TabIndex = 42;
            // 
            // Longitude
            // 
            this.Longitude.Location = new System.Drawing.Point(70, 247);
            this.Longitude.Name = "Longitude";
            this.Longitude.ReadOnly = true;
            this.Longitude.Size = new System.Drawing.Size(100, 21);
            this.Longitude.TabIndex = 41;
            // 
            // lbUtcData
            // 
            this.lbUtcData.Location = new System.Drawing.Point(70, 154);
            this.lbUtcData.Name = "lbUtcData";
            this.lbUtcData.ReadOnly = true;
            this.lbUtcData.Size = new System.Drawing.Size(100, 21);
            this.lbUtcData.TabIndex = 40;
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(71, 108);
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Size = new System.Drawing.Size(100, 21);
            this.Status.TabIndex = 39;
            // 
            // ShowMap
            // 
            this.ShowMap.Location = new System.Drawing.Point(426, 108);
            this.ShowMap.Margin = new System.Windows.Forms.Padding(2);
            this.ShowMap.Name = "ShowMap";
            this.ShowMap.Size = new System.Drawing.Size(73, 22);
            this.ShowMap.TabIndex = 38;
            this.ShowMap.Text = "显示地图";
            this.ShowMap.UseVisualStyleBackColor = true;
            this.ShowMap.Click += new System.EventHandler(this.ShowMap_Click);
            // 
            // OpenSerialPort
            // 
            this.OpenSerialPort.Location = new System.Drawing.Point(415, 19);
            this.OpenSerialPort.Margin = new System.Windows.Forms.Padding(2);
            this.OpenSerialPort.Name = "OpenSerialPort";
            this.OpenSerialPort.Size = new System.Drawing.Size(66, 21);
            this.OpenSerialPort.TabIndex = 37;
            this.OpenSerialPort.Text = "打开串口";
            this.OpenSerialPort.UseVisualStyleBackColor = true;
            this.OpenSerialPort.Click += new System.EventHandler(this.OpenSerialPort_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 35;
            this.label8.Text = "定位纬度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "定位经度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-31, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "状态";
            // 
            // UTCData
            // 
            this.UTCData.AutoSize = true;
            this.UTCData.Location = new System.Drawing.Point(13, 157);
            this.UTCData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UTCData.Name = "UTCData";
            this.UTCData.Size = new System.Drawing.Size(47, 12);
            this.UTCData.TabIndex = 31;
            this.UTCData.Text = "UTC日期";
            // 
            // UTCTime
            // 
            this.UTCTime.AutoSize = true;
            this.UTCTime.Location = new System.Drawing.Point(13, 201);
            this.UTCTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UTCTime.Name = "UTCTime";
            this.UTCTime.Size = new System.Drawing.Size(47, 12);
            this.UTCTime.TabIndex = 30;
            this.UTCTime.Text = "UTC时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "BandRate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "PortName";
            // 
            // PortName0
            // 
            this.PortName0.FormattingEnabled = true;
            this.PortName0.Location = new System.Drawing.Point(64, 19);
            this.PortName0.Margin = new System.Windows.Forms.Padding(2);
            this.PortName0.Name = "PortName0";
            this.PortName0.Size = new System.Drawing.Size(66, 20);
            this.PortName0.TabIndex = 27;
            // 
            // IbStatus
            // 
            this.IbStatus.AutoSize = true;
            this.IbStatus.Location = new System.Drawing.Point(19, 113);
            this.IbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IbStatus.Name = "IbStatus";
            this.IbStatus.Size = new System.Drawing.Size(29, 12);
            this.IbStatus.TabIndex = 46;
            this.IbStatus.Text = "状态";
            // 
            // BandRate0
            // 
            this.BandRate0.Location = new System.Drawing.Point(207, 19);
            this.BandRate0.Name = "BandRate0";
            this.BandRate0.Size = new System.Drawing.Size(66, 21);
            this.BandRate0.TabIndex = 47;
            this.BandRate0.Text = "9600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 48;
            this.label3.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 50;
            this.label4.Text = "DataBits";
            // 
            // DataBits0
            // 
            this.DataBits0.Location = new System.Drawing.Point(65, 44);
            this.DataBits0.Name = "DataBits0";
            this.DataBits0.Size = new System.Drawing.Size(66, 21);
            this.DataBits0.TabIndex = 51;
            this.DataBits0.Text = "8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 52;
            this.label7.Text = "StopBits";
            // 
            // StopBits0
            // 
            this.StopBits0.FormattingEnabled = true;
            this.StopBits0.Location = new System.Drawing.Point(207, 44);
            this.StopBits0.Margin = new System.Windows.Forms.Padding(2);
            this.StopBits0.Name = "StopBits0";
            this.StopBits0.Size = new System.Drawing.Size(66, 20);
            this.StopBits0.TabIndex = 53;
            this.StopBits0.Text = "One";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 54;
            this.label9.Text = "HandShake";
            // 
            // Parity0
            // 
            this.Parity0.FormattingEnabled = true;
            this.Parity0.Location = new System.Drawing.Point(340, 19);
            this.Parity0.Margin = new System.Windows.Forms.Padding(2);
            this.Parity0.Name = "Parity0";
            this.Parity0.Size = new System.Drawing.Size(66, 20);
            this.Parity0.TabIndex = 55;
            // 
            // HandShake0
            // 
            this.HandShake0.FormattingEnabled = true;
            this.HandShake0.Location = new System.Drawing.Point(340, 44);
            this.HandShake0.Margin = new System.Windows.Forms.Padding(2);
            this.HandShake0.Name = "HandShake0";
            this.HandShake0.Size = new System.Drawing.Size(66, 20);
            this.HandShake0.TabIndex = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CloseSerialPort);
            this.groupBox2.Controls.Add(this.PortName0);
            this.groupBox2.Controls.Add(this.HandShake0);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Parity0);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.BandRate0);
            this.groupBox2.Controls.Add(this.StopBits0);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.OpenSerialPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DataBits0);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 71);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            // 
            // CloseSerialPort
            // 
            this.CloseSerialPort.Location = new System.Drawing.Point(415, 44);
            this.CloseSerialPort.Margin = new System.Windows.Forms.Padding(2);
            this.CloseSerialPort.Name = "CloseSerialPort";
            this.CloseSerialPort.Size = new System.Drawing.Size(66, 21);
            this.CloseSerialPort.TabIndex = 57;
            this.CloseSerialPort.Text = "关闭串口";
            this.CloseSerialPort.UseVisualStyleBackColor = true;
            this.CloseSerialPort.Click += new System.EventHandler(this.CloseSerialPort_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(358, 303);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 348);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.IbStatus);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbUtcTime);
            this.Controls.Add(this.Latitude);
            this.Controls.Add(this.Longitude);
            this.Controls.Add(this.lbUtcData);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.ShowMap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UTCData);
            this.Controls.Add(this.UTCTime);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lbUtcTime;
        private System.Windows.Forms.TextBox Latitude;
        private System.Windows.Forms.TextBox Longitude;
        private System.Windows.Forms.TextBox lbUtcData;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.Button ShowMap;
        private System.Windows.Forms.Button OpenSerialPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label UTCData;
        private System.Windows.Forms.Label UTCTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PortName0;
        private System.Windows.Forms.Label IbStatus;
        private System.Windows.Forms.TextBox BandRate0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DataBits0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox StopBits0;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Parity0;
        private System.Windows.Forms.ComboBox HandShake0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CloseSerialPort;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}