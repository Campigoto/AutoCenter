﻿namespace UIL
{
    partial class FrmProdutos
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
            this.gb_produto = new System.Windows.Forms.GroupBox();
            this.cb_unidade = new System.Windows.Forms.ComboBox();
            this.tb_precocompra = new System.Windows.Forms.MaskedTextBox();
            this.tb_ulltimacompra = new System.Windows.Forms.MaskedTextBox();
            this.tb_estoqueatual = new System.Windows.Forms.MaskedTextBox();
            this.tb_estoqueminimo = new System.Windows.Forms.MaskedTextBox();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_subgrupo = new System.Windows.Forms.ComboBox();
            this.cb_grupo = new System.Windows.Forms.ComboBox();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.tb_referencia = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_produto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_produto
            // 
            this.gb_produto.Controls.Add(this.cb_unidade);
            this.gb_produto.Controls.Add(this.tb_precocompra);
            this.gb_produto.Controls.Add(this.tb_ulltimacompra);
            this.gb_produto.Controls.Add(this.tb_estoqueatual);
            this.gb_produto.Controls.Add(this.tb_estoqueminimo);
            this.gb_produto.Controls.Add(this.btn_pesquisa);
            this.gb_produto.Controls.Add(this.btnlimpar);
            this.gb_produto.Controls.Add(this.btncancelar);
            this.gb_produto.Controls.Add(this.btngravar);
            this.gb_produto.Controls.Add(this.cb_status);
            this.gb_produto.Controls.Add(this.cb_subgrupo);
            this.gb_produto.Controls.Add(this.cb_grupo);
            this.gb_produto.Controls.Add(this.tb_obs);
            this.gb_produto.Controls.Add(this.tb_referencia);
            this.gb_produto.Controls.Add(this.tb_nome);
            this.gb_produto.Controls.Add(this.tb_codigo);
            this.gb_produto.Controls.Add(this.label12);
            this.gb_produto.Controls.Add(this.label11);
            this.gb_produto.Controls.Add(this.label10);
            this.gb_produto.Controls.Add(this.label9);
            this.gb_produto.Controls.Add(this.label8);
            this.gb_produto.Controls.Add(this.label7);
            this.gb_produto.Controls.Add(this.label6);
            this.gb_produto.Controls.Add(this.label5);
            this.gb_produto.Controls.Add(this.label4);
            this.gb_produto.Controls.Add(this.label3);
            this.gb_produto.Controls.Add(this.label2);
            this.gb_produto.Controls.Add(this.label1);
            this.gb_produto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_produto.Location = new System.Drawing.Point(12, 88);
            this.gb_produto.Name = "gb_produto";
            this.gb_produto.Size = new System.Drawing.Size(1029, 439);
            this.gb_produto.TabIndex = 13;
            this.gb_produto.TabStop = false;
            this.gb_produto.Text = "Cadastro:";
            // 
            // cb_unidade
            // 
            this.cb_unidade.FormattingEnabled = true;
            this.cb_unidade.ItemHeight = 13;
            this.cb_unidade.Items.AddRange(new object[] {
            "",
            "BD",
            "CX",
            "DO",
            "DZ",
            "GF",
            "KG",
            "L",
            "LT",
            "MÇ",
            "PT",
            "UN"});
            this.cb_unidade.Location = new System.Drawing.Point(473, 100);
            this.cb_unidade.Name = "cb_unidade";
            this.cb_unidade.Size = new System.Drawing.Size(124, 21);
            this.cb_unidade.TabIndex = 6;
            // 
            // tb_precocompra
            // 
            this.tb_precocompra.Location = new System.Drawing.Point(16, 154);
            this.tb_precocompra.Name = "tb_precocompra";
            this.tb_precocompra.Size = new System.Drawing.Size(133, 21);
            this.tb_precocompra.TabIndex = 8;
            this.tb_precocompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_precocompra.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tb_ulltimacompra
            // 
            this.tb_ulltimacompra.Enabled = false;
            this.tb_ulltimacompra.Location = new System.Drawing.Point(308, 154);
            this.tb_ulltimacompra.Name = "tb_ulltimacompra";
            this.tb_ulltimacompra.Size = new System.Drawing.Size(100, 21);
            this.tb_ulltimacompra.TabIndex = 10;
            this.tb_ulltimacompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_ulltimacompra.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tb_ulltimacompra.ValidatingType = typeof(System.DateTime);
            // 
            // tb_estoqueatual
            // 
            this.tb_estoqueatual.Enabled = false;
            this.tb_estoqueatual.Location = new System.Drawing.Point(441, 154);
            this.tb_estoqueatual.Name = "tb_estoqueatual";
            this.tb_estoqueatual.Size = new System.Drawing.Size(100, 21);
            this.tb_estoqueatual.TabIndex = 11;
            this.tb_estoqueatual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_estoqueatual.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tb_estoqueminimo
            // 
            this.tb_estoqueminimo.Location = new System.Drawing.Point(174, 154);
            this.tb_estoqueminimo.Name = "tb_estoqueminimo";
            this.tb_estoqueminimo.Size = new System.Drawing.Size(100, 21);
            this.tb_estoqueminimo.TabIndex = 9;
            this.tb_estoqueminimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_estoqueminimo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Location = new System.Drawing.Point(520, 393);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(100, 30);
            this.btn_pesquisa.TabIndex = 15;
            this.btn_pesquisa.Text = "Pesquisa";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(414, 393);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(100, 30);
            this.btnlimpar.TabIndex = 14;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(626, 393);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 30);
            this.btncancelar.TabIndex = 16;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Visible = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(308, 393);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(100, 30);
            this.btngravar.TabIndex = 13;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.ItemHeight = 13;
            this.cb_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cb_status.Location = new System.Drawing.Point(732, 52);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(106, 21);
            this.cb_status.TabIndex = 3;
            this.cb_status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codigo_KeyPress);
            // 
            // cb_subgrupo
            // 
            this.cb_subgrupo.FormattingEnabled = true;
            this.cb_subgrupo.Location = new System.Drawing.Point(242, 100);
            this.cb_subgrupo.Name = "cb_subgrupo";
            this.cb_subgrupo.Size = new System.Drawing.Size(203, 21);
            this.cb_subgrupo.TabIndex = 5;
            this.cb_subgrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codigo_KeyPress);
            // 
            // cb_grupo
            // 
            this.cb_grupo.FormattingEnabled = true;
            this.cb_grupo.Location = new System.Drawing.Point(16, 100);
            this.cb_grupo.Name = "cb_grupo";
            this.cb_grupo.Size = new System.Drawing.Size(203, 21);
            this.cb_grupo.TabIndex = 4;
            this.cb_grupo.SelectedValueChanged += new System.EventHandler(this.cb_grupo_SelectedValueChanged);
            this.cb_grupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codigo_KeyPress);
            // 
            // tb_obs
            // 
            this.tb_obs.Location = new System.Drawing.Point(16, 205);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(867, 162);
            this.tb_obs.TabIndex = 12;
            // 
            // tb_referencia
            // 
            this.tb_referencia.Location = new System.Drawing.Point(620, 100);
            this.tb_referencia.Name = "tb_referencia";
            this.tb_referencia.Size = new System.Drawing.Size(106, 21);
            this.tb_referencia.TabIndex = 7;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(138, 52);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(566, 21);
            this.tb_nome.TabIndex = 2;
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(16, 52);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(100, 21);
            this.tb_codigo.TabIndex = 1;
            this.tb_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.tb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codigo_KeyPress);
            this.tb_codigo.Leave += new System.EventHandler(this.tb_codigo_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(438, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Estoque Atual:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Observação:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Última Compra:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Estoque Mínimo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Preço de Compra:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Referência:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Unidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(729, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sub Grupo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Grupo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.gb_produto);
            this.Name = "FrmProdutos";
            this.Text = "FrmProdutos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProdutos_FormClosing);
            this.Controls.SetChildIndex(this.gb_produto, 0);
            this.gb_produto.ResumeLayout(false);
            this.gb_produto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_produto;
        private System.Windows.Forms.ComboBox cb_grupo;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.TextBox tb_referencia;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_subgrupo;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.MaskedTextBox tb_ulltimacompra;
        private System.Windows.Forms.MaskedTextBox tb_estoqueatual;
        private System.Windows.Forms.MaskedTextBox tb_estoqueminimo;
        private System.Windows.Forms.MaskedTextBox tb_precocompra;
        private System.Windows.Forms.ComboBox cb_unidade;
    }
}