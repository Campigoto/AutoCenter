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
                            compra_todos = new CompraCollection(int.Parse(tb_igual.Text), CompraLoadType.LoadById);
                            break;

                        case 1:
                            compra_todos = new CompraCollection(int.Parse(tb_igual.Text), CompraLoadType.LoadByNF);
                            break;

                        case 2:
                            compra_todos = new CompraCollection(tb_igual.Text);
                            break;

                        case 3:
                            compra_todos = new CompraCollection(DateTime.Parse(tb_inicio.Text), DateTime.Parse(tb_final.Text));
                            break;

                        default:
                            compra_todos = new CompraCollection(false);
                            break;
                    }
                }
                else
                {
                    compra_todos = new CompraCollection(true);
                }
            }
            catch (Exception)
            {
                compra_todos = new CompraCollection(false);
            }

            dvg_compra.DataSource = compra_todos;
        }

        //private void Pintar()
        //{
        //    foreach (DataGridViewRow row in dvg_contas_pagar.Rows)
        //    {
        //        Contas_Pagar contas_pagar;

        //        try
        //        {
        //            contas_pagar = contas_pagar_todos[row.Index];
        //        }
        //        catch (Exception)
        //        {
        //            contas_pagar = new Contas_Pagar();
        //            contas_pagar. = 0;
        //        }

        //        switch (paciente.STATUS)
        //        {
        //            case 0:
        //                row.DefaultCellStyle.ForeColor = Color.Black;
        //                break;

        //            case 1:
        //                row.DefaultCellStyle.ForeColor = Color.Red;
        //                break;

        //            default:
        //                row.DefaultCellStyle.ForeColor = Color.Black;
        //                break;
        //        }
        //    }
        //}

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dvg_compra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int COM_CODIGO = int.Parse(dvg_compra.Rows[e.RowIndex].Cells[0].Value.ToString());

                Frm_Compra form = new Frm_Compra(COM_CODIGO);
                form.Show();

                this.Hide();
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
            Frm_Compra form = new Frm_Compra(0);
            form.Show();

            this.Hide();
        }
    }
}