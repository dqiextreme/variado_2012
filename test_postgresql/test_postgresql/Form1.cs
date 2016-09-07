using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_postgresql.clases;

namespace test_postgresql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Master_List ml = new Master_List();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ml.psql_select().CopyToDataTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds2 = ml.psql_select_DS("Test1");
            dataGridView1.DataSource = ml.psql_select_DS("Test1").Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //solo para evitar duplicados en pruebas
            int nv = ml.psql_count("Test1");
            //solo para evitar duplicados en pruebas

            //(1,'newval1'),(2,'newval2')   //string val = "(1,'newval1'),(2,'newval2')";

            //sin AUTO_INCREMENT
            //string val = "(" + (nv + 1) + ",'newval" + (nv + 1).ToString() + "'),(" + (nv + 2) + ",'newval" + (nv + 2).ToString() + "')";

            //con AUTO_INCREMENT
            string val = "('newval" + (nv + 1).ToString() + "'),('newval" + (nv + 2).ToString() + "')";
            ml.psql_insert("Test1 (texto) ", val);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

    }
}
