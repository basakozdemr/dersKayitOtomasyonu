using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210601026_Başak_Özdemir_Ödev2
{
    public partial class Frm_KayitEkle : Form
    {
        public Frm_KayitEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=proje;User Id=postgres;Password=1234");

        private void btn_KayitEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;
            

            komut_ekle.Parameters.AddWithValue("@kod", txt_Kod.Text);
            komut_ekle.Parameters.AddWithValue("@ad", txt_Ad.Text);
            komut_ekle.Parameters.AddWithValue("@harfNotu", txt_HarfNotu.Text);
            komut_ekle.Parameters.AddWithValue("@ogretimUyesi", txt_OgretimUyesi.Text);
            komut_ekle.Parameters.AddWithValue("@kredi", Convert.ToDecimal(txt_Kredi.Text));
            komut_ekle.Parameters.AddWithValue("@donem", txt_Donem.Text);
            komut_ekle.Parameters.AddWithValue("@akts", Convert.ToInt32(txt_Akts.Text));
            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into DERS (kod, ad, harf_notu, ogretim_uyesi,kredi,donem,akts) values (@kod, @ad, @harfNotu, @ogretimUyesi, @kredi,@donem,@akts)";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            
            conn.Close();
            komut_ekle.Dispose();

            this.Close();
            MessageBox.Show("KAYIT BAŞARILI", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /// buraya başarıyla eklendi bildirimi ekle///*********************************************************************************************
        }

        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
