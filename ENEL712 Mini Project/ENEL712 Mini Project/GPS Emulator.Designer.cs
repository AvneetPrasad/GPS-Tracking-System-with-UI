namespace ENEL712_Mini_Project
{
    partial class Updates
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.portStatus = new System.Windows.Forms.TextBox();
            this.butPortClose = new System.Windows.Forms.Button();
            this.butPortOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tBoxTotalTime = new System.Windows.Forms.TextBox();
            this.tBoxTotalDistance = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tBoxCompass = new System.Windows.Forms.TextBox();
            this.tBoxSpeed = new System.Windows.Forms.TextBox();
            this.tBoxDist = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tBoxTime2 = new System.Windows.Forms.TextBox();
            this.tBoxLong2 = new System.Windows.Forms.TextBox();
            this.tBoxLat2 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxTime1 = new System.Windows.Forms.TextBox();
            this.tBoxLong1 = new System.Windows.Forms.TextBox();
            this.tBoxLat1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblDataINLength = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.chBoxAddToOldData = new System.Windows.Forms.CheckBox();
            this.chBoxAlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.butClearDataIN = new System.Windows.Forms.Button();
            this.tBoxDataIN = new System.Windows.Forms.TextBox();
            this.tBoxDataLog = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.chartSpeed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 540);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial Port";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.butPortClose);
            this.groupBox2.Controls.Add(this.butPortOpen);
            this.groupBox2.Location = new System.Drawing.Point(20, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 160);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 125);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(389, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.portStatus);
            this.groupBox3.Location = new System.Drawing.Point(162, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serial Port Status";
            // 
            // portStatus
            // 
            this.portStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portStatus.Location = new System.Drawing.Point(69, 30);
            this.portStatus.Name = "portStatus";
            this.portStatus.Size = new System.Drawing.Size(100, 37);
            this.portStatus.TabIndex = 0;
            this.portStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butPortClose
            // 
            this.butPortClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPortClose.Location = new System.Drawing.Point(6, 79);
            this.butPortClose.Name = "butPortClose";
            this.butPortClose.Size = new System.Drawing.Size(124, 40);
            this.butPortClose.TabIndex = 1;
            this.butPortClose.Text = "Close";
            this.butPortClose.UseVisualStyleBackColor = true;
            this.butPortClose.Click += new System.EventHandler(this.butPortClose_Click);
            // 
            // butPortOpen
            // 
            this.butPortOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPortOpen.Location = new System.Drawing.Point(6, 33);
            this.butPortOpen.Name = "butPortOpen";
            this.butPortOpen.Size = new System.Drawing.Size(124, 40);
            this.butPortOpen.TabIndex = 0;
            this.butPortOpen.Text = "Open";
            this.butPortOpen.UseVisualStyleBackColor = true;
            this.butPortOpen.Click += new System.EventHandler(this.butPortOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Controls.Add(this.cBoxComPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Parameters";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cBoxParityBits.Location = new System.Drawing.Point(198, 222);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(168, 33);
            this.cBoxParityBits.TabIndex = 9;
            this.cBoxParityBits.Text = "None";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.AutoCompleteCustomSource.AddRange(new string[] {
            "One",
            "Two"});
            this.cBoxStopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Location = new System.Drawing.Point(198, 174);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(168, 33);
            this.cBoxStopBits.TabIndex = 8;
            this.cBoxStopBits.Text = "One";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(198, 126);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(168, 33);
            this.cBoxDataBits.TabIndex = 7;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(198, 78);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(168, 33);
            this.cBoxBaudRate.TabIndex = 6;
            this.cBoxBaudRate.Text = "9600";
            this.cBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.Location = new System.Drawing.Point(198, 30);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(168, 33);
            this.cBoxComPort.TabIndex = 5;
            this.cBoxComPort.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parity Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stop Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com Port #";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GPS Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.tBoxDataIN);
            this.groupBox4.Controls.Add(this.tBoxDataLog);
            this.groupBox4.Location = new System.Drawing.Point(20, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 490);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Received Data";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox9);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(6, 244);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(386, 237);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.tBoxTotalTime);
            this.groupBox9.Controls.Add(this.tBoxTotalDistance);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.tBoxCompass);
            this.groupBox9.Controls.Add(this.tBoxSpeed);
            this.groupBox9.Controls.Add(this.tBoxDist);
            this.groupBox9.Location = new System.Drawing.Point(6, 122);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(367, 100);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Calculation";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(218, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Total Time (min)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(60, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Total Distance (km)";
            // 
            // tBoxTotalTime
            // 
            this.tBoxTotalTime.Location = new System.Drawing.Point(189, 74);
            this.tBoxTotalTime.Name = "tBoxTotalTime";
            this.tBoxTotalTime.Size = new System.Drawing.Size(140, 20);
            this.tBoxTotalTime.TabIndex = 10;
            // 
            // tBoxTotalDistance
            // 
            this.tBoxTotalDistance.Location = new System.Drawing.Point(39, 74);
            this.tBoxTotalDistance.Name = "tBoxTotalDistance";
            this.tBoxTotalDistance.Size = new System.Drawing.Size(140, 20);
            this.tBoxTotalDistance.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(283, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Compass";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(147, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "speed (km/h)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "distance (m)";
            // 
            // tBoxCompass
            // 
            this.tBoxCompass.Location = new System.Drawing.Point(258, 32);
            this.tBoxCompass.Name = "tBoxCompass";
            this.tBoxCompass.Size = new System.Drawing.Size(100, 20);
            this.tBoxCompass.TabIndex = 5;
            // 
            // tBoxSpeed
            // 
            this.tBoxSpeed.Location = new System.Drawing.Point(132, 32);
            this.tBoxSpeed.Name = "tBoxSpeed";
            this.tBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.tBoxSpeed.TabIndex = 4;
            this.tBoxSpeed.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // tBoxDist
            // 
            this.tBoxDist.Location = new System.Drawing.Point(6, 32);
            this.tBoxDist.Name = "tBoxDist";
            this.tBoxDist.Size = new System.Drawing.Size(100, 20);
            this.tBoxDist.TabIndex = 3;
            this.tBoxDist.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.tBoxTime2);
            this.groupBox8.Controls.Add(this.tBoxLong2);
            this.groupBox8.Controls.Add(this.tBoxLat2);
            this.groupBox8.Location = new System.Drawing.Point(194, 16);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(179, 100);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Current Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Time 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Long 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Lat 2";
            // 
            // tBoxTime2
            // 
            this.tBoxTime2.Location = new System.Drawing.Point(71, 71);
            this.tBoxTime2.Name = "tBoxTime2";
            this.tBoxTime2.Size = new System.Drawing.Size(100, 20);
            this.tBoxTime2.TabIndex = 8;
            // 
            // tBoxLong2
            // 
            this.tBoxLong2.Location = new System.Drawing.Point(71, 45);
            this.tBoxLong2.Name = "tBoxLong2";
            this.tBoxLong2.Size = new System.Drawing.Size(100, 20);
            this.tBoxLong2.TabIndex = 6;
            // 
            // tBoxLat2
            // 
            this.tBoxLat2.Location = new System.Drawing.Point(71, 19);
            this.tBoxLat2.Name = "tBoxLat2";
            this.tBoxLat2.Size = new System.Drawing.Size(100, 20);
            this.tBoxLat2.TabIndex = 5;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.tBoxTime1);
            this.groupBox7.Controls.Add(this.tBoxLong1);
            this.groupBox7.Controls.Add(this.tBoxLat1);
            this.groupBox7.Location = new System.Drawing.Point(6, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(179, 100);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Previous Position";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Time 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Long 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Lat 1";
            // 
            // tBoxTime1
            // 
            this.tBoxTime1.Location = new System.Drawing.Point(71, 71);
            this.tBoxTime1.Name = "tBoxTime1";
            this.tBoxTime1.Size = new System.Drawing.Size(100, 20);
            this.tBoxTime1.TabIndex = 2;
            // 
            // tBoxLong1
            // 
            this.tBoxLong1.Location = new System.Drawing.Point(71, 45);
            this.tBoxLong1.Name = "tBoxLong1";
            this.tBoxLong1.Size = new System.Drawing.Size(100, 20);
            this.tBoxLong1.TabIndex = 1;
            // 
            // tBoxLat1
            // 
            this.tBoxLat1.Location = new System.Drawing.Point(71, 19);
            this.tBoxLat1.Name = "tBoxLat1";
            this.tBoxLat1.Size = new System.Drawing.Size(100, 20);
            this.tBoxLat1.TabIndex = 0;
            this.tBoxLat1.TextChanged += new System.EventHandler(this.tBoxLat2_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblDataINLength);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.chBoxAddToOldData);
            this.groupBox5.Controls.Add(this.chBoxAlwaysUpdate);
            this.groupBox5.Controls.Add(this.butClearDataIN);
            this.groupBox5.Location = new System.Drawing.Point(6, 151);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(386, 87);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Receiving Options";
            // 
            // lblDataINLength
            // 
            this.lblDataINLength.AutoSize = true;
            this.lblDataINLength.Location = new System.Drawing.Point(305, 57);
            this.lblDataINLength.Name = "lblDataINLength";
            this.lblDataINLength.Size = new System.Drawing.Size(19, 13);
            this.lblDataINLength.TabIndex = 3;
            this.lblDataINLength.Text = "00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(181, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Received Data Length:";
            // 
            // chBoxAddToOldData
            // 
            this.chBoxAddToOldData.AutoSize = true;
            this.chBoxAddToOldData.Location = new System.Drawing.Point(246, 19);
            this.chBoxAddToOldData.Name = "chBoxAddToOldData";
            this.chBoxAddToOldData.Size = new System.Drawing.Size(128, 17);
            this.chBoxAddToOldData.TabIndex = 2;
            this.chBoxAddToOldData.Text = "Add To The Old Data";
            this.chBoxAddToOldData.UseVisualStyleBackColor = true;
            this.chBoxAddToOldData.CheckedChanged += new System.EventHandler(this.chBoxAddToOldData_CheckedChanged);
            // 
            // chBoxAlwaysUpdate
            // 
            this.chBoxAlwaysUpdate.AutoSize = true;
            this.chBoxAlwaysUpdate.Location = new System.Drawing.Point(138, 19);
            this.chBoxAlwaysUpdate.Name = "chBoxAlwaysUpdate";
            this.chBoxAlwaysUpdate.Size = new System.Drawing.Size(97, 17);
            this.chBoxAlwaysUpdate.TabIndex = 1;
            this.chBoxAlwaysUpdate.Text = "Always Update";
            this.chBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            this.chBoxAlwaysUpdate.CheckedChanged += new System.EventHandler(this.chBoxAlwaysUpdate_CheckedChanged);
            // 
            // butClearDataIN
            // 
            this.butClearDataIN.Location = new System.Drawing.Point(15, 19);
            this.butClearDataIN.Name = "butClearDataIN";
            this.butClearDataIN.Size = new System.Drawing.Size(109, 57);
            this.butClearDataIN.TabIndex = 0;
            this.butClearDataIN.Text = "Clear Received Data";
            this.butClearDataIN.UseVisualStyleBackColor = true;
            this.butClearDataIN.Click += new System.EventHandler(this.butClearDataIN_Click);
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.Location = new System.Drawing.Point(6, 125);
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.Size = new System.Drawing.Size(386, 20);
            this.tBoxDataIN.TabIndex = 8;
            this.tBoxDataIN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tBoxDataLog
            // 
            this.tBoxDataLog.Location = new System.Drawing.Point(6, 19);
            this.tBoxDataLog.Multiline = true;
            this.tBoxDataLog.Name = "tBoxDataLog";
            this.tBoxDataLog.Size = new System.Drawing.Size(386, 100);
            this.tBoxDataLog.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(441, 514);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GPS Data Analysis";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.chartSpeed);
            this.groupBox10.Location = new System.Drawing.Point(20, 15);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(404, 324);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Speed Record";
            // 
            // chartSpeed
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSpeed.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSpeed.Legends.Add(legend1);
            this.chartSpeed.Location = new System.Drawing.Point(6, 19);
            this.chartSpeed.Name = "chartSpeed";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Speed";
            this.chartSpeed.Series.Add(series1);
            this.chartSpeed.Size = new System.Drawing.Size(392, 297);
            this.chartSpeed.TabIndex = 0;
            this.chartSpeed.Text = "chartSpeed";
            this.chartSpeed.Click += new System.EventHandler(this.chartSpeed_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Updates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 556);
            this.Controls.Add(this.tabControl1);
            this.Name = "Updates";
            this.Text = "GPS_Emulator";
            this.Load += new System.EventHandler(this.GPS_Emulator_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button butPortClose;
        private System.Windows.Forms.Button butPortOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBoxTime2;
        private System.Windows.Forms.TextBox tBoxLong2;
        private System.Windows.Forms.TextBox tBoxLat2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxTime1;
        private System.Windows.Forms.TextBox tBoxLong1;
        private System.Windows.Forms.TextBox tBoxLat1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chBoxAddToOldData;
        private System.Windows.Forms.CheckBox chBoxAlwaysUpdate;
        private System.Windows.Forms.Button butClearDataIN;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private System.Windows.Forms.TextBox tBoxDataLog;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tBoxCompass;
        private System.Windows.Forms.TextBox tBoxSpeed;
        private System.Windows.Forms.TextBox tBoxDist;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tBoxTotalTime;
        private System.Windows.Forms.TextBox tBoxTotalDistance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox portStatus;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblDataINLength;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpeed;
    }
}