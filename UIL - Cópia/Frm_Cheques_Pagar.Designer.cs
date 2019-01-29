namespace UIL
{
    partial class Frm_Cheques_Pagar
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
            this.gb_cheque = new System.Windows.Forms.GroupBox();
            this.lbl_obs = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.tb_efetivacao = new System.Windows.Forms.MaskedTextBox();
            this.lbl_efetivacao = new System.Windows.Forms.Label();
            this.tb_venc = new System.Windows.Forms.MaskedTextBox();
            this.lbl_venc = new System.Windows.Forms.Label();
            this.tb_emissao = new System.Windows.Forms.MaskedTextBox();
            this.lbl_emissao = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.lbl_conta = new System.Windows.Forms.Label();
            this.tb_conta = new System.Windows.Forms.TextBox();
            this.lbl_num_doc = new System.Windows.Forms.Label();
            this.tb_num_doc = new System.Windows.Forms.TextBox();
            this.lbl_agencia = new System.Windows.Forms.Label();
            this.tb_agencia = new System.Windows.Forms.TextBox();
            this.lbl_banco = new System.Windows.Forms.Label();
            this.tb_banco = new System.Windows.Forms.TextBox();
            this.tb_item = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_carne = new System.Windows.Forms.TextBox();
            this.lbl_carne = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.gb_cheque.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_cheque
            // 
            this.gb_cheque.Controls.Add(this.lbl_obs);
            this.gb_cheque.Controls.Add(this.tb_obs);
            this.gb_cheque.Controls.Add(this.tb_efetivacao);
            this.gb_cheque.Controls.Add(this.lbl_efetivacao);
            this.gb_cheque.Controls.Add(this.tb_venc);
            this.gb_cheque.Controls.Add(this.lbl_venc);
            this.gb_cheque.Controls.Add(this.tb_emissao);
            this.gb_cheque.Controls.Add(this.lbl_emissao);
            this.gb_cheque.Controls.Add(this.lbl_valor);
            this.gb_cheque.Controls.Add(this.tb_valor);
            this.gb_cheque.Controls.Add(this.lbl_conta);
            this.gb_cheque.Controls.Add(this.tb_conta);
            this.gb_cheque.Controls.Add(this.lbl_num_doc);
            this.gb_cheque.Controls.Add(this.tb_num_doc);
            this.gb_cheque.Controls.Add(this.lbl_agencia);
            this.gb_cheque.Controls.Add(this.tb_agencia);
            this.gb_cheque.Controls.Add(this.lbl_banco);
            this.gb_cheque.Controls.Add(this.tb_banco);
            this.gb_cheque.Controls.Add(this.tb_item);
            this.gb_cheque.Controls.Add(this.lbl_item);
            this.gb_cheque.Controls.Add(this.btn_pesquisar);
            this.gb_cheque.Controls.Add(this.btn_excluir);
            this.gb_cheque.Controls.Add(this.lbl_codigo);
            this.gb_cheque.Controls.Add(this.tb_codigo);
            this.gb_cheque.Controls.Add(this.tb_carne);
            this.gb_cheque.Controls.Add(this.lbl_carne);
            this.gb_cheque.Controls.Add(this.btn_limpar);
            this.gb_cheque.Controls.Add(this.btn_gravar);
            this.gb_cheque.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_cheque.Location = new System.Drawing.Point(21, 92);
            this.gb_cheque.Name = "gb_cheque";
            this.gb_cheque.Size = new System.Drawing.Size(1000, 444);
            this.gb_cheque.TabIndex = 23;
            this.gb_cheque.TabStop = false;
            this.gb_cheque.Text = "Cadastro:";
            // 
            // lbl_obs
            // 
            this.lbl_obs.AutoSize = true;
            this.lbl_obs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obs.Location = new System.Drawing.Point(31, 217);
            this.lbl_obs.Name = "lbl_obs";
            this.lbl_obs.Size = new System.Drawing.Size(80, 13);
            this.lbl_obs.TabIndex = 76;
            this.lbl_obs.Text = "Observação:";
            // 
            // tb_obs
            // 
            this.tb_obs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_obs.Location = new System.Drawing.Point(34, 233);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(714, 126);
            this.tb_obs.TabIndex = 12;
            // 
            // tb_efetivacao
            // 
            this.tb_efetivacao.Location = new System.Drawing.Point(398, 178);
            this.tb_efetivacao.Mask = "00/00/0000";
            this.tb_efetivacao.Name = "tb_efetivacao";
            this.tb_efetivacao.Size = new System.Drawing.Size(100, 21);
            this.tb_efetivacao.TabIndex = 11;
            this.tb_efetivacao.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_efetivacao
            // 
            this.lbl_efetivacao.AutoSize = true;
            this.lbl_efetivacao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_efetivacao.Location = new System.Drawing.Point(395, 162);
            this.lbl_efetivacao.Name = "lbl_efetivacao";
            this.lbl_efetivacao.Size = new System.Drawing.Size(71, 13);
            this.lbl_efetivacao.TabIndex = 73;
            this.lbl_efetivacao.Text = "Efetivação:";
            // 
            // tb_venc
            // 
            this.tb_venc.Location = new System.Drawing.Point(274, 178);
            this.tb_venc.Mask = "00/00/0000";
            this.tb_venc.Name = "tb_venc";
            this.tb_venc.Size = new System.Drawing.Size(100, 21);
            this.tb_venc.TabIndex = 10;
            this.tb_venc.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_venc
            // 
            this.lbl_venc.AutoSize = true;
            this.lbl_venc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venc.Location = new System.Drawing.Point(271, 162);
            this.lbl_venc.Name = "lbl_venc";
            this.lbl_venc.Size = new System.Drawing.Size(79, 13);
            this.lbl_venc.TabIndex = 71;
            this.lbl_venc.Text = "Vencimento:";
            // 
            // tb_emissao
            // 
            this.tb_emissao.Location = new System.Drawing.Point(155, 178);
            this.tb_emissao.Mask = "00/00/0000";
            this.tb_emissao.Name = "tb_emissao";
            this.tb_emissao.Size = new System.Drawing.Size(100, 21);
            this.tb_emissao.TabIndex = 9;
            this.tb_emissao.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_emissao
            // 
            this.lbl_emissao.AutoSize = true;
            this.lbl_emissao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emissao.Location = new System.Drawing.Point(152, 162);
            this.lbl_emissao.Name = "lbl_emissao";
            this.lbl_emissao.Size = new System.Drawing.Size(59, 13);
            this.lbl_emissao.TabIndex = 69;
            this.lbl_emissao.Text = "Emissão:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(31, 162);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(42, 13);
            this.lbl_valor.TabIndex = 39;
            this.lbl_valor.Text = "Valor:";
            // 
            // tb_valor
            // 
            this.tb_valor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor.Location = new System.Drawing.Point(34, 178);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 21);
            this.tb_valor.TabIndex = 8;
            this.tb_valor.Leave += new System.EventHandler(this.Valor_Leave);
            this.tb_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valor_KeyPress);
            // 
            // lbl_conta
            // 
            this.lbl_conta.AutoSize = true;
            this.lbl_conta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conta.Location = new System.Drawing.Point(31, 102);
            this.lbl_conta.Name = "lbl_conta";
            this.lbl_conta.Size = new System.Drawing.Size(46, 13);
            this.lbl_conta.TabIndex = 37;
            this.lbl_conta.Text = "Conta:";
            // 
            // tb_conta
            // 
            this.tb_conta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_conta.Location = new System.Drawing.Point(34, 118);
            this.tb_conta.Name = "tb_conta";
            this.tb_conta.Size = new System.Drawing.Size(100, 21);
            this.tb_conta.TabIndex = 4;
            // 
            // lbl_num_doc
            // 
            this.lbl_num_doc.AutoSize = true;
            this.lbl_num_doc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_doc.Location = new System.Drawing.Point(501, 102);
            this.lbl_num_doc.Name = "lbl_num_doc";
            this.lbl_num_doc.Size = new System.Drawing.Size(111, 13);
            this.lbl_num_doc.TabIndex = 35;
            this.lbl_num_doc.Text = "Num. Documento:";
            // 
            // tb_num_doc
            // 
            this.tb_num_doc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_num_doc.Location = new System.Drawing.Point(504, 118);
            this.tb_num_doc.Name = "tb_num_doc";
            this.tb_num_doc.Size = new System.Drawing.Size(119, 21);
            this.tb_num_doc.TabIndex = 7;
            // 
            // lbl_agencia
            // 
            this.lbl_agencia.AutoSize = true;
            this.lbl_agencia.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agencia.Location = new System.Drawing.Point(377, 102);
            this.lbl_agencia.Name = "lbl_agencia";
            this.lbl_agencia.Size = new System.Drawing.Size(57, 13);
            this.lbl_agencia.TabIndex = 33;
            this.lbl_agencia.Text = "Agência:";
            // 
            // tb_agencia
            // 
            this.tb_agencia.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_agencia.Location = new System.Drawing.Point(380, 118);
            this.tb_agencia.Name = "tb_agencia";
            this.tb_agencia.Size = new System.Drawing.Size(100, 21);
            this.tb_agencia.TabIndex = 6;
            // 
            // lbl_banco
            // 
            this.lbl_banco.AutoSize = true;
            this.lbl_banco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_banco.Location = new System.Drawing.Point(152, 102);
            this.lbl_banco.Name = "lbl_banco";
            this.lbl_banco.Size = new System.Drawing.Size(47, 13);
            this.lbl_banco.TabIndex = 31;
            this.lbl_banco.Text = "Banco:";
            // 
            // tb_banco
            // 
            this.tb_banco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_banco.Location = new System.Drawing.Point(155, 118);
            this.tb_banco.Name = "tb_banco";
            this.tb_banco.Size = new System.Drawing.Size(201, 21);
            this.tb_banco.TabIndex = 5;
            // 
            // tb_item
            // 
            this.tb_item.Enabled = false;
            this.tb_item.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_item.Location = new System.Drawing.Point(248, 63);
            this.tb_item.Name = "tb_item";
            this.tb_item.Size = new System.Drawing.Size(72, 21);
            this.tb_item.TabIndex = 3;
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.Location = new System.Drawing.Point(245, 47);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(39, 13);
            this.lbl_item.TabIndex = 29;
            this.lbl_item.Text = "Item:";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(293, 396);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(100, 30);
            this.btn_pesquisar.TabIndex = 13;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Location = new System.Drawing.Point(611, 396);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(100, 30);
            this.btn_excluir.TabIndex = 16;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(31, 47);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(52, 13);
            this.lbl_codigo.TabIndex = 25;
            this.lbl_codigo.Text = "Código:";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(34, 63);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(100, 21);
            this.tb_codigo.TabIndex = 1;
            this.tb_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.tb_codigo.Leave += new System.EventHandler(this.tb_codigo_Leave);
            this.tb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // tb_carne
            // 
            this.tb_carne.Enabled = false;
            this.tb_carne.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_carne.Location = new System.Drawing.Point(155, 63);
            this.tb_carne.Name = "tb_carne";
            this.tb_carne.Size = new System.Drawing.Size(72, 21);
            this.tb_carne.TabIndex = 2;
            // 
            // lbl_carne
            // 
            this.lbl_carne.AutoSize = true;
            this.lbl_carne.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carne.Location = new System.Drawing.Point(152, 47);
            this.lbl_carne.Name = "lbl_carne";
            this.lbl_carne.Size = new System.Drawing.Size(47, 13);
            this.lbl_carne.TabIndex = 23;
            this.lbl_carne.Text = "Carnê:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(505, 396);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(100, 30);
            this.btn_limpar.TabIndex = 15;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravar.Location = new System.Drawing.Point(399, 396);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(100, 30);
            this.btn_gravar.TabIndex = 14;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // Frm_Cheques_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.gb_cheque);
            this.Name = "Frm_Cheques_Pagar";
            this.Text = "Frm_Cheques_Pagar";
            this.Controls.SetChildIndex(this.gb_cheque, 0);
            this.gb_cheque.ResumeLayout(false);
            this.gb_cheque.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_cheque;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_carne;
        private System.Windows.Forms.Label lbl_carne;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox tb_item;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Label lbl_conta;
        private System.Windows.Forms.TextBox tb_conta;
        private System.Windows.Forms.Label lbl_num_doc;
        private System.Windows.Forms.TextBox tb_num_doc;
        private System.Windows.Forms.Label lbl_agencia;
        private System.Windows.Forms.TextBox tb_agencia;
        private System.Windows.Forms.Label lbl_banco;
        private System.Windows.Forms.TextBox tb_banco;
        private System.Windows.Forms.MaskedTextBox tb_efetivacao;
        private System.Windows.Forms.Label lbl_efetivacao;
        private System.Windows.Forms.MaskedTextBox tb_venc;
        private System.Windows.Forms.Label lbl_venc;
        private System.Windows.Forms.MaskedTextBox tb_emissao;
        private System.Windows.Forms.Label lbl_emissao;
        private System.Windows.Forms.Label lbl_obs;
        private System.Windows.Forms.TextBox tb_obs;
    }
}