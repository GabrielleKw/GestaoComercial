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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisaProd));
            this.ProdutodataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabcadastroprodutoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataaSet = new win0.DataaSet();
            this.tabcadastroprodutoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabCadastroProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPesquisaProduto = new System.Windows.Forms.Button();
            this.tabcadastroprodutoTableAdapter = new win0.DataaSetTableAdapters.tabcadastroprodutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadastroProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdutodataGridView
            // 
            this.ProdutodataGridView.AllowUserToAddRows = false;
            this.ProdutodataGridView.AllowUserToDeleteRows = false;
            this.ProdutodataGridView.AutoGenerateColumns = false;
            this.ProdutodataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdutodataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProdutodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdutodataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.ProdutodataGridView.DataSource = this.tabcadastroprodutoBindingSource2;
            this.ProdutodataGridView.GridColor = System.Drawing.Color.Magenta;
            this.ProdutodataGridView.Location = new System.Drawing.Point(20, 86);
            this.ProdutodataGridView.Name = "ProdutodataGridView";
            this.ProdutodataGridView.ReadOnly = true;
            this.ProdutodataGridView.RowHeadersWidth = 51;
            this.ProdutodataGridView.RowTemplate.Height = 24;
            this.ProdutodataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdutodataGridView.Size = new System.Drawing.Size(873, 238);
            this.ProdutodataGridView.TabIndex = 0;
            this.ProdutodataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdutodataGridView_CellContentClick_1);
            this.ProdutodataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdutodataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn3.HeaderText = "id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nomeproduto";
            this.dataGridViewTextBoxColumn4.HeaderText = "nomeproduto";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "preço";
            this.dataGridViewTextBoxColumn5.HeaderText = "preço";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "data_cadastro";
            this.dataGridViewTextBoxColumn6.HeaderText = "data_cadastro";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "data_atualizacao";
            this.dataGridViewTextBoxColumn7.HeaderText = "data_atualizacao";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "unidade_venda";
            this.dataGridViewTextBoxColumn8.HeaderText = "unidade_venda";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tabcadastroprodutoBindingSource2
            // 
            this.tabcadastroprodutoBindingSource2.DataMember = "tabcadastroproduto";
            this.tabcadastroprodutoBindingSource2.DataSource = this.dataaSet;
            // 
            // dataaSet
            // 
            this.dataaSet.DataSetName = "DataaSet";
            this.dataaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabcadastroprodutoBindingSource1
            // 
            this.tabcadastroprodutoBindingSource1.DataMember = "tabcadastroproduto";
            // 
            // tabCadastroProdutoBindingSource
            // 
            this.tabCadastroProdutoBindingSource.DataMember = "tabCadastroProduto";
            // 
            // buttonPesquisaProduto
            // 
            this.buttonPesquisaProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPesquisaProduto.BackgroundImage")));
            this.buttonPesquisaProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPesquisaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonPesquisaProduto.Location = new System.Drawing.Point(758, 12);
            this.buttonPesquisaProduto.Name = "buttonPesquisaProduto";
            this.buttonPesquisaProduto.Size = new System.Drawing.Size(131, 39);
            this.buttonPesquisaProduto.TabIndex = 1;
            this.buttonPesquisaProduto.Text = "Atualizar";
            this.buttonPesquisaProduto.UseVisualStyleBackColor = true;
            this.buttonPesquisaProduto.Click += new System.EventHandler(this.PesquisaProduto_Clicl);
            // 
            // tabcadastroprodutoTableAdapter
            // 
            this.tabcadastroprodutoTableAdapter.ClearBeforeFill = true;
            // 
            // FormPesquisaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 404);
            this.Controls.Add(this.buttonPesquisaProduto);
            this.Controls.Add(this.ProdutodataGridView);
            this.DoubleBuffered = true;
            this.Name = "FormPesquisaProd";
            this.Text = "Pesquisa Produto ";
            this.Load += new System.EventHandler(this.PesquisaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCadastroProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
 //       private DataSet2 DataSet1;
        private System.Windows.Forms.BindingSource tabCadastroProdutoBindingSource;
 //       private DataSet2TableAdapters.tabcadastroprodutoTableAdapter tabCadastroProdutoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAtualizacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonPesquisaProduto;
        public System.Windows.Forms.DataGridView ProdutodataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadevendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tabcadastroprodutoBindingSource1;
        private DataaSet dataaSet;
        private System.Windows.Forms.BindingSource tabcadastroprodutoBindingSource2;
        private DataaSetTableAdapters.tabcadastroprodutoTableAdapter tabcadastroprodutoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}