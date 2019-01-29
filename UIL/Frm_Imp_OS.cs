using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace UIL
{
    public partial class Frm_Imp_OS : Form
    {
        public Frm_Imp_OS(int OS_ID)
        {
            InitializeComponent();

            reportViewer1.LocalReport.EnableHyperlinks = true;
            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.Width = Screen.PrimaryScreen.WorkingArea.Width;
            reportViewer1.Height = Screen.PrimaryScreen.WorkingArea.Height - 20;

            rel_OSTableAdapter.Fill(dataSet1.Rel_OS, OS_ID);
        }

        private void Frm_Imp_OS_Load(object sender, EventArgs e)
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
