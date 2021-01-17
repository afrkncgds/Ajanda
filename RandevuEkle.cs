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
    public partial class RandevuEkle : Form
    {
        public RandevuEkle()
        {
            InitializeComponent();
        }

        AjandaEntitiess ae = new AjandaEntitiess();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Randevular randevu = new Randevular();

            randevu.Aciklama = txtAciklama.Text;
            randevu.Baslik = txtBaslik.Text;
            randevu.KullaniciAd = cmbxKullaniciAd.SelectedItem.ToString();
            randevu.RandevuTarih = Convert.ToDateTime(dtTarih.Value);
            randevu.RandevuSaat = TimeSpan.Parse(txtSaat.Text);

            ae.Randevular.Add(randevu);
            ae.SaveChanges();

            MessageBox.Show("Randevu Eklendi");
        }

        private void RandevuEkle_Load(object sender, EventArgs e)
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
            var randevu = ae.Randevular.Where(w => w.RandevuId == id).FirstOrDefault();

            ae.Randevular.Remove(randevu);
            ae.SaveChanges();

            MessageBox.Show("Randevu Silindi");
        }

        private void btnBilgiGetir_Click(object sender, EventArgs e)
        {
            var randevu = ae.Randevular.Where(w => w.KullaniciAd == cmbxKullaniciAd.SelectedItem.ToString() && w.Baslik == txtBaslik.Text).FirstOrDefault();

            dtTarih.Value = randevu.RandevuTarih.GetValueOrDefault();
            txtSaat.Text = randevu.RandevuSaat.ToString();
            txtID.Text = randevu.RandevuId.ToString();
            txtAciklama.Text = randevu.Aciklama;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var randevu = ae.Randevular.Where(w => w.RandevuId == id).FirstOrDefault();

            randevu.Aciklama = txtAciklama.Text;
            randevu.Baslik = txtBaslik.Text;
            randevu.KullaniciAd = cmbxKullaniciAd.SelectedItem.ToString();
            randevu.RandevuTarih = Convert.ToDateTime(dtTarih.Value);
            randevu.RandevuSaat = TimeSpan.Parse(txtSaat.Text);

            ae.SaveChanges();

            MessageBox.Show("Randevu Güncellendi");
        }
    }
}
