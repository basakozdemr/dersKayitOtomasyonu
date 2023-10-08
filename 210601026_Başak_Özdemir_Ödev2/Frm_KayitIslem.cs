using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210601026_Başak_Özdemir_Ödev2
{
    public partial class Frm_KayitIslem : Form
    {
        public Frm_KayitIslem()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=proje;User Id=postgres;Password=1234");


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

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            
            Frm_YeniBilgiler frm_yeniBilgiler = new Frm_YeniBilgiler();
            string txtguncelle = txt_kod.Text;
            
            frm_yeniBilgiler.txt_GuncellenecekKod.Text = txt_kod.Text;

            if(txt_kod.Text=="")
            {
                MessageBox.Show("Ders Kodu Giriniz");
            }
            else
            {
                frm_yeniBilgiler.ShowDialog();
            }

            
            verileri_goster("select * from DERS order by donem", dgv_Guncelle);

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                conn.Open();
                NpgsqlCommand komut_sil = new NpgsqlCommand();
                komut_sil.Connection = conn;
                komut_sil.Parameters.AddWithValue("@silinecekDers", txt_kod.Text);

                komut_sil.CommandType = CommandType.Text;
                komut_sil.CommandText = "delete from DERS where kod = @silinecekDers";

                NpgsqlDataReader dr = komut_sil.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dgv_Guncelle.DataSource = dt;

                }
                komut_sil.Dispose();

                conn.Close();
            }
            {
                verileri_goster("select * from DERS order by donem", dgv_Guncelle);
            }


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Frm_KayitEkle frm_KayitEkle = new Frm_KayitEkle();
            frm_KayitEkle.ShowDialog();

            verileri_goster("select * from DERS order by donem", dgv_Guncelle);

        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_KayitIslem_Load(object sender, EventArgs e)
        {
            verileri_goster("select * from DERS order by donem", dgv_Guncelle);

        }
    }
}
