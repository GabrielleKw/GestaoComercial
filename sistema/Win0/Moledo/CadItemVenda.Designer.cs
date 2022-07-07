namespace win0.Moledo
{
    partial class FormCadItemVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadItemVenda));
            this.tabvendasitensBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonSalvaVendaItem = new System.Windows.Forms.Button();
            this.ButtonEditarVendaItem = new System.Windows.Forms.Button();
            this.ButtonPesquisarVendaItem = new System.Windows.Forms.Button();
            this.ButtonExcluirVendaItem = new System.Windows.Forms.Button();
            this.TextValorTotalVendaItem = new System.Windows.Forms.NumericUpDown();
            this.LabelValorUnid = new System.Windows.Forms.Label();
            this.LabelValorTotalItem = new System.Windows.Forms.Label();
            this.LabelNomeProduto = new System.Windows.Forms.Label();
            this.TextCodigoProd = new System.Windows.Forms.TextBox();
            this.ButtonPesqProd = new System.Windows.Forms.Button();
            this.labelCodigoProd = new System.Windows.Forms.Label();
            this.TextValorUnid = new System.Windows.Forms.NumericUpDown();
            this.TextNomeProduto = new System.Windows.Forms.TextBox();
            this.TextQuantidade = new System.Windows.Forms.TextBox();
            this.LabelQuantidade = new System.Windows.Forms.Label();
            this.LabelCodigoItemVenda = new System.Windows.Forms.Label();
            this.tabvendasitensBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabvendasitensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabcadastroprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabcadastroprodutoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabcadastroprodutoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textCodigoItemVenda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendasitensBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextValorTotalVendaItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextValorUnid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendasitensBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendasitensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabvendasitensBindingSource2
            // 
            this.tabvendasitensBindingSource2.DataMember = "tabvendas_itens";
            // 
            // ButtonSalvaVendaItem
            // 
            this.ButtonSalvaVendaItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSalvaVendaItem.BackgroundImage")));
            this.ButtonSalvaVendaItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSalvaVendaItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonSalvaVendaItem.Location = new System.Drawing.Point(455, 179);
            this.ButtonSalvaVendaItem.Name = "ButtonSalvaVendaItem";
            this.ButtonSalvaVendaItem.Size = new System.Drawing.Size(123, 36);
            this.ButtonSalvaVendaItem.TabIndex = 8;
            this.ButtonSalvaVendaItem.Text = "Salvar Produto";
            this.ButtonSalvaVendaItem.UseVisualStyleBackColor = true;
            this.ButtonSalvaVendaItem.Click += new System.EventHandler(this.ButtonSalvaVendaItem_Click);
            // 
            // ButtonEditarVendaItem
            // 
            this.ButtonEditarVendaItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEditarVendaItem.BackgroundImage")));
            this.ButtonEditarVendaItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEditarVendaItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonEditarVendaItem.Location = new System.Drawing.Point(561, 21);
            this.ButtonEditarVendaItem.Name = "ButtonEditarVendaItem";
            this.ButtonEditarVendaItem.Size = new System.Drawing.Size(91, 34);
            this.ButtonEditarVendaItem.TabIndex = 10;
            this.ButtonEditarVendaItem.Text = "Editar";
            this.ButtonEditarVendaItem.UseVisualStyleBackColor = true;
            // 
            // ButtonPesquisarVendaItem
            // 
            this.ButtonPesquisarVendaItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPesquisarVendaItem.BackgroundImage")));
            this.ButtonPesquisarVendaItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonPesquisarVendaItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonPesquisarVendaItem.Location = new System.Drawing.Point(684, 21);
            this.ButtonPesquisarVendaItem.Name = "ButtonPesquisarVendaItem";
            this.ButtonPesquisarVendaItem.Size = new System.Drawing.Size(94, 34);
            this.ButtonPesquisarVendaItem.TabIndex = 11;
            this.ButtonPesquisarVendaItem.Text = "Pesquisa";
            this.ButtonPesquisarVendaItem.UseVisualStyleBackColor = true;
            this.ButtonPesquisarVendaItem.Click += new System.EventHandler(this.ButtonPesquisarVendaItem_Click);
            // 
            // ButtonExcluirVendaItem
            // 
            this.ButtonExcluirVendaItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonExcluirVendaItem.BackgroundImage")));
            this.ButtonExcluirVendaItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonExcluirVendaItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonExcluirVendaItem.Location = new System.Drawing.Point(444, 21);
            this.ButtonExcluirVendaItem.Name = "ButtonExcluirVendaItem";
            this.ButtonExcluirVendaItem.Size = new System.Drawing.Size(103, 34);
            this.ButtonExcluirVendaItem.TabIndex = 9;
            this.ButtonExcluirVendaItem.Text = "Excluir";
            this.ButtonExcluirVendaItem.UseVisualStyleBackColor = true;
            this.ButtonExcluirVendaItem.Click += new System.EventHandler(this.ButtonExcluirVendaItem_Click);
            // 
            // TextValorTotalVendaItem
            // 
            this.TextValorTotalVendaItem.DecimalPlaces = 2;
            this.TextValorTotalVendaItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextValorTotalVendaItem.Location = new System.Drawing.Point(341, 178);
            this.TextValorTotalVendaItem.Name = "TextValorTotalVendaItem";
            this.TextValorTotalVendaItem.Size = new System.Drawing.Size(92, 26);
            this.TextValorTotalVendaItem.TabIndex = 7;
            // 
            // LabelValorUnid
            // 
            this.LabelValorUnid.AutoSize = true;
            this.LabelValorUnid.BackColor = System.Drawing.Color.Transparent;
            this.LabelValorUnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelValorUnid.Location = new System.Drawing.Point(175, 158);
            this.LabelValorUnid.Name = "LabelValorUnid";
            this.LabelValorUnid.Size = new System.Drawing.Size(98, 17);
            this.LabelValorUnid.TabIndex = 57;
            this.LabelValorUnid.Text = "Valor Unidade";
            // 
            // LabelValorTotalItem
            // 
            this.LabelValorTotalItem.AutoSize = true;
            this.LabelValorTotalItem.BackColor = System.Drawing.Color.Transparent;
            this.LabelValorTotalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelValorTotalItem.Location = new System.Drawing.Point(335, 158);
            this.LabelValorTotalItem.Name = "LabelValorTotalItem";
            this.LabelValorTotalItem.Size = new System.Drawing.Size(77, 17);
            this.LabelValorTotalItem.TabIndex = 68;
            this.LabelValorTotalItem.Text = "Valor Total";
            // 
            // LabelNomeProduto
            // 
            this.LabelNomeProduto.AutoSize = true;
            this.LabelNomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.LabelNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelNomeProduto.Location = new System.Drawing.Point(343, 79);
            this.LabelNomeProduto.Name = "LabelNomeProduto";
            this.LabelNomeProduto.Size = new System.Drawing.Size(99, 17);
            this.LabelNomeProduto.TabIndex = 63;
            this.LabelNomeProduto.Text = "Nome Produto";
            // 
            // TextCodigoProd
            // 
            this.TextCodigoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextCodigoProd.Location = new System.Drawing.Point(191, 99);
            this.TextCodigoProd.Name = "TextCodigoProd";
            this.TextCodigoProd.Size = new System.Drawing.Size(82, 26);
            this.TextCodigoProd.TabIndex = 2;
            // 
            // ButtonPesqProd
            // 
            this.ButtonPesqProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPesqProd.BackgroundImage")));
            this.ButtonPesqProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonPesqProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonPesqProd.Location = new System.Drawing.Point(616, 92);
            this.ButtonPesqProd.Name = "ButtonPesqProd";
            this.ButtonPesqProd.Size = new System.Drawing.Size(160, 33);
            this.ButtonPesqProd.TabIndex = 4;
            this.ButtonPesqProd.Text = "Pesquisar Produto";
            this.ButtonPesqProd.UseVisualStyleBackColor = true;
            this.ButtonPesqProd.Click += new System.EventHandler(this.ButtonPesqProd_Click);
            // 
            // labelCodigoProd
            // 
            this.labelCodigoProd.AutoSize = true;
            this.labelCodigoProd.BackColor = System.Drawing.Color.Transparent;
            this.labelCodigoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelCodigoProd.Location = new System.Drawing.Point(188, 79);
            this.labelCodigoProd.Name = "labelCodigoProd";
            this.labelCodigoProd.Size = new System.Drawing.Size(106, 17);
            this.labelCodigoProd.TabIndex = 58;
            this.labelCodigoProd.Text = "Código Produto";
            // 
            // TextValorUnid
            // 
            this.TextValorUnid.DecimalPlaces = 2;
            this.TextValorUnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextValorUnid.Location = new System.Drawing.Point(178, 179);
            this.TextValorUnid.Name = "TextValorUnid";
            this.TextValorUnid.Size = new System.Drawing.Size(92, 26);
            this.TextValorUnid.TabIndex = 6;
            // 
            // TextNomeProduto
            // 
            this.TextNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextNomeProduto.Location = new System.Drawing.Point(346, 101);
            this.TextNomeProduto.Name = "TextNomeProduto";
            this.TextNomeProduto.Size = new System.Drawing.Size(255, 26);
            this.TextNomeProduto.TabIndex = 3;
            // 
            // TextQuantidade
            // 
            this.TextQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextQuantidade.Location = new System.Drawing.Point(23, 177);
            this.TextQuantidade.Name = "TextQuantidade";
            this.TextQuantidade.Size = new System.Drawing.Size(79, 26);
            this.TextQuantidade.TabIndex = 5;
            // 
            // LabelQuantidade
            // 
            this.LabelQuantidade.AutoSize = true;
            this.LabelQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.LabelQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelQuantidade.Location = new System.Drawing.Point(20, 157);
            this.LabelQuantidade.Name = "LabelQuantidade";
            this.LabelQuantidade.Size = new System.Drawing.Size(82, 17);
            this.LabelQuantidade.TabIndex = 72;
            this.LabelQuantidade.Text = "Quantidade";
            // 
            // LabelCodigoItemVenda
            // 
            this.LabelCodigoItemVenda.AutoSize = true;
            this.LabelCodigoItemVenda.BackColor = System.Drawing.Color.Transparent;
            this.LabelCodigoItemVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelCodigoItemVenda.Location = new System.Drawing.Point(26, 78);
            this.LabelCodigoItemVenda.Name = "LabelCodigoItemVenda";
            this.LabelCodigoItemVenda.Size = new System.Drawing.Size(127, 17);
            this.LabelCodigoItemVenda.TabIndex = 73;
            this.LabelCodigoItemVenda.Text = "Código Item Venda";
            // 
            // tabvendasitensBindingSource1
            // 
            this.tabvendasitensBindingSource1.DataMember = "tabvendas_itens";
            // 
            // tabvendasitensBindingSource
            // 
            this.tabvendasitensBindingSource.DataMember = "tabvendas_itens";
            // 
            // tabcadastroprodutoBindingSource
            // 
            this.tabcadastroprodutoBindingSource.DataMember = "tabcadastroproduto";
            // 
            // tabcadastroprodutoBindingSource1
            // 
            this.tabcadastroprodutoBindingSource1.DataMember = "tabcadastroproduto";
            // 
            // tabcadastroprodutoBindingSource2
            // 
            this.tabcadastroprodutoBindingSource2.DataMember = "tabcadastroproduto";
            // 
            // textCodigoItemVenda
            // 
            this.textCodigoItemVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textCodigoItemVenda.Location = new System.Drawing.Point(23, 101);
            this.textCodigoItemVenda.Name = "textCodigoItemVenda";
            this.textCodigoItemVenda.Size = new System.Drawing.Size(82, 26);
            this.textCodigoItemVenda.TabIndex = 1;
            // 
            // FormCadItemVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::win0.Properties.Resources._800xx600_gabe_flor_verde;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 301);
            this.Controls.Add(this.textCodigoItemVenda);
            this.Controls.Add(this.TextQuantidade);
            this.Controls.Add(this.LabelQuantidade);
            this.Controls.Add(this.LabelCodigoItemVenda);
            this.Controls.Add(this.ButtonSalvaVendaItem);
            this.Controls.Add(this.ButtonEditarVendaItem);
            this.Controls.Add(this.ButtonPesquisarVendaItem);
            this.Controls.Add(this.ButtonExcluirVendaItem);
            this.Controls.Add(this.TextValorTotalVendaItem);
            this.Controls.Add(this.LabelValorUnid);
            this.Controls.Add(this.LabelValorTotalItem);
            this.Controls.Add(this.LabelNomeProduto);
            this.Controls.Add(this.TextCodigoProd);
            this.Controls.Add(this.ButtonPesqProd);
            this.Controls.Add(this.labelCodigoProd);
            this.Controls.Add(this.TextValorUnid);
            this.Controls.Add(this.TextNomeProduto);
            this.DoubleBuffered = true;
            this.Name = "FormCadItemVenda";
            this.Text = "CadItemVenda";
            this.Load += new System.EventHandler(this.FormCadItemVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabvendasitensBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextValorTotalVendaItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextValorUnid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendasitensBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvendasitensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonSalvaVendaItem;
        private System.Windows.Forms.Button ButtonEditarVendaItem;
        private System.Windows.Forms.Button ButtonPesquisarVendaItem;
        private System.Windows.Forms.Button ButtonExcluirVendaItem;
        private System.Windows.Forms.NumericUpDown TextValorTotalVendaItem;
        private System.Windows.Forms.Label LabelValorUnid;
        private System.Windows.Forms.Label LabelValorTotalItem;
        private System.Windows.Forms.Label LabelNomeProduto;
        private System.Windows.Forms.TextBox TextCodigoProd;
        private System.Windows.Forms.Button ButtonPesqProd;
        private System.Windows.Forms.Label labelCodigoProd;
        private System.Windows.Forms.NumericUpDown TextValorUnid;
        private System.Windows.Forms.TextBox TextNomeProduto;
        private System.Windows.Forms.TextBox TextQuantidade;
        private System.Windows.Forms.Label LabelQuantidade;
        private System.Windows.Forms.Label LabelCodigoItemVenda;
//        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource tabvendasitensBindingSource;
//        private DataSet2TableAdapters.tabvendas_itensTableAdapter tabvendas_itensTableAdapter;
        private System.Windows.Forms.BindingSource tabcadastroprodutoBindingSource;
 //       private DataSet2TableAdapters.tabcadastroprodutoTableAdapter tabcadastroprodutoTableAdapter;
        private System.Windows.Forms.BindingSource tabcadastroprodutoBindingSource1;
        private System.Windows.Forms.BindingSource tabvendasitensBindingSource1;
        private System.Windows.Forms.BindingSource tabcadastroprodutoBindingSource2;
        private System.Windows.Forms.BindingSource tabvendasitensBindingSource2;
        private System.Windows.Forms.TextBox textCodigoItemVenda;
    }
}