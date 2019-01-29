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
    public partial class Frm_Imp_Contas_Pagar : Form
    {
        public Frm_Imp_Contas_Pagar(int TIPO, DateTime DATA_INICIAL, DateTime DATA_FINAL, int CAP_FORNECEDOR, int CAP_LANCAMENTO, int ORIGEM, int SITUACAO, int SEPARADO)
        {
            InitializeComponent();

            ReportViewer1.LocalReport.EnableHyperlinks = true;
            ReportViewer1.LocalReport.EnableExternalImages = true;

            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            //ReportViewer1.LocalReport.ReportEmbeddedResource = "ReportViewer/Rel_Contas_Pagar.rdlc";

            rel_Contas_PagarTableAdapter.Fill(dataSet1.Rel_Contas_Pagar, DATA_INICIAL, DATA_FINAL, CAP_FORNECEDOR, CAP_LANCAMENTO, ORIGEM.ToString(), SITUACAO.ToString());

            ReportParameter[] Paramentros = new ReportParameter[4];
            Paramentros[0] = new ReportParameter("tipo", TIPO.ToString());
            Paramentros[1] = new ReportParameter("data_inicial", DATA_INICIAL.ToString("dd/MM/yyyy"));
            Paramentros[2] = new ReportParameter("data_final", DATA_FINAL.ToString("dd/MM/yyyy"));
            Paramentros[3] = new ReportParameter("separado", SEPARADO.ToString());

            ReportViewer1.Width = Screen.PrimaryScreen.WorkingArea.Width;
            ReportViewer1.Height = Screen.PrimaryScreen.WorkingArea.Height - 20;
            ReportViewer1.LocalReport.SetParameters(Paramentros);
            ReportViewer1.RefreshReport();
        }

        private void Frm_Impressao_Load(object sender, EventArgs e)
        {
            ReportViewer1.RefreshReport();
        }

        private void Frm_Impressao_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form_aberto in Application.OpenForms)
            {
                if (form_aberto.Text.Contains("Relatório do Contas a Pagar"))
                {
                    Frm_Rel_Contas_Pagar form = (Frm_Rel_Contas_Pagar)form_aberto;
                }
            }
        }
    }
}