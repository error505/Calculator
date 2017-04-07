using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using NCalc;
using System.IO;

namespace Kalkulator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();          
        }

        //public string text
        //{
        //    get
        //    {
        //        return textBox1.Text;
        //    }
        //}

        float num1, num2, num3;
        //decimal memory = 0;
        string memory = "";
        //private konv konvForm;
        //private MoreForm moreForm;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '0';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '1';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '2';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '3';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '4';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '5';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '6';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '7';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '8';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '9';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '.';
            button2.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            button18.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '+';
            button3.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '-';
            button8.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '*';
            button12.Enabled = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '/';
            button16.Enabled = true;
        }

        MathParser.Parser p = new MathParser.Parser();
        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (p.Evaluate(textBox1.Text))
                    Convert.ToDouble(p.Result);
                textBox1.Text = p.Result.ToString();
            }
            //if (label1.Text == "+")
            //{

            //    num3 = num1 + num2;

            //    textBox1.Text = Convert.ToString(num3);
            //}

            //if (label1.Text == "-")
            //{
            //    num3 = num1 - num2;

            //    textBox1.Text = Convert.ToString(num3);
            //}

            //if (label1.Text == "*")
            //{
            //    num3 = num1 * num2;

            //    textBox1.Text = Convert.ToString(num3);
            //}

            //if (label1.Text == "/")
            //{
            //    num3 = num1 / num2;

            //    textBox1.Text = Convert.ToString(num3);
            //}
            //if (label1.Text == "%")
            //{
            //    num3 = (num1 / num2) * 100;

            //    textBox1.Text = Convert.ToString(num3);
            //}

            //if (label1.Text == "^")
            //{
            //    double dob = Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox1.Text));
            //    textBox1.Text = "";
            //    textBox1.Text = dob.ToString();          
            //}
            //if (label1.Text == "%")
            //{
            //    textBox1.Text = mp.Calculate(textBox1.Text).ToString();
            //}

            //if (label1.Text == "MS")
            //{
            //    memory = decimal.Parse(textBox1.Text);
            //    textBox1.Clear();
            //}

            //if (label1.Text == "M-")
            //{
            //    memory = memory - decimal.Parse(textBox1.Text);
            //}

            //if (label1.Text == "MR")
            //{
            //    textBox1.Text = memory.ToString();
            //}

            //if (label1.Text == "MC")
            //{
            //    memory = 0;
            //}

            //if (label1.Text == "M+")
            //{
            //    memory = memory + decimal.Parse(textBox1.Text);

            //}

            //if (label1.Text == "(")
            //{
            //    textBox1.Text = Convert.ToString(num3);

            //}

            //if (label1.Text == "(")
            //{

            //    textBox1.Text = Convert.ToString(num3);
            //}

        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Faktorijel
            textBox1.Text = textBox1.Text + "!";
            //int n, s = 1;
            //n = Convert.ToInt32(textBox1.Text);
            //if (n == 0)
            //{
            //    label1.Text = s.ToString();
            //}
            //else
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        s = s * i;
            //        label1.Text = s.ToString();
            //    }
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "sqrt";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-"))
            {
                textBox1.Text = textBox1.Text.Remove(0, 1);
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString((Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(textBox1.Text)));
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(((Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(textBox1.Text))));
        }

        private void button23_Click(object sender, EventArgs e)
        {
            memory = textBox1.Text;
            label1.Text = "M+";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            memory = "";
            label1.Text = "MC";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory;
            label1.Text = "MR";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "%";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //textBox1.Text = Convert.ToString(Math.Log10(Convert.ToDouble(textBox1.Text)));
            textBox1.Text = textBox1.Text + "log";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //textBox1.Text += button28.Text;
            //label1.Text = "(";
            textBox1.Text = textBox1.Text + '(';
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //textBox1.Text += button29.Text;
            //label1.Text = ")";
            textBox1.Text = textBox1.Text + ')';
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //double pi = Math.PI;
            //textBox1.Text = Convert.ToString(pi);
            textBox1.Text = textBox1.Text + "Pi";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //textBox1.Text = (Math.Sin(Convert.ToDouble(textBox1.Text))).ToString();
            textBox1.Text = textBox1.Text + "sin";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((1 / Convert.ToDouble(textBox1.Text))).ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //textBox1.Text = (Math.Cos(Convert.ToDouble(textBox1.Text))).ToString();
            textBox1.Text = textBox1.Text + "cos";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //textBox1.Text = (Math.Tan(Convert.ToDouble(textBox1.Text))).ToString();
            textBox1.Text = textBox1.Text + "tan";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //double dob = Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(label1.Text));
            //textBox1.Text = "";
            //textBox1.Text = dob.ToString();
            //label1.Text = "^";
            //num1 = float.Parse(textBox1.Text);
            //textBox1.Text = "";
            //button35.Enabled = true;
            textBox1.Text = textBox1.Text + "^";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            //textBox1.Text = (Math.Log(Convert.ToDouble(textBox1.Text))).ToString();
            textBox1.Text = textBox1.Text + "ln";
        }

        //private void button38_Click(object sender, EventArgs e)
        //{
        //    double dob = Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox1.Text));
        //    textBox1.Text = "";
        //    textBox1.Text = dob.ToString();
        //}

        private void button38_Click_1(object sender, EventArgs e)
        {
            //textBox1.Text = (Math.Cosh(Convert.ToDouble(textBox1.Text))).ToString();
            textBox1.Text = textBox1.Text + "cosh";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            //textBox1.Text = (Math.Sinh(Convert.ToDouble(textBox1.Text))).ToString();
            textBox1.Text = textBox1.Text + "sinh";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            //textBox1.Text = (Math.Tanh(Convert.ToDouble(textBox1.Text))).ToString();
            textBox1.Text = textBox1.Text + "tanh";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Round(Convert.ToDouble(textBox1.Text))).ToString();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            //textBox1.Text = (Math.Asin(Convert.ToDouble(textBox1.Text))).ToString();
            textBox1.Text = textBox1.Text + "asin";
        }

        private void button45_Click(object sender, EventArgs e)
        {
            //textBox1.Text = (Math.Acos(Convert.ToDouble(textBox1.Text))).ToString();
            textBox1.Text = textBox1.Text + "acos";
        }

        private void button46_Click(object sender, EventArgs e)
        {
            //textBox1.Text = (Math.Atan(Convert.ToDouble(textBox1.Text))).ToString();
            textBox1.Text = textBox1.Text + "atan";
        }

        //private void button47_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = (Math.Floor(Convert.ToDouble(textBox1.Text))).ToString();
        //}

        //private void button48_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = (Math.Ceiling(Convert.ToDouble(textBox1.Text))).ToString();
        //}

        private void button49_Click(object sender, EventArgs e)
        {
            //textBox1.Text = (Math.Abs(Convert.ToDouble(textBox1.Text))).ToString();
            textBox1.Text = textBox1.Text + "abs";
        }

        private void button51_Click(object sender, EventArgs e)
        {
            //textBox1.Text = (Math.Exp(Convert.ToDouble(textBox1.Text))).ToString();
            textBox1.Text = textBox1.Text + "exp";
        }

        private void button50_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0.25";
        }

        private void button52_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0.5";
        }

        private void button54_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0.75";
        }

        private void button53_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0.000000000066742";
        }

        private void button55_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1.324717957244746";
        }

        private void button56_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2.7182818284590452";
        }

        private void button57_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1.618033988749894";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            konv frm2 = new konv();
            frm2.frm1 = this;
            frm2.ShowDialog();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            financ fin = new financ();
            fin.ShowDialog();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            formula formul = new formula();
            formul.ShowDialog();
        }

        private void Calculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ceil";
        }

        private void button53_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "floor";
        }

        private void button55_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "sign";
        }
        
        private void button58_Click(object sender, EventArgs e)
        {
            p.Mode = MathParser.Mode.RAD;
            label1.Text = "RAD";
            
        }

        void button58_Click2(object sender, EventArgs e)
        {
            
            p.Mode = MathParser.Mode.DEG;
            label1.Text = "DEG";

        }

        void button58_Click3(object sender, EventArgs e)
        {

            p.Mode = MathParser.Mode.GRAD;
            label1.Text = "GRAD";

        }
        void button58_Click4(object sender, EventArgs e)
        {

            p.Mode = MathParser.Mode.RAD;
            label1.Text = "RAD";

        }

        private void button59_Click(object sender, EventArgs e)
        {
            p.Mode = MathParser.Mode.DEG;
            label1.Text = "DEG";
        }

        private void button60_Click(object sender, EventArgs e)
        {
            p.Mode = MathParser.Mode.GRAD;
            label1.Text = "GRAD";
        }

    }
}