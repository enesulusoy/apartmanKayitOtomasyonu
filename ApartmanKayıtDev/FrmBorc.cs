using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ApartmanKayıtDev
{
    public partial class FrmBorc : Form
    {
        public FrmBorc()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-72PGNVV\SQLEXPRESS;Initial Catalog=dbApartman;User ID=sa;password=1234;");

        private void verileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from kisiBilgi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text=oku["Ad"].ToString();
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Borclar"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frmAnaform anaform = new frmAnaform();
            anaform.Show();
            this.Hide();
        }

        private void FrmBorc_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }
    }
}
