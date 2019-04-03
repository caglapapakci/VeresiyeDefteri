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
    public partial class TedarikciEkleme : Form
    {
        SqlRepository<Tedarikci> tedarikciRepo = new SqlRepository<Tedarikci>();
        public TedarikciEkleme()
        {
            InitializeComponent();
        }

        private void btnTEkle_Click(object sender, EventArgs e)
        {
            tedarikciRepo.Ekle(new Tedarikci
            {
                Ad = txtTAd.Text,
                Sektor = txtTSektor.Text,
                YetkiliAd = txtTYetkiliAd.Text,
                YetkiliSoyad = txtTYetkiliSoyad.Text,
                VergiNo = txtTVNo.Text,
                VergiDairesi=txtTVDairesi.Text,
                Telefon = mtbTTelefon.Text,
                Faks = txtTFaks.Text,
                Mail = txtTMail.Text,
                Aciklama = rtbTAciklama.Text,
                Adres = rtbTAdres.Text
            });
            txtTAd.Clear(); txtTSektor.Clear(); txtTYetkiliAd.Clear();
            txtTYetkiliSoyad.Clear(); txtTMail.Clear();
            txtTFaks.Clear(); rtbTAdres.Clear(); rtbTAciklama.Clear();
            mtbTTelefon.Clear();txtTVDairesi.Clear();
            txtTVNo.Clear();


        }

        private void btnTIptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
