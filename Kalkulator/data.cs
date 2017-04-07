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
    public partial class data : Form
    {
        public konv frm2;
        //string min4 = "x10^-4";
        //string min5 = "x10^-5";
        //string min8 = "x10^-8";
        string min6 = "x10^-6";
        string min7 = "x10^-7";
        string min9 = "x10^-9";
        string min10 = "x10^-10";
        //string min11 = "x10^-11";
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
        public data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             textBox1.Text = frm2.textBox1.Text;
             if (label1.Text == "B")
             {
                 textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.000976562);
                 textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 9.536743164 + min7);
                 textBox4.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 9.313225746 + min10);
                 textBox5.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 9.094947018 + min13);
                 textBox6.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.001);
                 textBox7.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min6);
                 textBox8.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min9);
                 textBox9.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min12);
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = frm2.textBox1.Text;
            if (label2.Text == "KiB")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1024);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.000976562);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 9.313225746 + min7);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 9.094947018 + min10);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1024);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.001024);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1.024 + min6);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1.024 + min9);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = frm2.textBox1.Text;
            if (label3.Text == "MiB")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1048576);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1024);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.000976562);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 9.536743164 + min7);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1048.576);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1.048576);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.001048576);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1.048576 + min6);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = frm2.textBox1.Text;
            if (label4.Text == "GiB")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1073741824);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1048576);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1024);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.000976562);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1073741.824);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1073.741824);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1.073741824);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.001073742);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = frm2.textBox1.Text;
            if (label5.Text == "TiB")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1.099511628 + minn12);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1073741824);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1048576);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1024);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1099511628);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1099511.628);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1099.511628);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1.099511628);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = frm2.textBox1.Text;
            if (label6.Text == "kB")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 1000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.9765625);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.000953674);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 9.313225746 + min7);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 9.094947018 + min10);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.001);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 1 + min6);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 1 + min9);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Text = frm2.textBox1.Text;
            if (label7.Text == "MB")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1000000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 976.5625);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.953674316);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.000931323);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 9.094947018 + min7);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1000);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.001);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1 + min6);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox8.Text = frm2.textBox1.Text;
            if (label8.Text == "GB")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 1000000000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 976562.5);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 953.6743164);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.0931322575);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.000909495);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 1000000);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 1000);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.001);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox9.Text = frm2.textBox1.Text;
            if (label9.Text == "TB")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 1 + minn12);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 976562500);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 953674.3164);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 931.32257546);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.909494702);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 1000000000);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 1000000);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 1000);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data-size units follow the IEC standard, where kibi-, mebi- and gibi- etc are multiples of 1024 and kilo-, mega-, giga- etc are multiples of 1000. Please see en.wikipedia.org/wiki/Kibibyte for more info.", "Data Size");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
