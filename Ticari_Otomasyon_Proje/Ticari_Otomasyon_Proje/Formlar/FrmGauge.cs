using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon_Proje.Formlar
{
    public partial class FrmGauge : Form
    {
        public FrmGauge()
        {
            InitializeComponent();
        }

        private void FrmGauge_Load(object sender, EventArgs e)
        {
            timer1.Start();
            arcScaleComponent1.Value = 0;
            arcScaleComponent2.Value = 0;
            arcScaleComponent3.Value = 0;
            digitalGauge3.Text = "Selam";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            arcScaleComponent1.Value += 10;
            arcScaleComponent2.Value += 10;
            arcScaleComponent3.Value += 10;
            if (arcScaleComponent1.Value == 100)
            {
                timer1.Stop();
            }
        }
    }
}