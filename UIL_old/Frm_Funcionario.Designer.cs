namespace UIL
{
    partial class Frm_Funcionario
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
            this.gb_pesq_func = new System.Windows.Forms.GroupBox();
            this.dgv_usuario = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clínica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_cad_func = new System.Windows.Forms.GroupBox();
            this.tb_despesas = new System.Windows.Forms.TextBox();
            this.btn_desativar = new System.Windows.Forms.Button();
            this.cb_usuario = new System.Windows.Forms.CheckBox();
            this.tb_senha = new System.Windows.Forms.MaskedTextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.lb_tem = new System.Windows.Forms.ListBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.btn_remover = new System.Windows.Forms.Button();
            this.lb_nome = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.lb_sem = new System.Windows.Forms.ListBox();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.lb_senha = new System.Windows.Forms.Label();
            this.lb_despesas = new System.Windows.Forms.Label();
            this.gb_pesq_func.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).BeginInit();
            this.gb_cad_func.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_pesq_func
            // 
            this.gb_pesq_func.Controls.Add(this.dgv_usuario);
            this.gb_pesq_func.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_pesq_func.Location = new System.Drawing.Point(32, 374);
            this.gb_pesq_func.Name = "gb_pesq_func";
            this.gb_pesq_func.Size = new System.Drawing.Size(1000, 163);
            this.gb_pesq_func.TabIndex = 39;
            this.gb_pesq_func.TabStop = false;
            this.gb_pesq_func.Text = "Pesquisa:";
            // 
            // dgv_usuario
            // 
            this.dgv_usuario.AllowUserToAddRows = false;
            this.dgv_usuario.AllowUserToDeleteRows = false;
            this.dgv_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.CRM,
            this.Clínica});
            this.dgv_usuario.Location = new System.Drawing.Point(22, 32);
            this.dgv_usuario.Name = "dgv_usuario";
            this.dgv_usuario.RowHeadersVisible = false;
            this.dgv_usuario.Size = new System.Drawing.Size(716, 120);
            this.dgv_usuario.TabIndex = 14;
            this.dgv_usuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuario_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FUN_CODIGO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FUN_NOME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // CRM
            // 
            this.CRM.DataPropertyName = "FUN_DESPESAS_FORMATADO";
            this.CRM.HeaderText = "Despesas";
            this.CRM.Name = "CRM";
            this.CRM.Width = 150;
            // 
            // Clínica
            // 
            this.Clínica.DataPropertyName = "FUN_USUARIO_NOME";
            this.Clínica.HeaderText = "Usuário";
            this.Clínica.Name = "Clínica";
            this.Clínica.Width = 200;
            // 
            // gb_cad_func
            // 
            this.gb_cad_func.Controls.Add(this.tb_despesas);
            this.gb_cad_func.Controls.Add(this.btn_desativar);
            this.gb_cad_func.Controls.Add(this.cb_usuario);
            this.gb_cad_func.Controls.Add(this.tb_senha);
            this.gb_cad_func.Controls.Add(this.btn_limpar);
            this.gb_cad_func.Controls.Add(this.btn_gravar);
            this.gb_cad_func.Controls.Add(this.lb_tem);
            this.gb_cad_func.Controls.Add(this.tb_nome);
            this.gb_cad_func.Controls.Add(this.btn_remover);
            this.gb_cad_func.Controls.Add(this.lb_nome);
            this.gb_cad_func.Controls.Add(this.btn_adicionar);
            this.gb_cad_func.Controls.Add(this.tb_codigo);
            this.gb_cad_func.Controls.Add(this.lb_sem);
            this.gb_cad_func.Controls.Add(this.lb_codigo);
            this.gb_cad_func.Controls.Add(this.lb_login);
            this.gb_cad_func.Controls.Add(this.tb_login);
            this.gb_cad_func.Controls.Add(this.lb_senha);
            this.gb_cad_func.Controls.Add(this.lb_despesas);
            this.gb_cad_func.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_cad_func.Location = new System.Drawing.Point(32, 84);
            this.gb_cad_func.Name = "gb_cad_func";
            this.gb_cad_func.Size = new System.Drawing.Size(1000, 284);
            this.gb_cad_func.TabIndex = 38;
            this.gb_cad_func.TabStop = false;
            this.gb_cad_func.Text = "Cadastro:";
            // 
            // tb_despesas
            // 
            this.tb_despesas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_despesas.Location = new System.Drawing.Point(659, 36);
            this.tb_despesas.Name = "tb_despesas";
            this.tb_despesas.Size = new System.Drawing.Size(100, 21);
            this.tb_despesas.TabIndex = 5;
            this.tb_despesas.Leave += new System.EventHandler(this.Valor_Leave);
            this.tb_despesas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valor_KeyPress);
            // 
            // btn_desativar
            // 
            this.btn_desativar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desativar.Location = new System.Drawing.Point(632, 242);
            this.btn_desativar.Name = "btn_desativar";
            this.btn_desativar.Size = new System.Drawing.Size(100, 30);
            this.btn_desativar.TabIndex = 13;
            this.btn_desativar.Text = "Desativar";
            this.btn_desativar.UseVisualStyleBackColor = true;
            this.btn_desativar.Click += new System.EventHandler(this.btn_desativar_Click);
            // 
            // cb_usuario
            // 
            this.cb_usuario.AutoSize = true;
            this.cb_usuario.Location = new System.Drawing.Point(800, 29);
            this.cb_usuario.Name = "cb_usuario";
            this.cb_usuario.Size = new System.Drawing.Size(158, 17);
            this.cb_usuario.TabIndex = 6;
            this.cb_usuario.Text = "Usuário (Efetuar Login)";
            this.cb_usuario.UseVisualStyleBackColor = true;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(325, 36);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(150, 21);
            this.tb_senha.TabIndex = 3;
            this.tb_senha.UseSystemPasswordChar = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(526, 242);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(100, 30);
            this.btn_limpar.TabIndex = 12;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravar.Location = new System.Drawing.Point(420, 242);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(100, 30);
            this.btn_gravar.TabIndex = 11;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // lb_tem
            // 
            this.lb_tem.DisplayMember = "OPE_NOME";
            this.lb_tem.FormattingEnabled = true;
            this.lb_tem.Location = new System.Drawing.Point(547, 82);
            this.lb_tem.Name = "lb_tem";
            this.lb_tem.Size = new System.Drawing.Size(340, 121);
            this.lb_tem.TabIndex = 10;
            this.lb_tem.ValueMember = "OPE_CODIGO";
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(129, 36);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(180, 21);
            this.tb_nome.TabIndex = 2;
            // 
            // btn_remover
            // 
            this.btn_remover.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Location = new System.Drawing.Point(436, 149);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(100, 30);
            this.btn_remover.TabIndex = 9;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(126, 21);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(45, 13);
            this.lb_nome.TabIndex = 21;
            this.lb_nome.Text = "Nome:";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.Location = new System.Drawing.Point(436, 113);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(100, 30);
            this.btn_adicionar.TabIndex = 8;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_codigo
            // 
            this.tb_codigo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(16, 37);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(100, 21);
            this.tb_codigo.TabIndex = 1;
            this.tb_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.tb_codigo.Leave += new System.EventHandler(this.tb_codigo_Leave);
            this.tb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // lb_sem
            // 
            this.lb_sem.DisplayMember = "OPE_NOME";
            this.lb_sem.FormattingEnabled = true;
            this.lb_sem.Location = new System.Drawing.Point(84, 82);
            this.lb_sem.Name = "lb_sem";
            this.lb_sem.Size = new System.Drawing.Size(340, 121);
            this.lb_sem.TabIndex = 7;
            this.lb_sem.ValueMember = "OPE_CODIGO";
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigo.Location = new System.Drawing.Point(13, 21);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(52, 13);
            this.lb_codigo.TabIndex = 23;
            this.lb_codigo.Text = "Código:";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.Location = new System.Drawing.Point(489, 21);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(42, 13);
            this.lb_login.TabIndex = 25;
            this.lb_login.Text = "Login:";
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_login.Location = new System.Drawing.Point(492, 36);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(150, 21);
            this.tb_login.TabIndex = 4;
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(322, 21);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(48, 13);
            this.lb_senha.TabIndex = 27;
            this.lb_senha.Text = "Senha:";
            // 
            // lb_despesas
            // 
            this.lb_despesas.AutoSize = true;
            this.lb_despesas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_despesas.Location = new System.Drawing.Point(656, 21);
            this.lb_despesas.Name = "lb_despesas";
            this.lb_despesas.Size = new System.Drawing.Size(67, 13);
            this.lb_despesas.TabIndex = 29;
            this.lb_despesas.Text = "Despesas:";
            // 
            // Frm_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.gb_pesq_func);
            this.Controls.Add(this.gb_cad_func);
            this.Name = "Frm_Funcionario";
            this.Controls.SetChildIndex(this.gb_cad_func, 0);
            this.Controls.SetChildIndex(this.gb_pesq_func, 0);
            this.gb_pesq_func.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).EndInit();
            this.gb_cad_func.ResumeLayout(false);
            this.gb_cad_func.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_pesq_func;
        private System.Windows.Forms.DataGridView dgv_usuario;
        private System.Windows.Forms.GroupBox gb_cad_func;
        private System.Windows.Forms.MaskedTextBox tb_senha;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.ListBox lb_tem;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.ListBox lb_sem;
        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Label lb_despesas;
        private System.Windows.Forms.CheckBox cb_usuario;
        private System.Windows.Forms.Button btn_desativar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clínica;
        private System.Windows.Forms.TextBox tb_despesas;

    }
}