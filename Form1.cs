using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
/////////////////////////////////////
//           Joistick !!!          //
/////////////////////////////////////
//using OpenJigWare;
/////////////////////////////////////




////// Usefully things
///
///// Right things to text box
/// richTextBox_textReceiver.Text += msg_checksum.ToString() + " Checksum correct!" + "\n";
///
///// Use this to show somthing
/// message_error_label.Text = message_error_counter.ToString();










namespace Pneumatic_Control
{
    public partial class DCS_control : Form //partial
    {
        int MSG_LENGTH = 0; // 
        const int ID_MSG_LENGTH = 70;
        const int stringSize = 16;
        byte[] serialDataIn;
        byte[] clearRXBuffer;
        int message_sent_counter = 0;
        int message_received_counter = 0;
        int message_error_counter = 0;
        private byte[] serialDataHeader;
        private byte[] numberOfReceivdByts;
        MSG_TYPE msg_type = MSG_TYPE.WAIT;
        char startChar = '0';
        const byte ASCII_TO_INT = 48;
        string MSG_LENGTH_string = "";
        /////////////////////////////////////
        //           Joistick !!!          //
        /////////////////////////////////////
        uint m_current_x = 230;
        uint m_current_y = 230;
        uint previous_x = 230;
        uint previous_y = 230;
        uint m_joistic_mode = 0;
        JOISTICK_MODES joistick_modes = JOISTICK_MODES.NUTRAL;
        /////////////////////////////////////
        //             STATE 4             //
        /////////////////////////////////////
        SCRIPT_MODE_STATE scriptNumber = SCRIPT_MODE_STATE.UNKNOWN_STATE;
        




        private enum MSG_TYPE : byte
        {
            WAIT = 0,
            SATUS,
            ACK_SCAN,
            LEFT_SCAN,
            RIGHT_SCAN,
            POINTER_SCAN
        };


        private enum DEVICE_STATUS : byte
        {
            DEVICE_UNKNOWN = 0,
            DEVICE_OK,
            DEVICE_ERROR,
            DEVICE_LOW_VOLTAGE,
            DEVICE_NO_CONFIG,
            PROG_ID,
        };

        private enum SC_CMD : byte
        {
            UNDEFINED = 0,
            STATUS,
            AUTOMAT,
            RELAY_OPEN,
            RELAY_CLOSE,
            CHARGE,
            NOT_CHARGE,
            CALIBRATION_VOLTAGE,
            CALIBRATION_CURRENT
        }

        private enum SC_MSG_STATUS : byte
        {
            UNKNOWN_CMD = 0,
            ACK,
            CHARGING_RELAYOPEN,
            CHARGING_RELAYCLOSE,
            NOT_CHARGING_RELAYOPEN,
            NOT_CHARGING_RELAYCLOSE,
            ERROR,
            ILLEGAL_OPERATION,
            BAD_MSG,
            CMD_CHECKSUM_ERROR,
            CMD_SIZE_ERROR,
            STATUS_CHECKSUM_ERROR,
            MAINTENANCE,
            UNIT_NOT_CONNECTED,
            LOW_VOLTAGE,
            RESET
        };
        private enum STATE : byte
        {
            SLEEP = 0,
            MANUAL_CONTROL,
            JOISTICK_PAINTER,
            CALIBRATION,
            SCRIPT_MODE,
            MOTOR_COMMAND
        }
        private enum CALIBRATION_STATE : byte
        {
            UNKNOWN_STATE = 0,
            START_CALIB = 1,
            STOP_CALIB = 3
        }
        private enum SCRIPT_MODE_STATE : byte
        {
            UNKNOWN_STATE = 0,
            SCRIPT1,
            SCRIPT2,
            SCRIPT3
        }
        private enum MOTOR_COMMAND_STATE : byte
        {
            UNKNOWN_STATE = 0,
            CLOCKWISE,
            COUNTER_CLOCKWISE,
            STOP_MOTOR
        }
        private enum JOISTICK_MODES : byte
        {
            NUTRAL = 1,
            DRAW,
            ERASER,
            NONE
        }
        public DCS_control()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            button_open.Enabled = true;
            progressBar_statusBar.Value = 0;
            label_status.Text = "DISCONNECTED";
            label_status.ForeColor = Color.Red;

