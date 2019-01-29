namespace UIL
{
    partial class Frm_Impressao
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
            this.relContasPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new UIL.ReportViewer.DataSet1();
            this.ReportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rel_Contas_PagarTableAdapter = new UIL.ReportViewer.DataSet1TableAdapters.Rel_Contas_PagarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.relContasPagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // relContasPagarBindingSource
            // 
            this.relContasPagarBindingSource.DataMember = "Rel_Contas_Pagar";
            this.relContasPagarBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportViewer1
            // 
            reportDataSource1.Name = "DataSet1_Rel_Contas_Pagar";
            reportDataSource1.Value = this.relContasPagarBindingSource;
            this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewer1.LocalReport.ReportEmbeddedResource = "UIL.ReportViewer.Rel_Contas_Pagar.rdlc";
            this.ReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.ReportViewer1.Name = "ReportViewer1";
            this.ReportViewer1.Size = new System.Drawing.Size(900, 500);
            this.ReportViewer1.TabIndex = 1;
            // 
            // rel_Contas_PagarTableAdapter
            // 
            this.rel_Contas_PagarTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Impressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 519);
            this.Controls.Add(this.ReportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Impressao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3Pratos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Impressao_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Impressao_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.relContasPagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer1;
        private System.Windows.Forms.BindingSource relContasPagarBindingSource;
        private UIL.ReportViewer.DataSet1 dataSet1;
        private UIL.ReportViewer.DataSet1TableAdapters.Rel_Contas_PagarTableAdapter rel_Contas_PagarTableAdapter;

    }
}