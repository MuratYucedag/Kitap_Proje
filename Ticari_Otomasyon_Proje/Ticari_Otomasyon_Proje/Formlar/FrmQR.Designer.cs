namespace Ticari_Otomasyon_Proje.Formlar
{
    partial class FrmQR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQR));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.BtnQROlustur = new DevExpress.XtraEditors.SimpleButton();
            this.BtnQRCoz = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(12, 47);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(274, 181);
            this.pictureEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Metni Giriniz:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(79, 21);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(207, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // BtnQROlustur
            // 
            this.BtnQROlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnQROlustur.ImageOptions.Image")));
            this.BtnQROlustur.Location = new System.Drawing.Point(12, 232);
            this.BtnQROlustur.Name = "BtnQROlustur";
            this.BtnQROlustur.Size = new System.Drawing.Size(124, 30);
            this.BtnQROlustur.TabIndex = 0;
            this.BtnQROlustur.Text = "QR Oluştur";
            this.BtnQROlustur.Click += new System.EventHandler(this.BtnQROlustur_Click);
            // 
            // BtnQRCoz
            // 
            this.BtnQRCoz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnQRCoz.ImageOptions.Image")));
            this.BtnQRCoz.Location = new System.Drawing.Point(162, 232);
            this.BtnQRCoz.Name = "BtnQRCoz";
            this.BtnQRCoz.Size = new System.Drawing.Size(124, 30);
            this.BtnQRCoz.TabIndex = 4;
            this.BtnQRCoz.Text = "QR Çözümle";
            this.BtnQRCoz.Click += new System.EventHandler(this.BtnQRCoz_Click);
            // 
            // FrmQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 274);
            this.Controls.Add(this.BtnQRCoz);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.BtnQROlustur);
            this.Name = "FrmQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Kod Formu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnQROlustur;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton BtnQRCoz;
    }
}