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
    public partial class FormPesquisaVendaItens : Form
    {
        public FormPesquisaVendaItens()
        {
            InitializeComponent();
        }

        private void PesquisaVendaItens_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataaSet.tabcadastroproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tabcadastroprodutoTableAdapter.Fill(this.dataaSet.tabcadastroproduto);
        }

        private void buttonPesquisaVendasItens_Click(object sender, EventArgs e)
        {
           this.tabvendas_itensTableAdapter.Fill(this.dataaSet.tabvendas_itens);

        }


        int codigoVendaItem;
        string quandidade;
        decimal valor_unid;
        decimal valor_total;
        int id_venda;
        int id_produto;

        private void DataGridViewPesqVendaItens_DoubleClick(object sender, EventArgs e)
        {
            codigoVendaItem = int.Parse(this.DataGridViewPesqVendaItens.CurrentRow.Cells[0].Value.ToString());
            quandidade = this.DataGridViewPesqVendaItens.CurrentRow.Cells[0].Value.ToString();
            valor_unid = decimal.Parse(this.DataGridViewPesqVendaItens.CurrentRow.Cells[0].Value.ToString());
            valor_total = decimal.Parse(this.DataGridViewPesqVendaItens.CurrentRow.Cells[0].Value.ToString());
            id_venda = int.Parse(this.DataGridViewPesqVendaItens.CurrentRow.Cells[0].Value.ToString());
            id_produto = int.Parse(this.DataGridViewPesqVendaItens.CurrentRow.Cells[0].Value.ToString());


            //em "' é o nome da tela que preciso
            if (this.Owner.Name == "FormCadItemVenda")
            {
                try
                {
                    //GetDataSet .. é uma função dentro da tela tela cadastro produto
                    ((FormCadItemVenda)this.Owner).CarregarDadosVendasItens(codigoVendaItem, quandidade, valor_unid, valor_total, id_venda, id_produto);
                    
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

        private void DataGridViewPesqVendaItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
