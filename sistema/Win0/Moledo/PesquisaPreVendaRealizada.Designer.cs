namespace win0.Moledo
{
    partial class FormPesquisaVendaRealizada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisaVendaRealizada));
            this.tabvendaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataaSet = new win0.DataaSet();
            this.tabvendaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabvendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabvendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabvendasitensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabvendasitensBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPesquisaVendas = new System.Windows.Forms.Button();
            this.tabvendaTableAdapter = new win0.DataaSetTableAdapters.tabvendaTableAdapter();
            this.viewvendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewvendaTableAdapter = new win0.DataaSetTableAdapters.viewvendaTableAdapter();
            this.dataGridViewVendaRealizada = new System.Windows.Forms.DataGridView();
            this.idvendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendasitensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendasitensBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewvendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendaRealizada)).BeginInit();
            this.SuspendLayout();
            // 
            // tabvendaBindingSource3
            // 
            this.tabvendaBindingSource3.DataMember = "tabvenda";
            this.tabvendaBindingSource3.DataSource = this.dataaSet;
            // 
            // dataaSet
            // 
            this.dataaSet.DataSetName = "DataaSet";
            this.dataaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabvendaBindingSource2
            // 
            this.tabvendaBindingSource2.DataMember = "tabvenda";
            // 
            // tabvendaBindingSource1
            // 
            this.tabvendaBindingSource1.DataMember = "tabvenda";
            // 
            // tabvendaBindingSource
            // 
            this.tabvendaBindingSource.DataMember = "tabvenda";
            // 
            // tabvendasitensBindingSource
            // 
            this.tabvendasitensBindingSource.DataMember = "tabvendas_itens";
            // 
            // tabvendasitensBindingSource1
            // 
            this.tabvendasitensBindingSource1.DataMember = "tabvendas_itens";
            // 
            // buttonPesquisaVendas
            // 
            resources.ApplyResources(this.buttonPesquisaVendas, "buttonPesquisaVendas");
            this.buttonPesquisaVendas.Name = "buttonPesquisaVendas";
            this.buttonPesquisaVendas.UseVisualStyleBackColor = true;
            this.buttonPesquisaVendas.Click += new System.EventHandler(this.buttonPesquisaVendas_Click);
            // 
            // tabvendaTableAdapter
            // 
            this.tabvendaTableAdapter.ClearBeforeFill = true;
            // 
            // viewvendaBindingSource
            // 
            this.viewvendaBindingSource.DataMember = "viewvenda";
            this.viewvendaBindingSource.DataSource = this.dataaSet;
            // 
            // viewvendaTableAdapter
            // 
            this.viewvendaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewVendaRealizada
            // 
            this.dataGridViewVendaRealizada.AllowUserToAddRows = false;
            this.dataGridViewVendaRealizada.AllowUserToDeleteRows = false;
            this.dataGridViewVendaRealizada.AutoGenerateColumns = false;
            this.dataGridViewVendaRealizada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVendaRealizada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewVendaRealizada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendaRealizada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvendaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn13,
            this.nomeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridViewVendaRealizada.DataSource = this.viewvendaBindingSource;
            resources.ApplyResources(this.dataGridViewVendaRealizada, "dataGridViewVendaRealizada");
            this.dataGridViewVendaRealizada.Name = "dataGridViewVendaRealizada";
            this.dataGridViewVendaRealizada.ReadOnly = true;
            this.dataGridViewVendaRealizada.RowTemplate.Height = 24;
            this.dataGridViewVendaRealizada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idvendaDataGridViewTextBoxColumn
            // 
            this.idvendaDataGridViewTextBoxColumn.DataPropertyName = "idvenda";
            resources.ApplyResources(this.idvendaDataGridViewTextBoxColumn, "idvendaDataGridViewTextBoxColumn");
            this.idvendaDataGridViewTextBoxColumn.Name = "idvendaDataGridViewTextBoxColumn";
            this.idvendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "id_terceirocliente";
            resources.ApplyResources(this.dataGridViewTextBoxColumn13, "dataGridViewTextBoxColumn13");
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            resources.ApplyResources(this.nomeDataGridViewTextBoxColumn, "nomeDataGridViewTextBoxColumn");
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "numero_nf";
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "data_pedido";
            resources.ApplyResources(this.dataGridViewTextBoxColumn9, "dataGridViewTextBoxColumn9");
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "data_emissao";
            resources.ApplyResources(this.dataGridViewTextBoxColumn10, "dataGridViewTextBoxColumn10");
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "data_entrega";
            resources.ApplyResources(this.dataGridViewTextBoxColumn11, "dataGridViewTextBoxColumn11");
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "valor_total";
            resources.ApplyResources(this.dataGridViewTextBoxColumn12, "dataGridViewTextBoxColumn12");
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // FormPesquisaVendaRealizada
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewVendaRealizada);
            this.Controls.Add(this.buttonPesquisaVendas);
            this.DoubleBuffered = true;
            this.Name = "FormPesquisaVendaRealizada";
            this.Load += new System.EventHandler(this.FormPesquisaVendaRealizada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabvendaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendasitensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendasitensBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewvendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendaRealizada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
//        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource tabvendaBindingSource;
//        private DataSet2TableAdapters.tabvendaTableAdapter tabvendaTableAdapter;
        private System.Windows.Forms.BindingSource tabvendasitensBindingSource;
        private System.Windows.Forms.BindingSource tabvendaBindingSource1;
        private System.Windows.Forms.BindingSource tabvendasitensBindingSource1;
//        private DataSet2TableAdapters.tabvendas_itensTableAdapter tabvendas_itensTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeronfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataemissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idterceiroclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tabvendaBindingSource2;
        private System.Windows.Forms.Button buttonPesquisaVendas;
        private DataaSet dataaSet;
        private System.Windows.Forms.BindingSource tabvendaBindingSource3;
        private DataaSetTableAdapters.tabvendaTableAdapter tabvendaTableAdapter;
        private System.Windows.Forms.BindingSource viewvendaBindingSource;
        private DataaSetTableAdapters.viewvendaTableAdapter viewvendaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewVendaRealizada;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}