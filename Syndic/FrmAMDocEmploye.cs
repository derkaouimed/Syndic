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
    public partial class FrmAMDocEmploye : Form
    {
        int id;
        string frm, ch, name, ext;
        SqlCommand cmd;
        SqlDataReader dr;
        BindingSource bsEmp;

        private void btn_vider_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_valider_mod":
                    if (txt_nom.Text != "" && lbl_chemin.Text != "" && cb_emps.SelectedIndex != -1)
                    {
                        cmd = new SqlCommand("update document_employe set nom = '" + txt_nom.Text + "' , fichier = '" + lbl_chemin.Text + "' where id_document = " + id, Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Document Modifier Avec Succes.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Remplir Tous Les Champ S'il Vous Plait.", "Remplir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "btn_valider_ajt":
                    if (txt_nom.Text != "" && lbl_chemin.Text != "" && cb_emps.SelectedIndex != -1)
                    {
                        cmd = new SqlCommand("insert into document_employe values ('" + txt_nom.Text + "','" + (lbl_chemin.Text + ext) + "'," + cb_emps.SelectedValue + ",1)", Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Document Ajouter Avec Succes.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        File.Copy(ch, Application.StartupPath + @"\DocumentEmploye\" + name + ext);
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
                name = DateTime.Now.ToString().Replace(":", "").Replace("/", "").Replace(" ", "");
                ext = Path.GetExtension(ofd.FileName);

                lbl_chemin.Text = (Application.StartupPath + @"\DocumentEmploye\" + name);
            }
        }

        public FrmAMDocEmploye(string frm="")
        {
            InitializeComponent();
            this.frm = frm;
        }

        public FrmAMDocEmploye(int id=0,string frm="")
        {
            InitializeComponent();
            this.id = id;
            this.frm = frm;
        }

        private void FrmAMDocEmploye_Load(object sender, EventArgs e)
        {
            string sql = "select *,concat(nom,' ',prenom) as nomComplete from employe where archive = 1";
            bsEmp = Fonctions.remplirList(cb_emps, sql, "Employe", "nomComplete", "id_employe");

            if (frm == "Modifier")
            {
                cmd = new SqlCommand("select * from document_employe where id_document = " + id, Fonctions.CnConnection());
                dr = cmd.ExecuteReader();

                dr.Read();
                txt_nom.Text = dr["nom"].ToString();
                lbl_chemin.Text = dr["fichier"].ToString();

                lbl_titre.Text = "Modifier Document";

                cb_emps.SelectedValue = id;

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
    }
}
