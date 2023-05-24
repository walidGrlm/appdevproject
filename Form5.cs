using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" DOWNLOAD SUCCESSFULY and Pdf doc ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" DOWNLOAD SUCCESSFULY and Word Doc ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" DOWNLOAD SUCCESSFULY and Figma Doc  ");
        }
        }
    }

