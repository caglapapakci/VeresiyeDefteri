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
    public partial class Müsteriler : Form
    {
        SqlRepository<Musteri> musteriRepo = new SqlRepository<Musteri>();
            IQueryable<Musteri> musteriler;//arama için eklendi.
        public Müsteriler()
        {
            InitializeComponent();
        }

        private void Müsteriler_Load(object sender, EventArgs e)
        {
                 musteriler = musteriRepo.Listele();//arama için eklendi.
            dataGridView1.DataSource = musteriRepo.Listele().Select(s => new { ID = s.ID,TC=s.TC,Adı= s.Ad, Soyadı=s.Soyad ,Ünvan=s.Unvan,Telefon=s.Telefon,Mail=s.Mail,
              Faks =s.Faks,Açıklama=s.Aciklama,Adres=s.Adres}).ToList();
              dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MüsteriGüncelleSil F1 = new MüsteriGüncelleSil();
            F1.lblID.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int id = Convert.ToInt32(F1.lblID.Text);
            Musteri m = musteriRepo.IDGoreGetir(g => g.ID == id);
            F1.txtMAd.Text = m.Ad;
            F1.txtMSoyad.Text = m.Soyad;
            F1.txtMUnvan.Text = m.Unvan;
            F1.txtMTC.Text = m.TC;
            F1.maskedtbMTelefon.Text = m.Telefon;
            F1.txtMMail.Text = m.Mail;
            F1.txtMFaks.Text = m.Faks;
            F1.rtbMAciklama.Text = m.Aciklama;
            F1.rtbMAdres.Text = m.Adres;
            F1.Show();
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
