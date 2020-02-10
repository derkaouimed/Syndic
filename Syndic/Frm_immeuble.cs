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
    public partial class Frm_immeuble : Form
    {
        public Frm_immeuble()
        {
            InitializeComponent();
        }

        private void btn_immeuble_Supprimer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_immeuble_Ajouter":
                    Frm_immeuble_aj f = new Frm_immeuble_aj();
                    f.ShowDialog();

                    break;
                case "btn_immeuble_modifier":
                    Frm_immeuble_aj ff = new Frm_immeuble_aj();
                    ff.ShowDialog();


                    break;
                case "btn_immeuble_Supprimer":

                    break;

            }
        }
    }
}
