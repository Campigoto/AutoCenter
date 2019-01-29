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
    public partial class Frm_Funcionario : Frm_Master
    {
        public Frm_Funcionario()
        {
            InitializeComponent();

            dgv_usuario.AutoGenerateColumns = false;

            Carregar_DGV();
            this.Text = Titulo_Tela("Cadastro de Funcionário");
            gb_cad_func.Text = Titulo_Grupo("Cadastro");

            if (Global.FUN_CODIGO > 0)
            {
                Carregar_Cadastro(Global.FUN_CODIGO);

                tb_nome.Focus();
            }
        }

        private void Carregar_DGV()
        {
            FuncionarioCollection funcionario_todos = new FuncionarioCollection(true);

            dgv_usuario.DataSource = funcionario_todos;
        }

        private void Carregar_Cadastro(int FUN_CODIGO)
        {
            Funcionario funcionario = new Funcionario(FUN_CODIGO);

            if (funcionario.FUN_CODIGO > 0)
            {
                tb_codigo.Text = funcionario.FUN_CODIGO.ToString();
                tb_nome.Text = funcionario.FUN_NOME;
                tb_senha.Text = funcionario.FUN_SENHA;
                tb_login.Text = funcionario.FUN_LOGIN;
                tb_despesas.Text = funcionario.FUN_DESPESAS.ToString("0.00");
                cb_usuario.Checked = (funcionario.FUN_USUARIO == 1);
                if (funcionario.FUN_INATIVO == 1)
                {
                    btn_desativar.Text = "Ativar";
                }
                else
                {
                    btn_desativar.Text = "Desativar";
                }

                Carregar_Operacao(funcionario.FUN_CODIGO);

                tb_codigo.Enabled = false;
                btn_desativar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Registro não encontrado!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_codigo.Text = string.Empty;
            }
        }

        private void Carregar_Operacao(int FUN_CODIGO)
        {
            OperacaoCollection operacao_sem_todos = new OperacaoCollection(OperacaoLoadType.LoadBySemOperacao, FUN_CODIGO);
            OperacaoCollection operacao_tem_todos = new OperacaoCollection(OperacaoLoadType.LoadByOperacao, FUN_CODIGO);

            lb_sem.DataSource = operacao_sem_todos;
            lb_tem.DataSource = operacao_tem_todos;

            lb_sem.SelectedIndex = lb_sem.Items.Count - 1;
            lb_tem.SelectedIndex = lb_tem.Items.Count - 1;
        }

        private void Limpar()
        {
            tb_codigo.Text = string.Empty;
            tb_nome.Text = string.Empty;
            tb_senha.Text = string.Empty;
            tb_login.Text = string.Empty;
            tb_despesas.Text = string.Empty;
            cb_usuario.Checked = false;

            OperacaoCollection operacao_todos = new OperacaoCollection(false);

            lb_sem.DataSource = operacao_todos;
            lb_tem.DataSource = operacao_todos;

            tb_codigo.Enabled = true;
            btn_desativar.Enabled = false;
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == string.Empty)
            {
                MessageBox.Show("Nome obrigatório!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_nome.Focus();
            }
            else if (tb_senha.Text == string.Empty)
            {
                MessageBox.Show("Senha obrigatória!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_senha.Focus();
            }
            else if (tb_login.Text == string.Empty)
            {
                MessageBox.Show("Login obrigatório!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_login.Focus();
            }
            else
            {
                Funcionario funcionario;

                if (tb_codigo.Text == string.Empty)
                {
                    funcionario = new Funcionario();
                    funcionario.FUN_CADASTRO = DateTime.Now;
                    funcionario.FUN_INATIVO = 0;
                    funcionario.FUN_OBS = "";
                }
                else
                {
                    funcionario = new Funcionario(int.Parse(tb_codigo.Text));
                }

                funcionario.FUN_NOME = tb_nome.Text;
                funcionario.FUN_SENHA = tb_senha.Text;
                funcionario.FUN_LOGIN = tb_login.Text;
                try
                {
                    funcionario.FUN_DESPESAS = float.Parse(tb_despesas.Text);
                }
                catch (Exception)
                {
                    funcionario.FUN_DESPESAS = 0;
                }
                if (cb_usuario.Checked)
                {
                    funcionario.FUN_USUARIO = 1;
                }
                else
                {
                    funcionario.FUN_USUARIO = 0;
                }
                funcionario.Salvar();

                Log log = new Log();
                log.LOG_USUARIO = Global.FUN_CODIGO;
                log.LOG_DATA = DateTime.Now;
                log.LOG_TELA = this.Text;
                if (tb_codigo.Text == string.Empty)
                {
                    log.LOG_DESCRICAO = "Cadastrou o funcionário de código: " + funcionario.FUN_CODIGO.ToString() + " e nome: " + funcionario.FUN_NOME + ".";
                }
                else
                {
                    log.LOG_DESCRICAO = "Alterou o funcionário de código: " + funcionario.FUN_CODIGO.ToString() + " e nome: " + funcionario.FUN_NOME + ".";
                }
                log.Save();

                Carregar_DGV();

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

                tb_codigo.Text = funcionario.FUN_CODIGO.ToString();
                tb_codigo.Enabled = false;
                btn_desativar.Enabled = true;

                tb_nome.Focus();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();

            tb_nome.Focus();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_codigo.Text != string.Empty)
            {
                if (lb_sem.SelectedIndex >= 0)
                {
                    Operacao operacao;

                    foreach (object item in lb_sem.SelectedItems)
                    {
                        operacao = (Operacao)item;
                        operacao.Salvar(operacao.OPE_CODIGO, int.Parse(tb_codigo.Text));

                        if (tb_codigo.Text == Global.FUN_CODIGO.ToString())
                        {
                            Permitir(operacao.OPE_CODIGO, true);
                        }
                    }

                    Carregar_Operacao(int.Parse(tb_codigo.Text));
                }
            }
            else
            {
                MessageBox.Show("Usuário precisa estar cadastrado antes!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (tb_codigo.Text != string.Empty)
            {
                if (lb_tem.SelectedIndex >= 0)
                {
                    Operacao operacao;

                    foreach (object item in lb_tem.SelectedItems)
                    {
                        operacao = (Operacao)item;
                        operacao.Deletar(operacao.OPE_CODIGO, int.Parse(tb_codigo.Text));

                        if (tb_codigo.Text == Global.FUN_CODIGO.ToString())
                        {
                            Permitir(operacao.OPE_CODIGO, false);
                        }
                    }

                    Carregar_Operacao(int.Parse(tb_codigo.Text));
                }
            }
            else
            {
                MessageBox.Show("Usuário precisa estar cadastrado antes!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgv_usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Carregar_Cadastro(int.Parse(dgv_usuario.Rows[e.RowIndex].Cells[0].Value.ToString()));

            tb_nome.Focus();
        }

        private void tb_codigo_Leave(object sender, EventArgs e)
        {
            if (tb_codigo.Enabled && tb_codigo.Text != string.Empty)
            {
                Carregar_Cadastro(int.Parse(tb_codigo.Text));

                tb_nome.Focus();
            }
        }

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tb_codigo.Enabled && tb_codigo.Text != string.Empty)
            {
                Carregar_Cadastro(int.Parse(tb_codigo.Text));

                tb_nome.Focus();
            }
        }

        private void btn_desativar_Click(object sender, EventArgs e)
        {
            if (tb_codigo.Text != string.Empty)
            {
                Funcionario funcionario = new Funcionario(int.Parse(tb_codigo.Text));

                if (funcionario.FUN_CODIGO > 0)
                {
                    Log log = new Log();
                    log.LOG_USUARIO = Global.FUN_CODIGO;
                    log.LOG_DATA = DateTime.Now;
                    log.LOG_TELA = this.Text;
                    if (btn_desativar.Text == "Desativar")
                    {
                        log.LOG_DESCRICAO = "Desativou o funcionário de código: " + funcionario.FUN_CODIGO.ToString() + " e fornecedor: " + funcionario.FUN_NOME + ".";
                        funcionario.FUN_INATIVO = 1;
                        btn_desativar.Text = "Ativar";

                        if (Configuracoes.Default.Mensagem_Gravar == true)
                        {
                            MessageBox.Show("Funcionário desativado com sucesso!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        log.LOG_DESCRICAO = "Ativou o funcionário de código: " + funcionario.FUN_CODIGO.ToString() + " e fornecedor: " + funcionario.FUN_NOME + ".";
                        funcionario.FUN_INATIVO = 0;
                        btn_desativar.Text = "Desativar";

                        if (Configuracoes.Default.Mensagem_Gravar == true)
                        {
                            MessageBox.Show("Funcionário ativado com sucesso!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    funcionario.Salvar();
                    log.Save();

                    tb_nome.Focus();
                }
            }
        }

        private void Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != ",";
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
    }
}