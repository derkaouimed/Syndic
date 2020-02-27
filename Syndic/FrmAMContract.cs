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
    public partial class FrmAMContract : Form
    {
        BindingSource bsEmp;
        SqlCommand cmd;
        SqlDataReader dr;
        string frm;
        int idemp, idcon;
        public FrmAMContract(string frm = "")
        {
            InitializeComponent();
            this.frm = frm;
        }

        public FrmAMContract(int idemp, int idcon, string frm = "")
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
        
        private void FrmAMContract_Load(object sender, EventArgs e)
        {
            string sql = "select id_employe,concat(prenom,' ',nom) as nomComplet from employe where archive = 1";
            bsEmp = Fonctions.remplirList(cb_emps, sql, "employe", "nomComplet", "id_employe");

            if (frm == "Modifier")
            {
                cb_emps.SelectedValue = idemp;

                cmd = new SqlCommand("select * from contrat where id_contrat = " + idcon, Fonctions.CnConnection());
                dr = cmd.ExecuteReader();
                dr.Read();

                dt_debut.Text = dr["date_debut"].ToString();
                dt_fin.Text = dr["date_fin"].ToString();
                txt_salaire.Text = dr["salaire"].ToString();
                dr.Close();
                dr = null;

                lbl_titre.Text = "Modifier Contract";
                activier(false);
            }
            else
            {
                lbl_titre.Text = "Ajouter Contract";
                activier(true);
            }
        }

        private void btn_valider_mod_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_valider_ajt":
                    if (txt_salaire.Text != ""){
                        cmd = new SqlCommand("insert into contrat values (" + cb_emps.SelectedValue + ",'" + dt_debut.Value + "','" + dt_fin.Value + "'," + float.Parse(txt_salaire.Text) + ",1)", Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Contract Ajouter Avec Succes.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sisez Salaire S'il Vous Plait.", "Salaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_salaire.Focus();
                    }
                    break;
                case "btn_valider_mod":
                    if (txt_salaire.Text != "")
                    {
                        cmd = new SqlCommand("update contrat set id_employe = " + cb_emps.SelectedValue + ",date_debut = '" + dt_debut.Value + "',date_fin = '" + dt_fin.Value + "',salaire =" + float.Parse(txt_salaire.Text) + " where id_contrat = " + idcon, Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Contract Modifier Avec Succes.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sisez Salaire S'il Vous Plait.", "Salaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_salaire.Focus();
                    }
                    break;
                case "btn_annuler_ajt":
                case "btn_annuler_mod":
                    this.Close();
                    break;
            }
        }
    }
}
