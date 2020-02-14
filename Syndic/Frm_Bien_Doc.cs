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
                case "btn_Bien_doc_Ajouter":
                    Frm_Bien_Document_aj ff = new Frm_Bien_Document_aj("Ajouter",0);
                    ff.ShowDialog();

                    break;
                case "btn_Bien_doc_modifier":
                    Frm_Bien_Document_aj f = new Frm_Bien_Document_aj("Modifier",int.Parse(grid_doc_bien.CurrentRow.Cells[0].ToString()));
                    f.ShowDialog();

                    break;
                case "btn_Bien_doc_Supprimer":
                    DialogResult d = MessageBox.Show("Supprerimer", "Voulez Vous Supprime ce document ?", MessageBoxButtons.OK);
                    if (DialogResult.OK == d)
                    {

                        SqlCommand com = new SqlCommand("Update document_bien set archive = 0 where id_document = " + int.Parse(grid_doc_bien.CurrentRow.Cells[0].Value.ToString()), CN);
                        int a = 0;
                        a = com.ExecuteNonQuery();
                        if (a != 0)
                        {
                            MessageBox.Show("Supprimer !!");

                            grid_doc_bien.Rows.RemoveAt(grid_doc_bien.CurrentRow.Index);

                        }

                        else
                            MessageBox.Show("Error de Supprimer !!");

                    }

                    break;



            }
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder com = new SqlCommandBuilder(AD);
            AD.Update(DS.Tables["document_bien"]);

            string f = txt_nomfich.Text == "" ? "" : "nom like '%" + txt_nomfich.Text + "%'";


            BSbien.Filter = f;
        }

        private void Frm_Bien_Doc_Load(object sender, EventArgs e)
        {
            ouvriConnectio();
            AD = new SqlDataAdapter("select nom,fichier , b.NomApparetemnt from document_bien d inner join bien b on b.id_bien=d.id_bien ", CN);
            if (!DS.Tables.Contains("document_bien"))

                AD.Fill(DS, "document_bien");

            BSbien.DataSource = DS;
            BSbien.DataMember = "document_bien";

            grid_doc_bien.DataSource = BSbien;
        }

        private void moveFirst_Click(object sender, EventArgs e)
        {
            BSbien.MoveFirst();
        }

        private void movePrecedent_Click(object sender, EventArgs e)
        {
            BSbien.MovePrevious();
        }

        private void MoveNext_Click(object sender, EventArgs e)
        {
            BSbien.MoveNext();
        }

        private void MoveLast_Click(object sender, EventArgs e)
        {
            BSbien.MoveLast();
        }

        private void grp_fichier_Enter(object sender, EventArgs e)
        {

        }
    }
}
