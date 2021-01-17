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
    public partial class Anasayfa : Form
    {
        private int childFormNumber = 0;

        public Anasayfa()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        AjandaEntitiess ae = new AjandaEntitiess();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAd.Text != null && txtSifre.Text != null)
            {
               var Kullanici = ae.Kullanicilar.Where(w => w.KullaniciAd == txtKullaniciAd.Text).FirstOrDefault(); 
               
                if (txtSifre.Text == Kullanici.Sifre)
                {
                    menuAjanda.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Hatalı Şifre!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifre Kısmını Eksiksiz Doldurun!");
            }
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciEkle frm = new KullaniciEkle();
            frm.Show();
        }

        private void kullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciBilgileri frm = new KullaniciBilgileri();
            frm.Show();
        }

        private void tümRandevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TumRandevular frm = new TumRandevular();
            frm.Show();
        }

        private void randevuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandevuEkle frm = new RandevuEkle();
            frm.Show();
        }

        private void tümListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YapilacaklarTumListe frm = new YapilacaklarTumListe();
            frm.Show();
        }

        private void yeniListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YapilacaklarYeniListe frm = new YapilacaklarYeniListe();
            frm.Show();
        }
    }
}
