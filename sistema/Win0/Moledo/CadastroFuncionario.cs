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
    public partial class FormCadastroFuncionario : Form
    {
        public FormCadastroFuncionario()
        {
            InitializeComponent();
           
            
        }

        private void buttonSalvarFuncionario_Click(object sender, EventArgs e)
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
                    tipoContrato = "CLT";
                }
                else if (TextTipoContrato.SelectedIndex == 1)
                {
                    tipoContrato = "PJ";
                }


                DataaSetTableAdapters.tablecadastrofuncTableAdapter AdcFuncionario = new DataaSetTableAdapters.tablecadastrofuncTableAdapter();
                AdcFuncionario.InsertF( TextNomeFunc.Text, TextCpf.Text, sexo, tipoContrato, DateTime.Parse(TextDataCadastroFun.Text), DateTime.Parse(TextDataAtualizacaoFun.Text));


                MessageBox.Show("Cadastro criado com sucesso!");
                Application.Exit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonPesquisarCliente_Click(object sender, EventArgs e)
        {
            FormPesquisaFuncionario formPesquisaFuncionario = new FormPesquisaFuncionario();
            formPesquisaFuncionario.ShowDialog();
        }

        private void FormCadastroFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataaSet.tabcadastroproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tabcadastroprodutoTableAdapter.Fill(this.dataaSet.tabcadastroproduto);

        }

        internal void CarregarDadosFunc(int codigof, string nomef, string cpf, string sexo, string tipo_cadastro, DateTime dataatualizacao)
        {
            try
            {
                TextCodigoFunc.Text= codigof.ToString();
                TextNomeFunc.Text = nomef;
                TextCpf.Text= cpf;
                TextSexo.Text= sexo;
                TextTipoContrato.Text= tipo_cadastro;
            //  TextDataCadastroFun.Text= datacadastro.ToString();
                TextDataAtualizacaoFun.Text= dataAtualização.ToString();

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
                DataaSetTableAdapters.tablecadastrofuncTableAdapter excluirFun = new DataaSetTableAdapters.tablecadastrofuncTableAdapter();
                excluirFun.DeleteQuery(idAuxiliar);

                MessageBox.Show("Deletado. ");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void ButtonEditarCliente_Click(object sender, EventArgs e)
        {
            // PEGANDO AS INFORMAÇÕES DO DATAGRIDVIEW E ARMAZENANDO EM VARIÁVEIS PARA ATUALIZAR CADASTRO
            int id = int.Parse(ProdutodataGridView.SelectedRows[0].Cells[0].Value.ToString());
            string nome = ProdutodataGridView.SelectedRows[0].Cells[1].Value.ToString();
            string cpf = ProdutodataGridView.SelectedRows[0].Cells[2].Value.ToString();
            decimal salario = decimal.Parse(ProdutodataGridView.SelectedRows[0].Cells[3].Value.ToString());
            string sexo = ProdutodataGridView.SelectedRows[0].Cells[4].Value.ToString();
            string tipo_contrato = ProdutodataGridView.SelectedRows[0].Cells[5].Value.ToString();
            DateTime dataatulizacao = DateTime.Parse(ProdutodataGridView.SelectedRows[0].Cells[6].Value.ToString());

            DateTime dataAtualizacao = DateTime.Now;

            try
            {
                string sexoAlteracao = "0";
                if (TextSexo.SelectedIndex == 0)
                {
                    sexoAlteracao = "M";
                }
                else if (TextSexo.SelectedIndex == 1)
                {
                    sexoAlteracao = "F";
                }
                string tipoContratoAlteracao = "0";
                if (TextTipoContrato.SelectedIndex == 0)
                {
                    tipoContratoAlteracao = "CLT";
                }
                else if (TextTipoContrato.SelectedIndex == 1)
                {
                    tipoContratoAlteracao = "PJ";
                }

                // Preenchendo o DataSet para atualizar os cadastros, os parametros que estão um AO LADO DO OUTRO são os novos a serem inseridos
                // Os que estão um acima do outro, sao os antigos que foram selecionados do DataGridView
                DataaSetTableAdapters.tablecadastrofuncTableAdapter funcionarioTableAdapter = new DataaSetTableAdapters.tablecadastrofuncTableAdapter();
               /* funcionarioTableAdapter.UpdateTerc(TextNomeFunc.Text, TextCpf.Text, TextSexo.Text, TextTipoContrato.Text,DateTime.Parse(TextDataAtualizacaoFun.Text),                
                       nome,
                       cpf,
                       sexo, 
                       tipo_contrato,
                       dataatulizacao
                       );
               */
                MessageBox.Show("Cadastro atualizado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
