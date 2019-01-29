namespace UIL
{
    partial class FrmClientes
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
            this.gb_cliente = new System.Windows.Forms.GroupBox();
            this.tb_celular = new System.Windows.Forms.MaskedTextBox();
            this.tb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tb_cep = new System.Windows.Forms.MaskedTextBox();
            this.tb_cpf_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.lbl_ie_ci = new System.Windows.Forms.Label();
            this.lbl_cnpj_cpf = new System.Windows.Forms.Label();
            this.tb_ie_ci = new System.Windows.Forms.TextBox();
            this.tb_fantasia = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_cidade = new System.Windows.Forms.ComboBox();
            this.tb_UF = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_contato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_pessoa = new System.Windows.Forms.ComboBox();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.tb_logradouro = new System.Windows.Forms.TextBox();
            this.tb_cadastro = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_cliente
            // 
            this.gb_cliente.Controls.Add(this.tb_celular);
            this.gb_cliente.Controls.Add(this.tb_telefone);
            this.gb_cliente.Controls.Add(this.tb_cep);
            this.gb_cliente.Controls.Add(this.tb_cpf_cnpj);
            this.gb_cliente.Controls.Add(this.lbl_ie_ci);
            this.gb_cliente.Controls.Add(this.lbl_cnpj_cpf);
            this.gb_cliente.Controls.Add(this.tb_ie_ci);
            this.gb_cliente.Controls.Add(this.tb_fantasia);
            this.gb_cliente.Controls.Add(this.label16);
            this.gb_cliente.Controls.Add(this.cb_cidade);
            this.gb_cliente.Controls.Add(this.tb_UF);
            this.gb_cliente.Controls.Add(this.tb_email);
            this.gb_cliente.Controls.Add(this.label15);
            this.gb_cliente.Controls.Add(this.label14);
            this.gb_cliente.Controls.Add(this.label13);
            this.gb_cliente.Controls.Add(this.tb_contato);
            this.gb_cliente.Controls.Add(this.label4);
            this.gb_cliente.Controls.Add(this.btn_pesquisa);
            this.gb_cliente.Controls.Add(this.btnlimpar);
            this.gb_cliente.Controls.Add(this.btncancelar);
            this.gb_cliente.Controls.Add(this.btngravar);
            this.gb_cliente.Controls.Add(this.cb_status);
            this.gb_cliente.Controls.Add(this.cb_pessoa);
            this.gb_cliente.Controls.Add(this.tb_obs);
            this.gb_cliente.Controls.Add(this.tb_bairro);
            this.gb_cliente.Controls.Add(this.tb_logradouro);
            this.gb_cliente.Controls.Add(this.tb_cadastro);
            this.gb_cliente.Controls.Add(this.tb_nome);
            this.gb_cliente.Controls.Add(this.tb_codigo);
            this.gb_cliente.Controls.Add(this.label12);
            this.gb_cliente.Controls.Add(this.label11);
            this.gb_cliente.Controls.Add(this.label9);
            this.gb_cliente.Controls.Add(this.label8);
            this.gb_cliente.Controls.Add(this.label7);
            this.gb_cliente.Controls.Add(this.label6);
            this.gb_cliente.Controls.Add(this.label5);
            this.gb_cliente.Controls.Add(this.label3);
            this.gb_cliente.Controls.Add(this.label2);
            this.gb_cliente.Controls.Add(this.label1);
            this.gb_cliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_cliente.Location = new System.Drawing.Point(12, 89);
            this.gb_cliente.Name = "gb_cliente";
            this.gb_cliente.Size = new System.Drawing.Size(1029, 461);
            this.gb_cliente.TabIndex = 15;
            this.gb_cliente.TabStop = false;
            this.gb_cliente.Text = "Cadastro:";
            // 
            // tb_celular
            // 
            this.tb_celular.Location = new System.Drawing.Point(351, 177);
            this.tb_celular.Mask = "(999) 0000-0000";
            this.tb_celular.Name = "tb_celular";
            this.tb_celular.Size = new System.Drawing.Size(100, 21);
            this.tb_celular.TabIndex = 42;
            this.tb_celular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tb_celular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(221, 177);
            this.tb_telefone.Mask = "(999) 0000-0000";
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(100, 21);
            this.tb_telefone.TabIndex = 41;
            this.tb_telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tb_telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // tb_cep
            // 
            this.tb_cep.Location = new System.Drawing.Point(738, 87);
            this.tb_cep.Mask = "99,999-999";
            this.tb_cep.Name = "tb_cep";
            this.tb_cep.Size = new System.Drawing.Size(112, 21);
            this.tb_cep.TabIndex = 40;
            this.tb_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tb_cep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // tb_cpf_cnpj
            // 
            this.tb_cpf_cnpj.Location = new System.Drawing.Point(828, 129);
            this.tb_cpf_cnpj.Mask = "99,999,999/9999-99";
            this.tb_cpf_cnpj.Name = "tb_cpf_cnpj";
            this.tb_cpf_cnpj.Size = new System.Drawing.Size(159, 21);
            this.tb_cpf_cnpj.TabIndex = 39;
            this.tb_cpf_cnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tb_cpf_cnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // lbl_ie_ci
            // 
            this.lbl_ie_ci.AutoSize = true;
            this.lbl_ie_ci.Location = new System.Drawing.Point(32, 161);
            this.lbl_ie_ci.Name = "lbl_ie_ci";
            this.lbl_ie_ci.Size = new System.Drawing.Size(97, 13);
            this.lbl_ie_ci.TabIndex = 38;
            this.lbl_ie_ci.Text = "Inscr. Estadual:";
            // 
            // lbl_cnpj_cpf
            // 
            this.lbl_cnpj_cpf.AutoSize = true;
            this.lbl_cnpj_cpf.Location = new System.Drawing.Point(825, 115);
            this.lbl_cnpj_cpf.Name = "lbl_cnpj_cpf";
            this.lbl_cnpj_cpf.Size = new System.Drawing.Size(53, 13);
            this.lbl_cnpj_cpf.TabIndex = 37;
            this.lbl_cnpj_cpf.Text = "C.N.P.J:";
            // 
            // tb_ie_ci
            // 
            this.tb_ie_ci.Location = new System.Drawing.Point(35, 177);
            this.tb_ie_ci.Name = "tb_ie_ci";
            this.tb_ie_ci.Size = new System.Drawing.Size(161, 21);
            this.tb_ie_ci.TabIndex = 14;
            // 
            // tb_fantasia
            // 
            this.tb_fantasia.Location = new System.Drawing.Point(528, 42);
            this.tb_fantasia.Name = "tb_fantasia";
            this.tb_fantasia.Size = new System.Drawing.Size(229, 21);
            this.tb_fantasia.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(525, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Fantasia:";
            // 
            // cb_cidade
            // 
            this.cb_cidade.FormattingEnabled = true;
            this.cb_cidade.Location = new System.Drawing.Point(34, 129);
            this.cb_cidade.Name = "cb_cidade";
            this.cb_cidade.Size = new System.Drawing.Size(201, 21);
            this.cb_cidade.TabIndex = 8;
            this.cb_cidade.SelectedIndexChanged += new System.EventHandler(this.cb_cidade_SelectedIndexChanged);
            // 
            // tb_UF
            // 
            this.tb_UF.Location = new System.Drawing.Point(241, 129);
            this.tb_UF.Name = "tb_UF";
            this.tb_UF.Size = new System.Drawing.Size(41, 21);
            this.tb_UF.TabIndex = 9;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(477, 177);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(341, 21);
            this.tb_email.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(474, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Email:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(348, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Celular:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(218, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Telefone:";
            // 
            // tb_contato
            // 
            this.tb_contato.Location = new System.Drawing.Point(457, 129);
            this.tb_contato.Name = "tb_contato";
            this.tb_contato.Size = new System.Drawing.Size(181, 21);
            this.tb_contato.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Contato:";
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Location = new System.Drawing.Point(561, 415);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(100, 30);
            this.btn_pesquisa.TabIndex = 22;
            this.btn_pesquisa.Text = "Pesquisa";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(455, 415);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(100, 30);
            this.btnlimpar.TabIndex = 21;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(670, 415);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 30);
            this.btncancelar.TabIndex = 23;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Visible = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(348, 415);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(100, 30);
            this.btngravar.TabIndex = 20;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cb_status.Location = new System.Drawing.Point(789, 41);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(99, 21);
            this.cb_status.TabIndex = 4;
            this.cb_status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // cb_pessoa
            // 
            this.cb_pessoa.FormattingEnabled = true;
            this.cb_pessoa.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cb_pessoa.Location = new System.Drawing.Point(317, 129);
            this.cb_pessoa.Name = "cb_pessoa";
            this.cb_pessoa.Size = new System.Drawing.Size(117, 21);
            this.cb_pessoa.TabIndex = 10;
            this.cb_pessoa.SelectedIndexChanged += new System.EventHandler(this.cb_pessoa_SelectedIndexChanged);
            this.cb_pessoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // tb_obs
            // 
            this.tb_obs.Location = new System.Drawing.Point(35, 228);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(928, 161);
            this.tb_obs.TabIndex = 19;
            // 
            // tb_bairro
            // 
            this.tb_bairro.Location = new System.Drawing.Point(501, 87);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(205, 21);
            this.tb_bairro.TabIndex = 6;
            // 
            // tb_logradouro
            // 
            this.tb_logradouro.Location = new System.Drawing.Point(34, 87);
            this.tb_logradouro.Name = "tb_logradouro";
            this.tb_logradouro.Size = new System.Drawing.Size(445, 21);
            this.tb_logradouro.TabIndex = 5;
            // 
            // tb_cadastro
            // 
            this.tb_cadastro.Location = new System.Drawing.Point(669, 129);
            this.tb_cadastro.Name = "tb_cadastro";
            this.tb_cadastro.Size = new System.Drawing.Size(137, 21);
            this.tb_cadastro.TabIndex = 12;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(155, 42);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(353, 21);
            this.tb_nome.TabIndex = 2;
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(34, 42);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(100, 21);
            this.tb_codigo.TabIndex = 1;
            this.tb_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.tb_codigo.Leave += new System.EventHandler(this.tb_codigo_Leave);
            this.tb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Cidade:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Observação:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(498, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Bairro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Endereço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(666, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cadastro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(735, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(786, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pessoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.gb_cliente);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Controls.SetChildIndex(this.gb_cliente, 0);
            this.gb_cliente.ResumeLayout(false);
            this.gb_cliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_cliente;
        private System.Windows.Forms.Label lbl_ie_ci;
        private System.Windows.Forms.Label lbl_cnpj_cpf;
        private System.Windows.Forms.TextBox tb_ie_ci;
        private System.Windows.Forms.TextBox tb_fantasia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_cidade;
        private System.Windows.Forms.TextBox tb_UF;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_contato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_pessoa;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.TextBox tb_logradouro;
        private System.Windows.Forms.TextBox tb_cadastro;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tb_cpf_cnpj;
        private System.Windows.Forms.MaskedTextBox tb_celular;
        private System.Windows.Forms.MaskedTextBox tb_telefone;
        private System.Windows.Forms.MaskedTextBox tb_cep;

    }
}