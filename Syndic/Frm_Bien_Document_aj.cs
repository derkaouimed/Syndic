using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Data.SqlClient;

namespace Syndic
{
    public partial class Frm_Bien_Document_aj : Form
    {
        SqlDataReader DR;
        SqlCommand com = new SqlCommand();
        SqlCommand comI = new SqlCommand();
        SqlConnection CN = new SqlConnection();
        SqlDataReader DRT;
        SqlCommand comT = new SqlCommand();

        string s = "";
        int id;
   
        public Frm_Bien_Document_aj(string s , int id)
        {
            InitializeComponent();
            this.id = id;
            this.s = s;
            label3.Text = s;
        }
        public void ouvrirconnection()
        {
            if (CN.State != ConnectionState.Open)
            {
                CN.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                CN.Open();
            }
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Bien_Document_aj_Load(object sender, EventArgs e)
        {
            ouvrirconnection();
            if (label3.Text == "Modifier")
            {
                if (CN.State != ConnectionState.Open)
                    CN.Open();
                com = new SqlCommand("select nom, fichier, b.NomApparetemnt from document_bien d inner join bien b on b.id_bien = d.id_bien where id_document= " + id, CN);

                DR = com.ExecuteReader();

                DR.Read();
                txt_nom.Text = DR[1].ToString();
                txt_fich.Text = DR[3].ToString();
                cmb_bien.Text = DR[2].ToString();
                DR.Close();
                com = null;

            }


            comT = new SqlCommand("Select NomApparetemnt from bien", CN);
            DRT = comT.ExecuteReader();
            while (DRT.Read())
            {
                cmb_bien.Items.Add("" + DRT[0].ToString());

            }
            comT = null;
            DRT.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }

        private void btn_Recette_valider_Click(object sender, EventArgs e)
        {
            if (label3.Text == "Ajouter")
            {
                com = new SqlCommand("Select id_bien from bien where nom like '" + cmb_bien.Text + "'", CN);
                DR = com.ExecuteReader();
                DR.Read();
                int T = int.Parse(DR[0].ToString());

                if (txt_nom.Text != "" && txt_fich.Text != "")
                {
                    com = null;
                    DR.Close();

                    com = new SqlCommand("insert into document_bien values('" + txt_nom.Text + ",'" + txt_fich.Text + ",'" + T + ",1)", CN);
                    int a = -1;
                    a = com.ExecuteNonQuery();
                    if (a != -1)
                    {
                        MessageBox.Show("Enregistrer !!! ");
                    }
                    else
                    {
                        MessageBox.Show("not enregistrer !!");
                    }

                }
                else
                    MessageBox.Show("Remplir tous les champs !!!");
            }
            else if (label3.Text == "Modifier")
            {
                int I = 0;
                comI = new SqlCommand("Select distinct id_bien from bien where nom like '%" + cmb_bien.Text + "%'", CN);
                DR = com.ExecuteReader();
                DR.Read();
                I = int.Parse(DR[0].ToString());
                comI = new SqlCommand("update document_bien set nom = '" + txt_nom.Text + "',document = '" + txt_fich.Text + "',id_bien = '" + I + " where id_remarque = " + id, CN);
                int f = -1;
                f = comI.ExecuteNonQuery();
                if (f != -1)
                {
                    MessageBox.Show("modifie");
                }
                else
                {
                    MessageBox.Show("Erreur modifie !!");
                }

            }

        }
    }
}
