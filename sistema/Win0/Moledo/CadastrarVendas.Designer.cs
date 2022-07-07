namespace win0.Moledo
{
    partial class FormRealizarVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRealizarVendas));
            this.LabelIdVenda = new System.Windows.Forms.Label();
            this.TextCodigoVenda = new System.Windows.Forms.TextBox();
            this.tabvendasitensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelNumeroNF = new System.Windows.Forms.Label();
            this.LabelNomeCliente = new System.Windows.Forms.Label();
            this.TextCodigoCliente = new System.Windows.Forms.TextBox();
            this.buttonPesqCliente = new System.Windows.Forms.Button();
            this.LabelCodigoCliente = new System.Windows.Forms.Label();
            this.TextNomeCliente = new System.Windows.Forms.TextBox();
            this.TextNumeroNF = new System.Windows.Forms.MaskedTextBox();
            this.TextDataPedido = new System.Windows.Forms.DateTimePicker();
            this.LabeldataPedido = new System.Windows.Forms.Label();
            this.TextDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.labeldataEntrega = new System.Windows.Forms.Label();
            this.TextDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.labeldataEmissao = new System.Windows.Forms.Label();
            this.buttonAdicionarItens = new System.Windows.Forms.Button();
            this.buttonExcluirVenda = new System.Windows.Forms.Button();
            this.buttonPesquisaVenda = new System.Windows.Forms.Button();
            this.buttonSalvarVaiPraItemVenda = new System.Windows.Forms.Button();
            this.ButtonEditarCliente = new System.Windows.Forms.Button();
            this.tabcadastroclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelValor = new System.Windows.Forms.Label();
            this.textValorTotal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendasitensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textValorTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelIdVenda
            // 
            this.LabelIdVenda.AutoSize = true;
            this.LabelIdVenda.BackColor = System.Drawing.Color.Transparent;
            this.LabelIdVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelIdVenda.Location = new System.Drawing.Point(12, 16);
            this.LabelIdVenda.Name = "LabelIdVenda";
            this.LabelIdVenda.Size = new System.Drawing.Size(97, 17);
            this.LabelIdVenda.TabIndex = 57;
            this.LabelIdVenda.Text = "Código Venda";
            // 
            // TextCodigoVenda
            // 
            this.TextCodigoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextCodigoVenda.Location = new System.Drawing.Point(12, 44);
            this.TextCodigoVenda.Name = "TextCodigoVenda";
            this.TextCodigoVenda.Size = new System.Drawing.Size(82, 26);
            this.TextCodigoVenda.TabIndex = 56;
            this.TextCodigoVenda.TextChanged += new System.EventHandler(this.TextCodigoVenda_TextChanged);
            // 
            // tabvendasitensBindingSource
            // 
            this.tabvendasitensBindingSource.DataMember = "tabvendas_itens";
            // 
            // LabelNumeroNF
            // 
            this.LabelNumeroNF.AutoSize = true;
            this.LabelNumeroNF.BackColor = System.Drawing.Color.Transparent;
            this.LabelNumeroNF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelNumeroNF.Location = new System.Drawing.Point(627, 80);
            this.LabelNumeroNF.Name = "LabelNumeroNF";
            this.LabelNumeroNF.Size = new System.Drawing.Size(80, 17);
            this.LabelNumeroNF.TabIndex = 59;
            this.LabelNumeroNF.Text = "Numero NF";
            // 
            // LabelNomeCliente
            // 
            this.LabelNomeCliente.AutoSize = true;
            this.LabelNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.LabelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelNomeCliente.Location = new System.Drawing.Point(166, 80);
            this.LabelNomeCliente.Name = "LabelNomeCliente";
            this.LabelNomeCliente.Size = new System.Drawing.Size(92, 17);
            this.LabelNomeCliente.TabIndex = 60;
            this.LabelNomeCliente.Text = "Nome Cliente";
            // 
            // TextCodigoCliente
            // 
            this.TextCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextCodigoCliente.Location = new System.Drawing.Point(14, 100);
            this.TextCodigoCliente.Name = "TextCodigoCliente";
            this.TextCodigoCliente.Size = new System.Drawing.Size(82, 26);
            this.TextCodigoCliente.TabIndex = 57;
            // 
            // buttonPesqCliente
            // 
            this.buttonPesqCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPesqCliente.BackgroundImage")));
            this.buttonPesqCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPesqCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonPesqCliente.Location = new System.Drawing.Point(439, 93);
            this.buttonPesqCliente.Name = "buttonPesqCliente";
            this.buttonPesqCliente.Size = new System.Drawing.Size(160, 33);
            this.buttonPesqCliente.TabIndex = 58;
            this.buttonPesqCliente.Text = "Pesquisar Cliente";
            this.buttonPesqCliente.UseVisualStyleBackColor = true;
            this.buttonPesqCliente.Click += new System.EventHandler(this.buttonPesqCliente_Click);
            // 
            // LabelCodigoCliente
            // 
            this.LabelCodigoCliente.AutoSize = true;
            this.LabelCodigoCliente.BackColor = System.Drawing.Color.Transparent;
            this.LabelCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelCodigoCliente.Location = new System.Drawing.Point(11, 80);
            this.LabelCodigoCliente.Name = "LabelCodigoCliente";
            this.LabelCodigoCliente.Size = new System.Drawing.Size(99, 17);
            this.LabelCodigoCliente.TabIndex = 56;
            this.LabelCodigoCliente.Text = "Código Cliente";
            // 
            // TextNomeCliente
            // 
            this.TextNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextNomeCliente.Location = new System.Drawing.Point(169, 102);
            this.TextNomeCliente.Name = "TextNomeCliente";
            this.TextNomeCliente.Size = new System.Drawing.Size(255, 26);
            this.TextNomeCliente.TabIndex = 59;
            // 
            // TextNumeroNF
            // 
            this.TextNumeroNF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextNumeroNF.Location = new System.Drawing.Point(630, 100);
            this.TextNumeroNF.Mask = "000.000.000";
            this.TextNumeroNF.Name = "TextNumeroNF";
            this.TextNumeroNF.Size = new System.Drawing.Size(104, 26);
            this.TextNumeroNF.TabIndex = 61;
            // 
            // TextDataPedido
            // 
            this.TextDataPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextDataPedido.Location = new System.Drawing.Point(169, 179);
            this.TextDataPedido.Name = "TextDataPedido";
            this.TextDataPedido.Size = new System.Drawing.Size(125, 26);
            this.TextDataPedido.TabIndex = 62;
            // 
            // LabeldataPedido
            // 
            this.LabeldataPedido.AutoSize = true;
            this.LabeldataPedido.BackColor = System.Drawing.Color.Transparent;
            this.LabeldataPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabeldataPedido.Location = new System.Drawing.Point(169, 151);
            this.LabeldataPedido.Name = "LabeldataPedido";
            this.LabeldataPedido.Size = new System.Drawing.Size(86, 17);
            this.LabeldataPedido.TabIndex = 63;
            this.LabeldataPedido.Text = "Data Pedido";
            // 
            // TextDataEntrega
            // 
            this.TextDataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextDataEntrega.Location = new System.Drawing.Point(344, 179);
            this.TextDataEntrega.Name = "TextDataEntrega";
            this.TextDataEntrega.Size = new System.Drawing.Size(125, 26);
            this.TextDataEntrega.TabIndex = 64;
            // 
            // labeldataEntrega
            // 
            this.labeldataEntrega.AutoSize = true;
            this.labeldataEntrega.BackColor = System.Drawing.Color.Transparent;
            this.labeldataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labeldataEntrega.Location = new System.Drawing.Point(344, 151);
            this.labeldataEntrega.Name = "labeldataEntrega";
            this.labeldataEntrega.Size = new System.Drawing.Size(92, 17);
            this.labeldataEntrega.TabIndex = 65;
            this.labeldataEntrega.Text = "Data Entrega";
            // 
            // TextDataEmissao
            // 
            this.TextDataEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextDataEmissao.Location = new System.Drawing.Point(507, 179);
            this.TextDataEmissao.Name = "TextDataEmissao";
            this.TextDataEmissao.Size = new System.Drawing.Size(125, 26);
            this.TextDataEmissao.TabIndex = 66;
            // 
            // labeldataEmissao
            // 
            this.labeldataEmissao.AutoSize = true;
            this.labeldataEmissao.BackColor = System.Drawing.Color.Transparent;
            this.labeldataEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labeldataEmissao.Location = new System.Drawing.Point(507, 151);
            this.labeldataEmissao.Name = "labeldataEmissao";
            this.labeldataEmissao.Size = new System.Drawing.Size(95, 17);
            this.labeldataEmissao.TabIndex = 67;
            this.labeldataEmissao.Text = "Data Emissão";
            // 
            // buttonAdicionarItens
            // 
            this.buttonAdicionarItens.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarItens.BackgroundImage")));
            this.buttonAdicionarItens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdicionarItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonAdicionarItens.Location = new System.Drawing.Point(476, 284);
            this.buttonAdicionarItens.Name = "buttonAdicionarItens";
            this.buttonAdicionarItens.Size = new System.Drawing.Size(123, 36);
            this.buttonAdicionarItens.TabIndex = 68;
            this.buttonAdicionarItens.Text = "Adicionar Itens";
            this.buttonAdicionarItens.UseVisualStyleBackColor = true;
            this.buttonAdicionarItens.Click += new System.EventHandler(this.buttonSalvarVenda_Click);
            // 
            // buttonExcluirVenda
            // 
            this.buttonExcluirVenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExcluirVenda.BackgroundImage")));
            this.buttonExcluirVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExcluirVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonExcluirVenda.Location = new System.Drawing.Point(560, 12);
            this.buttonExcluirVenda.Name = "buttonExcluirVenda";
            this.buttonExcluirVenda.Size = new System.Drawing.Size(103, 34);
            this.buttonExcluirVenda.TabIndex = 69;
            this.buttonExcluirVenda.Text = "Excluir";
            this.buttonExcluirVenda.UseVisualStyleBackColor = true;
            this.buttonExcluirVenda.Click += new System.EventHandler(this.buttonExcluirVenda_Click);
            // 
            // buttonPesquisaVenda
            // 
            this.buttonPesquisaVenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPesquisaVenda.BackgroundImage")));
            this.buttonPesquisaVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPesquisaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonPesquisaVenda.Location = new System.Drawing.Point(669, 12);
            this.buttonPesquisaVenda.Name = "buttonPesquisaVenda";
            this.buttonPesquisaVenda.Size = new System.Drawing.Size(94, 34);
            this.buttonPesquisaVenda.TabIndex = 56;
            this.buttonPesquisaVenda.Text = "Pesquisa";
            this.buttonPesquisaVenda.UseVisualStyleBackColor = true;
            this.buttonPesquisaVenda.Click += new System.EventHandler(this.buttonPesquisaVenda_Click);
            // 
            // buttonSalvarVaiPraItemVenda
            // 
            this.buttonSalvarVaiPraItemVenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSalvarVaiPraItemVenda.BackgroundImage")));
            this.buttonSalvarVaiPraItemVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSalvarVaiPraItemVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSalvarVaiPraItemVenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSalvarVaiPraItemVenda.Location = new System.Drawing.Point(623, 284);
            this.buttonSalvarVaiPraItemVenda.Name = "buttonSalvarVaiPraItemVenda";
            this.buttonSalvarVaiPraItemVenda.Size = new System.Drawing.Size(140, 37);
            this.buttonSalvarVaiPraItemVenda.TabIndex = 70;
            this.buttonSalvarVaiPraItemVenda.Text = "Salva ";
            this.buttonSalvarVaiPraItemVenda.UseVisualStyleBackColor = true;
            this.buttonSalvarVaiPraItemVenda.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonEditarCliente
            // 
            this.ButtonEditarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEditarCliente.BackgroundImage")));
            this.ButtonEditarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonEditarCliente.Location = new System.Drawing.Point(463, 12);
            this.ButtonEditarCliente.Name = "ButtonEditarCliente";
            this.ButtonEditarCliente.Size = new System.Drawing.Size(91, 33);
            this.ButtonEditarCliente.TabIndex = 72;
            this.ButtonEditarCliente.Text = "Editar";
            this.ButtonEditarCliente.UseVisualStyleBackColor = true;
            // 
            // tabcadastroclienteBindingSource
            // 
            this.tabcadastroclienteBindingSource.DataMember = "tabcadastrocliente";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.BackColor = System.Drawing.Color.Transparent;
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelValor.Location = new System.Drawing.Point(12, 151);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(41, 17);
            this.labelValor.TabIndex = 73;
            this.labelValor.Text = "Valor";
            // 
            // textValorTotal
            // 
            this.textValorTotal.DecimalPlaces = 2;
            this.textValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textValorTotal.Location = new System.Drawing.Point(12, 179);
            this.textValorTotal.Name = "textValorTotal";
            this.textValorTotal.Size = new System.Drawing.Size(84, 26);
            this.textValorTotal.TabIndex = 75;
            // 
            // FormRealizarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 373);
            this.Controls.Add(this.textValorTotal);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.ButtonEditarCliente);
            this.Controls.Add(this.buttonSalvarVaiPraItemVenda);
            this.Controls.Add(this.buttonPesquisaVenda);
            this.Controls.Add(this.buttonExcluirVenda);
            this.Controls.Add(this.buttonAdicionarItens);
            this.Controls.Add(this.TextDataEmissao);
            this.Controls.Add(this.labeldataEmissao);
            this.Controls.Add(this.TextDataEntrega);
            this.Controls.Add(this.labeldataEntrega);
            this.Controls.Add(this.TextDataPedido);
            this.Controls.Add(this.TextNumeroNF);
            this.Controls.Add(this.LabeldataPedido);
            this.Controls.Add(this.LabelNomeCliente);
            this.Controls.Add(this.TextCodigoCliente);
            this.Controls.Add(this.LabelNumeroNF);
            this.Controls.Add(this.buttonPesqCliente);
            this.Controls.Add(this.LabelCodigoCliente);
            this.Controls.Add(this.TextCodigoVenda);
            this.Controls.Add(this.TextNomeCliente);
            this.Controls.Add(this.LabelIdVenda);
            this.DoubleBuffered = true;
            this.Name = "FormRealizarVendas";
            this.Text = "Venda ";
            this.Load += new System.EventHandler(this.FormRealizarVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabvendasitensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textValorTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelIdVenda;
        private System.Windows.Forms.TextBox TextCodigoVenda;
        private System.Windows.Forms.Label LabelNumeroNF;
        private System.Windows.Forms.Label LabelNomeCliente;
        private System.Windows.Forms.TextBox TextCodigoCliente;
        private System.Windows.Forms.Button buttonPesqCliente;
        private System.Windows.Forms.Label LabelCodigoCliente;
        private System.Windows.Forms.TextBox TextNomeCliente;
        private System.Windows.Forms.MaskedTextBox TextNumeroNF;
        public System.Windows.Forms.DateTimePicker TextDataPedido;
        private System.Windows.Forms.Label LabeldataPedido;
        public System.Windows.Forms.DateTimePicker TextDataEntrega;
        private System.Windows.Forms.Label labeldataEntrega;
        public System.Windows.Forms.DateTimePicker TextDataEmissao;
        private System.Windows.Forms.Label labeldataEmissao;
        private System.Windows.Forms.Button buttonAdicionarItens;
        private System.Windows.Forms.Button buttonExcluirVenda;
        private System.Windows.Forms.Button buttonPesquisaVenda;
//        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource tabvendasitensBindingSource;
//        private DataSet2TableAdapters.tabvendas_itensTableAdapter tabvendas_itensTableAdapter;
        private System.Windows.Forms.Button buttonSalvarVaiPraItemVenda;
        private System.Windows.Forms.Button ButtonEditarCliente;
        private System.Windows.Forms.BindingSource tabcadastroclienteBindingSource;
//        private DataSet2TableAdapters.tabcadastroclienteTableAdapter tabcadastroclienteTableAdapter;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.NumericUpDown textValorTotal;
    }
}