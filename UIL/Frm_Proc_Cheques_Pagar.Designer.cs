namespace UIL
{
    partial class Frm_Proc_Cheques_Pagar
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
            this.gb_proc_cheque = new System.Windows.Forms.GroupBox();
            this.tb_igual = new System.Windows.Forms.TextBox();
            this.lbl_final = new System.Windows.Forms.Label();
            this.tb_final = new System.Windows.Forms.MaskedTextBox();
            this.tb_inicio = new System.Windows.Forms.MaskedTextBox();
            this.lbl_igual = new System.Windows.Forms.Label();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.dvg_cheque = new System.Windows.Forms.DataGridView();
            this.CHP_CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHP_CARNE_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHP_CONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHP_EMISSAO_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHP_VENC_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHP_VALOR_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_criterio = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_proc_cheque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_cheque)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_proc_cheque
            // 
            this.gb_proc_cheque.Controls.Add(this.tb_igual);
            this.gb_proc_cheque.Controls.Add(this.lbl_final);
            this.gb_proc_cheque.Controls.Add(this.tb_final);
            this.gb_proc_cheque.Controls.Add(this.tb_inicio);
            this.gb_proc_cheque.Controls.Add(this.lbl_igual);
            this.gb_proc_cheque.Controls.Add(this.btn_cadastro);
            this.gb_proc_cheque.Controls.Add(this.dvg_cheque);
            this.gb_proc_cheque.Controls.Add(this.cb_criterio);
            this.gb_proc_cheque.Controls.Add(this.label12);
            this.gb_proc_cheque.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_proc_cheque.Location = new System.Drawing.Point(34, 91);
            this.gb_proc_cheque.Name = "gb_proc_cheque";
            this.gb_proc_cheque.Size = new System.Drawing.Size(1000, 447);
            this.gb_proc_cheque.TabIndex = 82;
            this.gb_proc_cheque.TabStop = false;
            this.gb_proc_cheque.Text = "Pesquisa:";
            // 
            // tb_igual
            // 
            this.tb_igual.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_igual.Location = new System.Drawing.Point(202, 41);
            this.tb_igual.Name = "tb_igual";
            this.tb_igual.Size = new System.Drawing.Size(237, 21);
            this.tb_igual.TabIndex = 2;
            this.tb_igual.TextChanged += new System.EventHandler(this.tb_igual_TextChanged);
            // 
            // lbl_final
            // 
            this.lbl_final.AutoSize = true;
            this.lbl_final.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_final.Location = new System.Drawing.Point(326, 25);
            this.lbl_final.Name = "lbl_final";
            this.lbl_final.Size = new System.Drawing.Size(38, 13);
            this.lbl_final.TabIndex = 88;
            this.lbl_final.Text = "Final:";
            this.lbl_final.Visible = false;
            // 
            // tb_final
            // 
            this.tb_final.Location = new System.Drawing.Point(329, 41);
            this.tb_final.Mask = "00/00/0000";
            this.tb_final.Name = "tb_final";
            this.tb_final.Size = new System.Drawing.Size(110, 21);
            this.tb_final.TabIndex = 3;
            this.tb_final.ValidatingType = typeof(System.DateTime);
            this.tb_final.Visible = false;
            this.tb_final.Leave += new System.EventHandler(this.tb_final_Leave);
            // 
            // tb_inicio
            // 
            this.tb_inicio.Location = new System.Drawing.Point(202, 41);
            this.tb_inicio.Mask = "00/00/0000";
            this.tb_inicio.Name = "tb_inicio";
            this.tb_inicio.Size = new System.Drawing.Size(110, 21);
            this.tb_inicio.TabIndex = 2;
            this.tb_inicio.ValidatingType = typeof(System.DateTime);
            this.tb_inicio.Visible = false;
            this.tb_inicio.Leave += new System.EventHandler(this.tb_inicio_Leave);
            // 
            // lbl_igual
            // 
            this.lbl_igual.AutoSize = true;
            this.lbl_igual.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_igual.Location = new System.Drawing.Point(199, 25);
            this.lbl_igual.Name = "lbl_igual";
            this.lbl_igual.Size = new System.Drawing.Size(52, 13);
            this.lbl_igual.TabIndex = 87;
            this.lbl_igual.Text = "Igual a:";
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro.Location = new System.Drawing.Point(471, 35);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(100, 30);
            this.btn_cadastro.TabIndex = 4;
            this.btn_cadastro.Text = "Cadastro";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // dvg_cheque
            // 
            this.dvg_cheque.AllowUserToAddRows = false;
            this.dvg_cheque.AllowUserToDeleteRows = false;
            this.dvg_cheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_cheque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHP_CODIGO,
            this.CHP_CARNE_FORMATADO,
            this.CHP_CONTA,
            this.CHP_EMISSAO_FORMATADO,
            this.CHP_VENC_FORMATADO,
            this.CHP_VALOR_FORMATADO});
            this.dvg_cheque.Location = new System.Drawing.Point(24, 83);
            this.dvg_cheque.MultiSelect = false;
            this.dvg_cheque.Name = "dvg_cheque";
            this.dvg_cheque.RowHeadersVisible = false;
            this.dvg_cheque.Size = new System.Drawing.Size(900, 348);
            this.dvg_cheque.TabIndex = 5;
            this.dvg_cheque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_cheque_CellClick);
            // 
            // CHP_CODIGO
            // 
            this.CHP_CODIGO.DataPropertyName = "CHP_CODIGO";
            this.CHP_CODIGO.HeaderText = "Código";
            this.CHP_CODIGO.Name = "CHP_CODIGO";
            this.CHP_CODIGO.Width = 120;
            // 
            // CHP_CARNE_FORMATADO
            // 
            this.CHP_CARNE_FORMATADO.DataPropertyName = "CHP_CARNE_FORMATADO";
            this.CHP_CARNE_FORMATADO.HeaderText = "Carnê";
            this.CHP_CARNE_FORMATADO.Name = "CHP_CARNE_FORMATADO";
            this.CHP_CARNE_FORMATADO.Width = 120;
            // 
            // CHP_CONTA
            // 
            this.CHP_CONTA.DataPropertyName = "CHP_CONTA";
            this.CHP_CONTA.HeaderText = "Conta";
            this.CHP_CONTA.Name = "CHP_CONTA";
            this.CHP_CONTA.Width = 120;
            // 
            // CHP_EMISSAO_FORMATADO
            // 
            this.CHP_EMISSAO_FORMATADO.DataPropertyName = "CHP_EMISSAO_FORMATADO";
            this.CHP_EMISSAO_FORMATADO.HeaderText = "Emissão";
            this.CHP_EMISSAO_FORMATADO.Name = "CHP_EMISSAO_FORMATADO";
            this.CHP_EMISSAO_FORMATADO.Width = 150;
            // 
            // CHP_VENC_FORMATADO
            // 
            this.CHP_VENC_FORMATADO.DataPropertyName = "CHP_VENC_FORMATADO";
            this.CHP_VENC_FORMATADO.HeaderText = "Vencimento";
            this.CHP_VENC_FORMATADO.Name = "CHP_VENC_FORMATADO";
            this.CHP_VENC_FORMATADO.Width = 150;
            // 
            // CHP_VALOR_FORMATADO
            // 
            this.CHP_VALOR_FORMATADO.DataPropertyName = "CHP_VALOR_FORMATADO";
            this.CHP_VALOR_FORMATADO.HeaderText = "Valor";
            this.CHP_VALOR_FORMATADO.Name = "CHP_VALOR_FORMATADO";
            this.CHP_VALOR_FORMATADO.Width = 150;
            // 
            // cb_criterio
            // 
            this.cb_criterio.DisplayMember = "1";
            this.cb_criterio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_criterio.FormattingEnabled = true;
            this.cb_criterio.Items.AddRange(new object[] {
            "Código",
            "Carnê",
            "Núm. Documento",
            "Emissão",
            "Vencimento",
            "Efetivação"});
            this.cb_criterio.Location = new System.Drawing.Point(24, 41);
            this.cb_criterio.Name = "cb_criterio";
            this.cb_criterio.Size = new System.Drawing.Size(168, 21);
            this.cb_criterio.TabIndex = 1;
            this.cb_criterio.SelectedIndexChanged += new System.EventHandler(this.cb_criterio_SelectedIndexChanged);
            this.cb_criterio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Critério:";
            // 
            // Frm_Proc_Cheques_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.gb_proc_cheque);
            this.Name = "Frm_Proc_Cheques_Pagar";
            this.Text = "Frm_Proc_Cheques_Pagar";
            this.Controls.SetChildIndex(this.gb_proc_cheque, 0);
            this.gb_proc_cheque.ResumeLayout(false);
            this.gb_proc_cheque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_cheque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_proc_cheque;
        private System.Windows.Forms.TextBox tb_igual;
        private System.Windows.Forms.Label lbl_final;
        private System.Windows.Forms.MaskedTextBox tb_final;
        private System.Windows.Forms.MaskedTextBox tb_inicio;
        private System.Windows.Forms.Label lbl_igual;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.DataGridView dvg_cheque;
        private System.Windows.Forms.ComboBox cb_criterio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHP_CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHP_CARNE_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHP_CONTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHP_EMISSAO_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHP_VENC_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHP_VALOR_FORMATADO;
    }
}