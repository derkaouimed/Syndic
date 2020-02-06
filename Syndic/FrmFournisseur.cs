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
        BindingSource bsFr = new BindingSource();
        public FrmFournisseur()
        {
            InitializeComponent();
        }

        private void activie(bool b)
        {
            pnl_details.Enabled = !b;
            pnl_lst.Enabled = b;
            btn_ajouter.Enabled = b;
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Rechercher Par Prenom Ou ICE");
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Rechercher Par Prenom Ou ICE");
        }

        private void FrmFournisseur_Load(object sender, EventArgs e)
        {
            string sql = "select *,concat(nom,' ',prenom) as nomComplet from fournisseur";
            bsFr = Fonctions.remplirList(lst_fournisseur, sql, "fournisseur", "nomComplet", "id_fournisseur");

            txt_ice.DataBindings.Add("Text", bsFr, "ice");
            txt_nom.DataBindings.Add("Text", bsFr, "nom");
            txt_prenom.DataBindings.Add("Text", bsFr, "prenom");
            txt_telephone.DataBindings.Add("Text", bsFr, "telephone");
            txt_email.DataBindings.Add("Text", bsFr, "email");

            activie(true);
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
                    break;
                case "Modifier":
                    activie(false);
                    btn_modifier.Text = "Valider";
                    btn_supprimer.Text = "Annuler";
                    break;
                case "Supprimer":
                    if (DialogResult.Yes == MessageBox.Show("Voulez-vous Vraiment Supprimer Ce Fournisseur ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        bsFr.RemoveCurrent();
                    break;
                case "Valider":
                    activie(true);
                    btn_modifier.Text = "Modifier";
                    btn_supprimer.Text = "Supprimer";
                    bsFr.EndEdit();
                    break;
                case "Annuler":
                    activie(true);
                    btn_modifier.Text = "Modifier";
                    btn_supprimer.Text = "Supprimer";
                    bsFr.CancelEdit();
                    break;
            }
        }
    }
}
