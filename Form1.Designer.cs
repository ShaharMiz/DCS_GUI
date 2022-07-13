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
            this.clearPanel1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ChartcomboBox = new System.Windows.Forms.ComboBox();
            this.clearChartButton = new System.Windows.Forms.Button();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stopStepMotor = new System.Windows.Forms.Button();
            this.counterClockwise = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.clockwise = new System.Windows.Forms.Button();
            this.step_angle_Label = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.SM_countre_Label = new System.Windows.Forms.Label();
            this.current_angle_Label = new System.Windows.Forms.Label();
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
            this.stopCalib = new System.Windows.Forms.Button();
            this.startCalib = new System.Windows.Forms.Button();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.script3_button = new System.Windows.Forms.Button();
            this.script2_button = new System.Windows.Forms.Button();
            this.script1_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.label4.Size = new System.Drawing.Size(58, 17);
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
            this.comboBox_baudRate.Size = new System.Drawing.Size(77, 25);
            this.comboBox_baudRate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "BAUD RATE :";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(14, 118);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(93, 15);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "DISCONNECTED";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_comPort
            // 
            this.comboBox_comPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Location = new System.Drawing.Point(122, 22);
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.Size = new System.Drawing.Size(77, 25);
            this.comboBox_comPort.TabIndex = 1;
            this.comboBox_comPort.Click += new System.EventHandler(this.comboBox_comPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM PORT :";
            // 
            // textBox_textSent
            // 
            this.textBox_textSent.Location = new System.Drawing.Point(3, 491);
            this.textBox_textSent.Name = "textBox_textSent";
            this.textBox_textSent.Size = new System.Drawing.Size(171, 25);
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
            this.label7.Size = new System.Drawing.Size(106, 20);
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
            this.groupBox1.Size = new System.Drawing.Size(289, 573);
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
            this.groupBox2.Controls.Add(this.clearPanel1);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.ChartcomboBox);
            this.groupBox2.Controls.Add(this.clearChartButton);
            this.groupBox2.Controls.Add(this.MainChart);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.MSG_Status);
            this.groupBox2.Location = new System.Drawing.Point(303, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 353);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control panel";
            // 
            // clearPanel1
            // 
            this.clearPanel1.Location = new System.Drawing.Point(741, 209);
            this.clearPanel1.Name = "clearPanel1";
            this.clearPanel1.Size = new System.Drawing.Size(95, 37);
            this.clearPanel1.TabIndex = 117;
            this.clearPanel1.Text = "Clear panel";
            this.clearPanel1.UseVisualStyleBackColor = true;
            this.clearPanel1.Click += new System.EventHandler(this.clearPanel1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(477, 86);
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
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
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
            this.ChartcomboBox.Size = new System.Drawing.Size(95, 25);
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
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stopStepMotor);
            this.groupBox3.Controls.Add(this.counterClockwise);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.clockwise);
            this.groupBox3.Controls.Add(this.step_angle_Label);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.SM_countre_Label);
            this.groupBox3.Controls.Add(this.current_angle_Label);
            this.groupBox3.Location = new System.Drawing.Point(14, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 217);
            this.groupBox3.TabIndex = 101;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step Motor status";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // stopStepMotor
            // 
            this.stopStepMotor.Location = new System.Drawing.Point(10, 169);
            this.stopStepMotor.Name = "stopStepMotor";
            this.stopStepMotor.Size = new System.Drawing.Size(165, 29);
            this.stopStepMotor.TabIndex = 134;
            this.stopStepMotor.Text = "stop";
            this.stopStepMotor.UseVisualStyleBackColor = true;
            this.stopStepMotor.Click += new System.EventHandler(this.stopStepMotor_Click);
            // 
            // counterClockwise
            // 
            this.counterClockwise.Location = new System.Drawing.Point(10, 134);
            this.counterClockwise.Name = "counterClockwise";
            this.counterClockwise.Size = new System.Drawing.Size(165, 29);
            this.counterClockwise.TabIndex = 119;
            this.counterClockwise.Text = "counter clockwise";
            this.counterClockwise.UseVisualStyleBackColor = true;
            this.counterClockwise.Click += new System.EventHandler(this.counterClockwise_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 132;
            this.label2.Text = "step angle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockwise
            // 
            this.clockwise.Location = new System.Drawing.Point(10, 102);
            this.clockwise.Name = "clockwise";
            this.clockwise.Size = new System.Drawing.Size(165, 29);
            this.clockwise.TabIndex = 118;
            this.clockwise.Text = "clockwise";
            this.clockwise.UseVisualStyleBackColor = true;
            this.clockwise.Click += new System.EventHandler(this.clockwise_Click);
            // 
            // step_angle_Label
            // 
            this.step_angle_Label.AutoSize = true;
            this.step_angle_Label.Location = new System.Drawing.Point(156, 76);
            this.step_angle_Label.Name = "step_angle_Label";
            this.step_angle_Label.Size = new System.Drawing.Size(15, 17);
            this.step_angle_Label.TabIndex = 133;
            this.step_angle_Label.Text = "0";
            this.step_angle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 17);
            this.label20.TabIndex = 127;
            this.label20.Text = "SM counter";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 52);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(85, 17);
            this.label25.TabIndex = 129;
            this.label25.Text = "current angle";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SM_countre_Label
            // 
            this.SM_countre_Label.AutoSize = true;
            this.SM_countre_Label.Location = new System.Drawing.Point(156, 27);
            this.SM_countre_Label.Name = "SM_countre_Label";
            this.SM_countre_Label.Size = new System.Drawing.Size(15, 17);
            this.SM_countre_Label.TabIndex = 128;
            this.SM_countre_Label.Text = "0";
            this.SM_countre_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // current_angle_Label
            // 
            this.current_angle_Label.AutoSize = true;
            this.current_angle_Label.Location = new System.Drawing.Point(156, 53);
            this.current_angle_Label.Name = "current_angle_Label";
            this.current_angle_Label.Size = new System.Drawing.Size(15, 17);
            this.current_angle_Label.TabIndex = 130;
            this.current_angle_Label.Text = "0";
            this.current_angle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Status:";
            // 
            // MSG_Status
            // 
            this.MSG_Status.AutoSize = true;
            this.MSG_Status.Location = new System.Drawing.Point(86, 25);
            this.MSG_Status.Name = "MSG_Status";
            this.MSG_Status.Size = new System.Drawing.Size(59, 17);
            this.MSG_Status.TabIndex = 33;
            this.MSG_Status.Text = "WAITING";
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
            this.label8.Location = new System.Drawing.Point(10, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "Sent:";
            // 
            // message_sent_label
            // 
            this.message_sent_label.AutoSize = true;
            this.message_sent_label.Location = new System.Drawing.Point(108, 94);
            this.message_sent_label.Name = "message_sent_label";
            this.message_sent_label.Size = new System.Drawing.Size(15, 17);
            this.message_sent_label.TabIndex = 46;
            this.message_sent_label.Text = "0";
            // 
            // message_recieved_label
            // 
            this.message_recieved_label.AutoSize = true;
            this.message_recieved_label.Location = new System.Drawing.Point(108, 117);
            this.message_recieved_label.Name = "message_recieved_label";
            this.message_recieved_label.Size = new System.Drawing.Size(15, 17);
            this.message_recieved_label.TabIndex = 48;
            this.message_recieved_label.Text = "0";
            // 
            // message_error_label
            // 
            this.message_error_label.AutoSize = true;
            this.message_error_label.Location = new System.Drawing.Point(108, 143);
            this.message_error_label.Name = "message_error_label";
            this.message_error_label.Size = new System.Drawing.Size(15, 17);
            this.message_error_label.TabIndex = 50;
            this.message_error_label.Text = "0";
            // 
            // reset_counter_button
            // 
            this.reset_counter_button.Location = new System.Drawing.Point(124, 56);
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
            this.label14.Location = new System.Drawing.Point(10, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 17);
            this.label14.TabIndex = 52;
            this.label14.Text = "Received:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 17);
            this.label15.TabIndex = 53;
            this.label15.Text = "Error:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.stopCalib);
            this.groupBox9.Controls.Add(this.startCalib);
            this.groupBox9.Location = new System.Drawing.Point(590, 418);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(123, 163);
            this.groupBox9.TabIndex = 112;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Clibration";
            // 
            // stopCalib
            // 
            this.stopCalib.Location = new System.Drawing.Point(6, 63);
            this.stopCalib.Name = "stopCalib";
            this.stopCalib.Size = new System.Drawing.Size(110, 29);
            this.stopCalib.TabIndex = 119;
            this.stopCalib.Text = "stop calib";
            this.stopCalib.UseVisualStyleBackColor = true;
            this.stopCalib.Click += new System.EventHandler(this.stopCalib_Click);
            // 
            // startCalib
            // 
            this.startCalib.Location = new System.Drawing.Point(6, 28);
            this.startCalib.Name = "startCalib";
            this.startCalib.Size = new System.Drawing.Size(110, 29);
            this.startCalib.TabIndex = 118;
            this.startCalib.Text = "start calib";
            this.startCalib.UseVisualStyleBackColor = true;
            this.startCalib.Click += new System.EventHandler(this.startCalib_Click);
            // 
            // groupBox10
            // 
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
            this.groupBox10.Location = new System.Drawing.Point(303, 418);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(271, 163);
            this.groupBox10.TabIndex = 113;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Message panel";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(124, 26);
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
            this.groupBox11.Location = new System.Drawing.Point(967, 394);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(178, 187);
            this.groupBox11.TabIndex = 114;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Command panel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(121, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
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
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 107;
            this.label12.Text = "Work mode";
            // 
            // calibTextBox
            // 
            this.calibTextBox.Location = new System.Drawing.Point(122, 64);
            this.calibTextBox.Name = "calibTextBox";
            this.calibTextBox.Size = new System.Drawing.Size(92, 25);
            this.calibTextBox.TabIndex = 115;
            // 
            // openModeButton
            // 
            this.openModeButton.AutoSize = true;
            this.openModeButton.Location = new System.Drawing.Point(6, 81);
            this.openModeButton.Name = "openModeButton";
            this.openModeButton.Size = new System.Drawing.Size(90, 21);
            this.openModeButton.TabIndex = 106;
            this.openModeButton.Text = "Open relay";
            this.openModeButton.UseVisualStyleBackColor = true;
            this.openModeButton.CheckedChanged += new System.EventHandler(this.openModeButton_CheckedChanged);
            // 
            // closeModeButton
            // 
            this.closeModeButton.AutoSize = true;
            this.closeModeButton.Location = new System.Drawing.Point(6, 102);
            this.closeModeButton.Name = "closeModeButton";
            this.closeModeButton.Size = new System.Drawing.Size(90, 21);
            this.closeModeButton.TabIndex = 105;
            this.closeModeButton.Text = "Close relay";
            this.closeModeButton.UseVisualStyleBackColor = true;
            this.closeModeButton.CheckedChanged += new System.EventHandler(this.closeModeButton_CheckedChanged);
            // 
            // autoModeButton
            // 
            this.autoModeButton.AutoSize = true;
            this.autoModeButton.Location = new System.Drawing.Point(6, 60);
            this.autoModeButton.Name = "autoModeButton";
            this.autoModeButton.Size = new System.Drawing.Size(91, 21);
            this.autoModeButton.TabIndex = 104;
            this.autoModeButton.Text = "Auto mode";
            this.autoModeButton.UseVisualStyleBackColor = true;
            this.autoModeButton.CheckedChanged += new System.EventHandler(this.autoModeButton_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.script3_button);
            this.groupBox4.Controls.Add(this.script2_button);
            this.groupBox4.Controls.Add(this.script1_button);
            this.groupBox4.Location = new System.Drawing.Point(719, 418);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 163);
            this.groupBox4.TabIndex = 120;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Script panel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 121;
            this.label6.Text = "STATUS";
            // 
            // script3_button
            // 
            this.script3_button.Location = new System.Drawing.Point(6, 125);
            this.script3_button.Name = "script3_button";
            this.script3_button.Size = new System.Drawing.Size(110, 29);
            this.script3_button.TabIndex = 120;
            this.script3_button.Text = "script 3";
            this.script3_button.UseVisualStyleBackColor = true;
            this.script3_button.Click += new System.EventHandler(this.script3_button_Click);
            // 
            // script2_button
            // 
            this.script2_button.Location = new System.Drawing.Point(6, 88);
            this.script2_button.Name = "script2_button";
            this.script2_button.Size = new System.Drawing.Size(110, 29);
            this.script2_button.TabIndex = 119;
            this.script2_button.Text = "script 2";
            this.script2_button.UseVisualStyleBackColor = true;
            this.script2_button.Click += new System.EventHandler(this.script2_button_Click);
            // 
            // script1_button
            // 
            this.script1_button.Location = new System.Drawing.Point(6, 49);
            this.script1_button.Name = "script1_button";
            this.script1_button.Size = new System.Drawing.Size(110, 29);
            this.script1_button.TabIndex = 118;
            this.script1_button.Text = "script 1";
            this.script1_button.UseVisualStyleBackColor = true;
            this.script1_button.Click += new System.EventHandler(this.script1_button_Click);
            // 
            // elevator_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1159, 589);
            this.Controls.Add(this.groupBox4);
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
            this.Text = " DCS - Final Project";
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
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Button PingButton;
        private System.Windows.Forms.Button AutoButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label message_sent_label;
        private System.Windows.Forms.Label message_recieved_label;
        private System.Windows.Forms.Label message_error_label;
        private System.Windows.Forms.Button reset_counter_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Button clearChartButton;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label current_angle_Label;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label SM_countre_Label;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox ChartcomboBox;
        private System.Windows.Forms.RadioButton openModeButton;
        private System.Windows.Forms.RadioButton closeModeButton;
        private System.Windows.Forms.RadioButton autoModeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label step_angle_Label;
        private System.Windows.Forms.Button calibVoltageButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox calibTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button calibCurrentButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button startCalib;
        private System.Windows.Forms.Button stopCalib;
        private System.Windows.Forms.Button counterClockwise;
        private System.Windows.Forms.Button clockwise;
        private System.Windows.Forms.Button stopStepMotor;
        private System.Windows.Forms.Button clearPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button script3_button;
        private System.Windows.Forms.Button script2_button;
        private System.Windows.Forms.Button script1_button;
        private System.Windows.Forms.Label label6;
    }
}

