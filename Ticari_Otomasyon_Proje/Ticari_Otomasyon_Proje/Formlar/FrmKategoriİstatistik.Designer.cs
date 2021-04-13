namespace Ticari_Otomasyon_Proje.Formlar
{
    partial class FrmKategoriİstatistik
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.LblKategoriSayisi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl9 = new DevExpress.XtraEditors.PanelControl();
            this.LblEnFazlaUrunluKategori = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.LBlSonEklenenKategori = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).BeginInit();
            this.panelControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(308, 369);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.Controls.Add(this.LblKategoriSayisi);
            this.panelControl4.Controls.Add(this.labelControl8);
            this.panelControl4.Location = new System.Drawing.Point(316, 1);
            this.panelControl4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(184, 110);
            this.panelControl4.TabIndex = 4;
            // 
            // LblKategoriSayisi
            // 
            this.LblKategoriSayisi.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKategoriSayisi.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblKategoriSayisi.Appearance.Options.UseFont = true;
            this.LblKategoriSayisi.Appearance.Options.UseForeColor = true;
            this.LblKategoriSayisi.Location = new System.Drawing.Point(92, 53);
            this.LblKategoriSayisi.Name = "LblKategoriSayisi";
            this.LblKategoriSayisi.Size = new System.Drawing.Size(13, 29);
            this.LblKategoriSayisi.TabIndex = 2;
            this.LblKategoriSayisi.Text = "0";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(50, 16);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(84, 16);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Kategori Sayısı";
            // 
            // panelControl9
            // 
            this.panelControl9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.panelControl9.Appearance.Options.UseBackColor = true;
            this.panelControl9.Controls.Add(this.LblEnFazlaUrunluKategori);
            this.panelControl9.Controls.Add(this.labelControl18);
            this.panelControl9.Location = new System.Drawing.Point(696, 1);
            this.panelControl9.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl9.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl9.Name = "panelControl9";
            this.panelControl9.Size = new System.Drawing.Size(184, 110);
            this.panelControl9.TabIndex = 13;
            // 
            // LblEnFazlaUrunluKategori
            // 
            this.LblEnFazlaUrunluKategori.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEnFazlaUrunluKategori.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblEnFazlaUrunluKategori.Appearance.Options.UseFont = true;
            this.LblEnFazlaUrunluKategori.Appearance.Options.UseForeColor = true;
            this.LblEnFazlaUrunluKategori.Location = new System.Drawing.Point(16, 53);
            this.LblEnFazlaUrunluKategori.Name = "LblEnFazlaUrunluKategori";
            this.LblEnFazlaUrunluKategori.Size = new System.Drawing.Size(11, 25);
            this.LblEnFazlaUrunluKategori.TabIndex = 2;
            this.LblEnFazlaUrunluKategori.Text = "0";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl18.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Appearance.Options.UseForeColor = true;
            this.labelControl18.Location = new System.Drawing.Point(27, 16);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(140, 16);
            this.labelControl18.TabIndex = 1;
            this.labelControl18.Text = "En Fazla Ürünlü Kategori";
            // 
            // panelControl5
            // 
            this.panelControl5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(52)))), ((int)(((byte)(113)))));
            this.panelControl5.Appearance.Options.UseBackColor = true;
            this.panelControl5.Controls.Add(this.LBlSonEklenenKategori);
            this.panelControl5.Controls.Add(this.labelControl10);
            this.panelControl5.Location = new System.Drawing.Point(506, 1);
            this.panelControl5.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl5.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(184, 110);
            this.panelControl5.TabIndex = 12;
            // 
            // LBlSonEklenenKategori
            // 
            this.LBlSonEklenenKategori.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBlSonEklenenKategori.Appearance.ForeColor = System.Drawing.Color.White;
            this.LBlSonEklenenKategori.Appearance.Options.UseFont = true;
            this.LBlSonEklenenKategori.Appearance.Options.UseForeColor = true;
            this.LBlSonEklenenKategori.Location = new System.Drawing.Point(30, 53);
            this.LBlSonEklenenKategori.Name = "LBlSonEklenenKategori";
            this.LBlSonEklenenKategori.Size = new System.Drawing.Size(13, 29);
            this.LBlSonEklenenKategori.TabIndex = 2;
            this.LBlSonEklenenKategori.Text = "0";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(30, 16);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(121, 16);
            this.labelControl10.TabIndex = 1;
            this.labelControl10.Text = "Son Eklenen Kategori";
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(316, 117);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "ürün-stok";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(564, 253);
            this.chartControl1.TabIndex = 14;
            // 
            // FrmKategoriİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 373);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panelControl9);
            this.Controls.Add(this.panelControl5);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmKategoriİstatistik";
            this.Text = "Kategori İstatistikleri";
            this.Load += new System.EventHandler(this.FrmKategoriİstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).EndInit();
            this.panelControl9.ResumeLayout(false);
            this.panelControl9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl LblKategoriSayisi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.PanelControl panelControl9;
        private DevExpress.XtraEditors.LabelControl LblEnFazlaUrunluKategori;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.LabelControl LBlSonEklenenKategori;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}