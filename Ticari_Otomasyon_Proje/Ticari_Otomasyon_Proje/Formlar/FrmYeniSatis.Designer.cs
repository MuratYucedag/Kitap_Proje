namespace Ticari_Otomasyon_Proje.Formlar
{
    partial class FrmYeniSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniSatis));
            this.LookUpEditPersonel = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtToplam = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBirimFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAdet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnSatisYap = new DevExpress.XtraEditors.SimpleButton();
            this.Btnİptal = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit8 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lookUpEditUrun = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditCari = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtTarih = new DevExpress.XtraEditors.DateEdit();
            this.TxtAciklama = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBirimFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LookUpEditPersonel
            // 
            this.LookUpEditPersonel.Location = new System.Drawing.Point(120, 69);
            this.LookUpEditPersonel.Name = "LookUpEditPersonel";
            this.LookUpEditPersonel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.LookUpEditPersonel.Properties.Appearance.Options.UseFont = true;
            this.LookUpEditPersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditPersonel.Properties.DisplayMember = "PERSONEL";
            this.LookUpEditPersonel.Properties.NullText = "Personel Seçiniz";
            this.LookUpEditPersonel.Properties.ValueMember = "PERSONELID";
            this.LookUpEditPersonel.Size = new System.Drawing.Size(153, 22);
            this.LookUpEditPersonel.TabIndex = 58;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(46, 203);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(46, 14);
            this.labelControl8.TabIndex = 52;
            this.labelControl8.Text = "Açıklama";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(46, 177);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(69, 14);
            this.labelControl7.TabIndex = 49;
            this.labelControl7.Text = "Toplam Fiyat";
            // 
            // TxtToplam
            // 
            this.TxtToplam.Location = new System.Drawing.Point(120, 174);
            this.TxtToplam.Name = "TxtToplam";
            this.TxtToplam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtToplam.Properties.Appearance.Options.UseFont = true;
            this.TxtToplam.Size = new System.Drawing.Size(153, 20);
            this.TxtToplam.TabIndex = 48;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(46, 151);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 14);
            this.labelControl6.TabIndex = 46;
            this.labelControl6.Text = "Birim Fiyat";
            // 
            // TxtBirimFiyat
            // 
            this.TxtBirimFiyat.Location = new System.Drawing.Point(120, 148);
            this.TxtBirimFiyat.Name = "TxtBirimFiyat";
            this.TxtBirimFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBirimFiyat.Properties.Appearance.Options.UseFont = true;
            this.TxtBirimFiyat.Size = new System.Drawing.Size(153, 20);
            this.TxtBirimFiyat.TabIndex = 45;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(46, 125);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 14);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "Adet";
            // 
            // TxtAdet
            // 
            this.TxtAdet.Location = new System.Drawing.Point(120, 122);
            this.TxtAdet.Name = "TxtAdet";
            this.TxtAdet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdet.Properties.Appearance.Options.UseFont = true;
            this.TxtAdet.Size = new System.Drawing.Size(153, 20);
            this.TxtAdet.TabIndex = 42;
            this.TxtAdet.EditValueChanged += new System.EventHandler(this.TxtAdet_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(46, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 14);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "Tarih";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(46, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 14);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "Personel";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(46, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 14);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Cari";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(46, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 14);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Ürün";
            // 
            // BtnSatisYap
            // 
            this.BtnSatisYap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSatisYap.Appearance.Options.UseFont = true;
            this.BtnSatisYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnSatisYap.Location = new System.Drawing.Point(120, 300);
            this.BtnSatisYap.Name = "BtnSatisYap";
            this.BtnSatisYap.Size = new System.Drawing.Size(153, 33);
            this.BtnSatisYap.TabIndex = 57;
            this.BtnSatisYap.Text = "Satış Yap";
            this.BtnSatisYap.Click += new System.EventHandler(this.BtnSatisYap_Click);
            // 
            // Btnİptal
            // 
            this.Btnİptal.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnİptal.Appearance.Options.UseFont = true;
            this.Btnİptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnİptal.ImageOptions.Image")));
            this.Btnİptal.Location = new System.Drawing.Point(120, 339);
            this.Btnİptal.Name = "Btnİptal";
            this.Btnİptal.Size = new System.Drawing.Size(153, 33);
            this.Btnİptal.TabIndex = 56;
            this.Btnİptal.Text = "İptal";
            // 
            // pictureEdit8
            // 
            this.pictureEdit8.EditValue = global::Ticari_Otomasyon_Proje.Properties.Resources.pielabelstooltips_32x32;
            this.pictureEdit8.Location = new System.Drawing.Point(11, 196);
            this.pictureEdit8.Name = "pictureEdit8";
            this.pictureEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit8.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit8.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit8.Size = new System.Drawing.Size(24, 24);
            this.pictureEdit8.TabIndex = 50;
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.EditValue = global::Ticari_Otomasyon_Proje.Properties.Resources.accounting_32x321;
            this.pictureEdit7.Location = new System.Drawing.Point(11, 170);
            this.pictureEdit7.Name = "pictureEdit7";
            this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit7.Properties.ErrorImageOptions.Image = global::Ticari_Otomasyon_Proje.Properties.Resources.accounting_32x32;
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit7.Size = new System.Drawing.Size(24, 24);
            this.pictureEdit7.TabIndex = 47;
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = global::Ticari_Otomasyon_Proje.Properties.Resources.scientific_32x32;
            this.pictureEdit6.Location = new System.Drawing.Point(11, 144);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit6.Size = new System.Drawing.Size(24, 24);
            this.pictureEdit6.TabIndex = 44;
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = global::Ticari_Otomasyon_Proje.Properties.Resources.fraction_32x32;
            this.pictureEdit5.Location = new System.Drawing.Point(11, 118);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit5.Size = new System.Drawing.Size(24, 24);
            this.pictureEdit5.TabIndex = 41;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = global::Ticari_Otomasyon_Proje.Properties.Resources.today_32x32;
            this.pictureEdit4.Location = new System.Drawing.Point(11, 92);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(24, 24);
            this.pictureEdit4.TabIndex = 39;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = global::Ticari_Otomasyon_Proje.Properties.Resources.boemployee_32x32;
            this.pictureEdit3.Location = new System.Drawing.Point(11, 66);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(24, 24);
            this.pictureEdit3.TabIndex = 37;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::Ticari_Otomasyon_Proje.Properties.Resources.user_32x32;
            this.pictureEdit2.Location = new System.Drawing.Point(11, 40);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(24, 24);
            this.pictureEdit2.TabIndex = 34;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::Ticari_Otomasyon_Proje.Properties.Resources.boproduct_32x32;
            this.pictureEdit1.Location = new System.Drawing.Point(12, 11);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(24, 24);
            this.pictureEdit1.TabIndex = 31;
            // 
            // lookUpEditUrun
            // 
            this.lookUpEditUrun.Location = new System.Drawing.Point(120, 14);
            this.lookUpEditUrun.Name = "lookUpEditUrun";
            this.lookUpEditUrun.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lookUpEditUrun.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditUrun.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditUrun.Properties.DisplayMember = "URUNAD";
            this.lookUpEditUrun.Properties.NullText = "Ürün Seçiniz";
            this.lookUpEditUrun.Properties.ValueMember = "URUNID";
            this.lookUpEditUrun.Size = new System.Drawing.Size(153, 22);
            this.lookUpEditUrun.TabIndex = 60;
            this.lookUpEditUrun.EditValueChanged += new System.EventHandler(this.lookUpEditUrun_EditValueChanged);
            // 
            // lookUpEditCari
            // 
            this.lookUpEditCari.Location = new System.Drawing.Point(120, 42);
            this.lookUpEditCari.Name = "lookUpEditCari";
            this.lookUpEditCari.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lookUpEditCari.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCari.Properties.DisplayMember = "CARI";
            this.lookUpEditCari.Properties.NullText = "Cari Seçiniz";
            this.lookUpEditCari.Properties.ValueMember = "CARIID";
            this.lookUpEditCari.Size = new System.Drawing.Size(153, 22);
            this.lookUpEditCari.TabIndex = 61;
            // 
            // TxtTarih
            // 
            this.TxtTarih.EditValue = null;
            this.TxtTarih.Location = new System.Drawing.Point(120, 96);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTarih.Properties.Appearance.Options.UseFont = true;
            this.TxtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtTarih.Properties.DisplayFormat.FormatString = "";
            this.TxtTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtTarih.Properties.EditFormat.FormatString = "";
            this.TxtTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.TxtTarih.Properties.Mask.EditMask = "";
            this.TxtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.TxtTarih.Size = new System.Drawing.Size(153, 20);
            this.TxtTarih.TabIndex = 59;
            // 
            // TxtAciklama
            // 
            this.TxtAciklama.Location = new System.Drawing.Point(120, 200);
            this.TxtAciklama.Name = "TxtAciklama";
            this.TxtAciklama.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAciklama.Properties.Appearance.Options.UseFont = true;
            this.TxtAciklama.Size = new System.Drawing.Size(153, 94);
            this.TxtAciklama.TabIndex = 51;
            // 
            // FrmYeniSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 377);
            this.Controls.Add(this.lookUpEditCari);
            this.Controls.Add(this.lookUpEditUrun);
            this.Controls.Add(this.LookUpEditPersonel);
            this.Controls.Add(this.BtnSatisYap);
            this.Controls.Add(this.Btnİptal);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.pictureEdit8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.TxtToplam);
            this.Controls.Add(this.pictureEdit7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.TxtBirimFiyat);
            this.Controls.Add(this.pictureEdit6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.TxtAdet);
            this.Controls.Add(this.pictureEdit5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.TxtTarih);
            this.Controls.Add(this.TxtAciklama);
            this.Name = "FrmYeniSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Satış Formu";
            this.Load += new System.EventHandler(this.FrmYeniSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBirimFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAciklama.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LookUpEdit LookUpEditPersonel;
        private DevExpress.XtraEditors.SimpleButton BtnSatisYap;
        private DevExpress.XtraEditors.SimpleButton Btnİptal;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.PictureEdit pictureEdit8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TxtToplam;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtBirimFiyat;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtAdet;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditUrun;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCari;
        private DevExpress.XtraEditors.DateEdit TxtTarih;
        private DevExpress.XtraEditors.MemoEdit TxtAciklama;
    }
}