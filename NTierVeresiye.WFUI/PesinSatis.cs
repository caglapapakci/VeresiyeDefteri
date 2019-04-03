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
    public partial class PesinSatis : Form
    {
        public PesinSatis()
        {
            InitializeComponent();
        }

        private void btnPesinSatisKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesinSatisBorcEkle_Click(object sender, EventArgs e)
        {
            BorcEkle frmBorcEkle = new BorcEkle();
            frmBorcEkle.Show();
            this.Close();
        }

        private void btnPesinSatisMusteriBul_Click(object sender, EventArgs e)
        {
            MüsterilerSatis frmMusteriEkle = new MüsterilerSatis();
            frmMusteriEkle.Show();
            this.Close();
        }
    }
}
