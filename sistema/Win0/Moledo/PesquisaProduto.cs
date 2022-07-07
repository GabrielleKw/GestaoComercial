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
    public partial class FormPesquisaProd : Form
    {
        public FormPesquisaProd()
        {
            InitializeComponent();
        }



        private void PesquisaProduto_Load(object sender, EventArgs e)
        {

        }

        public void PesquisaProduto_Clicl(object sender, EventArgs e)
        {
            this.tabcadastroprodutoTableAdapter.Fill(this.dataaSet.tabcadastroproduto);
        }

        //essas são as variáveis que irei utilizar abaixo. 
        int codigoProd;
        String nomeproduto;
        decimal preço;
        String unidade_venda;
        DateTime dataAtualizacaoProd; 
        private void ProdutodataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoProd = int.Parse(this.ProdutodataGridView.CurrentRow.Cells[0].Value.ToString());
            nomeproduto = this.ProdutodataGridView.CurrentRow.Cells[1].Value.ToString();
            preço = Convert.ToDecimal(this.ProdutodataGridView.CurrentRow.Cells[2].Value.ToString());
            unidade_venda = this.ProdutodataGridView.CurrentRow.Cells[5].Value.ToString();
            dataAtualizacaoProd = DateTime.Parse(this.ProdutodataGridView.CurrentRow.Cells[4].Value.ToString());

            //em "' é o nome da tela que preciso
            if (this.Owner.Name == "FormCadastroProd")
            {
                try
                {
                    //GetDataSet .. é uma função dentro da tela tela cadastro produto
                    ((FormCadastroProd)this.Owner).CarregarDadosProd(codigoProd, nomeproduto, preço, unidade_venda, dataAtualizacaoProd);
                    Close(); //toda vez que clicar vai obriga fechar 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (this.Owner.Name == "FormCadItemVenda")
            {
                try
                {
                    //GetDataSet .. é uma função dentro da tela tela cadastro produto
                    ((FormCadItemVenda)this.Owner).CarregaDadosProd3(codigoProd, nomeproduto);
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

        private void ProdutodataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProdutodataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
