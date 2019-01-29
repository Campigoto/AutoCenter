namespace UIL
{
    partial class Frm_Proc_Contas_Pagar
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
            this.tb_igual = new System.Windows.Forms.TextBox();
            this.lbl_final = new System.Windows.Forms.Label();
            this.tb_final = new System.Windows.Forms.MaskedTextBox();
            this.tb_inicio = new System.Windows.Forms.MaskedTextBox();
            this.lbl_igual = new System.Windows.Forms.Label();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.dvg_contas_pagar = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Médico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAP_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_criterio = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_proc_contas_pagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_contas_pagar)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_proc_contas_pagar
            // 
            this.gb_proc_contas_pagar.Controls.Add(this.tb_igual);
            this.gb_proc_contas_pagar.Controls.Add(this.lbl_final);
            this.gb_proc_contas_pagar.Controls.Add(this.tb_final);
            this.gb_proc_contas_pagar.Controls.Add(this.tb_inicio);
            this.gb_proc_contas_pagar.Controls.Add(this.lbl_igual);
            this.gb_proc_contas_pagar.Controls.Add(this.btn_cadastro);
            this.gb_proc_contas_pagar.Controls.Add(this.dvg_contas_pagar);
            this.gb_proc_contas_pagar.Controls.Add(this.cb_criterio);
            this.gb_proc_contas_pagar.Controls.Add(this.label12);
            this.gb_proc_contas_pagar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_proc_contas_pagar.Location = new System.Drawing.Point(34, 91);
            this.gb_proc_contas_pagar.Name = "gb_proc_contas_pagar";
            this.gb_proc_contas_pagar.Size = new System.Drawing.Size(1000, 447);
            this.gb_proc_contas_pagar.TabIndex = 81;
            this.gb_proc_contas_pagar.TabStop = false;
            this.gb_proc_contas_pagar.Text = "Pesquisa:";
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
            // dvg_contas_pagar
            // 
            this.dvg_contas_pagar.AllowUserToAddRows = false;
            this.dvg_contas_pagar.AllowUserToDeleteRows = false;
            this.dvg_contas_pagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_contas_pagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Descrição,
            this.Médico,
            this.CAP_TOTAL,
            this.Celular});
            this.dvg_contas_pagar.Location = new System.Drawing.Point(24, 83);
            this.dvg_contas_pagar.MultiSelect = false;
            this.dvg_contas_pagar.Name = "dvg_contas_pagar";
            this.dvg_contas_pagar.RowHeadersVisible = false;
            this.dvg_contas_pagar.Size = new System.Drawing.Size(900, 348);
            this.dvg_contas_pagar.TabIndex = 5;
            this.dvg_contas_pagar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_contas_pagar_CellClick);
            // 
            // Código
            // 
            this.Código.DataPropertyName = "CAP_CODIGO";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Width = 120;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "CAP_COMPRA_FORMATADO";
            this.Descrição.HeaderText = "Compra";
            this.Descrição.Name = "Descrição";
            this.Descrição.Width = 120;
            // 
            // Médico
            // 
            this.Médico.DataPropertyName = "FOR_NOME";
            this.Médico.HeaderText = "Fornecedor";
            this.Médico.Name = "Médico";
            this.Médico.Width = 350;
            // 
            // CAP_TOTAL
            // 
            this.CAP_TOTAL.DataPropertyName = "CAP_TOTAL_FORMATADO";
            this.CAP_TOTAL.HeaderText = "Total";
            this.CAP_TOTAL.Name = "CAP_TOTAL";
            this.CAP_TOTAL.Width = 150;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "CAP_CADASTRO";
            this.Celular.HeaderText = "Data";
            this.Celular.Name = "Celular";
            this.Celular.Width = 150;
            // 
            // cb_criterio
            // 
            this.cb_criterio.DisplayMember = "1";
            this.cb_criterio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_criterio.FormattingEnabled = true;
            this.cb_criterio.Items.AddRange(new object[] {
            "Código",
            "Compra",
            "Fornecedor",
            "Cadastro"});
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
            // Frm_Proc_Contas_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.gb_proc_contas_pagar);
            this.Name = "Frm_Proc_Contas_Pagar";
            this.Text = "Frm_Proc_Contas_Pagar";
            this.Controls.SetChildIndex(this.gb_proc_contas_pagar, 0);
            this.gb_proc_contas_pagar.ResumeLayout(false);
            this.gb_proc_contas_pagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_contas_pagar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_proc_contas_pagar;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.DataGridView dvg_contas_pagar;
        private System.Windows.Forms.ComboBox cb_criterio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_igual;
        private System.Windows.Forms.Label lbl_final;
        private System.Windows.Forms.MaskedTextBox tb_final;
        private System.Windows.Forms.MaskedTextBox tb_inicio;
        private System.Windows.Forms.Label lbl_igual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Médico;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAP_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
    }
}