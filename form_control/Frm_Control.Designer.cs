namespace user_control.other
{
    partial class Frm_Control
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.test_linqsqlDataSet = new user_control.test_linqsqlDataSet();
            this.web_service_test1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.web_service_test1TableAdapter = new user_control.test_linqsqlDataSetTableAdapters.web_service_test1TableAdapter();
            this.tableAdapterManager = new user_control.test_linqsqlDataSetTableAdapters.TableAdapterManager();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nav11 = new user_control.other.nav1();
            ((System.ComponentModel.ISupportInitialize)(this.test_linqsqlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.web_service_test1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // test_linqsqlDataSet
            // 
            this.test_linqsqlDataSet.DataSetName = "test_linqsqlDataSet";
            this.test_linqsqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // web_service_test1BindingSource
            // 
            this.web_service_test1BindingSource.DataMember = "web_service_test1";
            this.web_service_test1BindingSource.DataSource = this.test_linqsqlDataSet;
            // 
            // web_service_test1TableAdapter
            // 
            this.web_service_test1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.departamento1TableAdapter = null;
            this.tableAdapterManager.puesto1TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = user_control.test_linqsqlDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user1TableAdapter = null;
            this.tableAdapterManager.web_service_test1TableAdapter = this.web_service_test1TableAdapter;
            this.tableAdapterManager.web_service_testTableAdapter = null;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DataGridView1.DataSource = this.web_service_test1BindingSource;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridView1.Location = new System.Drawing.Point(0, 70);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(338, 252);
            this.DataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "usuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "usuario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ip";
            this.dataGridViewTextBoxColumn3.HeaderText = "ip";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "hora";
            this.dataGridViewTextBoxColumn4.HeaderText = "hora";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // nav11
            // 
            this.nav11.Location = new System.Drawing.Point(87, 13);
            this.nav11.Name = "nav11";
            this.nav11.Size = new System.Drawing.Size(165, 51);
            this.nav11.TabIndex = 2;
            // 
            // Frm_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 322);
            this.Controls.Add(this.nav11);
            this.Controls.Add(this.DataGridView1);
            this.Name = "Frm_Control";
            this.Text = "Frm_Control";
            this.Load += new System.EventHandler(this.Frm_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.test_linqsqlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.web_service_test1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private test_linqsqlDataSet test_linqsqlDataSet;
        private System.Windows.Forms.BindingSource web_service_test1BindingSource;
        private test_linqsqlDataSetTableAdapters.web_service_test1TableAdapter web_service_test1TableAdapter;
        private test_linqsqlDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private nav1 nav11;
    }
}