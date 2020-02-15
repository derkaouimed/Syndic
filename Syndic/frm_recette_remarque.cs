using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic
{
    public partial class frm_recette_remarque : Form
    {

        BindingSource bsProp = new BindingSource();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlConnection cn = new SqlConnection();

        public frm_recette_remarque()
        {
            InitializeComponent();
        }
     
        private void btn_RecetteRemarque_Supprimer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_RecetteRemarque_Ajouter":
                    frm_recette_remarque_info f = new frm_recette_remarque_info("Ajouter");
                    f.ShowDialog();
                  
                    break;
                case "btn_RecetteRemarque_modifier":
                    frm_recette_remarque_info ff = new frm_recette_remarque_info("Modifier", int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    ff.ShowDialog();

                    break;
                case "btn_RecetteRemarque_Supprimer":
                    DialogResult d = MessageBox.Show("Voules Vous Supprime Ce Remarque ?", "Suppresion", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == d)
                    {

                        SqlCommand com4 = new SqlCommand("Update remarque_recette set archive = 0 where id_remarque = " + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), cn);
                        int a = 0;
                        a = com4.ExecuteNonQuery();
                        if (a != 0)
                        {
                            MessageBox.Show("Removed !!");
                            ///////////////////

                            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                        }

                        else
                            MessageBox.Show("Error in removing !!");

                    }

                    break;
              

            }
        }

        private void frm_recette_remarque_Load(object sender, EventArgs e)
        {
            txt_search = MyHint.LoadText(txt_search, "Le Nom de Remarque");

            /////////


            ds.Tables.Clear();
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                cn.Open();
            }
            da = new SqlDataAdapter("Select id_remarque as [NumRemarque],nomRemarqur as Nom,remarque as Remarque,d.id_recette as Recette from remarque_recette d inner join recette r on d.id_recette = r.id_recette where d.archive = 1", cn);
            if (!ds.Tables.Contains("remarque"))

                da.Fill(ds, "remarque");

            bsProp.DataSource = ds;
            bsProp.DataMember = "remarque";

            dataGridView1.DataSource = bsProp;

        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            txt_search = MyHint.HintLeave(txt_search, "Le Nom de Remarque");
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search = MyHint.HintEnter(txt_search, "Le Nom de Remarque");
        }
        SqlCommandBuilder commande;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_search.Text.Equals("Taper Le Nom de Remarque pour rechercher") || txt_search.Text == "")
            {
                commande = new SqlCommandBuilder(da);
                da.Update(ds.Tables["remarque"]);
                bsProp.DataSource = ds;
                bsProp.DataMember = "remarque";
                dataGridView1.DataSource = bsProp;

            }
            else
            {
                String se = txt_search.Text.Replace("'", " ");
                if (txt_search.Text.Equals("Taper Le Nom de Remarque pour rechercher"))
                {
                    bsProp.DataSource = ds;
                    bsProp.DataMember = "remarque";
                    dataGridView1.DataSource = bsProp;

                }
                else
                {
                    bsProp.Filter = "Nom like '%" + se + "%'";

                }
            }
        }

        private void btn_Recette_Annuler_Click(object sender, EventArgs e)
        {
            bsProp.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bsProp.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bsProp.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bsProp.MoveLast();
        }
    }
}
