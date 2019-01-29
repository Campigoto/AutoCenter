namespace UIL
{
    partial class FrmProcClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_cliente = new System.Windows.Forms.GroupBox();
            this.cb_criterio = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_igual = new System.Windows.Forms.TextBox();
            this.lbl_igual = new System.Windows.Forms.Label();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.dgv_Cliente = new System.Windows.Forms.DataGridView();
            this.CLI_CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLI_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLI_CIDADE_CID_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLI_FONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLI_CONTATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_cliente
            // 
            this.gb_cliente.Controls.Add(this.cb_criterio);
            this.gb_cliente.Controls.Add(this.label12);
            this.gb_cliente.Controls.Add(this.tb_igual);
            this.gb_cliente.Controls.Add(this.lbl_igual);
            this.gb_cliente.Controls.Add(this.btn_cadastro);
            this.gb_cliente.Controls.Add(this.dgv_Cliente);
            this.gb_cliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_cliente.Location = new System.Drawing.Point(30, 90);
            this.gb_cliente.Name = "gb_cliente";
            this.gb_cliente.Size = new System.Drawing.Size(1017, 460);
            this.gb_cliente.TabIndex = 22;
            this.gb_cliente.TabStop = false;
            this.gb_cliente.Text = "Pesquisa:";
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
            // dgv_Cliente
            // 
            this.dgv_Cliente.AllowUserToAddRows = false;
            this.dgv_Cliente.AllowUserToDeleteRows = false;
            this.dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLI_CODIGO,
            this.CLI_NOME,
            this.CLI_CIDADE_CID_NOME,
            this.CLI_FONE,
            this.CLI_CONTATO});
            this.dgv_Cliente.Location = new System.Drawing.Point(13, 90);
            this.dgv_Cliente.Name = "dgv_Cliente";
            this.dgv_Cliente.RowHeadersVisible = false;
            this.dgv_Cliente.Size = new System.Drawing.Size(990, 351);
            this.dgv_Cliente.TabIndex = 4;
            this.dgv_Cliente.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Cliente_CellFormatting);
            this.dgv_Cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Cliente_CellClick);
            // 
            // CLI_CODIGO
            // 
            this.CLI_CODIGO.DataPropertyName = "CLI_CODIGO";
            dataGridViewCellStyle3.NullValue = null;
            this.CLI_CODIGO.DefaultCellStyle = dataGridViewCellStyle3;
            this.CLI_CODIGO.HeaderText = "Código";
            this.CLI_CODIGO.Name = "CLI_CODIGO";
            this.CLI_CODIGO.Width = 95;
            // 
            // CLI_NOME
            // 
            this.CLI_NOME.DataPropertyName = "CLI_NOME";
            this.CLI_NOME.HeaderText = "Nome";
            this.CLI_NOME.Name = "CLI_NOME";
            this.CLI_NOME.Width = 300;
            // 
            // CLI_CIDADE_CID_NOME
            // 
            this.CLI_CIDADE_CID_NOME.DataPropertyName = "CLI_CIDADE_CID_NOME";
            this.CLI_CIDADE_CID_NOME.HeaderText = "Cidade";
            this.CLI_CIDADE_CID_NOME.Name = "CLI_CIDADE_CID_NOME";
            this.CLI_CIDADE_CID_NOME.Width = 170;
            // 
            // CLI_FONE
            // 
            this.CLI_FONE.DataPropertyName = "CLI_FONE";
            dataGridViewCellStyle4.NullValue = null;
            this.CLI_FONE.DefaultCellStyle = dataGridViewCellStyle4;
            this.CLI_FONE.HeaderText = "Telefone";
            this.CLI_FONE.Name = "CLI_FONE";
            this.CLI_FONE.Width = 150;
            // 
            // CLI_CONTATO
            // 
            this.CLI_CONTATO.DataPropertyName = "CLI_CONTATO";
            this.CLI_CONTATO.HeaderText = "Contato";
            this.CLI_CONTATO.Name = "CLI_CONTATO";
            this.CLI_CONTATO.Width = 250;
            // 
            // FrmProcClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.gb_cliente);
            this.Name = "FrmProcClientes";
            this.Text = "FrmProcClientes";
            this.Controls.SetChildIndex(this.gb_cliente, 0);
            this.gb_cliente.ResumeLayout(false);
            this.gb_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_cliente;
        private System.Windows.Forms.DataGridView dgv_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLI_CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLI_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLI_CIDADE_CID_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLI_FONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLI_CONTATO;
        private System.Windows.Forms.ComboBox cb_criterio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_igual;
        private System.Windows.Forms.Label lbl_igual;
        private System.Windows.Forms.Button btn_cadastro;
    }
}