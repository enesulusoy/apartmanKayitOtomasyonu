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
    public partial class frmDaire : Form
    {
        public frmDaire()
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

        private void btnDaire1_Click(object sender, EventArgs e)
        {
            renkler();
            btnDaire1.BackColor = Color.Turquoise;
            labelControl1.Visible = true;
            lblAdsoyad.Text = "Enes Ulusoy";
        }

    }
}
