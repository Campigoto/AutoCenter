namespace UIL
{
    partial class Frm_Gerar_Parcelas
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
            this.lbl_qtde = new System.Windows.Forms.Label();
            this.tb_qtde = new System.Windows.Forms.TextBox();
            this.tb_venc_1parc = new System.Windows.Forms.MaskedTextBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.cb_intervalo = new System.Windows.Forms.ComboBox();
            this.lbl_intervalo = new System.Windows.Forms.Label();
            this.lbl_parcelas = new System.Windows.Forms.Label();
            this.tb_parcelas = new System.Windows.Forms.TextBox();
            this.lbl_venc_1parc = new System.Windows.Forms.Label();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_qtde
            // 
            this.lbl_qtde.AutoSize = true;
            this.lbl_qtde.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtde.Location = new System.Drawing.Point(502, 26);
            this.lbl_qtde.Name = "lbl_qtde";
            this.lbl_qtde.Size = new System.Drawing.Size(77, 13);
            this.lbl_qtde.TabIndex = 70;
            this.lbl_qtde.Text = "Quantidade:";
            // 
            // tb_qtde
            // 
            this.tb_qtde.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qtde.Location = new System.Drawing.Point(505, 42);
            this.tb_qtde.MaxLength = 3;
            this.tb_qtde.Name = "tb_qtde";
            this.tb_qtde.Size = new System.Drawing.Size(100, 21);
            this.tb_qtde.TabIndex = 5;
            this.tb_qtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // tb_venc_1parc
            // 
            this.tb_venc_1parc.Location = new System.Drawing.Point(263, 42);
            this.tb_venc_1parc.Mask = "00/00/0000";
            this.tb_venc_1parc.Name = "tb_venc_1parc";
            this.tb_venc_1parc.Size = new System.Drawing.Size(100, 20);
            this.tb_venc_1parc.TabIndex = 3;
            this.tb_venc_1parc.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(138, 26);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(36, 13);
            this.lbl_tipo.TabIndex = 67;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // cb_tipo
            // 
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "",
            "Dinheiro",
            "Crediario",
            "Cheque",
            "Boleto",
            "Financeira"});
            this.cb_tipo.Location = new System.Drawing.Point(141, 42);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(104, 21);
            this.cb_tipo.TabIndex = 2;
            this.cb_tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // cb_intervalo
            // 
            this.cb_intervalo.FormattingEnabled = true;
            this.cb_intervalo.Items.AddRange(new object[] {
            "Mês",
            "Dia"});
            this.cb_intervalo.Location = new System.Drawing.Point(625, 42);
            this.cb_intervalo.Name = "cb_intervalo";
            this.cb_intervalo.Size = new System.Drawing.Size(96, 21);
            this.cb_intervalo.TabIndex = 6;
            // 
            // lbl_intervalo
            // 
            this.lbl_intervalo.AutoSize = true;
            this.lbl_intervalo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intervalo.Location = new System.Drawing.Point(622, 26);
            this.lbl_intervalo.Name = "lbl_intervalo";
            this.lbl_intervalo.Size = new System.Drawing.Size(64, 13);
            this.lbl_intervalo.TabIndex = 64;
            this.lbl_intervalo.Text = "Intervalo:";
            // 
            // lbl_parcelas
            // 
            this.lbl_parcelas.AutoSize = true;
            this.lbl_parcelas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parcelas.Location = new System.Drawing.Point(379, 26);
            this.lbl_parcelas.Name = "lbl_parcelas";
            this.lbl_parcelas.Size = new System.Drawing.Size(78, 13);
            this.lbl_parcelas.TabIndex = 63;
            this.lbl_parcelas.Text = "Nº Parcelas:";
            // 
            // tb_parcelas
            // 
            this.tb_parcelas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_parcelas.Location = new System.Drawing.Point(382, 42);
            this.tb_parcelas.MaxLength = 3;
            this.tb_parcelas.Name = "tb_parcelas";
            this.tb_parcelas.Size = new System.Drawing.Size(100, 21);
            this.tb_parcelas.TabIndex = 4;
            this.tb_parcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // lbl_venc_1parc
            // 
            this.lbl_venc_1parc.AutoSize = true;
            this.lbl_venc_1parc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venc_1parc.Location = new System.Drawing.Point(260, 26);
            this.lbl_venc_1parc.Name = "lbl_venc_1parc";
            this.lbl_venc_1parc.Size = new System.Drawing.Size(86, 13);
            this.lbl_venc_1parc.TabIndex = 61;
            this.lbl_venc_1parc.Text = "Venc 1ª Parc:";
            // 
            // btn_gerar
            // 
            this.btn_gerar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerar.Location = new System.Drawing.Point(399, 95);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(100, 30);
            this.btn_gerar.TabIndex = 7;
            this.btn_gerar.Text = "Gerar";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(17, 26);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(42, 13);
            this.lbl_valor.TabIndex = 59;
            this.lbl_valor.Text = "Valor:";
            // 
            // tb_valor
            // 
            this.tb_valor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor.Location = new System.Drawing.Point(20, 42);
            this.tb_valor.MaxLength = 10;
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 21);
            this.tb_valor.TabIndex = 1;
            this.tb_valor.Leave += new System.EventHandler(this.Valor_Leave);
            this.tb_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valor_KeyPress);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.Location = new System.Drawing.Point(505, 95);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(100, 30);
            this.btn_fechar.TabIndex = 8;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Frm_Gerar_Parcelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 137);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.lbl_qtde);
            this.Controls.Add(this.tb_qtde);
            this.Controls.Add(this.tb_venc_1parc);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.cb_intervalo);
            this.Controls.Add(this.lbl_intervalo);
            this.Controls.Add(this.lbl_parcelas);
            this.Controls.Add(this.tb_parcelas);
            this.Controls.Add(this.lbl_venc_1parc);
            this.Controls.Add(this.btn_gerar);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.tb_valor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Gerar_Parcelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Gerar_Parcelas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Gerar_Parcelas_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_qtde;
        private System.Windows.Forms.TextBox tb_qtde;
        private System.Windows.Forms.MaskedTextBox tb_venc_1parc;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.ComboBox cb_intervalo;
        private System.Windows.Forms.Label lbl_intervalo;
        private System.Windows.Forms.Label lbl_parcelas;
        private System.Windows.Forms.TextBox tb_parcelas;
        private System.Windows.Forms.Label lbl_venc_1parc;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button btn_fechar;
    }
}