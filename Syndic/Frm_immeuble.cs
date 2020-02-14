using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Syndic
{
    public partial class Frm_immeuble : Form
    {
        SqlDataAdapter AD;
        BindingSource BSimm = new BindingSource();
        SqlConnection CN = new SqlConnection();
        DataSet DS = new DataSet();
        public Frm_immeuble()
        {
            InitializeComponent();
        }

        private void btn_immeuble_Supprimer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_immeuble_Ajouter":
                    Frm_immeuble_aj f = new Frm_immeuble_aj();
                    f.ShowDialog();

                    break;
                case "btn_immeuble_modifier":
                   Frm_immeuble_aj ff = new Frm_immeuble_aj();
                    ff.ShowDialog();


                    break;
                case "btn_immeuble_Supprimer":
                    DialogResult d = MessageBox.Show("Supprerimer", "Voulez Vous Supprime cette immeuble ?", MessageBoxButtons.YesNo);
                    if (DialogResult.OK == d)
                    {
                        

                        SqlCommand com = new SqlCommand("Update immeuble set archive = 0 where id_immeuble = " + int.Parse(dtG_immeuble.CurrentRow.Cells[0].Value.ToString()), CN);
                        int a = 0;
                        a = com.ExecuteNonQuery();
                        if (a != 0)
                        {
                            MessageBox.Show("Supprimer !!");

                            dtG_immeuble.Rows.RemoveAt(dtG_immeuble.CurrentRow.Index);

                        }

                        else
                            MessageBox.Show("Error de Supprimer !!");

                    }


            break;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Chercher Par Nom ");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Chercher Par Nom");
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder com = new SqlCommandBuilder(AD);
            AD.Update(DS.Tables["immeuble"]);

            if (txt_chercher.Text == "Chercher Par Nom ")
                BSimm.Filter = "";
            else
            {

                BSimm.Filter = " nom like '%" + txt_chercher.Text.Replace("'", "''") + "%'";

            }
        }

        private void Frm_immeuble_Load(object sender, EventArgs e)
        {
            Fonctions.ouvrireConnection();
            AD = new SqlDataAdapter("select id_immeuble as [ID] , i.nom as [Nom immeuble],r.nom as [residence],i.titrefoncier as[titre foncier] from immeuble i inner join residence r on r.id_residence=i.id_residence ", CN);

            AD.Fill(DS, "immeuble");

            dtG_immeuble.DataSource = DS;
            dtG_immeuble.DataMember = "immeuble";

            dtG_immeuble.DataSource = BSimm;
        }

        private void btn_premiere_Click(object sender, EventArgs e)
        {
            BSimm.MoveFirst();
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            BSimm.MovePrevious();
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            BSimm.MoveNext();
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            BSimm.MoveLast();
        }
    }
}
