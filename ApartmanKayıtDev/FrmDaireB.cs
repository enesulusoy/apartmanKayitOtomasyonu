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
    public partial class FrmDaireB : Form
    {
        public FrmDaireB()
        {
            InitializeComponent();
        }

        private void renkler()
        {
            btnDaire1.BackColor = Color.Gray;
            btnDaire2.BackColor = Color.Gray;
            btnDaire3.BackColor = Color.Gray;
            btnDaire4.BackColor = Color.Gray;
            btnDaire5.BackColor = Color.Gray;
            btnDaire6.BackColor = Color.Gray;
            btnDaire7.BackColor = Color.Gray;
            btnDaire8.BackColor = Color.Gray;
        }

        private void FrmDaireB_Load(object sender, EventArgs e)
        {
            renkler();
            lblAdsoyad.Text = "";
        }

        private void btnDaire1_Click(object sender, EventArgs e)
        {
            renkler();
            btnDaire1.BackColor = Color.Turquoise;
            labelControl1.Visible = true;
            lblAdsoyad.Text = "Enes Ulusoy";
        }

        private void btnDaire2_Click(object sender, EventArgs e)
        {
            renkler();
            btnDaire2.BackColor = Color.Turquoise;
            labelControl1.Visible = true;
            lblAdsoyad.Text = "Emin Ulusoy";
        }

        private void btnDaire3_Click(object sender, EventArgs e)
        {
            renkler();
            btnDaire3.BackColor = Color.Turquoise;
            labelControl1.Visible = true;
            lblAdsoyad.Text = "Sena Ulusoy";
        }

        private void btnDaire4_Click(object sender, EventArgs e)
        {
            renkler();
            btnDaire4.BackColor = Color.Turquoise;
            labelControl1.Visible = true;
            lblAdsoyad.Text = "Gülcan Ulusoy";
        }

        private void btnDaire5_Click(object sender, EventArgs e)
        {
            renkler();
            btnDaire5.BackColor = Color.Turquoise;
            labelControl1.Visible = true;
            lblAdsoyad.Text = "Şevket Ulusoy";
        }

        private void btnDaire6_Click(object sender, EventArgs e)
        {
            renkler();
            btnDaire6.BackColor = Color.Turquoise;
            labelControl1.Visible = true;
            lblAdsoyad.Text = "Hüseyin Ulusoy";
        }

        private void btnDaire7_Click(object sender, EventArgs e)
        {
            renkler();
            btnDaire7.BackColor = Color.Turquoise;
            labelControl1.Visible = true;
            lblAdsoyad.Text = "Okan Ulusoy";
        }

        private void btnDaire8_Click(object sender, EventArgs e)
        {
            renkler();
            btnDaire8.BackColor = Color.Turquoise;
            labelControl1.Visible = true;
            lblAdsoyad.Text = "Meryem Ulusoy";
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frmAnaform ana = new frmAnaform();
            ana.Show();
            this.Hide();
        }
    }
}
