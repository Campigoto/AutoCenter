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
    public partial class Frm_Proc_Compra : Frm_Master
    {
        CompraCollection compra_todos;
        int ORDER = 2;

        public Frm_Proc_Compra()
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Pesquisa da Compra");
            gb_compra.Text = Titulo_Grupo("Pesquisa");

            dvg_compra.AutoGenerateColumns = false;

            cb_criterio.SelectedIndex = 2;

            Carregar_DGV();

            tb_igual.Select();
        }

        private void Carregar_DGV()
        {
            try
            {
                if (tb_igual.Text != string.Empty || cb_criterio.SelectedIndex == 3)
                {
                    switch (cb_criterio.SelectedIndex)
                    {
                        case 0:
                            compra_todos = new CompraCollection(int.Parse(tb_igual.Text), CompraLoadType.LoadById, ORDER);
                            break;

                        case 1:
                            compra_todos = new CompraCollection(int.Parse(tb_igual.Text), CompraLoadType.LoadByNF, ORDER);
                            break;

                        case 2:
                            compra_todos = new CompraCollection(tb_igual.Text, ORDER);
                            break;

                        case 3:
                            compra_todos = new CompraCollection(DateTime.Parse(tb_inicio.Text), DateTime.Parse(tb_final.Text), ORDER);
                            break;

                        default:
                            compra_todos = new CompraCollection(false, ORDER);
                            break;
                    }
                }
                else
                {
                    compra_todos = new CompraCollection(true, ORDER);
                }
            }
            catch (Exception)
            {
                compra_todos = new CompraCollection(false, ORDER);
            }

            dvg_compra.DataSource = compra_todos;
        }

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dvg_compra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int COM_CODIGO = int.Parse(dvg_compra.Rows[e.RowIndex].Cells[0].Value.ToString());

                Abrir_Frm_Compra(COM_CODIGO);

                this.Hide();
            }
            else
            {
                ORDER = e.ColumnIndex;
                Carregar_DGV();
            }
        }

        private void tb_igual_TextChanged(object sender, EventArgs e)
        {
            Carregar_DGV();
        }

        private void cb_criterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_igual.Text = string.Empty;

            if (cb_criterio.SelectedIndex == 3)
            {
                lbl_igual.Text = "Início:";
                tb_igual.Visible = false;
                tb_inicio.Visible = true;
                lbl_final.Visible = true;
                tb_final.Visible = true;

                tb_inicio.Focus();
            }
            else
            {
                lbl_igual.Text = "Igual a:";
                tb_igual.Visible = true;
                tb_inicio.Visible = false;
                lbl_final.Visible = false;
                tb_final.Visible = false;

                tb_igual.Focus();
            }

            Carregar_DGV();
        }

        private void tb_inicio_Leave(object sender, EventArgs e)
        {
            Carregar_DGV();
        }

        private void tb_final_Leave(object sender, EventArgs e)
        {
            Carregar_DGV();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            Abrir_Frm_Compra(0);

            this.Hide();
        }

        private void dvg_compra_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            /* Pegando valor de uma celula do DataGridView */
            string Valor =  dvg_compra.Rows[e.RowIndex].Cells[5].Value.ToString();
            
            if (Valor == "1")
            {
                    /* Alterando cor do Fundo */
                   //dvg_compra.CurrentRow.DefaultCellStyle.BackColor = Color.Blue;
                    /* Alterando cor da fonte */
                    dvg_compra.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
        }
    }
}