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
    public partial class Frm_Imp_GrupoProdutosXFornecedor : Form
    {
        public Frm_Imp_GrupoProdutosXFornecedor(DateTime DATA_INICIAL, DateTime DATA_FINAL, int GRUPO)
        {
            InitializeComponent();
            reportViewer1.LocalReport.EnableHyperlinks = true;
            reportViewer1.LocalReport.EnableExternalImages = true;

            reportViewer1.ProcessingMode = ProcessingMode.Local;


            grupoProdutoXFornecedorTableAdapter.Fill(this.dataSet1.GrupoProdutoXFornecedor,DATA_INICIAL, DATA_FINAL, GRUPO);

            ReportParameter[] Paramentros = new ReportParameter[3];
            Paramentros[0] = new ReportParameter("data_inicial", DATA_INICIAL.ToString("dd/MM/yyyy"));
            Paramentros[1] = new ReportParameter("data_final", DATA_FINAL.ToString("dd/MM/yyyy"));
            Paramentros[2] = new ReportParameter("grupo", GRUPO.ToString());

            reportViewer1.Width = Screen.PrimaryScreen.WorkingArea.Width;
            reportViewer1.Height = Screen.PrimaryScreen.WorkingArea.Height - 20;
            reportViewer1.LocalReport.SetParameters(Paramentros);
            reportViewer1.RefreshReport();

        }

        private void Frm_Imp_GrupoProdutosXFornecedor_Load(object sender, EventArgs e)
        {

           this.reportViewer1.RefreshReport();
        }
    }
}
