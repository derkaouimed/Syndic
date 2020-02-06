using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Syndic
{
    public partial class frm_Proprietaire : Form
    {
        DataSet ds = new DataSet();
        BindingSource bsProp = new BindingSource();
        SqlDataAdapter da;
        SqlConnection cn = new SqlConnection();



        public frm_Proprietaire()
        {
            InitializeComponent();
        }

        private void btn_Proprietaire_Supprimer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_Proprietaire_Ajouter":

                    Frm_Propietaire_Information f = new Frm_Propietaire_Information("Ajouter",int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    f.ShowDialog();

                    //LesButton(false);
                    break;
                case "btn_Proprietaire_Modifier":
                    Frm_Propietaire_Information ff = new Frm_Propietaire_Information("Modifier", int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    ff.ShowDialog();
                    //LesButton(false);
                    break;
                case "btn_Proprietaire_Supprimer":
                    DialogResult d = MessageBox.Show("Suppresion","Voules Vous Supprime Ce Propietaire ?",MessageBoxButtons.OK);
                    if (DialogResult.OK == d)
                    {
                        SqlDataReader dr;
                        SqlCommand com = new SqlCommand("Update Proprietaire set archive = 0 where id_Proprietaire = "+int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), cn);
                        int a = 0;
                        a = com.ExecuteNonQuery();
                        if (a != 0)
                        {
                            MessageBox.Show("Removed !!");

                            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                        }

                        else
                            MessageBox.Show("Error in removing !!");

                        //////////////
                      




                        /////
                    }
                    //LesButton(false);
                    break;
           
            }

        }
        public void LesButton(bool b)
        {
            btn_Proprietaire_Ajouter.Visible = b;
            btn_Proprietaire_Modifier.Visible = b;
            btn_Proprietaire_Supprimer.Visible = b;
        
        }

        private void frm_Proprietaire_Load(object sender, EventArgs e)
        {
            
            txt_search = MyHint.LoadText(txt_search, "Nom & Prenom de Proprietaire");
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                cn.Open();
            }
            da = new SqlDataAdapter("Select id_Proprietaire as Num,nom as Nom,prenom as Prenom,adresse as Adresse,code_postale as 'Code Postal',telephone as Telephone,email as Email,nom_ville as Ville from Proprietaire p inner join ville v on v.id_ville = p.id_ville where archive = 1", cn);
            da.Fill(ds, "Proprietaire");

            //ds.Tables["Proprietaire"].Columns.RemoveAt(0);

            bsProp.DataSource = ds;
            bsProp.DataMember = "Proprietaire";
       
            dataGridView1.DataSource = bsProp;





        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_first":
                    bsProp.MoveFirst();
                    // groupBox1.Visible = true;
                    //LesButton(false);
                    break;
                case "btn_Last":
                    bsProp.MoveLast();
                    //LesButton(false);
                    break;
                case "btn_next":
                    bsProp.MoveNext();
                    //LesButton(false);
                    break;
                case "btn_previous":
                    bsProp.MovePrevious();
                    //LesButton(true);

                    break;
            }
         }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            s =  dataGridView1.Rows[0].Cells[0].Value.ToString();
            if (txt_search.Text.Equals("Taper Nom & Prenom de Proprietaire pour rechercher") && txt_search.Text == "" && s=="")
            {
                bsProp.DataSource = ds;
                bsProp.DataMember = "Proprietaire";
                dataGridView1.DataSource = bsProp;
            }
            else {
                String se = txt_search.Text.Replace("'", " ");
                if (txt_search.Text.Equals("Taper Nom & Prenom de Proprietaire pour rechercher"))
                {
                    bsProp.DataSource = ds;
                    bsProp.DataMember = "Proprietaire";
                    dataGridView1.DataSource = bsProp;

                }
                else
                {
                    bsProp.Filter = "nom like '%" + se + "%' or prenom like '%" + se + "%'";

                }
            }
           
            
          
           
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            txt_search = MyHint.HintLeave(txt_search, "Nom & Prenom de Proprietaire");
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search = MyHint.HintEnter(txt_search, "Nom & Prenom de Proprietaire");
        }
        
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
