namespace win0.Moledo
{
    partial class FormtesteTerceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormtesteTerceiro));
            this.label1 = new System.Windows.Forms.Label();
            this.TextTipoContrato = new System.Windows.Forms.ComboBox();
            this.labelsexo = new System.Windows.Forms.Label();
            this.TextSexo = new System.Windows.Forms.ComboBox();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label_cnpj = new System.Windows.Forms.Label();
            this.TextDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.ButtonEscluirCliente = new System.Windows.Forms.Button();
            this.ButtonEditarCliente = new System.Windows.Forms.Button();
            this.ButtonPesquisarCliente = new System.Windows.Forms.Button();
            this.Textemail = new System.Windows.Forms.TextBox();
            this.TextNomeTerc = new System.Windows.Forms.TextBox();
            this.buttonSalvarCliente = new System.Windows.Forms.Button();
            this.dataCadastro = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.TextDataAtualizacao = new System.Windows.Forms.DateTimePicker();
            this.TextTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dataAtualização = new System.Windows.Forms.Label();
            this.TextCnpj_cpf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "Tipo de Pessoa";
            // 
            // TextTipoContrato
            // 
            this.TextTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextTipoContrato.FormattingEnabled = true;
            this.TextTipoContrato.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.TextTipoContrato.Location = new System.Drawing.Point(16, 108);
            this.TextTipoContrato.Name = "TextTipoContrato";
            this.TextTipoContrato.Size = new System.Drawing.Size(139, 24);
            this.TextTipoContrato.TabIndex = 1;
            // 
            // labelsexo
            // 
            this.labelsexo.AutoSize = true;
            this.labelsexo.BackColor = System.Drawing.Color.Transparent;
            this.labelsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelsexo.Location = new System.Drawing.Point(16, 153);
            this.labelsexo.Name = "labelsexo";
            this.labelsexo.Size = new System.Drawing.Size(39, 17);
            this.labelsexo.TabIndex = 61;
            this.labelsexo.Text = "Sexo";
            // 
            // TextSexo
            // 
            this.TextSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextSexo.FormattingEnabled = true;
            this.TextSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.TextSexo.Location = new System.Drawing.Point(15, 176);
            this.TextSexo.Name = "TextSexo";
            this.TextSexo.Size = new System.Drawing.Size(139, 24);
            this.TextSexo.TabIndex = 3;
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelNomeCliente.Location = new System.Drawing.Point(256, 79);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(45, 17);
            this.labelNomeCliente.TabIndex = 58;
            this.labelNomeCliente.Text = "Nome";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelEmail.Location = new System.Drawing.Point(256, 153);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 57;
            this.labelEmail.Text = "Email";
            // 
            // label_cnpj
            // 
            this.label_cnpj.AutoSize = true;
            this.label_cnpj.BackColor = System.Drawing.Color.Transparent;
            this.label_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label_cnpj.Location = new System.Drawing.Point(259, 214);
            this.label_cnpj.Name = "label_cnpj";
            this.label_cnpj.Size = new System.Drawing.Size(71, 21);
            this.label_cnpj.TabIndex = 56;
            this.label_cnpj.Text = "cnpj/cpf";
            // 
            // TextDataCadastro
            // 
            this.TextDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextDataCadastro.Location = new System.Drawing.Point(17, 235);
            this.TextDataCadastro.Name = "TextDataCadastro";
            this.TextDataCadastro.Size = new System.Drawing.Size(125, 26);
            this.TextDataCadastro.TabIndex = 5;
            // 
            // ButtonEscluirCliente
            // 
            this.ButtonEscluirCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEscluirCliente.BackgroundImage")));
            this.ButtonEscluirCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEscluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonEscluirCliente.Location = new System.Drawing.Point(504, 16);
            this.ButtonEscluirCliente.Name = "ButtonEscluirCliente";
            this.ButtonEscluirCliente.Size = new System.Drawing.Size(103, 34);
            this.ButtonEscluirCliente.TabIndex = 10;
            this.ButtonEscluirCliente.Text = "Excluir";
            this.ButtonEscluirCliente.UseVisualStyleBackColor = true;
            this.ButtonEscluirCliente.Click += new System.EventHandler(this.ButtonEscluirCliente_Click);
            // 
            // ButtonEditarCliente
            // 
            this.ButtonEditarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEditarCliente.BackgroundImage")));
            this.ButtonEditarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonEditarCliente.Location = new System.Drawing.Point(622, 16);
            this.ButtonEditarCliente.Name = "ButtonEditarCliente";
            this.ButtonEditarCliente.Size = new System.Drawing.Size(91, 34);
            this.ButtonEditarCliente.TabIndex = 11;
            this.ButtonEditarCliente.Text = "Editar";
            this.ButtonEditarCliente.UseVisualStyleBackColor = true;
            this.ButtonEditarCliente.Click += new System.EventHandler(this.ButtonEditarCliente_Click);
            // 
            // ButtonPesquisarCliente
            // 
            this.ButtonPesquisarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPesquisarCliente.BackgroundImage")));
            this.ButtonPesquisarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonPesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonPesquisarCliente.Location = new System.Drawing.Point(719, 16);
            this.ButtonPesquisarCliente.Name = "ButtonPesquisarCliente";
            this.ButtonPesquisarCliente.Size = new System.Drawing.Size(94, 34);
            this.ButtonPesquisarCliente.TabIndex = 12;
            this.ButtonPesquisarCliente.Text = "Pesquisa";
            this.ButtonPesquisarCliente.UseVisualStyleBackColor = true;
            this.ButtonPesquisarCliente.Click += new System.EventHandler(this.ButtonPesquisarCliente_Click);
            // 
            // Textemail
            // 
            this.Textemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Textemail.Location = new System.Drawing.Point(259, 173);
            this.Textemail.Name = "Textemail";
            this.Textemail.Size = new System.Drawing.Size(478, 26);
            this.Textemail.TabIndex = 4;
            // 
            // TextNomeTerc
            // 
            this.TextNomeTerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextNomeTerc.Location = new System.Drawing.Point(259, 108);
            this.TextNomeTerc.Name = "TextNomeTerc";
            this.TextNomeTerc.Size = new System.Drawing.Size(478, 26);
            this.TextNomeTerc.TabIndex = 2;
            // 
            // buttonSalvarCliente
            // 
            this.buttonSalvarCliente.BackColor = System.Drawing.Color.White;
            this.buttonSalvarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSalvarCliente.BackgroundImage")));
            this.buttonSalvarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSalvarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonSalvarCliente.Location = new System.Drawing.Point(640, 364);
            this.buttonSalvarCliente.Name = "buttonSalvarCliente";
            this.buttonSalvarCliente.Size = new System.Drawing.Size(164, 49);
            this.buttonSalvarCliente.TabIndex = 9;
            this.buttonSalvarCliente.Text = "Salvar";
            this.buttonSalvarCliente.UseVisualStyleBackColor = false;
            this.buttonSalvarCliente.Click += new System.EventHandler(this.buttonSalvarCliente_Click);
            // 
            // dataCadastro
            // 
            this.dataCadastro.AutoSize = true;
            this.dataCadastro.BackColor = System.Drawing.Color.Transparent;
            this.dataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dataCadastro.Location = new System.Drawing.Point(16, 214);
            this.dataCadastro.Name = "dataCadastro";
            this.dataCadastro.Size = new System.Drawing.Size(99, 17);
            this.dataCadastro.TabIndex = 46;
            this.dataCadastro.Text = "Data Cadastro";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.BackColor = System.Drawing.Color.Transparent;
            this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelTelefone.Location = new System.Drawing.Point(579, 207);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(64, 17);
            this.labelTelefone.TabIndex = 67;
            this.labelTelefone.Text = "Telefone";
            // 
            // TextDataAtualizacao
            // 
            this.TextDataAtualizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextDataAtualizacao.Location = new System.Drawing.Point(17, 315);
            this.TextDataAtualizacao.Name = "TextDataAtualizacao";
            this.TextDataAtualizacao.Size = new System.Drawing.Size(123, 26);
            this.TextDataAtualizacao.TabIndex = 8;
            // 
            // TextTelefone
            // 
            this.TextTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextTelefone.Location = new System.Drawing.Point(582, 237);
            this.TextTelefone.Mask = "(00) 00000 - 0000";
            this.TextTelefone.Name = "TextTelefone";
            this.TextTelefone.Size = new System.Drawing.Size(155, 26);
            this.TextTelefone.TabIndex = 7;
            // 
            // dataAtualização
            // 
            this.dataAtualização.AutoSize = true;
            this.dataAtualização.BackColor = System.Drawing.Color.Transparent;
            this.dataAtualização.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dataAtualização.Location = new System.Drawing.Point(16, 295);
            this.dataAtualização.Name = "dataAtualização";
            this.dataAtualização.Size = new System.Drawing.Size(115, 17);
            this.dataAtualização.TabIndex = 65;
            this.dataAtualização.Text = "Data Atualização";
            // 
            // TextCnpj_cpf
            // 
            this.TextCnpj_cpf.Location = new System.Drawing.Point(262, 239);
            this.TextCnpj_cpf.Name = "TextCnpj_cpf";
            this.TextCnpj_cpf.Size = new System.Drawing.Size(155, 22);
            this.TextCnpj_cpf.TabIndex = 6;
            // 
            // FormtesteTerceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::win0.Properties.Resources._800xx600_gabe_flor_verde;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 442);
            this.Controls.Add(this.TextCnpj_cpf);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.TextDataAtualizacao);
            this.Controls.Add(this.TextTelefone);
            this.Controls.Add(this.dataAtualização);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextTipoContrato);
            this.Controls.Add(this.labelsexo);
            this.Controls.Add(this.TextSexo);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.label_cnpj);
            this.Controls.Add(this.TextDataCadastro);
            this.Controls.Add(this.ButtonEscluirCliente);
            this.Controls.Add(this.ButtonEditarCliente);
            this.Controls.Add(this.ButtonPesquisarCliente);
            this.Controls.Add(this.Textemail);
            this.Controls.Add(this.TextNomeTerc);
            this.Controls.Add(this.buttonSalvarCliente);
            this.Controls.Add(this.dataCadastro);
            this.DoubleBuffered = true;
            this.Name = "FormtesteTerceiro";
            this.Text = "Cadastro Terceiro";
            this.Load += new System.EventHandler(this.FormtesteTerceiro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TextTipoContrato;
        private System.Windows.Forms.Label labelsexo;
        private System.Windows.Forms.ComboBox TextSexo;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label_cnpj;
        public System.Windows.Forms.DateTimePicker TextDataCadastro;
        private System.Windows.Forms.Button ButtonEscluirCliente;
        private System.Windows.Forms.Button ButtonEditarCliente;
        private System.Windows.Forms.Button ButtonPesquisarCliente;
        public System.Windows.Forms.TextBox Textemail;
        public System.Windows.Forms.TextBox TextNomeTerc;
        private System.Windows.Forms.Button buttonSalvarCliente;
        private System.Windows.Forms.Label dataCadastro;
        private System.Windows.Forms.Label labelTelefone;
        public System.Windows.Forms.DateTimePicker TextDataAtualizacao;
        public System.Windows.Forms.MaskedTextBox TextTelefone;
        private System.Windows.Forms.Label dataAtualização;
        private System.Windows.Forms.TextBox TextCnpj_cpf;
    }
}