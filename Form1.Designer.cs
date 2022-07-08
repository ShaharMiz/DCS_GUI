namespace Pneumatic_Control
{
    partial class elevator_control
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(elevator_control));
            this.button_open = new System.Windows.Forms.Button();
            this.progressBar_statusBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.comboBox_comPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_textSent = new System.Windows.Forms.TextBox();
            this.richTextBox_textReceiver = new System.Windows.Forms.RichTextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearText = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ChartcomboBox = new System.Windows.Forms.ComboBox();
            this.clearChartButton = new System.Windows.Forms.Button();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.currentBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.VscapBar = new System.Windows.Forms.ProgressBar();
            this.currentLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.VinBar = new System.Windows.Forms.ProgressBar();
            this.label25 = new System.Windows.Forms.Label();
            this.SM_countre_Label = new System.Windows.Forms.Label();
            this.vscapLabel = new System.Windows.Forms.Label();
            this.timestamp_label = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MSG_Status = new System.Windows.Forms.Label();
            this.PingButton = new System.Windows.Forms.Button();
            this.AutoButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.message_sent_label = new System.Windows.Forms.Label();
            this.message_recieved_label = new System.Windows.Forms.Label();
            this.message_error_label = new System.Windows.Forms.Label();
            this.reset_counter_button = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.IDWriteButton = new System.Windows.Forms.Button();
            this.VersionTextBox = new System.Windows.Forms.TextBox();
            this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.PartNumberTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.ReadIDbutton = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.calibCurrentButton = new System.Windows.Forms.Button();
            this.calibVoltageButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.calibTextBox = new System.Windows.Forms.TextBox();
            this.openModeButton = new System.Windows.Forms.RadioButton();
            this.closeModeButton = new System.Windows.Forms.RadioButton();
            this.autoModeButton = new System.Windows.Forms.RadioButton();
            this.moveMotorTest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentBar)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(205, 26);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(67, 55);
            this.button_open.TabIndex = 7;
            this.button_open.Text = "OPEN";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // progressBar_statusBar
            // 
            this.progressBar_statusBar.Location = new System.Drawing.Point(104, 89);
            this.progressBar_statusBar.Name = "progressBar_statusBar";
            this.progressBar_statusBar.Size = new System.Drawing.Size(55, 23);
            this.progressBar_statusBar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "STATUS :";
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200",
            "500000",
            "1000000"});
            this.comboBox_baudRate.Location = new System.Drawing.Point(122, 55);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(77, 29);
            this.comboBox_baudRate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "BAUD RATE :";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(14, 118);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(118, 20);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "DISCONNECTED";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_status.Click += new System.EventHandler(this.label_status_Click);
            // 
            // comboBox_comPort
            // 
            this.comboBox_comPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Location = new System.Drawing.Point(122, 22);
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.Size = new System.Drawing.Size(77, 29);
            this.comboBox_comPort.TabIndex = 1;
            this.comboBox_comPort.Click += new System.EventHandler(this.comboBox_comPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM PORT :";
            // 
            // textBox_textSent
            // 
            this.textBox_textSent.Location = new System.Drawing.Point(3, 491);
            this.textBox_textSent.Name = "textBox_textSent";
            this.textBox_textSent.Size = new System.Drawing.Size(171, 29);
            this.textBox_textSent.TabIndex = 1;
            this.textBox_textSent.TextChanged += new System.EventHandler(this.textBox_textSent_TextChanged);
            // 
            // richTextBox_textReceiver
            // 
            this.richTextBox_textReceiver.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_textReceiver.Location = new System.Drawing.Point(0, 171);
            this.richTextBox_textReceiver.Name = "richTextBox_textReceiver";
            this.richTextBox_textReceiver.Size = new System.Drawing.Size(243, 316);
            this.richTextBox_textReceiver.TabIndex = 2;
            this.richTextBox_textReceiver.Text = "";
            this.richTextBox_textReceiver.TextChanged += new System.EventHandler(this.richTextBox_textReceiver_TextChanged);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(180, 489);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(64, 28);
            this.button_send.TabIndex = 3;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Received data:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearText);
            this.groupBox1.Controls.Add(this.comboBox_comPort);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_status);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_baudRate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.progressBar_statusBar);
            this.groupBox1.Controls.Add(this.button_open);
            this.groupBox1.Controls.Add(this.richTextBox_textReceiver);
            this.groupBox1.Controls.Add(this.button_send);
            this.groupBox1.Controls.Add(this.textBox_textSent);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 522);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication";
            // 
            // ClearText
            // 
            this.ClearText.Location = new System.Drawing.Point(156, 118);
            this.ClearText.Name = "ClearText";
            this.ClearText.Size = new System.Drawing.Size(91, 31);
            this.ClearText.TabIndex = 25;
            this.ClearText.Text = "Clear text";
            this.ClearText.UseVisualStyleBackColor = true;
            this.ClearText.Click += new System.EventHandler(this.ClearText_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.ChartcomboBox);
            this.groupBox2.Controls.Add(this.clearChartButton);
            this.groupBox2.Controls.Add(this.MainChart);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.timestamp_label);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.modeLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.MSG_Status);
            this.groupBox2.Location = new System.Drawing.Point(303, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 353);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control panel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(476, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 220);
            this.panel1.TabIndex = 116;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(103, 103);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ChartcomboBox
            // 
            this.ChartcomboBox.FormattingEnabled = true;
            this.ChartcomboBox.Items.AddRange(new object[] {
            "All"});
            this.ChartcomboBox.Location = new System.Drawing.Point(741, 295);
            this.ChartcomboBox.Name = "ChartcomboBox";
            this.ChartcomboBox.Size = new System.Drawing.Size(95, 29);
            this.ChartcomboBox.TabIndex = 115;
            this.ChartcomboBox.Text = "No select";
            this.ChartcomboBox.SelectedIndexChanged += new System.EventHandler(this.ChartcomboBox_SelectedIndexChanged);
            // 
            // clearChartButton
            // 
            this.clearChartButton.Location = new System.Drawing.Point(741, 252);
            this.clearChartButton.Name = "clearChartButton";
            this.clearChartButton.Size = new System.Drawing.Size(95, 37);
            this.clearChartButton.TabIndex = 115;
            this.clearChartButton.Text = "Clear chart";
            this.clearChartButton.UseVisualStyleBackColor = true;
            this.clearChartButton.Click += new System.EventHandler(this.clearChartButton_Click);
            // 
            // MainChart
            // 
            chartArea1.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.MainChart.Legends.Add(legend1);
            this.MainChart.Location = new System.Drawing.Point(336, 24);
            this.MainChart.Name = "MainChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Vin";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Vcap";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Current";
            this.MainChart.Series.Add(series1);
            this.MainChart.Series.Add(series2);
            this.MainChart.Series.Add(series3);
            this.MainChart.Size = new System.Drawing.Size(133, 323);
            this.MainChart.TabIndex = 114;
            this.MainChart.Text = "MainChart";
            this.MainChart.Click += new System.EventHandler(this.MainChart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.currentBar);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.VscapBar);
            this.groupBox3.Controls.Add(this.currentLabel);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.VinBar);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.SM_countre_Label);
            this.groupBox3.Controls.Add(this.vscapLabel);
            this.groupBox3.Location = new System.Drawing.Point(14, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 217);
            this.groupBox3.TabIndex = 101;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step Motor status";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 23);
            this.label11.TabIndex = 134;
            this.label11.Text = "-";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(217, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 23);
            this.label10.TabIndex = 130;
            this.label10.Text = "+";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 23);
            this.label9.TabIndex = 129;
            this.label9.Text = "0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentBar
            // 
            this.currentBar.Enabled = false;
            this.currentBar.Location = new System.Drawing.Point(8, 163);
            this.currentBar.Maximum = 20000;
            this.currentBar.Minimum = -20000;
            this.currentBar.Name = "currentBar";
            this.currentBar.Size = new System.Drawing.Size(224, 56);
            this.currentBar.TabIndex = 116;
            this.currentBar.TickFrequency = 1000;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 132;
            this.label2.Text = "Current";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VscapBar
            // 
            this.VscapBar.Location = new System.Drawing.Point(9, 105);
            this.VscapBar.Maximum = 65000;
            this.VscapBar.Name = "VscapBar";
            this.VscapBar.Size = new System.Drawing.Size(223, 22);
            this.VscapBar.TabIndex = 131;
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Location = new System.Drawing.Point(106, 134);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(19, 23);
            this.currentLabel.TabIndex = 133;
            this.currentLabel.Text = "0";
            this.currentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 23);
            this.label20.TabIndex = 127;
            this.label20.Text = "SM counter";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // VinBar
            // 
            this.VinBar.Location = new System.Drawing.Point(9, 53);
            this.VinBar.Maximum = 65000;
            this.VinBar.Name = "VinBar";
            this.VinBar.Size = new System.Drawing.Size(223, 22);
            this.VinBar.TabIndex = 43;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 85);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(124, 23);
            this.label25.TabIndex = 129;
            this.label25.Text = "Supercapacitor";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SM_countre_Label
            // 
            this.SM_countre_Label.AutoSize = true;
            this.SM_countre_Label.Location = new System.Drawing.Point(213, 29);
            this.SM_countre_Label.Name = "SM_countre_Label";
            this.SM_countre_Label.Size = new System.Drawing.Size(19, 23);
            this.SM_countre_Label.TabIndex = 128;
            this.SM_countre_Label.Text = "0";
            this.SM_countre_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SM_countre_Label.Click += new System.EventHandler(this.vinLabel_Click);
            // 
            // vscapLabel
            // 
            this.vscapLabel.AutoSize = true;
            this.vscapLabel.Location = new System.Drawing.Point(106, 85);
            this.vscapLabel.Name = "vscapLabel";
            this.vscapLabel.Size = new System.Drawing.Size(19, 23);
            this.vscapLabel.TabIndex = 130;
            this.vscapLabel.Text = "0";
            this.vscapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timestamp_label
            // 
            this.timestamp_label.AutoSize = true;
            this.timestamp_label.Location = new System.Drawing.Point(110, 77);
            this.timestamp_label.Name = "timestamp_label";
            this.timestamp_label.Size = new System.Drawing.Size(41, 23);
            this.timestamp_label.TabIndex = 45;
            this.timestamp_label.Text = "N/A";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 77);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(98, 23);
            this.label.TabIndex = 43;
            this.label.Text = "Timestamp:";
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(86, 47);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(41, 23);
            this.modeLabel.TabIndex = 36;
            this.modeLabel.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "Mode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Status:";
            // 
            // MSG_Status
            // 
            this.MSG_Status.AutoSize = true;
            this.MSG_Status.Location = new System.Drawing.Point(86, 25);
            this.MSG_Status.Name = "MSG_Status";
            this.MSG_Status.Size = new System.Drawing.Size(80, 23);
            this.MSG_Status.TabIndex = 33;
            this.MSG_Status.Text = "WAITING";
            this.MSG_Status.Click += new System.EventHandler(this.MSG_Status_Click);
            // 
            // PingButton
            // 
            this.PingButton.Location = new System.Drawing.Point(6, 26);
            this.PingButton.Name = "PingButton";
            this.PingButton.Size = new System.Drawing.Size(110, 29);
            this.PingButton.TabIndex = 41;
            this.PingButton.Text = "Status request";
            this.PingButton.UseVisualStyleBackColor = true;
            this.PingButton.Click += new System.EventHandler(this.PingButton_Click);
            // 
            // AutoButton
            // 
            this.AutoButton.Location = new System.Drawing.Point(6, 56);
            this.AutoButton.Name = "AutoButton";
            this.AutoButton.Size = new System.Drawing.Size(110, 29);
            this.AutoButton.TabIndex = 42;
            this.AutoButton.Text = "Press to run";
            this.AutoButton.UseVisualStyleBackColor = true;
            this.AutoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 23);
            this.label8.TabIndex = 44;
            this.label8.Text = "Sent:";
            // 
            // message_sent_label
            // 
            this.message_sent_label.AutoSize = true;
            this.message_sent_label.Location = new System.Drawing.Point(73, 94);
            this.message_sent_label.Name = "message_sent_label";
            this.message_sent_label.Size = new System.Drawing.Size(19, 23);
            this.message_sent_label.TabIndex = 46;
            this.message_sent_label.Text = "0";
            // 
            // message_recieved_label
            // 
            this.message_recieved_label.AutoSize = true;
            this.message_recieved_label.Location = new System.Drawing.Point(73, 113);
            this.message_recieved_label.Name = "message_recieved_label";
            this.message_recieved_label.Size = new System.Drawing.Size(19, 23);
            this.message_recieved_label.TabIndex = 48;
            this.message_recieved_label.Text = "0";
            // 
            // message_error_label
            // 
            this.message_error_label.AutoSize = true;
            this.message_error_label.Location = new System.Drawing.Point(73, 130);
            this.message_error_label.Name = "message_error_label";
            this.message_error_label.Size = new System.Drawing.Size(19, 23);
            this.message_error_label.TabIndex = 50;
            this.message_error_label.Text = "0";
            this.message_error_label.Click += new System.EventHandler(this.message_error_label_Click);
            // 
            // reset_counter_button
            // 
            this.reset_counter_button.Location = new System.Drawing.Point(150, 56);
            this.reset_counter_button.Name = "reset_counter_button";
            this.reset_counter_button.Size = new System.Drawing.Size(123, 29);
            this.reset_counter_button.TabIndex = 51;
            this.reset_counter_button.Text = "Reset counter";
            this.reset_counter_button.UseVisualStyleBackColor = true;
            this.reset_counter_button.Click += new System.EventHandler(this.reset_counter_button_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 23);
            this.label14.TabIndex = 52;
            this.label14.Text = "Received:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 23);
            this.label15.TabIndex = 53;
            this.label15.Text = "Error:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.IDWriteButton);
            this.groupBox9.Controls.Add(this.VersionTextBox);
            this.groupBox9.Controls.Add(this.SerialNumberTextBox);
            this.groupBox9.Controls.Add(this.PartNumberTextBox);
            this.groupBox9.Controls.Add(this.DescriptionTextBox);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Controls.Add(this.label24);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.ReadIDbutton);
            this.groupBox9.Location = new System.Drawing.Point(602, 367);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(273, 163);
            this.groupBox9.TabIndex = 112;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Device ID";
            // 
            // IDWriteButton
            // 
            this.IDWriteButton.Location = new System.Drawing.Point(218, 90);
            this.IDWriteButton.Name = "IDWriteButton";
            this.IDWriteButton.Size = new System.Drawing.Size(47, 56);
            this.IDWriteButton.TabIndex = 112;
            this.IDWriteButton.Text = "Write ID";
            this.IDWriteButton.UseVisualStyleBackColor = true;
            this.IDWriteButton.Click += new System.EventHandler(this.IDWriteButton_Click);
            // 
            // VersionTextBox
            // 
            this.VersionTextBox.Location = new System.Drawing.Point(96, 121);
            this.VersionTextBox.Name = "VersionTextBox";
            this.VersionTextBox.ReadOnly = true;
            this.VersionTextBox.Size = new System.Drawing.Size(117, 29);
            this.VersionTextBox.TabIndex = 59;
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.Location = new System.Drawing.Point(96, 90);
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(117, 29);
            this.SerialNumberTextBox.TabIndex = 58;
            // 
            // PartNumberTextBox
            // 
            this.PartNumberTextBox.Location = new System.Drawing.Point(96, 60);
            this.PartNumberTextBox.Name = "PartNumberTextBox";
            this.PartNumberTextBox.Size = new System.Drawing.Size(117, 29);
            this.PartNumberTextBox.TabIndex = 57;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(96, 29);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(117, 29);
            this.DescriptionTextBox.TabIndex = 56;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 23);
            this.label21.TabIndex = 55;
            this.label21.Text = "Description:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(109, 23);
            this.label23.TabIndex = 37;
            this.label23.Text = "Part number:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(21, 125);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 23);
            this.label24.TabIndex = 38;
            this.label24.Text = "FW version:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(4, 94);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(120, 23);
            this.label27.TabIndex = 53;
            this.label27.Text = "Serial number:";
            // 
            // ReadIDbutton
            // 
            this.ReadIDbutton.Location = new System.Drawing.Point(218, 29);
            this.ReadIDbutton.Name = "ReadIDbutton";
            this.ReadIDbutton.Size = new System.Drawing.Size(47, 56);
            this.ReadIDbutton.TabIndex = 52;
            this.ReadIDbutton.Text = "Read ID";
            this.ReadIDbutton.UseVisualStyleBackColor = true;
            this.ReadIDbutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.moveMotorTest);
            this.groupBox10.Controls.Add(this.ResetButton);
            this.groupBox10.Controls.Add(this.PingButton);
            this.groupBox10.Controls.Add(this.AutoButton);
            this.groupBox10.Controls.Add(this.reset_counter_button);
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Controls.Add(this.label14);
            this.groupBox10.Controls.Add(this.message_sent_label);
            this.groupBox10.Controls.Add(this.message_error_label);
            this.groupBox10.Controls.Add(this.message_recieved_label);
            this.groupBox10.Location = new System.Drawing.Point(303, 367);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(271, 163);
            this.groupBox10.TabIndex = 113;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Message panel";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(150, 26);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(123, 29);
            this.ResetButton.TabIndex = 117;
            this.ResetButton.Text = "Reset device";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label13);
            this.groupBox11.Controls.Add(this.calibCurrentButton);
            this.groupBox11.Controls.Add(this.calibVoltageButton);
            this.groupBox11.Controls.Add(this.label12);
            this.groupBox11.Controls.Add(this.calibTextBox);
            this.groupBox11.Controls.Add(this.openModeButton);
            this.groupBox11.Controls.Add(this.closeModeButton);
            this.groupBox11.Controls.Add(this.autoModeButton);
            this.groupBox11.Location = new System.Drawing.Point(895, 367);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(250, 163);
            this.groupBox11.TabIndex = 114;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Command panel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(119, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 23);
            this.label13.TabIndex = 119;
            this.label13.Text = "Calibration";
            // 
            // calibCurrentButton
            // 
            this.calibCurrentButton.Location = new System.Drawing.Point(101, 130);
            this.calibCurrentButton.Name = "calibCurrentButton";
            this.calibCurrentButton.Size = new System.Drawing.Size(134, 28);
            this.calibCurrentButton.TabIndex = 118;
            this.calibCurrentButton.Text = "Calib current";
            this.calibCurrentButton.UseVisualStyleBackColor = true;
            this.calibCurrentButton.Click += new System.EventHandler(this.calibCurrentButton_Click);
            // 
            // calibVoltageButton
            // 
            this.calibVoltageButton.Location = new System.Drawing.Point(113, 98);
            this.calibVoltageButton.Name = "calibVoltageButton";
            this.calibVoltageButton.Size = new System.Drawing.Size(122, 28);
            this.calibVoltageButton.TabIndex = 116;
            this.calibVoltageButton.Text = "Calib voltage";
            this.calibVoltageButton.UseVisualStyleBackColor = true;
            this.calibVoltageButton.Click += new System.EventHandler(this.calibButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 23);
            this.label12.TabIndex = 107;
            this.label12.Text = "Work mode";
            // 
            // calibTextBox
            // 
            this.calibTextBox.Location = new System.Drawing.Point(122, 64);
            this.calibTextBox.Name = "calibTextBox";
            this.calibTextBox.Size = new System.Drawing.Size(92, 29);
            this.calibTextBox.TabIndex = 115;
            // 
            // openModeButton
            // 
            this.openModeButton.AutoSize = true;
            this.openModeButton.Location = new System.Drawing.Point(6, 81);
            this.openModeButton.Name = "openModeButton";
            this.openModeButton.Size = new System.Drawing.Size(114, 27);
            this.openModeButton.TabIndex = 106;
            this.openModeButton.TabStop = true;
            this.openModeButton.Text = "Open relay";
            this.openModeButton.UseVisualStyleBackColor = true;
            this.openModeButton.CheckedChanged += new System.EventHandler(this.openModeButton_CheckedChanged);
            // 
            // closeModeButton
            // 
            this.closeModeButton.AutoSize = true;
            this.closeModeButton.Location = new System.Drawing.Point(6, 102);
            this.closeModeButton.Name = "closeModeButton";
            this.closeModeButton.Size = new System.Drawing.Size(113, 27);
            this.closeModeButton.TabIndex = 105;
            this.closeModeButton.TabStop = true;
            this.closeModeButton.Text = "Close relay";
            this.closeModeButton.UseVisualStyleBackColor = true;
            this.closeModeButton.CheckedChanged += new System.EventHandler(this.closeModeButton_CheckedChanged);
            // 
            // autoModeButton
            // 
            this.autoModeButton.AutoSize = true;
            this.autoModeButton.Location = new System.Drawing.Point(6, 60);
            this.autoModeButton.Name = "autoModeButton";
            this.autoModeButton.Size = new System.Drawing.Size(117, 27);
            this.autoModeButton.TabIndex = 104;
            this.autoModeButton.TabStop = true;
            this.autoModeButton.Text = "Auto mode";
            this.autoModeButton.UseVisualStyleBackColor = true;
            this.autoModeButton.CheckedChanged += new System.EventHandler(this.autoModeButton_CheckedChanged);
            // 
            // moveMotorTest
            // 
            this.moveMotorTest.Location = new System.Drawing.Point(155, 97);
            this.moveMotorTest.Name = "moveMotorTest";
            this.moveMotorTest.Size = new System.Drawing.Size(110, 29);
            this.moveMotorTest.TabIndex = 118;
            this.moveMotorTest.Text = "move";
            this.moveMotorTest.UseVisualStyleBackColor = true;
            this.moveMotorTest.Click += new System.EventHandler(this.moveMotorTest_Click);
            // 
            // elevator_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1159, 589);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "elevator_control";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Tevel Engineering Team- SuperCapacitor module control V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentBar)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.ProgressBar progressBar_statusBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ComboBox comboBox_comPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_textSent;
        private System.Windows.Forms.RichTextBox richTextBox_textReceiver;
        private System.Windows.Forms.Button button_send;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClearText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label MSG_Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Button PingButton;
        private System.Windows.Forms.Button AutoButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label timestamp_label;
        private System.Windows.Forms.Label message_sent_label;
        private System.Windows.Forms.Label message_recieved_label;
        private System.Windows.Forms.Label message_error_label;
        private System.Windows.Forms.Button reset_counter_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar VinBar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button IDWriteButton;
        private System.Windows.Forms.TextBox VersionTextBox;
        private System.Windows.Forms.TextBox SerialNumberTextBox;
        private System.Windows.Forms.TextBox PartNumberTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button ReadIDbutton;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Button clearChartButton;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label vscapLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label SM_countre_Label;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox ChartcomboBox;
        private System.Windows.Forms.ProgressBar VscapBar;
        private System.Windows.Forms.RadioButton openModeButton;
        private System.Windows.Forms.RadioButton closeModeButton;
        private System.Windows.Forms.RadioButton autoModeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.TrackBar currentBar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button calibVoltageButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox calibTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button calibCurrentButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button moveMotorTest;
    }
}

