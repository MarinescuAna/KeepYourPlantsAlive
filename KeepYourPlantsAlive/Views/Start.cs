﻿using KeepYourPlantsAlive.Views;
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
        public Start()
        {
            this.BackgroundImage = Properties.Resources.backgroundStart;
            InitializeComponent();
        }

        private void btnAddPlant_Click(object sender, EventArgs e)
        {
            AddFlowerForm addFlowerForm = new AddFlowerForm();
            addFlowerForm.Show();
        }
    }
}
