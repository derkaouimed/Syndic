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
    public partial class FrmAMAchat : Form
    {
        BindingSource bsart;
        BindingSource bsfact;
        SqlCommand cmd;
        SqlDataReader dr;
        string lbl;
        int ida, idf;
        public FrmAMAchat(string lbl,int ida,int idf)
        {
            InitializeComponent();
            this.lbl = lbl;
            this.ida = ida;
            this.idf = idf;
        }

        private void pnl(bool b)
        {
            pnl_ajouter.Visible = b;
            pnl_modifier.Visible = !b;
        }
        public FrmAMAchat(string lbl)
        {
            InitializeComponent();
            this.lbl = lbl;
        }

        private void FrmAMAchat_Load(object sender, EventArgs e)
        {
            lbl_titre.Text = lbl;
            bsart = Fonctions.remplirList(cb_article, "article", "designation", "id_article");
            bsfact = Fonctions.remplirList(cb_facture, "facture", "designation", "id_facture");

            if (lbl == "Modifier Achat")
            {
                pnl(false);
                cmd = new SqlCommand("select * from achat where (id_article = " + ida + " and id_facture = " + idf + ")", Fonctions.CnConnection());
                dr = cmd.ExecuteReader();
                dr.Read();
                cb_article.SelectedValue = int.Parse(dr["id_article"].ToString());
                cb_facture.SelectedValue = int.Parse(dr["id_facture"].ToString());
                txt_qteachat.Text = dr["qteAchat"].ToString();
                txt_prix.Text = dr["prix"].ToString();
            }
        }
        private void btn_vider_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_vider":
                    cb_article.SelectedIndex = 0;
                    cb_facture.SelectedIndex = 0;
                    txt_prix.Clear();
                    txt_qteachat.Clear();
                    txt_prix.Focus();
                    break;
                case "btn_valider_ajt":
                    if(txt_prix.Text.Equals("") || txt_qteachat.Text.Equals(""))
                        MessageBox.Show("Remplier Tous Les Informations S'il Vous Plait.", "Remplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    else
                    {
                        cmd = new SqlCommand("insert into achat values (" + cb_article.SelectedValue + "," + cb_facture.SelectedValue + "," + int.Parse(txt_qteachat.Text) + "," + float.Parse(txt_prix.Text) + ",1)", Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Achat Ajouter Avec Succes.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "btn_valider_mod":
                    if (txt_prix.Text.Equals("") || txt_qteachat.Text.Equals(""))
                        MessageBox.Show("Remplier Tous Les Informations S'il Vous Plait.", "Remplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    else
                    {
                        cmd = new SqlCommand("update achat set id_article = " + cb_article.SelectedValue + ", id_facture = " + cb_facture.SelectedValue + " , qteAchat = " + int.Parse(txt_qteachat.Text) + ", prix = " + float.Parse(txt_prix.Text) + ", archive = 1 where (id_article = " + ida + " and id_facture = " + idf + ")", Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Achat Ajouter Avec Succes.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "btn_annuler_ajt":
                case "btn_annuler_mod":
                    this.Close();
                    break;
            }
        }
        
    }
}
