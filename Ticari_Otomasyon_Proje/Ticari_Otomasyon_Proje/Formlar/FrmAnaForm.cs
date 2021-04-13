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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            //Grid Control Ürün Stok
            var urun_stok = from x in db.TBLURUN
                            select new
                            {
                                x.URUNAD,
                                x.STOK
                            };
            GridUrunStok.DataSource = urun_stok.ToList();

            //Grid Control Son 10 Stok
            var son10satis = from x in db.TBLCARIHAREKET
                             select new
                             {
                                 x.TBLURUN.URUNAD,
                                 x.ADET,
                                 x.TOPLAM,
                                 x.SATISID
                             };
            GridSon10Satis.DataSource = son10satis.OrderByDescending(x => x.SATISID).Take(10).ToList();
            GridViewSon10Satis.Columns["SATISID"].Visible = false;

            ///Bugün Yapılacaklar
            DateTime bugun = DateTime.Today;
            var bugunyapilacaklar = (from x in db.TBLNOTLAR
                                     select new
                                     {
                                         x.BASLIK,
                                         x.SAAT,
                                         x.TARIH
                                     }).Where(x => x.TARIH == bugun).ToList();
            GridBugunYapilacaklar.DataSource = bugunyapilacaklar;
            GridViewBugunYapilacaklar.Columns["TARIH"].Visible = false;

            //Cari Fihrist
            var carifihrist = (from x in db.TBLCARI
                               select new
                               {
                                   x.AD,
                                   x.SOYAD,
                                   x.TELEFON
                               }).ToList();
            GridCariFihrist.DataSource = carifihrist;

            webBrowser1.Navigate("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");

        }
    }
}