            comboBox_baudRate.Text = "9600";
            string[] portLists = SerialPort.GetPortNames();
            comboBox_comPort.Items.AddRange(portLists);
            comboBox_comPort.SelectedIndex = comboBox_comPort.Items.Count-1;

            /////////////////////////////////////
            //           Joistick !!!          //
            /////////////////////////////////////
            //Ojw.CMessage.Init(txtMessage);
            
            panel1.Controls.Add(radioButton1);
            radioButton1.Location = new Point((int)m_current_x, (int)m_current_y);

            DIS_ACK_script1.Text = "DIS_ACK";
            DIS_ACK_script1.ForeColor = Color.Red;
            DIS_ACK_script2.Text = "DIS_ACK";
            DIS_ACK_script2.ForeColor = Color.Red;
            DIS_ACK_script3.Text = "DIS_ACK";
            DIS_ACK_script3.ForeColor = Color.Red;
            /////////////////////////////////////


        }

        private void button_open_Click(object sender, EventArgs e)
        {
            if (button_open.Text == "OPEN")
            {
                try
                {
                    serialPort1.PortName = comboBox_comPort.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox_baudRate.Text);
                    serialPort1.Open();

                    progressBar_statusBar.Value = 100;
                    label_status.Text = "CONNECTED";
                    button_open.Text = "CLOSE";
                    label_status.ForeColor = Color.Green;
                    serialPort1.DiscardInBuffer();
                }
                catch (Exception error) { MessageBox.Show(error.Message); }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    progressBar_statusBar.Value = 0;
                    label_status.Text = "DISCONNECTED";
                    button_open.Text = "OPEN";
                    label_status.ForeColor = Color.Red;
                }
                catch (Exception error) { MessageBox.Show(error.Message); }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }





        ////////////////////////////////////////////////////////////////////////////////
        ///                           RECEIVER - interupt                            ///
        ////////////////////////////////////////////////////////////////////////////////
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //serialDataIn = serialPort1.ReadExisting();
            int bytes = serialPort1.BytesToRead;
            if (serialPort1.BytesToRead > 0 && msg_type == MSG_TYPE.WAIT)
            {
                while (bytes > 10)
                {
                    serialDataHeader = new byte[1];
                    serialPort1.Read(serialDataHeader, 0, 1);
                    bytes--;
                    if (serialDataHeader[0] == '#' || serialDataHeader[0] == '<' || serialDataHeader[0] == '>' || serialDataHeader[0] == '%')
                    {
                        try
                        {
                            if(serialDataHeader[0] == '#')
                            {
                                startChar = '#';
                                msg_type = MSG_TYPE.SATUS;
                            }
                            else if(serialDataHeader[0] == '<')
                            {
                                startChar = '<';
                                msg_type = MSG_TYPE.LEFT_SCAN;
                            }
                            else if(serialDataHeader[0] == '>')
                            {
                                startChar = '>';
                                msg_type = MSG_TYPE.RIGHT_SCAN;
                            }
                            else if (serialDataHeader[0] == '%')
                            {
                                startChar = '%';
                                msg_type = MSG_TYPE.POINTER_SCAN;
                            }
                            numberOfReceivdByts = new byte[2];
                            serialPort1.Read(numberOfReceivdByts, 0, 2);
                            bytes -= 2;
                            MSG_LENGTH_string = "";
                            for (int i = 0; i < numberOfReceivdByts.Length; i++)
                            {
                                MSG_LENGTH_string += numberOfReceivdByts[i] - ASCII_TO_INT;
                            }
                            MSG_LENGTH = int.Parse(MSG_LENGTH_string);
                            break;
                        }
                        catch (Exception error)
                        {
                        }

                    }
                    else if(serialDataHeader[0] == '!')
                    {
                        try
                        {
                            startChar = '!';
                            msg_type = MSG_TYPE.ACK_SCAN;
                            break;
                        }
                        catch (Exception error)
                        {
                        }
                    }
                    else startChar = '0';
                }
            }
            if (((msg_type == MSG_TYPE.SATUS) || (msg_type == MSG_TYPE.LEFT_SCAN) || msg_type == MSG_TYPE.RIGHT_SCAN || msg_type == MSG_TYPE.POINTER_SCAN) && bytes >= (MSG_LENGTH-3))
            {
                serialDataIn = new byte[bytes];
                serialPort1.Read(serialDataIn, 0, MSG_LENGTH-3);
                //clearRXBuffer = serialPort1.ReadExisting();
                this.Invoke(new EventHandler(ShowData));
            }
            else if(msg_type == MSG_TYPE.ACK_SCAN)
            {
                this.Invoke(new EventHandler(ACK_state4));
            }

        }
        ////////////////////////////////////////
        ///            ShowData             ///
        ////////////////////////////////////////
        private void ShowData(object sender, EventArgs e)
        {
            byte[] msg_array = serialDataIn;
            uint m_stepAngle = 0;
            uint m_currentAngle = 0;
            uint m_SMcounter = 0;
            bool CRC_status = false;
            //uint m_timestamp = 0;
            int index = 0;



            richTextBox_textReceiver.Text += "------New data ------" + "\n";
            richTextBox_textReceiver.Text += startChar.ToString() + "\t|" + Enum.GetName(typeof(MSG_TYPE), msg_type) + " message\n";
            richTextBox_textReceiver.Text += MSG_LENGTH_string + "\t|" +  " number of bytes received\n";
            for (int i = 0; i < msg_array.Length; i++)
            {
                if (msg_array[i] == 0) richTextBox_textReceiver.Text += (i + 1).ToString() + ") " + "48" + "\t| " + "0" + " \n";
                else
                {
                    richTextBox_textReceiver.Text += (i + 1).ToString() + ") " + msg_array[i].ToString();
                    if (msg_array[i] > 31 && msg_array[i] < 127) richTextBox_textReceiver.Text += "\t| " + (char)msg_array[i] + " \n";
                    else richTextBox_textReceiver.Text += "\n";
                }
            }
            richTextBox_textReceiver.Text += "---------------------" + "\n";

            if (startChar == '#' || startChar == '<' || startChar == '>' || startChar == '%')
            {
                CRC_status = true;
                message_received_counter++;
                message_recieved_label.Text = message_received_counter.ToString();

                
                string message = "";
                
                for (int i = 0; i < msg_array.Length; i++)
                {
                    string msg_temp = "";
                    msg_temp += msg_array[i] - ASCII_TO_INT;
                    if (msg_temp == "-48") message += "0";
                    else if (msg_temp == "-3") message += "-";
                    else message += msg_temp;
                }
                string[] values = message.Split('-');

                
                index =0;
                if (CRC_status)
                {
                    try
                    {
                        m_stepAngle      = uint.Parse(values[0]);
                        m_currentAngle   = uint.Parse(values[1]);
                        m_SMcounter      = uint.Parse(values[2]);
                        m_current_x      = uint.Parse(values[3])/2;
                        m_current_y      = 512-uint.Parse(values[4])/2;
                        m_joistic_mode   = uint.Parse(values[5]);
                        //
                        float m_stepAngle_float = (float)m_stepAngle / 1000;
                        step_angle_Label.Text = m_stepAngle_float.ToString() + " deg";
                        float m_currentAngle_float = (float)m_currentAngle / 100;
                        current_angle_Label.Text = m_currentAngle_float.ToString() + " deg";
                        SM_countre_Label.Text = m_SMcounter.ToString();
                        
                        // JOISTICK
                        if (m_joistic_mode != 4)
                        {
                            //timer1.Interval = 100;
                            if (m_joistic_mode == 1) joistick_modes = JOISTICK_MODES.NUTRAL;
                            else if (m_joistic_mode == 2) joistick_modes = JOISTICK_MODES.DRAW;
                            else joistick_modes = JOISTICK_MODES.ERASER;
                            panel1_Paint(sender, e);
                        }
                        //else timer1.Interval = 250;

                        // STATE 4
                        if (msg_type == MSG_TYPE.LEFT_SCAN)
                        {
                            if (scriptNumber == SCRIPT_MODE_STATE.SCRIPT1) left_1.Text = m_currentAngle_float.ToString();
                            else if (scriptNumber == SCRIPT_MODE_STATE.SCRIPT2) left_2.Text = m_currentAngle_float.ToString();
                            else if (scriptNumber == SCRIPT_MODE_STATE.SCRIPT3) left_3.Text = m_currentAngle_float.ToString();
                        }
                        else if (msg_type == MSG_TYPE.RIGHT_SCAN)
                        {
                            if (scriptNumber == SCRIPT_MODE_STATE.SCRIPT1) right_1.Text = m_currentAngle_float.ToString();
                            else if (scriptNumber == SCRIPT_MODE_STATE.SCRIPT2) right_2.Text = m_currentAngle_float.ToString();
                            else if (scriptNumber == SCRIPT_MODE_STATE.SCRIPT3) right_3.Text = m_currentAngle_float.ToString();
                        }
                        else if (msg_type == MSG_TYPE.POINTER_SCAN)
                        {
                            if (scriptNumber == SCRIPT_MODE_STATE.SCRIPT1) pointer_1.Text = m_currentAngle_float.ToString();
                            else if (scriptNumber == SCRIPT_MODE_STATE.SCRIPT2) pointer_2.Text = m_currentAngle_float.ToString();
                            else if (scriptNumber == SCRIPT_MODE_STATE.SCRIPT3) pointer_3.Text = m_currentAngle_float.ToString();
                        }

                    }
                    catch (Exception error)
                    {
                    }

                }
            }
            else
            {

            }
            startChar = '0';
            msg_type = MSG_TYPE.WAIT;
        }

        

            private void richTextBox_textReceiver_TextChanged(object sender, EventArgs e)
        {
            richTextBox_textReceiver.SelectionStart = richTextBox_textReceiver.Text.Length;
            richTextBox_textReceiver.ScrollToCaret();
        }

        private void ClearText_Click(object sender, EventArgs e)
        {
            richTextBox_textReceiver.Clear();
        }
        /////////////////////////////////////
        //           STATUS button         //
        /////////////////////////////////////
        private void PingButton_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] msg = { 0, 0 ,0, 0, 0};
                serialPort1.Write("#");
                //serialPort1.Write(msg, 0, 5);
                message_sent_label.Text = (++message_sent_counter).ToString();
            }
            catch (Exception error)
            {
                AutoButton.Text = "Press to run";
                button_open.Text = "OPEN";
                MessageBox.Show(error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AutoButton.Text == "Press to run")
            {
                AutoButton.Text = "Press to stop";
            }
            else AutoButton.Text = "Press to run";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(AutoSend));
            
        }

        private void AutoSend(object sender, EventArgs e)
        {
            if (AutoButton.Text == "Press to stop")
            {
                richTextBox_textReceiver.Clear();
                PingButton_Click(sender, e);
            }
        }

        private void reset_counter_button_Click(object sender, EventArgs e)
        {
            message_sent_label.Text = (message_sent_counter=0).ToString();
            message_recieved_label.Text = (message_received_counter = 0).ToString();
        }


        private void comboBox_comPort_Click(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            comboBox_comPort.Items.Clear();
            comboBox_comPort.Items.AddRange(portLists);
            comboBox_comPort.SelectedIndex = comboBox_comPort.Items.Count - 1;
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        ///------------------------------------------------------------------///
        ///                    STATE 1 - Manual Motor Control                ///
        ///------------------------------------------------------------------///
        private void ManualControl_start_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] msg = { (byte)STATE.MANUAL_CONTROL};
                serialPort1.Write("!");
                serialPort1.Write(msg, 0, 1);
                message_sent_label.Text = (++message_sent_counter).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        ///------------------------------------------------------------------///
        ///                    STATE 2 - Joystick Painter                    ///
        ///------------------------------------------------------------------///
        private void JoystickPainter_start_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] msg = { (byte)STATE.JOISTICK_PAINTER };
                serialPort1.Write("!");
                serialPort1.Write(msg, 0, 1);
                message_sent_label.Text = (++message_sent_counter).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        ///    PANEL   ///
        private void panel1_Paint(object sender, EventArgs e)
        {
            Graphics panelObject = panel1.CreateGraphics();
            Brush black = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(black, 3);
            Brush white = new SolidBrush(Color.White);
            Pen whitePen = new Pen(white, 30);
            // Draw
            if (joistick_modes == JOISTICK_MODES.DRAW)
            {
                panelObject.DrawLine(blackPen, m_current_x, m_current_y, previous_x, previous_y);
            }
            else if (joistick_modes == JOISTICK_MODES.ERASER)
            {
                panelObject.DrawLine(whitePen, m_current_x, m_current_y, previous_x, previous_y);
            }
            // Pointer update
            radioButton1.Location = new Point((int)m_current_x, (int)m_current_y);
            // Previous point update
            previous_x = m_current_x;
            previous_y = m_current_y;
        }
        private void clearPanel1_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Refresh();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        ///------------------------------------------------------------------///
        ///                    STATE 3 - Calibration                         ///
        ///------------------------------------------------------------------///
        private void startCalib_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] msg = { (byte)STATE.CALIBRATION , (byte)CALIBRATION_STATE.START_CALIB };
                serialPort1.Write("!");
                serialPort1.Write(msg, 0, 2);
                message_sent_label.Text = (++message_sent_counter).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void stopCalib_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] msg = { (byte)STATE.CALIBRATION, (byte)CALIBRATION_STATE.STOP_CALIB };
                serialPort1.Write("!");
                serialPort1.Write(msg, 0, 2);
                message_sent_label.Text = (++message_sent_counter).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        ///------------------------------------------------------------------///
        ///                       STATE 4 - Script                           ///
        ///------------------------------------------------------------------///
        ///
        ///-----------------///
        ///       ACK       ///
        ///-----------------///
        private void ACK_state4(object sender, EventArgs e)
        {
            if(scriptNumber == SCRIPT_MODE_STATE.SCRIPT1)
            {
                DIS_ACK_script1.Text = "ACK";
                DIS_ACK_script1.ForeColor = Color.Green;
            }
            else if (scriptNumber == SCRIPT_MODE_STATE.SCRIPT2)
            {
                DIS_ACK_script2.Text = "ACK";
                DIS_ACK_script2.ForeColor = Color.Green;
            }
            else if (scriptNumber == SCRIPT_MODE_STATE.SCRIPT3)
            {
                DIS_ACK_script3.Text = "ACK";
                DIS_ACK_script3.ForeColor = Color.Green;
            }
            startChar = '0';
            msg_type = MSG_TYPE.WAIT;
        }
        ///------------------------///
        ///       Run button       ///
        ///------------------------///
        private void run_script_1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DIS_ACK_script1.Text == "ACK")
                {
                    Byte[] msg = { (byte)STATE.SCRIPT_MODE, (byte)SCRIPT_MODE_STATE.SCRIPT1 };
                    serialPort1.Write("!");
                    serialPort1.Write(msg, 0, 2);
                    serialPort1.Write("-");
                    serialPort1.Write("-");
                    serialPort1.Write("-");
                    message_sent_label.Text = (++message_sent_counter).ToString();
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void run_script_2_Click(object sender, EventArgs e)
        {
            try
            {
                if (DIS_ACK_script2.Text == "ACK")
                {
                    Byte[] msg = { (byte)STATE.SCRIPT_MODE, (byte)SCRIPT_MODE_STATE.SCRIPT2 };
                    serialPort1.Write("!");
                    serialPort1.Write(msg, 0, 2);
                    serialPort1.Write("-");
                    serialPort1.Write("-");
                    serialPort1.Write("-");
                    message_sent_label.Text = (++message_sent_counter).ToString();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void run_script_3_Click(object sender, EventArgs e)
        {
            try
            {
                if (DIS_ACK_script3.Text == "ACK")
                {
                    Byte[] msg = { (byte)STATE.SCRIPT_MODE, (byte)SCRIPT_MODE_STATE.SCRIPT3 };
                    serialPort1.Write("!");
                    serialPort1.Write(msg, 0, 2);
                    serialPort1.Write("-");
                    serialPort1.Write("-");
                    serialPort1.Write("-");
                    message_sent_label.Text = (++message_sent_counter).ToString();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        ///------------------------///
        ///       Send script      ///
        ///------------------------///
        private void script1_button_Click(object sender, EventArgs e)
        {
            try
            {
                scriptNumber = SCRIPT_MODE_STATE.SCRIPT1;
                send_script(sender, e);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void script2_button_Click(object sender, EventArgs e)
        {
            try
            {
                scriptNumber = SCRIPT_MODE_STATE.SCRIPT2;
                send_script(sender, e);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void script3_button_Click(object sender, EventArgs e)
        {
            try
            {
                scriptNumber = SCRIPT_MODE_STATE.SCRIPT3;
                send_script(sender, e);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void send_script(object sender, EventArgs e)
        {
            try
            {
                byte[] writeBuffer = { };
                if (scriptNumber == SCRIPT_MODE_STATE.SCRIPT1)
                {
                    const string Path1 = @"scripts\script1.txt.txt";
                    writeBuffer = File.ReadAllBytes(Path1);
                }
                else if (scriptNumber == SCRIPT_MODE_STATE.SCRIPT2)
                {
                    const string Path2 = @"scripts\script2.txt.txt";
                    writeBuffer = File.ReadAllBytes(Path2);
                }
                else if (scriptNumber == SCRIPT_MODE_STATE.SCRIPT3)
                {
                    const string Path3 = @"scripts\script3.txt.txt";
                    writeBuffer = File.ReadAllBytes(Path3);
                }
                
                // number of lines
                string message = "";
                for (int i = 0; i < writeBuffer.Length; i++)
                {
                    message += writeBuffer[i];
                }
                message = message.Replace("13", "");
                message = message.Replace("10", "-");
                string[] values = message.Split('-');
                int nunberOfLines = values.Length;
                string nunberOfLines_string = nunberOfLines.ToString();
                char[] nunberOfLines_char = nunberOfLines_string.ToCharArray();
                nunberOfLines_string = new string(nunberOfLines_char);
                // number of bytes
                string numberOfbytes_string = writeBuffer.Length.ToString();
                char[] numberOfbytes_char = numberOfbytes_string.ToCharArray();
                numberOfbytes_string = new string(numberOfbytes_char);
                // SEND: !
                serialPort1.Write("!");
                // SEND: state and substate
                Byte[] state_msg = { (byte)STATE.SCRIPT_MODE, (byte)scriptNumber };
                serialPort1.Write(state_msg, 0, 2);
                //Byte[] state_msg = { (byte)STATE.SCRIPT_MODE };
                //serialPort1.Write(state_msg, 0, 1);
                //string scriptNumber_str = scriptNumber.ToString();
                // SEND: number of byts and lines
                string numOfBytesAndLines = "";
                //numOfBytesAndLines += "1";
                numOfBytesAndLines += numberOfbytes_string;
                numOfBytesAndLines += "-";
                numOfBytesAndLines += nunberOfLines_string;
                numOfBytesAndLines += "-";
                serialPort1.Write(numOfBytesAndLines);
                // SEND: scipt
                for (int i = 0; i < writeBuffer.Length; i++)
                {
                    if (writeBuffer[i] == 10 || writeBuffer[i] == 13) serialPort1.Write("-");
                    else serialPort1.Write(writeBuffer, i, 1);
                }
                message_sent_label.Text = (++message_sent_counter).ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        ///------------------------------------------------------------------///
        ///                    STATE 5 - Motor commands                      ///
        ///------------------------------------------------------------------///
        private void clockwise_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] msg = { (byte)STATE.MOTOR_COMMAND, (byte)MOTOR_COMMAND_STATE.CLOCKWISE }; 
                serialPort1.Write("!");
                serialPort1.Write(msg, 0, 2);
                message_sent_label.Text = (++message_sent_counter).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void counterClockwise_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] msg = { (byte)STATE.MOTOR_COMMAND, (byte)MOTOR_COMMAND_STATE.COUNTER_CLOCKWISE };
                serialPort1.Write("!");
                serialPort1.Write(msg, 0, 2);
                message_sent_label.Text = (++message_sent_counter).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void stopStepMotor_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] msg = { (byte)STATE.MOTOR_COMMAND, (byte)MOTOR_COMMAND_STATE.STOP_MOTOR };
                serialPort1.Write("!");
                serialPort1.Write(msg, 0, 2);
                message_sent_label.Text = (++message_sent_counter).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


    }
}
