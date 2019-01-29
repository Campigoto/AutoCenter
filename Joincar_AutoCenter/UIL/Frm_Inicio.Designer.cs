namespace UIL
{
    partial class Frm_Inicio
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
            this.fb_inicio = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tb_senha = new System.Windows.Forms.MaskedTextBox();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_logar = new System.Windows.Forms.Button();
            this.lb_login = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.lb_senha = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fb_inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // fb_inicio
            // 
            this.fb_inicio.Controls.Add(this.pictureBox1);
            this.fb_inicio.Controls.Add(this.pictureBox3);
            this.fb_inicio.Controls.Add(this.tb_senha);
            this.fb_inicio.Controls.Add(this.btn_remover);
            this.fb_inicio.Controls.Add(this.btn_logar);
            this.fb_inicio.Controls.Add(this.lb_login);
            this.fb_inicio.Controls.Add(this.tb_login);
            this.fb_inicio.Controls.Add(this.lb_senha);
            this.fb_inicio.Controls.Add(this.pictureBox2);
            this.fb_inicio.Location = new System.Drawing.Point(12, 106);
            this.fb_inicio.Name = "fb_inicio";
            this.fb_inicio.Size = new System.Drawing.Size(1044, 594);
            this.fb_inicio.TabIndex = 13;
            this.fb_inicio.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::UIL.Properties.Resources.Logomarca_D_Marcos1;
            this.pictureBox1.Location = new System.Drawing.Point(412, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::UIL.Properties.Resources.Logomarca_lado;
            this.pictureBox3.Location = new System.Drawing.Point(882, 137);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 184);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(134, 221);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(150, 20);
            this.tb_senha.TabIndex = 2;
            this.tb_senha.UseSystemPasswordChar = true;
            this.tb_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // btn_remover
            // 
            this.btn_remover.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Location = new System.Drawing.Point(213, 270);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(100, 30);
            this.btn_remover.TabIndex = 4;
            this.btn_remover.Text = "Fechar";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_logar
            // 
            this.btn_logar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logar.Location = new System.Drawing.Point(107, 270);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(100, 30);
            this.btn_logar.TabIndex = 3;
            this.btn_logar.Text = "Logar";
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.BackColor = System.Drawing.Color.LemonChiffon;
            this.lb_login.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.Location = new System.Drawing.Point(131, 157);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(42, 13);
            this.lb_login.TabIndex = 40;
            this.lb_login.Text = "Login:";
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_login.Location = new System.Drawing.Point(134, 172);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(150, 21);
            this.tb_login.TabIndex = 1;
            this.tb_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.BackColor = System.Drawing.Color.LemonChiffon;
            this.lb_senha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(131, 206);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(48, 13);
            this.lb_senha.TabIndex = 41;
            this.lb_senha.Text = "Senha:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::UIL.Properties.Resources.Logomarca_lado;
            this.pictureBox2.Location = new System.Drawing.Point(0, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(962, 184);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // Frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.fb_inicio);
            this.Name = "Frm_Inicio";
            this.Load += new System.EventHandler(this.Frm_Inicio_Load);
            this.Controls.SetChildIndex(this.fb_inicio, 0);
            this.fb_inicio.ResumeLayout(false);
            this.fb_inicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fb_inicio;
        private System.Windows.Forms.MaskedTextBox tb_senha;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}