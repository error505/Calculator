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
    public partial class fuel : Form
    {
        public konv frm2;
        public fuel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             textBox1.Text = frm2.textBox1.Text;
             if (label1.Text == "km/l")
             {
                 textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 100);
                 textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 2.824809363);
                 textBox4.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 2.352145833);
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = frm2.textBox1.Text;
            if (label2.Text == "l/100km")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 100);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 282.4809363);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 235.2145833);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = frm2.textBox1.Text;
            if (label3.Text == "mpg(lmp)")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.35400619);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 282.4809363);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.832674185);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = frm2.textBox1.Text;
            if (label4.Text == "mpg(US)")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.425143707);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 235.2145833);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1.200949926);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
