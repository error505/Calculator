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
    public partial class volume : Form
    {
        public konv frm2;
        //string min4 = "x10^-4";
        string min5 = "x10^-5";
        //string min8 = "x10^-8";
        string min6 = "x10^-6";
        //string min7 = "x10^-7";
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
        public volume()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = frm2.textBox1.Text;
            if (label1.Text == "ml")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.001);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min6);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.061023744);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 3.531466672 + min5);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.307950619 + min6);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.03519508);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.001759754);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.000219969);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.033814023);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.0002113376);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.000264172);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = frm2.textBox1.Text;
            if (label2.Text == "l")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.001);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 61.02374409);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.0353146667);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.001307951);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 35.19507973);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1.759753986);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.219969248);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 33.8140227);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 2.113376419);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.264172052);
            }
        }
        private void volume_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = frm2.textBox1.Text;
            if (label3.Text == "m3")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1000000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1000);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 61023.74409);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 35.31466672);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1.307950619);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 35195.07973);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1759.753986);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 219.9692483);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 33814.0227);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 2113.376419);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 264.1720524);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = frm2.textBox1.Text;
            if (label4.Text == "cu in")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 16.387064);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.016387064);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 16387064 + min5);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.0000578704);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 2.143347051 + min5);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.576744024);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.028837201);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.00360465);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.0554112554);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.034632035);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.004329004);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = frm2.textBox1.Text;
            if (label5.Text == "cu ft")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 28316.84659);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 28.31684659);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.028316847);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1728);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.037037037);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 996.6136734);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 49.83068367);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 6.228835459);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 957.5064935);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 59.84415584);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 7.480519481);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = frm2.textBox1.Text;
            if (label6.Text == "cu yd")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 764554.858);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 764.554858);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.764554858);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 46656);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 27);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 26908.56918);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 1345.428459);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 168.1785574);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 25852.67532);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 1615.792208);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 201.974026);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Text = frm2.textBox1.Text;
            if (label7.Text == "fl oz (lmp)")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 28.4130625);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.028413062);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 2.84130625 + min5);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1.733871455);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.001003398);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 3.716288269 + min5);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.05);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.00625);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.96075994);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.060047496);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.007505937);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox8.Text = frm2.textBox1.Text;
            if (label8.Text == "pt (lmp)")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 568.26125);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.56826125);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.000568261);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 34.6774291);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.020067957);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.000743258);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 20);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.125);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 19.21519881);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 1.200949926);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.150118741);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox9.Text = frm2.textBox1.Text;
            if (label9.Text == "gal (lmp)")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 4546.09);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 4.54609);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.00454609);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 277.4194328);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.160543653);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.005946061);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 160);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 8);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 153.7215905);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 9.607599404);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 1.200949926);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox10.Text = frm2.textBox1.Text;
            if (label10.Text == "fl oz (US)")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 29.57352956);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 0.02957353);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 2.957352956 + min5);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 1.8046875);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 0.001044379);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 3.868071631 + min5);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 1.040842731);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 0.052042137);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 0.006505267);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 0.0625);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 0.0078125);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox11.Text = frm2.textBox1.Text;
            if (label11.Text == "pt (US)")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 473.176473);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 0.473176473);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 0.000473176);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 28.875);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 0.016710069);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 0.000618891);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 16.65348369);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 0.832674185);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 0.104084273);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 16);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 0.125);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox12.Text = frm2.textBox1.Text;
            if (label12.Text == "gal (US)")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 3785.411784);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 3.785411784);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 0.003785412);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 231);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 0.133680556);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 0.004951132);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 133.2278695);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 6.661393477);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 0.832674185);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 128);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 8);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
