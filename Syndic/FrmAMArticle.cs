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
    public partial class FrmAMArticle : Form
    {
        string lbl;
        int id;
        SqlConnection cn = Fonctions.CnConnection();
        SqlCommand cmd;
        SqlDataReader dr;
        BindingSource bsRub = new BindingSource();
        public FrmAMArticle(string lbl,int id)
        {
            InitializeComponent();
            this.lbl = lbl;
            this.id = id;
        }

        public FrmAMArticle(string lbl)
        {
            InitializeComponent();
            this.lbl = lbl;
        }

        private void pnl(bool b)
        {
            pnl_ajouter.Visible = b;
            pnl_modifier.Visible = !b;
        }

        private void FrmAMArticle_Load(object sender, EventArgs e)
        {
            lbl_titre.Text = lbl;
            bsRub = Fonctions.remplirList(cb_Rubrique, "rubrique", "nomrubrique", "id_rubrique");
            if (lbl=="Modifier Article")
            {
                cmd = new SqlCommand("select * from article where id_article = " + id, cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                txt_designation.Text = dr["designation"].ToString();
                txt_qteMinimale.Text = dr["qteMinimum"].ToString();
                txt_qteStock.Text = dr["qtestock"].ToString();
                cb_Rubrique.SelectedValue = int.Parse(dr["id_rubrique"].ToString());

                dr.Close();
                dr = null;

                pnl(false);
            }
            else pnl(true);
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_vider":
                    txt_designation.Clear();
                    txt_qteMinimale.Clear();
                    txt_qteStock.Clear();
                    cb_Rubrique.SelectedIndex = 0;
                    txt_designation.Focus();
                    break;
                case "btn_valider_ajt":
                    if (txt_designation.Text.Equals("") || txt_qteMinimale.Text.Equals("") || txt_qteStock.Text.Equals(""))
                        MessageBox.Show("Remplir Tous Les Information S'il Vous Plait.", "Remplir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        cmd = new SqlCommand("insert into article values ('" + txt_designation.Text + "'," + int.Parse(txt_qteMinimale.Text) + "," + cb_Rubrique.SelectedValue + "," + int.Parse(txt_qteStock.Text) + ",1)", cn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Article Ajouter Avec Succes.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "btn_valider_mod":
                    if (txt_designation.Text.Equals("") || txt_qteMinimale.Text.Equals("") || txt_qteStock.Text.Equals(""))
                        MessageBox.Show("Remplir Tous Les Information S'il Vous Plait.", "Remplir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        cmd = new SqlCommand("update article set designation = '" + txt_designation.Text + "' , qteMinimum = " + int.Parse(txt_qteMinimale.Text) + " , id_rubrique = " + cb_Rubrique.SelectedValue + " , qtestock = " + int.Parse(txt_qteStock.Text) + " , archive = 1 where id_article = " + id + "", cn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Article Modifier Avec Succes.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "btn_annuler_mod":
                case "btn_annuler_ajt":
                    this.Close();
                    break;
            }
        }
    }   
}
