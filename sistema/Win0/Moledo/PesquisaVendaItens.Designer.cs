namespace win0.Moledo
{
    partial class FormPesquisaVendaItens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisaVendaItens));
            this.DataGridViewPesqVendaItens = new System.Windows.Forms.DataGridView();
            this.tabvendasitensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPesquisaVendasItens = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabvendasitensBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataaSet = new win0.DataaSet();
            this.tabvendas_itensTableAdapter = new win0.DataaSetTableAdapters.tabvendas_itensTableAdapter();
            this.tabcadastroprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabcadastroprodutoTableAdapter = new win0.DataaSetTableAdapters.tabcadastroprodutoTableAdapter();
            this.tabcadastroprodutoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPesqVendaItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendasitensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendasitensBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewPesqVendaItens
            // 
            this.DataGridViewPesqVendaItens.AllowUserToAddRows = false;
            this.DataGridViewPesqVendaItens.AllowUserToDeleteRows = false;
            this.DataGridViewPesqVendaItens.AutoGenerateColumns = false;
            this.DataGridViewPesqVendaItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewPesqVendaItens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DataGridViewPesqVendaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPesqVendaItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.DataGridViewPesqVendaItens.DataSource = this.tabcadastroprodutoBindingSource1;
            this.DataGridViewPesqVendaItens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DataGridViewPesqVendaItens.Location = new System.Drawing.Point(22, 70);
            this.DataGridViewPesqVendaItens.Name = "DataGridViewPesqVendaItens";
            this.DataGridViewPesqVendaItens.ReadOnly = true;
            this.DataGridViewPesqVendaItens.RowHeadersWidth = 51;
            this.DataGridViewPesqVendaItens.RowTemplate.Height = 24;
            this.DataGridViewPesqVendaItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPesqVendaItens.Size = new System.Drawing.Size(766, 251);
            this.DataGridViewPesqVendaItens.TabIndex = 0;
            this.DataGridViewPesqVendaItens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPesqVendaItens_CellContentClick);
            this.DataGridViewPesqVendaItens.DoubleClick += new System.EventHandler(this.DataGridViewPesqVendaItens_DoubleClick);
            // 
            // tabvendasitensBindingSource
            // 
            this.tabvendasitensBindingSource.DataMember = "tabvendas_itens";
            // 
            // buttonPesquisaVendasItens
            // 
            this.buttonPesquisaVendasItens.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPesquisaVendasItens.BackgroundImage")));
            this.buttonPesquisaVendasItens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPesquisaVendasItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonPesquisaVendasItens.Location = new System.Drawing.Point(657, 12);
            this.buttonPesquisaVendasItens.Name = "buttonPesquisaVendasItens";
            this.buttonPesquisaVendasItens.Size = new System.Drawing.Size(131, 39);
            this.buttonPesquisaVendasItens.TabIndex = 2;
            this.buttonPesquisaVendasItens.Text = "Atualizar";
            this.buttonPesquisaVendasItens.UseVisualStyleBackColor = true;
            this.buttonPesquisaVendasItens.Click += new System.EventHandler(this.buttonPesquisaVendasItens_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tabvendasitensBindingSource1
            // 
            this.tabvendasitensBindingSource1.DataMember = "tabvendas_itens";
            this.tabvendasitensBindingSource1.DataSource = this.dataaSet;
            // 
            // dataaSet
            // 
            this.dataaSet.DataSetName = "DataaSet";
            this.dataaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabvendas_itensTableAdapter
            // 
            this.tabvendas_itensTableAdapter.ClearBeforeFill = true;
            // 
            // tabcadastroprodutoBindingSource
            // 
            this.tabcadastroprodutoBindingSource.DataMember = "tabcadastroproduto";
            this.tabcadastroprodutoBindingSource.DataSource = this.dataaSet;
            // 
            // tabcadastroprodutoTableAdapter
            // 
            this.tabcadastroprodutoTableAdapter.ClearBeforeFill = true;
            // 
            // tabcadastroprodutoBindingSource1
            // 
            this.tabcadastroprodutoBindingSource1.DataMember = "tabcadastroproduto";
            this.tabcadastroprodutoBindingSource1.DataSource = this.dataaSet;
            // 
            // FormPesquisaVendaItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.buttonPesquisaVendasItens);
            this.Controls.Add(this.DataGridViewPesqVendaItens);
            this.DoubleBuffered = true;
            this.Name = "FormPesquisaVendaItens";
            this.Text = "Pesquisa Vendas Itens";
            this.Load += new System.EventHandler(this.PesquisaVendaItens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPesqVendaItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendasitensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendasitensBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
//        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource tabvendasitensBindingSource;
//        private DataSet2TableAdapters.tabvendas_itensTableAdapter tabvendas_itensTableAdapter;
        public System.Windows.Forms.DataGridView DataGridViewPesqVendaItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonPesquisaVendasItens;
        private DataaSet dataaSet;
        private System.Windows.Forms.BindingSource tabvendasitensBindingSource1;
        private DataaSetTableAdapters.tabvendas_itensTableAdapter tabvendas_itensTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource tabcadastroprodutoBindingSource;
        private DataaSetTableAdapters.tabcadastroprodutoTableAdapter tabcadastroprodutoTableAdapter;
        private System.Windows.Forms.BindingSource tabcadastroprodutoBindingSource1;
    }
}