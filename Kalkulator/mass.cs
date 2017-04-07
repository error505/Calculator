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
    public partial class mass : Form
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
        string min13 = "x10^-13";
        //string min14 = "x10^-14";
        //string min15 = "x10^-15";
        //string min16 = "x10^-16";
        //string min17 = "x10^-17";
        //string min18 = "x10^-18";
        //string min19 = "x10^-19";
        //string min20 = "x10^-20";
        //string min21 = "x10^-21";
        //string min22 = "x10^-22";
        public mass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = frm2.textBox1.Text;
            if (label1.Text == "μg")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.001);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min6);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min9);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min12);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 3.527296195 + min8);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 2.204622622 + min9);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.574730444 + min10);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 2.204622622 + min11);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.968613055 + min11);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.102311311 + min12);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 9.842065276 + min13);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = frm2.textBox1.Text;
            if (label2.Text == "mg")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.001);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1 + min6);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1 + min9);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 3.527296195 + min5);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 2.204622622 + min6);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1.574730444 + min7);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 2.204622622 + min8);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1.968613055 + min8);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1.102311311 + min9);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 9.842065276 + min10);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = frm2.textBox1.Text;
            if (label3.Text == "g")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1000000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1000);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.001);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1 + min6);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.035272962);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.002204623);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.000157473);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 2.204622622 + min5);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1.968613055 + min5);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1.102311311 + min6);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 9.842065276 + min7);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = frm2.textBox1.Text;
            if (label4.Text == "kg")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1000000000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1000000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1000);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.001);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 35.27396195);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 2.204622622);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.157473044);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.022046226);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.019686131);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.001102311);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.000984207);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = frm2.textBox1.Text;
            if (label5.Text == "t")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1 + min12);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1000000000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1000000);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1000);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 35273.96195);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 2204.622622);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 157.4730444);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 22.04622622);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 19.68613055);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1.102311311);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.984206528);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = frm2.textBox1.Text;
            if (label6.Text == "oz")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 28349523.12);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 28349.52312);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 28.34952312);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.028349523);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 2.834952312 + min5);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.0625);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.004464286);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.000625);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.0005558036);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 3.125 + min5);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 2.790175871 + min5);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Text = frm2.textBox1.Text;
            if (label7.Text == "lb")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 453592370);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 453592.37);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 453.59237);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.5359237);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.00053592);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 16);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.071428571);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.01);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.008928571);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.0005);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.000446429);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox8.Text = frm2.textBox1.Text;
            if (label8.Text == "st")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 6350293180);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 6350293.18);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 6350.29318);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 6.35029318);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.006350293);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 224);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 14);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.14);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.125);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.007);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.00625);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox9.Text = frm2.textBox1.Text;
            if (label9.Text == "cwt (US)")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 4.5359237 + minn10);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 45359237);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 45359.237);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 45.359237);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.045359237);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 1600);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 100);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 7.142857143);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.892857143);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.05);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.044642857);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox10.Text = frm2.textBox1.Text;
            if (label10.Text == "cwt (UK)")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 5.080234544 + minn10);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 50802345.44);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 50802.34544);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 50.80234544);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 0.050802345);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 1792);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 112);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 8);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 1.12);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 0.056);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 0.05);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox11.Text = frm2.textBox1.Text;
            if (label11.Text == "ton (US)")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 9.0718474 + minn11);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 907184740);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 907184.74);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 907.18474);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 0.90718474);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 32000);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 2000);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 142.8571529);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 20);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 17.85714286);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 0.892857143);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox12.Text = frm2.textBox1.Text;
            if (label12.Text == "ton (UK)")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 1.016046909 + minn12);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 1016046909);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 1016046.909);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 1016.046909);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 1.016046909);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 35840);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 2240);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 160);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 22.4);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 20);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 1.12);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
