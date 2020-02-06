using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic
{
    public partial class frm_recette_real : Form
    {
        public frm_recette_real()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void LesButton(bool b) {
            btn_Recette_Ajouter.Visible = b;
            btn_Recette_modifier.Visible = b;
            btn_Recette_Supprimer.Visible = b;
           
        }
        private void btn_Recette_Ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_Recette_Ajouter":
                    frm_recette_information f = new frm_recette_information();
                    f.ShowDialog();

                    //LesButton(false);
                    break;
                case "btn_Recette_modifier":
                    frm_recette_information ff = new frm_recette_information();
                    ff.ShowDialog();
                    //LesButton(false);
                    break;
                case "btn_Recette_Supprimer":
                    DialogResult d = MessageBox.Show("Suppresion", "Voules Vous Supprime Ce Propietaire ?", MessageBoxButtons.OK);
                    if (DialogResult.OK == d)
                    {
                        /////
                    }
                    //LesButton(false);
                    break;

            }
        }

        private void frm_recette_real_Load(object sender, EventArgs e)
        {
            LesButton(true);
            txt_search = MyHint.LoadText(txt_search, "Le Montant de Recette");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            txt_search = MyHint.HintLeave(txt_search,"Le Montant de Recette");
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search = MyHint.HintEnter(txt_search, "Le Montant de Recette");
        }
    }
}
