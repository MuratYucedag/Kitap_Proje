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
    public partial class FrmDovizDonusum : Form
    {
        public FrmDovizDonusum()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar = 0;
            kur = Convert.ToDouble(TxtKur.Text);
            miktar = Convert.ToDouble(TxtMiktar.Text);
            tutar = kur * miktar;
            TxtTutar.Text = tutar.ToString();
        }

        private void Btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}