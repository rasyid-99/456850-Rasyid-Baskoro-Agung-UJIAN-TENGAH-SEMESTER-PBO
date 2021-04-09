using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UJIAN_TENGAH_SEMESTER_PBO
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 o = new Form3();
            o.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 o = new Form9();
            o.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 o = new Form10();
            o.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 o = new Form11();
            o.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 o = new Form12();
            o.Show();
        }
    }
}
