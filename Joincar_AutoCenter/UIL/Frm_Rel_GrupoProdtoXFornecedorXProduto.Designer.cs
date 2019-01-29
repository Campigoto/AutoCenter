namespace UIL
{
    partial class Frm_Rel_GrupoProdtoXFornecedorXProduto
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
            this.gb_grupoXfornecedorXproduto = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_grupo = new System.Windows.Forms.ComboBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.cb_produto = new System.Windows.Forms.ComboBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.cb_fornecedor = new System.Windows.Forms.ComboBox();
            this.lbl_fornecedor = new System.Windows.Forms.Label();
            this.lbl_final = new System.Windows.Forms.Label();
            this.tb_final = new System.Windows.Forms.MaskedTextBox();
            this.tb_inicio = new System.Windows.Forms.MaskedTextBox();
            this.lbl_igual = new System.Windows.Forms.Label();
            this.gb_grupoXfornecedorXproduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_grupoXfornecedorXproduto
            // 
            this.gb_grupoXfornecedorXproduto.Controls.Add(this.lbl_final);
            this.gb_grupoXfornecedorXproduto.Controls.Add(this.tb_final);
            this.gb_grupoXfornecedorXproduto.Controls.Add(this.tb_inicio);
            this.gb_grupoXfornecedorXproduto.Controls.Add(this.lbl_igual);
            this.gb_grupoXfornecedorXproduto.Controls.Add(this.label3);
            this.gb_grupoXfornecedorXproduto.Controls.Add(this.cb_grupo);
            this.gb_grupoXfornecedorXproduto.Controls.Add(this.btn_confirmar);
            this.gb_grupoXfornecedorXproduto.Controls.Add(this.cb_produto);
            this.gb_grupoXfornecedorXproduto.Controls.Add(this.lbl_tipo);
            this.gb_grupoXfornecedorXproduto.Controls.Add(this.cb_fornecedor);
            this.gb_grupoXfornecedorXproduto.Controls.Add(this.lbl_fornecedor);
            this.gb_grupoXfornecedorXproduto.Location = new System.Drawing.Point(25, 77);
            this.gb_grupoXfornecedorXproduto.Name = "gb_grupoXfornecedorXproduto";
            this.gb_grupoXfornecedorXproduto.Size = new System.Drawing.Size(1019, 409);
            this.gb_grupoXfornecedorXproduto.TabIndex = 14;
            this.gb_grupoXfornecedorXproduto.TabStop = false;
            this.gb_grupoXfornecedorXproduto.Text = "Relatório Grupo X Fornecedor X Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Grupo";
            // 
            // cb_grupo
            // 
            this.cb_grupo.FormattingEnabled = true;
            this.cb_grupo.Location = new System.Drawing.Point(325, 147);
            this.cb_grupo.Name = "cb_grupo";
            this.cb_grupo.Size = new System.Drawing.Size(121, 21);
            this.cb_grupo.TabIndex = 107;
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
            // cb_produto
            // 
            this.cb_produto.DisplayMember = "PRO_NOME";
            this.cb_produto.FormattingEnabled = true;
            this.cb_produto.Location = new System.Drawing.Point(325, 258);
            this.cb_produto.Name = "cb_produto";
            this.cb_produto.Size = new System.Drawing.Size(369, 21);
            this.cb_produto.TabIndex = 99;
            this.cb_produto.ValueMember = "PRO_CODIGO";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(322, 242);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(56, 13);
            this.lbl_tipo.TabIndex = 105;
            this.lbl_tipo.Text = "Produto:";
            // 
            // cb_fornecedor
            // 
            this.cb_fornecedor.DisplayMember = "FOR_NOME";
            this.cb_fornecedor.FormattingEnabled = true;
            this.cb_fornecedor.Location = new System.Drawing.Point(325, 201);
            this.cb_fornecedor.Name = "cb_fornecedor";
            this.cb_fornecedor.Size = new System.Drawing.Size(369, 21);
            this.cb_fornecedor.TabIndex = 100;
            this.cb_fornecedor.ValueMember = "FOR_CODIGO";
            // 
            // lbl_fornecedor
            // 
            this.lbl_fornecedor.AutoSize = true;
            this.lbl_fornecedor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fornecedor.Location = new System.Drawing.Point(322, 185);
            this.lbl_fornecedor.Name = "lbl_fornecedor";
            this.lbl_fornecedor.Size = new System.Drawing.Size(76, 13);
            this.lbl_fornecedor.TabIndex = 101;
            this.lbl_fornecedor.Text = "Fornecedor:";
            // 
            // lbl_final
            // 
            this.lbl_final.AutoSize = true;
            this.lbl_final.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_final.Location = new System.Drawing.Point(449, 80);
            this.lbl_final.Name = "lbl_final";
            this.lbl_final.Size = new System.Drawing.Size(38, 13);
            this.lbl_final.TabIndex = 112;
            this.lbl_final.Text = "Final:";
            // 
            // tb_final
            // 
            this.tb_final.Location = new System.Drawing.Point(452, 96);
            this.tb_final.Mask = "00/00/0000";
            this.tb_final.Name = "tb_final";
            this.tb_final.Size = new System.Drawing.Size(110, 20);
            this.tb_final.TabIndex = 110;
            this.tb_final.ValidatingType = typeof(System.DateTime);
            // 
            // tb_inicio
            // 
            this.tb_inicio.Location = new System.Drawing.Point(325, 96);
            this.tb_inicio.Mask = "00/00/0000";
            this.tb_inicio.Name = "tb_inicio";
            this.tb_inicio.Size = new System.Drawing.Size(110, 20);
            this.tb_inicio.TabIndex = 109;
            this.tb_inicio.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_igual
            // 
            this.lbl_igual.AutoSize = true;
            this.lbl_igual.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_igual.Location = new System.Drawing.Point(322, 80);
            this.lbl_igual.Name = "lbl_igual";
            this.lbl_igual.Size = new System.Drawing.Size(43, 13);
            this.lbl_igual.TabIndex = 111;
            this.lbl_igual.Text = "Início:";
            // 
            // Frm_Rel_GrupoProdtoXFornecedorXProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.gb_grupoXfornecedorXproduto);
            this.Name = "Frm_Rel_GrupoProdtoXFornecedorXProduto";
            this.Text = "Frm_Rel_GrupoProdtoXFornecedorXProduto";
            this.Controls.SetChildIndex(this.gb_grupoXfornecedorXproduto, 0);
            this.gb_grupoXfornecedorXproduto.ResumeLayout(false);
            this.gb_grupoXfornecedorXproduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_grupoXfornecedorXproduto;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.ComboBox cb_produto;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.ComboBox cb_fornecedor;
        private System.Windows.Forms.Label lbl_fornecedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_grupo;
        private System.Windows.Forms.Label lbl_final;
        private System.Windows.Forms.MaskedTextBox tb_final;
        private System.Windows.Forms.MaskedTextBox tb_inicio;
        private System.Windows.Forms.Label lbl_igual;
    }
}