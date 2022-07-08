﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using OpenJigWare;




namespace Pneumatic_Control
{
    public partial class elevator_control : Form //partial
    {
        const int MSG_LENGTH = 13; // 
        const int ID_MSG_LENGTH = 70;
        const int stringSize = 16;
        byte[] serialDataIn;
        int message_sent_counter = 0;
        int message_received_counter = 0;
        int message_error_counter = 0;
        private byte[] serialDataHeader;
        MSG_TYPE msg_type = MSG_TYPE.WAIT;
        char startChar = '0';
        
        // Joistick
        float x1 = 115;
        float y1 = 115;
        float x2 = 115;
        float y2 = 115;

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

            comboBox_baudRate.Text = "115200";
            string[] portLists = SerialPort.GetPortNames();
            comboBox_comPort.Items.AddRange(portLists);
            comboBox_comPort.SelectedIndex = comboBox_comPort.Items.Count-1;

            // Joistick !!!
            Ojw.CMessage.Init(txtMessage);
            panel1.Controls.Add(radioButton1);
            radioButton1.Location = new Point((int)x1, (int)y1);

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

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //serialDataIn = serialPort1.ReadExisting();
            int bytes = serialPort1.BytesToRead;
            if (serialPort1.BytesToRead > 0 && msg_type == MSG_TYPE.WAIT)
            {
                while (bytes > 0)
                {
                    serialDataHeader = new byte[1];
                    serialPort1.Read(serialDataHeader, 0, 1);
                    bytes--;
                    if (serialDataHeader[0] == '#')
                    {
                        startChar = '#';
                        msg_type = MSG_TYPE.SATUS;
                        break;
                    }
                    else startChar = '0';
                }
            }
            if (msg_type == MSG_TYPE.SATUS && bytes >= MSG_LENGTH)
            {
                serialDataIn = new byte[bytes];
                serialPort1.Read(serialDataIn, 0, MSG_LENGTH);
                this.Invoke(new EventHandler(ShowData));
            }

        }

