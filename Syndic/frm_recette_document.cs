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
    public partial class frm_recette_document : Form
    {
        public frm_recette_document()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_RecetteDocument_Ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_RecetteDocument_Ajouter":
                    frm_recette_Document_info ff = new frm_recette_Document_info();
                    ff.ShowDialog();
                    
                    break;
                case "btn_RecetteDocument_modifier":
                    frm_recette_Document_info f = new frm_recette_Document_info();
                    f.ShowDialog();

                    break;
                case "btn_RecetteDocument_Supprimer":

                    break;
           
                 

            }
        }
      
        private void frm_recette_document_Load(object sender, EventArgs e)
        {
            txt_search = MyHint.LoadText(txt_search, "Nom de Document");
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            txt_search = MyHint.HintLeave(txt_search, "Nom de Document");
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search = MyHint.HintEnter(txt_search, "Nom de Document");
        }
    }
}
