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

namespace Syndic
{
    public partial class FrmDocFacture : Form
    {
        BindingSource bsFact;
        SqlCommand cmd;
        SqlDataReader dr;
        public FrmDocFacture()
        {
            InitializeComponent();
        }

        private void remplirDoc()
        {
            if (lst_factures.Items.Count > 0)
            {
                int pos=0;
                lst_documents.Items.Clear();
                try
                { pos = Convert.ToInt32(lst_factures.SelectedValue);}catch { }
                
                cmd = new SqlCommand("select concat(id_document,' - ',nom) as idnom from document_facture where archive = 1 and id_facture = " + pos, Fonctions.CnConnection());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lst_documents.Items.Add(dr["idnom"].ToString());
                }
                dr.Close();
                dr = null;
            }
        }

        private int GetID()
        {
            string str = lst_documents.Text;

            int id = Int32.Parse((str).Substring(0, str.IndexOf(' ')));

            return id;
        }
        private void FrmDocFacture_Load(object sender, EventArgs e)
        {
            bsFact = Fonctions.remplirList(lst_factures, "Facture", "designation", "id_facture");
            remplirDoc();
        }

        private void txt_chercher_Fact_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher_Fact, "Tapez Designation Pour Chercher");
        }

        private void txt_chercher_Fact_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher_Fact, "Tapez Designation Pour Chercher");
        }

        private void txt_chercher_doc_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher_doc, "Tapez ID Ou Nom De Document Pour Chercher");
        }

        private void txt_chercher_doc_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher_doc, "Tapez ID Ou Nom De Document Pour Chercher");
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_premiere":
                    bsFact.MoveFirst();
                    break;
                case "btn_derniere":
                    bsFact.MoveLast();
                    break;
                case "btn_precedent":
                    bsFact.MovePrevious();
                    break;
                case "btn_suivant":
                    bsFact.MoveNext();
                    break;
            }
        }

        private void lst_factures_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirDoc();
        }

        private void lst_documents_DoubleClick(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("select fichier from document_facture where id_document = " + GetID(), Fonctions.CnConnection());
            string chemin = cmd.ExecuteScalar().ToString();

            Fonctions.OuvrirDocument(chemin);
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_ajouter":
                    FrmAMDocFacture f = new FrmAMDocFacture("Ajouter");
                    f.ShowDialog();
                    remplirDoc();
                    break;
                case "btn_modifier":
                    if (lst_documents.SelectedIndex != -1)
                    {
                        FrmAMDocFacture fr = new FrmAMDocFacture(GetID(), "Modifier");
                        fr.ShowDialog();
                        remplirDoc();
                    }
                    else
                        MessageBox.Show("Selectionner Un Document S'il Vous Plait.", "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "btn_supprimer":
                    if (lst_documents.SelectedIndex != -1)
                    {
                        if (lst_documents.Items.Count > 0)
                        {
                            if (DialogResult.Yes == MessageBox.Show("Voulez-vous Vraiment Supprimer Ce Document ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                cmd = new SqlCommand("update document_facture set archive = 0 where id_document = " + GetID(), Fonctions.CnConnection());
                                cmd.ExecuteNonQuery();
                                remplirDoc();
                            }
                        }
                    }
                    else
                        MessageBox.Show("Selectionner Un Document S'il Vous Plait.", "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void txt_chercher_Fact_TextChanged(object sender, EventArgs e)
        {
            if (txt_chercher_Fact.Text != "Tapez Designation Pour Chercher")
                bsFact.Filter = "designation like '%" + txt_chercher_Fact.Text.Replace("'", "''") + "%'";
            else
                bsFact.Filter = "designation like '%%'";
        }

        private void txt_chercher_doc_TextChanged(object sender, EventArgs e)
        {
            if (txt_chercher_doc.Text != "Tapez ID Ou Nom De Document Pour Chercher")
            {
                if (lst_factures.Items.Count > 0)
                {
                    int pos = 0;
                    lst_documents.Items.Clear();
                    try
                    { pos = Convert.ToInt32(lst_factures.SelectedValue); }
                    catch { }


                    string filt = txt_chercher_doc.Text.Replace("'", "''");
                    try
                    {
                        cmd = new SqlCommand("select concat(id_document,' - ',nom) as idnom from document_facture where archive = 1 and id_facture = " + pos + " and id_document = " + Convert.ToInt32(filt), Fonctions.CnConnection());
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            lst_documents.Items.Add(dr["idnom"].ToString());
                        }
                        dr.Close();
                        dr = null;
                    }
                    catch
                    {
                        cmd = new SqlCommand("select concat(id_document,' - ',nom) as idnom from document_facture where archive = 1 and id_facture = " + pos + " and nom like '%" + filt + "%'", Fonctions.CnConnection());
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            lst_documents.Items.Add(dr["idnom"].ToString());
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
    }
}
