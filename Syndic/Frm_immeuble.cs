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

        public void ouvriConnectio()
        {
            if (CN.State != ConnectionState.Open)
            {
                CN.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                CN.Open();
            }
        }
        private void btn_immeuble_Supprimer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_immeuble_Ajouter":
                    Frm_immeuble_aj f = new Frm_immeuble_aj("Ajouter", 0);
                    f.ShowDialog();

                    break;
                case "btn_immeuble_modifier":
                    Frm_immeuble_aj ff = new Frm_immeuble_aj("Modifier", int.Parse(dtG_immeuble.CurrentRow.Cells[0].Value.ToString()));
                    ff.ShowDialog();


                    break;
                case "btn_immeuble_Supprimer":
                    DialogResult d = MessageBox.Show( "Voulez Vous Supprime cette immeuble ?", "Supprerimer", MessageBoxButtons.OKCancel);
                    if (DialogResult.OK == d)
                    {
                        SqlCommand com = new SqlCommand("SELECT  archive FROM bien WHERE id_immeuble = " + int.Parse(dtG_immeuble.CurrentRow.Cells[0].Value.ToString()), CN);
                        SqlDataReader dr = com.ExecuteReader();
                        int ly = 0;
                        while (dr.Read())
                        {

                            if (dr[0].ToString() =="True")
                                ly = 1;
                        }
                        dr.Close();
                        dr = null;
                        if (ly == 1)
                        {
                            MessageBox.Show("ne peut pas supprimer cette immeuble car il y a des bien dans cette immeuble !! ", "erreur");
                        }
                        else
                        {
                            com = null;
                            com = new SqlCommand("Update immeuble set archive = 0 where id_immeuble = " + int.Parse(dtG_immeuble.CurrentRow.Cells[0].Value.ToString()), CN);
                            int a = 0;
                            a = com.ExecuteNonQuery();
                            if (a != 0)
                            {
                                MessageBox.Show("Supprimer !!");
                            }

                            else
                                MessageBox.Show("Error de Supprimer !!");
                        }
                    }


                    break;

            }
        }


        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder com = new SqlCommandBuilder(AD);
            AD.Update(DS.Tables["immeuble"]);
            string f = txt_chercher.Text == "Taper un Nom Pour chercher" ? "" : "[Nom immeuble] like '%" + txt_chercher.Text + "%'";
            BSimm.Filter = f;
        }

        private void Frm_immeuble_Load(object sender, EventArgs e)
        {
            ouvriConnectio();
            AD = new SqlDataAdapter("select id_immeuble as [ID] , nom as [Nom immeuble],titrefoncier as[titre foncier],paiment from immeuble  where archive='1' ", CN);

            if (!DS.Tables.Contains("immeuble"))

                AD.Fill(DS, "immeuble");

            BSimm.DataSource = DS;
            BSimm.DataMember = "immeuble";

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_chercher_TextChanged(object sender, EventArgs e)
        {
            string f = txt_chercher.Text == "Taper un Nom Pour Chercher" ? "" : "[Nom immeuble] like '%" + txt_chercher.Text + "%'";
            BSimm.Filter = f;
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Taper un Nom Pour Chercher");
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Taper un Nom Pour Chercher");
        }
    }
}

