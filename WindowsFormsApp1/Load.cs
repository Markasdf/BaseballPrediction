﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Preview l = new Preview();
            l.Show();
            this.Hide();
        }
    }
}
