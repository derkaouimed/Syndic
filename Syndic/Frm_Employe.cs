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
    public partial class Frm_Employe : Form
    {
        public Frm_Employe()
        {
            InitializeComponent();
            pnlDrop.Visible = false;
        }

        private void btn_drop_Click(object sender, EventArgs e)
        {
            if (pnlDrop.Visible)
                pnlDrop.Visible = false;
            else
                pnlDrop.Visible = true;
        }
    }
}
