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
    public partial class FormtesteTerceiro : Form
    {
        public FormtesteTerceiro()
        {
            InitializeComponent();
        }

        private void buttonSalvarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                
                string sexo = "0";
                if (TextSexo.SelectedIndex == 0)
                {
                    sexo = "M";
                }
                else if (TextTipoContrato.SelectedIndex == 1)
                {
                    sexo = "F";
                }
                string tipoContrato = "0";
                if (TextTipoContrato.SelectedIndex == 0)
                {
                    tipoContrato = "F";
                }
                else if (TextTipoContrato.SelectedIndex == 1)
                {
                    tipoContrato = "J";
                }
                DataaSetTableAdapters.tabcadastrotercTableAdapter tabcadastrotercTableAdapter = new DataaSetTableAdapters.tabcadastrotercTableAdapter();
                tabcadastrotercTableAdapter.InsertQuery1(TextNomeTerc.Text, TextCnpj_cpf.Text, Textemail.Text, TextTelefone.Text, DateTime.Parse(TextDataCadastro.Text), DateTime.Parse(TextDataAtualizacao.Text), tipoContrato, sexo);
                MessageBox.Show("Cadastro criado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        int idAuxiliar;
        private void ButtonEscluirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DataaSetTableAdapters.tabcadastrotercTableAdapter delete = new DataaSetTableAdapters.tabcadastrotercTableAdapter();
                delete.Delete1(idAuxiliar);
                MessageBox.Show("Deletado. ");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        internal void CarregarDados(int codigo, string tipo_cadastro, string nome, string sexo, string cnpj_cpnj, string telefone, string email, DateTime data_atualizacao, DateTime data_cadastro)
        {
            try
            {
                //TextCodigoTerceiro.Text = codige.ToString();
                TextNomeTerc.Text = nome;
                TextTipoContrato.Text= tipo_cadastro;
                TextNomeTerc.Text = nome;
                TextSexo.Text = sexo;
                TextCnpj_cpf.Text = cnpj_cpnj;
                TextTelefone.Text = telefone;
                Textemail.Text = email;
                TextDataCadastro.Text = data_cadastro.ToString();
                TextDataAtualizacao.Text = data_atualizacao.ToString();
                idAuxiliar = codigo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonPesquisarCliente_Click(object sender, EventArgs e)
        {
            FormPesqTerceiro pesquisaTerceiroTeste = new FormPesqTerceiro();
            pesquisaTerceiroTeste.Owner = this;
            pesquisaTerceiroTeste.ShowDialog();

        }

        private void ButtonEditarCliente_Click(object sender, EventArgs e)
        {
            
        }
        
        public void CarregarDadosCliente2(int codigoCliente, string nomecliente)
        {

            try
            {
                //TextCodigoTerceiro.Text = codigoCliente.ToString();
                TextNomeTerc.Text = nomecliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormtesteTerceiro_Load(object sender, EventArgs e)
        {

        }
    }
}
