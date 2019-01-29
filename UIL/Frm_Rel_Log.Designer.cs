namespace UIL
{
    partial class Frm_Rel_Log
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
            this.lbl_funcionario = new System.Windows.Forms.Label();
            this.cb_funcionario = new System.Windows.Forms.ComboBox();
            this.lbl_final = new System.Windows.Forms.Label();
            this.tb_final = new System.Windows.Forms.MaskedTextBox();
            this.tb_inicio = new System.Windows.Forms.MaskedTextBox();
            this.lbl_igual = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.gb_contas_pagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_contas_pagar
            // 
            this.gb_contas_pagar.Controls.Add(this.lbl_separado);
            this.gb_contas_pagar.Controls.Add(this.cb_separado);
            this.gb_contas_pagar.Controls.Add(this.lbl_funcionario);
            this.gb_contas_pagar.Controls.Add(this.cb_funcionario);
            this.gb_contas_pagar.Controls.Add(this.lbl_final);
            this.gb_contas_pagar.Controls.Add(this.tb_final);
            this.gb_contas_pagar.Controls.Add(this.tb_inicio);
            this.gb_contas_pagar.Controls.Add(this.lbl_igual);
            this.gb_contas_pagar.Controls.Add(this.btn_confirmar);
            this.gb_contas_pagar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_contas_pagar.Location = new System.Drawing.Point(30, 90);
            this.gb_contas_pagar.Name = "gb_contas_pagar";
            this.gb_contas_pagar.Size = new System.Drawing.Size(1000, 460);
            this.gb_contas_pagar.TabIndex = 24;
            this.gb_contas_pagar.TabStop = false;
            this.gb_contas_pagar.Text = "Relatório:";
            // 
            // lbl_separado
            // 
            this.lbl_separado.AutoSize = true;
            this.lbl_separado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_separado.Location = new System.Drawing.Point(41, 169);
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
            "Data",
            "Tela",
            "Funcionário"});
            this.cb_separado.Location = new System.Drawing.Point(44, 185);
            this.cb_separado.Name = "cb_separado";
            this.cb_separado.Size = new System.Drawing.Size(369, 21);
            this.cb_separado.TabIndex = 99;
            this.cb_separado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // lbl_funcionario
            // 
            this.lbl_funcionario.AutoSize = true;
            this.lbl_funcionario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_funcionario.Location = new System.Drawing.Point(41, 105);
            this.lbl_funcionario.Name = "lbl_funcionario";
            this.lbl_funcionario.Size = new System.Drawing.Size(77, 13);
            this.lbl_funcionario.TabIndex = 95;
            this.lbl_funcionario.Text = "Funcionário:";
            // 
            // cb_funcionario
            // 
            this.cb_funcionario.DisplayMember = "FUN_NOME";
            this.cb_funcionario.FormattingEnabled = true;
            this.cb_funcionario.Items.AddRange(new object[] {
            "Todos",
            "Manual",
            "Compra"});
            this.cb_funcionario.Location = new System.Drawing.Point(44, 121);
            this.cb_funcionario.Name = "cb_funcionario";
            this.cb_funcionario.Size = new System.Drawing.Size(369, 21);
            this.cb_funcionario.TabIndex = 6;
            this.cb_funcionario.ValueMember = "FUN_CODIGO";
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
            // Frm_Rel_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.gb_contas_pagar);
            this.Name = "Frm_Rel_Log";
            this.Text = "Frm_Rel_Log";
            this.Controls.SetChildIndex(this.gb_contas_pagar, 0);
            this.gb_contas_pagar.ResumeLayout(false);
            this.gb_contas_pagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_contas_pagar;
        private System.Windows.Forms.Label lbl_separado;
        private System.Windows.Forms.ComboBox cb_separado;
        private System.Windows.Forms.Label lbl_funcionario;
        private System.Windows.Forms.ComboBox cb_funcionario;
        private System.Windows.Forms.Label lbl_final;
        private System.Windows.Forms.MaskedTextBox tb_final;
        private System.Windows.Forms.MaskedTextBox tb_inicio;
        private System.Windows.Forms.Label lbl_igual;
        private System.Windows.Forms.Button btn_confirmar;
    }
}