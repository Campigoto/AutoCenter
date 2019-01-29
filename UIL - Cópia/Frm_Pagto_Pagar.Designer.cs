namespace UIL
{
    partial class Frm_Pagto_Pagar
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
            this.gb_proc_contas_pagar = new System.Windows.Forms.GroupBox();
            this.dvg_parcelas = new System.Windows.Forms.DataGridView();
            this.cb_fornecedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_final = new System.Windows.Forms.Label();
            this.tb_final = new System.Windows.Forms.MaskedTextBox();
            this.tb_inicio = new System.Windows.Forms.MaskedTextBox();
            this.lbl_igual = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_linha = new System.Windows.Forms.Label();
            this.PCA_CARNE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_TIPO_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_NUM_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOR_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_VALOR_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_ACRESCIMO_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_DESCONTO_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_TOTAL_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_VENC_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_VALOR_PAGO_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_DATA_PAGTO_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_OBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_proc_contas_pagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_parcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_proc_contas_pagar
            // 
            this.gb_proc_contas_pagar.Controls.Add(this.dvg_parcelas);
            this.gb_proc_contas_pagar.Controls.Add(this.cb_fornecedor);
            this.gb_proc_contas_pagar.Controls.Add(this.label1);
            this.gb_proc_contas_pagar.Controls.Add(this.lbl_final);
            this.gb_proc_contas_pagar.Controls.Add(this.tb_final);
            this.gb_proc_contas_pagar.Controls.Add(this.tb_inicio);
            this.gb_proc_contas_pagar.Controls.Add(this.lbl_igual);
            this.gb_proc_contas_pagar.Controls.Add(this.cb_tipo);
            this.gb_proc_contas_pagar.Controls.Add(this.label12);
            this.gb_proc_contas_pagar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_proc_contas_pagar.Location = new System.Drawing.Point(34, 91);
            this.gb_proc_contas_pagar.Name = "gb_proc_contas_pagar";
            this.gb_proc_contas_pagar.Size = new System.Drawing.Size(1000, 447);
            this.gb_proc_contas_pagar.TabIndex = 82;
            this.gb_proc_contas_pagar.TabStop = false;
            this.gb_proc_contas_pagar.Text = "Pagamento:";
            // 
            // dvg_parcelas
            // 
            this.dvg_parcelas.AllowUserToAddRows = false;
            this.dvg_parcelas.AllowUserToDeleteRows = false;
            this.dvg_parcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_parcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PCA_CARNE,
            this.PCA_ITEM,
            this.PCA_TIPO_NOME,
            this.PCA_NUM_DOC,
            this.FOR_NOME,
            this.PCA_VALOR_FORMATADO,
            this.PCA_ACRESCIMO_FORMATADO,
            this.PCA_DESCONTO_FORMATADO,
            this.PCA_TOTAL_FORMATADO,
            this.PCA_VENC_FORMATADO,
            this.PCA_VALOR_PAGO_FORMATADO,
            this.PCA_DATA_PAGTO_FORMATADO,
            this.PCA_OBS});
            this.dvg_parcelas.Location = new System.Drawing.Point(26, 81);
            this.dvg_parcelas.Name = "dvg_parcelas";
            this.dvg_parcelas.RowHeadersVisible = false;
            this.dvg_parcelas.Size = new System.Drawing.Size(920, 348);
            this.dvg_parcelas.TabIndex = 5;
            this.dvg_parcelas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_parcelas_CellClick);
            // 
            // cb_fornecedor
            // 
            this.cb_fornecedor.DisplayMember = "FOR_NOME";
            this.cb_fornecedor.FormattingEnabled = true;
            this.cb_fornecedor.Location = new System.Drawing.Point(406, 41);
            this.cb_fornecedor.Name = "cb_fornecedor";
            this.cb_fornecedor.Size = new System.Drawing.Size(369, 21);
            this.cb_fornecedor.TabIndex = 4;
            this.cb_fornecedor.ValueMember = "FOR_CODIGO";
            this.cb_fornecedor.SelectedIndexChanged += new System.EventHandler(this.cb_fornecedor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Fornecedor:";
            // 
            // lbl_final
            // 
            this.lbl_final.AutoSize = true;
            this.lbl_final.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_final.Location = new System.Drawing.Point(276, 25);
            this.lbl_final.Name = "lbl_final";
            this.lbl_final.Size = new System.Drawing.Size(38, 13);
            this.lbl_final.TabIndex = 88;
            this.lbl_final.Text = "Final:";
            // 
            // tb_final
            // 
            this.tb_final.Location = new System.Drawing.Point(279, 41);
            this.tb_final.Mask = "00/00/0000";
            this.tb_final.Name = "tb_final";
            this.tb_final.Size = new System.Drawing.Size(110, 21);
            this.tb_final.TabIndex = 3;
            this.tb_final.ValidatingType = typeof(System.DateTime);
            this.tb_final.Leave += new System.EventHandler(this.tb_final_Leave);
            // 
            // tb_inicio
            // 
            this.tb_inicio.Location = new System.Drawing.Point(152, 41);
            this.tb_inicio.Mask = "00/00/0000";
            this.tb_inicio.Name = "tb_inicio";
            this.tb_inicio.Size = new System.Drawing.Size(110, 21);
            this.tb_inicio.TabIndex = 2;
            this.tb_inicio.ValidatingType = typeof(System.DateTime);
            this.tb_inicio.Leave += new System.EventHandler(this.tb_inicio_Leave);
            // 
            // lbl_igual
            // 
            this.lbl_igual.AutoSize = true;
            this.lbl_igual.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_igual.Location = new System.Drawing.Point(149, 25);
            this.lbl_igual.Name = "lbl_igual";
            this.lbl_igual.Size = new System.Drawing.Size(43, 13);
            this.lbl_igual.TabIndex = 87;
            this.lbl_igual.Text = "Início:";
            // 
            // cb_tipo
            // 
            this.cb_tipo.DisplayMember = "1";
            this.cb_tipo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Pagas",
            "Não Pagas"});
            this.cb_tipo.Location = new System.Drawing.Point(24, 41);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(112, 21);
            this.cb_tipo.TabIndex = 1;
            this.cb_tipo.SelectedIndexChanged += new System.EventHandler(this.cb_tipo_SelectedIndexChanged);
            this.cb_tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Tipo:";
            // 
            // lbl_linha
            // 
            this.lbl_linha.AutoSize = true;
            this.lbl_linha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_linha.Location = new System.Drawing.Point(9, 525);
            this.lbl_linha.Name = "lbl_linha";
            this.lbl_linha.Size = new System.Drawing.Size(19, 13);
            this.lbl_linha.TabIndex = 83;
            this.lbl_linha.Text = "-1";
            this.lbl_linha.Visible = false;
            // 
            // PCA_CARNE
            // 
            this.PCA_CARNE.DataPropertyName = "PCA_CARNE";
            this.PCA_CARNE.HeaderText = "Carnê";
            this.PCA_CARNE.Name = "PCA_CARNE";
            this.PCA_CARNE.Width = 80;
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
            // PCA_TIPO_NOME
            // 
            this.PCA_TIPO_NOME.DataPropertyName = "PCA_TIPO_NOME";
            this.PCA_TIPO_NOME.HeaderText = "Tipo";
            this.PCA_TIPO_NOME.Name = "PCA_TIPO_NOME";
            // 
            // PCA_NUM_DOC
            // 
            this.PCA_NUM_DOC.DataPropertyName = "PCA_NUM_DOC";
            this.PCA_NUM_DOC.HeaderText = "Num. Doc.";
            this.PCA_NUM_DOC.MaxInputLength = 50;
            this.PCA_NUM_DOC.Name = "PCA_NUM_DOC";
            // 
            // FOR_NOME
            // 
            this.FOR_NOME.DataPropertyName = "FOR_NOME";
            this.FOR_NOME.HeaderText = "Fornecedor";
            this.FOR_NOME.Name = "FOR_NOME";
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
            this.PCA_ACRESCIMO_FORMATADO.Name = "PCA_ACRESCIMO_FORMATADO";
            // 
            // PCA_DESCONTO_FORMATADO
            // 
            this.PCA_DESCONTO_FORMATADO.DataPropertyName = "PCA_DESCONTO_FORMATADO";
            this.PCA_DESCONTO_FORMATADO.HeaderText = "Desc.";
            this.PCA_DESCONTO_FORMATADO.Name = "PCA_DESCONTO_FORMATADO";
            // 
            // PCA_TOTAL_FORMATADO
            // 
            this.PCA_TOTAL_FORMATADO.DataPropertyName = "PCA_TOTAL_FORMATADO";
            this.PCA_TOTAL_FORMATADO.HeaderText = "Total";
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
            // Frm_Pagto_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.lbl_linha);
            this.Controls.Add(this.gb_proc_contas_pagar);
            this.Name = "Frm_Pagto_Pagar";
            this.Text = "Frm_Pagto_Pagar";
            this.Controls.SetChildIndex(this.gb_proc_contas_pagar, 0);
            this.Controls.SetChildIndex(this.lbl_linha, 0);
            this.gb_proc_contas_pagar.ResumeLayout(false);
            this.gb_proc_contas_pagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_parcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_proc_contas_pagar;
        private System.Windows.Forms.Label lbl_final;
        private System.Windows.Forms.MaskedTextBox tb_final;
        private System.Windows.Forms.MaskedTextBox tb_inicio;
        private System.Windows.Forms.Label lbl_igual;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_fornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvg_parcelas;
        private System.Windows.Forms.Label lbl_linha;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_CARNE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_TIPO_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_NUM_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOR_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_VALOR_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_ACRESCIMO_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_DESCONTO_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_TOTAL_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_VENC_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_VALOR_PAGO_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_DATA_PAGTO_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_OBS;
    }
}