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
    public partial class YapilacaklarTumListe : Form
    {
        public YapilacaklarTumListe()
        {
            InitializeComponent();
        }

        AjandaEntitiess ae = new AjandaEntitiess();

        private void YapilacaklarTumListe_Load(object sender, EventArgs e)
        {
            var kullanici = ae.Kullanicilar.ToList();

            foreach (var item in kullanici)
            {
                cmbxKullaniciAd.Items.Add(item.KullaniciAd);
            }
        }

        private void cmbxKullaniciAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            var liste = ae.YapilacaklarListesi.Where(w => w.KullaniciAd == cmbxKullaniciAd.SelectedItem.ToString());

            dataGridView1.DataSource = liste.ToList();
        }
    }
}
