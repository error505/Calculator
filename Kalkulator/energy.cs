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
    public partial class energy : Form
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
        public energy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = frm2.textBox1.Text;
            if (label1.Text == "J")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.001);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min6);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 2.777777778 + min7);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.238845897);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.000238846);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.000947817);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = frm2.textBox1.Text;
            if (label2.Text == "kJ")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.001);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.0000277778);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 238.8458966);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.238845897);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.94781712);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = frm2.textBox1.Text;
            if (label3.Text == "MJ")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1000000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1000);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.277777778);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 238845.8966);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 238.8458966);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 947.8171203);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = frm2.textBox1.Text;
            if (label4.Text == "kWh")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 3600000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 3600);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 3.6);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 859845.2279);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 859.8452279);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 3412.141633);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = frm2.textBox1.Text;
            if (label5.Text == "cal")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 4.1868);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.0041868);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 4.1868 + min6);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1.163 + min6);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.001);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.003968321);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = frm2.textBox1.Text;
            if (label6.Text == "kcal")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 4186.8);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 4.1868);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.0041868);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.001163);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 1000);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 3.968320719);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Text = frm2.textBox1.Text;
            if (label7.Text == "BTU")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1055.055853);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1.055055853);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.001055056);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.000293071);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 251.9957611);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.251995761);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
