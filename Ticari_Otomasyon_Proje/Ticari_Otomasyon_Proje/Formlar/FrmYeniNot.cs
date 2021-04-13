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
    public partial class FrmYeniNot : Form
    {
        public FrmYeniNot()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLNOTLAR t = new TBLNOTLAR();
            t.BASLIK = TxtBaslik.Text;
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            t.SAAT = TimeSpan.Parse(TxtSaat.Text);
            t.ICERIK = Txticerik.Text;
            t.DURUM = true;
            db.TBLNOTLAR.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Not bilgisi sisteme kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}