using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Kitaplik_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string durum = "";
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\user\Desktop\c# denemelerim\Kitaplik.mdb");

        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From Tbl_Kitaplar", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("insert into Tbl_Kitaplar (KitapAd,KitapYazar,KitapTur,KitapSayfa,Durum) values (@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut1.Parameters.AddWithValue("@p1", txtAd.Text);
            komut1.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut1.Parameters.AddWithValue("@p3", cmbTur.Text);
            komut1.Parameters.AddWithValue("@p4", txtSayfa.Text);
            komut1.Parameters.AddWithValue("@p5", durum);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kaydedildi");
            listele();

        }

        private void rdKullanılmıs_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void rdSifir_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbTur.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if(dataGridView1.Rows[secilen].Cells[5].Value.ToString()=="True")
            {
                rdSifir.Checked =true;
            }
            else
            {
                rdKullanılmıs.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komutsil = new OleDbCommand("Delete * From Tbl_Kitaplar where ID=@p1", baglanti);
            komutsil.Parameters.AddWithValue("@p1", txtID.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Silindi");
           listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komutguncelleme = new OleDbCommand("update Tbl_Kitaplar set KitapAd=@p1,KitapYazar=@p2,KitapTur=@p3,KitapSayfa=@p4,Durum=@p5 where ID=@p6", baglanti);
            komutguncelleme.Parameters.AddWithValue("@p1", txtAd.Text);
            komutguncelleme.Parameters.AddWithValue("@p2", txtYazar.Text);
            komutguncelleme.Parameters.AddWithValue("@p3", cmbTur.Text);
            komutguncelleme.Parameters.AddWithValue("@p4", txtSayfa.Text);
            if(rdKullanılmıs.Checked==true)
            {
                komutguncelleme.Parameters.AddWithValue("@p5", durum);
            }
            if (rdSifir.Checked == true)
            {
                komutguncelleme.Parameters.AddWithValue("@p5", durum);
            }
            komutguncelleme.Parameters.AddWithValue("@p6", txtID.Text);
            komutguncelleme.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap güncellendi");
            listele();
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komutbul = new OleDbCommand("Select *From Tbl_Kitaplar where KitapAd=@p1", baglanti);
            komutbul.Parameters.AddWithValue("@p1", txtbul.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komutbul);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


        }

        private void btnara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komutbul = new OleDbCommand("Select *From Tbl_Kitaplar where KitapAd like '%"+txtbul.Text+"%'", baglanti);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komutbul);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void txtbul_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komutbul = new OleDbCommand("Select *From Tbl_Kitaplar where KitapAd like '%" + txtbul.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komutbul);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
