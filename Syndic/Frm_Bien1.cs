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
    public partial class Frm_Bien1 : Form
    {
        public Frm_Bien1()
        {
            InitializeComponent();
        }

        private void btn_Bien_Supprimer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_Bien_Ajouter":
                    Frm_Bien_Aj f = new Frm_Bien_Aj("Ajouter", 0);
                    f.ShowDialog();

                    break;
                case "btn_Bien_modifier":
                    Frm_Bien_Aj ff = new Frm_Bien_Aj("Modifier", int.Parse(gridBien.CurrentRow.Cells[0].Value.ToString()));
                    ff.ShowDialog();


                    break;
                case "btn_Bien_Supprimer":

                    break;

            }
        }
    }
}
