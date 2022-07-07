namespace win0
{
    partial class FormCadastroProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProd));
            this.CodigoProduto = new System.Windows.Forms.Label();
            this.NomeProduto = new System.Windows.Forms.Label();
            this.unidade = new System.Windows.Forms.Label();
            this.bottonSalvar = new System.Windows.Forms.Button();
            this.DataCadastro = new System.Windows.Forms.Label();
            this.precoProduto = new System.Windows.Forms.Label();
            this.DataAtualizacao = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textNomeProduto = new System.Windows.Forms.TextBox();
            this.textDataCadProduto = new System.Windows.Forms.DateTimePicker();
            this.textDataAtualicaoProd = new System.Windows.Forms.DateTimePicker();
            this.TextPrecoProduto = new System.Windows.Forms.NumericUpDown();
            this.ButtonPesquisaProd = new System.Windows.Forms.Button();
            this.ButtonEditarProd = new System.Windows.Forms.Button();
            this.ButtonExcluir = new System.Windows.Forms.Button();
            this.textunidade_venda = new System.Windows.Forms.ComboBox();
            this.ProdutodataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataatualizacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadevendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabcadastroprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataaSet = new win0.DataaSet();
//            this.tabcadastroprodutoTableAdapter = new win0.DataaSetTableAdapters.tabcadastroprodutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TextPrecoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutodataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.AutoSize = true;
            this.CodigoProduto.BackColor = System.Drawing.Color.Transparent;
            this.CodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.CodigoProduto.Location = new System.Drawing.Point(12, 64);
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.Size = new System.Drawing.Size(52, 17);
            this.CodigoProduto.TabIndex = 0;
            this.CodigoProduto.Text = "Código";
            // 
            // NomeProduto
            // 
            this.NomeProduto.AutoSize = true;
            this.NomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.NomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.NomeProduto.Location = new System.Drawing.Point(201, 60);
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.Size = new System.Drawing.Size(99, 17);
            this.NomeProduto.TabIndex = 1;
            this.NomeProduto.Text = "Nome Produto";
            // 
            // unidade
            // 
            this.unidade.AutoSize = true;
            this.unidade.BackColor = System.Drawing.Color.Transparent;
            this.unidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.unidade.Location = new System.Drawing.Point(201, 139);
            this.unidade.Name = "unidade";
            this.unidade.Size = new System.Drawing.Size(61, 17);
            this.unidade.TabIndex = 2;
            this.unidade.Text = "Unidade";
            // 
            // bottonSalvar
            // 
            this.bottonSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.bottonSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottonSalvar.BackgroundImage")));
            this.bottonSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottonSalvar.Location = new System.Drawing.Point(578, 225);
            this.bottonSalvar.Name = "bottonSalvar";
            this.bottonSalvar.Size = new System.Drawing.Size(118, 39);
            this.bottonSalvar.TabIndex = 7;
            this.bottonSalvar.Text = "Salvar";
            this.bottonSalvar.UseVisualStyleBackColor = false;
            this.bottonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // DataCadastro
            // 
            this.DataCadastro.BackColor = System.Drawing.Color.Transparent;
            this.DataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.DataCadastro.Location = new System.Drawing.Point(361, 139);
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.Size = new System.Drawing.Size(105, 24);
            this.DataCadastro.TabIndex = 0;
            this.DataCadastro.Text = "Data Cadastro";
            // 
            // precoProduto
            // 
            this.precoProduto.BackColor = System.Drawing.Color.Transparent;
            this.precoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.precoProduto.Location = new System.Drawing.Point(13, 139);
            this.precoProduto.Name = "precoProduto";
            this.precoProduto.Size = new System.Drawing.Size(72, 25);
            this.precoProduto.TabIndex = 0;
            this.precoProduto.Text = "Preço";
            // 
            // DataAtualizacao
            // 
            this.DataAtualizacao.AutoSize = true;
            this.DataAtualizacao.BackColor = System.Drawing.Color.Transparent;
            this.DataAtualizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.DataAtualizacao.Location = new System.Drawing.Point(552, 139);
            this.DataAtualizacao.Name = "DataAtualizacao";
            this.DataAtualizacao.Size = new System.Drawing.Size(115, 17);
            this.DataAtualizacao.TabIndex = 4;
            this.DataAtualizacao.Text = "Data Atualização";
            // 
            // textCodigo
            // 
            this.textCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textCodigo.Location = new System.Drawing.Point(16, 89);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(125, 26);
            this.textCodigo.TabIndex = 1;
            this.textCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextCodigo_KeyPress);
            // 
            // textNomeProduto
            // 
            this.textNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textNomeProduto.Location = new System.Drawing.Point(204, 89);
            this.textNomeProduto.Name = "textNomeProduto";
            this.textNomeProduto.Size = new System.Drawing.Size(492, 26);
            this.textNomeProduto.TabIndex = 2;
            // 
            // textDataCadProduto
            // 
            this.textDataCadProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textDataCadProduto.Location = new System.Drawing.Point(367, 163);
            this.textDataCadProduto.Name = "textDataCadProduto";
            this.textDataCadProduto.Size = new System.Drawing.Size(125, 26);
            this.textDataCadProduto.TabIndex = 5;
            // 
            // textDataAtualicaoProd
            // 
            this.textDataAtualicaoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textDataAtualicaoProd.Location = new System.Drawing.Point(555, 163);
            this.textDataAtualicaoProd.Name = "textDataAtualicaoProd";
            this.textDataAtualicaoProd.Size = new System.Drawing.Size(123, 26);
            this.textDataAtualicaoProd.TabIndex = 6;
            // 
            // TextPrecoProduto
            // 
            this.TextPrecoProduto.DecimalPlaces = 2;
            this.TextPrecoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextPrecoProduto.Location = new System.Drawing.Point(16, 163);
            this.TextPrecoProduto.Name = "TextPrecoProduto";
            this.TextPrecoProduto.Size = new System.Drawing.Size(69, 26);
            this.TextPrecoProduto.TabIndex = 3;
            // 
            // ButtonPesquisaProd
            // 
            this.ButtonPesquisaProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPesquisaProd.BackgroundImage")));
            this.ButtonPesquisaProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonPesquisaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonPesquisaProd.Location = new System.Drawing.Point(588, 12);
            this.ButtonPesquisaProd.Name = "ButtonPesquisaProd";
            this.ButtonPesquisaProd.Size = new System.Drawing.Size(108, 27);
            this.ButtonPesquisaProd.TabIndex = 10;
            this.ButtonPesquisaProd.Text = "Pesquisa";
            this.ButtonPesquisaProd.UseVisualStyleBackColor = true;
            this.ButtonPesquisaProd.Click += new System.EventHandler(this.ButtonPesquisaProd_Click);
            // 
            // ButtonEditarProd
            // 
            this.ButtonEditarProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEditarProd.BackgroundImage")));
            this.ButtonEditarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEditarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonEditarProd.Location = new System.Drawing.Point(472, 12);
            this.ButtonEditarProd.Name = "ButtonEditarProd";
            this.ButtonEditarProd.Size = new System.Drawing.Size(110, 28);
            this.ButtonEditarProd.TabIndex = 9;
            this.ButtonEditarProd.Text = "Editar";
            this.ButtonEditarProd.UseVisualStyleBackColor = true;
            this.ButtonEditarProd.Click += new System.EventHandler(this.ButtonEditarProd_Click);
            // 
            // ButtonExcluir
            // 
            this.ButtonExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonExcluir.BackgroundImage")));
            this.ButtonExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonExcluir.Location = new System.Drawing.Point(367, 12);
            this.ButtonExcluir.Name = "ButtonExcluir";
            this.ButtonExcluir.Size = new System.Drawing.Size(99, 27);
            this.ButtonExcluir.TabIndex = 8;
            this.ButtonExcluir.Text = "Excluir";
            this.ButtonExcluir.UseVisualStyleBackColor = true;
            this.ButtonExcluir.Click += new System.EventHandler(this.ButtonExcluir_Click);
            // 
            // textunidade_venda
            // 
            this.textunidade_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textunidade_venda.FormattingEnabled = true;
            this.textunidade_venda.Items.AddRange(new object[] {
            "Litro",
            "Grama"});
            this.textunidade_venda.Location = new System.Drawing.Point(206, 163);
            this.textunidade_venda.Name = "textunidade_venda";
            this.textunidade_venda.Size = new System.Drawing.Size(94, 28);
            this.textunidade_venda.TabIndex = 11;
            // 
            // ProdutodataGridView1
            // 
            this.ProdutodataGridView1.AllowUserToAddRows = false;
            this.ProdutodataGridView1.AllowUserToDeleteRows = false;
            this.ProdutodataGridView1.AutoGenerateColumns = false;
            this.ProdutodataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdutodataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProdutodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdutodataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeprodutoDataGridViewTextBoxColumn,
            this.preçoDataGridViewTextBoxColumn,
            this.datacadastroDataGridViewTextBoxColumn,
            this.dataatualizacaoDataGridViewTextBoxColumn,
            this.unidadevendaDataGridViewTextBoxColumn});
            this.ProdutodataGridView1.DataSource = this.tabcadastroprodutoBindingSource;
            this.ProdutodataGridView1.GridColor = System.Drawing.Color.Magenta;
            this.ProdutodataGridView1.Location = new System.Drawing.Point(16, 270);
            this.ProdutodataGridView1.Name = "ProdutodataGridView1";
            this.ProdutodataGridView1.ReadOnly = true;
            this.ProdutodataGridView1.RowHeadersWidth = 51;
            this.ProdutodataGridView1.RowTemplate.Height = 24;
            this.ProdutodataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdutodataGridView1.Size = new System.Drawing.Size(670, 88);
            this.ProdutodataGridView1.TabIndex = 12;
            this.ProdutodataGridView1.Visible = false;
            this.ProdutodataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdutodataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeprodutoDataGridViewTextBoxColumn
            // 
            this.nomeprodutoDataGridViewTextBoxColumn.DataPropertyName = "nomeproduto";
            this.nomeprodutoDataGridViewTextBoxColumn.HeaderText = "nomeproduto";
            this.nomeprodutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeprodutoDataGridViewTextBoxColumn.Name = "nomeprodutoDataGridViewTextBoxColumn";
            this.nomeprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preçoDataGridViewTextBoxColumn
            // 
            this.preçoDataGridViewTextBoxColumn.DataPropertyName = "preço";
            this.preçoDataGridViewTextBoxColumn.HeaderText = "preço";
            this.preçoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preçoDataGridViewTextBoxColumn.Name = "preçoDataGridViewTextBoxColumn";
            this.preçoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datacadastroDataGridViewTextBoxColumn
            // 
            this.datacadastroDataGridViewTextBoxColumn.DataPropertyName = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.HeaderText = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datacadastroDataGridViewTextBoxColumn.Name = "datacadastroDataGridViewTextBoxColumn";
            this.datacadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataatualizacaoDataGridViewTextBoxColumn
            // 
            this.dataatualizacaoDataGridViewTextBoxColumn.DataPropertyName = "data_atualizacao";
            this.dataatualizacaoDataGridViewTextBoxColumn.HeaderText = "data_atualizacao";
            this.dataatualizacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataatualizacaoDataGridViewTextBoxColumn.Name = "dataatualizacaoDataGridViewTextBoxColumn";
            this.dataatualizacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadevendaDataGridViewTextBoxColumn
            // 
            this.unidadevendaDataGridViewTextBoxColumn.DataPropertyName = "unidade_venda";
            this.unidadevendaDataGridViewTextBoxColumn.HeaderText = "unidade_venda";
            this.unidadevendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadevendaDataGridViewTextBoxColumn.Name = "unidadevendaDataGridViewTextBoxColumn";
            this.unidadevendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabcadastroprodutoBindingSource
            // 
            this.tabcadastroprodutoBindingSource.DataMember = "tabcadastroproduto";
            this.tabcadastroprodutoBindingSource.DataSource = this.dataaSet;
            // 
            // dataaSet
            
            // tabcadastroprodutoTableAdapter
            // 
            // 
            // FormCadastroProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 406);
            this.Controls.Add(this.ProdutodataGridView1);
            this.Controls.Add(this.textunidade_venda);
            this.Controls.Add(this.ButtonExcluir);
            this.Controls.Add(this.ButtonEditarProd);
            this.Controls.Add(this.ButtonPesquisaProd);
            this.Controls.Add(this.TextPrecoProduto);
            this.Controls.Add(this.textDataAtualicaoProd);
            this.Controls.Add(this.textDataCadProduto);
            this.Controls.Add(this.textNomeProduto);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.DataAtualizacao);
            this.Controls.Add(this.precoProduto);
            this.Controls.Add(this.DataCadastro);
            this.Controls.Add(this.bottonSalvar);
            this.Controls.Add(this.unidade);
            this.Controls.Add(this.NomeProduto);
            this.Controls.Add(this.CodigoProduto);
            this.DoubleBuffered = true;
            this.Name = "FormCadastroProd";
            this.Text = "Cadastro de Produto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadastroProduto);
            this.Load += new System.EventHandler(this.FormCadastroProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextPrecoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutodataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CodigoProduto;
        private System.Windows.Forms.Label NomeProduto;
        private System.Windows.Forms.Label unidade;
        private System.Windows.Forms.Button bottonSalvar;
        private System.Windows.Forms.Label DataCadastro;
        private System.Windows.Forms.Label precoProduto;
        private System.Windows.Forms.Label DataAtualizacao;
        private System.Windows.Forms.Button ButtonPesquisaProd;
        private System.Windows.Forms.Button ButtonEditarProd;
        private System.Windows.Forms.Button ButtonExcluir;
        public System.Windows.Forms.TextBox textCodigo;
        public System.Windows.Forms.TextBox textNomeProduto;
        public System.Windows.Forms.DateTimePicker textDataCadProduto;
        public System.Windows.Forms.DateTimePicker textDataAtualicaoProd;
        public System.Windows.Forms.NumericUpDown TextPrecoProduto;
        private System.Windows.Forms.ComboBox textunidade_venda;
        public System.Windows.Forms.DataGridView ProdutodataGridView1;
        private DataaSet dataaSet;
        private System.Windows.Forms.BindingSource tabcadastroprodutoBindingSource;
        private DataaSetTableAdapters.tabcadastroprodutoTableAdapter tabcadastroprodutoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataatualizacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadevendaDataGridViewTextBoxColumn;
    }
}