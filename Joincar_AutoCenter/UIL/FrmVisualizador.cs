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
    public partial class FrmVisualizador : Form
    {
        public FrmVisualizador( int grupo, int subgrupo)
        {
            InitializeComponent();

            reportViewer1.LocalReport.EnableHyperlinks = true;
            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            // TODO: esta linha de código carrega dados na tabela '_3PratosDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter1.Fill(this.dataSet1.Produto, grupo, subgrupo);
            
            //ReportParameter[] Paramentros = new ReportParameter[4];
            //Paramentros[0] = new ReportParameter("ordem", ordem);
            //Paramentros[1] = new ReportParameter("grupo", grupo.ToString());
            //Paramentros[2] = new ReportParameter("subgrupo", subgrupo.ToString());
            //Paramentros[3] = new ReportParameter("estoque", estoque.ToString());

            ReportParameter[] Paramentros = new ReportParameter[2];
            Paramentros[0] = new ReportParameter("grupo", grupo.ToString());
            Paramentros[1] = new ReportParameter("subgrupo", subgrupo.ToString());

            reportViewer1.Width = Screen.PrimaryScreen.WorkingArea.Width;
            reportViewer1.Height = Screen.PrimaryScreen.WorkingArea.Height - 20;
            reportViewer1.LocalReport.SetParameters(Paramentros);
            reportViewer1.RefreshReport();
        }

        private void FrmVisualizador_Load(object sender, EventArgs e)
        {
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.RefreshReport();
        }

        private void FrmVisualizador_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form_aberto in Application.OpenForms)
            {
                if (form_aberto.Text.Contains("Relatório de Produtos"))
                {
                    Frm_Rel_Produtos form = (Frm_Rel_Produtos)form_aberto;

                    form.Enabled = true;
                }
            }
        }
    }
}
