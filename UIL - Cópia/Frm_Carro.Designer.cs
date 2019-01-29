namespace UIL
{
    partial class Frm_Carro
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
            this.gb_carro = new System.Windows.Forms.GroupBox();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_ano = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cor = new System.Windows.Forms.Label();
            this.tb_cor = new System.Windows.Forms.TextBox();
            this.tb_modelo = new System.Windows.Forms.TextBox();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.tb_placa = new System.Windows.Forms.MaskedTextBox();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.gb_pesquisa = new System.Windows.Forms.GroupBox();
            this.dgv_carro = new System.Windows.Forms.DataGridView();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_carro.SuspendLayout();
            this.gb_pesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carro)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_carro
            // 
            this.gb_carro.Controls.Add(this.btn_deletar);
            this.gb_carro.Controls.Add(this.button2);
            this.gb_carro.Controls.Add(this.button1);
            this.gb_carro.Controls.Add(this.tb_ano);
            this.gb_carro.Controls.Add(this.label1);
            this.gb_carro.Controls.Add(this.lbl_cor);
            this.gb_carro.Controls.Add(this.tb_cor);
            this.gb_carro.Controls.Add(this.tb_modelo);
            this.gb_carro.Controls.Add(this.lbl_modelo);
            this.gb_carro.Controls.Add(this.tb_marca);
            this.gb_carro.Controls.Add(this.lbl_marca);
            this.gb_carro.Controls.Add(this.tb_placa);
            this.gb_carro.Controls.Add(this.lbl_placa);
            this.gb_carro.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.gb_carro.Location = new System.Drawing.Point(49, 105);
            this.gb_carro.Name = "gb_carro";
            this.gb_carro.Size = new System.Drawing.Size(1319, 201);
            this.gb_carro.TabIndex = 0;
            this.gb_carro.TabStop = false;
            this.gb_carro.Text = "Cadastro:";
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(649, 140);
            this.btn_deletar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(133, 37);
            this.btn_deletar.TabIndex = 9;
            this.btn_deletar.Text = "EXCLUIR";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 140);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "LIMPAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_limpar_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "GRAVAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_carro_gravar);
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(791, 73);
            this.tb_ano.Mask = "0000";
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(51, 24);
            this.tb_ano.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(788, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ano:";
            // 
            // lbl_cor
            // 
            this.lbl_cor.AutoSize = true;
            this.lbl_cor.Location = new System.Drawing.Point(575, 52);
            this.lbl_cor.Name = "lbl_cor";
            this.lbl_cor.Size = new System.Drawing.Size(39, 17);
            this.lbl_cor.TabIndex = 0;
            this.lbl_cor.Text = "Cor:";
            // 
            // tb_cor
            // 
            this.tb_cor.Location = new System.Drawing.Point(578, 73);
            this.tb_cor.Name = "tb_cor";
            this.tb_cor.Size = new System.Drawing.Size(198, 24);
            this.tb_cor.TabIndex = 4;
            // 
            // tb_modelo
            // 
            this.tb_modelo.Location = new System.Drawing.Point(363, 73);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.Size = new System.Drawing.Size(199, 24);
            this.tb_modelo.TabIndex = 3;
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(360, 52);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(63, 17);
            this.lbl_modelo.TabIndex = 0;
            this.lbl_modelo.Text = "Modelo:";
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(160, 73);
            this.tb_marca.Margin = new System.Windows.Forms.Padding(4);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(192, 24);
            this.tb_marca.TabIndex = 2;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(157, 52);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(54, 17);
            this.lbl_marca.TabIndex = 0;
            this.lbl_marca.Text = "Marca:";
            // 
            // tb_placa
            // 
            this.tb_placa.Location = new System.Drawing.Point(32, 73);
            this.tb_placa.Margin = new System.Windows.Forms.Padding(4);
            this.tb_placa.Mask = "LLL-0000";
            this.tb_placa.Name = "tb_placa";
            this.tb_placa.Size = new System.Drawing.Size(110, 24);
            this.tb_placa.TabIndex = 1;
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(29, 52);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(48, 17);
            this.lbl_placa.TabIndex = 0;
            this.lbl_placa.Text = "Placa:";
            // 
            // gb_pesquisa
            // 
            this.gb_pesquisa.Controls.Add(this.dgv_carro);
            this.gb_pesquisa.Location = new System.Drawing.Point(49, 338);
            this.gb_pesquisa.Name = "gb_pesquisa";
            this.gb_pesquisa.Size = new System.Drawing.Size(1319, 330);
            this.gb_pesquisa.TabIndex = 13;
            this.gb_pesquisa.TabStop = false;
            this.gb_pesquisa.Text = "Pesquisa:";
            // 
            // dgv_carro
            // 
            this.dgv_carro.AllowUserToAddRows = false;
            this.dgv_carro.AllowUserToDeleteRows = false;
            this.dgv_carro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_carro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Placa,
            this.Marca,
            this.Modelo,
            this.Cor,
            this.Ano,
            this.CAR_ID});
            this.dgv_carro.Location = new System.Drawing.Point(32, 36);
            this.dgv_carro.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_carro.Name = "dgv_carro";
            this.dgv_carro.RowHeadersVisible = false;
            this.dgv_carro.RowTemplate.Height = 24;
            this.dgv_carro.Size = new System.Drawing.Size(1252, 273);
            this.dgv_carro.TabIndex = 0;
            this.dgv_carro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btn_carro_cellClick);
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "CAR_PLACA";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.Width = 120;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "CAR_MARCA";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.Width = 300;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "CAR_MODELO";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 300;
            // 
            // Cor
            // 
            this.Cor.DataPropertyName = "CAR_COR";
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            // 
            // Ano
            // 
            this.Ano.DataPropertyName = "CAR_ANO";
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            // 
            // CAR_ID
            // 
            this.CAR_ID.DataPropertyName = "CAR_ID";
            this.CAR_ID.HeaderText = "Column1";
            this.CAR_ID.Name = "CAR_ID";
            this.CAR_ID.Visible = false;
            // 
            // Frm_Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 692);
            this.Controls.Add(this.gb_pesquisa);
            this.Controls.Add(this.gb_carro);
            this.Name = "Frm_Carro";
            this.Text = "Frm_Carro";
            this.Controls.SetChildIndex(this.gb_carro, 0);
            this.Controls.SetChildIndex(this.gb_pesquisa, 0);
            this.gb_carro.ResumeLayout(false);
            this.gb_carro.PerformLayout();
            this.gb_pesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_carro;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.MaskedTextBox tb_placa;
        private System.Windows.Forms.TextBox tb_modelo;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.MaskedTextBox tb_ano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cor;
        private System.Windows.Forms.TextBox tb_cor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gb_pesquisa;
        private System.Windows.Forms.DataGridView dgv_carro;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAR_ID;
    }
}