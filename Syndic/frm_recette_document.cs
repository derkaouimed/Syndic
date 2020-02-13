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
    public partial class frm_recette_document : Form
    {
        BindingSource bsProp = new BindingSource();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlConnection cn = new SqlConnection();
        public frm_recette_document()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_RecetteDocument_Ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_RecetteDocument_Ajouter":
                    frm_recette_Document_info ff = new frm_recette_Document_info();
                    ff.ShowDialog();
                    
                    break;
                case "btn_RecetteDocument_modifier":
                    frm_recette_Document_info f = new frm_recette_Document_info();
                    f.ShowDialog();

                    break;
                case "btn_RecetteDocument_Supprimer":

                    break;
           
                 

            }
        }
      
        private void frm_recette_document_Load(object sender, EventArgs e)
        {
            txt_search = MyHint.LoadText(txt_search, "Nom de Document");
            ////////////

            ds.Tables.Clear();
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                cn.Open();
            }
            da = new SqlDataAdapter("Select id_document as [NumDoc],nomDocument as Nom,ficher as Fichier,d.id_recette as Recette from document_recette d inner join recette r on d.id_recette = r.id_recette where d.archive = 1", cn);
            if (!ds.Tables.Contains("document"))

                da.Fill(ds, "document");

            bsProp.DataSource = ds;
            bsProp.DataMember = "document";

            dataGridView1.DataSource = bsProp;








        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            txt_search = MyHint.HintLeave(txt_search, "Nom de Document");
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search = MyHint.HintEnter(txt_search, "Nom de Document");
        }

        private void btn_Recette_Annuler_Click(object sender, EventArgs e)
        {
            bsProp.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bsProp.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bsProp.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bsProp.MoveLast();
        }
        SqlCommandBuilder commande;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_search.Text.Equals("Taper Nom de Document pour rechercher") || txt_search.Text == "")
            {
                commande = new SqlCommandBuilder(da);
                da.Update(ds.Tables["document"]);
                bsProp.DataSource = ds;
                bsProp.DataMember = "document";
                dataGridView1.DataSource = bsProp;

            }
            else
            {
                String se = txt_search.Text.Replace("'", " ");
                if (txt_search.Text.Equals("Taper Nom de Document pour rechercher"))
                {
                    bsProp.DataSource = ds;
                    bsProp.DataMember = "document";
                    dataGridView1.DataSource = bsProp;

                }
                else
                {
                    bsProp.Filter = "nom like '%" + se + "%'";

                }
            }
        }
    }
}
