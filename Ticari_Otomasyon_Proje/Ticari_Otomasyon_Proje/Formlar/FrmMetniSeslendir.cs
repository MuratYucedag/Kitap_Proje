using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;

namespace Ticari_Otomasyon_Proje.Formlar
{
    public partial class FrmMetniSeslendir : Form
    {
        public FrmMetniSeslendir()
        {
            InitializeComponent();
        }

        private void BtnSeslendir_Click(object sender, EventArgs e)
        {
            SpVoice ses = new SpVoice();
            ses.Speak(textEdit1.Text);
        }
    }
}