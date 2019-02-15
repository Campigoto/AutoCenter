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
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ultima_troca_correia = new System.Windows.Forms.MaskedTextBox();
            this.tb_cada_troca_correia = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_km_ultima_troca = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cada_troca = new System.Windows.Forms.MaskedTextBox();
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
            this.grupoProdutoXFornecedorTableAdapter1 = new UIL.ReportViewer.DataSet1TableAdapters.GrupoProdutoXFornecedorTableAdapter();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cada_troca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultima_troca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAR_KM_ULTIMA_TROCA_CORREIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAR_KM_CADA_TROCA_CORREIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_carro.SuspendLayout();
            this.gb_pesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carro)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_carro
            // 
            this.gb_carro.Controls.Add(this.label5);
            this.gb_carro.Controls.Add(this.tb_ultima_troca_correia);
            this.gb_carro.Controls.Add(this.tb_cada_troca_correia);
            this.gb_carro.Controls.Add(this.label4);
            this.gb_carro.Controls.Add(this.label2);
            this.gb_carro.Controls.Add(this.tb_km_ultima_troca);
            this.gb_carro.Controls.Add(this.label3);
            this.gb_carro.Controls.Add(this.tb_cada_troca);
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
            this.gb_carro.Location = new System.Drawing.Point(37, 85);
            this.gb_carro.Margin = new System.Windows.Forms.Padding(2);
            this.gb_carro.Name = "gb_carro";
            this.gb_carro.Padding = new System.Windows.Forms.Padding(2);
            this.gb_carro.Size = new System.Drawing.Size(989, 177);
            this.gb_carro.TabIndex = 0;
            this.gb_carro.TabStop = false;
            this.gb_carro.Text = "Cadastro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Correia";
            // 
            // tb_ultima_troca_correia
            // 
            this.tb_ultima_troca_correia.Location = new System.Drawing.Point(832, 86);
            this.tb_ultima_troca_correia.Mask = "##########";
            this.tb_ultima_troca_correia.Name = "tb_ultima_troca_correia";
            this.tb_ultima_troca_correia.Size = new System.Drawing.Size(137, 21);
            this.tb_ultima_troca_correia.TabIndex = 10;
            // 
            // tb_cada_troca_correia
            // 
            this.tb_cada_troca_correia.Location = new System.Drawing.Point(689, 86);
            this.tb_cada_troca_correia.Mask = "##########";
            this.tb_cada_troca_correia.Name = "tb_cada_troca_correia";
            this.tb_cada_troca_correia.Size = new System.Drawing.Size(137, 21);
            this.tb_cada_troca_correia.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Óleo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(829, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "KM última troca:";
            // 
            // tb_km_ultima_troca
            // 
            this.tb_km_ultima_troca.Location = new System.Drawing.Point(832, 59);
            this.tb_km_ultima_troca.Mask = "##########";
            this.tb_km_ultima_troca.Name = "tb_km_ultima_troca";
            this.tb_km_ultima_troca.Size = new System.Drawing.Size(137, 21);
            this.tb_km_ultima_troca.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "KM a cada troca:";
            // 
            // tb_cada_troca
            // 
            this.tb_cada_troca.Location = new System.Drawing.Point(689, 59);
            this.tb_cada_troca.Mask = "##########";
            this.tb_cada_troca.Name = "tb_cada_troca";
            this.tb_cada_troca.Size = new System.Drawing.Size(137, 21);
            this.tb_cada_troca.TabIndex = 7;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(487, 114);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(100, 30);
            this.btn_deletar.TabIndex = 13;
            this.btn_deletar.Text = "EXCLUIR";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "LIMPAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_limpar_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "GRAVAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_carro_gravar);
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(593, 59);
            this.tb_ano.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ano.Mask = "0000";
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(39, 21);
            this.tb_ano.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ano:";
            // 
            // lbl_cor
            // 
            this.lbl_cor.AutoSize = true;
            this.lbl_cor.Location = new System.Drawing.Point(431, 42);
            this.lbl_cor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cor.Name = "lbl_cor";
            this.lbl_cor.Size = new System.Drawing.Size(33, 13);
            this.lbl_cor.TabIndex = 0;
            this.lbl_cor.Text = "Cor:";
            // 
            // tb_cor
            // 
            this.tb_cor.Location = new System.Drawing.Point(434, 59);
            this.tb_cor.Margin = new System.Windows.Forms.Padding(2);
            this.tb_cor.Name = "tb_cor";
            this.tb_cor.Size = new System.Drawing.Size(150, 21);
            this.tb_cor.TabIndex = 4;
            // 
            // tb_modelo
            // 
            this.tb_modelo.Location = new System.Drawing.Point(272, 59);
            this.tb_modelo.Margin = new System.Windows.Forms.Padding(2);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.Size = new System.Drawing.Size(150, 21);
            this.tb_modelo.TabIndex = 3;
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(270, 42);
            this.lbl_modelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(52, 13);
            this.lbl_modelo.TabIndex = 0;
            this.lbl_modelo.Text = "Modelo:";
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(120, 59);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(145, 21);
            this.tb_marca.TabIndex = 2;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(118, 42);
            this.lbl_marca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(46, 13);
            this.lbl_marca.TabIndex = 0;
            this.lbl_marca.Text = "Marca:";
            // 
            // tb_placa
            // 
            this.tb_placa.Location = new System.Drawing.Point(24, 59);
            this.tb_placa.Mask = "LLL-0000";
            this.tb_placa.Name = "tb_placa";
            this.tb_placa.Size = new System.Drawing.Size(84, 21);
            this.tb_placa.TabIndex = 1;
            this.tb_placa.TextChanged += new System.EventHandler(this.tb_placa_TextChanged);
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(22, 42);
            this.lbl_placa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(42, 13);
            this.lbl_placa.TabIndex = 0;
            this.lbl_placa.Text = "Placa:";
            // 
            // gb_pesquisa
            // 
            this.gb_pesquisa.Controls.Add(this.dgv_carro);
            this.gb_pesquisa.Location = new System.Drawing.Point(37, 275);
            this.gb_pesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.gb_pesquisa.Name = "gb_pesquisa";
            this.gb_pesquisa.Padding = new System.Windows.Forms.Padding(2);
            this.gb_pesquisa.Size = new System.Drawing.Size(989, 268);
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
            this.CAR_ID,
            this.cada_troca,
            this.ultima_troca,
            this.CAR_KM_ULTIMA_TROCA_CORREIA,
            this.CAR_KM_CADA_TROCA_CORREIA});
            this.dgv_carro.Location = new System.Drawing.Point(24, 29);
            this.dgv_carro.Name = "dgv_carro";
            this.dgv_carro.RowHeadersVisible = false;
            this.dgv_carro.RowTemplate.Height = 24;
            this.dgv_carro.Size = new System.Drawing.Size(939, 222);
            this.dgv_carro.TabIndex = 0;
            this.dgv_carro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btn_carro_cellClick);
            // 
            // grupoProdutoXFornecedorTableAdapter1
            // 
            this.grupoProdutoXFornecedorTableAdapter1.ClearBeforeFill = true;
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
            this.CAR_ID.HeaderText = "car_id";
            this.CAR_ID.Name = "CAR_ID";
            this.CAR_ID.Visible = false;
            // 
            // cada_troca
            // 
            this.cada_troca.DataPropertyName = "CAR_KM_CADA_TROCA_OLEO";
            this.cada_troca.HeaderText = "cada_troca";
            this.cada_troca.Name = "cada_troca";
            this.cada_troca.Visible = false;
            // 
            // ultima_troca
            // 
            this.ultima_troca.DataPropertyName = "CAR_KM_ULTIMA_TROCA_OLEO";
            this.ultima_troca.HeaderText = "ultima_troca";
            this.ultima_troca.Name = "ultima_troca";
            this.ultima_troca.Visible = false;
            // 
            // CAR_KM_ULTIMA_TROCA_CORREIA
            // 
            this.CAR_KM_ULTIMA_TROCA_CORREIA.DataPropertyName = "CAR_KM_ULTIMA_TROCA_CORREIA";
            this.CAR_KM_ULTIMA_TROCA_CORREIA.HeaderText = "CAR_KM_ULTIMA_TROCA_CORREIA";
            this.CAR_KM_ULTIMA_TROCA_CORREIA.Name = "CAR_KM_ULTIMA_TROCA_CORREIA";
            this.CAR_KM_ULTIMA_TROCA_CORREIA.Visible = false;
            // 
            // CAR_KM_CADA_TROCA_CORREIA
            // 
            this.CAR_KM_CADA_TROCA_CORREIA.DataPropertyName = "CAR_KM_CADA_TROCA_CORREIA";
            this.CAR_KM_CADA_TROCA_CORREIA.HeaderText = "CAR_KM_CADA_TROCA_CORREIA";
            this.CAR_KM_CADA_TROCA_CORREIA.Name = "CAR_KM_CADA_TROCA_CORREIA";
            this.CAR_KM_CADA_TROCA_CORREIA.Visible = false;
            // 
            // Frm_Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 562);
            this.Controls.Add(this.gb_pesquisa);
            this.Controls.Add(this.gb_carro);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.MaskedTextBox tb_cada_troca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tb_km_ultima_troca;
        private ReportViewer.DataSet1TableAdapters.GrupoProdutoXFornecedorTableAdapter grupoProdutoXFornecedorTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tb_ultima_troca_correia;
        private System.Windows.Forms.MaskedTextBox tb_cada_troca_correia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cada_troca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultima_troca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAR_KM_ULTIMA_TROCA_CORREIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAR_KM_CADA_TROCA_CORREIA;
    }
}