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
    public partial class frm_recette_remarque : Form
    {
        public frm_recette_remarque()
        {
            InitializeComponent();
        }
     
        private void btn_RecetteRemarque_Supprimer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_RecetteRemarque_Ajouter":
                    frm_recette_remarque_info f = new frm_recette_remarque_info();
                    f.ShowDialog();
                  
                    break;
                case "btn_RecetteRemarque_modifier":
                    frm_recette_remarque_info ff = new frm_recette_remarque_info();
                    ff.ShowDialog();

                    break;
                case "btn_RecetteRemarque_Supprimer":

                  
                    break;
              

            }
        }

        private void frm_recette_remarque_Load(object sender, EventArgs e)
        {
            txt_search = MyHint.LoadText(txt_search, "Le Nom de Remarque");
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            txt_search = MyHint.HintLeave(txt_search, "Le Nom de Remarque");
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search = MyHint.HintEnter(txt_search, "Le Nom de Remarque");
        }
    }
}
