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
    public partial class FormRealizarVendas : Form
    {
        public FormRealizarVendas()
        {
            InitializeComponent();
        }
       
        
        private void ButtonPesqProd_Click(object sender, EventArgs e)
        {
            FormPesquisaProd formPesquisaProd = new FormPesquisaProd();
            formPesquisaProd.Owner = this;
            formPesquisaProd.ShowDialog();
        }

        private void ButtonPesquisarVendaItem_Click(object sender, EventArgs e)
        {
            FormPesquisaVendaItens formPesquisaVendaItens = new FormPesquisaVendaItens
            {
                Owner = this
            };
            formPesquisaVendaItens.ShowDialog();
        }

        private void buttonSalvarVenda_Click(object sender, EventArgs e)
        {
            try
            {

                FormCadItemVenda formCadItemVenda = new FormCadItemVenda(int.Parse(TextCodigoVenda.Text));
                formCadItemVenda.ShowDialog();
            }
            catch (Exception ex)
            {
                //caso der errado mensagem que irá ser exibida
                MessageBox.Show(ex.Message);
            }
        }
        public void CarregarPreVenda(int codigoPreVenda, string numero_nf, DateTime data_pedido, DateTime data_emissao, DateTime data_entrega, int id_terceirocliente, string nome)
        {
            try
            {
                TextCodigoVenda.Text = codigoPreVenda.ToString();
                TextNumeroNF.Text = numero_nf;
                TextDataPedido.Text = data_pedido.ToString();
                TextDataEmissao.Text = data_emissao.ToString();
                TextDataEntrega.Text = data_entrega.ToString();
                TextCodigoCliente.Text = id_terceirocliente.ToString();
                TextNomeCliente.Text = nome.ToString();
                idAuxiliar = codigoPreVenda;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        internal void CarregaDadosProd2(int codigoProd, string nomeproduto)
        {
            throw new NotImplementedException();
        }

        internal void CarregarDadosVendasItens(int codigoVendaItem, string quandidade, decimal valor_unid, decimal valor_total, int id_venda, int id_produto)
        {
            throw new NotImplementedException();
        }

        private void buttonPesqCliente_Click(object sender, EventArgs e)
        {
            FormPesqTerceiro pesqTerceiro = new FormPesqTerceiro();
            pesqTerceiro.Owner = this;
            pesqTerceiro.ShowDialog();
        }

        private void buttonPesquisaVenda_Click(object sender, EventArgs e)
        {
            FormPesquisaVendaRealizada formPesquisaVendaRealizada = new FormPesquisaVendaRealizada();
            formPesquisaVendaRealizada.Owner = this;
            formPesquisaVendaRealizada.ShowDialog();
        }

        public void CarregarDadosCliente2(int codigoCliente, string nomecliente)
        {
            try
            {
                TextCodigoCliente.Text = codigoCliente.ToString();
                TextNomeCliente.Text = nomecliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //botão excluir
        int idAuxiliar;
        private void buttonExcluirVenda_Click(object sender, EventArgs e)
        {
            try
            {
                //DataaSetTableAdapters.tabvendaTableAdapter excluir = new DataaSetTableAdapters.tabvendaTableAdapter();
                //excluir.DeleteQuery(idAuxiliar);

                MessageBox.Show(" Deletado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //Estou salvando os dados na tabela 
                
                DataaSetTableAdapters.tabvendaTableAdapter tabvendaAdc = new DataaSetTableAdapters.tabvendaTableAdapter();
                tabvendaAdc.InsertVenda(int.Parse(TextCodigoVenda.Text), TextNumeroNF.Text, DateTime.Parse(TextDataPedido.Text), DateTime.Parse(TextDataEmissao.Text), DateTime.Parse(TextDataEntrega.Text), decimal.Parse(textValorTotal.Text), int.Parse(TextCodigoCliente.Text));
                //caso der certo mensagem a exibir para  cliente 
                MessageBox.Show("Cadastrado com Sucesso! ");

                FormCadItemVenda formCadItemVenda = new FormCadItemVenda(int.Parse(TextCodigoVenda.Text));
                formCadItemVenda.ShowDialog();

            }
            catch (Exception ex)
            {
                //caso der errado mensagem que irá ser exibida
                MessageBox.Show(ex.Message);
            }
        }

        private void TextCodigoVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRealizarVendas_Load(object sender, EventArgs e)
        {

        }
    }
}
