using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win0.Moledo
{
    public partial class FormLogin : Form
    {
        public bool Logado { get; set; }
        public string Usuario { get; set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void ButtonEntra_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //Nesta parte recupere os valores do seu banco de dados
            string usuarioBanco = "gabi";
            string senhaBanco = "123";
            string usuarioDigitado = TextUsuario.Text;
            string senhaDigitada = textSenha.Text;

            if ((usuarioDigitado == usuarioBanco) && (senhaDigitada == senhaBanco))
            {
                Logado = true;
                Usuario = TextUsuario.Text;

                //Salvar o nome de usuário nas configurações do aplicativo
                Properties.Settings.Default.Usuario = TextUsuario.Text;
                Properties.Settings.Default.Save();

                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.ShowDialog();
                this.Close();


            }
            else
            {
                Logado = false; ;
                LabelDadosInvalidos.Visible = true;
            }
            this.Cursor = Cursors.Default;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
