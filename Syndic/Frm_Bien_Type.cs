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
    public partial class Frm_Bien_Type : Form
    {
        string s = "";
        int id = 0;
        SqlCommand com = new SqlCommand();
        SqlConnection CN = new SqlConnection();
        public Frm_Bien_Type(string _s, int _id)
        {
            InitializeComponent();
            s = _s;
            id = _id;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Bien_Type_Load(object sender, EventArgs e)
        {
            ouvrirconnection();

            if (CN.State != ConnectionState.Open)
                CN.Open();
            com = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Frm_Bien_Aj ff = new Frm_Bien_Aj("Modifier", id);
            ff.ShowDialog();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }

        private void Frm_Bien_Type_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Frm_Bien_Aj f = new Frm_Bien_Aj("Modifier", id);
            //f.ShowDialog();
        }

        private void btn_Recette_valider_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                com = new SqlCommand("Insert into type_bien values ('" + textBox1.Text + "',1)", CN);
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
            {
                MessageBox.Show("if faut entre le nom !!!!!");
            }
           
        }
    }
}
