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
    public partial class Frm_Bien_Aj : Form
    {
        SqlDataReader DR;
        SqlDataReader DRI;
        SqlDataReader DRT;
        SqlDataReader DRP;
        SqlCommand com3 = new SqlCommand();
        SqlCommand com = new SqlCommand();
        SqlCommand comI = new SqlCommand();
        SqlCommand comT = new SqlCommand();
        SqlCommand comP = new SqlCommand();
        SqlCommand com2= new SqlCommand();
        SqlConnection CN = new SqlConnection();
        string s = "";
        int id ;
        public Frm_Bien_Aj(String _S, int id)
        {
            InitializeComponent();
            s = _S;
            this.id = id;
            lbl_text.Text = _S;
            
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
            this.Hide();
            Frm_Bien_Type f = new Frm_Bien_Type("Modifier", id);
            f.ShowDialog();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Bien_Aj_Load(object sender, EventArgs e)
        {
            ouvrirconnection();
            if (lbl_text.Text == "Modifier")
            {
                if (CN.State != ConnectionState.Open)
                    CN.Open();
                com = new SqlCommand("select id_bien,NomApparetemnt,etage,superficie,charges,b.titrefoncier , t.nom as [type],i.nom as [immeuble],(p.nom +' '+p.prenom) as [nomComplet] ,c.consomation,c.date_controle from bien B inner join type_bien t on t.id_type=b.id_type_bien inner join conteur_eau c on c.id_conteurEau=b.id_conteurEau inner join immeuble i on i.id_immeuble=b.id_immeuble inner join proprietaire p on p.id_proprietaire= b.id_proprietaire where id_bien= " + id, CN);

                DR = com.ExecuteReader();
                
                DR.Read();
                    txt_nom.Text = DR[1].ToString();
                    txt_etage.Text = DR[2].ToString();
                    txt_superficier.Text = DR[3].ToString();
                    txt_charge.Text = DR[4].ToString();
                    txt_titre.Text = DR[5].ToString();
                    comboBox1.Text = DR[6].ToString();
                    cmb_imm.Text = DR[7].ToString();
                    cmb_prop.Text = DR[8].ToString();
                    txt_consomation.Text = DR[9].ToString();
                    dt_date.Text = DR[10].ToString();

               
                DR.Close();
                com = null;

            }
               

            comT = new SqlCommand("Select nom from type_bien", CN);
            DRT= comT.ExecuteReader();
            while (DRT.Read())
            {
                comboBox1.Items.Add("" + DRT[0].ToString());

            }
            comT = null;
            DRT.Close();


            comI = new SqlCommand("Select nom from immeuble", CN);
            DRI = comI.ExecuteReader();
            while (DRI.Read())
            {
                cmb_imm.Items.Add("" + DRI[0].ToString());

            }
            comI = null;
            DRI.Close();

            comP = new SqlCommand("Select nom+' '+prenom from Proprietaire", CN);
            DRP = comP.ExecuteReader();
            while (DRP.Read())
            {
                cmb_prop.Items.Add("" + DRP[0].ToString());

            }
            comP = null;
            DRP.Close();

        }

        private void btn_Recette_valider_Click(object sender, EventArgs e)
        {


            if (label8.Text == "Ajouter")
            {
                //comT = new SqlCommand("Select id_type from type_bien where nom like '" + comboBox1.Text + "'", CN);
                //DRT = comT.ExecuteReader();
                //DRT.Read();
                //int T = int.Parse(DRT[0].ToString());

                //comI = new SqlCommand("Select id_immeuble from immeuble where nom like '" + cmb_imm.Text + "'", CN);
                //DRI = comI.ExecuteReader();
                //DRI.Read();
                //int b = int.Parse(DRI[0].ToString());

                //comP = new SqlCommand("Select id_proprietaire from Proprietaire where nom+' '+prenom like'" + cmb_prop.Text + "'", CN);
                //DRP = comP.ExecuteReader();
                //DRP.Read();
                //int c = int.Parse(DRP[0].ToString());

                //if (txt_nom.Text != "" && txt_charge.Text != "" && txt_consomation.Text != "" && txt_etage.Text != "" && txt_superficier.Text != "" && txt_titre.Text != "" && comboBox1.Text != "" && cmb_imm.Text != "" && cmb_prop.Text != "" && dt_date.Text != "")
                //{
                //    Random r = new Random();
                //    int j = r.Next(1000);
                //    com = null;
                //    DR.Close();
                //    com3 = new SqlCommand("insert into proprietaire values(" + j + ",'" + txt_nom.Text + "','" + txt_etage.Text + "','" + txt_superficier.Text + "','" + txt_charge.Text + "','"+b + "','"+T + "','"+c + "','" + txt_titre.Text + "','" + txt_consomation.Text + "'," + dt_date.Text + ",1)", CN);
                //    int a = -1;
                //    a = com3.ExecuteNonQuery();
                //    if (a != -1)
                //    {
                //        MessageBox.Show("Enregistrer");
                //    }
                //    else
                //    {
                //        MessageBox.Show("Erreur  !!");
                //    }
                //}
                //else
                //    MessageBox.Show("Remplire Les champs");


                if (txt_nom.Text != "" && txt_charge.Text != "" && txt_consomation.Text != "" && txt_etage.Text != "" && txt_superficier.Text != "" && txt_titre.Text != "" && comboBox1.Text != "" && cmb_imm.Text != "" && cmb_prop.Text != "" && dt_date.Text != "")
                {
                    Random r = new Random();
                    int j = r.Next(1000);

                    com2 = new SqlCommand("insert into bien values (" + j + ",'" + txt_nom.Text.ToString() + ",'" + txt_etage.Text.ToString() + ",'" + txt_superficier.Text.ToString() + ",'" + txt_charge.Text.ToString() + ",'" + txt_titre.Text.ToString() + "',(Select distinct id_type from type_bien where nom like '%" + comboBox1.Text + "%') '" + "',(Select distinct id_immeuble from immeuble where nom like '%" + cmb_imm.Text + "%', )" + "',(Select distinct id_proprietaire from proprietaire where (nom+' '+prenom) like '%" + cmb_prop.Text + "%' ) '" + ",'" + txt_consomation.Text + ",'" + dt_date.Text + " ,1)", CN);
                    int a = -1;
                    a = com2.ExecuteNonQuery();
                    if (a != -1)
                    {
                        MessageBox.Show("Added");
                    }
                    else
                    {
                        MessageBox.Show("not Added !!");
                    }
                }
                else
                    MessageBox.Show("Remplire Data");



            }
            else if (label8.Text == "Modifier")
            {
                com3 = null;
               
                DR.Close();
                com = null;
             
                int T = 0;
                com3 = new SqlCommand("Select distinct id_type from type_bien where nom like '%" + comboBox1.Text + "%'", CN);
                DR = com.ExecuteReader();
                DR.Read();
                T = int.Parse(DR[0].ToString());

                int I = 0;
                com3 = new SqlCommand("Select distinct id_immeuble from immeuble where nom like '%" + cmb_imm.Text + "%'", CN);
                DR = com.ExecuteReader();
                DR.Read();
                I = int.Parse(DR[0].ToString());

                int P = 0;
                com3 = new SqlCommand("Select id_proprietaire from Proprietaire where nom+' '+prenom like '%" + cmb_prop.Text + "%'", CN);
                DR = com.ExecuteReader();
                DR.Read();
                P = int.Parse(DR[0].ToString());

                int C = 0;
                com3 = new SqlCommand("Select id_conteurEau from conteurEau where consomation like '%" + txt_consomation.Text + "%'", CN);
                DR = com.ExecuteReader();
                DR.Read();
                C=int.Parse(DR[0].ToString());


                com3 = null;
                // dr.Close();
                DR.Close();
                com = null;
                //////
                com = new SqlCommand("update bien set nomAppartement = '" + txt_nom.Text + "',etage = '" + txt_etage.Text + "',syperficie = '" + txt_superficier.Text + "',charge = " + txt_charge + " ,id_immeuble = '" + I + "',id_type_bien = '" + T + "',id_propreitaire = " + P + "',titrefoncier = '" + txt_titre.Text + "',consomation = '" + txt_consomation.Text + "',date_controle = '" + dt_date.Text + " where id_bien = " + id, CN);
                int f = -1;
                f = com.ExecuteNonQuery();
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

