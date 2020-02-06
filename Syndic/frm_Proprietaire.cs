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
    public partial class frm_Proprietaire : Form
    {
        public frm_Proprietaire()
        {
            InitializeComponent();
        }

        private void btn_Proprietaire_Supprimer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_Proprietaire_Ajouter":

                    Frm_Propietaire_Information f = new Frm_Propietaire_Information("Ajouter");
                    f.ShowDialog();

                    //LesButton(false);
                    break;
                case "btn_Proprietaire_Modifier":
                    Frm_Propietaire_Information ff = new Frm_Propietaire_Information("Modifier");
                    ff.ShowDialog();
                    //LesButton(false);
                    break;
                case "btn_Proprietaire_Supprimer":
                    DialogResult d = MessageBox.Show("Suppresion","Voules Vous Supprime Ce Propietaire ?",MessageBoxButtons.OK);
                    if (DialogResult.OK == d)
                    {
                        /////
                    }
                    //LesButton(false);
                    break;
           
            }

        }
        public void LesButton(bool b)
        {
            btn_Proprietaire_Ajouter.Visible = b;
            btn_Proprietaire_Modifier.Visible = b;
            btn_Proprietaire_Supprimer.Visible = b;
        
        }

        private void frm_Proprietaire_Load(object sender, EventArgs e)
        {
            //LesButton(true);
            txt_search = MyHint.LoadText(txt_search, "Nom & Prenom de Proprietaire");
            //groupBox2.Enabled = true;
        }
       
        private void btn_Last_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_first":
                    
                    // groupBox1.Visible = true;
                    //LesButton(false);
                    break;
                case "btn_Last":

                    //LesButton(false);
                    break;
                case "btn_next":

                    //LesButton(false);
                    break;
                case "btn_previous":

                    //LesButton(true);

                    break;
            }
         }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            txt_search = MyHint.HintLeave(txt_search, "Nom & Prenom de Proprietaire");
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search = MyHint.HintEnter(txt_search, "Nom & Prenom de Proprietaire");
        }
    }
}
