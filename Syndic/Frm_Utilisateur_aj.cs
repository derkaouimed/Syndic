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
using System.Configuration;
using System.Runtime.InteropServices;

namespace Syndic
{
    public partial class Frm_Utilisateur_aj : Form
    {
        string s = "";
        int id;
        SqlDataReader dr;
        public Frm_Utilisateur_aj(String _S, int id)
        {
            InitializeComponent();
            s = _S;
            this.id = id;
            label4.Text = _S;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_utilisateur_type f = new Frm_utilisateur_type();
            f.ShowDialog();
        }

        private void Frm_Utilisateur_aj_Load(object sender, EventArgs e)
        {
            Fonctions.ouvrireConnection();
            if (lbl_titre.Text == "Modifier")
            {
                if (Fonctions.CnConnection().State != ConnectionState.Open)
                    Fonctions.CnConnection().Open();

                string sql = "select u.id_utilisateur,u.login,u.password,u.salt,t.nom_type,(e.prenom+' '+e.nom) as [Nom Complete] from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join employe e on e.id_employe = u.id_table where u.id_utilisateur= " +id;
                SqlCommand com = new SqlCommand(sql, Fonctions.CnConnection());

                dr = com.ExecuteReader();
                dr.Read();
                txt_log.Text = dr[1].ToString();
                txt_pass.Text = dr[2].ToString();
                cb_type.Text = dr[4].ToString();
                cb_nomc.Text = dr[5].ToString();

                dr = null;
                dr.Close();
            }

             SqlCommand com1 = new SqlCommand("Select nom_type from type_utilisateur where archive =1", Fonctions.CnConnection());
            dr = com1.ExecuteReader();
            while (dr.Read())
            {
                cb_type.Items.Add("" + dr[0].ToString());

            }
            com1 = null;
            dr.Close();

            //com1 = new SqlCommand("Select nom+' '+prenom from Employe where archive=1", Fonctions.CnConnection());
            //dr = com1.ExecuteReader();
            //while (dr.Read())
            //{
            //    cb_nomc.Items.Add("" + dr[0].ToString());

            //}
            //com1 = null;
            //dr.Close();


        }


        private void btn_close_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btn_vider_Click(object sender, EventArgs e)
        {
            txt_log.Text = "";
            txt_pass.Text = "";
            cb_type.Text = "";
        }

        private void btn_annuler_ajt_Click(object sender, EventArgs e)
        {
            txt_log.Text = "";
            txt_pass.Text = "";
            cb_type.Text = "";
            this.Close();

        }

        private void btn_valider_ajt_Click(object sender, EventArgs e)
        {
            if (lbl_titre.Text == "Ajouter")
            {

            }
            else if (lbl_titre.Text == "Modifier")
            {

            }
            else
            {

            }

        }
    }
}
