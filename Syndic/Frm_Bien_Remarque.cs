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
        BindingSource BSrem = new BindingSource();
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
                    Frm_Bien_remarque_aj ff = new Frm_Bien_remarque_aj("Modifier", int.Parse(List_rema.SelectedIndex.ToString()));
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

            string f = txt_chercher_rem.Text == "Chercher Par Nom Bien" ? "" : "nom like '%" + txt_chercher_rem.Text + "%'";


            BSbien.Filter = f;
        }

        private void grp_fichier_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_Bien_Remarque_Load(object sender, EventArgs e)
        {

            ouvriConnectio();
            AD = new SqlDataAdapter("select * from bien where archive=1", CN);
            if (!DS.Tables.Contains("bien"))

                AD.Fill(DS, "bien");

            BSbien.DataSource = DS;
            BSbien.DataMember = "bien";

            cmb_bien.DataSource = BSbien;
            cmb_bien.ValueMember = "id_bien";
            cmb_bien.DisplayMember = "NomApparetemnt";

            AD = null;

            AD = new SqlDataAdapter("select * from remarque_bien where archive = 1", CN);
            if (!DS.Tables.Contains("remarque_bien"))
                AD.Fill(DS, "remarque_bien");
            BSrem.DataSource = DS;
            BSrem.DataMember = "remarque_bien";

            List_rema.DataSource = BSrem;
            List_rema.ValueMember = "id_remarque";
            List_rema.DisplayMember = "remarque";
          
        }

      
        private void txt_chercher_bien_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher_rem, "Chercher Par Nom Bien");
        }

        private void txt_chercher_bien_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher_rem, "Chercher Par Nom Bien");
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

        private void List_rema_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_bien_SelectedIndexChanged(object sender, EventArgs e)
        {
            BSrem.Filter = "id_bien = '" + List_rema.SelectedValue + "'";
        }
    }
}
