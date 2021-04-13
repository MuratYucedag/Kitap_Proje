namespace Ticari_Otomasyon_Proje.Formlar
{
    partial class FrmMetniSeslendir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMetniSeslendir));
            this.BtnSeslendir = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSeslendir
            // 
            this.BtnSeslendir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnSeslendir.Location = new System.Drawing.Point(117, 202);
            this.BtnSeslendir.Name = "BtnSeslendir";
            this.BtnSeslendir.Size = new System.Drawing.Size(153, 33);
            this.BtnSeslendir.TabIndex = 1;
            this.BtnSeslendir.Text = "Seslendir";
            this.BtnSeslendir.Click += new System.EventHandler(this.BtnSeslendir_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(0, 2);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(403, 194);
            this.textEdit1.TabIndex = 0;
            // 
            // FrmMetniSeslendir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 244);
            this.Controls.Add(this.BtnSeslendir);
            this.Controls.Add(this.textEdit1);
            this.Name = "FrmMetniSeslendir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metni Seslendir";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnSeslendir;
        private DevExpress.XtraEditors.MemoEdit textEdit1;
    }
}