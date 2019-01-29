namespace UIL
{
    partial class Frm_OS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_geral = new System.Windows.Forms.GroupBox();
            this.print_button = new System.Windows.Forms.Button();
            this.add_carro = new System.Windows.Forms.Button();
            this.add_cliente = new System.Windows.Forms.Button();
            this.tb_remover = new System.Windows.Forms.Button();
            this.tb_adicionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.PRO_CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRECO_VENDA_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.rb_cancelada = new System.Windows.Forms.RadioButton();
            this.rb_aguarda = new System.Windows.Forms.RadioButton();
            this.rb_aprovado = new System.Windows.Forms.RadioButton();
            this.tb_data_entrega = new System.Windows.Forms.MaskedTextBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.tb_data_entrada = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_carro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_visualizaçao = new System.Windows.Forms.GroupBox();
            this.tb_desconto = new System.Windows.Forms.MaskedTextBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_historico = new System.Windows.Forms.DataGridView();
            this.ID_OS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_geral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.gb_status.SuspendLayout();
            this.gb_visualizaçao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_geral
            // 
            this.gb_geral.Controls.Add(this.print_button);
            this.gb_geral.Controls.Add(this.add_carro);
            this.gb_geral.Controls.Add(this.add_cliente);
            this.gb_geral.Controls.Add(this.tb_remover);
            this.gb_geral.Controls.Add(this.tb_adicionar);
            this.gb_geral.Controls.Add(this.label5);
            this.gb_geral.Controls.Add(this.label4);
            this.gb_geral.Controls.Add(this.tb_obs);
            this.gb_geral.Controls.Add(this.dgv_produtos);
            this.gb_geral.Controls.Add(this.gb_status);
            this.gb_geral.Controls.Add(this.tb_data_entrega);
            this.gb_geral.Controls.Add(this.lbl_data);
            this.gb_geral.Controls.Add(this.tb_data_entrada);
            this.gb_geral.Controls.Add(this.label3);
            this.gb_geral.Controls.Add(this.cb_carro);
            this.gb_geral.Controls.Add(this.label2);
            this.gb_geral.Controls.Add(this.cb_cliente);
            this.gb_geral.Controls.Add(this.label1);
            this.gb_geral.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.gb_geral.Location = new System.Drawing.Point(28, 87);
            this.gb_geral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_geral.Name = "gb_geral";
            this.gb_geral.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_geral.Size = new System.Drawing.Size(689, 448);
            this.gb_geral.TabIndex = 13;
            this.gb_geral.TabStop = false;
            this.gb_geral.Text = "Ordem de serviço";
            // 
            // print_button
            // 
            this.print_button.Location = new System.Drawing.Point(546, 332);
            this.print_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(80, 43);
            this.print_button.TabIndex = 13;
            this.print_button.Text = "Imprimir";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // add_carro
            // 
            this.add_carro.BackgroundImage = global::UIL.Properties.Resources.add;
            this.add_carro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_carro.Location = new System.Drawing.Point(646, 37);
            this.add_carro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_carro.Name = "add_carro";
            this.add_carro.Size = new System.Drawing.Size(22, 22);
            this.add_carro.TabIndex = 12;
            this.add_carro.UseVisualStyleBackColor = true;
            this.add_carro.Click += new System.EventHandler(this.add_carro_Click);
            // 
            // add_cliente
            // 
            this.add_cliente.AccessibleDescription = "";
            this.add_cliente.BackgroundImage = global::UIL.Properties.Resources.add;
            this.add_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_cliente.Location = new System.Drawing.Point(316, 37);
            this.add_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_cliente.Name = "add_cliente";
            this.add_cliente.Size = new System.Drawing.Size(22, 22);
            this.add_cliente.TabIndex = 11;
            this.add_cliente.Tag = "";
            this.add_cliente.UseVisualStyleBackColor = true;
            this.add_cliente.Click += new System.EventHandler(this.add_cliente_Click);
            // 
            // tb_remover
            // 
            this.tb_remover.Location = new System.Drawing.Point(546, 284);
            this.tb_remover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_remover.Name = "tb_remover";
            this.tb_remover.Size = new System.Drawing.Size(80, 43);
            this.tb_remover.TabIndex = 10;
            this.tb_remover.Text = "Remover";
            this.tb_remover.UseVisualStyleBackColor = true;
            this.tb_remover.Click += new System.EventHandler(this.tb_remover_Click);
            // 
            // tb_adicionar
            // 
            this.tb_adicionar.Location = new System.Drawing.Point(546, 236);
            this.tb_adicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_adicionar.Name = "tb_adicionar";
            this.tb_adicionar.Size = new System.Drawing.Size(80, 43);
            this.tb_adicionar.TabIndex = 9;
            this.tb_adicionar.Text = "Adicionar";
            this.tb_adicionar.UseVisualStyleBackColor = true;
            this.tb_adicionar.Click += new System.EventHandler(this.tb_adicionar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Descrição de serviço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Produtos:";
            // 
            // tb_obs
            // 
            this.tb_obs.Location = new System.Drawing.Point(12, 126);
            this.tb_obs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(656, 72);
            this.tb_obs.TabIndex = 8;
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRO_CODIGO,
            this.PRO_NOME,
            this.PRO_PRECO_VENDA_FORMATADO,
            this.Qtd,
            this.total});
            this.dgv_produtos.Location = new System.Drawing.Point(12, 236);
            this.dgv_produtos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.RowHeadersVisible = false;
            this.dgv_produtos.RowTemplate.Height = 24;
            this.dgv_produtos.Size = new System.Drawing.Size(508, 203);
            this.dgv_produtos.TabIndex = 5;
            this.dgv_produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produtos_CellClick);
            this.dgv_produtos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produtos_CellDoubleClick);
            this.dgv_produtos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produtos_CellValueChanged);
            this.dgv_produtos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_produtos_RowsAdded);
            this.dgv_produtos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_produtos_RowsRemoved);
            // 
            // PRO_CODIGO
            // 
            this.PRO_CODIGO.DataPropertyName = "PRO_CODIGO";
            this.PRO_CODIGO.HeaderText = "Código";
            this.PRO_CODIGO.Name = "PRO_CODIGO";
            this.PRO_CODIGO.ReadOnly = true;
            this.PRO_CODIGO.Visible = false;
            // 
            // PRO_NOME
            // 
            this.PRO_NOME.DataPropertyName = "PRO_NOME";
            this.PRO_NOME.HeaderText = "Nome";
            this.PRO_NOME.Name = "PRO_NOME";
            this.PRO_NOME.ReadOnly = true;
            this.PRO_NOME.Width = 300;
            // 
            // PRO_PRECO_VENDA_FORMATADO
            // 
            this.PRO_PRECO_VENDA_FORMATADO.DataPropertyName = "PRO_PRECO_VENDA_FORMATADO";
            this.PRO_PRECO_VENDA_FORMATADO.HeaderText = "Valor";
            this.PRO_PRECO_VENDA_FORMATADO.Name = "PRO_PRECO_VENDA_FORMATADO";
            this.PRO_PRECO_VENDA_FORMATADO.ReadOnly = true;
            this.PRO_PRECO_VENDA_FORMATADO.Width = 70;
            // 
            // Qtd
            // 
            this.Qtd.HeaderText = "Qtd";
            this.Qtd.Name = "Qtd";
            this.Qtd.ReadOnly = true;
            this.Qtd.Width = 50;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 70;
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.rb_cancelada);
            this.gb_status.Controls.Add(this.rb_aguarda);
            this.gb_status.Controls.Add(this.rb_aprovado);
            this.gb_status.Location = new System.Drawing.Point(723, 23);
            this.gb_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_status.Name = "gb_status";
            this.gb_status.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_status.Size = new System.Drawing.Size(235, 108);
            this.gb_status.TabIndex = 7;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "Status da OS";
            // 
            // rb_cancelada
            // 
            this.rb_cancelada.AutoSize = true;
            this.rb_cancelada.Location = new System.Drawing.Point(7, 78);
            this.rb_cancelada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_cancelada.Name = "rb_cancelada";
            this.rb_cancelada.Size = new System.Drawing.Size(64, 14);
            this.rb_cancelada.TabIndex = 8;
            this.rb_cancelada.TabStop = true;
            this.rb_cancelada.Text = "Cancelada";
            this.rb_cancelada.UseVisualStyleBackColor = true;
            // 
            // rb_aguarda
            // 
            this.rb_aguarda.AutoSize = true;
            this.rb_aguarda.Location = new System.Drawing.Point(7, 23);
            this.rb_aguarda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_aguarda.Name = "rb_aguarda";
            this.rb_aguarda.Size = new System.Drawing.Size(104, 14);
            this.rb_aguarda.TabIndex = 7;
            this.rb_aguarda.TabStop = true;
            this.rb_aguarda.Text = "Aguarda Aprovação";
            this.rb_aguarda.UseVisualStyleBackColor = true;
            // 
            // rb_aprovado
            // 
            this.rb_aprovado.AutoSize = true;
            this.rb_aprovado.Location = new System.Drawing.Point(7, 50);
            this.rb_aprovado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_aprovado.Name = "rb_aprovado";
            this.rb_aprovado.Size = new System.Drawing.Size(60, 14);
            this.rb_aprovado.TabIndex = 6;
            this.rb_aprovado.TabStop = true;
            this.rb_aprovado.Text = "Aprovado";
            this.rb_aprovado.UseVisualStyleBackColor = true;
            // 
            // tb_data_entrega
            // 
            this.tb_data_entrega.Location = new System.Drawing.Point(554, 78);
            this.tb_data_entrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_data_entrega.Mask = "00/00/0000";
            this.tb_data_entrega.Name = "tb_data_entrega";
            this.tb_data_entrega.Size = new System.Drawing.Size(111, 21);
            this.tb_data_entrega.TabIndex = 4;
            this.tb_data_entrega.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(374, 81);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(116, 13);
            this.lbl_data.TabIndex = 0;
            this.lbl_data.Text = "Data Prev. Entrega";
            // 
            // tb_data_entrada
            // 
            this.tb_data_entrada.Location = new System.Drawing.Point(203, 78);
            this.tb_data_entrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_data_entrada.Mask = "00/00/0000";
            this.tb_data_entrada.Name = "tb_data_entrada";
            this.tb_data_entrada.Size = new System.Drawing.Size(111, 21);
            this.tb_data_entrada.TabIndex = 3;
            this.tb_data_entrada.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data. Entrada:";
            // 
            // cb_carro
            // 
            this.cb_carro.FormattingEnabled = true;
            this.cb_carro.Location = new System.Drawing.Point(407, 37);
            this.cb_carro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(235, 21);
            this.cb_carro.TabIndex = 2;
            this.cb_carro.SelectedIndexChanged += new System.EventHandler(this.cb_carro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Carro:";
            // 
            // cb_cliente
            // 
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Location = new System.Drawing.Point(76, 37);
            this.cb_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(235, 21);
            this.cb_cliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // gb_visualizaçao
            // 
            this.gb_visualizaçao.Controls.Add(this.tb_desconto);
            this.gb_visualizaçao.Controls.Add(this.tb_total);
            this.gb_visualizaçao.Controls.Add(this.tb_valor);
            this.gb_visualizaçao.Controls.Add(this.label8);
            this.gb_visualizaçao.Controls.Add(this.label7);
            this.gb_visualizaçao.Controls.Add(this.label6);
            this.gb_visualizaçao.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.gb_visualizaçao.Location = new System.Drawing.Point(753, 87);
            this.gb_visualizaçao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_visualizaçao.Name = "gb_visualizaçao";
            this.gb_visualizaçao.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_visualizaçao.Size = new System.Drawing.Size(272, 145);
            this.gb_visualizaçao.TabIndex = 0;
            this.gb_visualizaçao.TabStop = false;
            this.gb_visualizaçao.Text = "Visualização";
            // 
            // tb_desconto
            // 
            this.tb_desconto.Location = new System.Drawing.Point(86, 69);
            this.tb_desconto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_desconto.Name = "tb_desconto";
            this.tb_desconto.Size = new System.Drawing.Size(168, 21);
            this.tb_desconto.TabIndex = 2;
            this.tb_desconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_desconto.TextChanged += new System.EventHandler(this.tb_desconto_TextChanged);
            // 
            // tb_total
            // 
            this.tb_total.Enabled = false;
            this.tb_total.Location = new System.Drawing.Point(86, 104);
            this.tb_total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(168, 21);
            this.tb_total.TabIndex = 3;
            this.tb_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_valor
            // 
            this.tb_valor.Enabled = false;
            this.tb_valor.Location = new System.Drawing.Point(86, 33);
            this.tb_valor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(168, 21);
            this.tb_valor.TabIndex = 1;
            this.tb_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Valor Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Desconto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Valor:";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(753, 247);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(133, 37);
            this.btn_salvar.TabIndex = 14;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(892, 247);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(133, 37);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_historico);
            this.groupBox1.Location = new System.Drawing.Point(722, 305);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(346, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histórico";
            // 
            // dgv_historico
            // 
            this.dgv_historico.AllowUserToAddRows = false;
            this.dgv_historico.AllowUserToDeleteRows = false;
            this.dgv_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_OS,
            this.CLIENTE,
            this.PLACA,
            this.data_entrada,
            this.data_entrega});
            this.dgv_historico.Location = new System.Drawing.Point(6, 18);
            this.dgv_historico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_historico.Name = "dgv_historico";
            this.dgv_historico.RowHeadersVisible = false;
            this.dgv_historico.RowTemplate.Height = 24;
            this.dgv_historico.Size = new System.Drawing.Size(334, 210);
            this.dgv_historico.TabIndex = 0;
            this.dgv_historico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_historico_CellDoubleClick);
            // 
            // ID_OS
            // 
            this.ID_OS.DataPropertyName = "HIST_ID_OS";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_OS.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID_OS.HeaderText = "OS";
            this.ID_OS.Name = "ID_OS";
            this.ID_OS.Width = 35;
            // 
            // CLIENTE
            // 
            this.CLIENTE.DataPropertyName = "NOME_CLIENTE";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLIENTE.DefaultCellStyle = dataGridViewCellStyle2;
            this.CLIENTE.HeaderText = "Cliente";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Width = 180;
            // 
            // PLACA
            // 
            this.PLACA.DataPropertyName = "HIST_PLACA";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLACA.DefaultCellStyle = dataGridViewCellStyle3;
            this.PLACA.HeaderText = "Placa";
            this.PLACA.Name = "PLACA";
            this.PLACA.Visible = false;
            this.PLACA.Width = 80;
            // 
            // data_entrada
            // 
            this.data_entrada.DataPropertyName = "DATA_ENTRADA";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_entrada.DefaultCellStyle = dataGridViewCellStyle4;
            this.data_entrada.HeaderText = "Entrada";
            this.data_entrada.Name = "data_entrada";
            this.data_entrada.Width = 55;
            // 
            // data_entrega
            // 
            this.data_entrega.DataPropertyName = "DATA_ENTREGA";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_entrega.DefaultCellStyle = dataGridViewCellStyle5;
            this.data_entrega.HeaderText = "Entrega";
            this.data_entrega.Name = "data_entrega";
            this.data_entrega.Width = 55;
            // 
            // Frm_OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.gb_visualizaçao);
            this.Controls.Add(this.gb_geral);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_OS";
            this.Controls.SetChildIndex(this.gb_geral, 0);
            this.Controls.SetChildIndex(this.gb_visualizaçao, 0);
            this.Controls.SetChildIndex(this.btn_salvar, 0);
            this.Controls.SetChildIndex(this.btn_cancelar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.gb_geral.ResumeLayout(false);
            this.gb_geral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            this.gb_visualizaçao.ResumeLayout(false);
            this.gb_visualizaçao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_geral;
        private System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_carro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tb_data_entrega;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.MaskedTextBox tb_data_entrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.RadioButton rb_aguarda;
        private System.Windows.Forms.RadioButton rb_aprovado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb_visualizaçao;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_cancelada;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_historico;
        private System.Windows.Forms.MaskedTextBox tb_desconto;
        private System.Windows.Forms.Button tb_remover;
        private System.Windows.Forms.Button tb_adicionar;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.Button add_cliente;
        private System.Windows.Forms.Button add_carro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_OS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRECO_VENDA_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button print_button;
    }
}
