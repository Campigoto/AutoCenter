namespace UIL
{
    partial class FrmProcProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_produto = new System.Windows.Forms.GroupBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.cb_criterio = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_igual = new System.Windows.Forms.TextBox();
            this.lbl_igual = new System.Windows.Forms.Label();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.dgv_Produtos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_UNIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRECO_COMPRA_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_ESTOQUE_FORMATADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COM_DATA_FORMATADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_produto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_produto
            // 
            this.gb_produto.Controls.Add(this.btn_voltar);
            this.gb_produto.Controls.Add(this.cb_criterio);
            this.gb_produto.Controls.Add(this.label12);
            this.gb_produto.Controls.Add(this.tb_igual);
            this.gb_produto.Controls.Add(this.lbl_igual);
            this.gb_produto.Controls.Add(this.btn_cadastro);
            this.gb_produto.Controls.Add(this.dgv_Produtos);
            this.gb_produto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_produto.Location = new System.Drawing.Point(30, 90);
            this.gb_produto.Name = "gb_produto";
            this.gb_produto.Size = new System.Drawing.Size(1017, 460);
            this.gb_produto.TabIndex = 18;
            this.gb_produto.TabStop = false;
            this.gb_produto.Text = "Pesquisa:";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(780, 42);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(100, 30);
            this.btn_voltar.TabIndex = 78;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // cb_criterio
            // 
            this.cb_criterio.DisplayMember = "1";
            this.cb_criterio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_criterio.FormattingEnabled = true;
            this.cb_criterio.Items.AddRange(new object[] {
            "Código",
            "Nome"});
            this.cb_criterio.Location = new System.Drawing.Point(13, 48);
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
            this.label12.Location = new System.Drawing.Point(10, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 77;
            this.label12.Text = "Critério:";
            // 
            // tb_igual
            // 
            this.tb_igual.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_igual.Location = new System.Drawing.Point(207, 48);
            this.tb_igual.MaxLength = 60;
            this.tb_igual.Name = "tb_igual";
            this.tb_igual.Size = new System.Drawing.Size(441, 21);
            this.tb_igual.TabIndex = 2;
            this.tb_igual.TextChanged += new System.EventHandler(this.tb_igual_TextChanged);
            // 
            // lbl_igual
            // 
            this.lbl_igual.AutoSize = true;
            this.lbl_igual.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_igual.Location = new System.Drawing.Point(204, 32);
            this.lbl_igual.Name = "lbl_igual";
            this.lbl_igual.Size = new System.Drawing.Size(52, 13);
            this.lbl_igual.TabIndex = 37;
            this.lbl_igual.Text = "Igual a:";
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro.Location = new System.Drawing.Point(674, 42);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(100, 30);
            this.btn_cadastro.TabIndex = 3;
            this.btn_cadastro.Text = "Cadastro";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // dgv_Produtos
            // 
            this.dgv_Produtos.AllowUserToAddRows = false;
            this.dgv_Produtos.AllowUserToDeleteRows = false;
            this.dgv_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.Grupo,
            this.SubGrupo,
            this.PRO_UNIDADE,
            this.PRO_PRECO_COMPRA_FORMATADO,
            this.PRO_ESTOQUE_FORMATADO,
            this.COM_DATA_FORMATADA});
            this.dgv_Produtos.Location = new System.Drawing.Point(13, 90);
            this.dgv_Produtos.Name = "dgv_Produtos";
            this.dgv_Produtos.RowHeadersVisible = false;
            this.dgv_Produtos.Size = new System.Drawing.Size(990, 351);
            this.dgv_Produtos.TabIndex = 4;
            this.dgv_Produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Produtos_CellClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "PRO_CODIGO";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Width = 70;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "PRO_NOME";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 250;
            // 
            // Grupo
            // 
            this.Grupo.DataPropertyName = "PRO_GRUPO_GRP_NOME";
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            this.Grupo.Width = 150;
            // 
            // SubGrupo
            // 
            this.SubGrupo.DataPropertyName = "PRO_SUBGRUPO_SGP_NOME";
            this.SubGrupo.HeaderText = "SubGrupo";
            this.SubGrupo.Name = "SubGrupo";
            this.SubGrupo.Width = 150;
            // 
            // PRO_UNIDADE
            // 
            this.PRO_UNIDADE.DataPropertyName = "PRO_UNIDADE";
            this.PRO_UNIDADE.HeaderText = "Unidade";
            this.PRO_UNIDADE.Name = "PRO_UNIDADE";
            this.PRO_UNIDADE.Width = 70;
            // 
            // PRO_PRECO_COMPRA_FORMATADO
            // 
            this.PRO_PRECO_COMPRA_FORMATADO.DataPropertyName = "PRO_PRECO_COMPRA_FORMATADO";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.PRO_PRECO_COMPRA_FORMATADO.DefaultCellStyle = dataGridViewCellStyle1;
            this.PRO_PRECO_COMPRA_FORMATADO.HeaderText = "Preço";
            this.PRO_PRECO_COMPRA_FORMATADO.Name = "PRO_PRECO_COMPRA_FORMATADO";
            // 
            // PRO_ESTOQUE_FORMATADO
            // 
            this.PRO_ESTOQUE_FORMATADO.DataPropertyName = "PRO_ESTOQUE_FORMATADO";
            this.PRO_ESTOQUE_FORMATADO.HeaderText = "Estoque";
            this.PRO_ESTOQUE_FORMATADO.Name = "PRO_ESTOQUE_FORMATADO";
            this.PRO_ESTOQUE_FORMATADO.Width = 80;
            // 
            // COM_DATA_FORMATADA
            // 
            this.COM_DATA_FORMATADA.DataPropertyName = "COM_DATA_FORMATADA";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.COM_DATA_FORMATADA.DefaultCellStyle = dataGridViewCellStyle2;
            this.COM_DATA_FORMATADA.HeaderText = "Ult. Compra";
            this.COM_DATA_FORMATADA.Name = "COM_DATA_FORMATADA";
            // 
            // FrmProcProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.gb_produto);
            this.Name = "FrmProcProdutos";
            this.Text = "FrmProcProdutos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProcProdutos_FormClosing);
            this.Controls.SetChildIndex(this.gb_produto, 0);
            this.gb_produto.ResumeLayout(false);
            this.gb_produto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produtos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_produto;
        private System.Windows.Forms.DataGridView dgv_Produtos;
        private System.Windows.Forms.TextBox tb_igual;
        private System.Windows.Forms.Label lbl_igual;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.ComboBox cb_criterio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_UNIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRECO_COMPRA_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_ESTOQUE_FORMATADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COM_DATA_FORMATADA;
    }
}