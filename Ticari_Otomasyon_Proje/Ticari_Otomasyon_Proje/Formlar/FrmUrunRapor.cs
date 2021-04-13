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
    public partial class FrmUrunRapor : Form
    {
        public FrmUrunRapor()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        void urunler()
        {
            gridControl1.DataSource = (from x in db.TBLURUN
                                       select new
                                       {
                                           x.URUNID,
                                           x.URUNAD,
                                           x.STOK,
                                           x.ALISFIYAT,
                                           x.SATISFIYAT,
                                           x.TBLKATEGORI.KATEGORIAD,
                                       }).ToList();
        }
        private void FrmUrunRapor_Load(object sender, EventArgs e)
        {
            urunler();
        }

        private void BtnPdfRaporu_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.Pdf";
            gridControl1.ExportToPdf(path);
        }

        private void BtnExcelRaporu_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.Xls";
            gridControl1.ExportToXls(path);
        }

        private void Btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}