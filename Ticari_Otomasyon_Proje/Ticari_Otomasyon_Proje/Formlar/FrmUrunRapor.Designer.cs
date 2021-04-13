namespace Ticari_Otomasyon_Proje.Formlar
{
    partial class FrmUrunRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunRapor));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnPdfRaporu = new DevExpress.XtraEditors.SimpleButton();
            this.BtnExcelRaporu = new DevExpress.XtraEditors.SimpleButton();
            this.Btnİptal = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(588, 308);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // BtnPdfRaporu
            // 
            this.BtnPdfRaporu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPdfRaporu.ImageOptions.Image")));
            this.BtnPdfRaporu.Location = new System.Drawing.Point(1, 12);
            this.BtnPdfRaporu.Name = "BtnPdfRaporu";
            this.BtnPdfRaporu.Size = new System.Drawing.Size(192, 35);
            this.BtnPdfRaporu.TabIndex = 1;
            this.BtnPdfRaporu.Text = "Pdf Raporu";
            this.BtnPdfRaporu.Click += new System.EventHandler(this.BtnPdfRaporu_Click);
            // 
            // BtnExcelRaporu
            // 
            this.BtnExcelRaporu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcelRaporu.ImageOptions.Image")));
            this.BtnExcelRaporu.Location = new System.Drawing.Point(199, 12);
            this.BtnExcelRaporu.Name = "BtnExcelRaporu";
            this.BtnExcelRaporu.Size = new System.Drawing.Size(192, 35);
            this.BtnExcelRaporu.TabIndex = 2;
            this.BtnExcelRaporu.Text = "Excel Raporu";
            this.BtnExcelRaporu.Click += new System.EventHandler(this.BtnExcelRaporu_Click);
            // 
            // Btnİptal
            // 
            this.Btnİptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnİptal.ImageOptions.Image")));
            this.Btnİptal.Location = new System.Drawing.Point(397, 12);
            this.Btnİptal.Name = "Btnİptal";
            this.Btnİptal.Size = new System.Drawing.Size(192, 35);
            this.Btnİptal.TabIndex = 3;
            this.Btnİptal.Text = "İptal";
            this.Btnİptal.Click += new System.EventHandler(this.Btnİptal_Click);
            // 
            // FrmUrunRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 373);
            this.Controls.Add(this.Btnİptal);
            this.Controls.Add(this.BtnExcelRaporu);
            this.Controls.Add(this.BtnPdfRaporu);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmUrunRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Raporları";
            this.Load += new System.EventHandler(this.FrmUrunRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnPdfRaporu;
        private DevExpress.XtraEditors.SimpleButton BtnExcelRaporu;
        private DevExpress.XtraEditors.SimpleButton Btnİptal;
    }
}