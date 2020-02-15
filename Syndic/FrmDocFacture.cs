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
    public partial class FrmDocFacture : Form
    {
        BindingSource bsFact;
        SqlCommand cmd;
        SqlDataReader dr;
        public FrmDocFacture()
        {
            InitializeComponent();
        }

        private void remplirDoc()
        {
            if (lst_factures.Items.Count > 0)
            {
                int pos=0;
                lst_documents.Items.Clear();
                try
                { pos = Convert.ToInt32(lst_factures.SelectedValue);}catch { }
                
                cmd = new SqlCommand("select * from document_facture where id_facture = " + pos, Fonctions.CnConnection());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lst_documents.Items.Add(dr["nom"].ToString());
                }
                dr.Close();
                dr = null;
            }
        }
        private void FrmDocFacture_Load(object sender, EventArgs e)
        {
            bsFact = Fonctions.remplirList(lst_factures, "Facture", "designation", "id_facture");
            remplirDoc();
        }

        private void txt_chercher_Fact_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher_Fact, "Tapez Designation Pour Chercher");
        }

        private void txt_chercher_Fact_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher_Fact, "Tapez Designation Pour Chercher");
        }

        private void txt_chercher_doc_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher_doc, "Tapez Un Nom De Document Pour Chercher");
        }

        private void txt_chercher_doc_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher_doc, "Tapez Un Nom De Document Pour Chercher");
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_premiere":
                    bsFact.MoveFirst();
                    break;
                case "btn_derniere":
                    bsFact.MoveLast();
                    break;
                case "btn_precedent":
                    bsFact.MovePrevious();
                    break;
                case "btn_suivant":
                    bsFact.MoveNext();
                    break;
            }
        }

        private void lst_factures_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirDoc();
        }
    }
}
