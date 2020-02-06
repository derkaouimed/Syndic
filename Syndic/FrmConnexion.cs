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
using System.Configuration;

namespace Syndic
{
    public partial class FrmConnexion : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;
        int row = 0;

        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void remplirGrilleProp()
        {
            cmd = new SqlCommand("select nom,prenom,date_connexion,nom_type,c.archive from utilisateur u inner join type_utilisateur t on t.id_type=u.id_type inner join connexion c on c.id_utilisateur=u.id_utilisateur inner join proprietaire e on e.id_proprietaire=u.id_table where u.id_type in (select u.id_type from utilisateur u inner join type_utilisateur t on u.id_type=t.id_type where nom_type='proprietaire')", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToBoolean(dr["archive"].ToString()))
                    dt_grid.Rows.Add(dr["nom"].ToString(), dr["prenom"].ToString(), dr["nom_type"].ToString(), dr["date_connexion"].ToString());
            }
            dr.Close();
            dr = null;
            dt_grid.Sort(dt_grid.Columns[3], ListSortDirection.Descending);
        }

        private void remplirGrillePropDate()
        {
            cmd = new SqlCommand("select nom,prenom,date_connexion,nom_type,c.archive from utilisateur u inner join type_utilisateur t on t.id_type=u.id_type inner join connexion c on c.id_utilisateur=u.id_utilisateur inner join proprietaire e on e.id_proprietaire=u.id_table where u.id_type in (select u.id_type from utilisateur u inner join type_utilisateur t on u.id_type=t.id_type where nom_type='proprietaire') and (date_connexion between '" + dt_de.Value.ToShortDateString()+"' and '"+dt_a.Value.ToShortDateString() + "')", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToBoolean(dr["archive"].ToString()))
                    dt_grid.Rows.Add(dr["nom"].ToString(), dr["prenom"].ToString(), dr["nom_type"].ToString(), dr["date_connexion"].ToString());
            }
            dr.Close();
            dr = null;
            dt_grid.Sort(dt_grid.Columns[3], ListSortDirection.Descending);
        }

        private void remplirGrilleEmp()
        {
            cmd = new SqlCommand("select nom,prenom,date_connexion,te.nom_type,c.archive from utilisateur u inner join type_utilisateur t on t.id_type=u.id_type inner join connexion c on c.id_utilisateur=u.id_utilisateur inner join employe e on e.id_employe=u.id_table inner join type_employe te on te.id_type = e.id_type_employe where u.id_type in (select u.id_type from utilisateur u inner join type_utilisateur t on u.id_type=t.id_type where nom_type='employee')", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToBoolean(dr["archive"].ToString()))
                    dt_grid.Rows.Add(dr["nom"].ToString(), dr["prenom"].ToString(), dr["nom_type"].ToString(), dr["date_connexion"].ToString());
            }
            dr.Close();
            dr = null;
        }

        private void remplirGrilleEmpDate()
        {
            cmd = new SqlCommand("select nom,prenom,date_connexion,te.nom_type,c.archive from utilisateur u inner join type_utilisateur t on t.id_type=u.id_type inner join connexion c on c.id_utilisateur=u.id_utilisateur inner join employe e on e.id_employe=u.id_table inner join type_employe te on te.id_type = e.id_type_employe where u.id_type in (select u.id_type from utilisateur u inner join type_utilisateur t on u.id_type=t.id_type where nom_type='employee') and (date_connexion between '" + dt_de.Value.ToShortDateString() + "' and '"+dt_a.Value.ToShortDateString() + "')", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToBoolean(dr["archive"].ToString()))
                    dt_grid.Rows.Add(dr["nom"].ToString(), dr["prenom"].ToString(), dr["nom_type"].ToString(), dr["date_connexion"].ToString());
            }
            dr.Close();
            dr = null;
        }

        private void pnlAfficher()
        {
            if (rd_nomPrenom.Checked)
            {
                pnl_nomPrenom.Visible = true;
                pnl_type.Visible = false;
                pnl_date.Visible = false;
            }
            else
            {
                if (rd_type.Checked)
                {
                    pnl_nomPrenom.Visible = false;
                    pnl_type.Visible = true;
                    pnl_date.Visible = false;

                    cb_type.Items.Clear();
                    cmd = new SqlCommand("select nom_type from type_employe", cn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cb_type.Items.Add(dr[0].ToString());
                    }
                    dr.Close();
                    dr = null;
                    cb_type.Items.Add("proprietaire");
                }
                else
                {
                    pnl_nomPrenom.Visible = false;
                    pnl_type.Visible = false;
                    pnl_date.Visible = true;
                }
            }
        }
        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                cn.Open();
            }
            pnlAfficher();

            remplirGrilleEmp();
            remplirGrilleProp();
            if (dt_grid.Rows.Count > 0)
                dt_grid.Rows[0].Cells[0].Selected = true;
        }

        private void rd_nomPrenom_CheckedChanged(object sender, EventArgs e)
        {
            pnlAfficher();
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            if ((txt_chercher.Text != "") && (txt_chercher.Text == "Tapez Le Nom & Prenom Pour Rechercher"))
            {
                txt_chercher.Clear();
                txt_chercher.ForeColor = Color.Black;
            }
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            if (txt_chercher.Text == "")
            {
                txt_chercher.Text = "Tapez Le Nom & Prenom Pour Rechercher";
                txt_chercher.ForeColor = Color.Gray;
            }
        }

        private void btn_chercherDate_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_chercherNom":
                    if (txt_chercher.Text == "Tapez Le Nom & Prenom Pour Rechercher")
                    {
                        dt_grid.Rows.Clear();
                        remplirGrilleEmp();
                        remplirGrilleProp();
                        if (dt_grid.Rows.Count > 0)
                            dt_grid.Rows[0].Cells[0].Selected = true;
                    }
                    else
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

                        cmd = new SqlCommand("select nom,prenom,date_connexion,nom_type from utilisateur u inner join type_utilisateur t on t.id_type=u.id_type inner join connexion c on c.id_utilisateur=u.id_utilisateur inner join proprietaire e on e.id_proprietaire=u.id_table where u.id_type in (select u.id_type from utilisateur u inner join type_utilisateur t on u.id_type=t.id_type where nom_type='proprietaire') and (nom like '%" + nom + "%' or nom like '%" + prenom + "%' or prenom like '%" + nom + "%' or prenom like '%" + prenom + "%')", cn);
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            dt_grid.Rows.Add(dr["nom"].ToString(), dr["prenom"].ToString(), dr["nom_type"].ToString(), dr["date_connexion"].ToString());
                        }
                        dr.Close();
                        dr = null;

                        cmd = new SqlCommand("select nom,prenom,date_connexion,te.nom_type from utilisateur u inner join type_utilisateur t on t.id_type=u.id_type inner join connexion c on c.id_utilisateur=u.id_utilisateur inner join employe e on e.id_employe=u.id_table inner join type_employe te on te.id_type = e.id_type_employe where u.id_type in (select u.id_type from utilisateur u inner join type_utilisateur t on u.id_type=t.id_type where nom_type='employee') and (nom like '%" + nom + "%' or nom like '%" + prenom + "%' or prenom like '%" + nom + "%' or prenom like '%" + prenom + "%')", cn);
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            dt_grid.Rows.Add(dr["nom"].ToString(), dr["prenom"].ToString(), dr["nom_type"].ToString(), dr["date_connexion"].ToString());
                        }
                        dr.Close();
                        dr = null;
                        dt_grid.Sort(dt_grid.Columns[3], ListSortDirection.Descending);
                        if (dt_grid.Rows.Count > 0)
                            dt_grid.Rows[0].Cells[0].Selected = true;
                    }
                    break;
                case "btn_chercherType":
                    if (cb_type.SelectedIndex == -1)
                        MessageBox.Show("select un type s'il vous plaît.", "Type Est Vide", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        dt_grid.Rows.Clear();
                        if (cb_type.Text == "proprietaire")
                        {
                            remplirGrilleProp();
                        }
                        else
                        {
                            cmd = new SqlCommand("select nom,prenom,date_connexion,te.nom_type from utilisateur u inner join type_utilisateur t on t.id_type=u.id_type inner join connexion c on c.id_utilisateur=u.id_utilisateur inner join employe e on e.id_employe=u.id_table inner join type_employe te on te.id_type = e.id_type_employe where u.id_type in (select u.id_type from utilisateur u inner join type_utilisateur t on u.id_type=t.id_type where nom_type='employee') and te.nom_type = '" + cb_type.Text + "'", cn);
                            dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                dt_grid.Rows.Add(dr["nom"].ToString(), dr["prenom"].ToString(), dr["nom_type"].ToString(), dr["date_connexion"].ToString());
                            }
                            dr.Close();
                            dr = null;
                            dt_grid.Sort(dt_grid.Columns[3], ListSortDirection.Descending);
                            if (dt_grid.Rows.Count > 0)
                                dt_grid.Rows[0].Cells[0].Selected = true;
                        }
                    }
                    break;
                case "btn_chercherDate":
                    dt_grid.Rows.Clear();
                    remplirGrilleEmpDate();
                    remplirGrillePropDate();
                    if (dt_grid.Rows.Count > 0)
                        dt_grid.Rows[0].Cells[0].Selected = true;
                    break;
            }
        }

        private void btn_premiere_Click(object sender, EventArgs e)
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

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_supprimer":
                    if (dt_grid.Rows.Count > 0)
                    {
                        if(DialogResult.Yes==MessageBox.Show("Voulez-vous Vraiment Supprimer Cette Connexcion ?","Supprimer",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                        {
                            cmd = new SqlCommand("update connexion set archive = 0 where date_connexion = '" + dt_grid.CurrentRow.Cells[3].Value.ToString() + "'", cn);
                            cmd.ExecuteNonQuery();
                            dt_grid.Rows.Clear();

                            remplirGrilleEmp();
                            remplirGrilleProp();
                        }
                    }
                    break;
                case "btn_vider":
                    if (dt_grid.Rows.Count > 0)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Voulez-vous Vraiment Vider La Liste Des Connexcion ?", "Vider", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            dt_grid.Rows.Clear();
                            cmd = new SqlCommand("update connexion set archive = 0", cn);
                            cmd.ExecuteNonQuery();
                            remplirGrilleEmp();
                            remplirGrilleProp();
                        }
                    }
                    break;
            }
        }
    }
}
