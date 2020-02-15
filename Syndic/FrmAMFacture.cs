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
    public partial class FrmAMFacture : Form
    {
        string filter;
        string id;
        SqlCommand cmd;
        SqlDataReader dr;
        BindingSource bsFr = new BindingSource();
        BindingSource bsEM = new BindingSource();
        public FrmAMFacture(string filter,string id="")
        {
            InitializeComponent();
            this.filter = filter;
            this.id = id;
        }

        private void Activie(bool b)
        {
            pnl_ajouter.Visible = b;
            pnl_modifier.Visible = !b;

            cb_type.Items.Add("Fournisseur");
            cb_type.Items.Add("Employe");
            cb_type.SelectedIndex = 0;

            cb_paiment.Items.Add("Chique");
            cb_paiment.Items.Add("Virement");
            cb_paiment.SelectedIndex = 0;
        }
        private void FrmAMFacture_Load(object sender, EventArgs e)
        {
            lbl_titre.Text = filter;
            if(filter=="Ajouter Facture")
            {
                Activie(true);
            }
            else
            {
                Activie(false);
                cmd = new SqlCommand("Select * from facture where id_facture = " + int.Parse(id), Fonctions.CnConnection());
                dr = cmd.ExecuteReader();
                dr.Read();

                if (dr["id_fournisseur"].ToString() != "")
                {
                    txt_designation.Text = dr["designation"].ToString();
                    dt_date.Text = dr["date_facture"].ToString();
                    txt_montant.Text = dr["montant"].ToString();
                    cb_type.SelectedIndex = 0;
                    cb_nom.SelectedValue = int.Parse(dr["id_fournisseur"].ToString());
                    if (int.Parse(dr["id_type_paiement"].ToString()) == 1)
                    {
                        cb_paiment.SelectedIndex = 0;
                        txt_numero.Text = dr["numCheque"].ToString();
                    }
                    else
                    {
                        cb_paiment.SelectedIndex = 1;
                        txt_numero.Text = dr["numVirement"].ToString();
                    }
                }
                else
                {
                    txt_designation.Text = dr["designation"].ToString();
                    dt_date.Text = dr["date_facture"].ToString();
                    txt_montant.Text = dr["montant"].ToString();
                    cb_type.SelectedIndex = 1;
                    cb_nom.SelectedValue = int.Parse(dr["id_employe"].ToString());
                    if (int.Parse(dr["id_type_paiement"].ToString()) == 1)
                    {
                        cb_paiment.SelectedIndex = 0;
                        txt_numero.Text = dr["numCheque"].ToString();
                    }
                    else if (int.Parse(dr["id_type_paiement"].ToString()) == 2)
                    {
                        cb_paiment.SelectedIndex = 1;
                        txt_numero.Text = dr["numVirement"].ToString();
                    }
                }
                
                dr.Close();
                dr = null;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_type.Text == "Fournisseur")
            {
                string sql = "Select id_fournisseur,concat('[',ice,'] - ',prenom,' ',nom) as nomCP from fournisseur where archive = 1";
                bsFr = Fonctions.remplirList(cb_nom, sql, "fournisseur", "nomCP", "id_fournisseur");
            }
            else
            {
                string sql = "Select id_employe,concat(id_employe,' - ',prenom,' ',nom) as nomCP from employe where archive = 1";
                bsFr = Fonctions.remplirList(cb_nom, sql, "employe", "nomCP", "id_employe");
            }
        }

        private void cb_paiment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_paiment.Text == "Chique")
                lbl_paiment.Text = "Numero De Chique :";
            else
                lbl_paiment.Text = "Numero De Virement :";

        }

        private void insertFN(string type,int idt,int paim)
        {
            if (type == "Fournisseur")
            {
                if (paim == 1)
                    cmd = new SqlCommand("insert into facture (designation,date_facture,montant,id_fournisseur,id_type_paiement,numCheque,archive) values ('" + txt_designation.Text + "','" + dt_date.Value.ToShortDateString() + "','" + txt_montant.Text + "'," + idt + "," + paim + "," + txt_numero.Text + ",1)", Fonctions.CnConnection());
                else
                    cmd = new SqlCommand("insert into facture (designation,date_facture,montant,id_fournisseur,id_type_paiement,numVirement,archive) values ('" + txt_designation.Text + "','" + dt_date.Value.ToShortDateString() + "','" + txt_montant.Text + "'," + idt + "," + paim + "," + txt_numero.Text + ",1)", Fonctions.CnConnection());
            }
            else
            {
                if (paim == 1)
                    cmd = new SqlCommand("insert into facture (designation,date_facture,montant,id_employe,id_type_paiement,numCheque,archive) values ('" + txt_designation.Text + "','" + dt_date.Value.ToShortDateString() + "','" + txt_montant.Text + "'," + idt + "," + paim + "," + txt_numero.Text + ",1)", Fonctions.CnConnection());
                else
                    cmd = new SqlCommand("insert into facture (designation,date_facture,montant,id_employe,id_type_paiement,numVirement,archive) values ('" + txt_designation.Text + "','" + dt_date.Value.ToShortDateString() + "','" + txt_montant.Text + "'," + idt + "," + paim + "," + txt_numero.Text + ",1)", Fonctions.CnConnection());
            }
            cmd.ExecuteNonQuery();
            MessageBox.Show("Facture Ajouter Avec Succes.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateFN(string type,int idt, int paim)
        {
            if (type == "Employe")
            {
                if (paim == 1)
                    cmd = new SqlCommand("update facture set designation = '" + txt_designation.Text + "' , date_facture = '" + dt_date.Value.ToShortDateString() + "' , montant = '" + txt_montant.Text + "' , id_employe = " + idt + ", id_type_paiement = " + paim + ", numCheque = " + txt_numero.Text + " where id_facture = " + int.Parse(id), Fonctions.CnConnection());
                else
                    cmd = new SqlCommand("update facture set designation = '" + txt_designation.Text + "' , date_facture = '" + dt_date.Value.ToShortDateString() + "' , montant = '" + txt_montant.Text + "' , id_employe = " + idt + ", id_type_paiement = " + paim + ", numVirement = " + txt_numero.Text + " where id_facture = " + int.Parse(id), Fonctions.CnConnection());
            }
            else
            {
                if (paim == 1)
                    cmd = new SqlCommand("update facture set designation = '" + txt_designation.Text + "' , date_facture = '" + dt_date.Value.ToShortDateString() + "' , montant = '" + txt_montant.Text + "' , id_fournisseur = " + idt + ", id_type_paiement = " + paim + ", numCheque = " + txt_numero.Text + " where id_facture = " + int.Parse(id), Fonctions.CnConnection());
                else
                    cmd = new SqlCommand("update facture set designation = '" + txt_designation.Text + "' , date_facture = '" + dt_date.Value.ToShortDateString() + "' , montant = '" + txt_montant.Text + "' , id_fournisseur = " + idt + ", id_type_paiement = " + paim + ", numVirement = " + txt_numero.Text + " where id_facture = " + int.Parse(id), Fonctions.CnConnection());
            }
            cmd.ExecuteNonQuery();
            MessageBox.Show("Facture Modifier Avec Succes.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_vider_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_vider":
                    txt_designation.Clear();
                    txt_montant.Clear();
                    txt_numero.Clear();
                    txt_designation.Focus();
                    break;
                case "btn_valider_ajt":
                    if (cb_type.Text == "Fournisseur")
                    {
                        if (cb_paiment.Text == "Chique") insertFN("Fournisseur", int.Parse(cb_nom.SelectedValue.ToString()), 1);
                        else insertFN("Fournisseur", int.Parse(cb_nom.SelectedValue.ToString()), 2);
                    }
                    else {
                        if (cb_paiment.Text == "Chique") insertFN("Employe", int.Parse(cb_nom.SelectedValue.ToString()), 1);
                        else insertFN("Employe",int.Parse(cb_nom.SelectedValue.ToString()), 2);
                    }
                    break;
                case "btn_valider_mod":
                    if (cb_type.Text == "Fournisseur")
                    {
                        if (cb_paiment.Text == "Chique") updateFN("Fournisseur", int.Parse(cb_nom.SelectedValue.ToString()), 1);
                        else updateFN("Fournisseur", int.Parse(cb_nom.SelectedValue.ToString()), 2);
                    }
                    else
                    {
                        if (cb_paiment.Text == "Chique") updateFN("Employe", int.Parse(cb_nom.SelectedValue.ToString()), 1);
                        else updateFN("Employe", int.Parse(cb_nom.SelectedValue.ToString()), 2);
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
