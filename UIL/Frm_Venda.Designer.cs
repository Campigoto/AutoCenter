namespace UIL
{
    partial class Frm_Venda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_compra = new System.Windows.Forms.GroupBox();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.gb_movimentação = new System.Windows.Forms.GroupBox();
            this.rb_venda = new System.Windows.Forms.RadioButton();
            this.rb_orcamento = new System.Windows.Forms.RadioButton();
            this.btn_produto = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.tb_subtotal = new System.Windows.Forms.TextBox();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.lbl_acresc = new System.Windows.Forms.Label();
            this.tb_acresc = new System.Windows.Forms.TextBox();
            this.tb_data = new System.Windows.Forms.MaskedTextBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.lbl_out_desp = new System.Windows.Forms.Label();
            this.tb_out_desp = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.gb_financeiro = new System.Windows.Forms.GroupBox();
            this.rb_avista = new System.Windows.Forms.RadioButton();
            this.rb_aprazo = new System.Windows.Forms.RadioButton();
            this.rb_nao_gerar = new System.Windows.Forms.RadioButton();
            this.PC_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_PRODUTO_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_NOME_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_UNIDADE_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_QTDE_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_PRECO_COMPRA_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_TOTAL_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_compra.SuspendLayout();
            this.gb_movimentação.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.gb_financeiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_compra
            // 
            this.gb_compra.Controls.Add(this.btn_imprimir);
            this.gb_compra.Controls.Add(this.gb_movimentação);
            this.gb_compra.Controls.Add(this.btn_produto);
            this.gb_compra.Controls.Add(this.lbl_total);
            this.gb_compra.Controls.Add(this.tb_total);
            this.gb_compra.Controls.Add(this.lbl_subtotal);
            this.gb_compra.Controls.Add(this.tb_subtotal);
            this.gb_compra.Controls.Add(this.lbl_desc);
            this.gb_compra.Controls.Add(this.tb_desc);
            this.gb_compra.Controls.Add(this.lbl_acresc);
            this.gb_compra.Controls.Add(this.tb_acresc);
            this.gb_compra.Controls.Add(this.tb_data);
            this.gb_compra.Controls.Add(this.lbl_data);
            this.gb_compra.Controls.Add(this.btn_pesquisar);
            this.gb_compra.Controls.Add(this.lbl_out_desp);
            this.gb_compra.Controls.Add(this.tb_out_desp);
            this.gb_compra.Controls.Add(this.btn_cancelar);
            this.gb_compra.Controls.Add(this.dgv_produtos);
            this.gb_compra.Controls.Add(this.cb_cliente);
            this.gb_compra.Controls.Add(this.lbl_codigo);
            this.gb_compra.Controls.Add(this.tb_codigo);
            this.gb_compra.Controls.Add(this.lbl_cliente);
            this.gb_compra.Controls.Add(this.btn_limpar);
            this.gb_compra.Controls.Add(this.btn_gravar);
            this.gb_compra.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_compra.Location = new System.Drawing.Point(34, 88);
            this.gb_compra.Name = "gb_compra";
            this.gb_compra.Size = new System.Drawing.Size(1000, 462);
            this.gb_compra.TabIndex = 25;
            this.gb_compra.TabStop = false;
            this.gb_compra.Text = "Cadastro:";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Enabled = false;
            this.btn_imprimir.Location = new System.Drawing.Point(862, 420);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(88, 30);
            this.btn_imprimir.TabIndex = 86;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // gb_movimentação
            // 
            this.gb_movimentação.Controls.Add(this.rb_venda);
            this.gb_movimentação.Controls.Add(this.rb_orcamento);
            this.gb_movimentação.Location = new System.Drawing.Point(780, 39);
            this.gb_movimentação.Margin = new System.Windows.Forms.Padding(2);
            this.gb_movimentação.Name = "gb_movimentação";
            this.gb_movimentação.Padding = new System.Windows.Forms.Padding(2);
            this.gb_movimentação.Size = new System.Drawing.Size(170, 50);
            this.gb_movimentação.TabIndex = 85;
            this.gb_movimentação.TabStop = false;
            this.gb_movimentação.Text = "Movimentação";
            // 
            // rb_venda
            // 
            this.rb_venda.AutoSize = true;
            this.rb_venda.Location = new System.Drawing.Point(101, 18);
            this.rb_venda.Margin = new System.Windows.Forms.Padding(2);
            this.rb_venda.Name = "rb_venda";
            this.rb_venda.Size = new System.Drawing.Size(61, 17);
            this.rb_venda.TabIndex = 1;
            this.rb_venda.TabStop = true;
            this.rb_venda.Text = "Venda";
            this.rb_venda.UseVisualStyleBackColor = true;
            // 
            // rb_orcamento
            // 
            this.rb_orcamento.AutoSize = true;
            this.rb_orcamento.Checked = true;
            this.rb_orcamento.Location = new System.Drawing.Point(16, 19);
            this.rb_orcamento.Margin = new System.Windows.Forms.Padding(2);
            this.rb_orcamento.Name = "rb_orcamento";
            this.rb_orcamento.Size = new System.Drawing.Size(88, 17);
            this.rb_orcamento.TabIndex = 0;
            this.rb_orcamento.TabStop = true;
            this.rb_orcamento.Text = "Orçamento";
            this.rb_orcamento.UseVisualStyleBackColor = true;
            // 
            // btn_produto
            // 
            this.btn_produto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produto.Location = new System.Drawing.Point(439, 420);
            this.btn_produto.Name = "btn_produto";
            this.btn_produto.Size = new System.Drawing.Size(100, 30);
            this.btn_produto.TabIndex = 17;
            this.btn_produto.Text = "Produto";
            this.btn_produto.UseVisualStyleBackColor = true;
            this.btn_produto.Click += new System.EventHandler(this.btn_produto_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(871, 323);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(40, 13);
            this.lbl_total.TabIndex = 84;
            this.lbl_total.Text = "Total:";
            // 
            // tb_total
            // 
            this.tb_total.Enabled = false;
            this.tb_total.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total.Location = new System.Drawing.Point(870, 340);
            this.tb_total.MaxLength = 10;
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(100, 21);
            this.tb_total.TabIndex = 15;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.Location = new System.Drawing.Point(870, 118);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(59, 13);
            this.lbl_subtotal.TabIndex = 82;
            this.lbl_subtotal.Text = "Subtotal:";
            // 
            // tb_subtotal
            // 
            this.tb_subtotal.Enabled = false;
            this.tb_subtotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subtotal.Location = new System.Drawing.Point(870, 134);
            this.tb_subtotal.MaxLength = 10;
            this.tb_subtotal.Name = "tb_subtotal";
            this.tb_subtotal.Size = new System.Drawing.Size(100, 21);
            this.tb_subtotal.TabIndex = 10;
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.Location = new System.Drawing.Point(870, 273);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(65, 13);
            this.lbl_desc.TabIndex = 80;
            this.lbl_desc.Text = "Desconto:";
            // 
            // tb_desc
            // 
            this.tb_desc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_desc.Location = new System.Drawing.Point(870, 289);
            this.tb_desc.MaxLength = 10;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(100, 21);
            this.tb_desc.TabIndex = 14;
            this.tb_desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valor_KeyPress);
            this.tb_desc.Leave += new System.EventHandler(this.Valor_Leave);
            // 
            // lbl_acresc
            // 
            this.lbl_acresc.AutoSize = true;
            this.lbl_acresc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acresc.Location = new System.Drawing.Point(870, 223);
            this.lbl_acresc.Name = "lbl_acresc";
            this.lbl_acresc.Size = new System.Drawing.Size(71, 13);
            this.lbl_acresc.TabIndex = 78;
            this.lbl_acresc.Text = "Acréscimo:";
            // 
            // tb_acresc
            // 
            this.tb_acresc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_acresc.Location = new System.Drawing.Point(870, 240);
            this.tb_acresc.MaxLength = 10;
            this.tb_acresc.Name = "tb_acresc";
            this.tb_acresc.Size = new System.Drawing.Size(100, 21);
            this.tb_acresc.TabIndex = 13;
            this.tb_acresc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valor_KeyPress);
            this.tb_acresc.Leave += new System.EventHandler(this.Valor_Leave);
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(546, 55);
            this.tb_data.Mask = "00/00/0000";
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(100, 21);
            this.tb_data.TabIndex = 4;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(543, 39);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(39, 13);
            this.lbl_data.TabIndex = 71;
            this.lbl_data.Text = "Data:";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(333, 420);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(100, 30);
            this.btn_pesquisar.TabIndex = 16;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // lbl_out_desp
            // 
            this.lbl_out_desp.AutoSize = true;
            this.lbl_out_desp.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_out_desp.Location = new System.Drawing.Point(870, 168);
            this.lbl_out_desp.Name = "lbl_out_desp";
            this.lbl_out_desp.Size = new System.Drawing.Size(95, 13);
            this.lbl_out_desp.TabIndex = 52;
            this.lbl_out_desp.Text = "Out. Despesas:";
            // 
            // tb_out_desp
            // 
            this.tb_out_desp.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_out_desp.Location = new System.Drawing.Point(870, 184);
            this.tb_out_desp.MaxLength = 10;
            this.tb_out_desp.Name = "tb_out_desp";
            this.tb_out_desp.Size = new System.Drawing.Size(100, 21);
            this.tb_out_desp.TabIndex = 11;
            this.tb_out_desp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valor_KeyPress);
            this.tb_out_desp.Leave += new System.EventHandler(this.Valor_Leave);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(757, 420);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 30);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PC_ITEM,
            this.PC_PRODUTO_FORMATADO,
            this.PRO_NOME_FORMATADO,
            this.PC_UNIDADE_FORMATADO,
            this.PC_QTDE_FORMATADO,
            this.PC_PRECO_COMPRA_FORMATADO,
            this.PC_TOTAL_FORMATADO});
            this.dgv_produtos.Location = new System.Drawing.Point(25, 94);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.RowHeadersVisible = false;
            this.dgv_produtos.Size = new System.Drawing.Size(832, 309);
            this.dgv_produtos.TabIndex = 9;
            this.dgv_produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produtos_CellClick);
            this.dgv_produtos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produtos_CellDoubleClick);
            this.dgv_produtos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produtos_CellEndEdit);
            this.dgv_produtos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_produtos_KeyDown);
            // 
            // cb_cliente
            // 
            this.cb_cliente.DisplayMember = "CLI_NOME";
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Location = new System.Drawing.Point(146, 55);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(369, 21);
            this.cb_cliente.TabIndex = 2;
            this.cb_cliente.ValueMember = "CLI_CODIGO";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(22, 39);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(52, 13);
            this.lbl_codigo.TabIndex = 25;
            this.lbl_codigo.Text = "Código:";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(25, 55);
            this.tb_codigo.MaxLength = 10;
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(100, 21);
            this.tb_codigo.TabIndex = 1;
            this.tb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            this.tb_codigo.Leave += new System.EventHandler(this.tb_codigo_Leave);
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(143, 39);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(52, 13);
            this.lbl_cliente.TabIndex = 23;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(651, 420);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(100, 30);
            this.btn_limpar.TabIndex = 19;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravar.Location = new System.Drawing.Point(545, 420);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(100, 30);
            this.btn_gravar.TabIndex = 18;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // gb_financeiro
            // 
            this.gb_financeiro.Controls.Add(this.rb_avista);
            this.gb_financeiro.Controls.Add(this.rb_aprazo);
            this.gb_financeiro.Controls.Add(this.rb_nao_gerar);
            this.gb_financeiro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_financeiro.Location = new System.Drawing.Point(732, 74);
            this.gb_financeiro.Name = "gb_financeiro";
            this.gb_financeiro.Size = new System.Drawing.Size(251, 44);
            this.gb_financeiro.TabIndex = 88;
            this.gb_financeiro.TabStop = false;
            this.gb_financeiro.Text = "Financeiro:";
            // 
            // rb_avista
            // 
            this.rb_avista.AutoSize = true;
            this.rb_avista.Location = new System.Drawing.Point(101, 18);
            this.rb_avista.Name = "rb_avista";
            this.rb_avista.Size = new System.Drawing.Size(65, 17);
            this.rb_avista.TabIndex = 7;
            this.rb_avista.Text = "À Vista";
            this.rb_avista.UseVisualStyleBackColor = true;
            // 
            // rb_aprazo
            // 
            this.rb_aprazo.AutoSize = true;
            this.rb_aprazo.Checked = true;
            this.rb_aprazo.Location = new System.Drawing.Point(172, 18);
            this.rb_aprazo.Name = "rb_aprazo";
            this.rb_aprazo.Size = new System.Drawing.Size(69, 17);
            this.rb_aprazo.TabIndex = 8;
            this.rb_aprazo.TabStop = true;
            this.rb_aprazo.Text = "À Prazo";
            this.rb_aprazo.UseVisualStyleBackColor = true;
            // 
            // rb_nao_gerar
            // 
            this.rb_nao_gerar.AutoSize = true;
            this.rb_nao_gerar.Location = new System.Drawing.Point(16, 18);
            this.rb_nao_gerar.Name = "rb_nao_gerar";
            this.rb_nao_gerar.Size = new System.Drawing.Size(84, 17);
            this.rb_nao_gerar.TabIndex = 6;
            this.rb_nao_gerar.Text = "Não Gerar";
            this.rb_nao_gerar.UseVisualStyleBackColor = true;
            // 
            // PC_ITEM
            // 
            this.PC_ITEM.DataPropertyName = "PC_ITEM";
            this.PC_ITEM.HeaderText = "Item";
            this.PC_ITEM.MaxInputLength = 10;
            this.PC_ITEM.Name = "PC_ITEM";
            this.PC_ITEM.ReadOnly = true;
            this.PC_ITEM.Width = 50;
            // 
            // PC_PRODUTO_FORMATADO
            // 
            this.PC_PRODUTO_FORMATADO.DataPropertyName = "PC_PRODUTO_FORMATADO";
            this.PC_PRODUTO_FORMATADO.HeaderText = "Código";
            this.PC_PRODUTO_FORMATADO.MaxInputLength = 50;
            this.PC_PRODUTO_FORMATADO.Name = "PC_PRODUTO_FORMATADO";
            this.PC_PRODUTO_FORMATADO.ReadOnly = true;
            this.PC_PRODUTO_FORMATADO.Width = 70;
            // 
            // PRO_NOME_FORMATADO
            // 
            this.PRO_NOME_FORMATADO.DataPropertyName = "PRO_NOME_FORMATADO";
            this.PRO_NOME_FORMATADO.HeaderText = "Produto";
            this.PRO_NOME_FORMATADO.MaxInputLength = 10;
            this.PRO_NOME_FORMATADO.Name = "PRO_NOME_FORMATADO";
            this.PRO_NOME_FORMATADO.ReadOnly = true;
            this.PRO_NOME_FORMATADO.Width = 300;
            // 
            // PC_UNIDADE_FORMATADO
            // 
            this.PC_UNIDADE_FORMATADO.DataPropertyName = "PC_UNIDADE_FORMATADO";
            this.PC_UNIDADE_FORMATADO.HeaderText = "Unidade";
            this.PC_UNIDADE_FORMATADO.MaxInputLength = 10;
            this.PC_UNIDADE_FORMATADO.Name = "PC_UNIDADE_FORMATADO";
            this.PC_UNIDADE_FORMATADO.ReadOnly = true;
            // 
            // PC_QTDE_FORMATADO
            // 
            this.PC_QTDE_FORMATADO.DataPropertyName = "PC_QTDE_FORMATADO";
            this.PC_QTDE_FORMATADO.HeaderText = "Qtde";
            this.PC_QTDE_FORMATADO.MaxInputLength = 10;
            this.PC_QTDE_FORMATADO.Name = "PC_QTDE_FORMATADO";
            this.PC_QTDE_FORMATADO.ReadOnly = true;
            // 
            // PC_PRECO_COMPRA_FORMATADO
            // 
            this.PC_PRECO_COMPRA_FORMATADO.DataPropertyName = "PC_PRECO_COMPRA_FORMATADO";
            dataGridViewCellStyle1.NullValue = null;
            this.PC_PRECO_COMPRA_FORMATADO.DefaultCellStyle = dataGridViewCellStyle1;
            this.PC_PRECO_COMPRA_FORMATADO.HeaderText = "Preço";
            this.PC_PRECO_COMPRA_FORMATADO.MaxInputLength = 10;
            this.PC_PRECO_COMPRA_FORMATADO.Name = "PC_PRECO_COMPRA_FORMATADO";
            this.PC_PRECO_COMPRA_FORMATADO.ReadOnly = true;
            // 
            // PC_TOTAL_FORMATADO
            // 
            this.PC_TOTAL_FORMATADO.DataPropertyName = "PC_TOTAL_FORMATADO";
            this.PC_TOTAL_FORMATADO.HeaderText = "Total";
            this.PC_TOTAL_FORMATADO.MaxInputLength = 300;
            this.PC_TOTAL_FORMATADO.Name = "PC_TOTAL_FORMATADO";
            this.PC_TOTAL_FORMATADO.ReadOnly = true;
            // 
            // Frm_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 562);
            this.Controls.Add(this.gb_financeiro);
            this.Controls.Add(this.gb_compra);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Venda";
            this.Text = "Frm_Venda";
            this.Controls.SetChildIndex(this.gb_compra, 0);
            this.Controls.SetChildIndex(this.gb_financeiro, 0);
            this.gb_compra.ResumeLayout(false);
            this.gb_compra.PerformLayout();
            this.gb_movimentação.ResumeLayout(false);
            this.gb_movimentação.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.gb_financeiro.ResumeLayout(false);
            this.gb_financeiro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_compra;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label lbl_out_desp;
        private System.Windows.Forms.TextBox tb_out_desp;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.Label lbl_codigo;
        public System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.MaskedTextBox tb_data;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.TextBox tb_subtotal;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.Label lbl_acresc;
        private System.Windows.Forms.TextBox tb_acresc;
        private System.Windows.Forms.Button btn_produto;
        private System.Windows.Forms.GroupBox gb_financeiro;
        private System.Windows.Forms.RadioButton rb_avista;
        private System.Windows.Forms.RadioButton rb_aprazo;
        private System.Windows.Forms.RadioButton rb_nao_gerar;
        private System.Windows.Forms.GroupBox gb_movimentação;
        private System.Windows.Forms.RadioButton rb_venda;
        private System.Windows.Forms.RadioButton rb_orcamento;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_PRODUTO_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_NOME_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_UNIDADE_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_QTDE_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_PRECO_COMPRA_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_TOTAL_FORMATADO;
    }
}