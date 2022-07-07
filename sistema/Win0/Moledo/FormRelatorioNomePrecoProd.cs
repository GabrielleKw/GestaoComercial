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
    public partial class FormRelatorioNomePrecoProd : Form
    {
        public FormRelatorioNomePrecoProd()
        {
            InitializeComponent();
        }

       

      

        private void buttonPesquisaProduto_Click(object sender, EventArgs e)
        {
            this.tabcadastroprodutoTableAdapter.Fill(this.dataaSet.tabcadastroproduto);

        }
    }
}
