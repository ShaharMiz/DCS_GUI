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
    public partial class elevator_control : Form //partial
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
        uint m_current_x = 30;
        uint m_current_y = 30;
        uint previous_x = 103;
        uint previous_y = 103;
        uint m_joistic_mode = 103;
        JOISTICK_MODES joistick_modes = JOISTICK_MODES.NUTRAL;
        /////////////////////////////////////





        private enum MSG_TYPE : byte
        {
            WAIT = 0,
            ID,
            SATUS
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
        private enum SC_MSG_MODES : byte
        {
            UNKNOWN_MODE = 0,
            AUTOMAT_MODE,
            RELAY_OPEND,
            RELAY_CLOSED,
            CHARGING,
            NOT_CHARGING
        }
        private enum JOISTICK_MODES : byte
        {
            NUTRAL = 0,
            DRAW,
            ERASER
        }
        private enum STATE : byte
        {
            SLEEP = 0,
            MOTOR_POINTER,
            JOISTICK_DRAW,
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

        public elevator_control()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            button_open.Enabled = true;
            button_send.Enabled = false;
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

                    button_send.Enabled = true;
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
                    button_send.Enabled = false;
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
        private void button_send_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write(textBox_textSent.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
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
                    if (serialDataHeader[0] == '#')
                    {
                        try
                        {
                            startChar = '#';
                            msg_type = MSG_TYPE.SATUS;
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
                    else startChar = '0';
                }
            }
            if (msg_type == MSG_TYPE.SATUS && bytes >= (MSG_LENGTH-3))
            {
                serialDataIn = new byte[bytes];
                serialPort1.Read(serialDataIn, 0, MSG_LENGTH-3);
                //clearRXBuffer = serialPort1.ReadExisting();
                this.Invoke(new EventHandler(ShowData));
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

            if (startChar == '#')
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
/*                for (int i = 1; i < values.Length; i++)
                {
                    if (values[i].Length == 0) 
                    {
                        values[i] = "0";
                    }
                }*/
                
                index =0;
                if (CRC_status)
                {
                    /*              MSG_Status.Text = Enum.GetName(typeof(SC_MSG_STATUS), msg_array[index]);
                                    index++;
                                    modeLabel.Text = Enum.GetName(typeof(SC_MSG_MODES), msg_array[index]);
                                    index++;
                                    m_timestamp = BitConverter.ToUInt32(new byte[4] { msg_array[index], msg_array[index+1], msg_array[index+2], msg_array[index+3] }, 0);
                                    index+=4;
                                    m_SMcounter = BitConverter.ToUInt16(new byte[2] { msg_array[index], msg_array[index + 1] }, 0);
                                    //m_SMcounter = BitConverter.ToUInt16( msg_array, index);
                                    index += 2;
                                    m_vscap = BitConverter.ToUInt16(new byte[2] { msg_array[index], msg_array[index + 1] }, 0);
                                    index += 2;
                                    m_current = BitConverter.ToInt16(new byte[2] { msg_array[index], msg_array[index + 1] }, 0);
                                    index += 2;*/

                    // Read buffer
                    //m_SMcounter = BitConverter.ToUInt16(new byte[2] { msg_array[index + 1], msg_array[index] }, 0);
                    try
                    {
                        m_stepAngle      = uint.Parse(values[0]);
                        m_currentAngle   = uint.Parse(values[1]);
                        m_SMcounter      = uint.Parse(values[2]);
                        m_current_x      = uint.Parse(values[3]);
                        m_current_y      = uint.Parse(values[4]);
                        m_joistic_mode   = uint.Parse(values[5]);
                        //
                        float m_stepAngle_float = (float)m_stepAngle / 100;
                        step_angle_Label.Text = m_stepAngle_float.ToString() + " deg";
                        float m_currentAngle_float = (float)m_currentAngle / 100;
                        current_angle_Label.Text = m_currentAngle_float.ToString() + " deg";
                        SM_countre_Label.Text = m_SMcounter.ToString();

                        // JOISTICK
                        if (m_joistic_mode == 0) joistick_modes = JOISTICK_MODES.NUTRAL;
                        else if (m_joistic_mode == 1) joistick_modes = JOISTICK_MODES.DRAW;
                        else joistick_modes = JOISTICK_MODES.ERASER;
                        panel1_Paint(sender, e);

                    }
                    catch (Exception error)
                    {
                    }


                        /*                    MainChart.Series["Vin"].Points.AddXY(m_timestamp.ToString(), m_SMcounter.ToString());
                                            MainChart.Series["Vcap"].Points.AddXY(m_timestamp.ToString(), m_vscap.ToString());
                                            MainChart.Series["Current"].Points.AddXY(m_timestamp.ToString(), m_current.ToString());*/

                        /////////////////////////////////////
                        //           Joistick !!!          //
                        /////////////////////////////////////
                        //radioButton1.Location = new Point((int)(current_x * 1.8 * m_CJoy.dX0), (int)(current_y * 1.8 * m_CJoy.dY0));
                        /////////////////////////////////////
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
            message_error_label.Text = (message_error_counter = 0).ToString();
        }


        private void comboBox_comPort_Click(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            comboBox_comPort.Items.Clear();
            comboBox_comPort.Items.AddRange(portLists);
            comboBox_comPort.SelectedIndex = comboBox_comPort.Items.Count - 1;
        }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            serialPort1.DtrEnable = true;
            serialPort1.DtrEnable = false;
            serialPort1.DtrEnable = false;
            serialPort1.DtrEnable = true;
        }

        private void clearChartButton_Click(object sender, EventArgs e)
        {
            MainChart.Series["Vin"].Points.Clear();
            MainChart.Series["Vcap"].Points.Clear();
            MainChart.Series["Current"].Points.Clear();
 
        }

        private void ChartcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainChart.Series["Vin"].Points.Clear();
            MainChart.Series["Vcap"].Points.Clear();
            MainChart.Series["Current"].Points.Clear();
        }

        private void motor_num_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] Checksum = { 0 };
                Byte[] msg = { (byte)SC_CMD.AUTOMAT, 0, 0, 0, 0 };
                for (int i = 0; i < msg.Length; i++)
                    Checksum[0] ^= msg[i];
                serialPort1.Write("#");
                serialPort1.Write(Checksum, 0, 1);
                serialPort1.Write(msg, 0, 5);
                message_sent_label.Text = (++message_sent_counter).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void autoModeButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] Checksum = { 0 };
                Byte[] msg = { (byte)SC_CMD.AUTOMAT, 0, 0, 0, 0 };
                for (int i = 0; i < msg.Length; i++)
                    Checksum[0] ^= msg[i];
                serialPort1.Write("#");
                serialPort1.Write(Checksum, 0, 1);
                serialPort1.Write(msg, 0, 5);
                message_sent_label.Text = (++message_sent_counter).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void closeModeButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] Checksum = { 0 };
                Byte[] msg = { (byte)SC_CMD.RELAY_CLOSE, 0, 0, 0, 0 };
                for (int i = 0; i < msg.Length; i++)
                    Checksum[0] ^= msg[i];
                serialPort1.Write("#");
                serialPort1.Write(Checksum, 0, 1);
                serialPort1.Write(msg, 0, 5);
                message_sent_label.Text = (++message_sent_counter).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void openModeButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] Checksum = { 0 };
                Byte[] msg = { (byte)SC_CMD.RELAY_OPEN, 0, 0, 0, 0 };
                for(int i=0;i<msg.Length;i++)
                    Checksum[0] ^= msg[i];
                serialPort1.Write("#");
                serialPort1.Write(Checksum, 0, 1);
                serialPort1.Write(msg, 0, 5);
                message_sent_label.Text = (++message_sent_counter).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        
        private void calibButton_Click(object sender, EventArgs e)
        {
            float calib_voltage = 0;
            calib_voltage = float.Parse(calibTextBox.Text);
            byte[] calibOut = BitConverter.GetBytes(calib_voltage);

            try
            {
                byte[] Checksum = { 0 };
                Byte[] msg = { (byte)SC_CMD.CALIBRATION_VOLTAGE, calibOut[0], calibOut[1], calibOut[2], calibOut[3] };
                for (int i = 0; i < msg.Length; i++)
                    Checksum[0] ^= msg[i];
                serialPort1.Write("#");
                serialPort1.Write(Checksum, 0, 1);
                serialPort1.Write(msg, 0, 5);
                message_sent_label.Text = (++message_sent_counter).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void calibCurrentButton_Click(object sender, EventArgs e)
        {
            float calib_voltage = 0;
            calib_voltage = float.Parse(calibTextBox.Text);
            byte[] calibOut = BitConverter.GetBytes(calib_voltage);

            try
            {
                byte[] Checksum = { 0 };
                Byte[] msg = { (byte)SC_CMD.CALIBRATION_CURRENT, calibOut[0], calibOut[1], calibOut[2], calibOut[3] };
                for (int i = 0; i < msg.Length; i++)
                    Checksum[0] ^= msg[i];
                serialPort1.Write("#");
                serialPort1.Write(Checksum, 0, 1);
                serialPort1.Write(msg, 0, 5);
                message_sent_label.Text = (++message_sent_counter).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void textBox_textSent_TextChanged(object sender, EventArgs e)
        {

        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

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
        private void script1_button_Click(object sender, EventArgs e)
        {
            const string Path = @"scripts\script1.txt";
            try
            {
                byte[] writeBuffer = File.ReadAllBytes(Path);
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
                // number of bytes
                int numberOfbytes = 0;
                for(int i = 0; i < writeBuffer.Length; i++)
                {
                    if (writeBuffer[i] != 13) numberOfbytes++;
                }
                byte[] numOfBytesAndLines = { (byte)numberOfbytes, (byte)'-', (byte)nunberOfLines, (byte)'-' };
                Byte[] state_msg = { (byte)STATE.SCRIPT_MODE, (byte)SCRIPT_MODE_STATE.SCRIPT1 };
                
                serialPort1.Write("!");
                serialPort1.Write(state_msg, 0, 2);
                serialPort1.Write(numOfBytesAndLines, 0, numOfBytesAndLines.Length);

                for (int i = 0; i < writeBuffer.Length; i++)
                {
                    if (writeBuffer[i] == 10) serialPort1.Write("-");
                    else if(writeBuffer[i] != 13) serialPort1.Write(writeBuffer, i, 1);
                }
                message_sent_label.Text = (++message_sent_counter).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void script2_button_Click(object sender, EventArgs e)
        {
            const string Path = @"scripts \ script2.txt";
            try
            {
                byte[] writeBuffer = File.ReadAllBytes(Path);
                Byte[] msg = { (byte)STATE.SCRIPT_MODE, (byte)SCRIPT_MODE_STATE.SCRIPT2 };
                serialPort1.Write("!");
                serialPort1.Write(msg, 0, 2);
                serialPort1.Write(writeBuffer, 0, writeBuffer.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void script3_button_Click(object sender, EventArgs e)
        {
            const string Path = @"scripts \ script3.txt";
            try
            {
                byte[] writeBuffer = File.ReadAllBytes(Path);
                Byte[] msg = { (byte)STATE.SCRIPT_MODE, (byte)SCRIPT_MODE_STATE.SCRIPT3 };
                serialPort1.Write("!");
                serialPort1.Write(msg, 0, 2);
                serialPort1.Write(writeBuffer, 0, writeBuffer.Length);
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
        ///------------------------------------------------------------------///
        ///                          PANEL                                   ///
        ///------------------------------------------------------------------///
        private void panel1_Paint(object sender, EventArgs e)
        {
            Graphics panelObject = panel1.CreateGraphics();
            Brush black = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(black, 3);
            Brush white = new SolidBrush(Color.White);
            Pen whitePen = new Pen(white, 5);
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
    }
}
