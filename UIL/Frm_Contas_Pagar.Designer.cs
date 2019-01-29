namespace UIL
{
    partial class Frm_Contas_Pagar
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
            this.gb_contas_pagar = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_valor_geral = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_desc_geral = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_acresc_geral = new System.Windows.Forms.TextBox();
            this.lbl_total_pago = new System.Windows.Forms.Label();
            this.tb_total_pago = new System.Windows.Forms.TextBox();
            this.lbl_total_geral = new System.Windows.Forms.Label();
            this.tb_total_geral = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_lancamento = new System.Windows.Forms.ComboBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_cheque = new System.Windows.Forms.Button();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dgv_parcelas = new System.Windows.Forms.DataGridView();
            this.PCA_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PCA_NUM_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_VALOR_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_ACRESCIMO_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_DESCONTO_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_TOTAL_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_VENC_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_VALOR_PAGO_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_DATA_PAGTO_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_OBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_compra = new System.Windows.Forms.TextBox();
            this.cb_fornecedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.lbl_compra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.lbl_linha = new System.Windows.Forms.Label();
            this.gb_contas_pagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_contas_pagar
            // 
            this.gb_contas_pagar.Controls.Add(this.label6);
            this.gb_contas_pagar.Controls.Add(this.tb_valor_geral);
            this.gb_contas_pagar.Controls.Add(this.label4);
            this.gb_contas_pagar.Controls.Add(this.tb_desc_geral);
            this.gb_contas_pagar.Controls.Add(this.label5);
            this.gb_contas_pagar.Controls.Add(this.tb_acresc_geral);
            this.gb_contas_pagar.Controls.Add(this.lbl_total_pago);
            this.gb_contas_pagar.Controls.Add(this.tb_total_pago);
            this.gb_contas_pagar.Controls.Add(this.lbl_total_geral);
            this.gb_contas_pagar.Controls.Add(this.tb_total_geral);
            this.gb_contas_pagar.Controls.Add(this.label2);
            this.gb_contas_pagar.Controls.Add(this.cb_lancamento);
            this.gb_contas_pagar.Controls.Add(this.btn_pesquisar);
            this.gb_contas_pagar.Controls.Add(this.btn_cheque);
            this.gb_contas_pagar.Controls.Add(this.btn_gerar);
            this.gb_contas_pagar.Controls.Add(this.btn_excluir);
            this.gb_contas_pagar.Controls.Add(this.dgv_parcelas);
            this.gb_contas_pagar.Controls.Add(this.tb_compra);
            this.gb_contas_pagar.Controls.Add(this.cb_fornecedor);
            this.gb_contas_pagar.Controls.Add(this.label3);
            this.gb_contas_pagar.Controls.Add(this.tb_codigo);
            this.gb_contas_pagar.Controls.Add(this.lbl_compra);
            this.gb_contas_pagar.Controls.Add(this.label1);
            this.gb_contas_pagar.Controls.Add(this.btn_limpar);
            this.gb_contas_pagar.Controls.Add(this.btn_gravar);
            this.gb_contas_pagar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_contas_pagar.Location = new System.Drawing.Point(34, 88);
            this.gb_contas_pagar.Name = "gb_contas_pagar";
            this.gb_contas_pagar.Size = new System.Drawing.Size(1000, 462);
            this.gb_contas_pagar.TabIndex = 24;
            this.gb_contas_pagar.TabStop = false;
            this.gb_contas_pagar.Text = "Cadastro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(878, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Valor:";
            // 
            // tb_valor_geral
            // 
            this.tb_valor_geral.Enabled = false;
            this.tb_valor_geral.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_geral.Location = new System.Drawing.Point(881, 122);
            this.tb_valor_geral.MaxLength = 10;
            this.tb_valor_geral.Name = "tb_valor_geral";
            this.tb_valor_geral.Size = new System.Drawing.Size(100, 21);
            this.tb_valor_geral.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(878, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Desconto:";
            // 
            // tb_desc_geral
            // 
            this.tb_desc_geral.Enabled = false;
            this.tb_desc_geral.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_desc_geral.Location = new System.Drawing.Point(881, 227);
            this.tb_desc_geral.MaxLength = 10;
            this.tb_desc_geral.Name = "tb_desc_geral";
            this.tb_desc_geral.Size = new System.Drawing.Size(100, 21);
            this.tb_desc_geral.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(878, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Acréscimo:";
            // 
            // tb_acresc_geral
            // 
            this.tb_acresc_geral.Enabled = false;
            this.tb_acresc_geral.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_acresc_geral.Location = new System.Drawing.Point(881, 175);
            this.tb_acresc_geral.MaxLength = 10;
            this.tb_acresc_geral.Name = "tb_acresc_geral";
            this.tb_acresc_geral.Size = new System.Drawing.Size(100, 21);
            this.tb_acresc_geral.TabIndex = 67;
            // 
            // lbl_total_pago
            // 
            this.lbl_total_pago.AutoSize = true;
            this.lbl_total_pago.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_pago.Location = new System.Drawing.Point(881, 322);
            this.lbl_total_pago.Name = "lbl_total_pago";
            this.lbl_total_pago.Size = new System.Drawing.Size(74, 13);
            this.lbl_total_pago.TabIndex = 66;
            this.lbl_total_pago.Text = "Valor Pago:";
            // 
            // tb_total_pago
            // 
            this.tb_total_pago.Enabled = false;
            this.tb_total_pago.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_pago.Location = new System.Drawing.Point(884, 338);
            this.tb_total_pago.MaxLength = 10;
            this.tb_total_pago.Name = "tb_total_pago";
            this.tb_total_pago.Size = new System.Drawing.Size(100, 21);
            this.tb_total_pago.TabIndex = 64;
            // 
            // lbl_total_geral
            // 
            this.lbl_total_geral.AutoSize = true;
            this.lbl_total_geral.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_geral.Location = new System.Drawing.Point(881, 268);
            this.lbl_total_geral.Name = "lbl_total_geral";
            this.lbl_total_geral.Size = new System.Drawing.Size(40, 13);
            this.lbl_total_geral.TabIndex = 65;
            this.lbl_total_geral.Text = "Total:";
            // 
            // tb_total_geral
            // 
            this.tb_total_geral.Enabled = false;
            this.tb_total_geral.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total_geral.Location = new System.Drawing.Point(884, 284);
            this.tb_total_geral.MaxLength = 10;
            this.tb_total_geral.Name = "tb_total_geral";
            this.tb_total_geral.Size = new System.Drawing.Size(100, 21);
            this.tb_total_geral.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Lançamento:";
            // 
            // cb_lancamento
            // 
            this.cb_lancamento.DisplayMember = "HIS_DESCRICAO";
            this.cb_lancamento.FormattingEnabled = true;
            this.cb_lancamento.Location = new System.Drawing.Point(670, 45);
            this.cb_lancamento.Name = "cb_lancamento";
            this.cb_lancamento.Size = new System.Drawing.Size(209, 21);
            this.cb_lancamento.TabIndex = 4;
            this.cb_lancamento.ValueMember = "HIS_ID";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(281, 421);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(100, 30);
            this.btn_pesquisar.TabIndex = 8;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_cheque
            // 
            this.btn_cheque.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cheque.Location = new System.Drawing.Point(531, 421);
            this.btn_cheque.Name = "btn_cheque";
            this.btn_cheque.Size = new System.Drawing.Size(100, 30);
            this.btn_cheque.TabIndex = 10;
            this.btn_cheque.Text = "Cheque";
            this.btn_cheque.UseVisualStyleBackColor = true;
            this.btn_cheque.Click += new System.EventHandler(this.btn_cheque_Click);
            // 
            // btn_gerar
            // 
            this.btn_gerar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerar.Location = new System.Drawing.Point(385, 421);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(140, 30);
            this.btn_gerar.TabIndex = 9;
            this.btn_gerar.Text = "Gerar Parcelas";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Location = new System.Drawing.Point(850, 421);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(100, 30);
            this.btn_excluir.TabIndex = 13;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // dgv_parcelas
            // 
            this.dgv_parcelas.AllowUserToAddRows = false;
            this.dgv_parcelas.AllowUserToDeleteRows = false;
            this.dgv_parcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_parcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PCA_ITEM,
            this.Tipo,
            this.PCA_NUM_DOC,
            this.PCA_VALOR_FORMATADO,
            this.PCA_ACRESCIMO_FORMATADO,
            this.PCA_DESCONTO_FORMATADO,
            this.PCA_TOTAL_FORMATADO,
            this.PCA_VENC_FORMATADO,
            this.PCA_VALOR_PAGO_FORMATADO,
            this.PCA_DATA_PAGTO_FORMATADO,
            this.PCA_OBS});
            this.dgv_parcelas.Location = new System.Drawing.Point(35, 84);
            this.dgv_parcelas.Name = "dgv_parcelas";
            this.dgv_parcelas.RowHeadersVisible = false;
            this.dgv_parcelas.Size = new System.Drawing.Size(832, 319);
            this.dgv_parcelas.TabIndex = 5;
            this.dgv_parcelas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_parcelas_CellClick);
            this.dgv_parcelas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_parcelas_CellEndEdit);
            this.dgv_parcelas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_parcelas_EditingControlShowing);
            this.dgv_parcelas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_parcelas_KeyDown);
            // 
            // PCA_ITEM
            // 
            this.PCA_ITEM.DataPropertyName = "PCA_ITEM";
            this.PCA_ITEM.HeaderText = "Item";
            this.PCA_ITEM.MaxInputLength = 10;
            this.PCA_ITEM.Name = "PCA_ITEM";
            this.PCA_ITEM.ReadOnly = true;
            this.PCA_ITEM.Width = 50;
            // 
            // Tipo
            // 
            this.Tipo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // PCA_NUM_DOC
            // 
            this.PCA_NUM_DOC.DataPropertyName = "PCA_NUM_DOC";
            this.PCA_NUM_DOC.HeaderText = "Num. Doc.";
            this.PCA_NUM_DOC.MaxInputLength = 50;
            this.PCA_NUM_DOC.Name = "PCA_NUM_DOC";
            // 
            // PCA_VALOR_FORMATADO
            // 
            this.PCA_VALOR_FORMATADO.DataPropertyName = "PCA_VALOR_FORMATADO";
            this.PCA_VALOR_FORMATADO.HeaderText = "Valor";
            this.PCA_VALOR_FORMATADO.MaxInputLength = 10;
            this.PCA_VALOR_FORMATADO.Name = "PCA_VALOR_FORMATADO";
            // 
            // PCA_ACRESCIMO_FORMATADO
            // 
            this.PCA_ACRESCIMO_FORMATADO.DataPropertyName = "PCA_ACRESCIMO_FORMATADO";
            this.PCA_ACRESCIMO_FORMATADO.HeaderText = "Acrésc.";
            this.PCA_ACRESCIMO_FORMATADO.MaxInputLength = 10;
            this.PCA_ACRESCIMO_FORMATADO.Name = "PCA_ACRESCIMO_FORMATADO";
            // 
            // PCA_DESCONTO_FORMATADO
            // 
            this.PCA_DESCONTO_FORMATADO.DataPropertyName = "PCA_DESCONTO_FORMATADO";
            this.PCA_DESCONTO_FORMATADO.HeaderText = "Desc.";
            this.PCA_DESCONTO_FORMATADO.MaxInputLength = 10;
            this.PCA_DESCONTO_FORMATADO.Name = "PCA_DESCONTO_FORMATADO";
            // 
            // PCA_TOTAL_FORMATADO
            // 
            this.PCA_TOTAL_FORMATADO.DataPropertyName = "PCA_TOTAL_FORMATADO";
            this.PCA_TOTAL_FORMATADO.HeaderText = "Total";
            this.PCA_TOTAL_FORMATADO.MaxInputLength = 10;
            this.PCA_TOTAL_FORMATADO.Name = "PCA_TOTAL_FORMATADO";
            // 
            // PCA_VENC_FORMATADO
            // 
            this.PCA_VENC_FORMATADO.DataPropertyName = "PCA_VENC_FORMATADO";
            this.PCA_VENC_FORMATADO.HeaderText = "Vencimento";
            this.PCA_VENC_FORMATADO.MaxInputLength = 10;
            this.PCA_VENC_FORMATADO.Name = "PCA_VENC_FORMATADO";
            // 
            // PCA_VALOR_PAGO_FORMATADO
            // 
            this.PCA_VALOR_PAGO_FORMATADO.DataPropertyName = "PCA_VALOR_PAGO_FORMATADO";
            this.PCA_VALOR_PAGO_FORMATADO.HeaderText = "Valor Pago";
            this.PCA_VALOR_PAGO_FORMATADO.MaxInputLength = 10;
            this.PCA_VALOR_PAGO_FORMATADO.Name = "PCA_VALOR_PAGO_FORMATADO";
            this.PCA_VALOR_PAGO_FORMATADO.ReadOnly = true;
            // 
            // PCA_DATA_PAGTO_FORMATADO
            // 
            this.PCA_DATA_PAGTO_FORMATADO.DataPropertyName = "PCA_DATA_PAGTO_FORMATADO";
            this.PCA_DATA_PAGTO_FORMATADO.HeaderText = "Pagamento";
            this.PCA_DATA_PAGTO_FORMATADO.MaxInputLength = 10;
            this.PCA_DATA_PAGTO_FORMATADO.Name = "PCA_DATA_PAGTO_FORMATADO";
            this.PCA_DATA_PAGTO_FORMATADO.ReadOnly = true;
            // 
            // PCA_OBS
            // 
            this.PCA_OBS.DataPropertyName = "PCA_OBS";
            this.PCA_OBS.HeaderText = "Observação";
            this.PCA_OBS.MaxInputLength = 300;
            this.PCA_OBS.Name = "PCA_OBS";
            this.PCA_OBS.Width = 200;
            // 
            // tb_compra
            // 
            this.tb_compra.Enabled = false;
            this.tb_compra.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_compra.Location = new System.Drawing.Point(547, 45);
            this.tb_compra.MaxLength = 10;
            this.tb_compra.Name = "tb_compra";
            this.tb_compra.Size = new System.Drawing.Size(100, 21);
            this.tb_compra.TabIndex = 3;
            // 
            // cb_fornecedor
            // 
            this.cb_fornecedor.DisplayMember = "FOR_NOME";
            this.cb_fornecedor.FormattingEnabled = true;
            this.cb_fornecedor.Location = new System.Drawing.Point(157, 45);
            this.cb_fornecedor.Name = "cb_fornecedor";
            this.cb_fornecedor.Size = new System.Drawing.Size(369, 21);
            this.cb_fornecedor.TabIndex = 2;
            this.cb_fornecedor.ValueMember = "FOR_CODIGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Código:";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(36, 45);
            this.tb_codigo.MaxLength = 10;
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(100, 21);
            this.tb_codigo.TabIndex = 1;
            this.tb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            this.tb_codigo.Leave += new System.EventHandler(this.tb_codigo_Leave);
            // 
            // lbl_compra
            // 
            this.lbl_compra.AutoSize = true;
            this.lbl_compra.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_compra.Location = new System.Drawing.Point(544, 29);
            this.lbl_compra.Name = "lbl_compra";
            this.lbl_compra.Size = new System.Drawing.Size(58, 13);
            this.lbl_compra.TabIndex = 24;
            this.lbl_compra.Text = "Compra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fornecedor:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(744, 421);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(100, 30);
            this.btn_limpar.TabIndex = 12;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravar.Location = new System.Drawing.Point(638, 421);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(100, 30);
            this.btn_gravar.TabIndex = 11;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // lbl_linha
            // 
            this.lbl_linha.AutoSize = true;
            this.lbl_linha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_linha.Location = new System.Drawing.Point(12, 537);
            this.lbl_linha.Name = "lbl_linha";
            this.lbl_linha.Size = new System.Drawing.Size(19, 13);
            this.lbl_linha.TabIndex = 36;
            this.lbl_linha.Text = "-1";
            this.lbl_linha.Visible = false;
            // 
            // Frm_Contas_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.lbl_linha);
            this.Controls.Add(this.gb_contas_pagar);
            this.Name = "Frm_Contas_Pagar";
            this.Controls.SetChildIndex(this.gb_contas_pagar, 0);
            this.Controls.SetChildIndex(this.lbl_linha, 0);
            this.gb_contas_pagar.ResumeLayout(false);
            this.gb_contas_pagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_contas_pagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Label lbl_compra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.ComboBox cb_fornecedor;
        private System.Windows.Forms.TextBox tb_compra;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView dgv_parcelas;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.Label lbl_linha;
        public System.Windows.Forms.Button btn_cheque;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_lancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_ITEM;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_NUM_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_VALOR_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_ACRESCIMO_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_DESCONTO_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_TOTAL_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_VENC_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_VALOR_PAGO_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_DATA_PAGTO_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_OBS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_desc_geral;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_acresc_geral;
        private System.Windows.Forms.Label lbl_total_pago;
        private System.Windows.Forms.TextBox tb_total_pago;
        private System.Windows.Forms.Label lbl_total_geral;
        private System.Windows.Forms.TextBox tb_total_geral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_valor_geral;
    }
}