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
    public partial class frmProdutosListagem : Form
    {
        public frmProdutosListagem()
        {
            InitializeComponent();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {

        }

        private void frmProdutosListagem_Load(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=loja_jadore";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlSelect = "SELECT produtos.id, produtos.nome, produtos.preco, produtos.cor, produtos.tamanho, categorias.categoria AS categoria, subcategorias.subcategoria AS subcategoria, produtos.quantidade_estoque, produtos.fotos FROM produtos INNER JOIN categorias ON produtos.id_categoria = categorias.id INNER JOIN subcategorias ON produtos.id_subcategoria = subcategorias.id";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelect, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridProdutos.DataSource = dt;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("A conexão com o banco de dados falhou. Erro: " + erro.Message, "Erro na conexão");
            }
        }
    }
}
