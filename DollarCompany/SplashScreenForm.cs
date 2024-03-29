﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarCompany
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void formSplashScreen_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.startForm.Show();
            this.Hide();
        }
    }
}
