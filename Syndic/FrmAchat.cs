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
    public partial class FrmAchat : Form
    {
        BindingSource bsAchat;
        string sql = "select a.id_article,a.id_facture,ar.designation as Article,f.designation as Facture,a.qteAchat as 'Quantite Achat',cast(a.prix as decimal(18,2)) as Prix, cast((a.prix * a.qteAchat) as decimal(18,2)) as 'Total' from achat a inner join article ar on ar.id_article=a.id_article inner join facture f on f.id_facture=a.id_facture where a.archive = 1";
        public FrmAchat()
        {
            InitializeComponent();
        }

        private void Refresh_Grille()
        {
            bsAchat = Fonctions.remplirGrille(dt_grid, sql, "achat");
        }
        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Tapez Un Article Ou Facture Pour Rechercher");
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Tapez Un Article Ou Facture Pour Rechercher");
        }

        private void FrmAchat_Load(object sender, EventArgs e)
        {
            bsAchat = Fonctions.remplirGrille(dt_grid, sql,"achat");

            dt_grid.Columns[0].Visible = false;
            dt_grid.Columns[1].Visible = false;
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_derniere":
                    bsAchat.MoveLast();
                    break;
                case "btn_premier":
                    bsAchat.MoveFirst();
                    break;
                case "btn_suivant":
                    bsAchat.MoveNext();
                    break;
                case "btn_precedent":
                    bsAchat.MovePrevious();
                    break;
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_ajouter":
                    FrmAMAchat f = new FrmAMAchat("Ajouter Achat");
                    f.ShowDialog();
                    Refresh_Grille();
                    break;
                case "btn_modifier":
                    FrmAMAchat f1 = new FrmAMAchat("Modifier Achat", int.Parse(dt_grid.CurrentRow.Cells[0].Value.ToString()), int.Parse(dt_grid.CurrentRow.Cells[1].Value.ToString()));
                    f1.ShowDialog();
                    Refresh_Grille();
                    break;
                case "btn_supprimer":
                    if (dt_grid.Rows.Count > 0)
                        if (DialogResult.Yes == MessageBox.Show("Voulez-vous Vraiment Supprimer Cette Achat ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            SqlCommand cmd = new SqlCommand("update achat set archive = 0 where (id_article = " + int.Parse(dt_grid.CurrentRow.Cells[0].Value.ToString()) + " and id_facture = " + int.Parse(dt_grid.CurrentRow.Cells[1].Value.ToString()) + ")", Fonctions.CnConnection());
                            cmd.ExecuteNonQuery();
                            Refresh_Grille();
                        }
                    break;
            }
        }

        private void btn_chercher_Click(object sender, EventArgs e)
        {
            if (txt_chercher.Text != "Tapez Un Article Ou Facture Pour Rechercher")
                bsAchat.Filter = " Article like '%" + txt_chercher.Text + "%' or Facture like '%" + txt_chercher.Text + "%'";
            else
                bsAchat.Filter = "";
        }
    }
}
