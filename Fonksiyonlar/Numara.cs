using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stokTakip.Fonksiyonlar
{
    class Numara
    {
        DataBaseDataContext DB = new DataBaseDataContext();
        Mesajlar Mesajlar = new Mesajlar();

        public string StokKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from s in DB.TBL_STOKLAR
                                        orderby s.ID descending
                                        select s).First().STOKKODU);
                Numara++;

                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception)
            {
                return "000001";
            }
        }
    }
}
