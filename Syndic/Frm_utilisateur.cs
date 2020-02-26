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
    public partial class Frm_utilisateur : Form
    {
        BindingSource BSimm;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter AD;
        int row = 0;

        public Frm_utilisateur()
        {
            InitializeComponent();
        }


        private void Affiche()
        {
            if (rd_nom.Checked == true)
            {
                pnl_nom.Visible = true;
                //pnl_typ.Visible = false;
            }
            else
            {
                pnl_nom.Visible = false;
                //  pnl_typ.Visible = true;

                Fonctions.remplirList(cb_type, "type_utilisateur", "nom_type", "id_type");
            }

        }

        private void remplirGrilleEmp()
        {
            string sqlEmp = "select u.id_utilisateur,u.login,u.password,u.salt,t.nom_type,(e.prenom+' '+e.nom) as [Nom Complete] from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join employe e on e.id_employe = u.id_table where  t.nom_type = 'Employée' and u.archive = 1";
            cmd = new SqlCommand(sqlEmp, Fonctions.CnConnection());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt_grid.Rows.Add(dr["Nom Complete"].ToString(), dr["login"].ToString(), dr["password"].ToString(), dr["nom_type"].ToString());
            }
            dr.Close();
            dr = null;
        }

        private void remplirGrilutilProp()
        {
            string sqlPrp = "select u.id_utilisateur,u.login,u.password,u.salt,t.nom_type,(e.prenom+' '+e.nom) as [Nom Complete] from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join employe e on e.id_employe = u.id_table where  t.nom_type = 'Proprietaire' and u.archive = 1";

            cmd = new SqlCommand(sqlPrp, Fonctions.CnConnection());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt_grid.Rows.Add(dr["Nom Complete"].ToString(), dr["login"].ToString(), dr["password"].ToString(), dr["nom_type"].ToString());
            }
            dr.Close();
            dr = null;
        }



        private void Frm_utilisateur_Load(object sender, EventArgs e)
        {
            Affiche();
            string sqlEmp = "select u.id_utilisateur,u.login,u.password,u.salt,t.nom_type,(e.prenom+' '+e.nom) as [Nom Complete] from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join employe e on e.id_employe = u.id_table where  t.nom_type = 'Employée' and u.archive = 1";
            string sqlPrp = "select u.id_utilisateur,u.login,u.password,u.salt,t.nom_type,(e.prenom+' '+e.nom) as [Nom Complete] from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join employe e on e.id_employe = u.id_table where  t.nom_type = 'Proprietaire' and u.archive = 1";

            cmd = new SqlCommand(sqlEmp, Fonctions.CnConnection());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt_grid.Rows.Add(dr["Nom Complete"].ToString(), dr["login"].ToString(), dr["password"].ToString(), dr["nom_type"].ToString());
            }
            dr.Close();
            dr = null;




            cmd = new SqlCommand(sqlPrp, Fonctions.CnConnection());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt_grid.Rows.Add(dr["Nom Complete"].ToString(), dr["login"].ToString(), dr["password"].ToString(), dr["nom_type"].ToString());
            }
            dr.Close();
            dr = null;
        }

        private void btn_ajouter_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_Bien_Ajouter":
                    Frm_Utilisateur_aj f = new Frm_Utilisateur_aj("Ajouter", 0);
                    f.ShowDialog();

                    break;
                case "btn_Bien_modifier":

                    Frm_Utilisateur_aj ff = new Frm_Utilisateur_aj("Modifier", int.Parse(dt_grid.CurrentRow.Cells[0].Value.ToString()));
                    ff.ShowDialog();


                    break;
                case "btn_Bien_Supprimer":
                    DialogResult d = MessageBox.Show("Voulez Vous Supprime cette Bien ?", "Supprerimer", MessageBoxButtons.YesNo);
                    if (DialogResult.OK == d)
                    {


                        SqlCommand com = new SqlCommand("Update utilisateur set archive = 0 where id_bien = " + int.Parse(dt_grid.CurrentRow.Cells[0].Value.ToString()), Fonctions.CnConnection());
                        int a = 0;
                        a = com.ExecuteNonQuery();
                        if (a != 0)
                        {
                            MessageBox.Show("Supprimer !!");
                        }

                        else
                            MessageBox.Show("Error de Supprimer !!");

                    }

                    break;

            }
        }

        private void btn_suivant_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_premiere":
                    row = 0;
                    dt_grid.Rows[row].Cells[0].Selected = true;
                    break;
                case "btn_suivant":
                    if (dt_grid.Rows.Count - 1 != row)
                    {
                        row++;
                        dt_grid.Rows[row].Cells[0].Selected = true;
                    }
                    break;
                case "btn_precedent":
                    if (row != 0)
                    {
                        row--;
                        dt_grid.Rows[row].Cells[0].Selected = true;
                    }
                    break;
                case "btn_derniere":
                    row = dt_grid.Rows.Count - 1;
                    dt_grid.Rows[row].Cells[0].Selected = true;
                    break;
            }
        }

        private void rd_rubrique_Click(object sender, EventArgs e)
        {
            Affiche();
        }


        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Taper un Nom Pour Chercher");
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Taper un Nom Pour Chercher");
        }

        private void btn_chercher_designation_Click(object sender, EventArgs e)
        {

            dt_grid.Rows.Clear();

            int a;
            if (txt_chercher.Text.Contains(' '))
                a = txt_chercher.Text.IndexOf(' ');
            else
                a = txt_chercher.Text.Length;

            string nom = txt_chercher.Text.Substring(0, a);
            string prenom = txt_chercher.Text.Substring(a, (txt_chercher.Text.Length - a));
            if (prenom == "") prenom = " ";

            string sqlPrp = "select u.id_utilisateur,u.login,u.password,u.salt,t.nom_type,(e.prenom+' '+e.nom) as [Nom Complete] from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join employe e on e.id_employe = u.id_table where  t.nom_type = 'Proprietaire'  and (nom like '%" + nom + "%' or nom like '%" + prenom + "%' or prenom like '%" + nom + "%' or prenom like '%" + prenom + "%')";

            cmd = new SqlCommand(sqlPrp, Fonctions.CnConnection());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt_grid.Rows.Add(dr["Nom Complete"].ToString(), dr["login"].ToString(), dr["password"].ToString(), dr["nom_type"].ToString());
            }
            dr.Close();
            dr = null;

            string sqlEmp = "select u.id_utilisateur,u.login,u.password,u.salt,t.nom_type,(e.prenom+' '+e.nom) as [Nom Complete] from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join employe e on e.id_employe = u.id_table where  t.nom_type = 'Employée' and (nom like '%" + nom + "%' or nom like '%" + prenom + "%' or prenom like '%" + nom + "%' or prenom like '%" + prenom + "%')";
            cmd = new SqlCommand(sqlEmp, Fonctions.CnConnection());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt_grid.Rows.Add(dr["Nom Complete"].ToString(), dr["login"].ToString(), dr["password"].ToString(), dr["nom_type"].ToString());
            }
            dr.Close();
            dr = null;

        }

        private void btn_chercher_rubrique_Click(object sender, EventArgs e)
        {
            if (cb_type.SelectedIndex == -1)
                MessageBox.Show("select un type s'il vous plaît.", "Type Est Vide", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                dt_grid.Rows.Clear();
                if (cb_type.Text == "Proprietaire")
                {
                    remplirGrilutilProp();
                }
                else
                {
                    string sql = "select u.id_utilisateur,u.login,u.password,u.salt,t.nom_type,(e.prenom+' '+e.nom) as [Nom Complete] from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join employe e on e.id_employe = u.id_table where  t.nom_type = '"+ cb_type.Text+"' and u.archive = 1";
                   

                    cmd = new SqlCommand(sql, Fonctions.CnConnection());
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        dt_grid.Rows.Add(dr["Nom Complete"].ToString(), dr["login"].ToString(), dr["password"].ToString(), dr["nom_type"].ToString());
                    }
                    dr.Close();
                    dr = null;
                }

            }
        }
    } 
}
