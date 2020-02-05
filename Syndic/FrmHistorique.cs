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
    public partial class FrmHistorique : Form
    {
        public FrmHistorique()
        {
            InitializeComponent();
        }

        private void ouvrire(Form frm)
        {
            if (this.pnl_forms.Controls.Count > 0)
                this.pnl_forms.Controls.RemoveAt(0);

            Form fh = frm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.AutoScroll = true;
            this.pnl_forms.Controls.Add(fh);
            this.pnl_forms.Tag = fh;
            fh.Show();
        }
        private void btn_journal_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Name)
            {
                case "btn_journal":
                    pnl_selection.Location = new Point(0, 38);
                    break;
                case "btn_connexion":
                    pnl_selection.Location = new Point(386, 38);
                    ouvrire(new FrmConnexion());
                    break;
            }
        }
    }
}
