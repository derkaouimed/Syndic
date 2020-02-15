using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Syndic
{
    public partial class frm_recette_Document_info : Form
    {

        BindingSource bsProp = new BindingSource();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlConnection cn = new SqlConnection();
        SqlCommand com;
        SqlDataReader dr;
        SqlCommand com22;
        /// <summary>
        /// ///////////;;;;;;
        /// </summary>
        SqlDataReader dr2;

        string s;
        public frm_recette_Document_info(String _s)
        {
            InitializeComponent();
            s = _s;
            label8.Text = _s;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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

        private void frm_recette_Document_info_Load(object sender, EventArgs e)
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
                com22 = new SqlCommand("Select montant ,nomtype from recette r inner join type_recette t on t.id_type = r.id_type where id_recette = " + id, cn);

                dr2 = com22.ExecuteReader();
                while (dr2.Read())
                {
                    textBox1.Text = dr2[0].ToString();
                    comboBox1.Text = dr2[1].ToString();
                }

                dr2.Close();
                com22 = null;

            }
           
            com = new SqlCommand("Select nom from document_recette", cn);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                MessageBox.Show("hhhhh");
                comboBox1.Items.Add("" + dr[0].ToString());

            }
            com = null;
            dr.Close();





        }

        private void btn_RecetteDocument_valider_Click(object sender, EventArgs e)
        {

        }
    }
}
