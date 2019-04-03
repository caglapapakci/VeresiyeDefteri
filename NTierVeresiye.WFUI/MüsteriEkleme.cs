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
    public partial class MüsteriEkleme : Form
    {
        SqlRepository<Musteri> musteriRepo = new SqlRepository<Musteri>();
        
        public MüsteriEkleme()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteriRepo.Ekle(new Musteri
            {
                Ad = txtMAd.Text,
                Soyad = txtMSoyad.Text,
                Unvan = txtMUnvan.Text,
                TC = txtMTC.Text,
                Telefon = maskedtbMTelefon.Text,
                Faks = txtMFaks.Text,
                Mail = txtMMail.Text,
                Aciklama = rtbMAciklama.Text,
                Adres = rtbMAdres.Text
            });
            txtMAd.Clear();txtMSoyad.Clear();txtMUnvan.Clear();txtMTC.Clear();txtMMail.Clear();
            txtMFaks.Clear();rtbMAdres.Clear();rtbMAciklama.Clear();maskedtbMTelefon.Clear();

        }

        private void btnMIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
