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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
   

        private void CadastrarProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormCadastroProd().Show();
        }

        private void CadastroClienteMenu(object sender, EventArgs e)
        {
            FormtesteTerceiro formtesteTerceiro = new FormtesteTerceiro();
            formtesteTerceiro.ShowDialog();
        }

        
        private void PesquisarVendasRealizadas_Click(object sender, EventArgs e)
        {
            FormPesquisaVendaRealizada FormPesquisaVenda = new FormPesquisaVendaRealizada();
            FormPesquisaVenda.ShowDialog();
        }

     

        private void PesquisarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesqTerceiro pesqTerceiro = new FormPesqTerceiro();
            pesqTerceiro.ShowDialog();
        }

        private void CadastrarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRealizarVendas formRealizarVendasItens = new FormRealizarVendas();
            formRealizarVendasItens.ShowDialog();
        }

        private void PesquisaProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPesquisaProd formPesquisaProd = new FormPesquisaProd();
            formPesquisaProd.ShowDialog();
        }

        private void cadastrarVendaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormRealizarVendas formRealizarVendas = new FormRealizarVendas();
            formRealizarVendas.ShowDialog();
        }

        private void cadastroFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionario formCadastroFuncionario = new FormCadastroFuncionario();
            formCadastroFuncionario.ShowDialog();
        }

        private void pesquisaProdutoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FormPesquisaProd formPesquisaProd = new FormPesquisaProd();
            formPesquisaProd.ShowDialog();
        }

        private void pesquisarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaFuncionario formPesquisaFuncionario = new FormPesquisaFuncionario();
            formPesquisaFuncionario.ShowDialog();
        }

        

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void nomeEPreçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioNomePrecoProd formRelatorioNomePrecoProd = new FormRelatorioNomePrecoProd();
            formRelatorioNomePrecoProd.ShowDialog();
        }
    }
}
