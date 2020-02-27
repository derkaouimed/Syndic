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
    public partial class Frm_utilisateur_type : Form
    {
        string s = "";
        int id = 0;
        SqlCommand com = new SqlCommand();
        SqlConnection CN = new SqlConnection();

        public Frm_utilisateur_type(string _s, int _id)
        {
            InitializeComponent();
            s = _s;
            id = _id;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ouvrirconnection()
        {
            if (CN.State != ConnectionState.Open)
            {
                CN.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                CN.Open();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }

        private void Frm_utilisateur_type_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Recette_valider_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Fonctions.ouvrireConnection();

                com = new SqlCommand("Insert into type_utilisateur values ('" + textBox1.Text + "',1)", CN);
                int a = -1;
                a = com.ExecuteNonQuery();
                if (a != -1)
                {
                    DialogResult d = MessageBox.Show("Enregistrer", "enregistrer", MessageBoxButtons.OK);
                    if (DialogResult.OK == d)
                        this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur  !!");
                }
            }
            else
            {
                MessageBox.Show("il faut entre le type !!!!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.Close();
        }

        private void Frm_utilisateur_type_Load(object sender, EventArgs e)
        {
            ouvrirconnection();

            if (CN.State != ConnectionState.Open)
                CN.Open();
            com = null;
        }
    }
}
