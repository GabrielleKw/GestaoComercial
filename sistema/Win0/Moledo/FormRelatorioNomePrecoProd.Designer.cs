namespace win0.Moledo
{
    partial class FormRelatorioNomePrecoProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioNomePrecoProd));
            this.tabcadastroprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataaSet = new win0.DataaSet();
            this.tabcadastroprodutoTableAdapter = new win0.DataaSetTableAdapters.tabcadastroprodutoTableAdapter();
            this.tabcadastroprodutoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabcadastroprodutoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ProdutodataGridView = new System.Windows.Forms.DataGridView();
            this.buttonPesquisaProduto = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcadastroprodutoBindingSource
            // 
            this.tabcadastroprodutoBindingSource.DataMember = "tabcadastroproduto";
            this.tabcadastroprodutoBindingSource.DataSource = this.dataaSet;
            // 
            // dataaSet
            // 
            this.dataaSet.DataSetName = "DataaSet";
            this.dataaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tabcadastroprodutoBindingSource2
            // 
            this.tabcadastroprodutoBindingSource2.DataMember = "tabcadastroproduto";
            this.tabcadastroprodutoBindingSource2.DataSource = this.dataaSet;
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
            this.dataGridViewTextBoxColumn5});
            this.ProdutodataGridView.DataSource = this.tabcadastroprodutoBindingSource2;
            this.ProdutodataGridView.GridColor = System.Drawing.Color.Magenta;
            this.ProdutodataGridView.Location = new System.Drawing.Point(12, 72);
            this.ProdutodataGridView.Name = "ProdutodataGridView";
            this.ProdutodataGridView.ReadOnly = true;
            this.ProdutodataGridView.RowHeadersWidth = 51;
            this.ProdutodataGridView.RowTemplate.Height = 24;
            this.ProdutodataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdutodataGridView.Size = new System.Drawing.Size(753, 255);
            this.ProdutodataGridView.TabIndex = 1;
            // 
            // buttonPesquisaProduto
            // 
            this.buttonPesquisaProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPesquisaProduto.BackgroundImage")));
            this.buttonPesquisaProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPesquisaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonPesquisaProduto.Location = new System.Drawing.Point(634, 12);
            this.buttonPesquisaProduto.Name = "buttonPesquisaProduto";
            this.buttonPesquisaProduto.Size = new System.Drawing.Size(131, 39);
            this.buttonPesquisaProduto.TabIndex = 2;
            this.buttonPesquisaProduto.Text = "Atualizar";
            this.buttonPesquisaProduto.UseVisualStyleBackColor = true;
            this.buttonPesquisaProduto.Click += new System.EventHandler(this.buttonPesquisaProduto_Click);
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
            // FormRelatorioNomePrecoProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.buttonPesquisaProduto);
            this.Controls.Add(this.ProdutodataGridView);
            this.Name = "FormRelatorioNomePrecoProd";
            this.Text = "FormRelatorioNomePrecoProd";
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataaSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcadastroprodutoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutodataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataaSet dataaSet;
        private System.Windows.Forms.BindingSource tabcadastroprodutoBindingSource;
        private DataaSetTableAdapters.tabcadastroprodutoTableAdapter tabcadastroprodutoTableAdapter;
        private System.Windows.Forms.BindingSource tabcadastroprodutoBindingSource1;
        private System.Windows.Forms.BindingSource tabcadastroprodutoBindingSource2;
        public System.Windows.Forms.DataGridView ProdutodataGridView;
        private System.Windows.Forms.Button buttonPesquisaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}