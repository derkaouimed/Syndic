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
      
        private void btn_Bien_rem_Supprimer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_Bien_rem_Ajouter":
                    Frm_Bien_remarque_aj f = new Frm_Bien_remarque_aj("Ajouter",0);
                    f.ShowDialog();

                    break;
                case "btn_Bien_rem_modifier":
                    Frm_Bien_remarque_aj ff = new Frm_Bien_remarque_aj("Modifier", int.Parse(grid_bien_rem.CurrentRow.Cells[0].ToString()));
                    ff.ShowDialog();

                    break;
                case "btn_Bien_rem_Supprimer":
                    DialogResult d = MessageBox.Show("Supprerimer", "Voulez Vous Supprime ce remarque ?", MessageBoxButtons.OK);
                    if (DialogResult.OK == d)
                    {
                       

                        SqlCommand com = new SqlCommand("Update remarque_bien set archive = 0 where id_remarque = " + int.Parse(grid_bien_rem.CurrentRow.Cells[0].Value.ToString()), CN);
                        int a = 0;
                        a = com.ExecuteNonQuery();
                        if (a != 0)
                        {
                            MessageBox.Show("Supprimer !!");

                            grid_bien_rem.Rows.RemoveAt(grid_bien_rem.CurrentRow.Index);

                        }

                        else
                            MessageBox.Show("Error de Supprimer !!");

                    }

                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder com = new SqlCommandBuilder(AD);
            AD.Update(DS.Tables["remarque_bien"]);

            string f = txt_nomfich.Text == "" ? "" : "nom like '%" + txt_nomfich.Text + "%'";


            BSbien.Filter = f;
        }

        private void grp_fichier_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_Bien_Remarque_Load(object sender, EventArgs e)
        {

            Fonctions.ouvrireConnection();
            AD = new SqlDataAdapter("select nom,remarque , b.NomApparetemnt from remarque_bien d inner join bien b on b.id_bien=d.id_bien ", CN);
            if (!DS.Tables.Contains("remarque_bien"))

                AD.Fill(DS, "remarque_bien");

            BSbien.DataSource = DS;
            BSbien.DataMember = "remarque_bien";

            grid_bien_rem.DataSource = BSbien;
        }
    }
}
