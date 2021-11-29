using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace stokTakip.stokModul
{
    public partial class frmStokKarti  : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext DB = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numaralar = new Fonksiyonlar.Numara();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        bool Edit = false;
        int GrupID = -1;
        int StokID = -1;
        public frmStokKarti()
        {
            InitializeComponent();
        }

        private void frmStokKarti_Load(object sender, EventArgs e)
        {
            txtStokKodu.Text = Numaralar.StokKodNumarasi();
        }

        void Temizle()
        {
            txtStokAdi.Text = "";
            txtStokKodu.Text = Numaralar.StokKodNumarasi(); 
            txtSatisFiyat.Text = "0";
            txtSatisKDV.Text = "0";
            txtAlisKDV.Text = "0";
            txtAlisFiyat.Text = "0";
            txtGrupAdi.Text = "";
            txtGrupKodu.Text = "";
            txtBirim.SelectedIndex = 0;
            txtBarkod.Text = "";
            Edit = false;
            GrupID = -1;
            StokID = -1;
            Anasayfa.Aktarma = -1;
        }

        public void Ac(int ID)
        {
            Edit = true;
            StokID = ID;
            Fonksiyonlar.TBL_STOKLAR Stok = DB.TBL_STOKLAR.First(s => s.ID == StokID);
            GrupAc(Stok.STOKGRUPID.Value);
            txtAlisFiyat.Text = Stok.STOKALISFIYAT.ToString();
            txtAlisKDV.Text = Stok.STOKALISKDV.ToString();
            txtBarkod.Text = Stok.STOKBARKOD;
            txtBirim.Text = Stok.STOKBIRIM;
            txtSatisFiyat.Text = Stok.STOKSATISFIYAT.ToString();
            txtSatisKDV.Text = Stok.STOKSATISKDV.ToString();
            txtStokAdi.Text = Stok.STOKADI;
            txtStokKodu.Text = Stok.STOKKODU;
             


        }

        void GrupAc(int ID)
        {
            GrupID = ID;
            txtGrupAdi.Text = DB.TBL_STOKGRUPLARI.First(s => s.ID == GrupID).GRUPADI;
            txtGrupKodu.Text = DB.TBL_STOKGRUPLARI.First(s => s.ID == GrupID).GRUPKODU;

        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_STOKLAR Stok = new Fonksiyonlar.TBL_STOKLAR();
                Stok.STOKADI = txtStokAdi.Text;
                Stok.STOKKODU = txtStokKodu.Text;
                Stok.STOKALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
                Stok.STOKALISKDV = decimal.Parse(txtAlisKDV.Text);
                Stok.STOKBARKOD = txtBarkod.Text;
                Stok.STOKBIRIM = txtBirim.Text;
                Stok.STOKGRUPID = GrupID;
                Stok.STOKSATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
                Stok.STOKSATISKDV = decimal.Parse(txtSatisKDV.Text);
                Stok.STOKSAVEDATE = DateTime.Now;
                Stok.STOKSAVEUSER = Anasayfa.UserID;
                DB.TBL_STOKLAR.InsertOnSubmit(Stok);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Kayıt Oluşturuldu !");
                Temizle();

            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_STOKLAR Stok = DB.TBL_STOKLAR.First(s => s.ID == StokID);
                Stok.STOKADI = txtStokAdi.Text;
                Stok.STOKKODU = txtStokKodu.Text;
                Stok.STOKALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
                Stok.STOKALISKDV = decimal.Parse(txtAlisKDV.Text);
                Stok.STOKBARKOD = txtBarkod.Text;
                Stok.STOKBIRIM = txtBirim.Text;
                Stok.STOKGRUPID = GrupID;
                Stok.STOKSATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
                Stok.STOKSATISKDV = decimal.Parse(txtSatisKDV.Text);
                Stok.STOKEDITDATE= DateTime.Now;
                Stok.STOKEDITUSER = Anasayfa.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();

            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void Sil()
        {
            try
            {
                DB.TBL_STOKLAR.DeleteOnSubmit(DB.TBL_STOKLAR.First(s => s.ID == StokID));
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void txtStokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokListesi(true);
            if (ID > 0)
            {
                Ac(ID);
                Anasayfa.Aktarma = -1;
            }
        }

        private void txtGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokGruplari(true);
            if (ID > 0)
            {
                GrupAc(ID);
            }
            Anasayfa.Aktarma = -1;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else
                YeniKaydet();
        }
    }
}