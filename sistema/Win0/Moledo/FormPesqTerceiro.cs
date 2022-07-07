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
    public partial class FormPesqTerceiro : Form
    {
        public FormPesqTerceiro()
        {
            InitializeComponent();
        }

        private void FormPesqTerceiro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataaSet.tabcadastroterc'. Você pode movê-la ou removê-la conforme necessário.

        }

        private void ButtonAtualizarTerc_Click(object sender, EventArgs e)
        {
            this.tabcadastrotercTableAdapter.Fill(this.dataaSet.tabcadastroterc);

        }
        int codigo;
        string tipo_cadastro;
        string nome;
        string sexo;
        string cnpj_cpnj;
        string telefone;
        string email;
        DateTime data_atualizacao; 
        DateTime data_cadastro;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            tipo_cadastro=this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            nome = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            sexo = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cnpj_cpnj = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            telefone = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            email = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            data_atualizacao = DateTime.Parse(this.dataGridView1.CurrentRow.Cells[8].Value.ToString());
            data_cadastro = DateTime.Parse(this.dataGridView1.CurrentRow.Cells[7].Value.ToString());

            //entre " " coloco o nome da tela que preciso que os dados vaoo
            if (this.Owner.Name == "FormtesteTerceiro")
            {
                try
                {
                    //GetDataSet .. é uma função dentro da tela tela cadastro produto
                    ((FormtesteTerceiro)this.Owner).CarregarDados(codigo, tipo_cadastro, nome, sexo, cnpj_cpnj, telefone, email, data_atualizacao, data_cadastro);
                    Close(); //toda vez que clicar vai obriga fechar 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (this.Owner.Name == "FormRealizarVendas")
            {
                try
                {
                    //GetDataSet .. é uma função dentro da tela tela cadastro produto
                    ((FormRealizarVendas)this.Owner).CarregarDadosCliente2(codigo, nome);
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
