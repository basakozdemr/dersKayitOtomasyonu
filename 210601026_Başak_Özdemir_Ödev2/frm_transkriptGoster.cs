using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210601026_Başak_Özdemir_Ödev2
{
    public partial class frm_TranskriptGoster : Form
    {
        public frm_TranskriptGoster()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=proje;User Id=postgres;Password=1234");

        private void frm_TranskriptGoster_Load(object sender, EventArgs e)
        {
            verileri_goster("select * from DERS where donem='2021/1' and harf_notu!=''", dgv_transkript_1);
            verileri_goster("select * from DERS where donem='2021/2' and harf_notu!=''", dgv_transkript_2);
            verileri_goster("select * from DERS where donem='2022/1' and harf_notu!=''", dgv_transkript_21);
            verileri_goster("select * from DERS where donem='2022/2' and harf_notu!=''", dgv_transkript_22);


            //     transkriptHesapla(dgv_transkript_1);
            //   transkriptHesapla(dgv_transkript_2);
            verileri_goster("select  (sum(ders.kredi* notlar.not_deger ) / sum(ders.kredi)) \r\nfrom ders \r\nInner join notlar on ders.harf_notu=notlar.harf_notu\r\nwhere ders.donem='2021/1'", dgv_transkript_1y);
            verileri_goster("select  (sum(ders.kredi* notlar.not_deger ) / sum(ders.kredi)) \r\nfrom ders \r\nInner join notlar on ders.harf_notu=notlar.harf_notu\r\nwhere ders.donem='2021/1'", dgv_transkript_1g);

            verileri_goster("select  (sum(ders.kredi* notlar.not_deger ) / sum(ders.kredi)) \r\nfrom ders \r\nInner join notlar on ders.harf_notu=notlar.harf_notu\r\nwhere ders.donem='2021/2'", dgv_transkript_2y);
            verileri_goster("select  (sum(ders.kredi * notlar.not_deger) / sum(ders.kredi)) \r\nfrom ders\r\nInner join notlar on ders.harf_notu = notlar.harf_notu\r\nwhere ders.donem = '2021/1' or ders.donem = '2021/2'", dgv_transkript_2g);

            verileri_goster("select  (sum(ders.kredi* notlar.not_deger ) / sum(ders.kredi)) \r\nfrom ders \r\nInner join notlar on ders.harf_notu=notlar.harf_notu\r\nwhere ders.donem='2022/1'", dgv_transkript_21y);
            verileri_goster("select  (sum(ders.kredi * notlar.not_deger) / sum(ders.kredi)) \r\nfrom ders\r\nInner join notlar on ders.harf_notu = notlar.harf_notu\r\nwhere ders.donem = '2021/1' or ders.donem = '2021/2' or ders.donem = '2022/1'", dgv_transkript_21g);


            verileri_goster("select  (sum(ders.kredi* notlar.not_deger ) / sum(ders.kredi)) \r\nfrom ders \r\nInner join notlar on ders.harf_notu=notlar.harf_notu\r\nwhere ders.donem='2022/2'", dgv_transkript_22y);
            verileri_goster("select  (sum(ders.kredi * notlar.not_deger) / sum(ders.kredi)) \r\nfrom ders\r\nInner join notlar on ders.harf_notu = notlar.harf_notu\r\nwhere ders.donem = '2021/1' or ders.donem = '2021/2' or ders.donem = '2022/1' or ders.donem = '2022/2'", dgv_transkript_22g);




            // MessageBox.Show(ortalama.ToString());

        }
        /*
                public void transkriptHesapla(DataGridView dataGridView)
                {
                    conn.Open();

                    //   MessageBox.Show(dataGridView.Rows.Count.ToString());
                    string[] notlar = new string[dataGridView.Rows.Count];

                    int krediToplam = 0;
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Cells[2].Value != null)
                        {
                            krediToplam += (int)row.Cells[2].Value;
                        }

                    }


                    conn.Close();

                }

                */
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

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } }
