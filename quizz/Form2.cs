using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ra3_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void ra1_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void ra2_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void check()
        {
            if (ra2.Checked)
            {
                Form1.score++;
            }
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }
    }
}
