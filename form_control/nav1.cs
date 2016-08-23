using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace user_control.other
{
    public partial class nav1 : UserControl
    {
        DataGridView DataGridView1 = new DataGridView();
        BindingSource bindingSource1 = new BindingSource();
        
        public nav1()
        {
            InitializeComponent();
        }

        public void cargar(DataGridView dg1, BindingSource bs1)
        {
            DataGridView1 = dg1;
            bindingSource1 = bs1;
        }

        public void mdg1()
        {
            if (DataGridView1.Visible)
            {
                DataGridView1.Hide();
            }
            else
            {
                DataGridView1.Show();
            }
        }

        public void mbsn()
        {
            bindingSource1.MoveNext();
        }

        public void mbsp()
        {
            bindingSource1.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mbsp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mbsn();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mdg1();
        }
    }
}
