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

namespace Ticari_Otomasyon_Proje
{
    public partial class FrmKategoriler : Form
    {
        public FrmKategoriler()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = from x in db.TBLKATEGORI
                              select new
                              {
                                  x.ID,
                                  x.KATEGORIAD
                              };
            gridControl1.DataSource = kategoriler.ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLKATEGORI t = new TBLKATEGORI();
            t.KATEGORIAD = TxtAd.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Kategori ekleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtID.Text != "")
            {
                int id = int.Parse(TxtID.Text);
                var x = db.TBLKATEGORI.Find(id);
                db.TBLKATEGORI.Remove(x);
                db.SaveChanges();
                XtraMessageBox.Show("Kategori başarılı bir şekilde silindi", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                XtraMessageBox.Show("Lütfen verileri listeledikten sonra bir satıra tıklayıp silmek istediğiniz kaydı seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var x = db.TBLKATEGORI.Find(id);
            x.KATEGORIAD = TxtAd.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Verileriniz başarılı bir şekilde güncellendi", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}