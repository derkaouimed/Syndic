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
    public partial class frm_recette : Form
    {
        public frm_recette()
        {
            InitializeComponent();
            btn_recette.PerformClick();
        }
        private void ouvrire(Form frm)
        {
            if (this.pnl_recette_container.Controls.Count > 0)
                this.pnl_recette_container.Controls.RemoveAt(0);

            Form fh = frm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.AutoScroll = true;
            this.pnl_recette_container.Controls.Add(fh);
            this.pnl_recette_container.Tag = fh;
            fh.Show();
        }
        private void btn_recette_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btn_recette":
                    pnl_selection.Location = new Point(0, 38);
                    ouvrire(new frm_recette_real());
                    break;
                case "btn_Recette_Document":

                    pnl_selection.Location = new Point(258, 38);
                    ouvrire(new frm_recette_document());

                    break;
                case "btn_Recette_remarque":
                    pnl_selection.Location = new Point(514, 38);
                    ouvrire(new frm_recette_remarque());
                    break;
            
            }
        }

        private void frm_recette_Load(object sender, EventArgs e)
        {
            ouvrire(new frm_recette_real());
        }

        private void pnl_recette_container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
