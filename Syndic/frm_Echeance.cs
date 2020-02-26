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
    public partial class frm_Echeance : Form
    {

        SqlDataReader reader;
        SqlConnection cn;
        SqlCommand com;
        string sql;


        public frm_Echeance()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void frm_Echeance_Load(object sender, EventArgs e)
        {
            txt_search = MyHint.LoadText(txt_search,"Nom de bien");
            //code
            Fonctions.ouvrireConnection();
            cn = Fonctions.CnConnection();

            ////les annee

            sql = "Select id_echeance,mois,annee,montant,montant_recu,NomApparetemnt from echeance e inner join Bien b on b.id_bien = e.id_bien ";

            com = new SqlCommand(sql, cn);

            reader = com.ExecuteReader();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Mois";
            dataGridView1.Columns[2].Name = "Anne";
            dataGridView1.Columns[3].Name = "Montant";
            dataGridView1.Columns[4].Name = "Montant Recu";
            dataGridView1.Columns[5].Name = "Bien";

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());

            }
          



        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            txt_search = MyHint.HintLeave(txt_search, "Nom de bien");
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search = MyHint.HintEnter(txt_search, "Nom de bien");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
