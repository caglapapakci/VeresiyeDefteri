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
    public partial class MüsterilerSatis : Form
    {
        SqlRepository<Musteri> musteriRepo = new SqlRepository<Musteri>();
            IQueryable<Musteri> musteriler;//arama için eklendi.
        public MüsterilerSatis()
        {
            InitializeComponent();
        }

        private void MüsterilerSatis_Load(object sender, EventArgs e)
        {
                 musteriler = musteriRepo.Listele();//arama için eklendi.
            dataGridView1.DataSource = musteriRepo.Listele().Select(s => new { ID = s.ID,TC=s.TC,Adı= s.Ad, Soyadı=s.Soyad ,Ünvan=s.Unvan,Telefon=s.Telefon,Mail=s.Mail,
              Faks =s.Faks,Açıklama=s.Aciklama,Adres=s.Adres}).ToList();
              dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PesinSatis P1 = new PesinSatis();
            P1.labelId.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int id = Convert.ToInt32(P1.labelId.Text);
            Musteri m = musteriRepo.IDGoreGetir(g => g.ID == id);
            P1.txtPesinSatisAd.Text = m.Ad;
            P1.txtPesinSatisSoyad.Text = m.Soyad;
            P1.txtPesinSatisTC.Text = m.TC;
            P1.maskedtbPesinSatisTelefon.Text = m.Telefon;
            P1.txtPesinSatisMail.Text = m.Mail;
            P1.txtPesinSatisFaks.Text = m.Faks;
            P1.rtbPesinSatisAciklama.Text = m.Aciklama;
            P1.rtbPesinSatisAdres.Text = m.Adres;
            P1.Show();
            P1.txtPesinSatisBakiye.Text ="";
            this.Close();
            

            
        }

        //Aşağıdakiler arama için eklendi.Design kısmındakidaki 3 arama textbox'ı seçilip propertiesten TextChanged özelliği tıklandı.
        private void txtMUnvanAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = musteriler.Where(w => (w.Ad.Contains(txtMAdAra.Text)) && (w.Soyad.Contains(txtMSoyadAra.Text)) && (w.Unvan.Contains(txtMUnvanAra.Text))).Select(s => new {
                ID = s.ID,
                TC = s.TC,
                Adı = s.Ad,
                Soyadı = s.Soyad,
                Ünvan = s.Unvan,
                Telefon = s.Telefon,
                Mail = s.Mail,
                Faks = s.Faks,
                Açıklama = s.Aciklama,
                Adres = s.Adres
            }).ToList();
        }
    }
}
