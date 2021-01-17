using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ajanda
{
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        AjandaEntitiess ae = new AjandaEntitiess();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanici = new Kullanicilar();

            kullanici.AdSoyad = txtAdSoyad.Text;
            kullanici.DogumTarihi = Convert.ToDateTime(dtDogumGunu.Value);
            kullanici.Email = txtEposta.Text;
            kullanici.Gsm = txtGsm.Text;
            kullanici.KullaniciAd = txtKullaniciAd.Text;
            kullanici.Sifre = txtSifre.Text;

            ae.Kullanicilar.Add(kullanici);
            ae.SaveChanges();

            MessageBox.Show("Kullanıcı Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var kullanici = ae.Kullanicilar.Where(w => w.KullaniciAd == txtKullaniciAd.Text).FirstOrDefault();

            ae.Kullanicilar.Remove(kullanici);
            ae.SaveChanges();

            MessageBox.Show("Kullanıcı Silindi");
        }

        private void btnBilgiGetir_Click(object sender, EventArgs e)
        {
            var kullanici = ae.Kullanicilar.Where(w => w.KullaniciAd == txtKullaniciAd.Text).FirstOrDefault();

            txtID.Text = kullanici.KullaniciId.ToString();
            txtGsm.Text = kullanici.Gsm;
            txtEposta.Text = kullanici.Email;
            txtAdSoyad.Text = kullanici.AdSoyad;
            txtSifre.Text = kullanici.Sifre;
            dtDogumGunu.Value = Convert.ToDateTime(kullanici.DogumTarihi.ToString());
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var kullanici = ae.Kullanicilar.Where(w => w.KullaniciId == id).FirstOrDefault();

            kullanici.AdSoyad = txtAdSoyad.Text;
            kullanici.DogumTarihi = Convert.ToDateTime(dtDogumGunu.Value);
            kullanici.Email = txtEposta.Text;
            kullanici.Gsm = txtGsm.Text;
            kullanici.KullaniciAd = txtKullaniciAd.Text;
            kullanici.Sifre = txtSifre.Text;

            ae.SaveChanges();

            MessageBox.Show("Kullanıcı Güncellendi");
        }
    }
}
