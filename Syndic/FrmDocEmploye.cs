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
    public partial class FrmDocEmploye : Form
    {
        BindingSource bsEmp;
        SqlCommand cmd;
        SqlDataReader dr;
        string chemin;
        public FrmDocEmploye()
        {
            InitializeComponent();
        }

        private void remplirDoc()
        {
            if (lst_employes.Items.Count > 0)
            {
                int pos = 0;
                lst_documents.Items.Clear();
                try
                { pos = Convert.ToInt32(lst_employes.SelectedValue); }
                catch { }

                cmd = new SqlCommand("select concat(id_document,' - ',nom) as idnom from document_employe where archive = 1 and id_employe = " + pos, Fonctions.CnConnection());
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
        private void FrmDocEmploye_Load(object sender, EventArgs e)
        {
            string sql = "select *,concat(nom,' ',prenom) as nomComplete from employe where archive = 1";
            bsEmp = Fonctions.remplirList(lst_employes, sql,"Employe", "nomComplete", "id_employe");
            remplirDoc();
        }

        private void lst_employes_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirDoc();
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_derniere":
                    bsEmp.MoveLast();
                    break;
                case "btn_precedent":
                    bsEmp.MovePrevious();
                    break;
                case "btn_suivant":
                    bsEmp.MoveNext();
                    break;
                case "btn_premiere":
                    bsEmp.MoveFirst();
                    break;
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_ajouter":
                    FrmAMDocEmploye f = new FrmAMDocEmploye("Ajouter");
                    f.ShowDialog();
                    remplirDoc();
                    break;
                case "btn_modifier":
                    if (lst_documents.SelectedIndex != -1)
                    {
                        FrmAMDocEmploye fr = new FrmAMDocEmploye(GetID(), "Modifier");
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
                                cmd = new SqlCommand("update document_employe set archive = 0 where id_document = " + GetID(), Fonctions.CnConnection());
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

        private void lst_documents_DoubleClick(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select fichier from document_employe where id_document = " + GetID(), Fonctions.CnConnection());
            string chemin = cmd.ExecuteScalar().ToString();

            Fonctions.OuvrirDocument(chemin);
        }

        private void txt_chercher_Emp_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher_Emp, "Tapez Nom Et Prenom Pour Chercher");
        }

        private void txt_chercher_Emp_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher_Emp, "Tapez Nom Et Prenom Pour Chercher");
        }

        private void txt_chercher_doc_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher_doc, "Tapez ID Ou Nom De Document Pour Chercher");
        }

        private void txt_chercher_doc_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher_doc, "Tapez ID Ou Nom De Document Pour Chercher");
        }

        private void txt_chercher_Emp_TextChanged(object sender, EventArgs e)
        {
            if (txt_chercher_Emp.Text != "Tapez Nom Et Prenom Pour Chercher")
            {
                string nom, prenom;
                string str = txt_chercher_Emp.Text.Replace("'", "''");
                if (txt_chercher_Emp.Text.IndexOf(' ') != -1)
                {
                    nom = str.Substring(0, str.IndexOf(' '));
                    prenom = str.Substring(str.IndexOf(' '), ((Convert.ToInt32(str.Length)) - str.IndexOf(' ')));
                }
                else
                {
                    nom = str;
                    prenom = str;
                }

                bsEmp.Filter = " nom like '%" + nom + "%' or nom like '%" + prenom + "%' or prenom like '%" + nom + "%' or prenom like '%" + prenom + "%'";
            }
        }

        private void txt_chercher_doc_TextChanged(object sender, EventArgs e)
        {
            if (txt_chercher_doc.Text != "Tapez ID Ou Nom De Document Pour Chercher")
            {
                if (lst_employes.Items.Count > 0)
                {
                    int pos = 0;
                    lst_documents.Items.Clear();
                    try
                    { pos = Convert.ToInt32(lst_employes.SelectedValue); }
                    catch { }


                    string filt = txt_chercher_doc.Text.Replace("'", "''");
                    try
                    {
                        cmd = new SqlCommand("select concat(id_document,' - ',nom) as idnom from document_employe where archive = 1 and id_employe = " + pos + " and id_document = " + Convert.ToInt32(filt), Fonctions.CnConnection());
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
                        cmd = new SqlCommand("select concat(id_document,' - ',nom) as idnom from document_employe where archive = 1 and id_employe = " + pos + " and nom like '%" + filt + "%'", Fonctions.CnConnection());
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
