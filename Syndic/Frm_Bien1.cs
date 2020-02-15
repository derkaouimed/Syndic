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
    public partial class Frm_Bien1 : Form
    {
        BindingSource BSbien = new BindingSource();
        SqlConnection CN = new SqlConnection();
        DataSet DS = new DataSet();
        SqlDataAdapter AD;
        public Frm_Bien1()
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

        private void btn_Bien_Supprimer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_Bien_Ajouter":
                    Frm_Bien_Aj f = new Frm_Bien_Aj("Ajouter", 0);
                    f.ShowDialog();

                    break;
                case "btn_Bien_modifier":

                    Frm_Bien_Aj ff = new Frm_Bien_Aj("Modifier", int.Parse(gridBien.CurrentRow.Cells[0].Value.ToString()));
                    ff.ShowDialog();


                    break;
                case "btn_Bien_Supprimer":
                    DialogResult d = MessageBox.Show("Supprerimer", "Voulez Vous Supprime cette Bien ?", MessageBoxButtons.YesNo);
                    if (DialogResult.OK == d)
                    {
                      

                        SqlCommand com = new SqlCommand("Update bien set archive = 0 where id_bien = " + int.Parse(gridBien.CurrentRow.Cells[0].Value.ToString()), CN);
                        int a = 0;
                        a = com.ExecuteNonQuery();
                        if (a != 0)
                        {
                            MessageBox.Show("Supprimer !!");

                            gridBien.Rows.RemoveAt(gridBien.CurrentRow.Index);

                        }

                        else
                            MessageBox.Show("Error de Supprimer !!");

                    }

                    break;

            }
        }

        private void grp_fichier_Enter(object sender, EventArgs e)
        {

        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder com = new SqlCommandBuilder(AD);
            AD.Update(DS.Tables["bien"]);

            string f = txt_nomfich.Text == "Chercher Par Nom " ? "" : "NomApparetemnt like '%" + txt_nomfich.Text + "%'";
          //  string f = txt_nomfich.Text == "" ? "" : "NomApparetemnt like '%" + txt_nomfich.Text + "%'";

            BSbien.Filter = f;
        
            }

        private void Frm_Bien1_Load(object sender, EventArgs e)
        {
            Fonctions.ouvrireConnection();
            AD = new SqlDataAdapter("select id_bien,NomApparetemnt,etage,superficie,charges,b.titrefoncier , t.nom as [type],i.nom as [immeuble],(p.nom +' '+p.prenom) as [nomComplet] ,c.consomation,c.date_controle from bien B inner join type_bien t on t.id_type=b.id_type_bien inner join conteur_eau c on c.id_conteurEau=b.id_conteurEau inner join immeuble i on i.id_immeuble=b.id_immeuble inner join proprietaire p on p.id_proprietaire= b.id_proprietaire ", CN);
            if (!DS.Tables.Contains("bien"))

                AD.Fill(DS, "bien");

            BSbien.DataSource = DS;
            BSbien.DataMember = "bien";

            gridBien.DataSource = BSbien;

        }

        private void moveFirst_Click(object sender, EventArgs e)
        {
            BSbien.MoveFirst();
        }

        private void movePrecedent_Click(object sender, EventArgs e)
        {
            BSbien.MovePrevious();
        }

        private void MoveNext_Click(object sender, EventArgs e)
        {
            BSbien.MoveNext();
        }

        private void MoveLast_Click(object sender, EventArgs e)
        {
            BSbien.MoveLast();
        }
    }
}
