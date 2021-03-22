using KeepYourPlantsAlive.Common;
using KeepYourPlantsAlive.Controllers;
using KeepYourPlantsAlive.Models;
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
        private readonly ViewController _controller;
        private readonly string _flowerName;
        private readonly List<int> _valuesEnter = new List<int>();
        private readonly BindingList<Entry> _source = new BindingList<Entry>();
        public FlowerDetailsControl(string name)
        {
            _flowerName = name;
            _controller = new ViewController(_flowerName);
            InitializeComponent();
            Init();
        }
        #region
        private void Init()
        {
            picFlowers.ImageLocation = FilePaths.FlowerHappyPath;
            lbFlowerName.Text = _flowerName;
            cmbPort.Items.AddRange(SerialPort.GetPortNames());
            InitMonthCalendar();
            ArduinoVisibility(true);
            KeyboardVisibility(false);
            InitTable();
        }
        private void InitMonthCalendar()
        {
            var datesread = _controller.ReadWaterDates();
            var dates = new DateTime[datesread.Count];
            var count = 0;
            foreach (var value in datesread.Distinct())
            {
                dates[count++] = DateTime.Parse(value);
            }
            monthCalendar.BoldedDates = dates;
        }
        private void ArduinoVisibility(bool value)
        {
            cmbPort.Visible = value;
            btnStartReading.Visible = value;
        }
        private void KeyboardVisibility(bool value)
        {
            btnClear.Visible = value;
            txtValuesKeyboard.Visible = value;
            btnWriteValue.Visible = value;
        }
        private void InitImageStoreValues(int value)
        {
            _valuesEnter.Add(value);
            picFlowers.ImageLocation = value < 500 ? FilePaths.FlowerHappyPath : FilePaths.FlowerSadPath;
        }
        private void InitTable()
        {
            _source.Clear();
            foreach (var values in _controller.ReadValues())
            {
                _source.Add(values);
            }
            dataGridView1.DataSource = _source;
        }
        private void Reset()
        {
            txtValuesRead.Text = "";
            _valuesEnter.Clear();
        }
        #endregion

        private void BtnStartRead_Click(object sender, EventArgs e)
        {
            if (cmbPort.Text.Equals(ConstString.SelectPort))
            {
                MessageBox.Show(ConstString.SelectPort_Error, ConstString.Error, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Reset();
                serialPort.PortName = cmbPort.Text.ToString();
                serialPort.BaudRate= 9600;
                serialPort.Open();
                for (var count = 0; count < 40; count++)
                {
                    string oneLine = serialPort.ReadLine();
                    InitImageStoreValues(int.Parse(oneLine));
                    txtValuesRead.AppendText($"\n{oneLine}");
                    System.Threading.Thread.Sleep(1000);
                }
                serialPort.Close();
                _controller.WriteValue(_valuesEnter.Min().ToString(), _valuesEnter.Max().ToString());
                if (_valuesEnter.Max() - _valuesEnter.Min() > 100)
                { 
                    _controller.WriteValueWater(); 
                }
            }
        }
        private void ChkKeyboard_CheckedChanged(object sender, EventArgs e)
        {
            ArduinoVisibility(false);
            KeyboardVisibility(true);
            chkArduino.Checked = false;
        }
        private void ChkArduino_CheckedChanged(object sender, EventArgs e)
        {
            ArduinoVisibility(true);
            KeyboardVisibility(false);
            chkKeyboard.Checked = false;
        }
        private void BtnWriteValue_Click(object sender, EventArgs e)
        {
            InitImageStoreValues(int.Parse(txtValuesKeyboard.Text));
            txtValuesRead.AppendText(txtValuesKeyboard.Text);
            txtValuesKeyboard.Text = string.Empty;
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void TxtValuesKeyboard_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void BtnGiveWater_Click(object sender, EventArgs e)
        {
            if (_valuesEnter.Count > 0)
            {
                _controller.WriteValue(_valuesEnter.Min().ToString(), _valuesEnter.Max().ToString());
            }
            _controller.WriteValueWater();
            InitTable();
            InitMonthCalendar();
        }
    }
}
