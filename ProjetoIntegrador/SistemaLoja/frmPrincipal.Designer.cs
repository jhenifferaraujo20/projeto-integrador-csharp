namespace SistemaLoja
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.novaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarTodosToolStripMenuItem,
            this.novoClienteToolStripMenuItem,
            this.alterarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // listarTodosToolStripMenuItem
            // 
            this.listarTodosToolStripMenuItem.Name = "listarTodosToolStripMenuItem";
            this.listarTodosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarTodosToolStripMenuItem.Text = "Listar todos";
            this.listarTodosToolStripMenuItem.Click += new System.EventHandler(this.listarTodosToolStripMenuItem_Click);
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // alterarClienteToolStripMenuItem
            // 
            this.alterarClienteToolStripMenuItem.Name = "alterarClienteToolStripMenuItem";
            this.alterarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarClienteToolStripMenuItem.Text = "Alterar cliente";
            this.alterarClienteToolStripMenuItem.Click += new System.EventHandler(this.alterarClienteToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listagemDePedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // listagemDePedidosToolStripMenuItem
            // 
            this.listagemDePedidosToolStripMenuItem.Name = "listagemDePedidosToolStripMenuItem";
            this.listagemDePedidosToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.listagemDePedidosToolStripMenuItem.Text = "Listar todos";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarTodosToolStripMenuItem1,
            this.novoProdutoToolStripMenuItem,
            this.alterarProdutoToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // listarTodosToolStripMenuItem1
            // 
            this.listarTodosToolStripMenuItem1.Name = "listarTodosToolStripMenuItem1";
            this.listarTodosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listarTodosToolStripMenuItem1.Text = "Listar todos";
            this.listarTodosToolStripMenuItem1.Click += new System.EventHandler(this.listarTodosToolStripMenuItem1_Click);
            // 
            // novoProdutoToolStripMenuItem
            // 
            this.novoProdutoToolStripMenuItem.Name = "novoProdutoToolStripMenuItem";
            this.novoProdutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoProdutoToolStripMenuItem.Text = "Novo produto";
            this.novoProdutoToolStripMenuItem.Click += new System.EventHandler(this.novoProdutoToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarTodosToolStripMenuItem2,
            this.novaCategoriaToolStripMenuItem});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // listarTodosToolStripMenuItem2
            // 
            this.listarTodosToolStripMenuItem2.Name = "listarTodosToolStripMenuItem2";
            this.listarTodosToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.listarTodosToolStripMenuItem2.Text = "Listar todas";
            // 
            // novaCategoriaToolStripMenuItem
            // 
            this.novaCategoriaToolStripMenuItem.Name = "novaCategoriaToolStripMenuItem";
            this.novaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.novaCategoriaToolStripMenuItem.Text = "Nova categoria";
            // 
            // alterarProdutoToolStripMenuItem
            // 
            this.alterarProdutoToolStripMenuItem.Name = "alterarProdutoToolStripMenuItem";
            this.alterarProdutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarProdutoToolStripMenuItem.Text = "Alterar produto";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "J\'adore Boutique";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagemDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarProdutoToolStripMenuItem;
    }
}