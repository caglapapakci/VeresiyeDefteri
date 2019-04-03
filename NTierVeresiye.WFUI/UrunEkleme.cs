using NTierVeresite.BLL.Repositories;
using NTierVeresiye.BOL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierVeresiye.WFUI
{
    public partial class UrunEkleme : Form
    {
        SqlRepository<Urun> urunRepo = new SqlRepository<Urun>();
        public UrunEkleme()
        {
            InitializeComponent();
        }

        private void UrunEkleme_Load(object sender, EventArgs e)
        {
            cmbUBirim.DataSource = Enum.GetNames(typeof(EBirim));
            
        }
        private void btnUEkle_Click(object sender, EventArgs e)
        {
            int birim = (int)Enum.Parse(typeof(EBirim), cmbUBirim.Text);
            urunRepo.Ekle(new Urun
            {
                 
                Ad = txtUAd.Text,
                Barkod = txtUBarkod.Text,
                Miktar = Convert.ToInt16(nmrUMiktar.Value),
                AlisFiyat = Convert.ToDecimal(txtUAlisFiyat.Text),
                SatisFiyat = Convert.ToDecimal(txtUSatisFiyat.Text),
                AlisTarih = txtUAlisTarih.Text,
                STTarih = txtUSTTarih.Text,
                Birim= (EBirim)birim 
               
            });

            txtUAd.Clear(); txtUBarkod.Clear(); txtUAlisFiyat.Clear(); txtUSatisFiyat.Clear(); txtUAlisTarih.Clear();
            txtUSTTarih.Clear();cmbUBirim.SelectedIndex = -1;nmrUMiktar.Value=0 ;
        }

        private void btnUIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }    

       
    
}
