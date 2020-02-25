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
    public partial class FrmCongeEmploye : Form
    {
        BindingSource bsCon;
        SqlCommand cmd;
        public FrmCongeEmploye()
        {
            InitializeComponent();
        }

        private void remplirListe()
        {
            string sql = "select c.id_conge,e.prenom,e.nom,c.date_sortie as 'Date Début',c.date_entree as 'Date Fin' from conge_employe c inner join employe e on e.id_employe = c.id_employe where c.archive = 1";
            bsCon = Fonctions.remplirGrille(dt_grid, sql, "conge_employe");
        }

        private void FrmCongeEmploye_Load(object sender, EventArgs e)
        {
            remplirListe();
            dt_grid.Columns[0].Visible = false;
        }

        private void dt_grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dt_grid.Columns[e.ColumnIndex].Name == "Date Fin")
            {
                if (Convert.ToDateTime(e.Value) < DateTime.Now)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Red;
                }

                if ((Convert.ToDateTime(e.Value) > DateTime.Now) && (Convert.ToDateTime(e.Value) < DateTime.Now.AddDays(5)))
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Orange;
                }

                if (Convert.ToDateTime(e.Value) > DateTime.Now.AddDays(5))
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Green;
                }
            }
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_derniere":
                    bsCon.MoveLast();
                    break;
                case "btn_precedent":
                    bsCon.MovePrevious();
                    break;
                case "btn_suivant":
                    bsCon.MoveNext();
                    break;
                case "btn_premier":
                    bsCon.MoveFirst();
                    break;
            }
        }

        private void txt_chercher_TextChanged(object sender, EventArgs e)
        {
            if (txt_chercher.Text != "Tapez Nom Ou Prenom Pour Chercher")
            {
                string nom, prenom;
                string str = txt_chercher.Text.Replace("'", "''");
                if (txt_chercher.Text.IndexOf(' ') != -1)
                {
                    nom = str.Substring(0, str.IndexOf(' '));
                    prenom = str.Substring(str.IndexOf(' '), ((Convert.ToInt32(str.Length)) - str.IndexOf(' ')));
                }
                else
                {
                    nom = str;
                    prenom = str;
                }

                bsCon.Filter = " nom like '%" + nom + "%' or nom like '%" + prenom + "%' or prenom like '%" + nom + "%' or prenom like '%" + prenom + "%'";
            }
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Tapez Nom Ou Prenom Pour Chercher");
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Tapez Nom Ou Prenom Pour Chercher");
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_ajouter":
                    break;
                case "btn_modifier":
                    break;
                case "btn_supprimer":
                    if (dt_grid.Rows.Count > 0)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Voulez-vous Vraiment Supprimer Ce Document ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            cmd = new SqlCommand("update conge_employe set archive = 0 where id_conge = " + dt_grid.CurrentRow.Cells[0].Value, Fonctions.CnConnection());
                            cmd.ExecuteNonQuery();
                            remplirListe();
                        }
                    }
                    break;
            }
        }
    }
}
