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
    public partial class FrmContratEmp : Form
    {
        BindingSource bsCon;
        public FrmContratEmp()
        {
            InitializeComponent();
        }

        private void remplirGrille()
        {
            string sql = "select c.id_contrat,c.id_employe,e.nom,e.prenom,c.date_debut as 'Date Début',c.date_fin as 'Date Fin',cast(c.salaire as decimal(18,2)) as Salaire from contrat c inner join employe e on e.id_employe = c.id_employe where c.archive = 1";
            bsCon = Fonctions.remplirGrille(dt_grid, sql, "contrat");
        }
        private void FrmContratEmp_Load(object sender, EventArgs e)
        {
            remplirGrille();

            dt_grid.Columns[0].Visible = false;
            dt_grid.Columns[1].Visible = false;
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

        private void dt_grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for(int i = 0; i < dt_grid.Rows.Count; i++)
            {
                if (Convert.ToDateTime(dt_grid.Rows[i].Cells[5].Value) < DateTime.Now)
                {
                    dt_grid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dt_grid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    if (Convert.ToDateTime(dt_grid.Rows[i].Cells[5].Value) < DateTime.Now.AddMonths(1))
                    {
                        dt_grid.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                        dt_grid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        dt_grid.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        dt_grid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_ajouter":
                    FrmAMContract f = new FrmAMContract("Ajouter");
                    f.ShowDialog();
                    remplirGrille();
                    break;
                case "btn_modifier":
                    int pos;
                    if (dt_grid.Rows.Count > 0)
                    {
                        pos = dt_grid.CurrentRow.Index;
                        FrmAMContract fr = new FrmAMContract(Convert.ToInt32(dt_grid.CurrentRow.Cells[1].Value), Convert.ToInt32(dt_grid.CurrentRow.Cells[0].Value), "Modifier");
                        fr.ShowDialog();
                        remplirGrille();
                        dt_grid.Rows[pos].Cells[2].Selected = true;
                    }
                    else
                        MessageBox.Show("Acun Contract Pour Modifier.", "Aucun", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "btn_supprimer":
                    if (dt_grid.Rows.Count > 0)
                    {
                        pos = dt_grid.CurrentRow.Index;
                        if (DialogResult.Yes == MessageBox.Show("Voulez-vous Vraiment Supprimer Cette Contract ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            SqlCommand cmd = new SqlCommand("update contrat set archive = 0 where id_contrat = " + dt_grid.CurrentRow.Cells[0].Value, Fonctions.CnConnection());
                            cmd.ExecuteNonQuery();
                            remplirGrille();
                        }
                        if (pos != 0)
                            dt_grid.Rows[pos - 1].Cells[2].Selected = true;
                    }
                    else
                        MessageBox.Show("Acun Contract Pour Supprimer.", "Aucun", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
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

        private void txt_chercher_TextChanged(object sender, EventArgs e)
        {
            if(txt_chercher.Text!= "Tapez Nom Ou Prenom Pour Chercher")
            {
                string str = txt_chercher.Text.Replace("'", "''");
                string nom = "", prenom = " ";
                if (str.IndexOf(' ') != -1)
                {
                    nom = str.Substring(0, str.IndexOf(' '));
                    prenom = str.Substring(str.IndexOf(' '), (str.Length - str.IndexOf(' ')));
                }
                else
                    nom = str;

                bsCon.Filter = " nom like '%" + nom + "%' or nom like '%" + prenom + "%' or prenom like '%" + nom + "%' or prenom like '%" + prenom + "%'";
            }
        }

        private void btn_imrimerTous_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_imrimerTous":
                    RptContractEmp r = new RptContractEmp();
                    r.SetDatabaseLogon("sa", "123456");
                    Imprimer imprimer = new Imprimer(r);
                    imprimer.ShowDialog();
                    break;
                case "btn_imprimer":
                    RptContractEmp r1 = new RptContractEmp();
                    r1.SetDatabaseLogon("sa", "123456");
                    string filter1 = "{contrat.id_contrat} = " + dt_grid.CurrentRow.Cells[0].Value;
                    Imprimer imprimer1 = new Imprimer(r1,filter1);
                    imprimer1.ShowDialog();
                    break;
            }
        }
    }
}
