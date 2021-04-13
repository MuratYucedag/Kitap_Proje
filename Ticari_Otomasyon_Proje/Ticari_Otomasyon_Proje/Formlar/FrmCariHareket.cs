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
    public partial class FrmCariHareket : Form
    {
        public FrmCariHareket()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmCariHareket_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLCARIHAREKET
                                       select new
                                       {
                                           x.SATISID,
                                           x.TBLURUN.URUNAD,
                                           Cari = x.TBLCARI.AD + x.TBLCARI.SOYAD,
                                           Personel = x.TBLPERSONEL.PERSONELAD + x.TBLPERSONEL.PERSONELSOYAD,
                                           x.TARIH,
                                           x.BIRIMFIYAT,
                                           x.ADET,
                                           x.TOPLAM
                                       }).ToList();

            LblToplamSatis.Text = db.TBLCARIHAREKET.Count().ToString();
            DateTime bugun = new DateTime();
            bugun = DateTime.Today;
            LblBugunkuSatis.Text = db.TBLCARIHAREKET.Where(x => x.TARIH == bugun).Count().ToString();
            var deger = db.TBLCARIHAREKET.GroupBy(x => x.URUN).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            LblEnFazlaSatilanUrun.Text = db.TBLURUN.Where(x => x.URUNID == deger).Select(y => y.URUNAD).FirstOrDefault().ToString();

            var deger2 = db.TBLCARIHAREKET.GroupBy(x => x.CARI).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            LblCari.Text = db.TBLCARI.Where(x => x.CARIID == deger2).Select(y => y.AD + " "+y.SOYAD).FirstOrDefault().ToString();
        }
    }
}