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
using System.IO;

namespace Syndic
{
    public partial class FrmAMDocFacture : Form
    {
        int id;
        string frm,ch,name,ext;
        SqlCommand cmd;
        SqlDataReader dr;
        BindingSource bsFct;

        public FrmAMDocFacture(string frm="")
        {
            InitializeComponent();
            this.frm = frm;
        }

        public FrmAMDocFacture(int id = 0, string frm="")
        {
            InitializeComponent();
            this.id = id;
            this.frm = frm;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAMDocFacture_Load(object sender, EventArgs e)
        {
            bsFct = Fonctions.remplirList(cb_fct, "Facture", "designation", "id_facture");

            if (frm == "Modifier")
            {
                cmd = new SqlCommand("select * from document_facture where id_document = " + id, Fonctions.CnConnection());
                dr = cmd.ExecuteReader();

                dr.Read();
                txt_nom.Text = dr["nom"].ToString();
                lbl_chemin.Text = dr["fichier"].ToString();

                lbl_titre.Text = "Modifier Document";

                cb_fct.SelectedValue = id;

                pnl_ajouter.Visible = false;
                pnl_modifier.Visible = true;
            }
            else
            {
                pnl_modifier.Visible = false;
                pnl_ajouter.Visible = true;
                lbl_titre.Text = "Ajouter Document";
            }
        }

        private void btn_valider_mod_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_valider_mod":
                    if (txt_nom.Text != "" && lbl_chemin.Text != "" && cb_fct.SelectedIndex != -1)
                    {
                        cmd = new SqlCommand("update document_facture set nom = '" + txt_nom.Text + "' , fichier = '" + lbl_chemin.Text + "' where id_document = " + id, Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Document Modifier Avec Succes.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Remplir Tous Les Champ S'il Vous Plait.", "Remplir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "btn_valider_ajt":
                    if (txt_nom.Text != "" && lbl_chemin.Text != "" && cb_fct.SelectedIndex != -1)
                    {
                        cmd = new SqlCommand("insert into document_facture values ('" + txt_nom.Text + "','" + (lbl_chemin.Text + ext) + "'," + cb_fct.SelectedValue + ",1)", Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Document Ajouter Avec Succes.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        File.Copy(ch, Application.StartupPath + @"\DocumentFacture\" + name + ext);
                    }
                    else
                        MessageBox.Show("Remplir Tous Les Champ S'il Vous Plait.", "Remplir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "btn_vider":
                    txt_nom.Clear();
                    lbl_chemin.Text = "";
                    txt_nom.Focus();
                    break;
                case "btn_annuler_ajt":
                case "btn_annuler_mod":
                    this.Close();
                    break;
            }
        }

        private void btn_ficher_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ch = ofd.FileName;
                name = DateTime.Now.ToString().Replace(":", "").Replace("/", "").Replace(" ","");
                ext = Path.GetExtension(ofd.FileName);

                lbl_chemin.Text = (Application.StartupPath + @"\DocumentFacture\" + name);
            }
        }
    }
}
