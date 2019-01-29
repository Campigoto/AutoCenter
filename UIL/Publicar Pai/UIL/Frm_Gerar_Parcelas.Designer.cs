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
            this.tb_nf = new System.Windows.Forms.TextBox();
            this.lbl_nf = new System.Windows.Forms.Label();
            this.lbl_acresc = new System.Windows.Forms.Label();
            this.tb_acresc = new System.Windows.Forms.TextBox();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_qtde
            // 
            this.lbl_qtde.AutoSize = true;
            this.lbl_qtde.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtde.Location = new System.Drawing.Point(21, 70);
            this.lbl_qtde.Name = "lbl_qtde";
            this.lbl_qtde.Size = new System.Drawing.Size(77, 13);
            this.lbl_qtde.TabIndex = 70;
            this.lbl_qtde.Text = "Quantidade:";
            // 
            // tb_qtde
            // 
            this.tb_qtde.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qtde.Location = new System.Drawing.Point(24, 86);
            this.tb_qtde.MaxLength = 3;
            this.tb_qtde.Name = "tb_qtde";
            this.tb_qtde.Size = new System.Drawing.Size(100, 21);
            this.tb_qtde.TabIndex = 8;
            this.tb_qtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // tb_venc_1parc
            // 
            this.tb_venc_1parc.Location = new System.Drawing.Point(558, 41);
            this.tb_venc_1parc.Mask = "00/00/0000";
            this.tb_venc_1parc.Name = "tb_venc_1parc";
            this.tb_venc_1parc.Size = new System.Drawing.Size(100, 20);
            this.tb_venc_1parc.TabIndex = 6;
            this.tb_venc_1parc.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(445, 25);
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
            "Cheque",
            "Boleto",
            "Débito em C/C",
            "DDA",
            "Depósito",
            "Cartão de Crédito",
            "Carnê",
            "Financeira"});
            this.cb_tipo.Location = new System.Drawing.Point(448, 41);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(104, 21);
            this.cb_tipo.TabIndex = 5;
            this.cb_tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // cb_intervalo
            // 
            this.cb_intervalo.FormattingEnabled = true;
            this.cb_intervalo.Items.AddRange(new object[] {
            "Mês",
            "Dia"});
            this.cb_intervalo.Location = new System.Drawing.Point(130, 86);
            this.cb_intervalo.Name = "cb_intervalo";
            this.cb_intervalo.Size = new System.Drawing.Size(96, 21);
            this.cb_intervalo.TabIndex = 9;
            // 
            // lbl_intervalo
            // 
            this.lbl_intervalo.AutoSize = true;
            this.lbl_intervalo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intervalo.Location = new System.Drawing.Point(127, 70);
            this.lbl_intervalo.Name = "lbl_intervalo";
            this.lbl_intervalo.Size = new System.Drawing.Size(64, 13);
            this.lbl_intervalo.TabIndex = 64;
            this.lbl_intervalo.Text = "Intervalo:";
            // 
            // lbl_parcelas
            // 
            this.lbl_parcelas.AutoSize = true;
            this.lbl_parcelas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parcelas.Location = new System.Drawing.Point(661, 24);
            this.lbl_parcelas.Name = "lbl_parcelas";
            this.lbl_parcelas.Size = new System.Drawing.Size(78, 13);
            this.lbl_parcelas.TabIndex = 63;
            this.lbl_parcelas.Text = "Nº Parcelas:";
            // 
            // tb_parcelas
            // 
            this.tb_parcelas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_parcelas.Location = new System.Drawing.Point(664, 40);
            this.tb_parcelas.MaxLength = 3;
            this.tb_parcelas.Name = "tb_parcelas";
            this.tb_parcelas.Size = new System.Drawing.Size(100, 21);
            this.tb_parcelas.TabIndex = 7;
            this.tb_parcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // lbl_venc_1parc
            // 
            this.lbl_venc_1parc.AutoSize = true;
            this.lbl_venc_1parc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venc_1parc.Location = new System.Drawing.Point(555, 25);
            this.lbl_venc_1parc.Name = "lbl_venc_1parc";
            this.lbl_venc_1parc.Size = new System.Drawing.Size(86, 13);
            this.lbl_venc_1parc.TabIndex = 61;
            this.lbl_venc_1parc.Text = "Venc 1ª Parc:";
            // 
            // btn_gerar
            // 
            this.btn_gerar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerar.Location = new System.Drawing.Point(381, 132);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(100, 30);
            this.btn_gerar.TabIndex = 10;
            this.btn_gerar.Text = "Gerar";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(127, 25);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(42, 13);
            this.lbl_valor.TabIndex = 59;
            this.lbl_valor.Text = "Valor:";
            // 
            // tb_valor
            // 
            this.tb_valor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor.Location = new System.Drawing.Point(130, 41);
            this.tb_valor.MaxLength = 10;
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 21);
            this.tb_valor.TabIndex = 2;
            this.tb_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valor_KeyPress);
            this.tb_valor.Leave += new System.EventHandler(this.Valor_Leave);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.Location = new System.Drawing.Point(487, 132);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(100, 30);
            this.btn_fechar.TabIndex = 11;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // tb_nf
            // 
            this.tb_nf.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nf.Location = new System.Drawing.Point(24, 41);
            this.tb_nf.MaxLength = 10;
            this.tb_nf.Name = "tb_nf";
            this.tb_nf.Size = new System.Drawing.Size(100, 21);
            this.tb_nf.TabIndex = 1;
            this.tb_nf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // lbl_nf
            // 
            this.lbl_nf.AutoSize = true;
            this.lbl_nf.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nf.Location = new System.Drawing.Point(21, 25);
            this.lbl_nf.Name = "lbl_nf";
            this.lbl_nf.Size = new System.Drawing.Size(73, 13);
            this.lbl_nf.TabIndex = 72;
            this.lbl_nf.Text = "Nota Fiscal:";
            // 
            // lbl_acresc
            // 
            this.lbl_acresc.AutoSize = true;
            this.lbl_acresc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acresc.Location = new System.Drawing.Point(233, 25);
            this.lbl_acresc.Name = "lbl_acresc";
            this.lbl_acresc.Size = new System.Drawing.Size(71, 13);
            this.lbl_acresc.TabIndex = 74;
            this.lbl_acresc.Text = "Acréscimo:";
            // 
            // tb_acresc
            // 
            this.tb_acresc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_acresc.Location = new System.Drawing.Point(236, 41);
            this.tb_acresc.MaxLength = 10;
            this.tb_acresc.Name = "tb_acresc";
            this.tb_acresc.Size = new System.Drawing.Size(100, 21);
            this.tb_acresc.TabIndex = 3;
            this.tb_acresc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valor_KeyPress);
            this.tb_acresc.Leave += new System.EventHandler(this.Valor_Leave);
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.Location = new System.Drawing.Point(339, 25);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(65, 13);
            this.lbl_desc.TabIndex = 76;
            this.lbl_desc.Text = "Desconto:";
            // 
            // tb_desc
            // 
            this.tb_desc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_desc.Location = new System.Drawing.Point(342, 41);
            this.tb_desc.MaxLength = 10;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(100, 21);
            this.tb_desc.TabIndex = 4;
            this.tb_desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valor_KeyPress);
            this.tb_desc.Leave += new System.EventHandler(this.Valor_Leave);
            // 
            // tb_obs
            // 
            this.tb_obs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_obs.Location = new System.Drawing.Point(236, 86);
            this.tb_obs.MaxLength = 300;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(528, 21);
            this.tb_obs.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Observação:";
            // 
            // Frm_Gerar_Parcelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 174);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.lbl_acresc);
            this.Controls.Add(this.tb_acresc);
            this.Controls.Add(this.tb_nf);
            this.Controls.Add(this.lbl_nf);
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
        private System.Windows.Forms.TextBox tb_nf;
        private System.Windows.Forms.Label lbl_nf;
        private System.Windows.Forms.Label lbl_acresc;
        private System.Windows.Forms.TextBox tb_acresc;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.Label label1;
    }
}