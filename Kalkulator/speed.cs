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
    public partial class speed : Form
    {
        public konv frm2;
        //string min4 = "x10^-4";
        //string min5 = "x10^-5";
        //string min8 = "x10^-8";
        //string min6 = "x10^-6";
        //string min7 = "x10^-7";
        //string min9 = "x10^-9";
        //string min10 = "x10^-10";
        //string minn10 = "x10^10";
        //string minn11 = "x10^11";
        //string min11 = "x10^-11";
        //string minn12 = "x10^12";
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
        public speed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = frm2.textBox1.Text;
            if (label1.Text == "m/s")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 3.6);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 3.280839895);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 2.236936292);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.943844492);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = frm2.textBox1.Text;
            if (label2.Text == "km/h")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.277777778);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.911344415);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.621371192);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.539956803);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = frm2.textBox1.Text;
            if (label3.Text == "ft/s")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.3048);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1.09728);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.681818182);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.592483801);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = frm2.textBox1.Text;
            if (label4.Text == "mph")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.44704);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1.609344);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1.466666667);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.868976242);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = frm2.textBox1.Text;
            if (label5.Text == "kt")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.514444444);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1.852);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1.687809857);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1.150779448);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
