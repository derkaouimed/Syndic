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
    public partial class Frm_utilisateur : Form
    {
        public Frm_utilisateur()
        {
            InitializeComponent();
        }

        private void btn_utilisateur_Ajouter_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_utilisateur_Ajouter":
                    Frm_Utilisateur_aj ff = new Frm_Utilisateur_aj();
                    ff.ShowDialog();

                    break;
                case "btn_utilisateur_modifier":
                    Frm_Utilisateur_aj f = new Frm_Utilisateur_aj();
                    f.ShowDialog();

                    break;
                case "btn_utilisateur_Supprimer":

                    break;
            }
        }
    }
}
