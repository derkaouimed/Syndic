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
    public partial class FrmFacture : Form
    {
        public FrmFacture()
        {
            InitializeComponent();
        }

        private void txt_chercher_Enter(object sender, EventArgs e)
        {
            if ((txt_chercher.Text != "") && (txt_chercher.Text == "Tapez Un Text Pour Rechercher"))
            {
                txt_chercher.Clear();
                txt_chercher.ForeColor = Color.Black;
            }
        }

        private void txt_chercher_Leave(object sender, EventArgs e)
        {
            if (txt_chercher.Text == "")
            {
                txt_chercher.Text = "Tapez Un Text Pour Rechercher";
                txt_chercher.ForeColor = Color.Gray;
            }
        }
    }
}
