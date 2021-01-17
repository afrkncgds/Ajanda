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
    public partial class TumRandevular : Form
    {
        public TumRandevular()
        {
            InitializeComponent();
        }

        AjandaEntitiess ae = new AjandaEntitiess();

        private void TumRandevular_Load(object sender, EventArgs e)
        {
            var kullanici = ae.Kullanicilar.ToList();

            foreach (var item in kullanici)
            {
                cmbxKullaniciAd.Items.Add(item.KullaniciAd);
            }
        }

        private void cmbxKullaniciAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            var randevu = ae.Randevular.Where(w => w.KullaniciAd == cmbxKullaniciAd.SelectedItem.ToString());

            dataGridView1.DataSource = randevu.ToList();
        }
    }
}
