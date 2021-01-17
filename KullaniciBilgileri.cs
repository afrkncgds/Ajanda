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
    public partial class KullaniciBilgileri : Form
    {
        public KullaniciBilgileri()
        {
            InitializeComponent();
        }

        AjandaEntitiess ae = new AjandaEntitiess();

        private void btnBilgiGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ae.Kullanicilar.ToList();
        }
    }
}
