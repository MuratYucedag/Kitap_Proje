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
    public partial class FrmCariSatisListesi : Form
    {
        public FrmCariSatisListesi()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmCariSatisListesi_Load(object sender, EventArgs e)
        {
            var satis_listesi = from x in db.TBLCARIHAREKET
                                select new
                                {
                                    x.SATISID,
                                    x.TBLURUN.URUNAD,
                                    x.ADET,
                                    x.BIRIMFIYAT,
                                    x.TOPLAM,
                                    Cari = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                                    Personel = x.TBLPERSONEL.PERSONELAD + " " + x.TBLPERSONEL.PERSONELSOYAD,
                                    x.TARIH
                                };
            gridControl1.DataSource = satis_listesi.ToList();
        }
    }
}