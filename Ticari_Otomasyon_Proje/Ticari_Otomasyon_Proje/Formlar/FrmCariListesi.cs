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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLCARI
                                       select new
                                       {
                                           x.CARIID,
                                           x.AD,
                                           x.SOYAD,
                                           x.IL,
                                           x.ILCE,
                                           x.ADRES,
                                           x.MAIL,
                                           x.TC,
                                           x.TELEFON,
                                           x.VERGIDAIRESI
                                       }).ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.IL = LookUpEditil.Text;
            t.ILCE = LookUpEditilce.Text;
            t.TELEFON = TxtTelefon.Text;
            t.ADRES = TxtAdres.Text;
            t.MAIL = TxtMail.Text;
            t.TC = TxtTC.Text;
            t.VERGIDAIRESI = TxtVergiDairesi.Text;
            db.TBLCARI.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Cari sisteme başarılı bir şekilde eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            LookUpEditil.Properties.DataSource = (from x in db.TBLILLER
                                                  select new
                                                  {
                                                      x.id,
                                                      x.sehir
                                                  }).ToList();
        }

        private void LookUpEditil_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(LookUpEditil.EditValue.ToString());
            LookUpEditilce.Properties.DataSource = (from y in db.TBLILCELER
                                                    select new
                                                    {
                                                        y.id,
                                                        y.ilce,
                                                        y.sehir
                                                    }).Where(z => z.sehir == secilen).ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("CARIID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            TxtTC.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            TxtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            TxtAdres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
            TxtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRESI").ToString();
            LookUpEditil.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            LookUpEditilce.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtID.Text != "")
            {
                int id = int.Parse(TxtID.Text);
                var x = db.TBLCARI.Find(id);
                db.TBLCARI.Remove(x);
                //db.SaveChanges();
                XtraMessageBox.Show("Cari başarılı bir şekilde silindi", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                XtraMessageBox.Show("Lütfen verileri listeledikten sonra bir satıra tıklayıp silmek istediğiniz kaydı seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var x = db.TBLCARI.Find(id);
            x.AD = TxtAd.Text;
            x.SOYAD = TxtSoyad.Text;
            x.IL = LookUpEditil.Text;
            x.ILCE = LookUpEditilce.Text;
            x.TELEFON = TxtTelefon.Text;
            x.ADRES = TxtAdres.Text;
            x.MAIL = TxtMail.Text;
            x.TC = TxtTC.Text;
            x.VERGIDAIRESI = TxtVergiDairesi.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Verileriniz başarılı bir şekilde güncellendi", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnYeniFormdaCariListesi_Click(object sender, EventArgs e)
        {
            FrmCariFormListesi fr = new FrmCariFormListesi();
            fr.Show();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLCARI
                                       select new
                                       {
                                           x.CARIID,
                                           x.AD,
                                           x.SOYAD,
                                           x.IL,
                                           x.ILCE,
                                           x.ADRES,
                                           x.MAIL,
                                           x.TC,
                                           x.TELEFON,
                                           x.VERGIDAIRESI
                                       }).Where(x => x.AD == TxtAd.Text || x.IL == LookUpEditil.Text).ToList();
        }

        private void Btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}