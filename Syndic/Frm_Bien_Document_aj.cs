using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Syndic
{
    public partial class Frm_Bien_Document_aj : Form
    {

        int id;
        string frm, ch, name, ext;
        SqlCommand cmd;
        SqlDataReader dr;
        BindingSource bsFct;
        public Frm_Bien_Document_aj(int id = 0, string frm = "")
        {
            InitializeComponent();
            this.id = id;
            this.frm = frm;
        }
       

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Bien_Document_aj_Load(object sender, EventArgs e)
        {

            bsFct = Fonctions.remplirList(cb_doc, "bien", "NomApparetemnt", "id_bien");

            if (frm == "Modifier")
            {
                cmd = new SqlCommand("select * from document_bien where id_document = " + id, Fonctions.CnConnection());
                dr = cmd.ExecuteReader();

                dr.Read();
                txt_nom.Text = dr["nom"].ToString();
                lbl_chemin.Text = dr["fichier"].ToString();

                lbl_titre.Text = "Modifier Document";

                cb_doc.SelectedValue = id;

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

        private void btn_vider_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_valider_mod":
                    if (txt_nom.Text != "" && lbl_chemin.Text != "" && cb_doc.SelectedIndex != -1)
                    {
                        cmd = new SqlCommand("update document_bien set nom = '" + txt_nom.Text + "' , fichier = '" + lbl_chemin.Text + "' where id_document = " + id, Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Document Modifier Avec Succes.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Remplir Tous Les Champ S'il Vous Plait.", "Remplir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "btn_valider_ajt":
                    if (txt_nom.Text != "" && lbl_chemin.Text != "" && cb_doc.SelectedIndex != -1)
                    {
                        cmd = new SqlCommand("insert into document_bien values ('" + txt_nom.Text + "','" + (lbl_chemin.Text + ext) + "'," + cb_doc.SelectedValue + ",1)", Fonctions.CnConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Document Ajouter Avec Succes.", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        File.Copy(ch, Application.StartupPath + @"\Documentbien\" + name + ext);
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

        private void btn_vider_Click(object sender, EventArgs e)
        {
          
        }

      

        private void btn_ficher_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ch = ofd.FileName;
                name = DateTime.Now.ToString().Replace(":", "").Replace("/", "").Replace(" ", "");
                ext = Path.GetExtension(ofd.FileName);

                lbl_chemin.Text = (Application.StartupPath + @"\DocumentBien\" + name);
            }
        }
    }
}
