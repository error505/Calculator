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
    public partial class time : Form
    {
        public konv frm2;
        //string min4 = "x10^-4";
        string min5 = "x10^-5";
        string min8 = "x10^-8";
        string min6 = "x10^-6";
        string min7 = "x10^-7";
        string min9 = "x10^-9";
        string min10 = "x10^-10";
        string minn10 = "x10^10";
        string minn11 = "x10^11";
        string min11 = "x10^-11";
        string minn12 = "x10^12";
        string min12 = "x10^-12";
        string minn13 = "x10^13";
        string min13 = "x10^-13";
        string minn14 = "x10^14";
        string min14 = "x10^-14";
        string min15 = "x10^-15";
        string minn16 = "x10^16";
        //string min16 = "x10^-16";
        string min17 = "x10^-17";
        //string min18 = "x10^-18";
        //string min19 = "x10^-19";
        //string min20 = "x10^-20";
        //string min21 = "x10^-21";
        //string min22 = "x10^-22";
        public time()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = frm2.textBox1.Text;
            if (label1.Text == "ns")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.001);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min6);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min9);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.666666667 + min11);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 2.777777778 + min13);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.157407407 + min14);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.653439153 + min15);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 3.168808781 + min17);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = frm2.textBox1.Text;
            if (label2.Text == "μs")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.001);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1 + min6);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1.666666667 + min8);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 2.777777778 + min10);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1.157407407 + min11);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1.653439153 + min12);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 3.168808781 + min14);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = frm2.textBox1.Text;
            if (label3.Text == "ms")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1000000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1000);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.001);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1.666666667 + min5);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 2.777777778 + min7);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1.157407407 + min8);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1.653439153 + min9);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 3.168808781 + min11);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = frm2.textBox1.Text;
            if (label4.Text == "s")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1000000000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1000000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1000);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.016666667);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.000277778);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1.157407407 + min5);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1.653439153 + min6);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 3.168808781 + min8);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = frm2.textBox1.Text;
            if (label5.Text == "min")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 6 + minn10);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 60000000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 60000);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 60);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.016666667);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.000694444);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 9.920634921 + min5);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1.901285269 + min6);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = frm2.textBox1.Text;
            if (label6.Text == "h")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 3.6 + minn12);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 3600000000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 3600000);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 3600);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 60);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.041666667);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.005952381);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.000114077);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Text = frm2.textBox1.Text;
            if (label7.Text == "d")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 8.64 + minn13);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 8.64 + minn10);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 86400000);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 86400);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1440);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 24);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.142857143);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.002737851);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox8.Text = frm2.textBox1.Text;
            if (label8.Text == "wk")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 6.048 + minn14);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 6.048 + minn11);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 604800000);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 604800);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 10080);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 168);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 7);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.019164956);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox9.Text = frm2.textBox1.Text;
            if (label9.Text == "yr")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 3.15576 + minn16);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 3.15576 + minn13);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 3.15576 + minn10);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 31557600);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 525960);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 8766);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 365.25);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 52.17857143);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
