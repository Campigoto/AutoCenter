using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BO;

namespace UIL
{
    public partial class Frm_Imp_CompVenda : Form
    {
        public Frm_Imp_CompVenda(int cod_compra, int tipo_mov, int tipo_lanc, string reportTitle)
        {
            InitializeComponent();

            reportViewer1.LocalReport.EnableHyperlinks = true;
            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.Width = Screen.PrimaryScreen.WorkingArea.Width;
            reportViewer1.Height = Screen.PrimaryScreen.WorkingArea.Height - 20;

            compra_VendaTableAdapter.Connection.ConnectionString = Connection.ConnectionString;
            compra_VendaTableAdapter.Fill(dataSet11.Compra_Venda , tipo_mov, tipo_lanc,cod_compra);
            /*
            compra_VendaTableAdapter.Fill(dataSet11.Compra_Venda, cod_compra, tipo_mov, tipo_lanc);
            */
            ReportParameter[] Paramentros = new ReportParameter[1];
            Paramentros[0] = new ReportParameter("title1", reportTitle);

            reportViewer1.LocalReport.SetParameters(Paramentros);
            reportViewer1.RefreshReport();
        }

        private void Frm_Imp_CompVenda_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            System.Drawing.Printing.PageSettings ps = new System.Drawing.Printing.PageSettings();
            ps.Margins.Top = 1;
            ps.Margins.Bottom = 1;
            ps.Margins.Left = 1;
            ps.Margins.Right = 1;
            reportViewer1.SetPageSettings(ps);
            this.reportViewer1.RefreshReport();
        }
    }
}
