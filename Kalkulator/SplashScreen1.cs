using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Kalkulator
{
    public partial class SplashScreen1 : SplashScreen
    {
        public SplashScreen1()
        {
            InitializeComponent();
        }
        Timer t;

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void SplashScreen1_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 2000;
            t.Start();
            t.Tick += new EventHandler(t_Tick);
        }
        void t_Tick(object sender, EventArgs e)
        {
            t.Stop();
            Calculator calc = new Calculator();
            calc.Show();
            this.Hide();
        }

        private void marqueeProgressBarControl1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}