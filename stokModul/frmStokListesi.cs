using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Data.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace stokTakip.stokModul
{
    public partial class frmStokListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext DB = new Fonksiyonlar.DataBaseDataContext();
        public bool Secim = false;
        int SecimID = -1;


        public frmStokListesi()
        {
            InitializeComponent();
        }

        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            listele();
        }

        void listele()
        {
            var lst = from s in DB.TBL_STOKLAR
                      where s.STOKADI.Contains(txtStokAdi.Text) && s.STOKBARKOD.Contains(txtBarkod.Text) && s.STOKKODU.Contains(txtStokKodu.Text)
                      select s;
            Liste.DataSource = lst;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listele(); 
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBarkod.Text = "";
            txtStokAdi.Text = "";
            txtStokKodu.Text = "";
        }
        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {
                SecimID = -1;   
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecimID > 0)
            {
                Anasayfa.Aktarma = SecimID;
                this.Close();
            }
        }

        
    }
}