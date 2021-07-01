using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLoja
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesListagem formulario = new frmClientesListagem();
            formulario.ShowDialog();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesCadastro formulario = new frmClientesCadastro();
            formulario.ShowDialog();
        }

        private void alterarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesAlterar formulario = new frmClientesAlterar();
            formulario.ShowDialog();
        }
    }
}
