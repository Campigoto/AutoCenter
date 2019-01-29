namespace UIL
{
    partial class Frm_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Master));
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.btn_inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_cidade = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_produto = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_produto = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_estoque_produto = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_estoque_todos = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_grupo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_subgrupo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_fornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_hist_lanc = new System.Windows.Forms.ToolStripMenuItem();
            this.carroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_movimento = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_contas_pagar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_mov_contas_pagar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_mov_cheque_pagar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_mov_pagto = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_mov_compra = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_relatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_rel_produto = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoXFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoProdutoXFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoProdutoXFornecedorXProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_rel_contas_pagar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_rel_log = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_utilitario = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_uti_funcionario = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_menu
            // 
            this.ms_menu.AutoSize = false;
            this.ms_menu.BackgroundImage = global::UIL.Properties.Resources.barra;
            this.ms_menu.Dock = System.Windows.Forms.DockStyle.None;
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_inicio,
            this.btn_cadastro,
            this.btn_movimento,
            this.btn_relatorio,
            this.btn_utilitario,
            this.btn_sair});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(1068, 71);
            this.ms_menu.TabIndex = 12;
            // 
            // btn_inicio
            // 
            this.btn_inicio.AutoSize = false;
            this.btn_inicio.Image = global::UIL.Properties.Resources.home1;
            this.btn_inicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.ShortcutKeyDisplayString = "";
            this.btn_inicio.Size = new System.Drawing.Size(170, 47);
            this.btn_inicio.Text = " Início";
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.AutoSize = false;
            this.btn_cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cad_cidade,
            this.btn_produto,
            this.btn_cad_cliente,
            this.btn_cad_fornecedor,
            this.btn_cad_hist_lanc,
            this.carroToolStripMenuItem});
            this.btn_cadastro.Image = global::UIL.Properties.Resources.invoice;
            this.btn_cadastro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.ShortcutKeyDisplayString = "";
            this.btn_cadastro.Size = new System.Drawing.Size(170, 47);
            this.btn_cadastro.Text = " Cadastros";
            // 
            // btn_cad_cidade
            // 
            this.btn_cad_cidade.Name = "btn_cad_cidade";
            this.btn_cad_cidade.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.btn_cad_cidade.Size = new System.Drawing.Size(176, 22);
            this.btn_cad_cidade.Text = "Cidade";
            this.btn_cad_cidade.Click += new System.EventHandler(this.btn_cad_cidade_Click);
            // 
            // btn_produto
            // 
            this.btn_produto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cad_produto,
            this.btn_cad_estoque,
            this.btn_cad_grupo,
            this.btn_cad_subgrupo});
            this.btn_produto.Name = "btn_produto";
            this.btn_produto.Size = new System.Drawing.Size(176, 22);
            this.btn_produto.Text = "Produto";
            // 
            // btn_cad_produto
            // 
            this.btn_cad_produto.Name = "btn_cad_produto";
            this.btn_cad_produto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.btn_cad_produto.Size = new System.Drawing.Size(162, 22);
            this.btn_cad_produto.Text = "Cadastro";
            this.btn_cad_produto.Click += new System.EventHandler(this.btn_cad_produto_Click);
            // 
            // btn_cad_estoque
            // 
            this.btn_cad_estoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cad_estoque_produto,
            this.btn_cad_estoque_todos});
            this.btn_cad_estoque.Name = "btn_cad_estoque";
            this.btn_cad_estoque.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.btn_cad_estoque.Size = new System.Drawing.Size(162, 22);
            this.btn_cad_estoque.Text = "Estoque";
            // 
            // btn_cad_estoque_produto
            // 
            this.btn_cad_estoque_produto.Name = "btn_cad_estoque_produto";
            this.btn_cad_estoque_produto.Size = new System.Drawing.Size(138, 22);
            this.btn_cad_estoque_produto.Text = "Por Produto";
            this.btn_cad_estoque_produto.Click += new System.EventHandler(this.btn_cad_estoque_produto_Click);
            // 
            // btn_cad_estoque_todos
            // 
            this.btn_cad_estoque_todos.Name = "btn_cad_estoque_todos";
            this.btn_cad_estoque_todos.Size = new System.Drawing.Size(138, 22);
            this.btn_cad_estoque_todos.Text = "Todos";
            this.btn_cad_estoque_todos.Click += new System.EventHandler(this.btn_cad_estoque_todos_Click);
            // 
            // btn_cad_grupo
            // 
            this.btn_cad_grupo.Name = "btn_cad_grupo";
            this.btn_cad_grupo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.btn_cad_grupo.Size = new System.Drawing.Size(162, 22);
            this.btn_cad_grupo.Text = "Grupo";
            this.btn_cad_grupo.Click += new System.EventHandler(this.btn_cad_grupo_Click);
            // 
            // btn_cad_subgrupo
            // 
            this.btn_cad_subgrupo.Name = "btn_cad_subgrupo";
            this.btn_cad_subgrupo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.btn_cad_subgrupo.Size = new System.Drawing.Size(162, 22);
            this.btn_cad_subgrupo.Text = "Subgrupo";
            this.btn_cad_subgrupo.Click += new System.EventHandler(this.btn_cad_subgrupo_Click);
            // 
            // btn_cad_cliente
            // 
            this.btn_cad_cliente.Name = "btn_cad_cliente";
            this.btn_cad_cliente.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.btn_cad_cliente.Size = new System.Drawing.Size(176, 22);
            this.btn_cad_cliente.Text = "Cliente";
            this.btn_cad_cliente.Click += new System.EventHandler(this.btn_cad_cliente_Click);
            // 
            // btn_cad_fornecedor
            // 
            this.btn_cad_fornecedor.Name = "btn_cad_fornecedor";
            this.btn_cad_fornecedor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.btn_cad_fornecedor.Size = new System.Drawing.Size(176, 22);
            this.btn_cad_fornecedor.Text = "Fornecedor";
            this.btn_cad_fornecedor.Click += new System.EventHandler(this.btn_cad_fornecedor_Click);
            // 
            // btn_cad_hist_lanc
            // 
            this.btn_cad_hist_lanc.Name = "btn_cad_hist_lanc";
            this.btn_cad_hist_lanc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.btn_cad_hist_lanc.Size = new System.Drawing.Size(176, 22);
            this.btn_cad_hist_lanc.Text = "Lançamento";
            this.btn_cad_hist_lanc.Click += new System.EventHandler(this.btn_cad_hist_lanc_Click);
            // 
            // carroToolStripMenuItem
            // 
            this.carroToolStripMenuItem.Name = "carroToolStripMenuItem";
            this.carroToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.carroToolStripMenuItem.Text = "Carro";
            this.carroToolStripMenuItem.Click += new System.EventHandler(this.btn_cad_carro_Click);
            // 
            // btn_movimento
            // 
            this.btn_movimento.AutoSize = false;
            this.btn_movimento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_contas_pagar,
            this.btn_mov_compra,
            this.ordemDeServiçoToolStripMenuItem,
            this.vendaToolStripMenuItem});
            this.btn_movimento.Image = global::UIL.Properties.Resources.coins;
            this.btn_movimento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_movimento.Name = "btn_movimento";
            this.btn_movimento.ShortcutKeyDisplayString = "M";
            this.btn_movimento.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.btn_movimento.Size = new System.Drawing.Size(170, 47);
            this.btn_movimento.Text = " Movimentos";
            // 
            // btn_contas_pagar
            // 
            this.btn_contas_pagar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_mov_contas_pagar,
            this.btn_mov_cheque_pagar,
            this.btn_mov_pagto});
            this.btn_contas_pagar.Name = "btn_contas_pagar";
            this.btn_contas_pagar.Size = new System.Drawing.Size(207, 22);
            this.btn_contas_pagar.Text = "Contas a Pagar";
            // 
            // btn_mov_contas_pagar
            // 
            this.btn_mov_contas_pagar.Name = "btn_mov_contas_pagar";
            this.btn_mov_contas_pagar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.btn_mov_contas_pagar.Size = new System.Drawing.Size(196, 22);
            this.btn_mov_contas_pagar.Text = "Cadastro";
            this.btn_mov_contas_pagar.Click += new System.EventHandler(this.btn_mov_contas_pagar_Click);
            // 
            // btn_mov_cheque_pagar
            // 
            this.btn_mov_cheque_pagar.Name = "btn_mov_cheque_pagar";
            this.btn_mov_cheque_pagar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.btn_mov_cheque_pagar.Size = new System.Drawing.Size(196, 22);
            this.btn_mov_cheque_pagar.Text = "Cheque a Pagar";
            this.btn_mov_cheque_pagar.Click += new System.EventHandler(this.btn_mov_cheque_pagar_Click);
            // 
            // btn_mov_pagto
            // 
            this.btn_mov_pagto.Name = "btn_mov_pagto";
            this.btn_mov_pagto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.btn_mov_pagto.Size = new System.Drawing.Size(196, 22);
            this.btn_mov_pagto.Text = "Pagamento";
            this.btn_mov_pagto.Click += new System.EventHandler(this.btn_mov_pagto_Click);
            // 
            // btn_mov_compra
            // 
            this.btn_mov_compra.Name = "btn_mov_compra";
            this.btn_mov_compra.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.btn_mov_compra.Size = new System.Drawing.Size(207, 22);
            this.btn_mov_compra.Text = "Compra";
            this.btn_mov_compra.Click += new System.EventHandler(this.btn_mov_compra_Click);
            // 
            // ordemDeServiçoToolStripMenuItem
            // 
            this.ordemDeServiçoToolStripMenuItem.Name = "ordemDeServiçoToolStripMenuItem";
            this.ordemDeServiçoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.ordemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.ordemDeServiçoToolStripMenuItem.Text = "Ordem de Serviço";
            this.ordemDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.ordemDeServiçoToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // btn_relatorio
            // 
            this.btn_relatorio.AutoSize = false;
            this.btn_relatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_rel_produto,
            this.btn_rel_contas_pagar,
            this.btn_rel_log});
            this.btn_relatorio.Image = global::UIL.Properties.Resources.bar_chart;
            this.btn_relatorio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_relatorio.Name = "btn_relatorio";
            this.btn_relatorio.ShortcutKeyDisplayString = "R";
            this.btn_relatorio.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.btn_relatorio.Size = new System.Drawing.Size(170, 47);
            this.btn_relatorio.Text = " Relatórios";
            // 
            // btn_rel_produto
            // 
            this.btn_rel_produto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem,
            this.produtoXFornecedorToolStripMenuItem,
            this.grupoProdutoXFornecedorToolStripMenuItem,
            this.grupoProdutoXFornecedorXProdutoToolStripMenuItem});
            this.btn_rel_produto.Name = "btn_rel_produto";
            this.btn_rel_produto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.btn_rel_produto.Size = new System.Drawing.Size(189, 22);
            this.btn_rel_produto.Text = "Produto";
            this.btn_rel_produto.Click += new System.EventHandler(this.btn_rel_produto_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // produtoXFornecedorToolStripMenuItem
            // 
            this.produtoXFornecedorToolStripMenuItem.Name = "produtoXFornecedorToolStripMenuItem";
            this.produtoXFornecedorToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.produtoXFornecedorToolStripMenuItem.Text = "Produto X Fornecedor";
            this.produtoXFornecedorToolStripMenuItem.Click += new System.EventHandler(this.produtoXFornecedorToolStripMenuItem_Click);
            // 
            // grupoProdutoXFornecedorToolStripMenuItem
            // 
            this.grupoProdutoXFornecedorToolStripMenuItem.Name = "grupoProdutoXFornecedorToolStripMenuItem";
            this.grupoProdutoXFornecedorToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.grupoProdutoXFornecedorToolStripMenuItem.Text = "Grupo Produto X Fornecedor";
            this.grupoProdutoXFornecedorToolStripMenuItem.Click += new System.EventHandler(this.grupoProdutoXFornecedorToolStripMenuItem_Click);
            // 
            // grupoProdutoXFornecedorXProdutoToolStripMenuItem
            // 
            this.grupoProdutoXFornecedorXProdutoToolStripMenuItem.Name = "grupoProdutoXFornecedorXProdutoToolStripMenuItem";
            this.grupoProdutoXFornecedorXProdutoToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.grupoProdutoXFornecedorXProdutoToolStripMenuItem.Text = "Grupo Produto X Fornecedor X  Produto";
            this.grupoProdutoXFornecedorXProdutoToolStripMenuItem.Click += new System.EventHandler(this.grupoProdutoXFornecedorXProdutoToolStripMenuItem_Click);
            // 
            // btn_rel_contas_pagar
            // 
            this.btn_rel_contas_pagar.Name = "btn_rel_contas_pagar";
            this.btn_rel_contas_pagar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.btn_rel_contas_pagar.Size = new System.Drawing.Size(189, 22);
            this.btn_rel_contas_pagar.Text = "Contas a Pagar";
            this.btn_rel_contas_pagar.Click += new System.EventHandler(this.btn_rel_contas_pagar_Click);
            // 
            // btn_rel_log
            // 
            this.btn_rel_log.Name = "btn_rel_log";
            this.btn_rel_log.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.btn_rel_log.Size = new System.Drawing.Size(189, 22);
            this.btn_rel_log.Text = "Log";
            this.btn_rel_log.Click += new System.EventHandler(this.btn_rel_log_Click);
            // 
            // btn_utilitario
            // 
            this.btn_utilitario.AutoSize = false;
            this.btn_utilitario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_uti_funcionario,
            this.backupToolStripMenuItem});
            this.btn_utilitario.Image = global::UIL.Properties.Resources.development_tools;
            this.btn_utilitario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_utilitario.Name = "btn_utilitario";
            this.btn_utilitario.ShortcutKeyDisplayString = "U";
            this.btn_utilitario.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.btn_utilitario.Size = new System.Drawing.Size(170, 47);
            this.btn_utilitario.Text = " Utilitários";
            // 
            // btn_uti_funcionario
            // 
            this.btn_uti_funcionario.Name = "btn_uti_funcionario";
            this.btn_uti_funcionario.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.btn_uti_funcionario.Size = new System.Drawing.Size(175, 22);
            this.btn_uti_funcionario.Text = "Funcionário";
            this.btn_uti_funcionario.Click += new System.EventHandler(this.btn_uti_funcionario_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.AutoSize = false;
            this.btn_sair.Image = global::UIL.Properties.Resources.gnome_application_exit1;
            this.btn_sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.ShortcutKeyDisplayString = "";
            this.btn_sair.Size = new System.Drawing.Size(170, 47);
            this.btn_sair.Text = " Sair";
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Frm_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 562);
            this.Controls.Add(this.ms_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master";
            this.Load += new System.EventHandler(this.Frm_Master_Load);
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_menu;
        private System.Windows.Forms.ToolStripMenuItem btn_inicio;
        private System.Windows.Forms.ToolStripMenuItem btn_cadastro;
        private System.Windows.Forms.ToolStripMenuItem btn_cad_cidade;
        private System.Windows.Forms.ToolStripMenuItem btn_produto;
        private System.Windows.Forms.ToolStripMenuItem btn_cad_produto;
        private System.Windows.Forms.ToolStripMenuItem btn_cad_grupo;
        private System.Windows.Forms.ToolStripMenuItem btn_cad_subgrupo;
        private System.Windows.Forms.ToolStripMenuItem btn_cad_cliente;
        private System.Windows.Forms.ToolStripMenuItem btn_cad_fornecedor;
        private System.Windows.Forms.ToolStripMenuItem btn_movimento;
        private System.Windows.Forms.ToolStripMenuItem btn_contas_pagar;
        private System.Windows.Forms.ToolStripMenuItem btn_mov_contas_pagar;
        private System.Windows.Forms.ToolStripMenuItem btn_mov_cheque_pagar;
        private System.Windows.Forms.ToolStripMenuItem btn_mov_pagto;
        private System.Windows.Forms.ToolStripMenuItem btn_mov_compra;
        private System.Windows.Forms.ToolStripMenuItem btn_relatorio;
        private System.Windows.Forms.ToolStripMenuItem btn_rel_produto;
        private System.Windows.Forms.ToolStripMenuItem btn_rel_contas_pagar;
        private System.Windows.Forms.ToolStripMenuItem btn_utilitario;
        private System.Windows.Forms.ToolStripMenuItem btn_uti_funcionario;
        private System.Windows.Forms.ToolStripMenuItem btn_sair;
        private System.Windows.Forms.ToolStripMenuItem btn_cad_hist_lanc;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoXFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoProdutoXFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_rel_log;
        private System.Windows.Forms.ToolStripMenuItem btn_cad_estoque;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoProdutoXFornecedorXProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_cad_estoque_produto;
        private System.Windows.Forms.ToolStripMenuItem btn_cad_estoque_todos;
        private System.Windows.Forms.ToolStripMenuItem carroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
    }
}