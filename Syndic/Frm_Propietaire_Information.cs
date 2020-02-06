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
using System.Data.SqlClient;
using System.Configuration;

namespace Syndic
{
    public partial class Frm_Propietaire_Information : Form
    {
        int id;
        String s = "";
        SqlDataReader dr;
        SqlCommand com;
        SqlDataReader dr2;
        SqlCommand com2;
        SqlConnection cn = new SqlConnection();
        public Frm_Propietaire_Information(String _S,int id)
        {
            InitializeComponent();
            s = _S;
            label8.Text = s;
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Frm_Propietaire_Information_Load(object sender, EventArgs e)
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                cn.Open();
            }
            if (label8.Text == "Modifier")
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();

                com2 = new SqlCommand("Select nom_ville ,nom,prenom,adresse,code_postale,telephone,email,p.id_ville from ville v inner join proprietaire p on p.id_ville = v.id_ville where v.id_ville like (select p.id_ville from proprietaire where id_proprietaire = " + id + ") and id_proprietaire = " + id, cn);
                dr2 = com2.ExecuteReader();
                dr2.Read();

                comboBox1.Text = dr2[0].ToString();
                txtnom.Text = dr2[1].ToString();
                txtprenom.Text = dr2[2].ToString();
                txtAdrees.Text = dr2[3].ToString();
                txtCodePostal.Text = dr2[4].ToString();
                txtPhone.Text = dr2[5].ToString();
                txtEmail.Text = dr2[6].ToString();
                //
                //MessageBox.Show("hhhh");
            }
            com = new SqlCommand("Select * from ville",cn);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[1].ToString());
            }
            
            com = null;
           // dr.Close();

           
           

        }
      
        private void btn_Proprietaire_Valider_Click(object sender, EventArgs e)
        {
           

            if (label8.Text == "Ajouter")
            {
                com = null;
                dr.Close();
                com = new SqlCommand("select id_ville from ville where nom_ville like '" + comboBox1.Text + "'", cn);
                dr = com.ExecuteReader();
                dr.Read();
                int b = int.Parse(dr[0].ToString());

                if (txtnom.Text != "" && txtprenom.Text != "")
                {
                    com = null;
                    dr.Close();
                    com = new SqlCommand("insert into proprietaire values('" + txtnom.Text + "','" + txtprenom.Text + "','" + txtAdrees.Text + "','" + txtCodePostal.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "'," + b + ",1)", cn);
                    int a = -1;
                    a = com.ExecuteNonQuery();
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
                    MessageBox.Show("Remplire Les Donner");

            }
            else if (label8.Text=="Modifier")
            {
                com = null;
               // dr.Close();
                dr2.Close();
                com2 = null;

                com = new SqlCommand("update proprietaire set nom = '"+txtnom.Text+"',prenom = '"+txtprenom.Text+"',adresse = '"+txtAdrees.Text+"',code_postale = "+int.Parse(txtCodePostal.Text.ToString())+" ,telephone = '"+txtPhone.Text+"',email = '"+txtEmail.Text+"',id_ville = (Select id_ville from ville where nom_ville like '"+comboBox1.Text+ "') where id_proprietaire = "+id, cn);
                int f = -1;
                com.ExecuteReader();
                if (f != -1)
                {
                    MessageBox.Show("modified");
                }
                else
                {
                    MessageBox.Show("not modified !!");
                }


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtnom.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtCodePostal.Text = "";
            txtprenom.Text = "";
            txtAdrees.Text = "";
            comboBox1.Text = "";
        }
    }
}

