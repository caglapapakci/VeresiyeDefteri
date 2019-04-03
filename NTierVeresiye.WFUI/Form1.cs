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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMüsteriEkle_Click(object sender, EventArgs e)
        {
            MüsteriEkleme frmMusteriEkle = new MüsteriEkleme();
            frmMusteriEkle.Show();
            
        }

        private void btnMGüncelleSil_Click(object sender, EventArgs e)
        {
            MüsteriGüncelleSil frmMüsterGuncelleSil = new MüsteriGüncelleSil();
            frmMüsterGuncelleSil.Show();
        }

        private void btnUEKle_Click(object sender, EventArgs e)
        {
            UrunEkleme frmUrunEkle = new UrunEkleme();
            frmUrunEkle.Show();

        }

        private void btnMüsteriListe_Click(object sender, EventArgs e)
        {
            Müsteriler frmMüsteriListele = new Müsteriler();
            frmMüsteriListele.Show();
        }

        private void btnUrunLİste_Click(object sender, EventArgs e)
        {
            Urunler frmUrunListele = new Urunler();
            frmUrunListele.Show();

        }

        private void btnUGuncelleSil_Click(object sender, EventArgs e)
        {
            UrunGuncelleSil frmUrunGuncelleSil = new UrunGuncelleSil();
            frmUrunGuncelleSil.Show();
        }

        

        private void btnUZamUygula_Click_1(object sender, EventArgs e)
        {
            ZamUygula frmZamUygula = new ZamUygula();
            frmZamUygula.Show();

        }

        private void btnHizliMEkle_Click(object sender, EventArgs e)
        {
            MüsteriEkleme frmMusteriEkle = new MüsteriEkleme();
            frmMusteriEkle.Show();
        }

        private void btnHizliUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkleme frmUrunEkle = new UrunEkleme();
            frmUrunEkle.Show();

        }

        private void btnHizliKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTEkle_Click(object sender, EventArgs e)
        {
            TedarikciEkleme frmTedarikciEkle = new TedarikciEkleme();
            frmTedarikciEkle.Show();

        }

        private void btnTGuncelle_Click(object sender, EventArgs e)
        {
            TedarikciGuncelleme frmTedarikciGuncelle = new TedarikciGuncelleme();
            frmTedarikciGuncelle.Show();

        }

        private void btnHizliVadeliSatis_Click(object sender, EventArgs e)
        {
            VadeliSatis frmVadeliSatis = new VadeliSatis();
            frmVadeliSatis.Show();

        }

        private void btnHizliPesinSatis_Click(object sender, EventArgs e)
        {
            PesinSatis frmPesinSatis = new PesinSatis();
            frmPesinSatis.Show();

        }

        private void btnHesapIslemleriVadeliSatis_Click(object sender, EventArgs e)
        {
            VadeliSatis frmVadeliSatis = new VadeliSatis();
            frmVadeliSatis.Show();

        }

        private void btnHesapIslemleriPesinSatis_Click(object sender, EventArgs e)
        {
            PesinSatis frmPesinSatis = new PesinSatis();
            frmPesinSatis.Show();

        }

        private void btnHizliTedarikciListesi_Click(object sender, EventArgs e)
        {
            Tedarikciler frmTedarikciListesi = new Tedarikciler();
            frmTedarikciListesi.Show();

        }
    }
    
}
