namespace UIL
{
    partial class Frm_Atualizar_Estoque
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
            this.gb_estoque = new System.Windows.Forms.GroupBox();
            this.tb_estoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.tb_qtde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_produto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.lbl_igual = new System.Windows.Forms.Label();
            this.dgv_historico = new System.Windows.Forms.DataGridView();
            this.HEP_CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEP_COMPRA_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEP_DATA_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEP_HORA_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUN_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEP_TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEP_QTDE_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEP_ESTOQUE_ANTERIOR_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEP_ESTOQUE_ATUAL_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEP_PRECO_UNITARIO_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEP_PRECO_TOTAL_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_estoque
            // 
            this.gb_estoque.Controls.Add(this.tb_estoque);
            this.gb_estoque.Controls.Add(this.label3);
            this.gb_estoque.Controls.Add(this.btn_pesquisar);
            this.gb_estoque.Controls.Add(this.btn_confirmar);
            this.gb_estoque.Controls.Add(this.tb_qtde);
            this.gb_estoque.Controls.Add(this.label2);
            this.gb_estoque.Controls.Add(this.tb_produto);
            this.gb_estoque.Controls.Add(this.label1);
            this.gb_estoque.Controls.Add(this.cb_tipo);
            this.gb_estoque.Controls.Add(this.label12);
            this.gb_estoque.Controls.Add(this.tb_codigo);
            this.gb_estoque.Controls.Add(this.lbl_igual);
            this.gb_estoque.Controls.Add(this.dgv_historico);
            this.gb_estoque.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_estoque.Location = new System.Drawing.Point(30, 90);
            this.gb_estoque.Name = "gb_estoque";
            this.gb_estoque.Size = new System.Drawing.Size(1017, 460);
            this.gb_estoque.TabIndex = 19;
            this.gb_estoque.TabStop = false;
            this.gb_estoque.Text = "Pesquisa:";
            // 
            // tb_estoque
            // 
            this.tb_estoque.Enabled = false;
            this.tb_estoque.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_estoque.Location = new System.Drawing.Point(385, 48);
            this.tb_estoque.MaxLength = 60;
            this.tb_estoque.Name = "tb_estoque";
            this.tb_estoque.Size = new System.Drawing.Size(110, 21);
            this.tb_estoque.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Estoque:";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(506, 39);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(100, 30);
            this.btn_pesquisar.TabIndex = 85;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.Location = new System.Drawing.Point(876, 39);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(100, 30);
            this.btn_confirmar.TabIndex = 84;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // tb_qtde
            // 
            this.tb_qtde.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qtde.Location = new System.Drawing.Point(620, 48);
            this.tb_qtde.MaxLength = 60;
            this.tb_qtde.Name = "tb_qtde";
            this.tb_qtde.Size = new System.Drawing.Size(80, 21);
            this.tb_qtde.TabIndex = 80;
            this.tb_qtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valor_KeyPress);
            this.tb_qtde.Leave += new System.EventHandler(this.Valor_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(617, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Qtde:";
            // 
            // tb_produto
            // 
            this.tb_produto.Enabled = false;
            this.tb_produto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_produto.Location = new System.Drawing.Point(79, 48);
            this.tb_produto.MaxLength = 60;
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(300, 21);
            this.tb_produto.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Produto:";
            // 
            // cb_tipo
            // 
            this.cb_tipo.DisplayMember = "1";
            this.cb_tipo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Saída",
            "Entrada"});
            this.cb_tipo.Location = new System.Drawing.Point(706, 48);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(160, 21);
            this.cb_tipo.TabIndex = 1;
            this.cb_tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(703, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 77;
            this.label12.Text = "Tipo:";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Enabled = false;
            this.tb_codigo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(13, 48);
            this.tb_codigo.MaxLength = 60;
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(60, 21);
            this.tb_codigo.TabIndex = 2;
            // 
            // lbl_igual
            // 
            this.lbl_igual.AutoSize = true;
            this.lbl_igual.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_igual.Location = new System.Drawing.Point(10, 32);
            this.lbl_igual.Name = "lbl_igual";
            this.lbl_igual.Size = new System.Drawing.Size(52, 13);
            this.lbl_igual.TabIndex = 37;
            this.lbl_igual.Text = "Código:";
            // 
            // dgv_historico
            // 
            this.dgv_historico.AllowUserToAddRows = false;
            this.dgv_historico.AllowUserToDeleteRows = false;
            this.dgv_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HEP_CODIGO,
            this.HEP_COMPRA_FORMATADO,
            this.HEP_DATA_FORMATADO,
            this.HEP_HORA_FORMATADO,
            this.FUN_NOME,
            this.HEP_TIPO,
            this.HEP_QTDE_FORMATADO,
            this.HEP_ESTOQUE_ANTERIOR_FORMATADO,
            this.HEP_ESTOQUE_ATUAL_FORMATADO,
            this.HEP_PRECO_UNITARIO_FORMATADO,
            this.HEP_PRECO_TOTAL_FORMATADO});
            this.dgv_historico.Location = new System.Drawing.Point(13, 90);
            this.dgv_historico.Name = "dgv_historico";
            this.dgv_historico.RowHeadersVisible = false;
            this.dgv_historico.Size = new System.Drawing.Size(990, 351);
            this.dgv_historico.TabIndex = 4;
            // 
            // HEP_CODIGO
            // 
            this.HEP_CODIGO.DataPropertyName = "HEP_CODIGO";
            this.HEP_CODIGO.HeaderText = "Código";
            this.HEP_CODIGO.Name = "HEP_CODIGO";
            this.HEP_CODIGO.Width = 70;
            // 
            // HEP_COMPRA_FORMATADO
            // 
            this.HEP_COMPRA_FORMATADO.DataPropertyName = "HEP_COMPRA_FORMATADO";
            this.HEP_COMPRA_FORMATADO.HeaderText = "Compra";
            this.HEP_COMPRA_FORMATADO.Name = "HEP_COMPRA_FORMATADO";
            this.HEP_COMPRA_FORMATADO.Width = 70;
            // 
            // HEP_DATA_FORMATADO
            // 
            this.HEP_DATA_FORMATADO.DataPropertyName = "HEP_DATA_FORMATADO";
            this.HEP_DATA_FORMATADO.HeaderText = "Data";
            this.HEP_DATA_FORMATADO.Name = "HEP_DATA_FORMATADO";
            this.HEP_DATA_FORMATADO.Width = 120;
            // 
            // HEP_HORA_FORMATADO
            // 
            this.HEP_HORA_FORMATADO.DataPropertyName = "HEP_HORA_FORMATADO";
            this.HEP_HORA_FORMATADO.HeaderText = "Hora";
            this.HEP_HORA_FORMATADO.Name = "HEP_HORA_FORMATADO";
            this.HEP_HORA_FORMATADO.Width = 70;
            // 
            // FUN_NOME
            // 
            this.FUN_NOME.DataPropertyName = "FUN_NOME";
            this.FUN_NOME.HeaderText = "Funcionário";
            this.FUN_NOME.Name = "FUN_NOME";
            this.FUN_NOME.Width = 200;
            // 
            // HEP_TIPO
            // 
            this.HEP_TIPO.DataPropertyName = "HEP_TIPO";
            this.HEP_TIPO.HeaderText = "Tipo";
            this.HEP_TIPO.Name = "HEP_TIPO";
            // 
            // HEP_QTDE_FORMATADO
            // 
            this.HEP_QTDE_FORMATADO.DataPropertyName = "HEP_QTDE_FORMATADO";
            this.HEP_QTDE_FORMATADO.HeaderText = "Qtde";
            this.HEP_QTDE_FORMATADO.Name = "HEP_QTDE_FORMATADO";
            // 
            // HEP_ESTOQUE_ANTERIOR_FORMATADO
            // 
            this.HEP_ESTOQUE_ANTERIOR_FORMATADO.DataPropertyName = "HEP_ESTOQUE_ANTERIOR_FORMATADO";
            this.HEP_ESTOQUE_ANTERIOR_FORMATADO.HeaderText = "Est. Anterior";
            this.HEP_ESTOQUE_ANTERIOR_FORMATADO.Name = "HEP_ESTOQUE_ANTERIOR_FORMATADO";
            this.HEP_ESTOQUE_ANTERIOR_FORMATADO.Width = 120;
            // 
            // HEP_ESTOQUE_ATUAL_FORMATADO
            // 
            this.HEP_ESTOQUE_ATUAL_FORMATADO.DataPropertyName = "HEP_ESTOQUE_ATUAL_FORMATADO";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.HEP_ESTOQUE_ATUAL_FORMATADO.DefaultCellStyle = dataGridViewCellStyle1;
            this.HEP_ESTOQUE_ATUAL_FORMATADO.HeaderText = "Est. Atual";
            this.HEP_ESTOQUE_ATUAL_FORMATADO.Name = "HEP_ESTOQUE_ATUAL_FORMATADO";
            this.HEP_ESTOQUE_ATUAL_FORMATADO.Width = 120;
            // 
            // HEP_PRECO_UNITARIO_FORMATADO
            // 
            this.HEP_PRECO_UNITARIO_FORMATADO.DataPropertyName = "HEP_PRECO_UNITARIO_FORMATADO";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.HEP_PRECO_UNITARIO_FORMATADO.DefaultCellStyle = dataGridViewCellStyle2;
            this.HEP_PRECO_UNITARIO_FORMATADO.HeaderText = "Preço Unitário";
            this.HEP_PRECO_UNITARIO_FORMATADO.Name = "HEP_PRECO_UNITARIO_FORMATADO";
            this.HEP_PRECO_UNITARIO_FORMATADO.Width = 120;
            // 
            // HEP_PRECO_TOTAL_FORMATADO
            // 
            this.HEP_PRECO_TOTAL_FORMATADO.DataPropertyName = "HEP_PRECO_TOTAL_FORMATADO";
            this.HEP_PRECO_TOTAL_FORMATADO.HeaderText = "Preço Total";
            this.HEP_PRECO_TOTAL_FORMATADO.Name = "HEP_PRECO_TOTAL_FORMATADO";
            this.HEP_PRECO_TOTAL_FORMATADO.Width = 120;
            // 
            // Frm_Atualizar_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.gb_estoque);
            this.Name = "Frm_Atualizar_Estoque";
            this.Text = "Frm_Atualizar_Estoque";
            this.Controls.SetChildIndex(this.gb_estoque, 0);
            this.gb_estoque.ResumeLayout(false);
            this.gb_estoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_estoque;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Label lbl_igual;
        private System.Windows.Forms.DataGridView dgv_historico;
        private System.Windows.Forms.TextBox tb_qtde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_produto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox tb_estoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEP_CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEP_COMPRA_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEP_DATA_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEP_HORA_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUN_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEP_TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEP_QTDE_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEP_ESTOQUE_ANTERIOR_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEP_ESTOQUE_ATUAL_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEP_PRECO_UNITARIO_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEP_PRECO_TOTAL_FORMATADO;
    }
}