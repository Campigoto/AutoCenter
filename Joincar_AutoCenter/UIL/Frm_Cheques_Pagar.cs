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
    public partial class Frm_Cheques_Pagar : Frm_Master
    {
        public Frm_Cheques_Pagar(int CHP_CODIGO)
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Cadastro do Cheques a Pagar");
            gb_cheque.Text = Titulo_Grupo("Cadastro");

            Limpar();

            if (CHP_CODIGO > 0)
            {
                Carregar_Cadastro(CHP_CODIGO);
            }

            tb_conta.Select();
        }

        private void Carregar_Cadastro(int CHP_CODIGO)
        {
            Cheques_Pagar cheque_pagar = new Cheques_Pagar(CHP_CODIGO);

            if (cheque_pagar.CHP_CODIGO > 0)
            {
                tb_codigo.Text = cheque_pagar.CHP_CODIGO.ToString();
                tb_conta.Text = cheque_pagar.CHP_CONTA;
                tb_banco.Text = cheque_pagar.CHP_BANCO;
                tb_agencia.Text = cheque_pagar.CHP_AGENCIA;
                tb_num_doc.Text = cheque_pagar.CHP_NUM_DOC;
                tb_valor.Text = cheque_pagar.CHP_VALOR.ToString("0.00");
                tb_emissao.Text = cheque_pagar.CHP_EMISSAO.ToString("dd/MM/yyyy");
                tb_venc.Text = cheque_pagar.CHP_VENC.ToString("dd/MM/yyyy");
                tb_efetivacao.Text = cheque_pagar.CHP_EFETIVACAO.ToString("dd/MM/yyyy");
                tb_obs.Text = cheque_pagar.CHP_OBS;
                if (cheque_pagar.CHP_CARNE > 0)
                {
                    tb_carne.Text = cheque_pagar.CHP_CARNE.ToString();
                    tb_item.Text = cheque_pagar.CHP_ITEM.ToString();
                }

                tb_codigo.Enabled = false;
                btn_excluir.Enabled = true;
            }
            else
            {
                MessageBox.Show("Registro não encontrado!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_codigo.Text = string.Empty;
            }
        }

        public void Limpar()
        {
            tb_codigo.Text = "";
            tb_conta.Text = "";
            tb_banco.Text = "";
            tb_agencia.Text = "";
            tb_num_doc.Text = "";
            tb_valor.Text = "0,00";
            tb_emissao.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_venc.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_efetivacao.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_obs.Text = "";
            tb_carne.Text = "";
            tb_item.Text = "";

            tb_codigo.Enabled = true;
            btn_excluir.Enabled = false;
        }

        private void tb_codigo_Leave(object sender, EventArgs e)
        {
            if (tb_codigo.Enabled && tb_codigo.Text != string.Empty)
            {
                Carregar_Cadastro(int.Parse(tb_codigo.Text));

                tb_conta.Focus();
            }
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != "," && e.KeyChar.ToString() != "\b";
        }

        private void Valor_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            try
            {
                tb.Text = float.Parse(tb.Text).ToString("0.00");
            }
            catch (Exception)
            {
                tb.Text = "0,00";
            }
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tb_codigo.Enabled && tb_codigo.Text != string.Empty)
            {
                Carregar_Cadastro(int.Parse(tb_codigo.Text));

                tb_conta.Focus();
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Frm_Proc_Cheques_Pagar form = new Frm_Proc_Cheques_Pagar();
            form.Show();

            this.Hide();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (tb_valor.Text == "")
            {
                tb_valor.Text = "0,00";
            }
            if (float.Parse(tb_valor.Text) == 0)
            {
                MessageBox.Show("Valor precisa ser maior que zero!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_valor.Focus();
            }
            else
            {
                Cheques_Pagar cheque_pagar;

                if (tb_codigo.Text == string.Empty)
                {
                    cheque_pagar = new Cheques_Pagar();
                    cheque_pagar.CHP_CARNE = 0;
                    cheque_pagar.CHP_ITEM = 0;
                }
                else
                {
                    cheque_pagar = new Cheques_Pagar(int.Parse(tb_codigo.Text));
                }

                cheque_pagar.CHP_CONTA = tb_conta.Text;
                cheque_pagar.CHP_BANCO = tb_banco.Text;
                cheque_pagar.CHP_AGENCIA = tb_agencia.Text;
                cheque_pagar.CHP_NUM_DOC = tb_num_doc.Text;
                try
                {
                    cheque_pagar.CHP_VALOR = float.Parse(tb_valor.Text);
                }
                catch (Exception)
                {
                    cheque_pagar.CHP_VALOR = 0;
                }
                try
                {
                    cheque_pagar.CHP_EMISSAO = DateTime.Parse(tb_emissao.Text);
                }
                catch (Exception)
                {
                    cheque_pagar.CHP_EMISSAO = DateTime.Today;
                }
                try
                {
                    cheque_pagar.CHP_VENC = DateTime.Parse(tb_venc.Text);
                }
                catch (Exception)
                {
                    cheque_pagar.CHP_VENC = DateTime.Today;
                }
                try
                {
                    cheque_pagar.CHP_EFETIVACAO = DateTime.Parse(tb_efetivacao.Text);
                }
                catch (Exception)
                {
                    cheque_pagar.CHP_EFETIVACAO = DateTime.Today;
                }
                cheque_pagar.CHP_OBS = tb_obs.Text;
                cheque_pagar.Salvar();

                Log log = new Log();
                log.LOG_USUARIO = Global.FUN_CODIGO;
                log.LOG_DATA = DateTime.Now;
                log.LOG_TELA = this.Text;
                if (tb_codigo.Text == string.Empty)
                {
                    log.LOG_DESCRICAO = "Cadastrou o cheque de código: " + cheque_pagar.CHP_CODIGO.ToString() + " e número doc.: " + cheque_pagar.CHP_NUM_DOC + ".";
                }
                else
                {
                    log.LOG_DESCRICAO = "Alterou o cheque de código: " + cheque_pagar.CHP_CODIGO.ToString() + " e número doc.: " + cheque_pagar.CHP_NUM_DOC + ".";
                }
                log.Save();

                if (Configuracoes.Default.Mensagem_Gravar == true)
                {
                    if (tb_codigo.Text == string.Empty)
                    {
                        MessageBox.Show("Cadastro efetuado com sucesso!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Alteração efetuada com sucesso!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                tb_codigo.Text = cheque_pagar.CHP_CODIGO.ToString();
                tb_codigo.Enabled = false;
                btn_excluir.Enabled = true;

                tb_conta.Focus();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();

            tb_conta.Focus();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (tb_carne.Text == "")
            {
                if (tb_codigo.Text != "" && MessageBox.Show("Deseja realmente excluir este cheque?", "3Pratos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cheques_Pagar cheque_pagar = new Cheques_Pagar(int.Parse(tb_codigo.Text));

                    if (cheque_pagar.CHP_CODIGO > 0)
                    {
                        cheque_pagar.Deletar();

                        Log log = new Log();
                        log.LOG_USUARIO = Global.FUN_CODIGO;
                        log.LOG_DATA = DateTime.Now;
                        log.LOG_TELA = this.Text;
                        log.LOG_DESCRICAO = "Excluiu o cheque de código: " + cheque_pagar.CHP_CODIGO.ToString() + " e número doc.: " + cheque_pagar.CHP_NUM_DOC + ".";
                        log.Save();

                        Limpar();

                        if (Configuracoes.Default.Mensagem_Gravar == true)
                        {
                            MessageBox.Show("Exclusão efetuada com sucesso!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        tb_conta.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Exclusão permitida apenas com a exclusão da parcela no contas a pagar!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}