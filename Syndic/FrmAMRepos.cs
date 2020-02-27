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
    public partial class FrmAMRepos : Form
    {
        BindingSource bsEmp;
        SqlCommand cmd;
        SqlDataReader dr;
        string frm;
        int idrep, idemp;
        public FrmAMRepos(string frm = "")
        {
            InitializeComponent();
            this.frm = frm;
        }

        public FrmAMRepos(int idrep, int idemp, string frm = "")
        {
            InitializeComponent();
            this.frm = frm;
            this.idrep = idrep;
            this.idemp = idemp;
        }

        private void activier(bool b)
        {
            pnl_ajouter.Visible = b;
            pnl_modifier.Visible = !b;
        }

        private void FrmAMRepos_Load(object sender, EventArgs e)
        {
            string sql = "select *,concat(prenom,' ',nom) as 'nomComplet' from employe where archive = 1";
            bsEmp = Fonctions.remplirList(cb_emps, sql, "Employe", "nomComplet", "id_employe");

            if (frm == "Modifier")
            {
                activier(false);
                lbl_titre.Text = "Modifier Repos";

                cb_emps.SelectedValue = idemp;

                cmd = new SqlCommand("select * from repos_employe where id_repos = " + idrep, Fonctions.CnConnection());
                dr = cmd.ExecuteReader();
                dr.Read();

                txt_nb.Text = dr["nb_jour"].ToString();
                txt_jours.Text = dr["jours"].ToString();

                dr.Close();
                dr = null;
            }
            else
            {
                activier(true);
                lbl_titre.Text = "Ajouter Repos";
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_vider_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_vider":
                    txt_jours.Clear();
                    txt_nb.Clear();
                    txt_nb.Focus();
                    break;
                case "btn_valider_ajt":
                    if (txt_jours.Text != "" && txt_nb.Text != "")
                    {
                        cmd = new SqlCommand("insert into repos_employe values (" + cb_emps.SelectedValue + "," + Int32.Parse(txt_nb.Text) + ",'" + txt_jours.Text + "',1)", Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Repos Ajouter Avec Succes.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Remplier Tous Les Informations S'il Vous Plaît.", "Remplir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "btn_valider_mod":
                    if(txt_jours.Text != "" && txt_nb.Text != "")
                    {
                        cmd = new SqlCommand("update repos_employe set id_employe = " + cb_emps.SelectedValue + ",nb_jour = " + Int32.Parse(txt_nb.Text) + ", jours = '" + txt_jours.Text + "' where id_repos = " + idrep + "", Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Repos Modifier Avec Succes.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Remplier Tous Les Informations S'il Vous Plaît.", "Remplir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "btn_annuler_ajt":
                case "btn_annuler_mod":
                    this.Close();
                    break;
            }
        }
    }
}
