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
    public partial class UrunGuncelleSil : Form
    {
        SqlRepository<Urun> urunRepo = new SqlRepository<Urun>();
        public UrunGuncelleSil()
        {
            InitializeComponent();
        }

        private void btnUSec_Click(object sender, EventArgs e)
        {

            Urunler urun = new Urunler();
            urun.Show();
            this.Close();
        }

        private void btnUGuncelle_Click(object sender, EventArgs e)
        {
            int birim = (int)Enum.Parse(typeof(EBirim), cmbUBirim.Text);
            int id = Convert.ToInt32(lblid.Text);
            Urun u = urunRepo.IDGoreGetir(g => g.ID == id);
            u.Ad = txtUAd.Text;
            u.Barkod = txtUBarkod.Text;
            u.AlisFiyat =Convert.ToDecimal( txtUAlisFiyat.Text);
            u.SatisFiyat = Convert.ToDecimal(txtUSatisFiyat.Text);
            u.AlisTarih = txtUAlisTarih.Text;
            u.STTarih = txtUSTTarih.Text;
            u.Miktar =Convert.ToInt16( nmrUMiktar.Value);
            u.Birim = (EBirim)birim;
            
            urunRepo.Guncelle(u);
            txtUAd.Clear(); txtUBarkod.Clear(); txtUAlisFiyat.Clear(); txtUSatisFiyat.Clear();
            txtUAlisTarih.Clear();txtUSTTarih.Clear(); nmrUMiktar.Value=0;
            cmbUBirim.SelectedIndex=-1; 

           
        }

        private void BtnUIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUSil_Click(object sender, EventArgs e)
        {
            DialogResult r= MessageBox.Show("Silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                int id = Convert.ToInt32(lblid.Text);
                Urun u = urunRepo.IDGoreGetir(g => g.ID == id);
                urunRepo.Sil(u);
                txtUAd.Clear(); txtUBarkod.Clear(); txtUAlisFiyat.Clear(); txtUSatisFiyat.Clear();
                txtUAlisTarih.Clear(); txtUSTTarih.Clear(); nmrUMiktar.Value = 0;
                cmbUBirim.SelectedIndex = -1;
            }
            else
                this.Close();
               

            
        }

       
    }
}
