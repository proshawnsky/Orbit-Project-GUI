using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orbit_Project_GUI
{
    public partial class Form1 : Form
    {
        private bool connected;
        public delegate void d1(string indata);
        public Form1()
        {
            InitializeComponent();
            getAvailablePorts();
        }

        private void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            portDropdown.Items.AddRange(ports);
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            statusTextBox.Text = "Select Port";
            statusTextBox.BackColor = Color.LightCoral;
            connected = false;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(portDropdown.Text == "")
                {
                    statusTextBox.Text = "No Port";
                }
                else
                {
                    serialPort1.PortName = portDropdown.Text;
                    serialPort1.Open();
                    statusTextBox.BackColor = Color.Lime;
                    statusTextBox.Text = "Connected";
                    connected = true;
                }
            }
            catch (UnauthorizedAccessException)
            {
                statusTextBox.Text = "Unauthorized";
                statusTextBox.BackColor = Color.LightCoral;

            }
            catch (System.IO.IOException)
            {
                statusTextBox.Text = "Unavailable";
                statusTextBox.BackColor = Color.LightCoral;
            }
        }

        private void sendCommandButton_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                serialPort1.Write(sendCommandText.Text);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String indata = serialPort1.ReadLine();
            d1 writeit = new d1(handleSerialIn);
            Invoke(writeit, indata);
        }

        private void handleSerialIn(string indata)
        {
            char firstchar = indata[0];
            int mode = 0;
            recievedTextBox.Text = indata;

        }
    }
}
