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
    public partial class FrmArticleStock : Form
    {
        BindingSource bsArt;
        BindingSource bsRub;
        string sql = "select a.id_article as 'ID Article',a.designation,a.qteMinimum as 'Qte Minimum',a.qtestock as 'Qte En Stock',r.nomrubrique as 'Nom Rubrique' from article a inner join rubrique r on a.id_rubrique=r.id_rubrique where a.archive = 1";

        public FrmArticleStock()
        {
            InitializeComponent();
        }

        private void remplircombo()
        {
            bsRub = Fonctions.remplirList(cb_rubrique, "rubrique", "nomrubrique", "id_rubrique");
        }
        private void afficherpnl()
        {
            if (rd_IDdesination.Checked)
            {
                pnl_designation.Visible = true;
                pnl_rubrique.Visible = false;
            }
            else
            {
                pnl_designation.Visible = false;
                pnl_rubrique.Visible = true;
            }
        }
        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Tapez ID Article Ou Designation Pour Rechercher");
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Tapez ID Article Ou Designation Pour Rechercher");
        }

        private void FrmArticleStock_Load(object sender, EventArgs e)
        {
            bsArt = Fonctions.remplirGrille(dt_grid, sql, "article");

            dt_grid.Columns[0].Width = 100;
            dt_grid.Columns[1].Width = 180;

            remplircombo();
            afficherpnl();
        }

        private void rd_IDdesination_CheckedChanged(object sender, EventArgs e)
        {
            afficherpnl();
        }

        private void btn_chercher_rubrique_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_chercher_designation":
                    if (txt_chercher.Text == "Tapez ID Article Ou Designation Pour Rechercher")
                        bsArt.Filter = "designation like '%%'";
                    else
                    {
                        try
                        {
                            int id = Convert.ToInt32(txt_chercher.Text);
                            bsArt.Filter = "[ID Article] = " + id + "";
                        }
                        catch
                        {
                            bsArt.Filter = "designation like '%" + txt_chercher.Text + "%'";
                        }
                    }
                    break;
                case "btn_chercher_rubrique":
                    if (cb_rubrique.SelectedIndex != -1)
                        bsArt.Filter = "[Nom Rubrique] like '%" + cb_rubrique.Text + "%'";
                    break;
            }
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_derniere":
                    bsArt.MoveLast();
                    break;
                case "btn_suivant":
                    bsArt.MoveNext();
                    break;
                case "btn_precedent":
                    bsArt.MovePrevious();
                    break;
                case "btn_premier":
                    bsArt.MoveFirst();
                    break;
            }
        }

        private void btn_utiliser_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dt_grid.CurrentRow.Cells[0].Value);
            int row = dt_grid.CurrentRow.Index;

            SqlCommand cmd = new SqlCommand("update article set qtestock -=" + 5 + " where id_article = " + id, Fonctions.CnConnection());
            cmd.ExecuteNonQuery();
            Fonctions.refreshTable(sql,"article");
            bsArt.Position = row;
        }
    }
}
