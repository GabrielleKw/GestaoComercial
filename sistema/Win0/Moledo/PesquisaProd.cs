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

        private void PesquisaProd_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.tabCadastroProduto'. Você pode movê-la ou removê-la conforme necessário.
            //this.tabCadastroProdutoTableAdapter.Fill(this.dataSet1.tabCadastroProduto);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonPesquisaProduto_Click(object sender, EventArgs e)
        {
            this.tabCadastroProdutoTableAdapter.Fill(this.dataSet1.tabCadastroProduto);

        }


    }
}
