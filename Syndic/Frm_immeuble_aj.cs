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
    public partial class Frm_immeuble_aj : Form
    {
        SqlCommand com = new SqlCommand();
        SqlCommand com1 = new SqlCommand();
        SqlDataReader dr;
        SqlConnection CN = new SqlConnection();
        string anciennes = "";
        string nouvelles = "";
        string s = "";
        int id;
        public Frm_immeuble_aj(string _S, int id)
        {
            InitializeComponent();
            s = _S;
            this.id = id;
            label5.Text = _S;
        }
        public void ouvrirconnection()
        {
            if (CN.State != ConnectionState.Open)
            {
                CN.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                CN.Open();
            }
        }
        private void journal()
        {
            com = new SqlCommand("select id_immeuble as [ID] , nom as [Nom immeuble],titrefoncier as[titre foncier],paiment from immeuble where id_immeuble =" + id, Fonctions.CnConnection());
            dr = com.ExecuteReader();
            dr.Read();
            nouvelles += " Nom immeuble =" + dr["Nom immeuble"].ToString() + "titre foncier = " + dr["titre foncier"].ToString() + "paiment = " + dr["paiment"].ToString();
            dr.Close();
            com = null;

            com1 = new SqlCommand("insert into journal values (1,GETDATE(),'Modifier','immeuble','" + anciennes + "','" + nouvelles + "',1)", Fonctions.CnConnection());
            com1.ExecuteNonQuery();
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

        }

        private void btn_immeuble_valider_Click(object sender, EventArgs e)
        {
            if (label5.Text == "Ajouter Immeuble")
            {

                if (txt_nm.Text != "" && txt_tit.Text != "")
                {
                    if (rd_mois.Checked == true)
                    {
                        com = new SqlCommand("insert into immeuble values('" + txt_nm.Text + "' ,'4', '" + txt_tit.Text + "' , '"
                       + "mois" + "' ,'1')", CN);

                    }
                    else
                    {
                        com = new SqlCommand("insert into immeuble values('" + txt_nm.Text + "' ,'4', '" + txt_tit.Text + "' , '"
                      + "annee" + "' ,'1')", CN);
                    }

                    int a = -1;
                    a = com.ExecuteNonQuery();
                    journal();
                    if (a != -1)
                    {
                        DialogResult d = MessageBox.Show("Enregistrer acev succés ", "Enregistrer", MessageBoxButtons.OK);
                        if (DialogResult.OK == d)
                        {

                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Erreur  !!");
                    }

                }
                else
                    MessageBox.Show("Remplire Les champs");
            }
            else if (label5.Text == "Modifier Immeuble")
            {
                com = null;

                dr.Close();
                com1 = null;

                if (rd_anne.Checked == true)
                {
                    com = new SqlCommand("update immeuble set nom = '" + txt_nm.Text + "',titrefoncier = '" + txt_tit.Text + "', paiment = '" + rd_anne.Text + "' where id_immeuble = " + id, CN);

                }
                else
                {
                    com = new SqlCommand("update immeuble set nom = '" + txt_nm.Text + "',titrefoncier = '" + txt_tit.Text + "', paiment = '" + rd_mois.Text + "' where id_immeuble = " + id, CN);

                }

                int f = -1;
                f = com.ExecuteNonQuery();
                journal();
                if (f != -1)
                {
                    DialogResult d = MessageBox.Show("Modifier avec succès !!", "Modifier", MessageBoxButtons.OK);
                    if (DialogResult.OK == d)
                    {

                        this.Close();

                    }
                }

                else
                {
                    MessageBox.Show("Erreur modifie !!");
                }

            }


        }

        private void Frm_immeuble_aj_Load(object sender, EventArgs e)
        {
            ouvrirconnection();
            if (label5.Text == "Modifier Immeuble")
            {
                if (CN.State != ConnectionState.Open)
                    CN.Open();
                com = null;
                com = new SqlCommand("select id_immeuble as [ID] , nom as [Nom immeuble],titrefoncier as[titre foncier],paiment from immeuble where id_immeuble = " + id, CN);
                dr = com.ExecuteReader();

                dr.Read();

                anciennes += " Nom immeuble =" + dr["Nom immeuble"].ToString() + "titre foncier = " + dr["titre foncier"].ToString() + "paiment = " + dr["paiment"].ToString();

                txt_nm.Text = dr[1].ToString();
                txt_tit.Text = dr[2].ToString();
                if (dr[3].ToString() == "Année")
                {
                    rd_anne.Checked = true;
                }
                else
                    rd_mois.Checked = true;


                dr.Close();
                com = null;
            }

        }

        private void btn_immeuble_Annuler_Click(object sender, EventArgs e)
        {
            if (label5.Text == "Ajouter Immeuble")
            {
                txt_nm.Text = "";

                txt_tit.Text = "";

            }
            else
                this.Close();
        }
    }
}
