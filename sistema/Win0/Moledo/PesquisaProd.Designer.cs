namespace win0.Moledo
{
    partial class FormPesquisaProd
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
            this.ButtonPesquisaProduto = new System.Windows.Forms.Button();
            this.Produto_dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAtualizacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadevendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCadastroProdutoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new win0.DataSet1();
            this.tabCadastroProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabCadastroProdutoTableAdapter = new win0.DataSet1TableAdapters.tabCadastroProdutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Produto_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadastroProdutoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadastroProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonPesquisaProduto
            // 
            this.ButtonPesquisaProduto.Location = new System.Drawing.Point(755, 12);
            this.ButtonPesquisaProduto.Name = "ButtonPesquisaProduto";
            this.ButtonPesquisaProduto.Size = new System.Drawing.Size(120, 39);
            this.ButtonPesquisaProduto.TabIndex = 7;
            this.ButtonPesquisaProduto.Text = "Pesquisar";
            this.ButtonPesquisaProduto.UseVisualStyleBackColor = true;
            this.ButtonPesquisaProduto.Click += new System.EventHandler(this.ButtonPesquisaProduto_Click);
            // 
            // Produto_dataGridView
            // 
            this.Produto_dataGridView.AllowUserToAddRows = false;
            this.Produto_dataGridView.AutoGenerateColumns = false;
            this.Produto_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Produto_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Produto_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeprodutoDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.dataAtualizacaoDataGridViewTextBoxColumn,
            this.preçoDataGridViewTextBoxColumn,
            this.unidadevendaDataGridViewTextBoxColumn});
            this.Produto_dataGridView.DataSource = this.tabCadastroProdutoBindingSource1;
            this.Produto_dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Produto_dataGridView.Location = new System.Drawing.Point(12, 57);
            this.Produto_dataGridView.Name = "Produto_dataGridView";
            this.Produto_dataGridView.RowHeadersWidth = 51;
            this.Produto_dataGridView.RowTemplate.Height = 24;
            this.Produto_dataGridView.Size = new System.Drawing.Size(863, 245);
            this.Produto_dataGridView.TabIndex = 11;
            this.Produto_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeprodutoDataGridViewTextBoxColumn
            // 
            this.nomeprodutoDataGridViewTextBoxColumn.DataPropertyName = "nomeproduto";
            this.nomeprodutoDataGridViewTextBoxColumn.HeaderText = "nomeproduto";
            this.nomeprodutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeprodutoDataGridViewTextBoxColumn.Name = "nomeprodutoDataGridViewTextBoxColumn";
            this.nomeprodutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "dataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "dataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataAtualizacaoDataGridViewTextBoxColumn
            // 
            this.dataAtualizacaoDataGridViewTextBoxColumn.DataPropertyName = "dataAtualizacao";
            this.dataAtualizacaoDataGridViewTextBoxColumn.HeaderText = "dataAtualizacao";
            this.dataAtualizacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataAtualizacaoDataGridViewTextBoxColumn.Name = "dataAtualizacaoDataGridViewTextBoxColumn";
            this.dataAtualizacaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // preçoDataGridViewTextBoxColumn
            // 
            this.preçoDataGridViewTextBoxColumn.DataPropertyName = "preço";
            this.preçoDataGridViewTextBoxColumn.HeaderText = "preço";
            this.preçoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preçoDataGridViewTextBoxColumn.Name = "preçoDataGridViewTextBoxColumn";
            this.preçoDataGridViewTextBoxColumn.Width = 125;
            // 
            // unidadevendaDataGridViewTextBoxColumn
            // 
            this.unidadevendaDataGridViewTextBoxColumn.DataPropertyName = "unidade_venda";
            this.unidadevendaDataGridViewTextBoxColumn.HeaderText = "unidade_venda";
            this.unidadevendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadevendaDataGridViewTextBoxColumn.Name = "unidadevendaDataGridViewTextBoxColumn";
            this.unidadevendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tabCadastroProdutoBindingSource1
            // 
            this.tabCadastroProdutoBindingSource1.DataMember = "tabCadastroProduto";
            this.tabCadastroProdutoBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabCadastroProdutoBindingSource
            // 
            this.tabCadastroProdutoBindingSource.DataMember = "tabCadastroProduto";
            this.tabCadastroProdutoBindingSource.DataSource = this.dataSet1;
            // 
            // tabCadastroProdutoTableAdapter
            // 
            this.tabCadastroProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // FormPesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 325);
            this.Controls.Add(this.Produto_dataGridView);
            this.Controls.Add(this.ButtonPesquisaProduto);
            this.Name = "FormPesquisaProduto";
            this.Text = "Pesquisa Produto";
            this.Load += new System.EventHandler(this.PesquisaProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Produto_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadastroProdutoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadastroProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonPesquisaProduto;
        private System.Windows.Forms.DataGridView Produto_dataGridView;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tabCadastroProdutoBindingSource;
        private DataSet1TableAdapters.tabCadastroProdutoTableAdapter tabCadastroProdutoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAtualizacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadevendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tabCadastroProdutoBindingSource1;
    }
}