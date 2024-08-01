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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ra2_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void ra1_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ra3_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void check()
        {
            if (ra3.Checked)
            {
                Form1.score++;
            }
            Form4 form4 = new Form4();
            form4.Show();
            this.Close();
        }
    }
}
