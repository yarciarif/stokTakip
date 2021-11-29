namespace stokTakip
{
    partial class Anasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnStokKarti = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokListesi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokGruplari = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.Stok = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnStokKarti,
            this.barBtnStokListesi,
            this.barBtnStokGruplari,
            this.barBtnStokHareketleri});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Stok});
            this.ribbon.Size = new System.Drawing.Size(442, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnStokKarti
            // 
            this.barBtnStokKarti.Caption = "Stok Kartı";
            this.barBtnStokKarti.Id = 1;
            this.barBtnStokKarti.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnStokKarti.ImageOptions.Image")));
            this.barBtnStokKarti.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnStokKarti.ImageOptions.LargeImage")));
            this.barBtnStokKarti.Name = "barBtnStokKarti";
            this.barBtnStokKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokKarti_ItemClick);
            // 
            // barBtnStokListesi
            // 
            this.barBtnStokListesi.Caption = "Stok Listesi";
            this.barBtnStokListesi.Id = 2;
            this.barBtnStokListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnStokListesi.ImageOptions.Image")));
            this.barBtnStokListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnStokListesi.ImageOptions.LargeImage")));
            this.barBtnStokListesi.Name = "barBtnStokListesi";
            this.barBtnStokListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokListesi_ItemClick);
            // 
            // barBtnStokGruplari
            // 
            this.barBtnStokGruplari.Caption = "Stok Grupları";
            this.barBtnStokGruplari.Id = 3;
            this.barBtnStokGruplari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnStokGruplari.ImageOptions.Image")));
            this.barBtnStokGruplari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnStokGruplari.ImageOptions.LargeImage")));
            this.barBtnStokGruplari.Name = "barBtnStokGruplari";
            this.barBtnStokGruplari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokGruplari_ItemClick);
            // 
            // barBtnStokHareketleri
            // 
            this.barBtnStokHareketleri.Caption = "Stok Hareketleri";
            this.barBtnStokHareketleri.Id = 4;
            this.barBtnStokHareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnStokHareketleri.ImageOptions.Image")));
            this.barBtnStokHareketleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnStokHareketleri.ImageOptions.LargeImage")));
            this.barBtnStokHareketleri.Name = "barBtnStokHareketleri";
            this.barBtnStokHareketleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokHareketleri_ItemClick);
            // 
            // Stok
            // 
            this.Stok.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.Stok.Name = "Stok";
            this.Stok.Text = "Stok";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokKarti);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokListesi);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokGruplari);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokHareketleri);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Stok İşlemleri";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(442, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "Anasayfa";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage Stok;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnStokKarti;
        private DevExpress.XtraBars.BarButtonItem barBtnStokListesi;
        private DevExpress.XtraBars.BarButtonItem barBtnStokGruplari;
        private DevExpress.XtraBars.BarButtonItem barBtnStokHareketleri;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}