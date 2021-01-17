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
    public partial class YapilacaklarYeniListe : Form
    {
        public YapilacaklarYeniListe()
        {
            InitializeComponent();
        }

        AjandaEntitiess ae = new AjandaEntitiess();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            YapilacaklarListesi liste = new YapilacaklarListesi();

            liste.Aciklama = txtAciklama.Text;
            liste.Baslik = txtBaslik.Text;
            liste.KullaniciAd = cmbxKullaniciAd.SelectedItem.ToString();
            liste.YapilacaklarTarih = Convert.ToDateTime(dtTarih.Value);
            liste.YapilacaklarSaat = TimeSpan.Parse(txtSaat.Text);

            ae.YapilacaklarListesi.Add(liste);
            ae.SaveChanges();

            MessageBox.Show("Liste Eklendi");
        }

        private void YapilacaklarYeniListe_Load(object sender, EventArgs e)
        {
            var kullanici = ae.Kullanicilar.ToList();

            foreach (var item in kullanici)
            {
                cmbxKullaniciAd.Items.Add(item.KullaniciAd);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var liste = ae.YapilacaklarListesi.Where(w => w.ListeId == id).FirstOrDefault();

            ae.YapilacaklarListesi.Remove(liste);
            ae.SaveChanges();

            MessageBox.Show("Liste Silindi");
        }

        private void btnBilgiGetir_Click(object sender, EventArgs e)
        {
            var liste = ae.YapilacaklarListesi.Where(w => w.KullaniciAd == cmbxKullaniciAd.SelectedItem.ToString() && w.Baslik == txtBaslik.Text).FirstOrDefault();

            dtTarih.Value = liste.YapilacaklarTarih.GetValueOrDefault();
            txtSaat.Text = liste.YapilacaklarSaat.ToString();
            txtID.Text = liste.ListeId.ToString();
            txtAciklama.Text = liste.Aciklama;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var liste = ae.YapilacaklarListesi.Where(w => w.ListeId == id).FirstOrDefault();

            liste.Aciklama = txtAciklama.Text;
            liste.Baslik = txtBaslik.Text;
            liste.KullaniciAd = cmbxKullaniciAd.SelectedItem.ToString();
            liste.YapilacaklarTarih = Convert.ToDateTime(dtTarih.Value);
            liste.YapilacaklarSaat = TimeSpan.Parse(txtSaat.Text);

            ae.SaveChanges();

            MessageBox.Show("Liste Güncellendi");
        }
    }
}
