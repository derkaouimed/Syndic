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
    public partial class FrmAMConge : Form
    {
        BindingSource bsEmp;
        string frm;
        int idemp, idcon;
        SqlCommand cmd;
        SqlDataReader dr;
        public FrmAMConge(string frm = "")
        {
            InitializeComponent();
            this.frm = frm;
        }

        public FrmAMConge(int idemp = 0, int idcon = 0, string frm = "")
        {
            InitializeComponent();
            this.frm = frm;
            this.idemp = idemp;
            this.idcon = idcon;
        }

        private void activier(bool b)
        {
            pnl_ajouter.Visible = b;
            pnl_modifier.Visible = !b;
        }
        
        private void FrmAMConge_Load(object sender, EventArgs e)
        {
            string sql = "select *,concat(prenom,' ',nom) as nomComplet from employe where archive = 1";
            bsEmp = Fonctions.remplirList(cb_emps, sql, "Employe", "nomComplet", "id_employe");

            if (frm == "Modifier")
            {
                cb_emps.SelectedValue = idemp;
                cmd = new SqlCommand("select * from conge_employe where id_employe = " + idemp + " and id_conge = " + idcon, Fonctions.CnConnection());
                dr = cmd.ExecuteReader();
                dr.Read();

                dt_debut.Value = Convert.ToDateTime(dr["date_sortie"].ToString());
                dt_fin.Value = Convert.ToDateTime(dr["date_entree"].ToString());
                dr.Close();
                dr = null;

                lbl_titre.Text = "Modifier Conge";
                activier(false);
            }
            else
            {
                lbl_titre.Text = "Ajouter Conge";
                activier(true);
            }
        }

        private void btn_valider_ajt_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_valider_ajt":
                    cmd = new SqlCommand("insert into conge_employe values (" + cb_emps.SelectedValue + ",'" + dt_debut.Value + "','" + dt_fin.Value + "',1)", Fonctions.CnConnection());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Conge Ajouter Avec Succes.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "btn_valider_mod":
                    cmd = new SqlCommand("update conge_employe set id_employe=" + cb_emps.SelectedValue + " ,date_sortie='" + dt_debut.Value + "',date_entree='" + dt_fin.Value + "' where id_conge = " + idcon, Fonctions.CnConnection());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Conge Modifier Avec Succes.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "btn_annuler_ajt":
                case "btn_annuler_mod":
                    this.Close();
                    break;
            }
        }

    }
}
