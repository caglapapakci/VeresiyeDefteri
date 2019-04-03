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
    public partial class MüsteriGüncelleSil : Form
    {
        SqlRepository<Musteri> musteriRepo = new SqlRepository<Musteri>();
        
        public MüsteriGüncelleSil()
        {
            InitializeComponent();
        }
        private void btnMSec_Click(object sender, EventArgs e)
        {
            Müsteriler müsteri = new Müsteriler();
            müsteri.Show();
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblID.Text);
            Musteri m = musteriRepo.IDGoreGetir(g => g.ID ==id);
            m.Ad = txtMAd.Text;
            m.Soyad = txtMSoyad.Text;
            m.Unvan = txtMUnvan.Text;
            m.TC = txtMTC.Text;
            m.Telefon =maskedtbMTelefon.Text;
            m.Mail = txtMMail.Text;
            m.Faks = txtMFaks.Text;
            m.Aciklama = rtbMAciklama.Text;
            m.Adres = rtbMAdres.Text;
            musteriRepo.Guncelle(m);
            txtMAd.Clear();txtMSoyad.Clear();txtMUnvan.Clear();txtMTC.Clear();txtMMail.Clear();
            txtMFaks.Clear();rtbMAdres.Clear();rtbMAciklama.Clear();maskedtbMTelefon.Clear();

        }

        private void btnMIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMSil_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show( "Silmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                int id = Convert.ToInt32(lblID.Text);
                Musteri m = musteriRepo.IDGoreGetir(g => g.ID == id);
                musteriRepo.Sil(m);
                txtMAd.Clear(); txtMSoyad.Clear(); txtMUnvan.Clear(); txtMTC.Clear();
                txtMMail.Clear(); txtMFaks.Clear(); rtbMAdres.Clear(); rtbMAciklama.Clear();
                maskedtbMTelefon.Clear();
            }
            else
                this.Close();
            
        }
    }
}
