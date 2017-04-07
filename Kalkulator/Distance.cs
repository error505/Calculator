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
    public partial class Distance : Form
    {
        public konv frm2;
        string min4 = "x10^-4";
        string min5 = "x10^-5";
        string min8 = "x10^-8";
        string min6 = "x10^-6";
        string min7 = "x10^-7";
        string min9 = "x10^-9";
        //string min10 = "x10^-10";
        string min12 = "x10^-12";
        string min13 = "x10^-13";
        string min14 = "x10^-14";
        string min15 = "x10^-15";
        string min16 = "x10^-16";
        string min17 = "x10^-17";
        string min18 = "x10^-18";
        string min19 = "x10^-19";
        string min20 = "x10^-20";
        string min21 = "x10^-21";
        //string min22 = "x10^-22";
        public Distance()
        {
            InitializeComponent();
        }

        private void Distance_Load(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {


            textBox1.Text = frm2.textBox1.Text;

            if (label1.Text == "μm")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.001);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min4);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min6);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1 + min9);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.039370079);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 3.937007874);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 3.280839895);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.093613298);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 6.213711922);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 5.399568035);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 5.468066492);
                textBox13.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 4.970969538);
                textBox14.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 4.970969538);
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.057000834);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = frm2.textBox1.Text;

            if (label2.Text == "mm")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.1);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.001);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.000001);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 39.37007874);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.039370079);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.00328084);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.001093613);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 6.213711922 + min7);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 5.399568035 + min7);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.000546807);
                textBox13.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 4.970969538 + min5);
                textBox14.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 4.970969538 + min6);
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 1.057000834 + min19);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = frm2.textBox1.Text;

            if (label3.Text == "cm")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 10000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 10);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.01);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1 + min5);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 393.7007874);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.393700787);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.032808399);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.010936133);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 6.213711922 + min6);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 5.399568035 + min6);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.005468066);
                textBox13.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 0.000497097);
                textBox14.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 4.970969538 + min5);
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * 1.057000834 + min18);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = frm2.textBox1.Text;

            if (label4.Text == "m")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1000000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 100);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.001);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 39370.07874);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 39.37007874);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 3.280839895);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1.093613298);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.000621371);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.000539957);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.546806649);
                textBox13.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.049709695);
                textBox14.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 0.00497097);
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 1.057000834 + min16);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text = frm2.textBox1.Text;

            if (label5.Text == "km")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1000000000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1000000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 100000);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1000);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 39370078.74);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 39370.07874);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 3280.839895);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1093.613298);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.621371192);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 0.539956803);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 546.8066492);
                textBox13.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 49.70969538);
                textBox14.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 4.970969538);
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * 1.057000834 + min13);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Text = frm2.textBox1.Text;
            
            if (label7.Text == "mil")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 25.4);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.0254);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.00254);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 2.54 + min5);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 2.54 + min8);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 0.001);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 8.333333333 + min5);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 2.777777778 + min5);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 1.578282828 + min8);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 1.371490281 + min8);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 1.388888889 + min5);
                textBox13.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 1.262626263 + min6);
                textBox14.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 1.262626263 + min7);
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * 2.684782118 + min21);
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.Text = frm2.textBox1.Text;

            if (label8.Text == "in")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 25.400);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 25.4);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 2.54);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.0254);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 2.54 + min5);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1000);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.08333333333);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.02777777778);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1.578282828 + min5);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1.371490281 + min5);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.013888889);
                textBox13.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.001262626);
                textBox14.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 0.000126263);
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 2.684782118 + min18);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox8.Text = frm2.textBox1.Text;

            if (label9.Text == "ft")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 304800);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 304.8);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 30.48);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.3048);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.00003048);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 12000);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 12);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.333333333);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.000189394);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.000164579);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.166666667);
                textBox13.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.015151515);
                textBox14.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 0.001515152);
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * 3.221738542 + min17);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox9.Text = frm2.textBox1.Text;

            if (label10.Text == "yd")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 914400);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 914.4);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 91.44);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.9144);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.0009144);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 36000);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 36);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 3);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.000568182);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.000493737);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.5);
                textBox13.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.045454545);
                textBox14.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 0.004545455);
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) * 9.665215626 + min17);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox10.Text = frm2.textBox1.Text;

            if (label11.Text == "mi")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 1609344000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 1609344);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 160934.4);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 1609.344);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 1.609344);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 63360000);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 63360);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 5280);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 1760);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 0.868976242);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 880);
                textBox13.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 80);
                textBox14.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 8);
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * 1.70107795 + min13);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox11.Text = frm2.textBox1.Text;

            if (label12.Text == "nm")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 1852000000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 1850000);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 185200);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 1852);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 1.852);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 72913385.83);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 72913.38583);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 6076.115486);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 2025.371829);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 1.150779448);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 1012.685914);
                textBox13.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 92.06235584);
                textBox14.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 9.206235584);
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) * 1.957565545 + min13);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox12.Text = frm2.textBox1.Text;

            if (label13.Text == "fm")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 1828800);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 1828.8);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 182.88);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 1.8288);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 0.0018288);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 72000);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 72);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 6);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 2);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 0.001136364);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 0.000987473);
                textBox13.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 0.090909091);
                textBox14.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 0.009090909);
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox12.Text) * 1.933043125 + min16);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox13.Text = frm2.textBox1.Text;

            if (label14.Text == "ch")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 20116800);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 20116.8);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 2011.68);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 20.1168);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 0.0201168);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 792000);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 792);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 66);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 22);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 0.0125);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 0.010862203);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 11);
                textBox14.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 0.1);
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) * 2.126347438 + min15);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox14.Text = frm2.textBox1.Text;

            if (label15.Text == "fur")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox14.Text) * 201168000);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox14.Text) * 201168);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox14.Text) * 20116.8);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox14.Text) * 201.168);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox14.Text) * 0.201168);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox14.Text) * 7920000);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox14.Text) * 7920);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox14.Text) * 660);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox14.Text) * 220);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox14.Text) * 0.125);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox14.Text) * 0.10862203);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox14.Text) * 110);
                textBox13.Text = Convert.ToString(Convert.ToDouble(textBox14.Text) * 10);
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox14.Text) * 2.126347438 + min14);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox15.Text = frm2.textBox1.Text;

            if (label16.Text == "ly")
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) * 9.460730473 + min21);
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) * 9.460730473 + min18);
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) * 9.460730473 + min17);
                textBox4.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) * 9.460730473 + min15);
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) * 9.460730473 + min12);
                textBox6.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) * 3.724697036 + min20);
                textBox7.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) * 3.724697036 + min17);
                textBox8.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) * 3.103914197 + min16);
                textBox9.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) * 1.034638066 + min16);
                textBox10.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) * 5.878625373 + min12);
                textBox11.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) * 5.108385784 + min12);
                textBox12.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) * 5.173190328 + min15);
                textBox13.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) * 4.702900299 + min14);
                textBox14.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) * 4.702900299 + min13);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
