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
    public partial class konv : Form
    {
        public Calculator frm1;
        public konv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Distance frm3 = new Distance();
            frm3.frm2 = this;
            frm3.ShowDialog();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void konv_Load(object sender, EventArgs e)
        {
            textBox1.Text = ((Calculator)frm1).textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            area frm4 = new area();
            frm4.frm2 = this;
            frm4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            volume frm5 = new volume();
            frm5.frm2 = this;
            frm5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mass frm6 = new mass();
            frm6.frm2 = this;
            frm6.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            speed frm7 = new speed();
            frm7.frm2 = this;
            frm7.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            time frm8 = new time();
            frm8.frm2 = this;
            frm8.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            force frm9 = new force();
            frm9.frm2 = this;
            frm9.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            preasure frm10 = new preasure();
            frm10.frm2 = this;
            frm10.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            energy frm11 = new energy();
            frm11.frm2 = this;
            frm11.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            power frm12 = new power();
            frm12.frm2 = this;
            frm12.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            fuel frm13 = new fuel();
            frm13.frm2 = this;
            frm13.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            temperature frm14 = new temperature();
            frm14.frm2 = this;
            frm14.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            data frm15 = new data();
            frm15.frm2 = this;
            frm15.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
