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
    public partial class power : Form
    {
        public konv frm2;
        //string min4 = "x10^-4";
        //string min5 = "x10^-5";
        //string min8 = "x10^-8";
        string min6 = "x10^-6";
        string min7 = "x10^-7";
        //string min9 = "x10^-9";
        //string min10 = "x10^-10";
        //string min11 = "x10^-11";
        //string min12 = "x10^-12";
        //string min13 = "x10^-13";
        //string min14 = "x10^-14";
        //string min15 = "x10^-15";
        //string min16 = "x10^-16";
        //string min17 = "x10^-17";
        //string min18 = "x10^-18";
        //string min19 = "x10^-19";
        //string min20 = "x10^-20";
        //string min21 = "x10^-21";
        //string min22 = "x10^-22";
        public power()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = frm2.textBox1.Text;
            if (label1.Text == "W")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.001);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min6);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.238845897);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 3.412141633);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.001341022);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = frm2.textBox1.Text;
            if (label2.Text == "kW")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.001);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 238.8458966);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 3412.141633);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1.341022089);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = frm2.textBox1.Text;
            if (label3.Text == "MW")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1000000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1000);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 238845.8966);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 3412141.633);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1341.022089);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = frm2.textBox1.Text;
            if (label4.Text == "cal/s")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 4.1868);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.004186);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 4.1868 + min6);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 14.28595459);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.005614591);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = frm2.textBox1.Text;
            if (label5.Text == "BTU/h")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.29307107);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.000293071);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 2.930710702 + min7);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.069998823);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.000393015);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = frm2.textBox1.Text;
            if (label6.Text == "hp")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 745.699872);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.745699872);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.0007457);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 178.1073545);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 2544.433579);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
