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
    public partial class FrmFournisseur : Form
    {
        BindingSource bsFr;
        BindingSource bsAr;
        SqlCommand cmd;
        bool ajt = false;
        int ice;
        public FrmFournisseur()
        {
            InitializeComponent();
        }

        private void lstArticleAchat()
        {
            if (lst_fournisseur.Items.Count > 0 && txt_ice.Text != "")
            {
                string sql = "select a.id_article,CONCAT(a.designation,' - ',a.qtestock) as Libelle,a.archive from article a inner join achat c on c.id_article = a.id_article inner join facture f on f.id_facture = c.id_facture inner join fournisseur r on r.id_fournisseur = f.id_fournisseur where r.ice = " + txt_ice.Text + " and a.archive = 1";
                bsAr = Fonctions.remplirList(lst_article, sql, "articleAchat", "Libelle", "a.id_article");
            }
        }

        private void activie(bool b)
        {
            pnl_details.Enabled = !b;
            pnl_lst.Enabled = b;
            btn_ajouter.Enabled = b;
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Chercher Par Nom && Prenom Ou ICE");
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Chercher Par Nom && Prenom Ou ICE");
        }

        private void remplir_lstFR()
        {
            string sql = "select *,concat(nom,' ',prenom) as nomComplet from fournisseur where archive = 1";
            bsFr = Fonctions.remplirList(lst_fournisseur, sql, "fournisseur", "nomComplet", "id_fournisseur");

            txt_ice.DataBindings.Clear();
            txt_nom.DataBindings.Clear();
            txt_prenom.DataBindings.Clear();
            txt_telephone.DataBindings.Clear();
            txt_email.DataBindings.Clear();

            txt_ice.DataBindings.Add("Text", bsFr, "ice");
            txt_nom.DataBindings.Add("Text", bsFr, "nom");
            txt_prenom.DataBindings.Add("Text", bsFr, "prenom");
            txt_telephone.DataBindings.Add("Text", bsFr, "telephone");
            txt_email.DataBindings.Add("Text", bsFr, "email");
        }
        private void FrmFournisseur_Load(object sender, EventArgs e)
        {
            remplir_lstFR();
            
            activie(true);
            lstArticleAchat();
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_derniere":
                    bsFr.MoveLast();
                    break;
                case "btn_premiere":
                    bsFr.MoveFirst();
                    break;
                case "btn_suivant":
                    bsFr.MoveNext();
                    break;
                case "btn_precedent":
                    bsFr.MovePrevious();
                    break;
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "Ajouter":
                    activie(false);
                    btn_modifier.Text = "Valider";
                    btn_supprimer.Text = "Annuler";
                    bsFr.AddNew();
                    ajt = true;
                    break;
                case "Modifier":
                    activie(false);
                    btn_modifier.Text = "Valider";
                    btn_supprimer.Text = "Annuler";
                    ice = int.Parse(txt_ice.Text);
                    break;
                case "Supprimer":
                    if (DialogResult.Yes == MessageBox.Show("Voulez-vous Vraiment Supprimer Ce Fournisseur ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        cmd = new SqlCommand("update fournisseur set archive = 0 where ice = " + txt_ice.Text, Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        remplir_lstFR();
                    }
                    break;
                case "Valider":
                    if (txt_ice.Text.Equals("") || txt_nom.Text.Equals("") || txt_prenom.Text.Equals("") || txt_telephone.Text.Equals("") || txt_email.Text.Equals(""))
                        MessageBox.Show("Remplier Tous Les Informations S'il Vous Plait.", "Remplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        if (ajt)
                        {
                            cmd = new SqlCommand("insert into fournisseur values ('" + txt_nom.Text + "','" + txt_prenom.Text + "','" + txt_telephone.Text + "','" + txt_email.Text + "'," + int.Parse(txt_ice.Text) + ",1)", Fonctions.CnConnection());
                            cmd.ExecuteNonQuery();
                            lst_fournisseur.SelectedIndex = lst_fournisseur.Items.Count - 1;
                        }
                        else
                        {
                            int pos = lst_fournisseur.SelectedIndex;
                            cmd = new SqlCommand("update fournisseur set nom = '" + txt_nom.Text + "', prenom = '" + txt_prenom.Text + "', telephone = '" + txt_telephone.Text + "', email = '" + txt_email.Text + "', ice = " + txt_ice.Text + " where ice = " + ice + "", Fonctions.CnConnection());
                            cmd.ExecuteNonQuery();
                            lst_fournisseur.SelectedIndex = pos;
                        }
                        activie(true);
                        btn_modifier.Text = "Modifier";
                        btn_supprimer.Text = "Supprimer";
                        remplir_lstFR();
                    }
                    break;
                case "Annuler":
                    activie(true);
                    btn_modifier.Text = "Modifier";
                    btn_supprimer.Text = "Supprimer";
                    bsFr.CancelEdit();
                    break;
            }
        }

        private void lst_fournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstArticleAchat();
        }

        private void txt_chercher_TextChanged(object sender, EventArgs e)
        {
            if (txt_chercher.Text == "Chercher Par Nom && Prenom Ou ICE")
                bsFr.Filter = "";
            else
            {
                try
                {
                    int ice = Convert.ToInt32(txt_chercher.Text);
                    bsFr.Filter = " ice = " + ice;
                }
                catch
                {
                    bsFr.Filter = " nom like '%" + txt_chercher.Text.Replace("'","''") + "%' or prenom like '%" + txt_chercher.Text.Replace("'", "''") + "%'";
                }
            }
        }
    }
}
