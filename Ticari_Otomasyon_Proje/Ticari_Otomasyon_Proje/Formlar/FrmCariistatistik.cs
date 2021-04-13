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
    public partial class FrmCariistatistik : Form
    {
        public FrmCariistatistik()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private void FrmCariistatistik_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLCARI.OrderBy(x => x.IL).
                GroupBy(y => y.IL).
                Select(z => new { İL = z.Key, TOPLAM = z.Count() }).ToList();

            var degerler = db.TBLCARI.OrderBy(x => x.IL).
                GroupBy(y => y.IL).
                Select(z => new { İL = z.Key, TOPLAM = z.Count() }).ToList();
            foreach (var x in degerler)
            {
                chartControl1.Series["iller"].Points.AddPoint(x.İL, short.Parse(x.TOPLAM.ToString()));
            }
        }
    }
}