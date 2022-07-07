namespace win0.Moledo
{
    partial class FormPesquisaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisaFuncionario));
            this.buttonPesquisaProduto = new System.Windows.Forms.Button();
            this.ProdutodataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipocadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAtualzacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablecadastrofuncBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataaSet = new win0.DataaSet();
            this.tablecadastrofuncTableAdapter = new win0.DataaSetTableAdapters.tablecadastrofuncTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablecadastrofuncBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPesquisaProduto
            // 
            this.buttonPesquisaProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPesquisaProduto.BackgroundImage")));
            this.buttonPesquisaProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPesquisaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonPesquisaProduto.Location = new System.Drawing.Point(670, 12);
            this.buttonPesquisaProduto.Name = "buttonPesquisaProduto";
            this.buttonPesquisaProduto.Size = new System.Drawing.Size(118, 44);
            this.buttonPesquisaProduto.TabIndex = 3;
            this.buttonPesquisaProduto.Text = "Atualizar";
            this.buttonPesquisaProduto.UseVisualStyleBackColor = true;
            this.buttonPesquisaProduto.Click += new System.EventHandler(this.buttonPesquisaProduto_Click);
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
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.tipocadastroDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.dataAtualzacaoDataGridViewTextBoxColumn});
            this.ProdutodataGridView.DataSource = this.tablecadastrofuncBindingSource;
            this.ProdutodataGridView.GridColor = System.Drawing.Color.Magenta;
            this.ProdutodataGridView.Location = new System.Drawing.Point(12, 78);
            this.ProdutodataGridView.Name = "ProdutodataGridView";
            this.ProdutodataGridView.ReadOnly = true;
            this.ProdutodataGridView.RowHeadersWidth = 51;
            this.ProdutodataGridView.RowTemplate.Height = 24;
            this.ProdutodataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdutodataGridView.Size = new System.Drawing.Size(776, 257);
            this.ProdutodataGridView.TabIndex = 2;
            this.ProdutodataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdutodataGridView_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipocadastroDataGridViewTextBoxColumn
            // 
            this.tipocadastroDataGridViewTextBoxColumn.DataPropertyName = "tipo_cadastro";
            this.tipocadastroDataGridViewTextBoxColumn.HeaderText = "tipo_cadastro";
            this.tipocadastroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipocadastroDataGridViewTextBoxColumn.Name = "tipocadastroDataGridViewTextBoxColumn";
            this.tipocadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "dataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "dataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataAtualzacaoDataGridViewTextBoxColumn
            // 
            this.dataAtualzacaoDataGridViewTextBoxColumn.DataPropertyName = "dataAtualzacao";
            this.dataAtualzacaoDataGridViewTextBoxColumn.HeaderText = "dataAtualzacao";
            this.dataAtualzacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataAtualzacaoDataGridViewTextBoxColumn.Name = "dataAtualzacaoDataGridViewTextBoxColumn";
            this.dataAtualzacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tablecadastrofuncBindingSource
            // 
            this.tablecadastrofuncBindingSource.DataMember = "tablecadastrofunc";
            this.tablecadastrofuncBindingSource.DataSource = this.dataaSet;
            // 
            // dataaSet
            // 
            this.dataaSet.DataSetName = "DataaSet";
            this.dataaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablecadastrofuncTableAdapter
            // 
            this.tablecadastrofuncTableAdapter.ClearBeforeFill = true;
            // 
            // FormPesquisaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPesquisaProduto);
            this.Controls.Add(this.ProdutodataGridView);
            this.DoubleBuffered = true;
            this.Name = "FormPesquisaFuncionario";
            this.Text = "Pesquisa Funcionario";
            this.Load += new System.EventHandler(this.FormPesquisaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablecadastrofuncBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPesquisaProduto;
        public System.Windows.Forms.DataGridView ProdutodataGridView;
        private DataaSet dataaSet;
        private System.Windows.Forms.BindingSource tablecadastrofuncBindingSource;
        private DataaSetTableAdapters.tablecadastrofuncTableAdapter tablecadastrofuncTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipocadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAtualzacaoDataGridViewTextBoxColumn;
    }
}