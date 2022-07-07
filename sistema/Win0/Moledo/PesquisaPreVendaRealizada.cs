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
    public partial class FormPesquisaVendaRealizada : Form
    {
        public FormPesquisaVendaRealizada()
        {
            InitializeComponent();
        }

        private void FormPesquisaVendaRealizada_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataaSet.viewvenda'. Você pode movê-la ou removê-la conforme necessário.
            this.viewvendaTableAdapter.Fill(this.dataaSet.viewvenda);
            // TODO: esta linha de código carrega dados na tabela 'dataaSet.tabvenda'. Você pode movê-la ou removê-la conforme necessário.
            // TODO: esta linha de código carrega dados na tabela 'dataSet2.tabvendas_itens'. Você pode movê-la ou removê-la conforme necessário.
            //this.tabvendas_itensTableAdapter.Fill(this.dataSet2.tabvendas_itens);

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.tabvendaTableAdapter.Fill(this.dataSet2.tabvenda);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void buttonPesquisaVendas_Click(object sender, EventArgs e)
        {
            this.tabvendaTableAdapter.Fill(this.dataaSet.tabvenda);

        }
        int codigoPreVenda;
        string numero_nf;
        DateTime data_pedido;
        DateTime data_emissao;
        DateTime data_entrega;
        decimal valor_total;
        int id_terceirocliente;
        string nome;
        private void dataGridViewVendaRealizada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoPreVenda = int.Parse(this.dataGridViewVendaRealizada.CurrentRow.Cells[0].Value.ToString());
            numero_nf = this.dataGridViewVendaRealizada.CurrentRow.Cells[1].Value.ToString();
            data_pedido = DateTime.Parse(this.dataGridViewVendaRealizada.CurrentRow.Cells[2].Value.ToString());
            data_emissao = DateTime.Parse(this.dataGridViewVendaRealizada.CurrentRow.Cells[3].Value.ToString());
            data_entrega = DateTime.Parse(this.dataGridViewVendaRealizada.CurrentRow.Cells[4].Value.ToString());
            valor_total = decimal.Parse(this.dataGridViewVendaRealizada.CurrentRow.Cells[5].Value.ToString());
            id_terceirocliente = int.Parse(this.dataGridViewVendaRealizada.CurrentRow.Cells[6].Value.ToString());
            //em "' é o nome da tela que preciso
            if (this.Owner.Name == "FormRealizarVendas")
            {
                try
                {
                    //GetDataSet .. é uma função dentro da tela tela cadastro produto
                    ((FormRealizarVendas)this.Owner).CarregarPreVenda(codigoPreVenda, numero_nf, data_pedido, data_emissao, data_entrega, id_terceirocliente, nome);
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

        private void dataGridViewVendaRealizada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoPreVenda = int.Parse(this.dataGridViewVendaRealizada.CurrentRow.Cells[0].Value.ToString());
            numero_nf = this.dataGridViewVendaRealizada.CurrentRow.Cells[3].Value.ToString();
            data_pedido = DateTime.Parse(this.dataGridViewVendaRealizada.CurrentRow.Cells[4].Value.ToString());
            data_emissao = DateTime.Parse(this.dataGridViewVendaRealizada.CurrentRow.Cells[5].Value.ToString());
            data_entrega = DateTime.Parse(this.dataGridViewVendaRealizada.CurrentRow.Cells[6].Value.ToString());
            valor_total = decimal.Parse(this.dataGridViewVendaRealizada.CurrentRow.Cells[7].Value.ToString());
            id_terceirocliente = int.Parse(this.dataGridViewVendaRealizada.CurrentRow.Cells[1].Value.ToString());
            string nome=this.dataGridViewVendaRealizada.CurrentRow.Cells[2].Value.ToString();
            //em "' é o nome da tela que preciso
            if (this.Owner.Name == "FormRealizarVendas")
            {
                try
                {
                    //GetDataSet .. é uma função dentro da tela tela cadastro produto
                    ((FormRealizarVendas)this.Owner).CarregarPreVenda(codigoPreVenda, numero_nf, data_pedido, data_emissao, data_entrega, id_terceirocliente, nome);
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
