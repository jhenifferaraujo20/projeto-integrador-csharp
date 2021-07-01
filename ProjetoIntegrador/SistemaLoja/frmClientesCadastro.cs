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
    public partial class frmClientesCadastro : Form
    {
        public frmClientesCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCliente(txtNome.Text, txtCpf.Text, txtTelefone.Text, txtEmail.Text, txtCep.Text, txtRua.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, txtEstado.Text);
            LimparFormulario();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtCep.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
        }

        private void SalvarCliente(string nome, string cpf, string telefone, string email, string cep, string rua, string numero, string bairro, string cidade, string estado)
        {
            StreamWriter arquivo;
            string caminho = "C:\\sistema1\\clientes.txt";
            arquivo = File.AppendText(caminho);
            arquivo.WriteLine(nome + " - " + cpf + " - " + telefone + " - " + email + " - " + cep + " - " + rua + " - " + numero + " - " + bairro + " - " + cidade + " - " + estado);
            arquivo.Close();

            string bancoDeDados = "server=localhost;user id=root;password=;database=loja_jadore";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = $"INSERT INTO clientes(nome_completo, cpf,  telefone, email, cep, rua, numero_casa, bairro, cidade, estado) VALUES('{nome}', '{cpf}', '{telefone}', '{email}', '{cep}', '{rua}', '{numero}', '{bairro} ', '{cidade}', '{estado}');";
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados. \nErro: " + erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void txtEstado_Enter(object sender, EventArgs e)
        {
            SalvarCliente(txtNome.Text, txtCpf.Text, txtTelefone.Text, txtEmail.Text, txtCep.Text, txtRua.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, txtEstado.Text);
            LimparFormulario();
        }

        private void btnSalvar_Enter(object sender, EventArgs e)
        {
            SalvarCliente(txtNome.Text, txtCpf.Text, txtTelefone.Text, txtEmail.Text, txtCep.Text, txtRua.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, txtEstado.Text);
            LimparFormulario();
        }
    }
}
