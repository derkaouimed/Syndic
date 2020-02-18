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
    public partial class Frm_Bien_Remarque : Form
    {
        BindingSource BSbien = new BindingSource();
        SqlConnection CN = new SqlConnection();
        DataSet DS = new DataSet();
        SqlDataAdapter AD;
        public Frm_Bien_Remarque()
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

        private void btn_Bien_rem_Supprimer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_Bien_rem_Ajouter":
                    Frm_Bien_remarque_aj f = new Frm_Bien_remarque_aj("Ajouter", 0);
                    f.ShowDialog();

                    break;
                case "btn_Bien_rem_modifier":
                    Frm_Bien_remarque_aj ff = new Frm_Bien_remarque_aj("Modifier", int.Parse(list_bien.SelectedIndex.ToString()));
                    ff.ShowDialog();

                    break;
                case "btn_Bien_rem_Supprimer":
                    //DialogResult d = MessageBox.Show("Supprerimer", "Voulez Vous Supprime ce remarque ?", MessageBoxButtons.OK);
                    //if (DialogResult.OK == d)
                    //{


                    //    SqlCommand com = new SqlCommand("Update remarque_bien set archive = 0 where id_remarque = " + int.Parse(grid_bien_rem.CurrentRow.Cells[0].Value.ToString()), CN);
                    //    int a = 0;
                    //    a = com.ExecuteNonQuery();
                    //    if (a != 0)
                    //    {
                    //        MessageBox.Show("Supprimer !!");

                    //        grid_bien_rem.Rows.RemoveAt(grid_bien_rem.CurrentRow.Index);

                    //    }

                    //    else
                    //        MessageBox.Show("Error de Supprimer !!");

                    //}

                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder com = new SqlCommandBuilder(AD);
            AD.Update(DS.Tables["remarque"]);

            string f = txt_cherch_rem.Text == "Chercher Par Nom Bien " ? "" : "nom like '%" + txt_cherch_rem.Text + "%'";


            BSbien.Filter = f;
        }

        private void grp_fichier_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_Bien_Remarque_Load(object sender, EventArgs e)
        {

            ouvriConnectio();
            AD = new SqlDataAdapter("select * from bien ", CN);
            if (!DS.Tables.Contains("bien"))

                AD.Fill(DS, "bien");

            BSbien.DataSource = DS;
            BSbien.DataMember = "bien";

            list_bien.DataSource = BSbien;
            list_bien.ValueMember = "id_bien";
            list_bien.DisplayMember = "NomApparetemnt";
        }

      
        private void txt_chercher_bien_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher_bien, "Chercher Par Nom Bien");
        }

        private void txt_chercher_bien_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher_bien, "Chercher Par Nom Bien");
        }

        private void txt_cherch_rem_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_cherch_rem, "Chercher Nom Remarque");
        }

        private void txt_cherch_rem_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_cherch_rem, "Chercher Nom Remarque");
        }

        private void btn_premiere_Click(object sender, EventArgs e)
        {
            BSbien.MoveFirst();
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            BSbien.MovePrevious();
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            BSbien.MoveNext();
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            BSbien.MoveLast();
        }
    }
}
