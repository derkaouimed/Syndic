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
    public partial class FrmFactures : Form
    {
        public FrmFactures()
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
        private void btn_facture_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_facture":
                    pnl_selection.Location = new Point(0, 39);
                    ouvrire(new FrmFacture());
                    break;
                case "btn_documents":
                    pnl_selection.Location = new Point(258, 39);
                    ouvrire(new FrmDocFacture());
                    break;
                case "btn_remarques":
                    pnl_selection.Location = new Point(515, 39);
                    ouvrire(new FrmRemFacture());
                    break;
            }
        }
    }
}
