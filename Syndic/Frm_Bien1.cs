
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Syndic
{
    public partial class Frm_Bien1 : Form
    {

        BindingSource bsBien;
        BindingSource bsType;
        BindingSource bsimmeub;
        BindingSource bsProp;
        // BindingSource bscon;
        

        int pos = 0;
        public Frm_Bien1()
        {
            InitializeComponent();
        }

        private void activer(bool b)
        {
            grp_bien.Enabled = b;
            grp_information.Enabled = !b;

            btn_ajouter.Visible = b;
            btn_modifier.Visible = b;
            btn_supprimer.Visible = b;

            btn_valider.Visible = !b;
            btn_annuler.Visible = !b;

           // btn_ajouter.Enabled = b;
        }

        private void remplirEmps()
        {
            string sql = "select b.* ,c.consomation,c.date_controle, (p.prenom+' '+p.nom) as nomcomplete from bien b inner join proprietaire p on p.id_proprietaire=b.id_proprietaire inner join conteur_eau c on c.id_conteurEau=b.id_conteurEau where b.archive = 1";
            bsBien = Fonctions.remplirList(lst_bien, sql, "bien", "NomApparetemnt", "id_bien");

            txt_id.DataBindings.Clear();
            txt_nom.DataBindings.Clear();
            txt_etage.DataBindings.Clear();
            txt_super.DataBindings.Clear();
            txt_charge.DataBindings.Clear();
            txt_foncier.DataBindings.Clear();
            txt_archive.DataBindings.Clear();
            txt_consomation.DataBindings.Clear();
            dt_date.DataBindings.Clear();

            txt_id.DataBindings.Add("Text", bsBien, "id_bien");
            txt_nom.DataBindings.Add("Text", bsBien, "NomApparetemnt");
            txt_etage.DataBindings.Add("Text", bsBien, "etage");
            txt_super.DataBindings.Add("Text", bsBien, "superficie");
            txt_charge.DataBindings.Add("Text", bsBien, "charges");
            txt_foncier.DataBindings.Add("Text", bsBien, "titrefoncier");

           txt_consomation.DataBindings.Add("text", bsBien, "consomation");
            dt_date.DataBindings.Add("text", bsBien, "date_controle");
          

            txt_archive.DataBindings.Add("Text", bsBien, "archive");

            cb_type.DataBindings.Clear();
            cb_immeuble.DataBindings.Clear();
            cb_prop.DataBindings.Clear();

            bsType = Fonctions.remplirList(cb_type, "type_bien", "nom", "id_type");
            cb_type.DataBindings.Add("SelectedValue", bsBien, "id_type_bien");

            bsimmeub = Fonctions.remplirList(cb_immeuble, "immeuble", "nom", "id_immeuble");
            cb_immeuble.DataBindings.Add("SelectedValue", bsBien, "id_immeuble");

            bsProp = Fonctions.remplirList(cb_prop, "proprietaire", "nomcomplete", "id_proprietaire");
            cb_prop.DataBindings.Add("SelectedValue", bsBien, "id_proprietaire");


        }
        private void afficherpnl()
        {
            if (rd_nomPrenom.Checked)
            {
                pnl_nom.Visible = true;
                pnl_im.Visible = false;
            }
            else
            {
                pnl_nom.Visible = false;
                pnl_im.Visible = true;
            }
        }

        private void Frm_Bien1_Load(object sender, EventArgs e)
        {
            remplirEmps();
            activer(true);
            afficherpnl();
        }

        private void btn_supprimer_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_ajouter":
                    pos = lst_bien.Items.Count;
                    bsBien.AddNew();
                    txt_consomation.Enabled = false;
                    dt_date.Enabled = false;


                    txt_archive.Text = "true";
                    activer(false);
                    break;
                case "btn_modifier":
                    activer(false);
                    break;
                case "btn_supprimer":
                    if (lst_bien.Items.Count > 0)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Voulez-vous Vraiment Supprimer Cette Bien ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            pos = lst_bien.SelectedIndex - 1;
                            txt_archive.Text = "False";
                            bsBien.EndEdit();
                            Fonctions.syncr("bien", Fonctions.CnConnection(), Fonctions.ds);
                            remplirEmps();

                            lst_bien.SelectedIndex = pos;
                        }
                    }
                    break;
                case "btn_valider":
                    bsBien.EndEdit();
                    Fonctions.syncr("bien", Fonctions.CnConnection(), Fonctions.ds);
                    remplirEmps();
                    lst_bien.SelectedIndex = pos;
                    activer(true);
                    break;
                case "btn_annuler":
                    bsBien.CancelEdit();
                    activer(true);
                    break;
            }
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_derniere":
                    bsBien.MoveLast();
                    break;
                case "btn_suivant":
                    bsBien.MoveNext();
                    break;
                case "btn_premiere":
                    bsBien.MoveFirst();
                    break;
                case "btn_precedent":
                    bsBien.MovePrevious();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Bien_Type f = new Frm_Bien_Type("Modifier",pos);
            f.ShowDialog();
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            Fonctions.textHintLeave(txt_chercher, "Taper un Nom Pour Chercher");
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            Fonctions.textHintEntre(txt_chercher, "Taper un Nom Pour Chercher");
        }

        private void btn_chercherType_Click(object sender, EventArgs e)
        {
           
        }

        private void rd_type_Click(object sender, EventArgs e)
        {
            //pnlAfficher();
        }

        private void rd_type_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f = txt_chercher.Text == "Taper un Nom Pour Chercher" ? "" : "NomApparetemnt like '%" + txt_chercher.Text + "%'";
            bsBien.Filter = f;
        }

        private void rd_type_CheckedChanged_2(object sender, EventArgs e)
        {
            afficherpnl();
        }
    }
}