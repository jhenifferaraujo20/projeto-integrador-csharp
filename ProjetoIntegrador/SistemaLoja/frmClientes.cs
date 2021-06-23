using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaLoja
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCliente(txtNome.Text, txtCPF.Text, txtTelefone.Text, txtCEP.Text, txtEndereco.Text, txtCidade.Text, txtEstado.Text, txtEmail.Text);
            LimparFormulario();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
            txtCEP.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtEmail.Clear();
        }

        private void SalvarCliente(string nome, string cpf, string telefone, string cep, string endereco, string cidade, string estado, string email)
        {
            StreamWriter arquivo;
            string caminho = "C:\\sistema1\\clientes.txt";
            arquivo = File.AppendText(caminho);
            arquivo.WriteLine(nome + " - " + cpf + " - " + telefone + " - " + cep + " - " + endereco + " - " + cidade + " - " + estado + " - " + email);
            arquivo.Close();

            string bancoDeDados = "server=localhost;user id=root;password=;database=loja_jadore";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados: " + erro.Message);
            }
        }
    }
}
