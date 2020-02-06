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

namespace Syndic
{
    public partial class FrmFacture : Form
    {
        SqlConnection cn = Fonctions.CnConnection();
        BindingSource bsLst = new BindingSource();
        SqlCommand cmd;
        SqlDataReader dr;
        int pos = 0;
        public FrmFacture()
        {
            InitializeComponent();
        }

        private string sqlEmp(string num)
        {
            string com = "select f.id_facture,f.designation,f.date_facture,f.montant,'Employe',e.nom,t.nom," + num + " from facture f inner join type_paiement t on t.id_type = f.id_type_paiement inner join employe e on e.id_employe = f.id_employe where " + num + " is not null";

            return com;
        }

        private string sqlFrn(string num)
        {
            string com = "select f.id_facture,f.designation,f.date_facture,f.montant,'Fournisseur',fr.nom,t.nom," + num + " from facture f inner join type_paiement t on t.id_type = f.id_type_paiement inner join fournisseur fr on fr.id_fournisseur = f.id_fournisseur where " + num + " is not null";

            return com;
        }

        private void remplirdt(SqlCommand cm)
        {
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dt_facture.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDateTime(dr[2].ToString()).ToShortDateString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            dr = null;
        }
        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            if ((txt_chercher.Text != "") && (txt_chercher.Text == "Tapez Un Text Pour Rechercher"))
            {
                txt_chercher.Clear();
                txt_chercher.ForeColor = Color.Black;
            }
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            if (txt_chercher.Text == "")
            {
                txt_chercher.Text = "Tapez Un Text Pour Rechercher";
                txt_chercher.ForeColor = Color.Gray;
            }
        }

        private void FrmFacture_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand(sqlEmp("numCheque"), cn);
            remplirdt(cmd);
            cmd = new SqlCommand(sqlEmp("numVirement"), cn);
            remplirdt(cmd);
            cmd = new SqlCommand(sqlFrn("numCheque"), cn);
            remplirdt(cmd);
            cmd = new SqlCommand(sqlFrn("numVirement"), cn);
            remplirdt(cmd);

            dt_facture.Columns[0].Visible = false;
            dt_facture.Sort(dt_facture.Columns[0], ListSortDirection.Ascending);
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_derniere":
                    pos = dt_facture.Rows.Count - 1;
                    dt_facture.Rows[pos].Cells[1].Selected = true;
                    break;
                case "btn_premiere":
                    pos = 0;
                    dt_facture.Rows[pos].Cells[1].Selected = true;
                    break;
                case "btn_suivant":
                    if (pos != (dt_facture.Rows.Count - 1))
                    {
                        pos++;
                        dt_facture.Rows[pos].Cells[1].Selected = true;
                    }
                    break;
                case "btn_precedent":
                    if (dt_facture.CurrentRow.Index != 0)
                    {
                        pos--;
                        dt_facture.Rows[pos].Cells[1].Selected = true;
                    }
                    break;
            }
        }
    }
}
