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
    public partial class FormCadItemVenda : Form
    {
        int _idVenda = 0;
        public FormCadItemVenda(int idvenda)
        {
            InitializeComponent();
            _idVenda = idvenda;
            //dataGridView1.Refresh();
        }
        /*
        public FormCadItemVenda(string valor)
        {
            InitializeComponent();
           // Text .Text = valor.ToString();
        } */
        private void ButtonSalvaVendaItem_Click(object sender, EventArgs e)
        {
            try
            {
                int CodigoVenda = _idVenda;
                
                DataaSetTableAdapters.tabvendas_itensTableAdapter salvaitens = new DataaSetTableAdapters.tabvendas_itensTableAdapter();
                salvaitens.InsertVendaItem(int.Parse(textCodigoItemVenda.Text), TextQuantidade.Text, decimal.Parse(TextValorUnid.Text), decimal.Parse(TextValorTotalVendaItem.Text), CodigoVenda, int.Parse(TextCodigoProd.Text));

                MessageBox.Show("Cadastrado com Sucesso ! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonPesqProd_Click(object sender, EventArgs e)
        {
            
            FormPesquisaProd formPesquisaProd = new FormPesquisaProd
            {
                Owner = this
            };
            formPesquisaProd.ShowDialog();
        }
        int idAuxiliar;
        private void ButtonExcluirVendaItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataaSetTableAdapters.tabvendas_itensTableAdapter excluirvendaItem = new DataaSetTableAdapters.tabvendas_itensTableAdapter();
                excluirvendaItem.DeleteQuery(idAuxiliar);

                MessageBox.Show(" Deletado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonPesquisarVendaItem_Click(object sender, EventArgs e)
        {
           /* FormPesquisaVendaItens formPesquisaVendaItens = new FormPesquisaVendaItens
            {
                Owner = this
            };
            formPesquisaVendaItens.ShowDialog();
           */
        }

        internal void CarregaDadosProd3(int codigoProd, string nomeproduto)
        {
           
                try
                {
                    TextCodigoProd.Text = codigoProd.ToString();
                    TextNomeProduto.Text = nomeproduto;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

           
        }

        public void CarregarDadosVendasItens(int codigoVendaItem, string quandidade, decimal valor_unid, decimal valor_total, int id_venda, int id_produto)
        {

            try
            {
                TextQuantidade.Text = quandidade.ToString();
                TextValorUnid.Text = valor_unid.ToString();
                TextValorTotalVendaItem.Text = valor_total.ToString();
                textCodigoItemVenda.Text = id_venda.ToString();
                TextCodigoProd.Text = id_produto.ToString();
                idAuxiliar = codigoVendaItem;
                //TextNomeProduto.Text = nome;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.tabvendas_itensTableAdapter.Fill(this.dataSet2.tabvendas_itens());

        }

        private void FormCadItemVenda_Load(object sender, EventArgs e)
        {

        }

        /*
        private void TextValorTotalVendaItem_MouseClick(object sender, MouseEventArgs e)
        {
           if (dataGridView1.Rows.Count > 0)
                TextValorTotalVendaItem.Text = CalcularValorTotal().ToString("c");
            
        }

        private double CalcularValorTotal()
        {
            double total = 0;
            int i = 0;
            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                i++;
                total = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) + Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
            }
            return total;
        }
        */
    }
}