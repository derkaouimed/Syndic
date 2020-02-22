using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic
{
    public partial class frm_cotisation_information : Form
    {
        string s = "";
        int id = 0;

        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlCommand com2 = new SqlCommand();
        SqlDataReader dr2;
        SqlCommand com22 = new SqlCommand();
        SqlConnection cn = new SqlConnection();

        public frm_cotisation_information(string _s,int _id=0)
        {

            InitializeComponent();

            s = _s;

            id = _id;

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_cotisation_information_Load(object sender, EventArgs e)
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

                


            }
            //remplire proprietaire
                com2 = new SqlCommand("Select * from proprietaire where archive = 1",cn);
                dr = com2.ExecuteReader();
                while (dr.Read())
                {
                    cmb_proprietaire.Items.Add(dr[2].ToString());


                }
            dr.Close();
            //remplire type
            com22 = new SqlCommand("Select * from type_cotisation",cn);
            dr2 = com22.ExecuteReader();
            while (dr2.Read())
            {
                cmb_type.Items.Add(dr[1].ToString());

            }



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

        private void btn_Proprietaire_Valider_Click(object sender, EventArgs e)
        {
            if (label8.Text == "Ajouter")
            {
                if (txtMontant.Text != "" || cmb_proprietaire.Text != "" || cmb_type.Text != "")
                {
                    com = new SqlCommand("insert into cotisation values('" + dateTimePicker1.Value.ToShortDateString() + "'," + txtMontant.Text + "," + cmb_proprietaire.ValueMember + "," + cmb_proprietaire.ValueMember + ");", cn);
                    int a = -1;
                    a = com.ExecuteNonQuery();
                    if (a != -1)
                    {
                        MessageBox.Show("Insertion Success !");
                    }
                    else
                        MessageBox.Show("Echec Dans Insertion !");
                }
                else
                    MessageBox.Show("Remplire Les Donner");
            }
            else {


            }
           
            
         }
    }
}
