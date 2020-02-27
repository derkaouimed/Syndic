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
    public partial class frm_recette_information : Form
    {
        string s = "";
        SqlDataReader dr;
        int id = 0;
        SqlDataReader dr2;
        SqlCommand com = new SqlCommand();
        SqlCommand com33 = new SqlCommand();
        SqlCommand com22 = new SqlCommand();
        SqlConnection cn = new SqlConnection();

        public frm_recette_information(String _S,int _id)
        {
            InitializeComponent();
            s = _S;
            id = _id;
            label8.Text = s;
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


        private void frm_recette_information_Load(object sender, EventArgs e)
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
                com22 = new SqlCommand("Select montant ,nomtype,t.id_type from recette r inner join type_recette t on t.id_type = r.id_type where id_recette = " + id, cn);

                dr2 = com22.ExecuteReader();
                while (dr2.Read())
                {
                    textBox1.Text = dr2[0].ToString();
                    comboBox1.Text = dr2[1].ToString();
                    comboBox1.ValueMember = dr[2].ToString();
                }

                dr2.Close();
                com22 = null;


              

            }
            else { 
                com = new SqlCommand("Select nomtype,id_type from type_recette",cn);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    //MessageBox.Show("hhhhh");
                    comboBox1.Items.Add(""+dr[0].ToString());
                    //comboBox1.ValueMember = dr[1].ToString();
                }
                com = null;
                dr.Close();
            }
            dr.Close();


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
        }
        SqlCommand com2 = new SqlCommand();
        //SqlDataReader dr2;
        private void btn_Recette_valider_Click(object sender, EventArgs e)
        {
            //hna erro hitax makaynaxi identity  >> autoIncrement  //
           
                if (label8.Text == "Ajouter")
                {
                    if (textBox1.Text != "" && comboBox1.Text != "")
                    {
                        Random r = new Random();
                        int j = r.Next(1000);

                        com2 = new SqlCommand("insert into recette values (" + j + ",'" + textBox1.Text.ToString() + "',(Select distinct id_type from type_recette where nomtype like '%" + comboBox1.Text + "%'),1)", cn);
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
                    com2 = null;
                    
                    }
                    else
                        MessageBox.Show("Remplire Data");

                }
                else
                {
                //dr.Close();

                //dr2.Close();
                try
                {

                    com33 = new SqlCommand("update recette set montant = '" + textBox1.Text.ToString() + "',id_type = (Select id_type from type_recette where nomtype like '" + comboBox1.Text.ToString() + "') where id_recette = " + id, cn);
                    int a = -1;
                    a = com33.ExecuteNonQuery();
                    if (a != -1)
                    {
                        MessageBox.Show("Updates Succesfully");
                    }
                    else
                        MessageBox.Show(" error Updates Succesfully");
                }
                catch {
                    return;
                }

                }
          
           






        }
        int move = 0;

        private void frm_recette_information_MouseMove(object sender, MouseEventArgs e)
        {
            SqlDataReader da1000;
            SqlCommand com1000 = new SqlCommand();
            com = null;
            move++;
            cn.Close();

            cn.Open();
            if (move <= 1)
            {
                com1000 = new SqlCommand("Select nomtype from type_recette", cn);
                da1000 = com1000.ExecuteReader();
                while (da1000.Read())
                {
                    //MessageBox.Show(""+dr[0].ToString());
                    comboBox1.Items.Add("" + da1000[0].ToString());
                    //comboBox1.ValueMember = dr[1].ToString();
                }
                com1000 = null;
                da1000.Close();


            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frm_Recette_type f = new frm_Recette_type("Modifier", id);
            f.ShowDialog();
        }
    }
}
