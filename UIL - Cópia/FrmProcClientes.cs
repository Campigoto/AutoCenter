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
    public partial class FrmProcClientes : Frm_Master
    {
        int ORDER = 1;

        public FrmProcClientes()
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Pesquisa de Cliente");
            gb_cliente.Text = Titulo_Grupo("Pesquisa");

            Global.CLI_CODIGO = 0;

            cb_criterio.SelectedIndex = 1;

            Carregar_DGV();

            tb_igual.Select();
        }

        private void Carregar_DGV()
        {
            ClienteCollection cliente_todos;

            if (cb_criterio.SelectedIndex == 0 && tb_igual.Text != "")
            {
                try
                {
                    cliente_todos = new ClienteCollection(int.Parse(tb_igual.Text), ORDER);
                }
                catch (Exception)
                {
                    cliente_todos = new ClienteCollection(true, ORDER);
                }
            }
            else if (cb_criterio.SelectedIndex == 1 && tb_igual.Text != "")
            {
                cliente_todos = new ClienteCollection(ClienteLoadType.LoadByNome, tb_igual.Text, ORDER);
            }
            else
            {
                cliente_todos = new ClienteCollection(true, ORDER);
            }
            dgv_Cliente.AutoGenerateColumns = false;
            dgv_Cliente.DataSource = cliente_todos;
        }

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tb_igual_TextChanged(object sender, EventArgs e)
        {
            Carregar_DGV();
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgv_Cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Global.CLI_CODIGO = int.Parse(dgv_Cliente.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.Close();

                FrmClientes form = new FrmClientes();
                form.Show();
            }
            else
            {
                ORDER = e.ColumnIndex;
                Carregar_DGV();
            }
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmClientes form = new FrmClientes();
            form.Show();
        }

        private void cb_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_criterio.SelectedIndex == 0)
            {
                tb_igual.KeyPress += Numero_KeyPress;
                tb_igual.MaxLength = 10;
            }
            else
            {
                tb_igual.KeyPress -= Numero_KeyPress;
                tb_igual.MaxLength = 150;
            }
            tb_igual.Text = "";
            tb_igual.Focus();
        }

        private void dgv_Cliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3) 
            {
                DataGridViewColumn col = dgv_Cliente.Columns[e.ColumnIndex];
             
               this.dgv_Cliente.Columns[e.ColumnIndex].DefaultCellStyle.Format = "(999)9999-99";
    
               
            }
        }

        //protected string FormataString(string mascara, string valor)
        //{

        //    string novoValor = string.Empty;

        //    int posicao = 0;

        //    for (int i = 0; mascara.Length > i; i++)
        //    {

        //        if (mascara[i] == "#")
        //        {

        //            if (valor.Length > posicao)
        //            {

        //                novoValor = novoValor + valor[posicao];

        //                posicao++;

        //            }

        //            else

        //                break;

        //        }

        //        else
        //        {

        //            if (valor.Length > posicao)

        //                novoValor = novoValor + mascara[i];

        //            else

        //                break;

        //        }

        //    }

        //    return novoValor;

        //}
    }
}
