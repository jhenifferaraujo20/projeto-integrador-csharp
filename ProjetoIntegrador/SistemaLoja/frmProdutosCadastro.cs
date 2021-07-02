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
    public partial class frmProdutosCadastro : Form
    {
        public frmProdutosCadastro()
        {
            InitializeComponent();
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            Janela.InitialDirectory = "C://Desktop";
            Janela.Title = "Selecione uma imagem.";
            Janela.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            Janela.FilterIndex = 1;
            try
            {
                if (Janela.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (Janela.CheckFileExists)
                    {
                        string caminhoDaImagem = System.IO.Path.GetFullPath(Janela.FileName);
                        lblCaminhoDaImagem.Text = caminhoDaImagem;
                        picImagem.Image = new Bitmap(Janela.FileName);
                        picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Realize o upload da imagem.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeDoArquivo = System.IO.Path.GetFileName(Janela.FileName);
                if (nomeDoArquivo == null)
                {
                    MessageBox.Show("Por favor selecione uma imagem válida");
                }
                else
                {
                    string caminho = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(Janela.FileName, caminho + "\\images\\" + nomeDoArquivo);
                    MessageBox.Show("Sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Arquivo já existe");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string tamanho = "";
            if (rbnPP.Checked)
            {
                tamanho = "P";
            }else if (rbnP.Checked)
            {
                tamanho = "P";
            }else if (rbnM.Checked)
            {
                tamanho = "M";
            }
            else
            {
                tamanho = "G";
            }

            SalvarProduto(txtNome.Text, txtPreco.Text, txtPrecoAntigo.Text, txtDescricao.Text, tamanho, txtIdCategoria.Text, txtIdSubcategoria.Text, txtEstoque.Text);
            LimparFormulario();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtPreco.Clear();
            txtPrecoAntigo.Clear();
            txtDescricao.Clear();
            txtIdCategoria.Clear();
            txtIdSubcategoria.Clear();
            txtEstoque.Clear();
        }

        private void SalvarProduto(string nome, string preco, string precoAntigo, string descricao, string tamanho, string idCategoria, string idSubcategoria, string estoque)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=loja_jadore";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = $"INSERT INTO produtos(nome, preco,  preco_antigo, descricao, tamanho, id_categoria, id_subcategoria, estoque) VALUES('{nome}', '{preco}', '{precoAntigo}', '{descricao}', '{tamanho}', '{idCategoria}', '{idSubcategoria}', '{estoque}');";
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Produto cadastrado com sucesso!");
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
    }
}
