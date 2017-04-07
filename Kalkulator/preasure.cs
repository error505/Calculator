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
    public partial class preasure : Form
    {
        public konv frm2;
        //string min4 = "x10^-4";
        string min5 = "x10^-5";
        //string min8 = "x10^-8";
        string min6 = "x10^-6";
        //string min7 = "x10^-7";
        //string min9 = "x10^-9";
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
        public preasure()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = frm2.textBox1.Text;

            if (label1.Text == "Pa")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.01);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.001);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min6);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.01);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min5);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 9.869232667 + min6);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.000145038);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.0002953);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.007500617);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = frm2.textBox1.Text;

            if (label2.Text == "hPa")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 100);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.1);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.0001);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.001);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.000986923);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.014503774);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.02952998);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.750061683);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = frm2.textBox1.Text;
            if (label3.Text == "kPa")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 10);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.001);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 10);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.01);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.009869233);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.145037738);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.295299802);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 7.500616827);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = frm2.textBox1.Text;
            if (label4.Text == "MPa")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1000000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 10000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1000);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 10000);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 10);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 9.869232667);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 145.0377378);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 295.2998016);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 7500.616827);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text = frm2.textBox1.Text;
            if (label5.Text == "mbar")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 100);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.1);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.0001);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.001);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.000986923);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.014503774);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.02952998);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.750061683);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Text = frm2.textBox1.Text;
            if (label7.Text == "bar")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 100000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 1000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 100);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.1);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 1000);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.986923267);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 14.50377378);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 29.52998016);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 750.0616827);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.Text = frm2.textBox1.Text;
            if (label8.Text == "atm")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 101325);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1013.25);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 101.325);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.101325);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1013.25);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1.01325);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 14.69594878);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 29.9212524);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 760);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox8.Text = frm2.textBox1.Text;
            if (label9.Text == "psi")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 6894.75729);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 68.9475729);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 6.89475729);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.006894757);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 68.9475729);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.068947573);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.068045964);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 2.03602046);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 51.71493255);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox9.Text = frm2.textBox1.Text;
            if (label10.Text == "in Hg")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 3386.389);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 33.86389);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 3.386389);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.003386389);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 33.86389);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.03386389);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.033421061);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.4911542);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 25.40000632);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox10.Text = frm2.textBox1.Text;
            if (label11.Text == "Torr")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 133.3223684);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 1.333223684);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 0.133322368);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 0.000133322);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 1.333223684);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 0.001333224);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 0.001315789);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 0.019336775);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 0.039370069);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
