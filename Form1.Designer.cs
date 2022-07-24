namespace Pneumatic_Control
{
    partial class DCS_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DCS_control));
            this.button_open = new System.Windows.Forms.Button();
            this.progressBar_statusBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.comboBox_comPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_textReceiver = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearText = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.PingButton = new System.Windows.Forms.Button();
            this.AutoButton = new System.Windows.Forms.Button();
            this.reset_counter_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.message_sent_label = new System.Windows.Forms.Label();
            this.message_recieved_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.clearPanel1 = new System.Windows.Forms.Button();
            this.JoystickPainter_start = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ManualControl_start = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.run_script_3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.run_script_2 = new System.Windows.Forms.Button();
            this.left_1 = new System.Windows.Forms.Label();
            this.run_script_1 = new System.Windows.Forms.Button();
            this.left_2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.left_3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.right_1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.right_2 = new System.Windows.Forms.Label();
            this.pointer_3 = new System.Windows.Forms.Label();
            this.right_3 = new System.Windows.Forms.Label();
            this.pointer_2 = new System.Windows.Forms.Label();
            this.pointer_1 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.script1_button = new System.Windows.Forms.Button();
            this.script2_button = new System.Windows.Forms.Button();
            this.script3_button = new System.Windows.Forms.Button();
            this.DIS_ACK_script1 = new System.Windows.Forms.Label();
            this.DIS_ACK_script2 = new System.Windows.Forms.Label();
            this.DIS_ACK_script3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.stopStepMotor = new System.Windows.Forms.Button();
            this.counterClockwise = new System.Windows.Forms.Button();
            this.clockwise = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.stopCalib = new System.Windows.Forms.Button();
            this.startCalib = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.step_angle_Label = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.SM_countre_Label = new System.Windows.Forms.Label();
            this.current_angle_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MSG_Status = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(212, 22);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(71, 55);
            this.button_open.TabIndex = 7;
            this.button_open.Text = "OPEN";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // progressBar_statusBar
            // 
            this.progressBar_statusBar.Location = new System.Drawing.Point(101, 104);
            this.progressBar_statusBar.Name = "progressBar_statusBar";
            this.progressBar_statusBar.Size = new System.Drawing.Size(55, 23);
            this.progressBar_statusBar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
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
            this.comboBox_baudRate.Location = new System.Drawing.Point(129, 62);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(77, 36);
            this.comboBox_baudRate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "BAUD RATE :";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(14, 139);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(142, 25);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "DISCONNECTED";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_comPort
            // 
            this.comboBox_comPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Location = new System.Drawing.Point(129, 20);
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.Size = new System.Drawing.Size(77, 36);
            this.comboBox_comPort.TabIndex = 1;
            this.comboBox_comPort.Click += new System.EventHandler(this.comboBox_comPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM PORT :";
            // 
            // richTextBox_textReceiver
            // 
            this.richTextBox_textReceiver.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_textReceiver.Location = new System.Drawing.Point(0, 205);
            this.richTextBox_textReceiver.Name = "richTextBox_textReceiver";
            this.richTextBox_textReceiver.Size = new System.Drawing.Size(272, 348);
            this.richTextBox_textReceiver.TabIndex = 2;
            this.richTextBox_textReceiver.Text = "";
            this.richTextBox_textReceiver.TextChanged += new System.EventHandler(this.richTextBox_textReceiver_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "Received data:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearText);
            this.groupBox1.Controls.Add(this.comboBox_comPort);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox10);
            this.groupBox1.Controls.Add(this.label_status);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_baudRate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.progressBar_statusBar);
            this.groupBox1.Controls.Add(this.button_open);
            this.groupBox1.Controls.Add(this.richTextBox_textReceiver);
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 725);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication";
            // 
            // ClearText
            // 
            this.ClearText.Location = new System.Drawing.Point(181, 135);
            this.ClearText.Name = "ClearText";
            this.ClearText.Size = new System.Drawing.Size(91, 42);
            this.ClearText.TabIndex = 25;
            this.ClearText.Text = "Clear text";
            this.ClearText.UseVisualStyleBackColor = true;
            this.ClearText.Click += new System.EventHandler(this.ClearText_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.PingButton);
            this.groupBox10.Controls.Add(this.AutoButton);
            this.groupBox10.Controls.Add(this.reset_counter_button);
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Controls.Add(this.label14);
            this.groupBox10.Controls.Add(this.message_sent_label);
            this.groupBox10.Controls.Add(this.message_recieved_label);
            this.groupBox10.Location = new System.Drawing.Point(1, 557);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(271, 162);
            this.groupBox10.TabIndex = 113;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Message panel";
            // 
            // PingButton
            // 
            this.PingButton.Location = new System.Drawing.Point(6, 26);
            this.PingButton.Name = "PingButton";
            this.PingButton.Size = new System.Drawing.Size(110, 35);
            this.PingButton.TabIndex = 41;
            this.PingButton.Text = "Status request";
            this.PingButton.UseVisualStyleBackColor = true;
            this.PingButton.Click += new System.EventHandler(this.PingButton_Click);
            // 
            // AutoButton
            // 
            this.AutoButton.Location = new System.Drawing.Point(6, 56);
            this.AutoButton.Name = "AutoButton";
            this.AutoButton.Size = new System.Drawing.Size(110, 35);
            this.AutoButton.TabIndex = 42;
            this.AutoButton.Text = "Press to run";
            this.AutoButton.UseVisualStyleBackColor = true;
            this.AutoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // reset_counter_button
            // 
            this.reset_counter_button.Location = new System.Drawing.Point(123, 28);
            this.reset_counter_button.Name = "reset_counter_button";
            this.reset_counter_button.Size = new System.Drawing.Size(123, 33);
            this.reset_counter_button.TabIndex = 51;
            this.reset_counter_button.Text = "Reset counter";
            this.reset_counter_button.UseVisualStyleBackColor = true;
            this.reset_counter_button.Click += new System.EventHandler(this.reset_counter_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 28);
            this.label8.TabIndex = 44;
            this.label8.Text = "Sent:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 28);
            this.label14.TabIndex = 52;
            this.label14.Text = "Received:";
            // 
            // message_sent_label
            // 
            this.message_sent_label.AutoSize = true;
            this.message_sent_label.Location = new System.Drawing.Point(108, 94);
            this.message_sent_label.Name = "message_sent_label";
            this.message_sent_label.Size = new System.Drawing.Size(23, 28);
            this.message_sent_label.TabIndex = 46;
            this.message_sent_label.Text = "0";
            // 
            // message_recieved_label
            // 
            this.message_recieved_label.AutoSize = true;
            this.message_recieved_label.Location = new System.Drawing.Point(108, 117);
            this.message_recieved_label.Name = "message_recieved_label";
            this.message_recieved_label.Size = new System.Drawing.Size(23, 28);
            this.message_recieved_label.TabIndex = 48;
            this.message_recieved_label.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.MSG_Status);
            this.groupBox2.Location = new System.Drawing.Point(303, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 655);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control panel";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.clearPanel1);
            this.groupBox7.Controls.Add(this.JoystickPainter_start);
            this.groupBox7.Location = new System.Drawing.Point(294, 189);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(159, 131);
            this.groupBox7.TabIndex = 121;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Joystick Painter";
            // 
            // clearPanel1
            // 
            this.clearPanel1.Location = new System.Drawing.Point(15, 76);
            this.clearPanel1.Name = "clearPanel1";
            this.clearPanel1.Size = new System.Drawing.Size(110, 42);
            this.clearPanel1.TabIndex = 117;
            this.clearPanel1.Text = "Clear panel";
            this.clearPanel1.UseVisualStyleBackColor = true;
            this.clearPanel1.Click += new System.EventHandler(this.clearPanel1_Click);
            // 
            // JoystickPainter_start
            // 
            this.JoystickPainter_start.Location = new System.Drawing.Point(15, 32);
            this.JoystickPainter_start.Name = "JoystickPainter_start";
            this.JoystickPainter_start.Size = new System.Drawing.Size(110, 38);
            this.JoystickPainter_start.TabIndex = 119;
            this.JoystickPainter_start.Text = "start";
            this.JoystickPainter_start.UseVisualStyleBackColor = true;
            this.JoystickPainter_start.Click += new System.EventHandler(this.JoystickPainter_start_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ManualControl_start);
            this.groupBox6.Location = new System.Drawing.Point(135, 189);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(153, 131);
            this.groupBox6.TabIndex = 120;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Manual Motor Control";
            // 
            // ManualControl_start
            // 
            this.ManualControl_start.Location = new System.Drawing.Point(14, 79);
            this.ManualControl_start.Name = "ManualControl_start";
            this.ManualControl_start.Size = new System.Drawing.Size(110, 37);
            this.ManualControl_start.TabIndex = 119;
            this.ManualControl_start.Text = "start";
            this.ManualControl_start.UseVisualStyleBackColor = true;
            this.ManualControl_start.Click += new System.EventHandler(this.ManualControl_start_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox11);
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Location = new System.Drawing.Point(6, 324);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(441, 324);
            this.groupBox4.TabIndex = 120;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Script panel";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Controls.Add(this.label9);
            this.groupBox11.Controls.Add(this.run_script_3);
            this.groupBox11.Controls.Add(this.label10);
            this.groupBox11.Controls.Add(this.run_script_2);
            this.groupBox11.Controls.Add(this.left_1);
            this.groupBox11.Controls.Add(this.run_script_1);
            this.groupBox11.Controls.Add(this.left_2);
            this.groupBox11.Controls.Add(this.label16);
            this.groupBox11.Controls.Add(this.left_3);
            this.groupBox11.Controls.Add(this.label15);
            this.groupBox11.Controls.Add(this.right_1);
            this.groupBox11.Controls.Add(this.label6);
            this.groupBox11.Controls.Add(this.right_2);
            this.groupBox11.Controls.Add(this.pointer_3);
            this.groupBox11.Controls.Add(this.right_3);
            this.groupBox11.Controls.Add(this.pointer_2);
            this.groupBox11.Controls.Add(this.pointer_1);
            this.groupBox11.Location = new System.Drawing.Point(12, 145);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(410, 168);
            this.groupBox11.TabIndex = 124;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Run scripts";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 28);
            this.label11.TabIndex = 132;
            this.label11.Text = "POINTER";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 28);
            this.label9.TabIndex = 124;
            this.label9.Text = "LEFT ";
            // 
            // run_script_3
            // 
            this.run_script_3.Location = new System.Drawing.Point(109, 120);
            this.run_script_3.Name = "run_script_3";
            this.run_script_3.Size = new System.Drawing.Size(54, 37);
            this.run_script_3.TabIndex = 140;
            this.run_script_3.Text = "run";
            this.run_script_3.UseVisualStyleBackColor = true;
            this.run_script_3.Click += new System.EventHandler(this.run_script_3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 28);
            this.label10.TabIndex = 125;
            this.label10.Text = "RIGHT";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // run_script_2
            // 
            this.run_script_2.Location = new System.Drawing.Point(109, 79);
            this.run_script_2.Name = "run_script_2";
            this.run_script_2.Size = new System.Drawing.Size(54, 37);
            this.run_script_2.TabIndex = 139;
            this.run_script_2.Text = "run";
            this.run_script_2.UseVisualStyleBackColor = true;
            this.run_script_2.Click += new System.EventHandler(this.run_script_2_Click);
            // 
            // left_1
            // 
            this.left_1.AutoSize = true;
            this.left_1.Enabled = false;
            this.left_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left_1.Location = new System.Drawing.Point(274, 45);
            this.left_1.Name = "left_1";
            this.left_1.Size = new System.Drawing.Size(46, 25);
            this.left_1.TabIndex = 126;
            this.left_1.Text = "    --";
            this.left_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // run_script_1
            // 
            this.run_script_1.Location = new System.Drawing.Point(109, 37);
            this.run_script_1.Name = "run_script_1";
            this.run_script_1.Size = new System.Drawing.Size(54, 37);
            this.run_script_1.TabIndex = 138;
            this.run_script_1.Text = "run";
            this.run_script_1.UseVisualStyleBackColor = true;
            this.run_script_1.Click += new System.EventHandler(this.run_script_1_Click);
            // 
            // left_2
            // 
            this.left_2.AutoSize = true;
            this.left_2.Enabled = false;
            this.left_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left_2.Location = new System.Drawing.Point(274, 84);
            this.left_2.Name = "left_2";
            this.left_2.Size = new System.Drawing.Size(46, 25);
            this.left_2.TabIndex = 127;
            this.left_2.Text = "    --";
            this.left_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 28);
            this.label16.TabIndex = 137;
            this.label16.Text = "script 3:";
            // 
            // left_3
            // 
            this.left_3.AutoSize = true;
            this.left_3.Enabled = false;
            this.left_3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left_3.Location = new System.Drawing.Point(274, 122);
            this.left_3.Name = "left_3";
            this.left_3.Size = new System.Drawing.Size(46, 25);
            this.left_3.TabIndex = 128;
            this.left_3.Text = "    --";
            this.left_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 28);
            this.label15.TabIndex = 136;
            this.label15.Text = "script 2:";
            // 
            // right_1
            // 
            this.right_1.AutoSize = true;
            this.right_1.Enabled = false;
            this.right_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right_1.Location = new System.Drawing.Point(339, 44);
            this.right_1.Name = "right_1";
            this.right_1.Size = new System.Drawing.Size(46, 25);
            this.right_1.TabIndex = 129;
            this.right_1.Text = "    --";
            this.right_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 28);
            this.label6.TabIndex = 122;
            this.label6.Text = "script 1:";
            // 
            // right_2
            // 
            this.right_2.AutoSize = true;
            this.right_2.Enabled = false;
            this.right_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right_2.Location = new System.Drawing.Point(339, 81);
            this.right_2.Name = "right_2";
            this.right_2.Size = new System.Drawing.Size(46, 25);
            this.right_2.TabIndex = 130;
            this.right_2.Text = "    --";
            this.right_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointer_3
            // 
            this.pointer_3.AutoSize = true;
            this.pointer_3.Enabled = false;
            this.pointer_3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointer_3.Location = new System.Drawing.Point(194, 124);
            this.pointer_3.Name = "pointer_3";
            this.pointer_3.Size = new System.Drawing.Size(46, 25);
            this.pointer_3.TabIndex = 135;
            this.pointer_3.Text = "    --";
            this.pointer_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // right_3
            // 
            this.right_3.AutoSize = true;
            this.right_3.Enabled = false;
            this.right_3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right_3.Location = new System.Drawing.Point(339, 122);
            this.right_3.Name = "right_3";
            this.right_3.Size = new System.Drawing.Size(46, 25);
            this.right_3.TabIndex = 131;
            this.right_3.Text = "    --";
            this.right_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointer_2
            // 
            this.pointer_2.AutoSize = true;
            this.pointer_2.Enabled = false;
            this.pointer_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointer_2.Location = new System.Drawing.Point(194, 83);
            this.pointer_2.Name = "pointer_2";
            this.pointer_2.Size = new System.Drawing.Size(46, 25);
            this.pointer_2.TabIndex = 134;
            this.pointer_2.Text = "    --";
            this.pointer_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointer_1
            // 
            this.pointer_1.AutoSize = true;
            this.pointer_1.Enabled = false;
            this.pointer_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointer_1.Location = new System.Drawing.Point(194, 44);
            this.pointer_1.Name = "pointer_1";
            this.pointer_1.Size = new System.Drawing.Size(46, 25);
            this.pointer_1.TabIndex = 133;
            this.pointer_1.Text = "    --";
            this.pointer_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.script1_button);
            this.groupBox8.Controls.Add(this.script2_button);
            this.groupBox8.Controls.Add(this.script3_button);
            this.groupBox8.Controls.Add(this.DIS_ACK_script1);
            this.groupBox8.Controls.Add(this.DIS_ACK_script2);
            this.groupBox8.Controls.Add(this.DIS_ACK_script3);
            this.groupBox8.Location = new System.Drawing.Point(10, 24);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(410, 120);
            this.groupBox8.TabIndex = 120;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Load scripts";
            // 
            // script1_button
            // 
            this.script1_button.Location = new System.Drawing.Point(17, 32);
            this.script1_button.Name = "script1_button";
            this.script1_button.Size = new System.Drawing.Size(103, 37);
            this.script1_button.TabIndex = 118;
            this.script1_button.Text = "script 1";
            this.script1_button.UseVisualStyleBackColor = true;
            this.script1_button.Click += new System.EventHandler(this.script1_button_Click);
            // 
            // script2_button
            // 
            this.script2_button.Location = new System.Drawing.Point(150, 33);
            this.script2_button.Name = "script2_button";
            this.script2_button.Size = new System.Drawing.Size(104, 36);
            this.script2_button.TabIndex = 119;
            this.script2_button.Text = "script 2";
            this.script2_button.UseVisualStyleBackColor = true;
            this.script2_button.Click += new System.EventHandler(this.script2_button_Click);
            // 
            // script3_button
            // 
            this.script3_button.Location = new System.Drawing.Point(285, 31);
            this.script3_button.Name = "script3_button";
            this.script3_button.Size = new System.Drawing.Size(95, 38);
            this.script3_button.TabIndex = 120;
            this.script3_button.Text = "script 3";
            this.script3_button.UseVisualStyleBackColor = true;
            this.script3_button.Click += new System.EventHandler(this.script3_button_Click);
            // 
            // DIS_ACK_script1
            // 
            this.DIS_ACK_script1.AutoSize = true;
            this.DIS_ACK_script1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS_ACK_script1.Location = new System.Drawing.Point(20, 79);
            this.DIS_ACK_script1.Name = "DIS_ACK_script1";
            this.DIS_ACK_script1.Size = new System.Drawing.Size(80, 25);
            this.DIS_ACK_script1.TabIndex = 26;
            this.DIS_ACK_script1.Text = "DIS_ACK";
            this.DIS_ACK_script1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DIS_ACK_script2
            // 
            this.DIS_ACK_script2.AutoSize = true;
            this.DIS_ACK_script2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS_ACK_script2.Location = new System.Drawing.Point(155, 79);
            this.DIS_ACK_script2.Name = "DIS_ACK_script2";
            this.DIS_ACK_script2.Size = new System.Drawing.Size(80, 25);
            this.DIS_ACK_script2.TabIndex = 122;
            this.DIS_ACK_script2.Text = "DIS_ACK";
            this.DIS_ACK_script2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DIS_ACK_script3
            // 
            this.DIS_ACK_script3.AutoSize = true;
            this.DIS_ACK_script3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIS_ACK_script3.Location = new System.Drawing.Point(295, 79);
            this.DIS_ACK_script3.Name = "DIS_ACK_script3";
            this.DIS_ACK_script3.Size = new System.Drawing.Size(80, 25);
            this.DIS_ACK_script3.TabIndex = 123;
            this.DIS_ACK_script3.Text = "DIS_ACK";
            this.DIS_ACK_script3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.stopStepMotor);
            this.groupBox5.Controls.Add(this.counterClockwise);
            this.groupBox5.Controls.Add(this.clockwise);
            this.groupBox5.Location = new System.Drawing.Point(252, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 164);
            this.groupBox5.TabIndex = 120;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Motor command";
            // 
            // stopStepMotor
            // 
            this.stopStepMotor.Location = new System.Drawing.Point(6, 114);
            this.stopStepMotor.Name = "stopStepMotor";
            this.stopStepMotor.Size = new System.Drawing.Size(165, 40);
            this.stopStepMotor.TabIndex = 134;
            this.stopStepMotor.Text = "stop";
            this.stopStepMotor.UseVisualStyleBackColor = true;
            this.stopStepMotor.Click += new System.EventHandler(this.stopStepMotor_Click);
            // 
            // counterClockwise
            // 
            this.counterClockwise.Location = new System.Drawing.Point(6, 70);
            this.counterClockwise.Name = "counterClockwise";
            this.counterClockwise.Size = new System.Drawing.Size(165, 41);
            this.counterClockwise.TabIndex = 119;
            this.counterClockwise.Text = "counter clockwise";
            this.counterClockwise.UseVisualStyleBackColor = true;
            this.counterClockwise.Click += new System.EventHandler(this.counterClockwise_Click);
            // 
            // clockwise
            // 
            this.clockwise.Location = new System.Drawing.Point(6, 29);
            this.clockwise.Name = "clockwise";
            this.clockwise.Size = new System.Drawing.Size(165, 38);
            this.clockwise.TabIndex = 118;
            this.clockwise.Text = "clockwise";
            this.clockwise.UseVisualStyleBackColor = true;
            this.clockwise.Click += new System.EventHandler(this.clockwise_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.stopCalib);
            this.groupBox9.Controls.Add(this.startCalib);
            this.groupBox9.Location = new System.Drawing.Point(6, 190);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(123, 130);
            this.groupBox9.TabIndex = 112;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Calibration";
            // 
            // stopCalib
            // 
            this.stopCalib.Location = new System.Drawing.Point(6, 80);
            this.stopCalib.Name = "stopCalib";
            this.stopCalib.Size = new System.Drawing.Size(110, 36);
            this.stopCalib.TabIndex = 119;
            this.stopCalib.Text = "stop calib";
            this.stopCalib.UseVisualStyleBackColor = true;
            this.stopCalib.Click += new System.EventHandler(this.stopCalib_Click);
            // 
            // startCalib
            // 
            this.startCalib.Location = new System.Drawing.Point(7, 38);
            this.startCalib.Name = "startCalib";
            this.startCalib.Size = new System.Drawing.Size(110, 36);
            this.startCalib.TabIndex = 118;
            this.startCalib.Text = "start calib";
            this.startCalib.UseVisualStyleBackColor = true;
            this.startCalib.Click += new System.EventHandler(this.startCalib_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.step_angle_Label);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.SM_countre_Label);
            this.groupBox3.Controls.Add(this.current_angle_Label);
            this.groupBox3.Location = new System.Drawing.Point(6, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 110);
            this.groupBox3.TabIndex = 101;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step Motor status";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 132;
            this.label2.Text = "step angle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // step_angle_Label
            // 
            this.step_angle_Label.AutoSize = true;
            this.step_angle_Label.Location = new System.Drawing.Point(138, 78);
            this.step_angle_Label.Name = "step_angle_Label";
            this.step_angle_Label.Size = new System.Drawing.Size(23, 28);
            this.step_angle_Label.TabIndex = 133;
            this.step_angle_Label.Text = "0";
            this.step_angle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 28);
            this.label20.TabIndex = 127;
            this.label20.Text = "SM counter";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 52);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(127, 28);
            this.label25.TabIndex = 129;
            this.label25.Text = "current angle";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SM_countre_Label
            // 
            this.SM_countre_Label.AutoSize = true;
            this.SM_countre_Label.Location = new System.Drawing.Point(138, 27);
            this.SM_countre_Label.Name = "SM_countre_Label";
            this.SM_countre_Label.Size = new System.Drawing.Size(23, 28);
            this.SM_countre_Label.TabIndex = 128;
            this.SM_countre_Label.Text = "0";
            this.SM_countre_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // current_angle_Label
            // 
            this.current_angle_Label.AutoSize = true;
            this.current_angle_Label.Location = new System.Drawing.Point(138, 53);
            this.current_angle_Label.Name = "current_angle_Label";
            this.current_angle_Label.Size = new System.Drawing.Size(23, 28);
            this.current_angle_Label.TabIndex = 130;
            this.current_angle_Label.Text = "0";
            this.current_angle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 28);
            this.label5.TabIndex = 34;
            this.label5.Text = "Status:";
            // 
            // MSG_Status
            // 
            this.MSG_Status.AutoSize = true;
            this.MSG_Status.Location = new System.Drawing.Point(95, 24);
            this.MSG_Status.Name = "MSG_Status";
            this.MSG_Status.Size = new System.Drawing.Size(92, 28);
            this.MSG_Status.TabIndex = 33;
            this.MSG_Status.Text = "WAITING";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(765, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 512);
            this.panel1.TabIndex = 116;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(260, 248);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(21, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label12.Location = new System.Drawing.Point(547, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(440, 45);
            this.label12.TabIndex = 133;
            this.label12.Text = "DCS - Final Project GUI";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(783, 663);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(730, 41);
            this.label13.TabIndex = 134;
            this.label13.Text = "© Copyright: Shahar Mizrahi and Tamar Oren";
            // 
            // DCS_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1299, 749);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DCS_control";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " DCS - Final Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.RichTextBox richTextBox_textReceiver;
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
        private System.Windows.Forms.Button reset_counter_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label current_angle_Label;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label SM_countre_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label step_angle_Label;
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
        private System.Windows.Forms.Label DIS_ACK_script1;
        private System.Windows.Forms.Label DIS_ACK_script3;
        private System.Windows.Forms.Label DIS_ACK_script2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label right_3;
        private System.Windows.Forms.Label right_2;
        private System.Windows.Forms.Label right_1;
        private System.Windows.Forms.Label left_3;
        private System.Windows.Forms.Label left_2;
        private System.Windows.Forms.Label left_1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button ManualControl_start;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button JoystickPainter_start;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label pointer_3;
        private System.Windows.Forms.Label pointer_2;
        private System.Windows.Forms.Label pointer_1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button run_script_3;
        private System.Windows.Forms.Button run_script_2;
        private System.Windows.Forms.Button run_script_1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox8;
    }
}

