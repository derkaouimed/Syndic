using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Drawing;

namespace Syndic
{
    static class Fonctions
    {
        static SqlConnection cn = new SqlConnection();
        public static DataSet ds = new DataSet();
        static public void ouvrireConnection()
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                cn.Open();
            }
        }

        static public SqlConnection CnConnection()
        {
            SqlConnection cn = new SqlConnection();
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["SyndicCS"].ToString();
                cn.Open();
            }

            return cn;
        }

        static private void remplirTable(string t)
        {
            ouvrireConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from " + t, cn);
            if (ds.Tables.Contains(t))
                ds.Tables[t].Clear();

            da.Fill(ds, t);
        }

        static private void remplirTable(string t, string tpk, string pk, string fk)
        {
            ouvrireConnection();
            SqlDataAdapter da = new SqlDataAdapter("select * from " + t, cn);
            if (ds.Tables.Contains(t))
                ds.Tables[t].Clear();

            da.Fill(ds, t);

            da = new SqlDataAdapter("select * from " + tpk, cn);
            if (ds.Tables.Contains(tpk))
                ds.Tables[tpk].Clear();
        
            da.Fill(ds, tpk);

            DataColumn c1 = ds.Tables[t].Columns[pk];
            DataColumn c2 = ds.Tables[tpk].Columns[tpk];

            DataRelation r = new DataRelation("fk_" + t + "_" + tpk, c1, c2);
            ds.Relations.Add(r);
        }


        static private void remplirTableClear(string sql, string t)
        {
            ouvrireConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, t);
        }

        static private void remplirTable(string sql, string t)
        {
            ouvrireConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            if (ds.Tables.Contains(t))
                ds.Tables[t].Clear();

            da.Fill(ds, t);
        }
        static public void textHintEntre(TextBox t,string s)
        {
            if ((t.Text != "") && (t.Text == s))
            {
                t.Clear();
                t.ForeColor = Color.Black;
            }
        }

        static public void textHintLeave(TextBox t, string s)
        {
            if (t.Text == "")
            {
                t.Text = s;
                t.ForeColor = Color.Gray;
            }
        }

        static public void syncr(string t,SqlConnection cn,DataSet ds)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from " + t, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds.Tables[t]);
            da = null;
            cb = null;
        }

        static public BindingSource remplirGrille(DataGridView d, string t)
        {
            BindingSource bs = new BindingSource();

            remplirTable(t);

            bs.DataSource = ds;
            bs.DataMember = t;

            d.DataSource = bs;
            return bs;
        }
        static public BindingSource remplirGrille(DataGridView d, string sql, string t)
        {
            BindingSource bs = new BindingSource();

            remplirTable(sql, t);

            bs.DataSource = ds;
            bs.DataMember = t;

            d.DataSource = bs;
            return bs;
        }

        static public BindingSource remplirList(ListControl l, string t, string dm, string vm)
        {
            BindingSource bs = new BindingSource();

            remplirTable(t);

            bs.DataSource = ds;
            bs.DataMember = t;

            l.DataSource = bs;
            l.DisplayMember = dm;
            l.ValueMember = vm;

            return bs;
        }

        static public BindingSource remplirList(ListControl l, string sql, string t, string dm, string vm)
        {
            BindingSource bs = new BindingSource();

            remplirTable(sql,t);

            bs.DataSource = ds;
            bs.DataMember = t;

            l.DataSource = bs;
            l.DisplayMember = dm;
            l.ValueMember = vm;

            return bs;
        }

        static public BindingSource remplirListRel(ListControl l, string t, string dm, string vm,string tpk,string pk,string fk,BindingSource bsk)
        {
            BindingSource bs = new BindingSource();

            remplirTable(t);

            bs.DataSource = bsk;
            bs.DataMember = "fk_" + t + "_" + tpk;

            l.DataSource = bs;
            l.DisplayMember = dm;
            l.ValueMember = vm;

            return bs;
        }

        static public void refreshTable(string sql, string t)
        {
            ds.Tables[t].Clear();
            remplirTableClear(sql, t);
        }
    }
}
