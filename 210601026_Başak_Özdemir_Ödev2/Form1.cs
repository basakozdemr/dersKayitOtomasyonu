using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace _210601026_Başak_Özdemir_Ödev2
{
    public partial class Frm_menu : Form
    {
        public Frm_menu()
        {
            InitializeComponent();
        }


        private void btn_frmTranskript_Click(object sender, EventArgs e)
        {
            frm_TranskriptGoster frm_transkriptGoster = new frm_TranskriptGoster();
            frm_transkriptGoster.ShowDialog();



        }


        private void btn_kayitIslem_Click(object sender, EventArgs e)
        {
            Frm_KayitIslem frm_kayitIslem = new Frm_KayitIslem();
            frm_kayitIslem.ShowDialog();
        }

       
    }
}