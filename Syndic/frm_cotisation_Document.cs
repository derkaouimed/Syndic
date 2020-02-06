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
    public partial class frm_cotisation_Document : Form
    {
        public frm_cotisation_Document()
        {
            InitializeComponent();
            //
            txt_search = MyHint.LoadText(txt_search, "Nom De Document");
            
        }
     
        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search = MyHint.HintEnter(txt_search, "Nom De Document");
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            txt_search = MyHint.HintLeave(txt_search,"Nom De Document");
        }
    }
}
