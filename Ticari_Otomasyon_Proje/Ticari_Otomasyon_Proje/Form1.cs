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

namespace Ticari_Otomasyon_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKategoriler frm = new FrmKategoriler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BrnUrunistatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Frmistatistikler frm = new Formlar.Frmistatistikler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnKategoriİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKategoriİstatistik frm = new Formlar.FrmKategoriİstatistik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKategoriEkle fr = new Formlar.FrmKategoriEkle();
            fr.Show();
        }

        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunEkle fr = new Formlar.FrmUrunEkle();
            fr.Show();
        }

        private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariListesi fr = new Formlar.FrmCariListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariKart fr = new Formlar.FrmCariKart();
            fr.Show();
        }

        private void BtnCariistatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariistatistik frm = new Formlar.FrmCariistatistik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnCariHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariHareket frm = new Formlar.FrmCariHareket();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersonel frm = new Formlar.FrmPersonel();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartman fr = new Formlar.FrmDepartman();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnKasaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKasaListesi fr = new Formlar.FrmKasaListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGider fr = new Formlar.FrmGider();
            fr.Show();
        }

        private void BtnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKurlar fr = new Formlar.FrmKurlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnDovizDonusum_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDovizDonusum fr = new Formlar.FrmDovizDonusum();
            fr.Show();
        }

        private void BtnAjanda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmAjanda fr = new Formlar.FrmAjanda();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniNot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniNot fr = new Formlar.FrmYeniNot();
            fr.Show();
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnHeaspMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void BtnGauge_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGauge fr = new Formlar.FrmGauge();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYoutube fr = new Formlar.FrmYoutube();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYardim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Projede alacağınız her türlü hata için test@gmail.com mail adresi üzerinden bize ulaşabilirsiniz. \n\nBuna ek olarak +90 (123) (45-67) numaralı telefondan direkt arayarak veya Whatsapp uygulaması üzerinden\n\nsorularınızı bize iletirseniz en hızlı şekilde dönüş sağlayıp probleminizi çözmeniz için yardımcı olabiliriz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnHarita_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmHarita fr = new Formlar.FrmHarita();
            fr.MdiParent = this;
            fr.Show();
        }
        Formlar.FrmAnaForm frm1;
        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new Formlar.FrmAnaForm();
                frm1.MdiParent = this;
                frm1.Show();
            }
        }

        private void BtnQR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmQR fr = new Formlar.FrmQR();
            fr.Show();
        }

        private void BtnBarcode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmBarkod fr = new Formlar.FrmBarkod();
            fr.Show();
        }

        private void BtnUrunRaporlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunRapor fr = new Formlar.FrmUrunRapor();
            fr.Show();
        }

        private void BtnCariSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariSatisListesi fr = new Formlar.FrmCariSatisListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniSatisislemi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniSatis fr = new Formlar.FrmYeniSatis();
            fr.Show();
        }

        private void BtnRapor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmRaporlar fr = new Formlar.FrmRaporlar();
            fr.Show();
        }

        private void BtnMetniSeslendir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmMetniSeslendir fr = new Formlar.FrmMetniSeslendir();
            fr.Show();
        }

        private void BtnKonus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmSpeechToTest fr = new Formlar.FrmSpeechToTest();
            fr.Show();
        }
    }
}

