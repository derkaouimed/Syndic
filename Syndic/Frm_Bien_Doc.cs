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
    public partial class Frm_Bien_Doc : Form
    {
        public Frm_Bien_Doc()
        {
            InitializeComponent();
        }

        private void btn_Bien_Supprimer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_Bien_doc_Ajouter":
                    Frm_Bien_Document_aj ff = new Frm_Bien_Document_aj();
                    ff.ShowDialog();

                    break;
                case "btn_Bien_doc_modifier":
                    Frm_Bien_Document_aj f = new Frm_Bien_Document_aj();
                    f.ShowDialog();

                    break;
                case "btn_Bien_doc_Supprimer":

                    break;



            }
        }
    }
}
