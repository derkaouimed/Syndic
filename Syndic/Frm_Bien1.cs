﻿
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

        SqlCommand comT;
        SqlCommand comI;
        SqlCommand comP;
        SqlDataReader DRI;
        SqlDataReader DRT;
        SqlDataReader DRP;
        // BindingSource bscon;

        SqlCommand cmd;
        SqlDataReader dr;


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

        private void rempliBien()
        {
           
            string sql = "select b.* ,c.consomation,c.date_controle, c.id_conteurEau, p.prenom+''+p.nom as [nomcomplete] from bien b inner join proprietaire p on p.id_proprietaire=b.id_proprietaire inner join conteur_eau c on c.id_conteurEau=b.id_conteurEau where b.archive = 1";
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

           // txtid_conteurEau.DataBindings.Add("Text", bsBien, "id_conteurEau");

            txt_consomation.DataBindings.Add("text", bsBien, "consomation");
            dt_date.DataBindings.Add("text", bsBien, "date_controle");
          

            txt_archive.DataBindings.Add("Text", bsBien, "archive");

            cb_type.DataBindings.Clear();
            cb_immeuble.DataBindings.Clear();
            cb_prop.DataBindings.Clear();

           // bsconteur = Fonctions.remplirList(cb_type, "conteur_eau", "consomation", "id_conteurEau");

            bsType = Fonctions.remplirList(cb_type, "type_bien", "nom", "id_type");
            cb_type.DataBindings.Add("SelectedValue", bsBien, "id_type_bien");

            bsimmeub = Fonctions.remplirList(cb_immeuble, "immeuble", "nom", "id_immeuble");
            cb_immeuble.DataBindings.Add("SelectedValue", bsBien, "id_immeuble");

            bsProp = Fonctions.remplirList(cb_prop, "proprietaire", "nomcomplet", "id_proprietaire");
            cb_prop.DataBindings.Add("SelectedValue", bsBien, "id_proprietaire");

        }
       

        private void Frm_Bien1_Load(object sender, EventArgs e)
        {
            rempliBien();
            activer(true);
            
        }
        private void Affiche()
        {
            if (rd_nom.Checked)
            {
               // pnl_im.Visible = false;
                pnl_nom.Visible = true;
            }
            else
            {
             //   pnl_im.Visible = true;
                pnl_nom.Visible = false;
                cm_et.Items.Clear();
                cmd = new SqlCommand("select etage from bien", Fonctions.CnConnection());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cm_et.Items.Add(dr[0].ToString());
                }
                dr.Close();
                dr = null;
               


                cm_ch_im.Items.Clear();
                cmd = new SqlCommand("select nom from immeuble", Fonctions.CnConnection());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cm_ch_im.Items.Add(dr[0].ToString());
                }
                dr.Close();
                dr = null;
               
            }

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
                    label12.Text = "0";


                    txt_archive.Text = "true";
                    activer(false);
                    break;
                case "btn_modifier":
                    activer(false);
                    label12.Text = "1";
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
                            rempliBien();

                            lst_bien.SelectedIndex = pos;
                        }
                    }
                    break;
                case "btn_valider":
                    if (label12.Text =="0")
                    {
                        comT = new SqlCommand("Select id_type from type_bien where nom like '" + cb_type.Text + "'", Fonctions.CnConnection());
                        DRT = comT.ExecuteReader();
                        DRT.Read();
                        int T = int.Parse(DRT[0].ToString());

                        comT = null;
                        DRT.Close();

                        comI = new SqlCommand("Select id_immeuble from immeuble where nom like '" + cb_immeuble.Text + "'", Fonctions.CnConnection());
                        DRI = comI.ExecuteReader();
                        DRI.Read();

                        int I = int.Parse(DRI[0].ToString());

                        comI = null;
                        DRI.Close();

                        comP = new SqlCommand("Select id_proprietaire from Proprietaire where id_proprietaire  like'" + cb_prop.Text + "'", Fonctions.CnConnection());
                        DRP = comP.ExecuteReader();
                        DRP.Read();
                        int P = int.Parse(DRP[0].ToString());


                        comP = null;
                        DRP.Close();

                        SqlCommand cm = new SqlCommand("Select max(id_conteurEau) from conteur_eau", Fonctions.CnConnection());
                        txtid_conteurEau.Text = cm.ExecuteScalar().ToString();

                        SqlCommand com = new SqlCommand("insert into conteur_eau (archive) values (1)"
                       + " insert into bien values( '" + txt_nom.Text + "' , '"
                       + txt_etage.Text + "' , '" + txt_super.Text + "' , '"
                       + txt_charge.Text + "' , '" + I + "' , '" + T + "' ,  '" + P + "' , '"
                       + txt_foncier.Text + "' , '" + txtid_conteurEau.Text + "' ,'1')", Fonctions.CnConnection());
                        bsBien.EndEdit();
                        Fonctions.syncr("bien", Fonctions.CnConnection(), Fonctions.ds);
                        Fonctions.syncr("conteur_eau", Fonctions.CnConnection(), Fonctions.ds);
                        rempliBien();
                       // lst_bien.SelectedIndex = pos;
                        activer(true);
                    }

                    else
                    {
                        comT = new SqlCommand("Select id_type from type_bien where nom like '" + cb_type.Text + "'", Fonctions.CnConnection());
                        DRT = comT.ExecuteReader();
                        DRT.Read();
                        int T = int.Parse(DRT[0].ToString());

                        comT = null;
                        DRT.Close();

                        comI = new SqlCommand("Select id_immeuble from immeuble where nom like '" + cb_immeuble.Text + "'", Fonctions.CnConnection());
                        DRI = comI.ExecuteReader();
                        DRI.Read();

                        int I = int.Parse(DRI[0].ToString());

                        comI = null;
                        DRI.Close();

                        comP = new SqlCommand("Select id_proprietaire from Proprietaire where id_proprietaire  like'" + cb_prop.Text + "'", Fonctions.CnConnection());
                        DRP = comP.ExecuteReader();
                        DRP.Read();
                        int P = int.Parse(DRP[0].ToString());


                        comP = null;
                        DRP.Close();

                        SqlCommand com = new SqlCommand("update conteur_eau set consomation ='"+ txt_consomation.Text+ "',date_controle ='"+dt_date.Text +"where id_conteur = "+txtid_conteurEau
                            + "update bien set NomApparetemnt = '" + txt_nom.Text + "',etage = '"
                   + txt_etage.Text + "',superficie = '" + txt_super.Text
                   + "',charges = '" + txt_charge.Text + "' ,id_immeuble = '" + I + "',id_type_bien = '"
                   + T + "',id_proprietaire =' " + P + "',titrefoncier = '" + txt_foncier.Text+ "where id_bien = "+txt_id, Fonctions.CnConnection());

                     bsBien.EndEdit();
                        rempliBien();
                        lst_bien.SelectedIndex = pos;
                        activer(true);
                    }
                   

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
            if (cm_ch_im.SelectedIndex == -1 || cm_et.SelectedIndex== -1 )
                MessageBox.Show("select un type et un etage s'il vous plaît.", "Type Est Vide", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                cmd = new SqlCommand("select * from  bien b inner join immeuble i on i.id_immeuble=b.id_immeuble where b.archive = 1 and  b.etage = '" + cm_et.Text + "' and i.nom = '" + cm_ch_im.Text + "'", Fonctions.CnConnection());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lst_bien.Items.Add(dr["NomApparetemnt"].ToString());
                    lst_bien.Sorted = true;
                }
                dr.Close();
                dr = null;
                // lst_bien.Sort(lst_bien,);
                if (lst_bien.Items.Count > 0)
                    lst_bien.SelectedValue = true;



            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string f = txt_chercher.Text == "Taper un Nom Pour Chercher" ? "" : "NomApparetemnt like '%" + txt_chercher.Text + "%'";
            bsBien.Filter = f;
        }

        private void rd_immeu_CheckedChanged(object sender, EventArgs e)
        {
            Affiche();
        }

        private void lst_bien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}