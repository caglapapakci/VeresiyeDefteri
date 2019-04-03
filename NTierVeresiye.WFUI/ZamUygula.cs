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
    public partial class ZamUygula : Form
    {
        SqlRepository<Urun> urunRepo = new SqlRepository<Urun>();
        public ZamUygula()
        {
            InitializeComponent();
        }

        private void ZamUygula_Load(object sender, EventArgs e)
        {
            cmbZUrun.DataSource = urunRepo.Listele().Select(s => new { ID=s.ID,Ad=s.Ad}).ToList();
  
        }

        private void btnZIpta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbZUrun.SelectedValue);
            Urun u = urunRepo.Filtreleme(s => s.ID == id).FirstOrDefault();
            decimal x = Convert.ToDecimal(nmrZOran.Value);
            u.SatisFiyat =(u.SatisFiyat+ ((u.SatisFiyat * x) / 100));
            urunRepo.Guncelle(u);
            cmbZUrun.SelectedIndex = -1;
            nmrZOran.Value = 0;



        }
    }
}
