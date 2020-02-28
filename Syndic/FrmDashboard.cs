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
    public partial class FrmDashboard : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select count(id_employe) from employe where archive = 1", Fonctions.CnConnection());
            lbl_count_emps.Text = cmd.ExecuteScalar().ToString();

            cmd = new SqlCommand("select count(id_fournisseur) from fournisseur where archive = 1", Fonctions.CnConnection());
            lbl_count_four.Text = cmd.ExecuteScalar().ToString();

            cmd = new SqlCommand("select count(id_bien) from bien where archive = 1", Fonctions.CnConnection());
            lbl_count_bien.Text = cmd.ExecuteScalar().ToString();

            cmd = new SqlCommand("select count(id_immeuble) from immeuble where archive = 1", Fonctions.CnConnection());
            lbl_count_immeuble.Text = cmd.ExecuteScalar().ToString();

            cmd = new SqlCommand("select sum(montant) from recette where archive = 1", Fonctions.CnConnection());
            int somme = Convert.ToInt32(cmd.ExecuteScalar());
            cmd = new SqlCommand("select sum(montant) from cotisation where archive = 1", Fonctions.CnConnection());
            lbl_somme_revenus.Text = (somme + Convert.ToInt32(cmd.ExecuteScalar())).ToString();

            cmd = new SqlCommand("select cast(sum(montant) as decimal(18,2)) from facture where archive = 1", Fonctions.CnConnection());
            lbl_somme_depenses.Text = cmd.ExecuteScalar().ToString();
        }
    }
}
