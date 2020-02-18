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
        SqlDataReader DR1;
        SqlCommand comR = new SqlCommand();
        SqlDataReader DRR;
        SqlConnection CN = new SqlConnection();
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
            if (label5.Text == "Ajouter")
            {
                comR = new SqlCommand("select id_residence from residence where nom like '" + cmb_res.Text + "'", CN);
                DRR = comR.ExecuteReader();
                DRR.Read();
                int T = int.Parse(DRR[0].ToString());

                comR = null;
                DRR.Close();

                if(txt_nm.Text!="" && txt_tit.Text!="" && txt_pai.Text != "")
                {
                    com= new SqlCommand("insert into immeuble values('" + txt_nm.Text + "', '" + T + "' , '" + txt_tit.Text + "' , '"
                        + txt_pai.Text+ "' ,'1')", CN);
                    int a = -1;
                    a = com.ExecuteNonQuery();
                    if (a != -1)
                    {
                        MessageBox.Show("Enregistrer");
                    }
                    else
                    {
                        MessageBox.Show("Erreur  !!");
                    }

                }
                else
                    MessageBox.Show("Remplire Les champs");
            }
            else if (label5.Text == "Modifier")
            {
                com = null;

                DR1.Close();
                com1 = null;

                int T = 0;
                com = new SqlCommand("Select distinct id_residence from residence where nom like '%" + cmb_res.Text + "%'", CN);
                DR1 = com.ExecuteReader();
                DR1.Read();
                T = int.Parse(DR1[0].ToString());

                DR1.Close();
                com = null;
                //////
                com = new SqlCommand("update immeuble set nom = '" + txt_nm.Text + "',id_residence = '" + T + "',titrefoncier = '" + txt_tit.Text + "',paiment = '" + txt_pai + " where id_bien = " + id, CN);
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

        

        private void Frm_immeuble_aj_Load(object sender, EventArgs e)
        {
            ouvrirconnection();
            if (label5.Text == "Modifier")
            {
                if (CN.State != ConnectionState.Open)
                    CN.Open();
                com1 = new SqlCommand("select id_immeuble as [ID] , i.nom as [Nom immeuble],r.nom as [residence],i.titrefoncier as[titre foncier],i.paiment from immeuble i inner join residence r on r.id_residence=i.id_residence  whare id_immeuble = " + id, CN);
                DR1 = com1.ExecuteReader();

                DR1.Read();
                txt_nm.Text = DR1[1].ToString();
                cmb_res.Text = DR1[2].ToString();
                txt_tit.Text = DR1[3].ToString();
                txt_pai.Text = DR1[4].ToString();

                DR1.Close();
                com1 = null;
            }
            comR = new SqlCommand("Select nom from residence", CN);
            DRR = comR.ExecuteReader();
            while (DRR.Read())
            {
                cmb_res.Items.Add("" + DRR[0].ToString());

            }
            comR = null;
            DRR.Close();
        }

        private void btn_immeuble_Annuler_Click(object sender, EventArgs e)
        {
            if (label5.Text == "Ajouter")
            {
                txt_nm.Text = "";
                txt_pai.Text = "";
                txt_tit.Text = "";
                cmb_res.Text = "";
            }
            else
                this.Close();
        }
    }
}
