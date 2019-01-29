namespace UIL
{
    partial class buscaCep
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
            this.cb_cidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_bairro = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_rua = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.gb_CEP = new System.Windows.Forms.GroupBox();
            this.cb_cep = new System.Windows.Forms.ComboBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_CEP.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_cidade
            // 
            this.cb_cidade.FormattingEnabled = true;
            this.cb_cidade.Location = new System.Drawing.Point(78, 28);
            this.cb_cidade.Name = "cb_cidade";
            this.cb_cidade.Size = new System.Drawing.Size(235, 24);
            this.cb_cidade.TabIndex = 0;
            this.cb_cidade.SelectedIndexChanged += new System.EventHandler(this.pesquisa_bairro);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cidade: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bairro: ";
            // 
            // cb_bairro
            // 
            this.cb_bairro.CausesValidation = false;
            this.cb_bairro.FormattingEnabled = true;
            this.cb_bairro.Location = new System.Drawing.Point(78, 67);
            this.cb_bairro.Name = "cb_bairro";
            this.cb_bairro.Size = new System.Drawing.Size(235, 24);
            this.cb_bairro.TabIndex = 3;
            this.cb_bairro.SelectedIndexChanged += new System.EventHandler(this.Pesquisa_Rua);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_rua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_pesquisar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_bairro);
            this.groupBox1.Controls.Add(this.cb_cidade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // cb_rua
            // 
            this.cb_rua.FormattingEnabled = true;
            this.cb_rua.Location = new System.Drawing.Point(78, 102);
            this.cb_rua.Name = "cb_rua";
            this.cb_rua.Size = new System.Drawing.Size(234, 24);
            this.cb_rua.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rua: ";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(78, 143);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(234, 53);
            this.btn_pesquisar.TabIndex = 7;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.pesquisa_cep);
            // 
            // gb_CEP
            // 
            this.gb_CEP.Controls.Add(this.cb_cep);
            this.gb_CEP.Location = new System.Drawing.Point(13, 234);
            this.gb_CEP.Name = "gb_CEP";
            this.gb_CEP.Size = new System.Drawing.Size(352, 60);
            this.gb_CEP.TabIndex = 5;
            this.gb_CEP.TabStop = false;
            this.gb_CEP.Text = "CEP";
            // 
            // cb_cep
            // 
            this.cb_cep.FormattingEnabled = true;
            this.cb_cep.Location = new System.Drawing.Point(77, 22);
            this.cb_cep.Name = "cb_cep";
            this.cb_cep.Size = new System.Drawing.Size(234, 24);
            this.cb_cep.TabIndex = 8;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(90, 301);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(235, 53);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // buscaCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 369);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.gb_CEP);
            this.Controls.Add(this.groupBox1);
            this.Name = "buscaCep";
            this.Text = "Buscar CEP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_CEP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_cidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_bairro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.GroupBox gb_CEP;
        private System.Windows.Forms.ComboBox cb_cep;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.ComboBox cb_rua;
        private System.Windows.Forms.Label label3;
    }
}