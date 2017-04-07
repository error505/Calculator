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
    public partial class formula : Form
    {
        public formula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmsareas frareas = new frmsareas();
            frareas.ShowDialog();
        }

        private void formula_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pythagora pitagora = new pythagora();
            pitagora.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            distancef distance = new distancef();
            distance.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            trigonometry trig = new trigonometry();
            trig.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            basicfrms basic = new basicfrms();
            basic.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Vectors vect = new Vectors();
            vect.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AnalitycG analit = new AnalitycG();
            analit.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DiferentialC dif = new DiferentialC();
            dif.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IntegralC integ = new IntegralC();
            integ.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DifEq dif = new DifEq();
            dif.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Series ser = new Series();
            ser.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Probability prob = new Probability();
            prob.ShowDialog();
        }
    }
}
