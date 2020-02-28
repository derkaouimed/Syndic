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
using System.Security.Cryptography;

namespace Syndic
{
    public partial class Frm_Utilisateur_aj : Form
    {
        string s = "";
        int id;
        SqlCommand com1;
        SqlCommand com;
        SqlDataReader dr;
        SqlDataReader DR;
        string anciennes = "";
        string nouvelles = "";


        private string passInc(string pass, string salt)
        {
            string password;

            byte[] data = UTF8Encoding.UTF8.GetBytes(pass);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(salt));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] resulta = transform.TransformFinalBlock(data, 0, data.Length);
                    password = Convert.ToBase64String(resulta, 0, resulta.Length);
                }
            }

            return password;
        }


        public Frm_Utilisateur_aj(String _S, int id)
        {
            InitializeComponent();
            s = _S;
            this.id = id;
            lbl_titre.Text = _S;
        }
        private void journal()
        {
            string sql = "select u.id_utilisateur,u.login,u.password,u.salt,t.nom_type,(e.prenom+' '+e.nom) as [Nom Complete] from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join employe e on e.id_employe = u.id_table where  t.nom_type = 'Employée' and u.archive = 1 and u.id_utilisateur =" + id +
        "union select u.id_utilisateur,u.login,u.password,u.salt,t.nom_type,(e.prenom + ' ' + e.nom) as [Nom Complete] from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join proprietaire e on e.id_proprietaire = u.id_table where t.nom_type = 'Proprietaire' and u.archive = 1 and u.id_utilisateur= " + id;

            com = new SqlCommand(sql, Fonctions.CnConnection());
            dr = com.ExecuteReader();
            dr.Read();
            nouvelles += "Id =" + dr["id_utilisateur"].ToString() + " Nom Complet =" + dr["Nom Complete"].ToString() + "Login = " + dr["login"].ToString() + "Password =" + dr["password"].ToString() + "type=" + dr["nom_type"].ToString();
            dr.Close();
            com = null;

            com = new SqlCommand("insert into journal values (1,GETDATE(),'Modifier','utilisateur','" + anciennes + "','" + nouvelles + "',1)", Fonctions.CnConnection());
            com.ExecuteNonQuery();
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
        }

        private void Frm_Utilisateur_aj_Load(object sender, EventArgs e)
        {
            Fonctions.ouvrireConnection();
            if (lbl_titre.Text == "Modifier utilisateur")
            {
                if (Fonctions.CnConnection().State != ConnectionState.Open)
                    Fonctions.CnConnection().Open();

                string sql = "select u.id_utilisateur,u.login,u.password,u.salt,t.nom_type,(e.prenom+' '+e.nom) as [Nom Complete] from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join employe e on e.id_employe = u.id_table where  t.nom_type = 'employee' and u.archive = 1 and u.id_utilisateur =" + id +
                    "union select u.id_utilisateur,u.login,u.password,u.salt,t.nom_type,(e.prenom + ' ' + e.nom) as [Nom Complete] from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join proprietaire e on e.id_proprietaire = u.id_table where t.nom_type = 'proprietaire' and u.archive = 1 and u.id_utilisateur= " + id;
                SqlCommand com = new SqlCommand(sql, Fonctions.CnConnection());

                dr = com.ExecuteReader();
                dr.Read();

                anciennes += "Id =" + dr["id_utilisateur"].ToString() + " Nom Complet =" + dr["Nom Complete"].ToString() + "Login = " + dr["login"].ToString() + "Password" + dr["password"].ToString() + "type" + dr["nom_type"].ToString();

                txt_log.Text = dr[1].ToString();
                txt_pass.Text = dr[2].ToString();
                cb_type.Text = dr[4].ToString();
                cb_nomc.Text = dr[5].ToString();
                txt_salt.Text = dr[3].ToString();
                dr.Close();
                dr = null;

            }

            SqlCommand com1 = new SqlCommand("Select nom_type from type_utilisateur where archive =1", Fonctions.CnConnection());
            dr = com1.ExecuteReader();
            while (dr.Read())
            {
                cb_type.Items.Add("" + dr[0].ToString());

            }
            com1 = null;
            dr.Close();
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
            if (lbl_titre.Text == "Ajouter utilisateur")
            {

                if (txt_log.Text != "" && txt_pass.Text != "")
                {

                    com1 = null;
                    com1 = new SqlCommand("Select id_type from type_utilisateur where nom_type like '" + cb_type.Text + "'", Fonctions.CnConnection());
                    DR = com1.ExecuteReader();
                    DR.Read();
                    int T = int.Parse(DR[0].ToString());

                    com1 = null;
                    DR.Close();

                    com1 = new SqlCommand("select u.id_table from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join employe e on e.id_employe = u.id_table where nom_type like '" + cb_type.Text + "'", Fonctions.CnConnection());
                    DR = com1.ExecuteReader();
                    DR.Read();
                    int E = int.Parse(DR[0].ToString());

                    com1 = null;
                    DR.Close();
                    com1 = new SqlCommand("select u.id_table from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join proprietaire e on e.id_proprietaire=u.id_table where nom_type like '" + cb_type.Text + "'", Fonctions.CnConnection());
                    DR = com1.ExecuteReader();
                    DR.Read();
                    int P = int.Parse(DR[0].ToString());

                    com1 = null;
                    dr = null;
                    if (cb_type.Text == "proprietaire")
                    {
                        com1 = null;
                        DR = null;
                        com1 = new SqlCommand(" select nom from proprietaire where (nom+' '+prenom) like  '" + cb_nomc.Text + "'", Fonctions.CnConnection());
                        DR = com1.ExecuteReader();
                        DR.Read();
                        string NP = DR[0].ToString();
                        // MessageBox.Show(NP);
                        com1 = null;

                        DR.Close();

                        com1 = new SqlCommand(" select prenom from proprietaire where (nom+' '+prenom) like '" + cb_nomc.Text + "'", Fonctions.CnConnection());
                        DR = com1.ExecuteReader();
                        DR.Read();
                        string PP = DR[0].ToString();
                        //  MessageBox.Show(PP);
                        com1 = null;
                        DR.Close();

                        string slt = Fonctions.GiveMeSalt(NP, PP);


                        com = new SqlCommand("insert into utilisateur values('" + txt_log.Text + "', '" + passInc(txt_pass.Text, slt) + "' , '"
                      + slt + "','" + T + "','" + P + "','1')", Fonctions.CnConnection());
                    }
                    if (cb_type.Text == "employee")
                    {
                        com1 = null;
                        //dr = null;
                        com1 = new SqlCommand("select nom from employe where (nom+' '+prenom) like '" + cb_nomc.Text + "'", Fonctions.CnConnection());
                        dr = com1.ExecuteReader();
                        dr.Read();
                        string NE = dr[0].ToString();
                        // MessageBox.Show(NE);
                        com1 = null;
                        dr.Close();

                        com1 = new SqlCommand("Select prenom from employe where (nom+' '+prenom) like '" + cb_nomc.Text + "'", Fonctions.CnConnection());
                        dr = com1.ExecuteReader();
                        dr.Read();
                        string PE = dr[0].ToString();
                        // MessageBox.Show(PE);
                        com1 = null;
                        dr.Close();
                        string slt = Fonctions.GiveMeSalt(NE, PE);

                        com = new SqlCommand("insert into utilisateur values('" + txt_log.Text + "' , '" + passInc(txt_pass.Text, slt) + "' , '"
                       + slt + "','" + T + "','" + E + "' ,'1')", Fonctions.CnConnection());


                    }
                    int a = -1;
                    a = com.ExecuteNonQuery();
                    if (a != -1)
                    {
                        DialogResult d = MessageBox.Show("Enregistrer avec sucées", "enregistrer", MessageBoxButtons.OK);
                        if (DialogResult.OK == d)
                            this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erreur  !!");
                    }

                }
                else
                    MessageBox.Show("Remplire Les champs");

            }


            else if (lbl_titre.Text == "Modifier utilisateur")
            {
                com1 = null;

                com1 = new SqlCommand("Select id_type from type_utilisateur where nom_type like '" + cb_type.Text + "'", Fonctions.CnConnection());
                DR = com1.ExecuteReader();
                DR.Read();
                int T = int.Parse(DR[0].ToString());

                com1 = null;
                DR.Close();

                com1 = new SqlCommand("select u.id_table from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join employe e on e.id_employe = u.id_table where nom_type like '" + cb_type.Text + "'", Fonctions.CnConnection());
                DR = com1.ExecuteReader();
                DR.Read();
                int E = int.Parse(DR[0].ToString());

                com1 = null;
                DR.Close();
                com1 = new SqlCommand("select u.id_table from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join proprietaire e on e.id_proprietaire=u.id_table where nom_type like '" + cb_type.Text + "'", Fonctions.CnConnection());
                DR = com1.ExecuteReader();
                DR.Read();
                int P = int.Parse(DR[0].ToString());

                com1 = null;
                dr = null;

                if (cb_nomc.Text == "proprietaire")
                {
                    com = new SqlCommand("update utilisateur set login ='" + txt_log.Text + "', password = '" + passInc(txt_pass.Text, txt_salt.Text) +
                         "',id_type='" + T + "',id_table='" + P + "' where id_utilisateur  = " + id, Fonctions.CnConnection());

                }
                else
                {
                    com = new SqlCommand("update utilisateur set login ='" + txt_log.Text + "', password = '" + passInc(txt_pass.Text, txt_salt.Text) +
                         "',id_type='" + T + "',id_table='" + E + "' where id_utilisateur  = " + id, Fonctions.CnConnection());
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
            }
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_type.Text == "employee")
            {
                cb_nomc.Items.Clear();
                com1 = new SqlCommand("select nom+' '+prenom from employe where archive=1", Fonctions.CnConnection());
                dr = com1.ExecuteReader();
                while (dr.Read())
                {
                    cb_nomc.Items.Add("" + dr[0].ToString());

                }
                com1 = null;
                dr.Close();
            }
            else
            {
                cb_nomc.Items.Clear();
                dr = null;
                com1 = new SqlCommand("select nom+' '+prenom from proprietaire where archive=1", Fonctions.CnConnection());
                dr = com1.ExecuteReader();
                while (dr.Read())
                {
                    cb_nomc.Items.Add("" + dr[0].ToString());

                }
                com1 = null;
                dr.Close();
            }
        }

        private void btn_rubrique_Click(object sender, EventArgs e)
        {
            Frm_utilisateur_type u = new Frm_utilisateur_type("Ajouter type", id);
            u.ShowDialog();
        }
    }
}