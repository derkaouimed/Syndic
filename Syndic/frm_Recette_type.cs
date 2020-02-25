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
    public partial class frm_Recette_type : Form
    {
        string s = "";
        int id = 0;
        //SqlDataReader dr;
        SqlCommand com = new SqlCommand();
        SqlConnection cn = new SqlConnection();
        public frm_Recette_type(string _s,int _id)
        {
            InitializeComponent();
            s = _s;
            id = _id;
        }

        private void button1_Click(object sender, EventArgs e)
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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void frm_Recette_type_Load(object sender, EventArgs e)
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                cn.Open();
            }
           
          
                if (cn.State != ConnectionState.Open)
                    cn.Open();
            com = null;
           // dr.Close();


        }

        private void btn_Recette_valider_Click(object sender, EventArgs e)
        {
            try
            {
                com = new SqlCommand("Insert into type_recette values ('" + textBox1.Text + "',1)", cn);
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
            catch {
                MessageBox.Show("Name Not valid");
                return;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void frm_Recette_type_FormClosing(object sender, FormClosingEventArgs e)
        {
            //frm_recette_information f = new frm_recette_information("Ajouter",id);
            //f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
