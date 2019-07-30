﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DollarCompany
{
    public partial class formMain : Form
    {
        public formMain()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new formSplashScreen());
        }
    }
}
