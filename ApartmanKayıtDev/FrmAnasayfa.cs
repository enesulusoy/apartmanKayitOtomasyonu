using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanKayıtDev
{
    public partial class frmAnaform : Form
    {
        public frmAnaform()
        {
            InitializeComponent();
        }

        private void btnDaire_Click(object sender, EventArgs e)
        {
            FrmDaireB daire = new FrmDaireB();
            daire.Show();
            this.Hide();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            FrmKayit kayit = new FrmKayit();
            kayit.Show();
            this.Hide();
        }

        private void btnFotograf_Click(object sender, EventArgs e)
        {
            FrmFotograf fotograf = new FrmFotograf();
            fotograf.Show();
            this.Hide();
        }

        private void btnBorc_Click(object sender, EventArgs e)
        {
            FrmBorc borc = new FrmBorc();
            borc.Show();
            this.Hide();
        }

        private void btnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulamayı yaparken her yaştan insanın kolaylıkla kullanabileceği ve görseli bol bir proje yaparak kolaylık sağlamasını istedik. Bunu yaparken C# dilini kullanırken yanında bir toolu olan Devexpress yapısını da kullandık.");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
