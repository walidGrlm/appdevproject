﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" done ");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" done ");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" done ");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" done ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
