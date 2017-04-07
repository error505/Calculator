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
    public partial class force : Form
    {
        public konv frm2;
        //string min4 = "x10^-4";
        //string min5 = "x10^-5";
        //string min8 = "x10^-8";
        string min6 = "x10^-6";
        string min7 = "x10^-7";
        string min9 = "x10^-9";
        //string min10 = "x10^-10";
        //string minn10 = "x10^10";
        //string minn11 = "x10^11";
        //string min11 = "x10^-11";
        //string minn12 = "x10^12";
        //string min12 = "x10^-12";
        //string minn13 = "x10^13";
        //string min13 = "x10^-13";
        //string minn14 = "x10^14";
        //string min14 = "x10^-14";
        //string min15 = "x10^-15";
        //string minn16 = "x10^16";
        //string min16 = "x10^-16";
        //string min17 = "x10^-17";
        //string min18 = "x10^-18";
        //string min19 = "x10^-19";
        //string min20 = "x10^-20";
        //string min21 = "x10^-21";
        //string min22 = "x10^-22";
        public force()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = frm2.textBox1.Text;
            if (label1.Text == "μN")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.001);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min6);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min9);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.019716213 + min7);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 2.248089429 + min7);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = frm2.textBox1.Text;
            if (label2.Text == "mN")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.001);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1 + min6);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.000101972);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.000224809);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = frm2.textBox1.Text;
            if (label3.Text == "N")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1000000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1000);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.001);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.101971621);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.224808943);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = frm2.textBox1.Text;
            if (label4.Text == "kN")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1000000000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1000000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1000);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 101.9716213);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 224.8089429);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = frm2.textBox1.Text;
            if (label5.Text == "kgf")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 9806650);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 9806.65);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 9.80665);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.00980665);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 2.204622619);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = frm2.textBox1.Text;
            if (label6.Text == "lbf")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 4448221.62);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 4448.22162);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 4.44822162);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.004448222);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.45359237);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
