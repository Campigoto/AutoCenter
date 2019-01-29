using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BO;

namespace UIL
{
    public partial class FormataValorGridView : Form
    {
        private String FormName;
        private String ColumnName;
        private DataGridView GridView;
        private Int32 RowIndex;

        /// <summary>
        /// Metodo para formatar valores decimais de uma gridview.
        /// <para> Deve-se passar nome da gridview, nome da coluna da grid, nome da Form, e linha da celula da grid.</para>
        /// </summary>
        /// <param name="_GridView"> Nome da DataGridView a ser alterada </param>
        /// <param name="_ColumnName"> Nome da Coluna </param>
        /// <param name="_FormName"> Nome da Janela </param>
        /// <param name="_RowIndex"> Linha da GridView que se encontra a celula a ser alterada </param>
        public FormataValorGridView(DataGridView _GridView, String _ColumnName, String _FormName, Int32 _RowIndex)
        {
            GridView = new DataGridView();
            this.FormName = _FormName;
            this.ColumnName = _ColumnName;
            this.GridView = _GridView;
            this.RowIndex = _RowIndex;

            InitializeComponent();
            novoValor.Text = GridView[ColumnName, RowIndex].Value.ToString();
            this.Text = "Novo Valor";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == FormName)
                {
                    GridView[ColumnName, RowIndex].Value = novoValor.Text;
                    break;
                }
            }

            this.Close();
        }

        private void novoValor_TextChanged(object sender, EventArgs e)
        {
            novoValor.Text = Global.formatString(novoValor.Text,0);
            novoValor.SelectionStart = novoValor.Text.Length + 1;
        }

        private void novoValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ok_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btn_cancelar_Click(sender, e);
            }
        }


    }
}
