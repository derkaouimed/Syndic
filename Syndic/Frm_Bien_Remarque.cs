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
    public partial class Frm_Bien_Remarque : Form
    {
        public Frm_Bien_Remarque()
        {
            InitializeComponent();
        }

        private void btn_Bien_rem_Supprimer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_Bien_rem_Ajouter":
                    Frm_Bien_remarque_aj f = new Frm_Bien_remarque_aj();
                    f.ShowDialog();

                    break;
                case "btn_Bien_rem_modifier":
                    Frm_Bien_remarque_aj ff = new Frm_Bien_remarque_aj();
                    ff.ShowDialog();

                    break;
                case "btn_Bien_rem_Supprimer":


                    break;
            }
        }
    }
}
