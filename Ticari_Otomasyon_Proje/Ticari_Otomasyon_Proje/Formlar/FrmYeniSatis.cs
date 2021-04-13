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
    public partial class FrmYeniSatis : Form
    {
        public FrmYeniSatis()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void FrmYeniSatis_Load(object sender, EventArgs e)
        {
            //Ürün Listesi
            lookUpEditUrun.Properties.DataSource = (from x in db.TBLURUN
                                                    select new
                                                    {
                                                        x.URUNID,
                                                        x.URUNAD
                                                    }).ToList();

            //Personel Listesi
            LookUpEditPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                        select new
                                                        {
                                                            x.PERSONELID,
                                                            PERSONEL = x.PERSONELAD + " " + x.PERSONELSOYAD
                                                        }).ToList();

            //Cari Listesi
            lookUpEditCari.Properties.DataSource = (from x in db.TBLCARI
                                                    select new
                                                    {
                                                        x.CARIID,
                                                        CARI = x.AD + " " + x.SOYAD
                                                    }).ToList();
        }

        private void lookUpEditUrun_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(lookUpEditUrun.EditValue.ToString());
            var birimfiyat = db.TBLURUN.Where(x => x.URUNID == secilen).Select(y => y.SATISFIYAT).FirstOrDefault();
            TxtBirimFiyat.Text = birimfiyat.ToString();
        }

        private void TxtAdet_EditValueChanged(object sender, EventArgs e)
        {
            int adet = int.Parse(TxtAdet.Text);
            double birimfiyat = double.Parse(TxtBirimFiyat.Text);
            double toplam = adet * birimfiyat;
            TxtToplam.Text = toplam.ToString();
        }

        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            TBLCARIHAREKET t = new TBLCARIHAREKET();
            t.URUN= int.Parse(lookUpEditUrun.EditValue.ToString());
            t.PERSONEL= int.Parse(LookUpEditPersonel.EditValue.ToString());
            t.CARI= int.Parse(lookUpEditCari.EditValue.ToString());
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            t.ADET = short.Parse(TxtAdet.Text);
            t.BIRIMFIYAT = decimal.Parse(TxtBirimFiyat.Text);
            t.TOPLAM = decimal.Parse(TxtToplam.Text);
            t.ACIKLAMA = TxtAciklama.Text;
            db.TBLCARIHAREKET.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Satış işlemi başarılı bir şekilde gerçekleşti", "Cari Satış İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}