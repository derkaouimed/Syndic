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
    public partial class frm_journal : Form
    {
        BindingSource bs;
        public frm_journal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_journal_Load(object sender, EventArgs e)
        {
            Fonctions.ouvrireConnection();

            string sql= "select id_journal as ID ,date_action as [Date],action,table_action as tablee,anciennes_valeurs,nouvelles_valeurs from journal where archive = '1'";
           bs= Fonctions.remplirGrille(dtG_immeuble, sql, "journal");
        }

        private void btn_premiere_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }
    }
}
