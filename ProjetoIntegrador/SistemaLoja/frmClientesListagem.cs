using MySql.Data.MySqlClient;
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
    public partial class frmClientesListagem : Form
    {
        public frmClientesListagem()
        {
            InitializeComponent();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmClientes formulario = new frmClientes();
            formulario.ShowDialog();
        }

        private void frmClientesListagem_Load(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=loja_jadore";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            try
            {
                conexao.Open();
                string sqlSelecionar = "SELECT * FROM clientes";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelecionar , conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridClientes.DataSource = dt;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("A conexão falhou. Erro: " + erro.Message, "Erro na conexão");
            }
        }

        private void txtNomeBuscar_TextChanged(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=loja_jadore";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            try
            {
                string nomeBuscar = txtNomeBuscar.Text;
                conexao.Open();
                string sqlSelecionar = $"SELECT * FROM clientes WHERE nome LIKE '%{nomeBuscar}%'";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelecionar, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridClientes.DataSource = dt;
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("A conexão falhou. Erro: " + erro.Message, "Erro na conexão");
            }
        }

        private void Pesquisar(string nome)
        {
            string sqlBuscar = "";
            sqlBuscar = $"SELECT * FROM clientes WHERE nome LIKE '%{nome}%'";

            string bancoDeDados = "server=localhost;user id=root;password=;database=loja_jadore";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
        }
    }
}
