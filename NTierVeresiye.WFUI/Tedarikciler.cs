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
    public partial class Tedarikciler : Form
    {
        SqlRepository<Tedarikci> tedarikciRepo = new SqlRepository<Tedarikci>();
        IQueryable<Tedarikci> tedarikciler;//arama için eklendi.
        public Tedarikciler()
        {
            InitializeComponent();
        }

        private void Tedarikciler_Load(object sender, EventArgs e)
        {
            tedarikciler= tedarikciRepo.Listele();//arama için eklendi.
            dataGridView1.DataSource = tedarikciRepo.Listele().Select(s => new {
                ID = s.ID,   
                Adı = s.Ad,
                YetkiliAdı = s.YetkiliAd,
                YetkiliSoyadı = s.YetkiliSoyad,
                Sektör = s.Sektor,
                VergiNo=s.VergiNo,
                VergiDairesi=s.VergiDairesi,
                Telefon = s.Telefon,
                Mail = s.Mail,
                Faks = s.Faks,
                Açıklama = s.Aciklama,
                Adres = s.Adres
            }).ToList();
            dataGridView1.Columns[0].Visible = false;
        }


        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            TedarikciGuncelleme F3 = new TedarikciGuncelleme();
            F3.lblId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int id = Convert.ToInt32(F3.lblId.Text);
            Tedarikci t= tedarikciRepo.IDGoreGetir(g=>g.ID==id);
            F3.txtTAd.Text = t.Ad;
            F3.txtTYetkiliAd.Text =t.YetkiliAd;
            F3.txtTYetkiliSoyad.Text =t.YetkiliSoyad ;
            F3.txtTSektor.Text = t.Sektor;
            F3.txtTVNo.Text = t.VergiNo;
            F3.txtTVDairesi.Text = t.VergiDairesi;
            F3.mtbTTelefon.Text = t.Telefon;
            F3.txtTMail.Text = t.Mail;
            F3.txtTFaks.Text = t.Faks;
            F3.rtbTAciklama.Text = t.Aciklama;
            F3.rtbTAdres.Text = t.Adres;
            F3.Show();
            this.Close();


        }

        private void Tedarikciler_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tedarikciler.Where(w => (w.Ad.Contains(txtTAdAra.Text)) && (w.Sektor.Contains(txtTSektorAra.Text)) && (w.YetkiliAd.Contains(txtTYAdAra.Text)) && (w.YetkiliSoyad.Contains(txtTYSoyadAra.Text))).Select(s => new {
                ID = s.ID,        
                Adı = s.Ad,
                Sektör = s.Sektor,
                YetkiliAdı = s.YetkiliAd,
                YetkiliSoyadı= s.YetkiliSoyad,
                VergiNo = s.VergiNo,
                VergiDairesi = s.VergiDairesi,
                Telefon = s.Telefon,
                Mail = s.Mail,
                Faks = s.Faks,
                Açıklama = s.Aciklama,
                Adres = s.Adres
            }).ToList();
        }
    }
}
