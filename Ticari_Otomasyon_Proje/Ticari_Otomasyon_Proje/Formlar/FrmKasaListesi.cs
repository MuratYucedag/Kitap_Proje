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
    public partial class FrmKasaListesi : Form
    {
        public FrmKasaListesi()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmKasaListesi_Load(object sender, EventArgs e)
        {
            var kasa_verileri = db.TBLKASA.ToList();
            gridControl1.DataSource = kasa_verileri;
        }
    }
}