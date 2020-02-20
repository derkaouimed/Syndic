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
       SqlDataAdapter AD ;
        BindingSource BSut = new BindingSource();
        BindingSource BSty = new BindingSource();
        SqlConnection CN = new SqlConnection();
        SqlCommand comT = new SqlCommand();
        SqlCommand com = new SqlCommand();
        SqlDataReader DRT;


        DataSet DS = new DataSet();
        bool aj;
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


        private void btn_utilisateur_Ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_valider":
                    if (aj)
                    {
                        ouvriConnectio();
                        comT = new SqlCommand("Select id_type from type_utilisateur where nom_type like '" + cmb_typ.Text + "'", CN);
                        DRT = comT.ExecuteReader();
                        DRT.Read();
                        int T = int.Parse(DRT[0].ToString());

                        comT = null;
                        DRT.Close();

                        if (txt_log.Text != "" && txt_pass.Text != "")
                        {


                            com = new SqlCommand("insert into utilisateur values('" + txt_log.Text + "','" + txt_pass.Text + "', 'P '" + "','" + T + "','1','1')", CN);
                            int a = -1;
                            a = com.ExecuteNonQuery();
                            if (a != -1)
                            {
                                MessageBox.Show("Enregistrer !!! ");
                            }
                            else
                            {
                                MessageBox.Show("not enregistrer !!");
                            }

                        }
                        else
                            MessageBox.Show("Remplir tous les champs !!!");
                    }

                    break;
                case "btn_annuler":
                    btn_valider.Visible = false;
                    btn_annuler.Visible = false;
                    groupBox2.Enabled = false;
                    btn_utilisateur_Ajouter.Visible = true;
                    btn_utilisateur_modifier.Visible = true;
                    btn_utilisateur_Supprimer.Visible = true;
                    groupBox2.Enabled = false;

                    break;
                case "btn_utilisateur_Ajouter":
                   
                    btn_valider.Visible = true;
                    btn_annuler.Visible = true;
                    groupBox2.Enabled = true;
                    btn_utilisateur_Ajouter.Visible = false;
                    btn_utilisateur_modifier.Visible = false;
                    btn_utilisateur_Supprimer.Visible = false;
                    txt_log.Text = "";
                    txt_pass.Text = "";
                    cmb_typ.Text = "";
                    aj = true;

                    break;
                case "btn_utilisateur_modifier":
                    btn_utilisateur_Ajouter.Visible = false;
                    btn_utilisateur_modifier.Visible = false;
                    btn_utilisateur_Supprimer.Visible = false;
                    btn_valider.Visible = true;
                    btn_annuler.Visible = true;
                    groupBox2.Enabled = true;
                    aj = false;

                    break;
                case "btn_utilisateur_Supprimer":
                    DialogResult d = MessageBox.Show("Supprerimer", "Voulez Vous Supprime cette utilisateur ?", MessageBoxButtons.YesNo);
                    if (DialogResult.OK == d)
                    {


                        SqlCommand com = new SqlCommand("Update utilisateur set archive = 0 where id_utilisateur = " + int.Parse(lst_utilisateur.SelectedValue.ToString()), CN);
                        int a = 0;
                        a = com.ExecuteNonQuery();
                        if (a != 0)
                        {
                           MessageBox.Show("supresion" , "suppeimer !!",MessageBoxButtons.OK);
                           
                           // dtG_utilisateur.Rows.RemoveAt(dtG_utilisateur.CurrentRow.Index);

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
            BSut = Fonctions.remplirList(lst_utilisateur, "utilisateur", "login", "id_utilisateur");
            txt_log.DataBindings.Add("text", BSut, "login");
            txt_pass.DataBindings.Add("text", BSut, "password");

            BSty = Fonctions.remplirList(cmb_typ, "type_utilisateur", "nom_type", "id_type");
            cmb_typ.DataBindings.Add("selectedvalue", BSut, "id_type");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder com = new SqlCommandBuilder(AD);
            AD.Update(DS.Tables["utilisateur"]);
            string f = txt_chercher.Text == "Chercher Par Nom" ? "" : "login like '%" + txt_chercher.Text + "%'";
            BSut.Filter = f;


        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Chercher Par Nom");
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Chercher Par Nom");
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

        private void txt_chercher_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_chercher_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
