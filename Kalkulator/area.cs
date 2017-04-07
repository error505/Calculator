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
    public partial class area : Form
    {
        public konv frm2;
        //string min4 = "x10^-4";
        string min5 = "x10^-5";
        string min8 = "x10^-8";
        string min6 = "x10^-6";
        string min7 = "x10^-7";
        //string min9 = "x10^-9";
        string min10 = "x10^-10";
        string min11 = "x10^-11";
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
        public area()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = frm2.textBox1.Text;
            if (label1.Text == "mm2")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.01);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min6);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min10);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min12);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.001550003);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.076391042 + min5);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.195990046 + min6);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 2.471053815 + min10);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 3.861021585 + min13);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = frm2.textBox1.Text;
            if (label2.Text == "cm2")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 100);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.0001);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1 + min8);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1 + min10);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.15500031);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.001076391);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.000119599);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 2.471053815 + min8);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 3.861021585 + min11);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = frm2.textBox1.Text;
            if (label3.Text == "m2")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1000000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 10000);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.0001);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1 + min6);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1.5500031);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 10.76391042);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1.195990046);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.000247105);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 3.861021585 + min7);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = frm2.textBox1.Text;
            if (label4.Text == "ha")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1 + min10);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 100000000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 10000);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.01);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 15.500031);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 107.6391042);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 11.95990046);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 2.471053815);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.003861022);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = frm2.textBox1.Text;
            if (label5.Text == "km2")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1 + min12);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1 + min10);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1000000);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 100);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1550003100);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 10763910.42);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1195990.046);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 247.1053815);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.386102159);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = frm2.textBox1.Text;
            if (label6.Text == "sq in")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 645.16);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 6.4516);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.00064516);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 6.4516 + min8);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 6.4516 + min10);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.006944444);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.000771605);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 1.594225079 + min7);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 2.490976684 + min10);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Text = frm2.textBox1.Text;
            if (label7.Text == "sq ft")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 92903.04);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 929.0304);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.09290304);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 9.290304 + min6);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 9.290304 + min8);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 144);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.111111111);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 2.295684114 + min5);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 3.587006428 + min8);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox8.Text = frm2.textBox1.Text;
            if (label8.Text == "sq yd")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 836127.36);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 8361.2736);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.83612736);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 8.3612736 + min5);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 8.3612736 + min7);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 1296);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 9);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.000206612);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 3.228305785 + min7);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox9.Text = frm2.textBox1.Text;
            if (label9.Text == "ac")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 4046856422);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 40468564.22);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 4046.856422);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.404685642);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.004046856);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 6272640);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 43560);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 4840);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.0015625);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox10.Text = frm2.textBox1.Text;
            if (label10.Text == "sq mi")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 2.58998811 + min12);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 2.58998811 + min10);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 2589988.11);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 258.998811);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 2.58998811);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 4014489600);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 27878400);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 3097600);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 640);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
