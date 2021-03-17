using KeepYourPlantsAlive.Common;
using KeepYourPlantsAlive.Controllers;
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

namespace KeepYourPlantsAlive.Views
{
    public partial class FlowerDetailsControl : UserControl
    {
        private readonly ViewController _controller = new ViewController();
        private string _flowerName;
        private SerialPort _serialPort;
        public FlowerDetailsControl(string name)
        {
            _flowerName = name;
            InitializeComponent();
            Init();
        }
        private void Init()
        { 
            lbFlowerName.Text = _flowerName;
            cmbPort.Items.AddRange(SerialPort.GetPortNames());
        }
        private void BtnStartRead_Click(object sender, EventArgs e)
        {
            if (cmbPort.Text.Equals(ConstString.SelectPort))
            {
                MessageBox.Show(ConstString.SelectPort_Error, ConstString.Error, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                _serialPort = new SerialPort(cmbPort.Text.ToString(), 19200, Parity.None, 8, StopBits.One);
            }
        }
    }
}
