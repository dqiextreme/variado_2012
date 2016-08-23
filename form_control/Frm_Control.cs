using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace user_control.other
{
    public partial class Frm_Control : Form
    {
        public Frm_Control()
        {
            InitializeComponent();
        }

        private void web_service_test1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.web_service_test1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.test_linqsqlDataSet);

        }

        private void Frm_Control_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'test_linqsqlDataSet.web_service_test1' Puede moverla o quitarla según sea necesario.
            this.web_service_test1TableAdapter.Fill(this.test_linqsqlDataSet.web_service_test1);
            nav11.cargar(DataGridView1, web_service_test1BindingSource);
        }
    }
}
