namespace UIL
{
    partial class Frm_Imp_GrupoProdutosXFornecedorXProduto
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.grupoXFornecedorXProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new UIL.ReportViewer.DataSet1();
            this.rv_GrupoXFornecedorXProduto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grupoXFornecedorXProdutoTableAdapter = new UIL.ReportViewer.DataSet1TableAdapters.GrupoXFornecedorXProdutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grupoXFornecedorXProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoXFornecedorXProdutoBindingSource
            // 
            this.grupoXFornecedorXProdutoBindingSource.DataMember = "GrupoXFornecedorXProduto";
            this.grupoXFornecedorXProdutoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rv_GrupoXFornecedorXProduto
            // 
            this.rv_GrupoXFornecedorXProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.grupoXFornecedorXProdutoBindingSource;
            this.rv_GrupoXFornecedorXProduto.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_GrupoXFornecedorXProduto.LocalReport.ReportEmbeddedResource = "UIL.ReportViewer.Rel_GrupoXFornecedorXProduto.rdlc";
            this.rv_GrupoXFornecedorXProduto.Location = new System.Drawing.Point(0, 0);
            this.rv_GrupoXFornecedorXProduto.Name = "rv_GrupoXFornecedorXProduto";
            this.rv_GrupoXFornecedorXProduto.Size = new System.Drawing.Size(1078, 484);
            this.rv_GrupoXFornecedorXProduto.TabIndex = 0;
            this.rv_GrupoXFornecedorXProduto.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            this.rv_GrupoXFornecedorXProduto.ZoomPercent = 50;
            // 
            // grupoXFornecedorXProdutoTableAdapter
            // 
            this.grupoXFornecedorXProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Imp_GrupoProdutosXFornecedorXProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 484);
            this.Controls.Add(this.rv_GrupoXFornecedorXProduto);
            this.Name = "Frm_Imp_GrupoProdutosXFornecedorXProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Imp_GrupoProdutosXFornecedorXProduto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Imp_GrupoProdutosXFornecedorXProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupoXFornecedorXProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_GrupoXFornecedorXProduto;
       // private System.Windows.Forms.BindingSource grupoXFornecedorXProdutoTableAdapter;
        //  private System.Windows.Forms.BindingSource dataSet1BindingSource;
        //private ReportViewer.DataSet1TableAdapters.GrupoXFornecedorXProdutoTableAdapter grupoXFornecedorXProdutoTableAdapter;
        private ReportViewer.DataSet1TableAdapters.GrupoXFornecedorXProdutoTableAdapter grupoXFornecedorXProdutoTableAdapter1;
        private ReportViewer.DataSet1TableAdapters.GrupoXFornecedorXProdutoTableAdapter grupoXFornecedorXProdutoTableAdapter2;
        private System.Windows.Forms.BindingSource grupoXFornecedorXProdutoBindingSource;
        private ReportViewer.DataSet1 dataSet1;
        private ReportViewer.DataSet1TableAdapters.GrupoXFornecedorXProdutoTableAdapter grupoXFornecedorXProdutoTableAdapter;
    }
}