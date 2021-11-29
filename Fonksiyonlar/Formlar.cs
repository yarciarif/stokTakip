using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stokTakip.Fonksiyonlar
{
    class Formlar
    {
    public int StokListesi(bool Secim=false)
        {
            stokModul.frmStokListesi frm = new stokModul.frmStokListesi();
            if (Secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Anasayfa.ActiveForm;
                frm.Show();            
            }
            return Anasayfa.Aktarma;
        }
   
    public int StokGruplari(bool Secim = false)
    {
        stokModul.frmStokGruplari frm = new stokModul.frmStokGruplari();
        if (Secim)
        {
            frm.Secim = Secim;
            frm.ShowDialog();
           
        }
            return Anasayfa.Aktarma;
    }

    public void StokHareketleri(bool Ac = false)
        {

        }

    public void StokKarti(bool Ac = false)
        {
            stokModul.frmStokKarti frm = new stokModul.frmStokKarti();
            frm.ShowDialog();
        }

    }
 }
