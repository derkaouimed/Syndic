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
        BindingSource bsbien;
        BindingSource bsRem;
        SqlCommand cmd=new SqlCommand();
        bool ajt = false;

        public Frm_Bien_Remarque()
        {
            InitializeComponent();
        }
        private void activier(bool b)
        {
            grp_bien.Enabled = b;
            grp_remarque.Enabled = b;
            grp_details.Enabled = !b;
            btn_ajouter.Enabled = b;
            if (b)
            {
                btn_modifier.Text = "Modifier";
                btn_supprimer.Text = "Supprimer";
            }
            else
            {
                btn_modifier.Text = "Valider";
                btn_supprimer.Text = "Annuler";
            }
        }

        private void remplirLst()
        {
            int pos = 0;
            if (cb_bien.Items.Count > 0)
            {
                try
                {
                    pos = Convert.ToInt32(cb_bien.SelectedValue);
                }
                catch { }
               
            }
            string sql = "select * from remarque_bien where id_bien = "+ pos;
            bsRem = Fonctions.remplirList(lst_Remaques, sql, "remarque_bien", "nom", "id_remarque");

            txt_nomremarque.DataBindings.Clear();
            txt_remarque.DataBindings.Clear();

            txt_nomremarque.DataBindings.Add("Text", bsRem, "nom");
            txt_remarque.DataBindings.Add("Text", bsRem, "remarque");
        }



        private void btn_derniere_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Bien_Remarque_Load(object sender, EventArgs e)
        {
            bsbien = Fonctions.remplirList(cb_bien, "bien", "NomApparetemnt", "id_bien");

            remplirLst();

            activier(true);
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "Ajouter":
                    activier(false);
                    ajt = true;
                    txt_nomremarque.Clear();
                    txt_remarque.Clear();
                    break;
                case "Modifier":
                    activier(false);
                    ajt = false;
                    break;
                case "Supprimer":
                    if (lst_Remaques.Items.Count > 0)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Voulez-vous Vraiment Supprimer Cette Remarque ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            cmd = new SqlCommand("delete from remarque_bien where id_remaque = " + lst_Remaques.SelectedValue + "", Fonctions.CnConnection());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Remarque Supprimer Avec Succces.", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            remplirLst();
                        }
                    }
                    break;
                case "Valider":
                    if (ajt)
                    {
                        cmd = new SqlCommand("insert into remarque_bien values ('" + txt_nomremarque.Text + "','" + txt_remarque.Text + "','" + cb_bien.SelectedValue +"','1')", Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Remarque Ajouter Avec Succces.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        remplirLst();
                    }
                    else
                    {
                        if (lst_Remaques.Items.Count > 0)
                        {
                            cmd = new SqlCommand("update remarque_bien set nom = '" + txt_nomremarque.Text + "' , remarque = '" + txt_remarque.Text + "' where id_remaque = " + lst_Remaques.SelectedValue + "", Fonctions.CnConnection());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Remarque Modifier Avec Succces.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            remplirLst();
                        }
                    }
                    activier(true);
                    break;
                case "Annuler":
                    activier(true);
                    break;
            }
        
    }

        private void grp_details_Enter(object sender, EventArgs e)
        {

        }

        private void txt_chercher_TextChanged(object sender, EventArgs e)
        {
            string f = txt_chercher.Text == "Tapez Nom Pour Chercher" ? "" : "nom like '%" + txt_chercher.Text + "%'";


            bsRem.Filter = f;
        }

        private void lst_Remaques_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Tapez Nom Pour Chercher");
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Tapez Nom Pour Chercher");
        }

        private void cb_bien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bsRem.Filter = "id_bien = " + cb_bien.SelectedValue;
            remplirLst();
        }
    }
}
