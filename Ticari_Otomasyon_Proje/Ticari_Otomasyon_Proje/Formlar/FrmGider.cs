using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.Entity;

namespace Ticari_Otomasyon_Proje.Formlar
{
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLGIDERLER t = new TBLGIDERLER();
            t.TUTAR = decimal.Parse(TxtTutar.Text);
            t.ACIKLAMA = TxtAciklama.Text;
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            db.TBLGIDERLER.Add(t);
            db.SaveChanges();

            TBLKASA t2 = new TBLKASA();
            t2.TUTAR = decimal.Parse(TxtTutar.Text);
            t2.ACIKLAMA = TxtAciklama.Text;
            t2.TARIH = DateTime.Parse(TxtTarih.Text);
            t2.TUR = "Çıkış";
            db.TBLKASA.Add(t2);
            db.SaveChanges();
            XtraMessageBox.Show("Gider sisteme başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}