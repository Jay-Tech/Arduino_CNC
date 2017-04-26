using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetUpComPort()
        {
            SerialPort myPort = new SerialPort();
            myPort.BaudRate = Convert.ToInt32(cbBaud.Text);
            myPort.PortName = cbPort.Text;


        }

        private void GetComPort()
        {
            String[] localPorts = SerialPort.GetPortNames();
            foreach (string ports in localPorts)
            {
                cbPort.Text = ports;

            }
        }

        private void MessageRec()
        {

        }
    }
}
