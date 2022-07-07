namespace win0.Moledo
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.TextUsuario = new System.Windows.Forms.TextBox();
            this.labellogin = new System.Windows.Forms.Label();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.ButtonEntra = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.LabelDadosInvalidos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextUsuario
            // 
            this.TextUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextUsuario.Location = new System.Drawing.Point(260, 118);
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(151, 26);
            this.TextUsuario.TabIndex = 59;
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.BackColor = System.Drawing.Color.Transparent;
            this.labellogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labellogin.Location = new System.Drawing.Point(191, 118);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(57, 17);
            this.labellogin.TabIndex = 60;
            this.labellogin.Text = "Usuário";
            // 
            // textSenha
            // 
            this.textSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textSenha.Location = new System.Drawing.Point(260, 172);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(151, 26);
            this.textSenha.TabIndex = 61;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.BackColor = System.Drawing.Color.Transparent;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelSenha.Location = new System.Drawing.Point(191, 172);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(49, 17);
            this.labelSenha.TabIndex = 62;
            this.labelSenha.Text = "Senha";
            // 
            // ButtonEntra
            // 
            this.ButtonEntra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEntra.BackgroundImage")));
            this.ButtonEntra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEntra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonEntra.Location = new System.Drawing.Point(317, 260);
            this.ButtonEntra.Name = "ButtonEntra";
            this.ButtonEntra.Size = new System.Drawing.Size(94, 34);
            this.ButtonEntra.TabIndex = 64;
            this.ButtonEntra.Text = "Login";
            this.ButtonEntra.UseVisualStyleBackColor = true;
            this.ButtonEntra.Click += new System.EventHandler(this.ButtonEntra_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSair.BackgroundImage")));
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonSair.Location = new System.Drawing.Point(216, 260);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(94, 34);
            this.buttonSair.TabIndex = 65;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // LabelDadosInvalidos
            // 
            this.LabelDadosInvalidos.AutoSize = true;
            this.LabelDadosInvalidos.BackColor = System.Drawing.Color.Transparent;
            this.LabelDadosInvalidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelDadosInvalidos.ForeColor = System.Drawing.Color.Red;
            this.LabelDadosInvalidos.Location = new System.Drawing.Point(213, 220);
            this.LabelDadosInvalidos.Name = "LabelDadosInvalidos";
            this.LabelDadosInvalidos.Size = new System.Drawing.Size(179, 17);
            this.LabelDadosInvalidos.TabIndex = 66;
            this.LabelDadosInvalidos.Text = "Usuário ou senha inválidos";
            this.LabelDadosInvalidos.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::win0.Properties.Resources.privacy;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(62, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 71);
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelDadosInvalidos);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.ButtonEntra);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.TextUsuario);
            this.Controls.Add(this.labellogin);
            this.DoubleBuffered = true;
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextUsuario;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Button ButtonEntra;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label LabelDadosInvalidos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}