using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaLoja
{
    public partial class frmClientesAlterar : Form
    {
        public frmClientesAlterar()
        {
            InitializeComponent();
        }


        private void BtnCarregar_Click(object sender, EventArgs e)
        {
            string idCliente = txtId.Text;
            string bancoDeDados = "server=localhost;user id=root;password=;database=loja_jadore";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlBuscar = $" SELECT * FROM clientes WHERE id={idCliente}";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sqlBuscar, conexao);
                da.Fill(dt);
                txtNome.Text = dt.Rows[0]["nome_completo"].ToString();
                txtCpf.Text = dt.Rows[0]["cpf"].ToString();
                txtTelefone.Text = dt.Rows[0]["telefone"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtCep.Text = dt.Rows[0]["cep"].ToString();
                txtRua.Text = dt.Rows[0]["rua"].ToString();
                txtNumero.Text = dt.Rows[0]["numero_casa"].ToString();
                txtBairro.Text = dt.Rows[0]["bairro"].ToString();
                txtCidade.Text = dt.Rows[0]["cidade"].ToString();
                txtEstado.Text = dt.Rows[0]["estado"].ToString();
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Algo errado com a conexao. Erro: " + erro.Message);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=loja_jadore";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlAlterar = $"UPDATE clientes SET nome_completo='{txtNome.Text}', cpf='{txtCpf.Text}', telefone='{txtTelefone.Text}', email='{txtEmail.Text}', cep='{txtCep.Text}', rua='{txtRua.Text}', numero_casa='{txtNumero.Text}', bairro='{txtBairro.Text}', cidade='{txtCidade.Text}', estado='{txtEstado.Text}'  WHERE id={txtId.Text}";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sqlAlterar;
                cmd.ExecuteNonQuery();
                conexao.Clone();
                MessageBox.Show("Alterado com sucesso!");
            }catch(MySqlException erro)
            {
                MessageBox.Show("Algum erro ocorreu. Erro: " + erro.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=loja_jadore";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            string idCliente = txtId.Text;
            try
            {
                conexao.Open();
                string sqlExcluir = $"DELETE FROM clientes WHERE id={idCliente}";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sqlExcluir;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Excluído com sucesso!");
                txtNome.Clear();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Algum erro ocorreu. Erro: " + erro.Message);
            }
        }
    }
}
