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
        BindingSource BSut = new BindingSource();
        SqlConnection CN = new SqlConnection();
        DataSet DS = new DataSet();
        public Frm_utilisateur()
        {
            InitializeComponent();
        }

        private void btn_utilisateur_Ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_utilisateur_Ajouter":
                    Frm_Utilisateur_aj ff = new Frm_Utilisateur_aj();
                    ff.ShowDialog();

                    break;
                case "btn_utilisateur_modifier":
                    Frm_Utilisateur_aj f = new Frm_Utilisateur_aj();
                    f.ShowDialog();

                    break;
                case "btn_utilisateur_Supprimer":
                    DialogResult d = MessageBox.Show("Supprerimer", "Voulez Vous Supprime cette utilisateur ?", MessageBoxButtons.YesNo);
                    if (DialogResult.OK == d)
                    {


                        SqlCommand com = new SqlCommand("Update utilisateur set archive = 0 where id_utilisateur = " + int.Parse(dtG_utilisateur.CurrentRow.Cells[0].Value.ToString()), CN);
                        int a = 0;
                        a = com.ExecuteNonQuery();
                        if (a != 0)
                        {
                            MessageBox.Show("Supprimer !!");

                            dtG_utilisateur.Rows.RemoveAt(dtG_utilisateur.CurrentRow.Index);

                        }

                        else
                            MessageBox.Show("Error de Supprimer !!");

                    }
                    break;
            }
        }

        private void Frm_utilisateur_Load(object sender, EventArgs e)
        {
            Fonctions.ouvrireConnection();
            AD = new SqlDataAdapter("select id_utilisateur as [ID] , u.login ,u.password as [Mot Passe ],t.nom_type as[Type utilisateur] from utilisateur u inner join type_utilisateur t on t.id_type=u.id_type ", CN);

            AD.Fill(DS, "utilisateur");

            dtG_utilisateur.DataSource = DS;
            dtG_utilisateur.DataMember = "utilisateur";

            dtG_utilisateur.DataSource = BSut;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder com = new SqlCommandBuilder(AD);
            AD.Update(DS.Tables["utilisateur"]);

            if (txt_chercher.Text == "Chercher Par Nom ")
                BSut.Filter = "";
            else
            {

                BSut.Filter = " nom like '%" + txt_chercher.Text.Replace("'", "''") + "%'";

            }
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Chercher Par Nom");
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Chercher Par Nom ");
        }

        private void btn_premiere_Click(object sender, EventArgs e)
        {
            BSut.MoveFirst();
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            BSut.MovePrevious();
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            BSut.MoveNext();
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            BSut.MoveLast();
        }
    }
}
