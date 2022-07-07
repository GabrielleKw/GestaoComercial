using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using win0.Moledo;
using System.ComponentModel.DataAnnotations;


namespace win0
{
    public partial class FormCadastroProd : Form
    {
        public object ProdutodataGridView { get; private set; }

        public FormCadastroProd()
        {
            InitializeComponent();
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            try 
            {
                string unidadeVenda = "0";
                if (textunidade_venda.SelectedIndex == 0)
                {
                    unidadeVenda = "Litro";
                }
                else if (textunidade_venda.SelectedIndex == 1)
                {
                    unidadeVenda = "Grama";
                }
                //Estou salvando os dados na tabela 
                DataaSetTableAdapters.tabcadastroprodutoTableAdapter tabcadastroprodutoTableAdapter = new DataaSetTableAdapters.tabcadastroprodutoTableAdapter();
                tabcadastroprodutoTableAdapter.InsertProd(textNomeProduto.Text, decimal.Parse(TextPrecoProduto.Text), DateTime.Parse(textDataCadProduto.Text), DateTime.Parse(textDataAtualicaoProd.Text), unidadeVenda);
                
                
                //caso der certo mensagem a exibir para  cliente 
                MessageBox.Show("Cadastrado com Sucesso! ");
            }
            catch (Exception ex) 
            {
                 //caso der errado mensagem que irá ser exibida
                MessageBox.Show(ex.Message);
              
            }

        }

        private void FormCadastroProduto(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
             

        int idAuxiliar;
        public void CarregarDadosProd(int codigoProd, String nomeproduto, decimal preço, String unidade_Venda, DateTime dataAtualizacaoProd )
        {

            try
            {
                textCodigo.Text = codigoProd.ToString();
                textNomeProduto.Text = nomeproduto;
                TextPrecoProduto.Text = preço.ToString();
                textunidade_venda.Text = unidade_Venda;
                textDataAtualicaoProd.Text = dataAtualizacaoProd.ToString();
                idAuxiliar = codigoProd;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonPesquisaProd_Click(object sender, EventArgs e)
        {
            //Estou chamando a tela pesquisar Produto
            FormPesquisaProd FormPesquisaProd = new FormPesquisaProd();
            FormPesquisaProd.Owner=this; //estamos falando que o proprietario é cadastro prod
            FormPesquisaProd.ShowDialog();

        }

        private void ButtonExcluir_Click(object sender, EventArgs e)
        {
            
            try
            {
                //DataaSetTableAdapters.tabcadastroprodutoTableAdapter dropEmployee = new DataaSetTableAdapters.tabcadastroprodutoTableAdapter();
               // dropEmployee.DeleteProd(idAuxiliar);

                MessageBox.Show("Deletado. ");
            }
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            } 
        
        }

        private void TextCodigo_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            // Permite digitar apenas numeros, não lê outros valores 
            KeyPressEvent.Handled = !char.IsDigit(KeyPressEvent.KeyChar);
        }

        private DateTimePicker GetTextDataAtualicaoProd()
        {
            return textDataAtualicaoProd;
        }

        private void ButtonEditarProd_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoProd = int.Parse(this.ProdutodataGridView1.CurrentRow.Cells[0].Value.ToString());
                string nomeproduto = this.ProdutodataGridView1.CurrentRow.Cells[1].Value.ToString();
                decimal preço = Convert.ToDecimal(this.ProdutodataGridView1.CurrentRow.Cells[2].Value.ToString());
                string unidade_venda = this.ProdutodataGridView1.CurrentRow.Cells[5].Value.ToString();
                DateTime dataAtualizacaoProd = DateTime.Parse(this.ProdutodataGridView1.CurrentRow.Cells[4].Value.ToString());
                
                DataaSetTableAdapters.tabcadastroprodutoTableAdapter tabcadastroprodutoTableAdapter = new DataaSetTableAdapters.tabcadastroprodutoTableAdapter();
                tabcadastroprodutoTableAdapter.UpdateProd(textNomeProduto.Text, decimal.Parse(TextPrecoProduto.Text), DateTime.Parse(textDataAtualicaoProd.Text), textunidade_venda.Text, codigoProd);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            
        }

        private void FormCadastroProd_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataaSet.tabcadastroproduto'. Você pode movê-la ou removê-la conforme necessário.
            //this.tabcadastroprodutoTableAdapter.Fill(this.dataaSet.tabcadastroproduto);

        }

        private void ProdutodataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
