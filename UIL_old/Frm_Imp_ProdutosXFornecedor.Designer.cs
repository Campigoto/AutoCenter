﻿namespace UIL
{
    partial class Frm_Imp_ProdutosXFornecedor
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.produtoXFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new UIL.ReportViewer.DataSet1();
            this.produtoXFornecedorTableAdapter = new UIL.ReportViewer.DataSet1TableAdapters.ProdutoXFornecedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.produtoXFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.produtoXFornecedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UIL.ReportViewer.ProdutoXFornecedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1094, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // produtoXFornecedorBindingSource
            // 
            this.produtoXFornecedorBindingSource.DataMember = "ProdutoXFornecedor";
            this.produtoXFornecedorBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoXFornecedorTableAdapter
            // 
            this.produtoXFornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Imp_ProdutosXFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 522);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Imp_ProdutosXFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Imp_ProdutosXFornecedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Imp_ProdutosXFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoXFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportViewer.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource produtoXFornecedorBindingSource;
        private ReportViewer.DataSet1TableAdapters.ProdutoXFornecedorTableAdapter produtoXFornecedorTableAdapter;
    }
}