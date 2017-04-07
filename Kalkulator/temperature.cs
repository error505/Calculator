using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class temperature : Form
    {
        public konv frm2;
        public temperature()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = frm2.textBox1.Text;
            if (label1.Text == "°C")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 33.8);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 274.15);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = frm2.textBox1.Text;
            if (label2.Text == "°F")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * -17.22222222);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 255.9277778);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = frm2.textBox1.Text;
            if (label3.Text == "K")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * -272.15);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * -457.87);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
