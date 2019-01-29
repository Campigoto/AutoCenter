namespace UIL
{
    partial class FrmProcFornecedores
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
            this.gb_fornecedor = new System.Windows.Forms.GroupBox();
            this.dgv_Fornecedor = new System.Windows.Forms.DataGridView();
            this.cb_criterio = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_igual = new System.Windows.Forms.TextBox();
            this.lbl_igual = new System.Windows.Forms.Label();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_fornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_fornecedor
            // 
            this.gb_fornecedor.Controls.Add(this.dgv_Fornecedor);
            this.gb_fornecedor.Controls.Add(this.cb_criterio);
            this.gb_fornecedor.Controls.Add(this.label12);
            this.gb_fornecedor.Controls.Add(this.tb_igual);
            this.gb_fornecedor.Controls.Add(this.lbl_igual);
            this.gb_fornecedor.Controls.Add(this.btn_cadastro);
            this.gb_fornecedor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_fornecedor.Location = new System.Drawing.Point(30, 90);
            this.gb_fornecedor.Name = "gb_fornecedor";
            this.gb_fornecedor.Size = new System.Drawing.Size(1017, 460);
            this.gb_fornecedor.TabIndex = 23;
            this.gb_fornecedor.TabStop = false;
            this.gb_fornecedor.Text = "Pesquisa:";
            // 
            // dgv_Fornecedor
            // 
            this.dgv_Fornecedor.AllowUserToAddRows = false;
            this.dgv_Fornecedor.AllowUserToDeleteRows = false;
            this.dgv_Fornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Fornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.Cidade,
            this.Telefone,
            this.Contato});
            this.dgv_Fornecedor.Location = new System.Drawing.Point(13, 90);
            this.dgv_Fornecedor.Name = "dgv_Fornecedor";
            this.dgv_Fornecedor.RowHeadersVisible = false;
            this.dgv_Fornecedor.Size = new System.Drawing.Size(990, 351);
            this.dgv_Fornecedor.TabIndex = 4;
            this.dgv_Fornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Fornecedor_CellClick);
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
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 82;
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
            this.lbl_igual.TabIndex = 80;
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
            // codigo
            // 
            this.codigo.DataPropertyName = "FOR_CODIGO";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Width = 95;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "FOR_NOME";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 300;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "FOR_CIDADE_CID_NOME";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.Width = 170;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "FOR_FONE";
            dataGridViewCellStyle1.Format = "(###) ####-####";
            dataGridViewCellStyle1.NullValue = null;
            this.Telefone.DefaultCellStyle = dataGridViewCellStyle1;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.Width = 150;
            // 
            // Contato
            // 
            this.Contato.DataPropertyName = "FOR_CONTATO";
            this.Contato.HeaderText = "Contato";
            this.Contato.Name = "Contato";
            this.Contato.Width = 250;
            // 
            // FrmProcFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.gb_fornecedor);
            this.Name = "FrmProcFornecedores";
            this.Text = "FrmProcFornecedores";
            this.Controls.SetChildIndex(this.gb_fornecedor, 0);
            this.gb_fornecedor.ResumeLayout(false);
            this.gb_fornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_fornecedor;
        private System.Windows.Forms.DataGridView dgv_Fornecedor;
        private System.Windows.Forms.ComboBox cb_criterio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_igual;
        private System.Windows.Forms.Label lbl_igual;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;

    }
}