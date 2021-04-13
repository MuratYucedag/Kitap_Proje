using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace Ticari_Otomasyon_Proje.Formlar
{
    public partial class FrmQR : Form
    {
        public FrmQR()
        {
            InitializeComponent();
        }

        private void BtnQROlustur_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            pictureEdit1.Image = enc.Encode(textEdit1.Text);
        }

        private void BtnQRCoz_Click(object sender, EventArgs e)
        {
            QRCodeDecoder dc = new QRCodeDecoder();
            textEdit1.Text = dc.Decode(new QRCodeBitmapImage(pictureEdit1.Image as Bitmap));
        }
    }
}