namespace Ticari_Otomasyon_Proje.Formlar
{
    partial class FrmSpeechToTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpeechToTest));
            this.BtnKonus = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKonus
            // 
            this.BtnKonus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSeslendir.ImageOptions.Image")));
            this.BtnKonus.Location = new System.Drawing.Point(117, 200);
            this.BtnKonus.Name = "BtnKonus";
            this.BtnKonus.Size = new System.Drawing.Size(153, 33);
            this.BtnKonus.TabIndex = 3;
            this.BtnKonus.Text = "Konuş";
            this.BtnKonus.Click += new System.EventHandler(this.BtnKonus_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(0, 0);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(403, 194);
            this.textEdit1.TabIndex = 2;
            // 
            // FrmSpeechToTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 237);
            this.Controls.Add(this.BtnKonus);
            this.Controls.Add(this.textEdit1);
            this.Name = "FrmSpeechToTest";
            this.Text = "Sesi Metne Dönüştür";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnKonus;
        private DevExpress.XtraEditors.MemoEdit textEdit1;
    }
}