namespace win0.Moledo
{
    partial class FormCadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroFuncionario));
            this.labelNomeFunc = new System.Windows.Forms.Label();
            this.label_cpf = new System.Windows.Forms.Label();
            this.labelcodigofunc = new System.Windows.Forms.Label();
            this.TextDataAtualizacaoFun = new System.Windows.Forms.DateTimePicker();
            this.TextNomeFunc = new System.Windows.Forms.TextBox();
            this.TextCodigoFunc = new System.Windows.Forms.TextBox();
            this.dataAtualização = new System.Windows.Forms.Label();
            this.ButtonEscluirCliente = new System.Windows.Forms.Button();
            this.ButtonEditarCliente = new System.Windows.Forms.Button();
            this.ButtonPesquisarCliente = new System.Windows.Forms.Button();
            this.buttonSalvarFuncionario = new System.Windows.Forms.Button();
            this.TextSexo = new System.Windows.Forms.ComboBox();
            this.labelsexo = new System.Windows.Forms.Label();
            this.TextTipoContrato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextCpf = new System.Windows.Forms.MaskedTextBox();
            this.dataCadastro = new System.Windows.Forms.Label();
            this.TextDataCadastroFun = new System.Windows.Forms.DateTimePicker();
            this.ProdutodataGridView = new System.Windows.Forms.DataGridView();
            this.dataaSet = new win0.DataaSet();
            this.tabcadastroprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabcadastroprodutoTableAdapter = new win0.DataaSetTableAdapters.tabcadastroprodutoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataatualizacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadevendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeFunc
            // 
            this.labelNomeFunc.AutoSize = true;
            this.labelNomeFunc.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelNomeFunc.Location = new System.Drawing.Point(245, 40);
            this.labelNomeFunc.Name = "labelNomeFunc";
            this.labelNomeFunc.Size = new System.Drawing.Size(45, 17);
            this.labelNomeFunc.TabIndex = 33;
            this.labelNomeFunc.Text = "Nome";
            // 
            // label_cpf
            // 
            this.label_cpf.AutoSize = true;
            this.label_cpf.BackColor = System.Drawing.Color.Transparent;
            this.label_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label_cpf.Location = new System.Drawing.Point(5, 114);
            this.label_cpf.Name = "label_cpf";
            this.label_cpf.Size = new System.Drawing.Size(34, 17);
            this.label_cpf.TabIndex = 31;
            this.label_cpf.Text = "CPF";
            // 
            // labelcodigofunc
            // 
            this.labelcodigofunc.AutoSize = true;
            this.labelcodigofunc.BackColor = System.Drawing.Color.Transparent;
            this.labelcodigofunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelcodigofunc.Location = new System.Drawing.Point(2, 40);
            this.labelcodigofunc.Name = "labelcodigofunc";
            this.labelcodigofunc.Size = new System.Drawing.Size(130, 17);
            this.labelcodigofunc.TabIndex = 30;
            this.labelcodigofunc.Text = "Código Funcionário";
            // 
            // TextDataAtualizacaoFun
            // 
            this.TextDataAtualizacaoFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextDataAtualizacaoFun.Location = new System.Drawing.Point(248, 213);
            this.TextDataAtualizacaoFun.Name = "TextDataAtualizacaoFun";
            this.TextDataAtualizacaoFun.Size = new System.Drawing.Size(123, 26);
            this.TextDataAtualizacaoFun.TabIndex = 23;
            // 
            // TextNomeFunc
            // 
            this.TextNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextNomeFunc.Location = new System.Drawing.Point(248, 69);
            this.TextNomeFunc.Name = "TextNomeFunc";
            this.TextNomeFunc.Size = new System.Drawing.Size(478, 26);
            this.TextNomeFunc.TabIndex = 18;
            // 
            // TextCodigoFunc
            // 
            this.TextCodigoFunc.BackColor = System.Drawing.Color.White;
            this.TextCodigoFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextCodigoFunc.Location = new System.Drawing.Point(8, 69);
            this.TextCodigoFunc.Name = "TextCodigoFunc";
            this.TextCodigoFunc.Size = new System.Drawing.Size(70, 26);
            this.TextCodigoFunc.TabIndex = 17;
            // 
            // dataAtualização
            // 
            this.dataAtualização.AutoSize = true;
            this.dataAtualização.BackColor = System.Drawing.Color.Transparent;
            this.dataAtualização.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dataAtualização.Location = new System.Drawing.Point(245, 185);
            this.dataAtualização.Name = "dataAtualização";
            this.dataAtualização.Size = new System.Drawing.Size(115, 17);
            this.dataAtualização.TabIndex = 24;
            this.dataAtualização.Text = "Data Atualização";
            // 
            // ButtonEscluirCliente
            // 
            this.ButtonEscluirCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEscluirCliente.BackgroundImage")));
            this.ButtonEscluirCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEscluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonEscluirCliente.Location = new System.Drawing.Point(489, 5);
            this.ButtonEscluirCliente.Name = "ButtonEscluirCliente";
            this.ButtonEscluirCliente.Size = new System.Drawing.Size(103, 34);
            this.ButtonEscluirCliente.TabIndex = 27;
            this.ButtonEscluirCliente.Text = "Excluir";
            this.ButtonEscluirCliente.UseVisualStyleBackColor = true;
            this.ButtonEscluirCliente.Click += new System.EventHandler(this.ButtonEscluirCliente_Click);
            // 
            // ButtonEditarCliente
            // 
            this.ButtonEditarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEditarCliente.BackgroundImage")));
            this.ButtonEditarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonEditarCliente.Location = new System.Drawing.Point(607, 5);
            this.ButtonEditarCliente.Name = "ButtonEditarCliente";
            this.ButtonEditarCliente.Size = new System.Drawing.Size(91, 34);
            this.ButtonEditarCliente.TabIndex = 28;
            this.ButtonEditarCliente.Text = "Editar";
            this.ButtonEditarCliente.UseVisualStyleBackColor = true;
            this.ButtonEditarCliente.Click += new System.EventHandler(this.ButtonEditarCliente_Click);
            // 
            // ButtonPesquisarCliente
            // 
            this.ButtonPesquisarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPesquisarCliente.BackgroundImage")));
            this.ButtonPesquisarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonPesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonPesquisarCliente.Location = new System.Drawing.Point(704, 5);
            this.ButtonPesquisarCliente.Name = "ButtonPesquisarCliente";
            this.ButtonPesquisarCliente.Size = new System.Drawing.Size(94, 34);
            this.ButtonPesquisarCliente.TabIndex = 29;
            this.ButtonPesquisarCliente.Text = "Pesquisa";
            this.ButtonPesquisarCliente.UseVisualStyleBackColor = true;
            this.ButtonPesquisarCliente.Click += new System.EventHandler(this.ButtonPesquisarCliente_Click);
            // 
            // buttonSalvarFuncionario
            // 
            this.buttonSalvarFuncionario.BackColor = System.Drawing.Color.White;
            this.buttonSalvarFuncionario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSalvarFuncionario.BackgroundImage")));
            this.buttonSalvarFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSalvarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonSalvarFuncionario.Location = new System.Drawing.Point(624, 394);
            this.buttonSalvarFuncionario.Name = "buttonSalvarFuncionario";
            this.buttonSalvarFuncionario.Size = new System.Drawing.Size(164, 49);
            this.buttonSalvarFuncionario.TabIndex = 26;
            this.buttonSalvarFuncionario.Text = "Salvar";
            this.buttonSalvarFuncionario.UseVisualStyleBackColor = false;
            this.buttonSalvarFuncionario.Click += new System.EventHandler(this.buttonSalvarFuncionario_Click);
            // 
            // TextSexo
            // 
            this.TextSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextSexo.FormattingEnabled = true;
            this.TextSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.TextSexo.Location = new System.Drawing.Point(248, 134);
            this.TextSexo.Name = "TextSexo";
            this.TextSexo.Size = new System.Drawing.Size(139, 24);
            this.TextSexo.TabIndex = 34;
            // 
            // labelsexo
            // 
            this.labelsexo.AutoSize = true;
            this.labelsexo.BackColor = System.Drawing.Color.Transparent;
            this.labelsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelsexo.Location = new System.Drawing.Point(245, 114);
            this.labelsexo.Name = "labelsexo";
            this.labelsexo.Size = new System.Drawing.Size(39, 17);
            this.labelsexo.TabIndex = 35;
            this.labelsexo.Text = "Sexo";
            // 
            // TextTipoContrato
            // 
            this.TextTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextTipoContrato.FormattingEnabled = true;
            this.TextTipoContrato.Items.AddRange(new object[] {
            "CLT",
            "PJ"});
            this.TextTipoContrato.Location = new System.Drawing.Point(470, 134);
            this.TextTipoContrato.Name = "TextTipoContrato";
            this.TextTipoContrato.Size = new System.Drawing.Size(158, 24);
            this.TextTipoContrato.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(467, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tipo Contrato";
            // 
            // TextCpf
            // 
            this.TextCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.TextCpf.Location = new System.Drawing.Point(8, 135);
            this.TextCpf.Mask = "000.000.000-00";
            this.TextCpf.Name = "TextCpf";
            this.TextCpf.Size = new System.Drawing.Size(108, 23);
            this.TextCpf.TabIndex = 38;
            // 
            // dataCadastro
            // 
            this.dataCadastro.AutoSize = true;
            this.dataCadastro.BackColor = System.Drawing.Color.Transparent;
            this.dataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dataCadastro.Location = new System.Drawing.Point(5, 185);
            this.dataCadastro.Name = "dataCadastro";
            this.dataCadastro.Size = new System.Drawing.Size(99, 17);
            this.dataCadastro.TabIndex = 21;
            this.dataCadastro.Text = "Data Cadastro";
            // 
            // TextDataCadastroFun
            // 
            this.TextDataCadastroFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextDataCadastroFun.Location = new System.Drawing.Point(5, 213);
            this.TextDataCadastroFun.Name = "TextDataCadastroFun";
            this.TextDataCadastroFun.Size = new System.Drawing.Size(125, 26);
            this.TextDataCadastroFun.TabIndex = 22;
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
            this.nomeprodutoDataGridViewTextBoxColumn,
            this.preçoDataGridViewTextBoxColumn,
            this.datacadastroDataGridViewTextBoxColumn,
            this.dataatualizacaoDataGridViewTextBoxColumn,
            this.unidadevendaDataGridViewTextBoxColumn});
            this.ProdutodataGridView.DataSource = this.tabcadastroprodutoBindingSource;
            this.ProdutodataGridView.GridColor = System.Drawing.Color.Magenta;
            this.ProdutodataGridView.Location = new System.Drawing.Point(12, 254);
            this.ProdutodataGridView.Name = "ProdutodataGridView";
            this.ProdutodataGridView.ReadOnly = true;
            this.ProdutodataGridView.RowHeadersWidth = 51;
            this.ProdutodataGridView.RowTemplate.Height = 24;
            this.ProdutodataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdutodataGridView.Size = new System.Drawing.Size(776, 119);
            this.ProdutodataGridView.TabIndex = 39;
            // 
            // dataaSet
            // 
            this.dataaSet.DataSetName = "DataaSet";
            this.dataaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // FormCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 442);
            this.Controls.Add(this.ProdutodataGridView);
            this.Controls.Add(this.TextCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextTipoContrato);
            this.Controls.Add(this.labelsexo);
            this.Controls.Add(this.TextSexo);
            this.Controls.Add(this.labelNomeFunc);
            this.Controls.Add(this.label_cpf);
            this.Controls.Add(this.labelcodigofunc);
            this.Controls.Add(this.TextDataAtualizacaoFun);
            this.Controls.Add(this.TextDataCadastroFun);
            this.Controls.Add(this.ButtonEscluirCliente);
            this.Controls.Add(this.ButtonEditarCliente);
            this.Controls.Add(this.ButtonPesquisarCliente);
            this.Controls.Add(this.TextNomeFunc);
            this.Controls.Add(this.TextCodigoFunc);
            this.Controls.Add(this.buttonSalvarFuncionario);
            this.Controls.Add(this.dataAtualização);
            this.Controls.Add(this.dataCadastro);
            this.DoubleBuffered = true;
            this.Name = "FormCadastroFuncionario";
            this.Text = "Cadastro Funcionário";
            this.Load += new System.EventHandler(this.FormCadastroFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNomeFunc;
        private System.Windows.Forms.Label label_cpf;
        private System.Windows.Forms.Label labelcodigofunc;
        public System.Windows.Forms.DateTimePicker TextDataAtualizacaoFun;
        private System.Windows.Forms.Button ButtonEscluirCliente;
        private System.Windows.Forms.Button ButtonEditarCliente;
        private System.Windows.Forms.Button ButtonPesquisarCliente;
        public System.Windows.Forms.TextBox TextNomeFunc;
        public System.Windows.Forms.TextBox TextCodigoFunc;
        private System.Windows.Forms.Button buttonSalvarFuncionario;
        private System.Windows.Forms.Label dataAtualização;
        private System.Windows.Forms.ComboBox TextSexo;
        private System.Windows.Forms.Label labelsexo;
        private System.Windows.Forms.ComboBox TextTipoContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TextCpf;
        private System.Windows.Forms.Label dataCadastro;
        public System.Windows.Forms.DateTimePicker TextDataCadastroFun;
        public System.Windows.Forms.DataGridView ProdutodataGridView;
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