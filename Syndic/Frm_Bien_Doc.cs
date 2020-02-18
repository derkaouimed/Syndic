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

namespace Syndic
{
    public partial class Frm_Bien_Doc : Form
    {
        BindingSource BSbien = new BindingSource();
        SqlConnection CN = new SqlConnection();
        DataSet DS = new DataSet();
        SqlDataAdapter AD;
        public Frm_Bien_Doc()
        {
            InitializeComponent();
        }
        public void ouvriConnectio()
        {
            if (CN.State != ConnectionState.Open)
            {
                CN.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                CN.Open();
            }
        }

        private void btn_Bien_Supprimer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_Bien_Doc_Ajouter":
                    Frm_Bien_Document_aj ff = new Frm_Bien_Document_aj("Ajouter",0);
                    ff.ShowDialog();

                    break;
                case "btn_Bien_Doc_modifier":
                    Frm_Bien_Document_aj f = new Frm_Bien_Document_aj("Modifier", int.Parse(list_document.SelectedIndex.ToString()));
                    f.ShowDialog();

                    break;
                case "btn_Bien_Doc_Supprimer":
                    //DialogResult d = MessageBox.Show("Supprerimer", "Voulez Vous Supprime ce document ?", MessageBoxButtons.OK);
                    //if (DialogResult.OK == d)
                    //{

                    //    SqlCommand com = new SqlCommand("Update document_bien set archive = 0 where id_document = " + int.Parse(grid_doc_bien.CurrentRow.Cells[0].Value.ToString()), CN);
                    //    int a = 0;
                    //    a = com.ExecuteNonQuery();
                    //    if (a != 0)
                    //    {
                    //        MessageBox.Show("Supprimer !!");

                    //        grid_doc_bien.Rows.RemoveAt(grid_doc_bien.CurrentRow.Index);

                    //    }

                    //    else
                    //        MessageBox.Show("Error de Supprimer !!");

                    //}

                    break;



            }
        }

        private void Frm_Bien_Doc_Load(object sender, EventArgs e)
        {
            ouvriConnectio();
            AD = new SqlDataAdapter("select * from bien ", CN);
            if (!DS.Tables.Contains("bien"))

                AD.Fill(DS, "bien");

            BSbien.DataSource = DS;
            BSbien.DataMember = "bien";

            list_bien.DataSource = BSbien;
            list_bien.ValueMember = "id_bien";
            list_bien.DisplayMember = "NomApparetemnt";

        }

       

        private void grp_fichier_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder com = new SqlCommandBuilder(AD);
            AD.Update(DS.Tables["document"]);

            string f = txt_cherch_doc.Text == "Chercher Par Nom Bien " ? "" : "nom like '%" + txt_cherch_doc.Text + "%'";


            BSbien.Filter = f;
        }

        private void btn_premiere_Click(object sender, EventArgs e)
        {
            BSbien.MoveFirst();
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            BSbien.MovePrevious();
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            BSbien.MoveNext();
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            BSbien.MoveLast();
        }

        private void txt_chercher_bien_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher_bien, "Chercher Par Nom Bien");
        }

        private void txt_chercher_bien_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher_bien, "Chercher Par Nom Bien");
        }

        private void txt_cherch_doc_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_cherch_doc, "Chercher Nom document");
        }

        private void txt_cherch_doc_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_cherch_doc, "Chercher Nom document");
        }
    }
}
