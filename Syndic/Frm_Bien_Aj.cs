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
        SqlDataReader DR2;
        SqlCommand com = new SqlCommand();
        SqlCommand com2 = new SqlCommand();
        SqlCommand com3 = new SqlCommand();
        SqlConnection CN = new SqlConnection();
        string s = "";
        int id = 0;
        public Frm_Bien_Aj(String _S, int _id)
        {
            InitializeComponent();
            s = _S;
            id = _id;
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
            //this.Hide();
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
                com = new SqlCommand("select id_bien,NomApparetemnt,etage,superficie,charges,b.titrefoncier , t.nom,c.consomation,c.date_controle from bien B inner join type_bien t on t.id_type=b.id_type_bien inner join conteur_eau c on c.id_conteurEau=b.id_conteurEau where id_bien=" + id, CN);

                DR = com.ExecuteReader();
                comboBox1.Items.Clear();
                while (DR.Read())
                {
                    txt_nom.Text = DR[1].ToString();
                    txt_etage.Text = DR[2].ToString();
                    txt_superficier.Text = DR[3].ToString();
                    txt_charge.Text = DR[4].ToString();
                    txt_titre.Text = DR[5].ToString();
                    comboBox1.Text = DR[6].ToString();
                    txt_consomation.Text = DR[7].ToString();
                    dt_date.Text = DR[8].ToString();

                }

                DR.Close();
                com = null;

            }

            com2 = new SqlCommand("Select nom from type_bien", CN);
            DR2 = com2.ExecuteReader();
            while (DR2.Read())
            {
                comboBox1.Items.Add("" + DR2[0].ToString());

            }
            com2 = null;
            DR2.Close();

        }

        private void btn_Recette_valider_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text != "" && txt_charge.Text != "" && txt_consomation.Text != "" && txt_etage.Text != "" && txt_superficier.Text != "" && comboBox1.Text != "" && dt_date.Text!="")
            {
                Random r = new Random();
                int j = r.Next(1000);

                com3 = new SqlCommand("insert into bien values (" + j + ",'" + txt_nom.Text.ToString() + ",'" +txt_etage.Text.ToString() +",'"+txt_superficier.Text.ToString() +",'"+txt_charge.Text.ToString() +",'"+txt_titre.Text.ToString()+ ",'" + txt_consomation.Text.ToString() + ",'" + dt_date.Text.ToString()+ "',(Select distinct id_type from type_bien where nom like '%" + comboBox1.Text + "%'))" , CN);
                int a = -1;
                a = com3.ExecuteNonQuery();
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
    }
    }

