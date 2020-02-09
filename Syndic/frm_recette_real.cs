﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic
{
    public partial class frm_recette_real : Form
    {

        BindingSource bsProp = new BindingSource();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlConnection cn = new SqlConnection();


        public frm_recette_real()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void LesButton(bool b) {
            btn_Recette_Ajouter.Visible = b;
            btn_Recette_modifier.Visible = b;
            btn_Recette_Supprimer.Visible = b;
           
        }
        private void btn_Recette_Ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_Recette_Ajouter":
                    frm_recette_information f = new frm_recette_information();
                    f.ShowDialog();

                    //LesButton(false);
                    break;
                case "btn_Recette_modifier":
                    frm_recette_information ff = new frm_recette_information();
                    ff.ShowDialog();
                    //LesButton(false);
                    break;
                case "btn_Recette_Supprimer":
                    DialogResult d = MessageBox.Show("Suppresion", "Voules Vous Supprime Ce Propietaire ?", MessageBoxButtons.OK);
                    if (DialogResult.OK == d)
                    {
                        /////
                    }
                    //LesButton(false);
                    break;

            }
        }

        private void frm_recette_real_Load(object sender, EventArgs e)
        {
            //LesButton(true);
            txt_search = MyHint.LoadText(txt_search, "Le Montant de Recette");
            ds.Tables.Clear();
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                cn.Open();
            }
            da = new SqlDataAdapter("Select id_recette as [NumRecette],montant as Montant,t.nomtype as Type from recette r inner join type_recette t on t.id_type = r.id_type where r.archive = 1", cn);
            if (!ds.Tables.Contains("recette"))
                
             da.Fill(ds,"recette");

            bsProp.DataSource = ds;
            bsProp.DataMember = "recette";

            dataGridView1.DataSource = bsProp;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            txt_search = MyHint.HintLeave(txt_search,"Le Montant de Recette");
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search = MyHint.HintEnter(txt_search, "Le Montant de Recette");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder com = new SqlCommandBuilder(da);
            da.Update(ds.Tables["recette"]);

            //string s = "";
            //if(dataGridView1.RowCount >= 0)
            //    s = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (txt_search.Text.Equals("Taper Le Montant de Recette pour rechercher") /*&& txt_search.Text == "" && s == ""*/)
            {
                bsProp.DataSource = ds;
                bsProp.DataMember = "recette";
                dataGridView1.DataSource = bsProp;
            }
            else
            {
                String se = txt_search.Text.Replace("'", " ");
                if (txt_search.Text.Equals("Taper Le Montant de Recette pour rechercher"))
                {
                    bsProp.DataSource = ds;
                    bsProp.DataMember = "recette";
                    dataGridView1.DataSource = bsProp;

                }
                else
                {
                    bsProp.Filter = "montant = " + se + "";

                }
            }

        }
    }
}
