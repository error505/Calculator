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
    public partial class financ : Form
    {
        public financ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateInterest simpleinterest = new CalculateInterest();
            //assigning principal field to principal textbox
            simpleinterest.principal = int.Parse(textBox1.Text);
            //assigning rate field to rate textbox
            simpleinterest.rate = int.Parse(textBox2.Text);
            //assigning period field to period textbox
            simpleinterest.period = int.Parse(textBox3.Text);

            //calling the the SimpleInterest calculation  method
            simpleinterest.SimpleInterest();
            //calling the SimpleInterestAmount calculation method
            simpleinterest.SimpleInterestAmount();

            //assigning the calculated interest to interest textbox
            textBox4.Text = simpleinterest.interest.ToString();
            //assigning the calculated future value to the amount textbox
            textBox5.Text = simpleinterest.amount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
