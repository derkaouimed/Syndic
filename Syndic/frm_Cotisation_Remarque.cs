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
    public partial class frm_Cotisation_Remarque : Form
    {
        public frm_Cotisation_Remarque()
        {
            InitializeComponent();
        }

        private void frm_Cotisation_Remarque_Load(object sender, EventArgs e)
        {
            txt_search = MyHint.LoadText(txt_search,"Nom de Remarque");
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
           // "Nom de Remarque"
                txt_search = MyHint.HintLeave(txt_search, "Nom de Remarque");
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search = MyHint.HintEnter(txt_search, "Nom de Remarque");
        }
    }
}
