namespace UIL
{
    partial class Frm_Rel_Produtos
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_grupo = new System.Windows.Forms.ComboBox();
            this.cb_subgrupo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_relatorioprodutos = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Informe Opções:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_grupo
            // 
            this.cb_grupo.FormattingEnabled = true;
            this.cb_grupo.Location = new System.Drawing.Point(347, 247);
            this.cb_grupo.Name = "cb_grupo";
            this.cb_grupo.Size = new System.Drawing.Size(121, 21);
            this.cb_grupo.TabIndex = 15;
            this.cb_grupo.SelectedIndexChanged += new System.EventHandler(this.cb_grupo_SelectedIndexChanged);
            this.cb_grupo.SelectedValueChanged += new System.EventHandler(this.cb_grupo_SelectedValueChanged);
            // 
            // cb_subgrupo
            // 
            this.cb_subgrupo.FormattingEnabled = true;
            this.cb_subgrupo.Location = new System.Drawing.Point(484, 247);
            this.cb_subgrupo.Name = "cb_subgrupo";
            this.cb_subgrupo.Size = new System.Drawing.Size(121, 21);
            this.cb_subgrupo.TabIndex = 16;
            this.cb_subgrupo.SelectedIndexChanged += new System.EventHandler(this.cb_subgrupo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Grupo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sub-Grupo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 26);
            this.button1.TabIndex = 22;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gb_relatorioprodutos
            // 
            this.gb_relatorioprodutos.Location = new System.Drawing.Point(29, 103);
            this.gb_relatorioprodutos.Name = "gb_relatorioprodutos";
            this.gb_relatorioprodutos.Size = new System.Drawing.Size(994, 390);
            this.gb_relatorioprodutos.TabIndex = 23;
            this.gb_relatorioprodutos.TabStop = false;
            this.gb_relatorioprodutos.Text = "Relatório de Produtos";
            // 
            // Frm_Rel_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_subgrupo);
            this.Controls.Add(this.cb_grupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_relatorioprodutos);
            this.Name = "Frm_Rel_Produtos";
            this.Text = "Relatório de Produtos";
            this.Controls.SetChildIndex(this.gb_relatorioprodutos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cb_grupo, 0);
            this.Controls.SetChildIndex(this.cb_subgrupo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_grupo;
        private System.Windows.Forms.ComboBox cb_subgrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gb_relatorioprodutos;
    }
}