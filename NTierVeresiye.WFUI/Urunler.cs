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
    public partial class Urunler : Form
    {
        SqlRepository<Urun> urunRepo = new SqlRepository<Urun>();
        public Urunler()
        {
            InitializeComponent();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = urunRepo.Listele().Select(s => new { 
                ID=s.ID,
                Adı =s.Ad,
                Barkodu=s.Barkod,
                AlışFiyatı=s.AlisFiyat,
                SatışFiyatı=s.SatisFiyat,
                AlışTarihi=s.AlisFiyat,
                STTarihi=s.STTarih,
                Miktar=s.Miktar,
                Birim=s.Birim
                
            }).ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UrunGuncelleSil F2 = new UrunGuncelleSil();
            F2.lblid.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int id = Convert.ToInt32(F2.lblid.Text);
            Urun u = urunRepo.IDGoreGetir(g => g.ID == id);
            F2.txtUAd.Text = u.Ad;
            F2.txtUBarkod.Text = u.Barkod;
            F2.txtUAlisTarih.Text = u.AlisTarih;
            F2.txtUSTTarih.Text = u.STTarih;
            F2.txtUAlisFiyat.Text = Convert.ToString(u.AlisFiyat);
            F2.txtUSatisFiyat.Text = Convert.ToString(u.SatisFiyat);
            F2.nmrUMiktar.Value = u.Miktar;
            F2.cmbUBirim.Text= Enum.GetName(typeof(EBirim),(int)u.Birim);


            F2.Show();
            this.Close();
        }
    }
}
