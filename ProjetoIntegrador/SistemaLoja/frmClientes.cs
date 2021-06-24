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

        public object Telefone { get; private set; }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtNome.Text, "Campo obrigatório!");
            }

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

            // Conexão
            // String de conexão
            string bancoDeDados = "server=localhost;user id=root;password=;database=loja_jadore";

            // Objeto de conexão
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            // Tratamento de exceção
            try
            {
                // Abrir conexão com o banco de dados
                conexao.Open();

                // Objeto que vai armazenar um comando sql e vai executar
                MySqlCommand cmd = new MySqlCommand();
                // informa o objeto de conexao para o cmd
                cmd.Connection = conexao;
                // Informar o sql que será executado
                cmd.CommandText = $"INSERT INTO clientes(nome, cpf, telefone, cep, endereco, cidade, estado, email) VALUES(' {nome} ', ' {cpf} ', ' {telefone} ', ' {cep} ', ' {endereco} ', ' {cidade} ', ' {estado} ', ' {email} ');";
                // Executar o sql
                cmd.ExecuteNonQuery();

                // Fechar a conexao
                conexao.Close();
                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados. \nErro: " + erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                e.Cancel = true;
                txtNome.Focus();
                erroNome.SetError(txtNome, "Nome precisa ser preenchido!");
            }
            else
            {
                e.Cancel = false;
                erroNome.SetError(txtNome, "");
            }
        }
    }
}
