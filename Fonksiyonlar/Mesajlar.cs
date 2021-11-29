using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stokTakip.Fonksiyonlar
{
    class Mesajlar
    {   
        public void YeniKayit(string Mesaj)
        {
            MessageBox.Show(Mesaj, "Yeni Kayıt Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili Kayıt Güncellenecektir\n Güncelleme İşlemini Onaylıyor musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili Olan Kayıt Kalıcı Olarak Silinecektir\n Silme İşlemini Onaylıyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
        }


        public void Guncelle(bool Guncelleme)
        {
            MessageBox.Show("Kayıt Güncellenmiştir", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void Hata(Exception Hata)
        {
            MessageBox.Show(Hata.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
