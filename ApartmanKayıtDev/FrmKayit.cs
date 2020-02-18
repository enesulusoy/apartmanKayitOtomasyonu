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
    public partial class FrmKayit : Form
    {
        public FrmKayit()
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
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Daire"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Borclar"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void btnVeriGoster_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kisiBilgi (Ad,Soyad,Daire,Telefon,Mail,Borclar) values ('" + textEdit1.Text.ToString() + "','" + textEdit2.Text.ToString() + "','" + textEdit3.Text.ToString() + "','" + textEdit4.Text.ToString() + "','" + textEdit5.Text.ToString() + "','" + textEdit6.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
        }

        int id = 0;

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from kisiBilgi where id=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textEdit1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textEdit2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textEdit3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textEdit4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textEdit5.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textEdit6.Text = listView1.SelectedItems[0].SubItems[6].Text;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
            textEdit5.Text = "";
            textEdit6.Text = "";

            textEdit1.Focus();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kisiBilgi set Ad='"+textEdit1.Text.ToString()+ "',Soyad='" + textEdit2.Text.ToString() + "',Daire='" + textEdit3.Text.ToString() + "',Telefon='" + textEdit4.Text.ToString() + "',Mail='" + textEdit5.Text.ToString() + "',Borclar='" + textEdit6.Text.ToString() + "'where id="+id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from kisiBilgi where Ad like '%"+textEdit7.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Daire"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Borclar"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmAnaform anaform = new frmAnaform();
            anaform.Show();
            this.Hide();
        }
    }
}
//Data Source=DESKTOP-72PGNVV\SQLEXPRESS;Initial Catalog=dbApartman;User ID=sa