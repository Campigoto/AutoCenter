namespace UIL
{
    partial class Frm_Gerar_Cheques
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
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_gerar = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.Location = new System.Drawing.Point(477, 220);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(100, 30);
            this.btn_fechar.TabIndex = 11;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_gerar
            // 
            this.btn_gerar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerar.Location = new System.Drawing.Point(371, 220);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(100, 30);
            this.btn_gerar.TabIndex = 10;
            this.btn_gerar.Text = "Gerar";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // lbl_obs
            // 
            this.lbl_obs.AutoSize = true;
            this.lbl_obs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obs.Location = new System.Drawing.Point(20, 135);
            this.lbl_obs.Name = "lbl_obs";
            this.lbl_obs.Size = new System.Drawing.Size(80, 13);
            this.lbl_obs.TabIndex = 94;
            this.lbl_obs.Text = "Observação:";
            // 
            // tb_obs
            // 
            this.tb_obs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_obs.Location = new System.Drawing.Point(23, 151);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(661, 53);
            this.tb_obs.TabIndex = 9;
            // 
            // tb_efetivacao
            // 
            this.tb_efetivacao.Location = new System.Drawing.Point(387, 96);
            this.tb_efetivacao.Mask = "00/00/0000";
            this.tb_efetivacao.Name = "tb_efetivacao";
            this.tb_efetivacao.Size = new System.Drawing.Size(100, 20);
            this.tb_efetivacao.TabIndex = 8;
            this.tb_efetivacao.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_efetivacao
            // 
            this.lbl_efetivacao.AutoSize = true;
            this.lbl_efetivacao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_efetivacao.Location = new System.Drawing.Point(384, 80);
            this.lbl_efetivacao.Name = "lbl_efetivacao";
            this.lbl_efetivacao.Size = new System.Drawing.Size(71, 13);
            this.lbl_efetivacao.TabIndex = 91;
            this.lbl_efetivacao.Text = "Efetivação:";
            // 
            // tb_venc
            // 
            this.tb_venc.Location = new System.Drawing.Point(263, 96);
            this.tb_venc.Mask = "00/00/0000";
            this.tb_venc.Name = "tb_venc";
            this.tb_venc.Size = new System.Drawing.Size(100, 20);
            this.tb_venc.TabIndex = 7;
            this.tb_venc.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_venc
            // 
            this.lbl_venc.AutoSize = true;
            this.lbl_venc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venc.Location = new System.Drawing.Point(260, 80);
            this.lbl_venc.Name = "lbl_venc";
            this.lbl_venc.Size = new System.Drawing.Size(79, 13);
            this.lbl_venc.TabIndex = 89;
            this.lbl_venc.Text = "Vencimento:";
            // 
            // tb_emissao
            // 
            this.tb_emissao.Location = new System.Drawing.Point(144, 96);
            this.tb_emissao.Mask = "00/00/0000";
            this.tb_emissao.Name = "tb_emissao";
            this.tb_emissao.Size = new System.Drawing.Size(100, 20);
            this.tb_emissao.TabIndex = 6;
            this.tb_emissao.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_emissao
            // 
            this.lbl_emissao.AutoSize = true;
            this.lbl_emissao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emissao.Location = new System.Drawing.Point(141, 80);
            this.lbl_emissao.Name = "lbl_emissao";
            this.lbl_emissao.Size = new System.Drawing.Size(59, 13);
            this.lbl_emissao.TabIndex = 87;
            this.lbl_emissao.Text = "Emissão:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(20, 80);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(42, 13);
            this.lbl_valor.TabIndex = 86;
            this.lbl_valor.Text = "Valor:";
            // 
            // tb_valor
            // 
            this.tb_valor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor.Location = new System.Drawing.Point(23, 96);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 21);
            this.tb_valor.TabIndex = 5;
            this.tb_valor.Leave += new System.EventHandler(this.Valor_Leave);
            // 
            // lbl_conta
            // 
            this.lbl_conta.AutoSize = true;
            this.lbl_conta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conta.Location = new System.Drawing.Point(20, 20);
            this.lbl_conta.Name = "lbl_conta";
            this.lbl_conta.Size = new System.Drawing.Size(46, 13);
            this.lbl_conta.TabIndex = 84;
            this.lbl_conta.Text = "Conta:";
            // 
            // tb_conta
            // 
            this.tb_conta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_conta.Location = new System.Drawing.Point(23, 36);
            this.tb_conta.Name = "tb_conta";
            this.tb_conta.Size = new System.Drawing.Size(100, 21);
            this.tb_conta.TabIndex = 1;
            // 
            // lbl_num_doc
            // 
            this.lbl_num_doc.AutoSize = true;
            this.lbl_num_doc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_doc.Location = new System.Drawing.Point(490, 20);
            this.lbl_num_doc.Name = "lbl_num_doc";
            this.lbl_num_doc.Size = new System.Drawing.Size(111, 13);
            this.lbl_num_doc.TabIndex = 82;
            this.lbl_num_doc.Text = "Num. Documento:";
            // 
            // tb_num_doc
            // 
            this.tb_num_doc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_num_doc.Location = new System.Drawing.Point(493, 36);
            this.tb_num_doc.Name = "tb_num_doc";
            this.tb_num_doc.Size = new System.Drawing.Size(119, 21);
            this.tb_num_doc.TabIndex = 4;
            // 
            // lbl_agencia
            // 
            this.lbl_agencia.AutoSize = true;
            this.lbl_agencia.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agencia.Location = new System.Drawing.Point(366, 20);
            this.lbl_agencia.Name = "lbl_agencia";
            this.lbl_agencia.Size = new System.Drawing.Size(57, 13);
            this.lbl_agencia.TabIndex = 80;
            this.lbl_agencia.Text = "Agência:";
            // 
            // tb_agencia
            // 
            this.tb_agencia.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_agencia.Location = new System.Drawing.Point(369, 36);
            this.tb_agencia.Name = "tb_agencia";
            this.tb_agencia.Size = new System.Drawing.Size(100, 21);
            this.tb_agencia.TabIndex = 3;
            // 
            // lbl_banco
            // 
            this.lbl_banco.AutoSize = true;
            this.lbl_banco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_banco.Location = new System.Drawing.Point(141, 20);
            this.lbl_banco.Name = "lbl_banco";
            this.lbl_banco.Size = new System.Drawing.Size(47, 13);
            this.lbl_banco.TabIndex = 78;
            this.lbl_banco.Text = "Banco:";
            // 
            // tb_banco
            // 
            this.tb_banco.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_banco.Location = new System.Drawing.Point(144, 36);
            this.tb_banco.Name = "tb_banco";
            this.tb_banco.Size = new System.Drawing.Size(201, 21);
            this.tb_banco.TabIndex = 2;
            // 
            // Frm_Gerar_Cheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 262);
            this.Controls.Add(this.lbl_obs);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.tb_efetivacao);
            this.Controls.Add(this.lbl_efetivacao);
            this.Controls.Add(this.tb_venc);
            this.Controls.Add(this.lbl_venc);
            this.Controls.Add(this.tb_emissao);
            this.Controls.Add(this.lbl_emissao);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.lbl_conta);
            this.Controls.Add(this.tb_conta);
            this.Controls.Add(this.lbl_num_doc);
            this.Controls.Add(this.tb_num_doc);
            this.Controls.Add(this.lbl_agencia);
            this.Controls.Add(this.tb_agencia);
            this.Controls.Add(this.lbl_banco);
            this.Controls.Add(this.tb_banco);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_gerar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Gerar_Cheques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Gerar_Cheques";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Gerar_Cheques_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.Label lbl_obs;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.MaskedTextBox tb_efetivacao;
        private System.Windows.Forms.Label lbl_efetivacao;
        private System.Windows.Forms.MaskedTextBox tb_venc;
        private System.Windows.Forms.Label lbl_venc;
        private System.Windows.Forms.MaskedTextBox tb_emissao;
        private System.Windows.Forms.Label lbl_emissao;
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
    }
}