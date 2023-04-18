using ControllerProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ViewProject
{
    public partial class FormJanelaPrincipal : Form
    {
        private NotaEntradaController notaEntradaController =
            new NotaEntradaController();
        private FornecedorCotroller fornecedorController = 
            new FornecedorCotroller();
        private ProdutoController produtoController =
            new ProdutoController();
        public FormJanelaPrincipal()
        {
            InitializeComponent();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFornecedor(fornecedorController).
                ShowDialog();
        }

        private void compasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRegistro(notaEntradaController,
                fornecedorController, produtoController).
                ShowDialog();

        }
    }
}
