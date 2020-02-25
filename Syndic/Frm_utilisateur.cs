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
    public partial class Frm_utilisateur : Form
    {
        SqlDataAdapter AD;
        BindingSource BSimm = new BindingSource();
        SqlConnection CN = new SqlConnection();
        DataSet DS = new DataSet();

        public Frm_utilisateur()
        {
            InitializeComponent();
        }
        public void ouvriConnectio()
        {
            if (CN.State != ConnectionState.Open)
            {
                CN.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                CN.Open();
            }
        }
        private void remplirGrilleutil()
        {

            ouvriConnectio();
            AD = new SqlDataAdapter("select u.id_utilisateur,u.login,u.password,u.salt,t.nom_type,e.prenom+' '+e.nom as 'Nom Complete' from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join employe e on e.id_employe = u.id_table where t.nom_type = 'employee' union select u.id_utilisateur, u.login, u.password, u.salt, t.nom_type, e.prenom+' '+e.nom as 'Nom Complete' from utilisateur u inner join type_utilisateur t on t.id_type = u.id_type inner join employe e on e.id_employe = u.id_table where u.archive='1' ", CN);

            if (!DS.Tables.Contains("utilisateur"))

                AD.Fill(DS, "utilisateur");

            BSimm.DataSource = DS;
            BSimm.DataMember = "utilisateur";

            dt_grid.DataSource = BSimm;

          dt_grid.Columns[0].Visible = false;

            dt_grid.Sort(dt_grid.Columns[0], ListSortDirection.Descending);
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {

        }

        private void Frm_utilisateur_Load(object sender, EventArgs e)
        {
            remplirGrilleutil();

        }

        private void btn_premier_Click(object sender, EventArgs e)
        {

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


                        SqlCommand com = new SqlCommand("Update utilisateur set archive = 0 where id_bien = " + int.Parse(dt_grid.CurrentRow.Cells[0].Value.ToString()), CN);
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
                case "btn_derniere":
                    BSimm.MoveLast();
                    break;
                case "btn_suivant":
                    BSimm.MoveNext();
                    break;
                case "btn_premiere":
                    BSimm.MoveFirst();
                    break;
                case "btn_precedent":
                    BSimm.MovePrevious();
                    break;
            }
        }
    }
}
