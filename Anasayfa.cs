using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace stokTakip
{
    public partial class Anasayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        public static int UserID = -1;
        public static int Aktarma = -1;

        public Anasayfa()
        {
            InitializeComponent();
        }

       
        private void barBtnStokKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokKarti();
        }

        private void barBtnStokListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokListesi();
        }

        private void barBtnStokGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokGruplari(true);
        }

        private void barBtnStokHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokHareketleri();
        }
    }
}