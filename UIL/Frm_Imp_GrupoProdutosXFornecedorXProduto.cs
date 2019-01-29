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
    public partial class Frm_Imp_GrupoProdutosXFornecedorXProduto : Form
    {
        public Frm_Imp_GrupoProdutosXFornecedorXProduto(DateTime DATA_INICIAL, DateTime DATA_FINAL, int GRUPO, int FORNECEDOR, int PRODUTO)
        {
            InitializeComponent();
            rv_GrupoXFornecedorXProduto.LocalReport.EnableHyperlinks = true;
            rv_GrupoXFornecedorXProduto.LocalReport.EnableExternalImages = true;

            rv_GrupoXFornecedorXProduto.ProcessingMode = ProcessingMode.Local;

            grupoXFornecedorXProdutoTableAdapter.Fill(this.dataSet1.GrupoXFornecedorXProduto,FORNECEDOR,DATA_INICIAL,DATA_FINAL, PRODUTO,GRUPO);

            ReportParameter[] Paramentros = new ReportParameter[5];
            Paramentros[0] = new ReportParameter("data_inicial", DATA_INICIAL.ToString("dd/MM/yyyy"));
            Paramentros[1] = new ReportParameter("data_final", DATA_FINAL.ToString("dd/MM/yyyy"));
            Paramentros[2] = new ReportParameter("grupo", GRUPO.ToString());
            Paramentros[3] = new ReportParameter("fornecedor", FORNECEDOR.ToString());
            Paramentros[4] = new ReportParameter("produto", PRODUTO.ToString());

            rv_GrupoXFornecedorXProduto.Width = Screen.PrimaryScreen.WorkingArea.Width;
            rv_GrupoXFornecedorXProduto.Height = Screen.PrimaryScreen.WorkingArea.Height - 20;
            rv_GrupoXFornecedorXProduto.LocalReport.SetParameters(Paramentros);
            rv_GrupoXFornecedorXProduto.RefreshReport();
        }

        private void Frm_Imp_GrupoProdutosXFornecedorXProduto_Load(object sender, EventArgs e)
        {
            this.rv_GrupoXFornecedorXProduto.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.rv_GrupoXFornecedorXProduto.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rv_GrupoXFornecedorXProduto.RefreshReport();
        }

       
    }
}
