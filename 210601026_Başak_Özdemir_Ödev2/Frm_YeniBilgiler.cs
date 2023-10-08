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
    public partial class Frm_YeniBilgiler : Form
    {
        public Frm_YeniBilgiler()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=proje;User Id=postgres;Password=1234");

        private void btn_GuncelleYeni_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_guncelle = new NpgsqlCommand();
            komut_guncelle.Connection = conn;
            
            komut_guncelle.CommandText = "update DERS set kod=@kod, ad=@ad, harf_notu=@harfNotu, ogretim_uyesi= @ogretimUyesi,kredi=@kredi, donem=@donem, akts=@akts where kod = @veriKod";
            

            komut_guncelle.Parameters.AddWithValue("@kod", txt_Kod.Text);
            komut_guncelle.Parameters.AddWithValue("@ad", txt_Ad.Text);
            komut_guncelle.Parameters.AddWithValue("@harfNotu", txt_HarfNotu.Text);
            komut_guncelle.Parameters.AddWithValue("@ogretimUyesi", txt_OgretimUyesi.Text);
            komut_guncelle.Parameters.AddWithValue("@kredi", Convert.ToDecimal(txt_Kredi.Text));
            komut_guncelle.Parameters.AddWithValue("@donem", txt_Donem.Text);
            komut_guncelle.Parameters.AddWithValue("@akts", Convert.ToInt32(txt_Akts.Text));
            komut_guncelle.Parameters.AddWithValue("@veriKod",  this.txt_GuncellenecekKod.Text);



            komut_guncelle.CommandType = CommandType.Text;
            komut_guncelle.ExecuteNonQuery();
            conn.Close();
            this.Close();

        }



        private void Frm_YeniBilgiler_Load(object sender, EventArgs e)
        {
            verileri_goster("SELECT * FROM ders WHERE kod = '" + txt_GuncellenecekKod.Text + "'  ", dgv_guncelle);

            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = "select * from DERS where kod Like '" + txt_GuncellenecekKod.Text + "'";
            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_Akts.Text = dr["akts"].ToString();
                txt_Donem.Text = dr["donem"].ToString();
                txt_HarfNotu.Text = dr["harf_notu"].ToString();
                txt_Kredi.Text = dr["kredi"].ToString();
                txt_OgretimUyesi.Text = dr["ogretim_uyesi"].ToString();
                txt_Kod.Text = dr["kod"].ToString();
                txt_Ad.Text = dr["ad"].ToString();
            }
            komut.Dispose();
            conn.Close();

        }  
        
        public int verileri_goster(string txt, DataGridView dataGridView)
            {
                conn.Open();
                NpgsqlCommand komut = new NpgsqlCommand();
                komut.Connection = conn;
                komut.CommandType = CommandType.Text;
                komut.CommandText = txt;
                NpgsqlDataReader dr = komut.ExecuteReader();

                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    dataGridView.DataSource = dt;

                }
                komut.Dispose();
                conn.Close();
                return 0;
            }

        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
