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
    public partial class TedarikciGuncelleme : Form
    {
        SqlRepository<Tedarikci> tedarikciRepo = new SqlRepository<Tedarikci>();
        public TedarikciGuncelleme()
        {
            InitializeComponent();
        }

        private void btnTSec_Click(object sender, EventArgs e)
        {

            Tedarikciler tedarikci = new Tedarikciler();
            tedarikci.Show();
            this.Close();
        }

        private void btnTGuncelle_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(lblId.Text);
            Tedarikci t = tedarikciRepo.IDGoreGetir(g => g.ID== id);
            t.Ad = txtTAd.Text;
            t.Sektor = txtTSektor.Text;
            t.YetkiliAd = txtTYetkiliAd.Text;
            t.YetkiliSoyad = txtTYetkiliSoyad.Text;
            t.VergiDairesi = txtTVDairesi.Text;
            t.VergiNo= txtTVNo.Text;
            t.Telefon = mtbTTelefon.Text;
            t.Mail = txtTMail.Text;
            t.Faks = txtTFaks.Text;
            t.Aciklama = rtbTAciklama.Text;
            t.Adres = rtbTAdres.Text;
            tedarikciRepo.Guncelle(t);
            txtTAd.Clear(); txtTSektor.Clear(); txtTYetkiliAd.Clear(); txtTYetkiliSoyad.Clear(); txtTMail.Clear();
            txtTFaks.Clear(); rtbTAdres.Clear(); rtbTAciklama.Clear(); mtbTTelefon.Clear();
            txtTVDairesi.Clear();txtTVNo.Clear();

        }

        private void btnTIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
