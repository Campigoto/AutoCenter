namespace UIL
{
    partial class Frm_Rel_GrupoProdtoXFornecedor
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
            this.gb_produtoXfornecedor = new System.Windows.Forms.GroupBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.cb_grupo = new System.Windows.Forms.ComboBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_final = new System.Windows.Forms.Label();
            this.tb_final = new System.Windows.Forms.MaskedTextBox();
            this.tb_inicio = new System.Windows.Forms.MaskedTextBox();
            this.lbl_igual = new System.Windows.Forms.Label();
            this.gb_produtoXfornecedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_produtoXfornecedor
            // 
            this.gb_produtoXfornecedor.Controls.Add(this.btn_confirmar);
            this.gb_produtoXfornecedor.Controls.Add(this.cb_grupo);
            this.gb_produtoXfornecedor.Controls.Add(this.lbl_tipo);
            this.gb_produtoXfornecedor.Controls.Add(this.lbl_final);
            this.gb_produtoXfornecedor.Controls.Add(this.tb_final);
            this.gb_produtoXfornecedor.Controls.Add(this.tb_inicio);
            this.gb_produtoXfornecedor.Controls.Add(this.lbl_igual);
            this.gb_produtoXfornecedor.Location = new System.Drawing.Point(37, 90);
            this.gb_produtoXfornecedor.Name = "gb_produtoXfornecedor";
            this.gb_produtoXfornecedor.Size = new System.Drawing.Size(1019, 409);
            this.gb_produtoXfornecedor.TabIndex = 14;
            this.gb_produtoXfornecedor.TabStop = false;
            this.gb_produtoXfornecedor.Text = "Relatório Grupo de Produto X Fornecedor";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.Location = new System.Drawing.Point(453, 309);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(100, 30);
            this.btn_confirmar.TabIndex = 106;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // cb_grupo
            // 
            this.cb_grupo.DisplayMember = "GRP_NOME";
            this.cb_grupo.FormattingEnabled = true;
            this.cb_grupo.Location = new System.Drawing.Point(326, 187);
            this.cb_grupo.Name = "cb_grupo";
            this.cb_grupo.Size = new System.Drawing.Size(369, 21);
            this.cb_grupo.TabIndex = 99;
            this.cb_grupo.ValueMember = "GRP_CODIGO";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(323, 171);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(117, 13);
            this.lbl_tipo.TabIndex = 105;
            this.lbl_tipo.Text = "Selecione o Grupo:";
            // 
            // lbl_final
            // 
            this.lbl_final.AutoSize = true;
            this.lbl_final.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_final.Location = new System.Drawing.Point(450, 112);
            this.lbl_final.Name = "lbl_final";
            this.lbl_final.Size = new System.Drawing.Size(38, 13);
            this.lbl_final.TabIndex = 104;
            this.lbl_final.Text = "Final:";
            // 
            // tb_final
            // 
            this.tb_final.Location = new System.Drawing.Point(453, 128);
            this.tb_final.Mask = "00/00/0000";
            this.tb_final.Name = "tb_final";
            this.tb_final.Size = new System.Drawing.Size(110, 20);
            this.tb_final.TabIndex = 98;
            this.tb_final.ValidatingType = typeof(System.DateTime);
            // 
            // tb_inicio
            // 
            this.tb_inicio.Location = new System.Drawing.Point(326, 128);
            this.tb_inicio.Mask = "00/00/0000";
            this.tb_inicio.Name = "tb_inicio";
            this.tb_inicio.Size = new System.Drawing.Size(110, 20);
            this.tb_inicio.TabIndex = 97;
            this.tb_inicio.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_igual
            // 
            this.lbl_igual.AutoSize = true;
            this.lbl_igual.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_igual.Location = new System.Drawing.Point(323, 112);
            this.lbl_igual.Name = "lbl_igual";
            this.lbl_igual.Size = new System.Drawing.Size(43, 13);
            this.lbl_igual.TabIndex = 103;
            this.lbl_igual.Text = "Início:";
            // 
            // Frm_Rel_GrupoProdtoXFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.gb_produtoXfornecedor);
            this.Name = "Frm_Rel_GrupoProdtoXFornecedor";
            this.Text = "Frm_Rel_GrupoProdtoXFornecedor";
            this.Controls.SetChildIndex(this.gb_produtoXfornecedor, 0);
            this.gb_produtoXfornecedor.ResumeLayout(false);
            this.gb_produtoXfornecedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_produtoXfornecedor;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.ComboBox cb_grupo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_final;
        private System.Windows.Forms.MaskedTextBox tb_final;
        private System.Windows.Forms.MaskedTextBox tb_inicio;
        private System.Windows.Forms.Label lbl_igual;

    }
}