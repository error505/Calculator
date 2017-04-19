using System;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Konv : Form
    {
        public Calculator Frm1;
        public Konv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm3 = new Distance {frm2 = this};
            frm3.ShowDialog();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void konv_Load(object sender, EventArgs e)
        {
            textBox1.Text = ((Calculator)Frm1).InputBox.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var areaFrm4= new area {frm2 = this};
            areaFrm4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var volumeFrm = new volume {frm2 = this};
            volumeFrm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var massFrm = new mass {frm2 = this};
            massFrm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frm7 = new speed {frm2 = this};
            frm7.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var frm8 = new time {frm2 = this};
            frm8.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var frm9 = new force {frm2 = this};
            frm9.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var frm10 = new preasure {frm2 = this};
            frm10.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var frm11 = new energy {frm2 = this};
            frm11.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var powerForm = new power {frm2 = this};
            powerForm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var fuelForm = new fuel {frm2 = this};
            fuelForm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var temperatureFrm = new temperature {frm2 = this};
            temperatureFrm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var dataFrm = new data {frm2 = this};
            dataFrm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
