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
        BindingSource bsAchat = new BindingSource();
        public FrmAchat()
        {
            InitializeComponent();
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
            string sql = "select a.id_article,a.id_facture,ar.designation as Article,f.designation as Facture,a.qteAchat as 'Quantite En Stock',a.prix as Prix from achat a inner join article ar on ar.id_article=a.id_article inner join facture f on f.id_facture=a.id_facture where a.archive = 1";
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
    }
}
