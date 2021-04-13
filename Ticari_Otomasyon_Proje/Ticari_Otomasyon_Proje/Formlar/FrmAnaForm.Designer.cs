namespace Ticari_Otomasyon_Proje.Formlar
{
    partial class FrmAnaForm
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
            this.GridUrunStok = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.GridBugunYapilacaklar = new DevExpress.XtraGrid.GridControl();
            this.GridViewBugunYapilacaklar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.GridSon10Satis = new DevExpress.XtraGrid.GridControl();
            this.GridViewSon10Satis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.GridCariFihrist = new DevExpress.XtraGrid.GridControl();
            this.GridViewCariFihrist = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.GridUrunStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBugunYapilacaklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBugunYapilacaklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSon10Satis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSon10Satis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCariFihrist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCariFihrist)).BeginInit();
            this.SuspendLayout();
            // 
            // GridUrunStok
            // 
            this.GridUrunStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridUrunStok.Location = new System.Drawing.Point(2, 20);
            this.GridUrunStok.MainView = this.gridView1;
            this.GridUrunStok.Name = "GridUrunStok";
            this.GridUrunStok.Size = new System.Drawing.Size(314, 158);
            this.GridUrunStok.TabIndex = 0;
            this.GridUrunStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridUrunStok;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.GridUrunStok);
            this.groupControl1.Location = new System.Drawing.Point(1, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(318, 180);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Ürün - Stok Listesi";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.GridSon10Satis);
            this.groupControl2.Location = new System.Drawing.Point(1, 190);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(318, 180);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Son 10 Satış";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.GridBugunYapilacaklar);
            this.groupControl3.Location = new System.Drawing.Point(325, 1);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(318, 180);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Bugün Yapılacaklar";
            // 
            // GridBugunYapilacaklar
            // 
            this.GridBugunYapilacaklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridBugunYapilacaklar.Location = new System.Drawing.Point(2, 20);
            this.GridBugunYapilacaklar.MainView = this.GridViewBugunYapilacaklar;
            this.GridBugunYapilacaklar.Name = "GridBugunYapilacaklar";
            this.GridBugunYapilacaklar.Size = new System.Drawing.Size(314, 158);
            this.GridBugunYapilacaklar.TabIndex = 0;
            this.GridBugunYapilacaklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewBugunYapilacaklar});
            // 
            // GridViewBugunYapilacaklar
            // 
            this.GridViewBugunYapilacaklar.GridControl = this.GridBugunYapilacaklar;
            this.GridViewBugunYapilacaklar.Name = "GridViewBugunYapilacaklar";
            this.GridViewBugunYapilacaklar.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.webBrowser1);
            this.groupControl4.Location = new System.Drawing.Point(649, 1);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(230, 367);
            this.groupControl4.TabIndex = 4;
            this.groupControl4.Text = "Kurlar";
            // 
            // GridSon10Satis
            // 
            this.GridSon10Satis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSon10Satis.Location = new System.Drawing.Point(2, 20);
            this.GridSon10Satis.MainView = this.GridViewSon10Satis;
            this.GridSon10Satis.Name = "GridSon10Satis";
            this.GridSon10Satis.Size = new System.Drawing.Size(314, 158);
            this.GridSon10Satis.TabIndex = 1;
            this.GridSon10Satis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewSon10Satis});
            // 
            // GridViewSon10Satis
            // 
            this.GridViewSon10Satis.GridControl = this.GridSon10Satis;
            this.GridViewSon10Satis.Name = "GridViewSon10Satis";
            this.GridViewSon10Satis.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.GridCariFihrist);
            this.groupControl5.Location = new System.Drawing.Point(325, 190);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(318, 180);
            this.groupControl5.TabIndex = 5;
            this.groupControl5.Text = "Cari Fihrist";
            // 
            // GridCariFihrist
            // 
            this.GridCariFihrist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCariFihrist.Location = new System.Drawing.Point(2, 20);
            this.GridCariFihrist.MainView = this.GridViewCariFihrist;
            this.GridCariFihrist.Name = "GridCariFihrist";
            this.GridCariFihrist.Size = new System.Drawing.Size(314, 158);
            this.GridCariFihrist.TabIndex = 0;
            this.GridCariFihrist.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewCariFihrist});
            // 
            // GridViewCariFihrist
            // 
            this.GridViewCariFihrist.GridControl = this.GridCariFihrist;
            this.GridViewCariFihrist.Name = "GridViewCariFihrist";
            this.GridViewCariFihrist.OptionsView.ShowGroupPanel = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(2, 20);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(226, 345);
            this.webBrowser1.TabIndex = 0;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 373);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmAnaForm";
            this.Text = "Ana Form";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridUrunStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridBugunYapilacaklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBugunYapilacaklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridSon10Satis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSon10Satis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCariFihrist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCariFihrist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridUrunStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl GridSon10Satis;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewSon10Satis;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl GridBugunYapilacaklar;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewBugunYapilacaklar;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraGrid.GridControl GridCariFihrist;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewCariFihrist;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}