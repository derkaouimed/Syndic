﻿using System;
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
    public partial class frm_recette_remarque_info : Form
    {
        String s = "";
        int id = 0;


        BindingSource bsProp = new BindingSource();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlConnection cn = new SqlConnection();
        SqlCommand com;
        SqlDataReader dr;
        SqlCommand com22;
        SqlDataReader dr2;

        public frm_recette_remarque_info(string _s,int _id=0)
        {
            InitializeComponent();
            s = _s;
            id = _id;
            label8.Text = s;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_recette_remarque_info_Load(object sender, EventArgs e)
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
                com22 = new SqlCommand("Select nomRemarqur ,remarque,id_recette from remarque_recette where id_remarque = " + id, cn);

                dr2 = com22.ExecuteReader();
                while (dr2.Read())
                {
                    textBox1.Text = dr2[0].ToString();
                    comboBox1.Text = dr2[2].ToString();
                    textBox2.Text = dr2[1].ToString();
                }

                dr2.Close();
                com22 = null;
                dr.Close();

            }
        }
        int move = 0;
        private void frm_recette_remarque_info_MouseMove(object sender, MouseEventArgs e)
        {
            move++;
            if (move <= 1)
            {

                com = new SqlCommand("Select id_recette from recette where archive = 1", cn);
                dr = com.ExecuteReader();
                while (dr.Read())
                {

                    comboBox1.Items.Add("" + dr[0].ToString());

                }
                com = null;
                dr.Close();


            }
        }

        private void btn_RecetteDocument_valider_Click(object sender, EventArgs e)
        {
            if (label8.Text == "Ajouter")
            {
                if (textBox1.Text != "" && comboBox1.Text != "")
                {


                    com22 = new SqlCommand("insert into remarque_recette values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "'," + comboBox1.Text + ",1)", cn);
                    int a = -1;
                    a = com22.ExecuteNonQuery();
                    if (a != -1)
                    {
                        MessageBox.Show("Added");
                    }
                    else
                    {
                        MessageBox.Show("not Added !!");
                    }
                }
            }
            else {
                if (textBox1.Text.ToString() != "" && textBox2.Text.ToString() != "" && comboBox1.Text != "")
                {


                    com = new SqlCommand("update remarque_recette set nomRemarqur = '" + textBox1.Text.ToString() + "' , remarque = '" + textBox2.Text.ToString() + "' , id_recette = " + comboBox1.Text.ToString() + " where id_remarque = " + id, cn);
                    int a = -1;
                    a = com.ExecuteNonQuery();

                    if (a != -1)
                    {
                        MessageBox.Show("update Succesfully");
                    }
                    else
                    {
                        MessageBox.Show("Error update Succesfully");

                    }
                }
                else
                {
                    MessageBox.Show("remplire data");
                }











            }
        }

        private void btn_RecetteDocument_Annuler_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";

        }
    }
}
