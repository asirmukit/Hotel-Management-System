﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnpayroll_Click(object sender, EventArgs e)
        {
            FormPayroll F1 = new FormPayroll();
            F1.Show();
            this.Hide();

        }
    }
}
