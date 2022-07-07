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
    public partial class FormPesquisaFuncionario : Form
    {
        public FormPesquisaFuncionario()
        {
            InitializeComponent();
        }

        private void FormPesquisaFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataaSet.tablecadastrofunc'. Você pode movê-la ou removê-la conforme necessário.

        }

        private void buttonPesquisaProduto_Click(object sender, EventArgs e)
        {
            this.tablecadastrofuncTableAdapter.Fill(this.dataaSet.tablecadastrofunc);

        }
        int codigof;
        string nomef;
        string cpf;
        string sexo;
        string tipo_cadastro;
        DateTime dataatualizacao;
        private void ProdutodataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //odigoProd = int.Parse(this.ProdutodataGridView.CurrentRow.Cells[0].Value.ToString());
            codigof = int.Parse(this.ProdutodataGridView.CurrentRow.Cells[0].Value.ToString());
            nomef = this.ProdutodataGridView.CurrentRow.Cells[0].Value.ToString();
            cpf=this.ProdutodataGridView.CurrentRow.Cells[0].Value.ToString();
            sexo = this.ProdutodataGridView.CurrentRow.Cells[0].Value.ToString();
            tipo_cadastro = this.ProdutodataGridView.CurrentRow.Cells[0].Value.ToString();
     //     datacadastro = DateTime.Parse(this.ProdutodataGridView.CurrentRow.Cells[0].Value.ToString());
            //em "' é o nome da tela que preciso
            if (this.Owner.Name == "FormCadastroFuncionario")
            {
                try
                {
                    //GetDataSet .. é uma função dentro da tela tela cadastro produto
                    ((FormCadastroFuncionario)this.Owner).CarregarDadosFunc(codigof, nomef, cpf, sexo, tipo_cadastro,  dataatualizacao);
                    Close(); //toda vez que clicar vai obriga fechar 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
            
        }
    }
}