        private void ShowData(object sender, EventArgs e)
        {
            byte[] msg_array = serialDataIn;

            byte msg_checksum=0;
            uint m_timestamp = 0;
            uint m_vin = 0;
            uint m_vscap = 0;
            int m_current = 0;
            bool CRC_status = false;
            int index = 0;
            byte[] module_status = { 0, 0, 0, 0, 0, 0, 0 };
            short[] weight = { 0, 0, 0, 0 ,0 ,0 ,0};
            short[] position = { 0, 0, 0, 0 ,0 , 0, 0};

            richTextBox_textReceiver.Text += "------New data ------" + "\n";
            richTextBox_textReceiver.Text += startChar.ToString() + "\t|" + Enum.GetName(typeof(MSG_TYPE), msg_type) + " message\n";
            for (int i = 0; i < msg_array.Length; i++)
            {
                richTextBox_textReceiver.Text += (i+1).ToString() + ") " + msg_array[i].ToString();
                if(msg_array[i]>31 && msg_array[i]<127) richTextBox_textReceiver.Text += "\t| " + (char)msg_array[i] + " \n";
                else richTextBox_textReceiver.Text += "\n";
            }

            richTextBox_textReceiver.Text += "---------------------" + "\n";

            if (startChar == '#')
            {
                //CRC calculation
                msg_checksum = 0;
                for (int i = 1; i < MSG_LENGTH; i++)
                {
                    msg_checksum ^= msg_array[i];
                }

                if (msg_checksum == msg_array[0])
                {
                    CRC_status = true;
                    message_received_counter++;
                    message_recieved_label.Text = message_received_counter.ToString();
                    richTextBox_textReceiver.Text += msg_checksum.ToString() + " Checksum correct!" + "\n";
                }
                else
                {
                    MSG_Status.Text = "Checksum error";
                    message_error_counter++;
                    message_error_label.Text = message_error_counter.ToString();
                    richTextBox_textReceiver.Text += msg_checksum.ToString() + " Checksum error" + "\n";
                }

                index=1;
                if (CRC_status)
                {
                    MSG_Status.Text = Enum.GetName(typeof(SC_MSG_STATUS), msg_array[index]);
                    index++;
                    modeLabel.Text = Enum.GetName(typeof(SC_MSG_MODES), msg_array[index]);
                    index++;
                    m_timestamp = BitConverter.ToUInt32(new byte[4] { msg_array[index], msg_array[index+1], msg_array[index+2], msg_array[index+3] }, 0);
                    index+=4;
                    m_vin = BitConverter.ToUInt16(new byte[2] { msg_array[index], msg_array[index + 1] }, 0);
                    //m_vin = BitConverter.ToUInt16( msg_array, index);
                    index += 2;
                    m_vscap = BitConverter.ToUInt16(new byte[2] { msg_array[index], msg_array[index + 1] }, 0);
                    index += 2;
                    m_current = BitConverter.ToInt16(new byte[2] { msg_array[index], msg_array[index + 1] }, 0);
                    index += 2;
                    timestamp_label.Text = Convert.ToString(m_timestamp / 3600000) + "h " + Convert.ToString((m_timestamp / 60000) % 60) + "m " + Convert.ToString((m_timestamp / 1000) % 60) + 's';
                    vinLabel.Text = m_vin.ToString() + "mV";
                    vscapLabel.Text = m_vscap.ToString() + "mV"; 
                    currentLabel.Text = m_current.ToString() + "mV";

                    if (m_vin >= VinBar.Minimum && m_vin <= VinBar.Maximum) VinBar.Value =  (int)m_vin;
                    if (m_vscap >= VscapBar.Minimum && m_vscap <= VscapBar.Maximum) VscapBar.Value = (int)m_vscap;
                    if (m_current >= currentBar.Minimum && m_current <= currentBar.Maximum) currentBar.Value = (int)m_current;

                    MainChart.Series["Vin"].Points.AddXY(m_timestamp.ToString(), m_vin.ToString());
                    MainChart.Series["Vcap"].Points.AddXY(m_timestamp.ToString(), m_vscap.ToString());
                    MainChart.Series["Current"].Points.AddXY(m_timestamp.ToString(), m_current.ToString());

                    // joistick
                    radioButton1.Location = new Point((int)(x1 * 1.8 * m_CJoy.dX0), (int)(y1 * 1.8 * m_CJoy.dY0)); 

                }
            }
            else
            {
                message_error_counter++;
                message_error_label.Text = message_error_counter.ToString();
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

        private void PingButton_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] Checksum = { 0 };
                Byte[] msg = { 1, 0 ,0, 0, 0};
                for (int i = 0; i < msg.Length; i++)
                    Checksum[0] ^= msg[i];
                serialPort1.Write("#");
                serialPort1.Write(Checksum, 0, 1);
                serialPort1.Write(msg, 0, 5);
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("?");
                message_sent_label.Text = (++message_sent_counter).ToString();
            }
            catch (Exception error)
            {
                AutoButton.Text = "Press to run";
                button_open.Text = "OPEN";
                MessageBox.Show(error.Message);
            }
        }

        private void IDWriteButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to write to EEPROM?";
            string title = "ID programming";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    byte[] Checksum = { 0 };
                    byte[] msg = new byte[ID_MSG_LENGTH + 1];
                    byte[] description_msg = new byte[stringSize];
                    byte[] partNumber_msg = new byte[stringSize];
                    byte[] serialNumber_msg = new byte[stringSize];
                    byte[] version_msg = new byte[stringSize];

                    msg[0] = (byte)'!';
                    msg[2] = (byte)DEVICE_STATUS.PROG_ID;

                    Byte[] description_temp = Encoding.ASCII.GetBytes(DescriptionTextBox.Text);
                    Byte[] partNumber_temp = Encoding.ASCII.GetBytes(PartNumberTextBox.Text);
                    Byte[] serialNumber_temp = Encoding.ASCII.GetBytes(SerialNumberTextBox.Text);
                    Byte[] version_temp = Encoding.ASCII.GetBytes(VersionTextBox.Text);

                    System.Buffer.BlockCopy(description_temp, 0, description_msg, 0, description_temp.Length);
                    System.Buffer.BlockCopy(partNumber_temp, 0, partNumber_msg, 0, partNumber_temp.Length);
                    System.Buffer.BlockCopy(serialNumber_temp, 0, serialNumber_msg, 0, serialNumber_temp.Length);
                    System.Buffer.BlockCopy(version_temp, 0, version_msg, 0, version_temp.Length);

                    System.Buffer.BlockCopy(description_msg, 0, msg, 3, description_msg.Length);
                    System.Buffer.BlockCopy(partNumber_msg, 0, msg, 3 + stringSize * 1, partNumber_msg.Length);
                    System.Buffer.BlockCopy(serialNumber_msg, 0, msg, 3 + stringSize * 2, serialNumber_msg.Length);
                    System.Buffer.BlockCopy(version_msg, 0, msg, 3 + stringSize * 3, version_msg.Length);
                    for (int i = 2; i < msg.Length; i++)
                        msg[1] ^= msg[i];

                    serialPort1.Write(msg, 0, msg.Length);
                    message_sent_label.Text = (++message_sent_counter).ToString();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    button_open.Text = "OPEN";
                }
            }
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
            float calib_voltage=0;
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

        private void MainChart_Click(object sender, EventArgs e)
        {

        }
    }

}
