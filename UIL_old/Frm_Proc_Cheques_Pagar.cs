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
    public partial class Frm_Proc_Cheques_Pagar : Frm_Master
    {
        Cheques_PagarCollection cheques_pagar_todos;

        public Frm_Proc_Cheques_Pagar()
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Pesquisa do Cheques a Pagar");
            gb_proc_cheque.Text = Titulo_Grupo("Pesquisa");

            dvg_cheque.AutoGenerateColumns = false;

            cb_criterio.SelectedIndex = 1;

            Carregar_DGV();

            tb_igual.Select();
        }

        private void Carregar_DGV()
        {
            try
            {
                if (tb_igual.Text != string.Empty || cb_criterio.SelectedIndex == 3 || cb_criterio.SelectedIndex == 4 ||
                     cb_criterio.SelectedIndex == 5)
                {
                    switch (cb_criterio.SelectedIndex)
                    {
                        case 0:
                            cheques_pagar_todos = new Cheques_PagarCollection(int.Parse(tb_igual.Text), Cheques_PagarLoadType.LoadById);
                            break;

                        case 1:
                            cheques_pagar_todos = new Cheques_PagarCollection(int.Parse(tb_igual.Text), Cheques_PagarLoadType.LoadByCarne);
                            break;

                        case 2:
                            cheques_pagar_todos = new Cheques_PagarCollection(tb_igual.Text);
                            break;

                        case 3:
                            cheques_pagar_todos = new Cheques_PagarCollection(DateTime.Parse(tb_inicio.Text), DateTime.Parse(tb_final.Text), Cheques_PagarLoadType.LoadByEmissao);
                            break;

                        case 4:
                            cheques_pagar_todos = new Cheques_PagarCollection(DateTime.Parse(tb_inicio.Text), DateTime.Parse(tb_final.Text), Cheques_PagarLoadType.LoadByVencimento);
                            break;

                        case 5:
                            cheques_pagar_todos = new Cheques_PagarCollection(DateTime.Parse(tb_inicio.Text), DateTime.Parse(tb_final.Text), Cheques_PagarLoadType.LoadByEfetivacao);
                            break;

                        default:
                            cheques_pagar_todos = new Cheques_PagarCollection(false);
                            break;
                    }
                }
                else
                {
                    cheques_pagar_todos = new Cheques_PagarCollection(true);
                }
            }
            catch (Exception)
            {
                cheques_pagar_todos = new Cheques_PagarCollection(false);
            }

            dvg_cheque.DataSource = cheques_pagar_todos;

            //Pintar();
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

        private void dvg_cheque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int CHP_CODIGO = int.Parse(dvg_cheque.Rows[e.RowIndex].Cells[0].Value.ToString());

                Frm_Cheques_Pagar form = new Frm_Cheques_Pagar(CHP_CODIGO);
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

            if (cb_criterio.SelectedIndex == 3 || cb_criterio.SelectedIndex == 4 || cb_criterio.SelectedIndex == 5)
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
            Frm_Cheques_Pagar form = new Frm_Cheques_Pagar(0);
            form.Show();

            this.Hide();
        }
    }
}