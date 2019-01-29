using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BO;

namespace UIL
{
    public partial class Frm_Imp_ProdutosXFornecedor : Form
    {
        public Frm_Imp_ProdutosXFornecedor(DateTime DATA_INICIAL, DateTime DATA_FINAL, int FORNECEDOR, int PRODUTO)
        {
            InitializeComponent();
            
            reportViewer1.LocalReport.EnableHyperlinks = true;
            reportViewer1.LocalReport.EnableExternalImages = true;

            reportViewer1.ProcessingMode = ProcessingMode.Local;

            produtoXFornecedorTableAdapter.Fill(this.dataSet1.ProdutoXFornecedor,FORNECEDOR,DATA_INICIAL, DATA_FINAL, PRODUTO);

            ReportParameter[] Paramentros = new ReportParameter[4];
            Paramentros[0] = new ReportParameter("data_inicial", DATA_INICIAL.ToString("dd/MM/yyyy"));
            Paramentros[1] = new ReportParameter("data_final", DATA_FINAL.ToString("dd/MM/yyyy"));
            Paramentros[2] = new ReportParameter("fornecedor", FORNECEDOR.ToString());
            Paramentros[3] = new ReportParameter("produto", PRODUTO.ToString());

            reportViewer1.Width = Screen.PrimaryScreen.WorkingArea.Width;
            reportViewer1.Height = Screen.PrimaryScreen.WorkingArea.Height - 20;
            reportViewer1.LocalReport.SetParameters(Paramentros);
            reportViewer1.RefreshReport();
        }

        private void Frm_Imp_ProdutosXFornecedor_Load(object sender, EventArgs e)
        {
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.RefreshReport();
        }
    }
}
