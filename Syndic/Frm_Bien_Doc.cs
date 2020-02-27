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
        BindingSource bsBien;
    
        SqlCommand cmd;
        SqlDataReader dr;
   

        public Frm_Bien_Doc()
        {
            InitializeComponent();
        }
        private void remplirDoc()
        {
            if (lst_bien.Items.Count > 0)
            {
                int pos = 0;
                lst_document.Items.Clear();
                try
                { pos = Convert.ToInt32(lst_bien.SelectedValue); }
                catch { }

                cmd = new SqlCommand("select (id_document+' - '+ nom) as [idnom] from document_bien where archive = 1 and id_bien = " + pos, Fonctions.CnConnection());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lst_document.Items.Add(dr["idnom"].ToString());
                }
                dr.Close();
                dr = null;
            }



        }
        private int GetID()
        {
            string str = lst_document.Text;

            int id = Int32.Parse((str).Substring(0, str.IndexOf(' ')));

            return id;
        }



        private void Frm_Bien_Doc_Load(object sender, EventArgs e)
        {
            bsBien = Fonctions.remplirList(lst_bien, "bien", "NomApparetemnt", "id_bien");
            remplirDoc();
        }

        private void txt_chercher_Fact_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher_bien, "Tapez Designation Pour Chercher");
        }

        private void txt_chercher_Fact_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher_bien, "Tapez Designation Pour Chercher");
        }

        private void txt_chercher_doc_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher_doc, "Tapez ID Ou Nom De Document Pour Chercher");
        }

        private void txt_chercher_doc_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher_doc, "Tapez ID Ou Nom De Document Pour Chercher");
        }

       

        private void lst_bien_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirDoc();
        }

        private void lst_document_DoubleClick(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select fichier from document_bien where id_document = " + GetID(), Fonctions.CnConnection());
            string chemin = cmd.ExecuteScalar().ToString();

            Fonctions.OuvrirDocument(chemin);
        }

      

        private void txt_chercher_bien_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_chercher_bien.Text != "Tapez Designation Pour Chercher")
                bsBien.Filter = "NomApparetemnt like '%" + txt_chercher_bien.Text.Replace("'", "''") + "%'";
            else
                bsBien.Filter = "NomApparetemnt like '%%'";
        }

        private void txt_chercher_doc_TextChanged(object sender, EventArgs e)
        {
            if (txt_chercher_doc.Text != "Tapez ID Ou Nom De Document Pour Chercher")
            {
                if (lst_bien.Items.Count > 0)
                {
                    int pos = 0;
                    lst_document.Items.Clear();
                    try
                    { pos = Convert.ToInt32(lst_bien.SelectedValue); }
                    catch { }


                    string filt = txt_chercher_doc.Text.Replace("'", "''");
                    try
                    {
                        cmd = new SqlCommand("select (id_document+' - '+nom) as idnom from document_bien where archive = 1 and id_bien = " + pos + " and id_document = " + Convert.ToInt32(filt), Fonctions.CnConnection());
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            lst_document.Items.Add(dr["idnom"].ToString());
                        }
                        dr.Close();
                        dr = null;
                    }
                    catch
                    {
                        cmd = new SqlCommand("select (id_document+' - '+nom) as idnom from document_bien where archive = 1 and id_bien = " + pos + " and nom like '%" + filt + "%'", Fonctions.CnConnection());
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            lst_document.Items.Add(dr["idnom"].ToString());
                        }
                        dr.Close();
                        dr = null;
                    }

                }
            }
            else
            {
                remplirDoc();
            }
        }

        private void btn_suivant_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_premiere":
                    bsBien.MoveFirst();
                    break;
                case "btn_derniere":
                    bsBien.MoveLast();
                    break;
                case "btn_precedent":
                    bsBien.MovePrevious();
                    break;
                case "btn_suivant":
                    bsBien.MoveNext();
                    break;
            }
        }

        private void btn_ajouter_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_ajouter":
                    Frm_Bien_Document_aj f = new Frm_Bien_Document_aj(0,"Ajouter");
                    f.ShowDialog();
                    remplirDoc();
                    break;
                case "btn_modifier":
                    if (lst_document.SelectedIndex != -1)
                    {
                        FrmAMDocFacture fr = new FrmAMDocFacture(GetID(), "Modifier");
                        fr.ShowDialog();
                        remplirDoc();
                    }
                    else
                        MessageBox.Show("Selectionner Un Document S'il Vous Plait.", "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "btn_supprimer":
                    if (lst_document.Items.Count > 0)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Voulez-vous Vraiment Supprimer Ce Document ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            cmd = new SqlCommand("update document_bien set archive = 0 where id_document = " + GetID(), Fonctions.CnConnection());
                            cmd.ExecuteNonQuery();
                            remplirDoc();
                        }
                    }
                    break;
            }

        }
    }
}
