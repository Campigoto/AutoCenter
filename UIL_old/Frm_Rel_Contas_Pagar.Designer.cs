namespace UIL
{
    partial class Frm_Rel_Contas_Pagar
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
            this.lbl_separado = new System.Windows.Forms.Label();
            this.cb_separado = new System.Windows.Forms.ComboBox();
            this.cb_situacao = new System.Windows.Forms.ComboBox();
            this.lbl_situacao = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_origem = new System.Windows.Forms.Label();
            this.cb_origem = new System.Windows.Forms.ComboBox();
            this.lbl_final = new System.Windows.Forms.Label();
            this.tb_final = new System.Windows.Forms.MaskedTextBox();
            this.tb_inicio = new System.Windows.Forms.MaskedTextBox();
            this.lbl_igual = new System.Windows.Forms.Label();
            this.lbl_lancamento = new System.Windows.Forms.Label();
            this.cb_lancamento = new System.Windows.Forms.ComboBox();
            this.cb_fornecedor = new System.Windows.Forms.ComboBox();
            this.lbl_fornecedor = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.gb_contas_pagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_contas_pagar
            // 
            this.gb_contas_pagar.Controls.Add(this.lbl_separado);
            this.gb_contas_pagar.Controls.Add(this.cb_separado);
            this.gb_contas_pagar.Controls.Add(this.cb_situacao);
            this.gb_contas_pagar.Controls.Add(this.lbl_situacao);
            this.gb_contas_pagar.Controls.Add(this.cb_tipo);
            this.gb_contas_pagar.Controls.Add(this.lbl_tipo);
            this.gb_contas_pagar.Controls.Add(this.lbl_origem);
            this.gb_contas_pagar.Controls.Add(this.cb_origem);
            this.gb_contas_pagar.Controls.Add(this.lbl_final);
            this.gb_contas_pagar.Controls.Add(this.tb_final);
            this.gb_contas_pagar.Controls.Add(this.tb_inicio);
            this.gb_contas_pagar.Controls.Add(this.lbl_igual);
            this.gb_contas_pagar.Controls.Add(this.lbl_lancamento);
            this.gb_contas_pagar.Controls.Add(this.cb_lancamento);
            this.gb_contas_pagar.Controls.Add(this.cb_fornecedor);
            this.gb_contas_pagar.Controls.Add(this.lbl_fornecedor);
            this.gb_contas_pagar.Controls.Add(this.btn_confirmar);
            this.gb_contas_pagar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_contas_pagar.Location = new System.Drawing.Point(30, 90);
            this.gb_contas_pagar.Name = "gb_contas_pagar";
            this.gb_contas_pagar.Size = new System.Drawing.Size(1000, 460);
            this.gb_contas_pagar.TabIndex = 23;
            this.gb_contas_pagar.TabStop = false;
            this.gb_contas_pagar.Text = "Relatório:";
            // 
            // lbl_separado
            // 
            this.lbl_separado.AutoSize = true;
            this.lbl_separado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_separado.Location = new System.Drawing.Point(41, 356);
            this.lbl_separado.Name = "lbl_separado";
            this.lbl_separado.Size = new System.Drawing.Size(67, 13);
            this.lbl_separado.TabIndex = 100;
            this.lbl_separado.Text = "Separado:";
            // 
            // cb_separado
            // 
            this.cb_separado.FormattingEnabled = true;
            this.cb_separado.Items.AddRange(new object[] {
            "Todos",
            "Fornecedor",
            "Lançamento"});
            this.cb_separado.Location = new System.Drawing.Point(44, 372);
            this.cb_separado.Name = "cb_separado";
            this.cb_separado.Size = new System.Drawing.Size(369, 21);
            this.cb_separado.TabIndex = 99;
            // 
            // cb_situacao
            // 
            this.cb_situacao.FormattingEnabled = true;
            this.cb_situacao.Items.AddRange(new object[] {
            "À Pagar",
            "Pagas",
            "Todos"});
            this.cb_situacao.Location = new System.Drawing.Point(44, 172);
            this.cb_situacao.Name = "cb_situacao";
            this.cb_situacao.Size = new System.Drawing.Size(369, 21);
            this.cb_situacao.TabIndex = 97;
            this.cb_situacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // lbl_situacao
            // 
            this.lbl_situacao.AutoSize = true;
            this.lbl_situacao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_situacao.Location = new System.Drawing.Point(41, 156);
            this.lbl_situacao.Name = "lbl_situacao";
            this.lbl_situacao.Size = new System.Drawing.Size(61, 13);
            this.lbl_situacao.TabIndex = 98;
            this.lbl_situacao.Text = "Situação:";
            // 
            // cb_tipo
            // 
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Completa",
            "Resumida"});
            this.cb_tipo.Location = new System.Drawing.Point(44, 118);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(369, 21);
            this.cb_tipo.TabIndex = 3;
            this.cb_tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(41, 102);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(36, 13);
            this.lbl_tipo.TabIndex = 96;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // lbl_origem
            // 
            this.lbl_origem.AutoSize = true;
            this.lbl_origem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_origem.Location = new System.Drawing.Point(41, 307);
            this.lbl_origem.Name = "lbl_origem";
            this.lbl_origem.Size = new System.Drawing.Size(54, 13);
            this.lbl_origem.TabIndex = 95;
            this.lbl_origem.Text = "Origem:";
            // 
            // cb_origem
            // 
            this.cb_origem.FormattingEnabled = true;
            this.cb_origem.Items.AddRange(new object[] {
            "Todos",
            "Manual",
            "Compra"});
            this.cb_origem.Location = new System.Drawing.Point(44, 323);
            this.cb_origem.Name = "cb_origem";
            this.cb_origem.Size = new System.Drawing.Size(369, 21);
            this.cb_origem.TabIndex = 6;
            this.cb_origem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // lbl_final
            // 
            this.lbl_final.AutoSize = true;
            this.lbl_final.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_final.Location = new System.Drawing.Point(168, 43);
            this.lbl_final.Name = "lbl_final";
            this.lbl_final.Size = new System.Drawing.Size(38, 13);
            this.lbl_final.TabIndex = 93;
            this.lbl_final.Text = "Final:";
            // 
            // tb_final
            // 
            this.tb_final.Location = new System.Drawing.Point(171, 59);
            this.tb_final.Mask = "00/00/0000";
            this.tb_final.Name = "tb_final";
            this.tb_final.Size = new System.Drawing.Size(110, 21);
            this.tb_final.TabIndex = 2;
            this.tb_final.ValidatingType = typeof(System.DateTime);
            // 
            // tb_inicio
            // 
            this.tb_inicio.Location = new System.Drawing.Point(44, 59);
            this.tb_inicio.Mask = "00/00/0000";
            this.tb_inicio.Name = "tb_inicio";
            this.tb_inicio.Size = new System.Drawing.Size(110, 21);
            this.tb_inicio.TabIndex = 1;
            this.tb_inicio.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_igual
            // 
            this.lbl_igual.AutoSize = true;
            this.lbl_igual.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_igual.Location = new System.Drawing.Point(41, 43);
            this.lbl_igual.Name = "lbl_igual";
            this.lbl_igual.Size = new System.Drawing.Size(43, 13);
            this.lbl_igual.TabIndex = 92;
            this.lbl_igual.Text = "Início:";
            // 
            // lbl_lancamento
            // 
            this.lbl_lancamento.AutoSize = true;
            this.lbl_lancamento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lancamento.Location = new System.Drawing.Point(41, 258);
            this.lbl_lancamento.Name = "lbl_lancamento";
            this.lbl_lancamento.Size = new System.Drawing.Size(81, 13);
            this.lbl_lancamento.TabIndex = 62;
            this.lbl_lancamento.Text = "Lançamento:";
            // 
            // cb_lancamento
            // 
            this.cb_lancamento.DisplayMember = "HIS_DESCRICAO";
            this.cb_lancamento.FormattingEnabled = true;
            this.cb_lancamento.Location = new System.Drawing.Point(44, 274);
            this.cb_lancamento.Name = "cb_lancamento";
            this.cb_lancamento.Size = new System.Drawing.Size(369, 21);
            this.cb_lancamento.TabIndex = 5;
            this.cb_lancamento.ValueMember = "HIS_ID";
            this.cb_lancamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // cb_fornecedor
            // 
            this.cb_fornecedor.DisplayMember = "FOR_NOME";
            this.cb_fornecedor.FormattingEnabled = true;
            this.cb_fornecedor.Location = new System.Drawing.Point(44, 223);
            this.cb_fornecedor.Name = "cb_fornecedor";
            this.cb_fornecedor.Size = new System.Drawing.Size(369, 21);
            this.cb_fornecedor.TabIndex = 4;
            this.cb_fornecedor.ValueMember = "FOR_CODIGO";
            // 
            // lbl_fornecedor
            // 
            this.lbl_fornecedor.AutoSize = true;
            this.lbl_fornecedor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fornecedor.Location = new System.Drawing.Point(41, 207);
            this.lbl_fornecedor.Name = "lbl_fornecedor";
            this.lbl_fornecedor.Size = new System.Drawing.Size(76, 13);
            this.lbl_fornecedor.TabIndex = 59;
            this.lbl_fornecedor.Text = "Fornecedor:";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.Location = new System.Drawing.Point(403, 415);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(100, 30);
            this.btn_confirmar.TabIndex = 7;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // Frm_Rel_Contas_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.gb_contas_pagar);
            this.Name = "Frm_Rel_Contas_Pagar";
            this.Text = "Frm_Rel_Contas_Pagar";
            this.Controls.SetChildIndex(this.gb_contas_pagar, 0);
            this.gb_contas_pagar.ResumeLayout(false);
            this.gb_contas_pagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_contas_pagar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label lbl_lancamento;
        private System.Windows.Forms.ComboBox cb_lancamento;
        private System.Windows.Forms.ComboBox cb_fornecedor;
        private System.Windows.Forms.Label lbl_fornecedor;
        private System.Windows.Forms.Label lbl_final;
        private System.Windows.Forms.MaskedTextBox tb_final;
        private System.Windows.Forms.MaskedTextBox tb_inicio;
        private System.Windows.Forms.Label lbl_igual;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_origem;
        private System.Windows.Forms.ComboBox cb_origem;
        private System.Windows.Forms.ComboBox cb_situacao;
        private System.Windows.Forms.Label lbl_situacao;
        private System.Windows.Forms.Label lbl_separado;
        private System.Windows.Forms.ComboBox cb_separado;
    }
}