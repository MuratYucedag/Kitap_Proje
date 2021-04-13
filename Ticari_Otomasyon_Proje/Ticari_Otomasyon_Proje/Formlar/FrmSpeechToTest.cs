using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
namespace Ticari_Otomasyon_Proje.Formlar
{
    public partial class FrmSpeechToTest : Form
    {
        public FrmSpeechToTest()
        {
            InitializeComponent();
        }

        private void BtnKonus_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine sp = new SpeechRecognitionEngine();
            Grammar g = new DictationGrammar();
            sp.LoadGrammar(g);
            try
            {
                BtnKonus.Text = "Konuşun...";
                sp.SetInputToDefaultAudioDevice();
                RecognitionResult res = sp.Recognize();
                BtnKonus.Text = res.Text;
            }
            catch (Exception)
            {
                BtnKonus.Text = "Hata";
            }
        }
    }
}