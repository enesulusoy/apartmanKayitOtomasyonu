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
    public partial class FrmFotograf : Form
    {
        public FrmFotograf()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            frmAnaform anaform = new frmAnaform();
            anaform.Show();
            this.Hide();
        }
    }
}
