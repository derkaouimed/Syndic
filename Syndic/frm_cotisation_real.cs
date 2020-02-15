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
    public partial class frm_cotisation_real : Form
    {
        BindingSource bsProp = new BindingSource();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlConnection cn = new SqlConnection();


        public frm_cotisation_real()
        {
            InitializeComponent();
        }

        private void btn_Recette_Ajouter_Click(object sender, EventArgs e)
        {

        }

        private void frm_cotisation_real_Load(object sender, EventArgs e)
        {
            
            ds.Tables.Clear();
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                cn.Open();
            }
            da = new SqlDataAdapter("Select id_cotisation as [NumCotisation],date_cotisation as Date,montant as Montant,id_proprietaire as Proprietaire,id_typeCotisation as Type from cotisation where archive =1", cn);
            if (!ds.Tables.Contains("cotisation"))
               da.Fill(ds, "cotisation");

            bsProp.DataSource = ds;
            bsProp.DataMember = "cotisation";

            dataGridView1.DataSource = bsProp;

        }
    }
}
