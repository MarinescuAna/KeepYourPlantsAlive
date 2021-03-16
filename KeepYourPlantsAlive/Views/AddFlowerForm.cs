using KeepYourPlantsAlive.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeepYourPlantsAlive.Views
{
    public partial class AddFlowerForm : Form
    {
        private readonly FlowerManagementController _flowerManagementController = new FlowerManagementController();
        public AddFlowerForm()
        {
            InitializeComponent();
        }

        private void btnSaveFlower_Click(object sender, EventArgs e)
        {
            if(!_flowerManagementController.AddNewFlower(txtFlowerName.Text.ToUpper()))
            {
                MessageBox.Show("The name already exists!");
            }
            else
            {
                this.Close();
            }
        }
    }
}
