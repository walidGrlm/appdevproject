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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 09093142383 ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Walid Guro, 22, 08,13,2000");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Not Invalid ");
        }
    }
}
