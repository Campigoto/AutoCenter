namespace UIL
{
    partial class Frm_Pagar_Parcelas
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
            this.rb_nova_parc = new System.Windows.Forms.RadioButton();
            this.rb_completa = new System.Windows.Forms.RadioButton();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.lbl_valor_nova_parc = new System.Windows.Forms.Label();
            this.tb_valor_nova_parc = new System.Windows.Forms.TextBox();
            this.lbl_multa = new System.Windows.Forms.Label();
            this.tb_multa = new System.Windows.Forms.TextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.lbl_obs = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.gb_nova_parc = new System.Windows.Forms.GroupBox();
            this.tb_venc_nova_parc = new System.Windows.Forms.MaskedTextBox();
            this.lbl_tipo_nova_parc = new System.Windows.Forms.Label();
            this.cb_tipo_nova_parc = new System.Windows.Forms.ComboBox();
            this.lbl_venc_nova_parc = new System.Windows.Forms.Label();
            this.gb_nova_parc.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_nova_parc
            // 
            this.rb_nova_parc.AutoSize = true;
            this.rb_nova_parc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_nova_parc.Location = new System.Drawing.Point(26, 55);
            this.rb_nova_parc.Name = "rb_nova_parc";
            this.rb_nova_parc.Size = new System.Drawing.Size(131, 17);
            this.rb_nova_parc.TabIndex = 2;
            this.rb_nova_parc.Text = "Com Nova Parcela";
            this.rb_nova_parc.UseVisualStyleBackColor = true;
            this.rb_nova_parc.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_completa
            // 
            this.rb_completa.AutoSize = true;
            this.rb_completa.Checked = true;
            this.rb_completa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_completa.Location = new System.Drawing.Point(26, 32);
            this.rb_completa.Name = "rb_completa";
            this.rb_completa.Size = new System.Drawing.Size(80, 17);
            this.rb_completa.TabIndex = 1;
            this.rb_completa.TabStop = true;
            this.rb_completa.Text = "Completa";
            this.rb_completa.UseVisualStyleBackColor = true;
            this.rb_completa.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(159, 35);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(74, 13);
            this.lbl_valor.TabIndex = 88;
            this.lbl_valor.Text = "Valor Pago:";
            // 
            // tb_valor
            // 
            this.tb_valor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor.Location = new System.Drawing.Point(162, 51);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 21);
            this.tb_valor.TabIndex = 3;
            this.tb_valor.Leave += new System.EventHandler(this.tb_valor_Leave);
            // 
            // lbl_valor_nova_parc
            // 
            this.lbl_valor_nova_parc.AutoSize = true;
            this.lbl_valor_nova_parc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_nova_parc.Location = new System.Drawing.Point(13, 23);
            this.lbl_valor_nova_parc.Name = "lbl_valor_nova_parc";
            this.lbl_valor_nova_parc.Size = new System.Drawing.Size(42, 13);
            this.lbl_valor_nova_parc.TabIndex = 90;
            this.lbl_valor_nova_parc.Text = "Valor:";
            // 
            // tb_valor_nova_parc
            // 
            this.tb_valor_nova_parc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_nova_parc.Location = new System.Drawing.Point(16, 39);
            this.tb_valor_nova_parc.Name = "tb_valor_nova_parc";
            this.tb_valor_nova_parc.Size = new System.Drawing.Size(105, 21);
            this.tb_valor_nova_parc.TabIndex = 5;
            this.tb_valor_nova_parc.Leave += new System.EventHandler(this.Valor_Leave);
            // 
            // lbl_multa
            // 
            this.lbl_multa.AutoSize = true;
            this.lbl_multa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_multa.Location = new System.Drawing.Point(271, 35);
            this.lbl_multa.Name = "lbl_multa";
            this.lbl_multa.Size = new System.Drawing.Size(42, 13);
            this.lbl_multa.TabIndex = 92;
            this.lbl_multa.Text = "Multa:";
            // 
            // tb_multa
            // 
            this.tb_multa.Enabled = false;
            this.tb_multa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_multa.Location = new System.Drawing.Point(274, 51);
            this.tb_multa.Name = "tb_multa";
            this.tb_multa.Size = new System.Drawing.Size(100, 21);
            this.tb_multa.TabIndex = 4;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.Location = new System.Drawing.Point(532, 180);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(100, 30);
            this.btn_fechar.TabIndex = 10;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.Location = new System.Drawing.Point(426, 180);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(100, 30);
            this.btn_confirmar.TabIndex = 9;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // lbl_obs
            // 
            this.lbl_obs.AutoSize = true;
            this.lbl_obs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obs.Location = new System.Drawing.Point(23, 92);
            this.lbl_obs.Name = "lbl_obs";
            this.lbl_obs.Size = new System.Drawing.Size(80, 13);
            this.lbl_obs.TabIndex = 96;
            this.lbl_obs.Text = "Observação:";
            // 
            // tb_obs
            // 
            this.tb_obs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_obs.Location = new System.Drawing.Point(26, 108);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(724, 53);
            this.tb_obs.TabIndex = 8;
            // 
            // gb_nova_parc
            // 
            this.gb_nova_parc.Controls.Add(this.tb_venc_nova_parc);
            this.gb_nova_parc.Controls.Add(this.lbl_tipo_nova_parc);
            this.gb_nova_parc.Controls.Add(this.cb_tipo_nova_parc);
            this.gb_nova_parc.Controls.Add(this.lbl_venc_nova_parc);
            this.gb_nova_parc.Controls.Add(this.lbl_valor_nova_parc);
            this.gb_nova_parc.Controls.Add(this.tb_valor_nova_parc);
            this.gb_nova_parc.Location = new System.Drawing.Point(389, 12);
            this.gb_nova_parc.Name = "gb_nova_parc";
            this.gb_nova_parc.Size = new System.Drawing.Size(376, 81);
            this.gb_nova_parc.TabIndex = 97;
            this.gb_nova_parc.TabStop = false;
            this.gb_nova_parc.Text = "Nova Parcela:";
            // 
            // tb_venc_nova_parc
            // 
            this.tb_venc_nova_parc.Location = new System.Drawing.Point(261, 39);
            this.tb_venc_nova_parc.Mask = "00/00/0000";
            this.tb_venc_nova_parc.Name = "tb_venc_nova_parc";
            this.tb_venc_nova_parc.Size = new System.Drawing.Size(100, 20);
            this.tb_venc_nova_parc.TabIndex = 7;
            this.tb_venc_nova_parc.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_tipo_nova_parc
            // 
            this.lbl_tipo_nova_parc.AutoSize = true;
            this.lbl_tipo_nova_parc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_nova_parc.Location = new System.Drawing.Point(136, 23);
            this.lbl_tipo_nova_parc.Name = "lbl_tipo_nova_parc";
            this.lbl_tipo_nova_parc.Size = new System.Drawing.Size(36, 13);
            this.lbl_tipo_nova_parc.TabIndex = 93;
            this.lbl_tipo_nova_parc.Text = "Tipo:";
            // 
            // cb_tipo_nova_parc
            // 
            this.cb_tipo_nova_parc.FormattingEnabled = true;
            this.cb_tipo_nova_parc.Items.AddRange(new object[] {
            "",
            "Dinheiro",
            "Crediario",
            "Cheque",
            "Boleto",
            "Financeira"});
            this.cb_tipo_nova_parc.Location = new System.Drawing.Point(139, 39);
            this.cb_tipo_nova_parc.Name = "cb_tipo_nova_parc";
            this.cb_tipo_nova_parc.Size = new System.Drawing.Size(104, 21);
            this.cb_tipo_nova_parc.TabIndex = 6;
            // 
            // lbl_venc_nova_parc
            // 
            this.lbl_venc_nova_parc.AutoSize = true;
            this.lbl_venc_nova_parc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venc_nova_parc.Location = new System.Drawing.Point(258, 23);
            this.lbl_venc_nova_parc.Name = "lbl_venc_nova_parc";
            this.lbl_venc_nova_parc.Size = new System.Drawing.Size(79, 13);
            this.lbl_venc_nova_parc.TabIndex = 91;
            this.lbl_venc_nova_parc.Text = "Vencimento:";
            // 
            // Frm_Pagar_Parcelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 222);
            this.Controls.Add(this.gb_nova_parc);
            this.Controls.Add(this.lbl_obs);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_multa);
            this.Controls.Add(this.tb_multa);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.rb_completa);
            this.Controls.Add(this.rb_nova_parc);
            this.Name = "Frm_Pagar_Parcelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Pagar_Parcelas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Pagar_Parcelas_FormClosing);
            this.gb_nova_parc.ResumeLayout(false);
            this.gb_nova_parc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_nova_parc;
        private System.Windows.Forms.RadioButton rb_completa;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Label lbl_valor_nova_parc;
        private System.Windows.Forms.TextBox tb_valor_nova_parc;
        private System.Windows.Forms.Label lbl_multa;
        private System.Windows.Forms.TextBox tb_multa;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label lbl_obs;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.GroupBox gb_nova_parc;
        private System.Windows.Forms.MaskedTextBox tb_venc_nova_parc;
        private System.Windows.Forms.Label lbl_tipo_nova_parc;
        private System.Windows.Forms.ComboBox cb_tipo_nova_parc;
        private System.Windows.Forms.Label lbl_venc_nova_parc;
    }
}