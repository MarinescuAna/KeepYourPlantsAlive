using KeepYourPlantsAlive.Common;
using KeepYourPlantsAlive.Controllers;
using KeepYourPlantsAlive.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeepYourPlantsAlive
{
    public partial class Start : Form
    {
        private readonly StartController _controller = new StartController();
        public Start()
        {
            this.BackgroundImage = Properties.Resources.backgroundStart;
            InitializeComponent();
            Init();
        }

        private void btnAddPlant_Click(object sender, EventArgs e)
        {
            AddFlowerForm addFlowerForm = new AddFlowerForm();
            addFlowerForm.FormClosed += new FormClosedEventHandler(AddFlowerForm_FormClosed);
            addFlowerForm.Show();
           
        }

        private void Init()
        {
            cmbFlowers.Items.AddRange(_controller.ReadFlowerNames().ToArray());
        }
        private void AddFlowerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cmbFlowers.Items.Clear();
            Init();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(cmbFlowers.Text.Equals(ConstString.Select))
            {  
                MessageBox.Show(ConstString.SelectName_Error,ConstString.Error,MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new FlowerDetailsControl(cmbFlowers.Text));
                
            }

        }
    }
}
