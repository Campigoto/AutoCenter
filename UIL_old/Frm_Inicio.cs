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
    public partial class Frm_Inicio : Frm_Master
    {
        public Frm_Inicio()
        {
            InitializeComponent();

            Connection.ConnectionString = Configuracoes.Default.Conexao;

            this.Text = Titulo_Tela("In�cio");

            if (Global.FUN_CODIGO > 0)
            {
                Carregar_Cadastro(Global.FUN_CODIGO);

                btn_logar.Focus();
            }
            else if (Configuracoes.Default.Login_Automatico)
            {
                tb_login.Text = Configuracoes.Default.Usuario;
                tb_senha.Text = Configuracoes.Default.Senha;

                Logar();
            }
            else
            {
                tb_login.Focus();
            }
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void Logar()
        {
            if (btn_logar.Text == "Logar")
            {
                if (tb_login.Text == string.Empty)
                {
                    MessageBox.Show("Login obrigat�rio!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_login.Focus();
                }
                else if (tb_senha.Text == string.Empty)
                {
                    MessageBox.Show("Senha obrigat�rio!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_senha.Focus();
                }
                else
                {
                    Funcionario funcionario = new Funcionario(tb_login.Text, tb_senha.Text);

                    if (funcionario.FUN_CODIGO > 0)
                    {
                        if (funcionario.FUN_USUARIO == 1)
                        {
                            OperacaoCollection operacao_tem_todos = new OperacaoCollection(OperacaoLoadType.LoadByOperacao, funcionario.FUN_CODIGO);

                            Global.FUN_CODIGO = funcionario.FUN_CODIGO;
                            Global.FUN_NOME = funcionario.FUN_NOME.ToUpper();

                            foreach (Operacao operacao in operacao_tem_todos)
                            {
                                Permitir(operacao.OPE_CODIGO, true);
                            }

                            Carregar_Cadastro(funcionario.FUN_CODIGO);

                            btn_logar.Text = "Logout";

                            Log log = new Log();
                            log.LOG_USUARIO = Global.FUN_CODIGO;
                            log.LOG_DATA = DateTime.Now;
                            log.LOG_TELA = this.Text;
                            log.LOG_DESCRICAO = "Logou no sistema.";
                            log.Save();

                            btn_logar.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Funcion�rio n�o foi definido com usu�rio!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tb_login.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Funcion�rio n�o encontrado!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_login.Focus();
                    }
                }
            }
            else
            {
                Permitir(1, false);
                Permitir(4, false);
                Permitir(7, false);
                Permitir(10, false);
                Permitir(13, false);
                Permitir(16, false);
                Permitir(19, false);
                Permitir(22, false);
                Permitir(25, false);
                Permitir(28, false);
                Permitir(29, false);
                Permitir(31, false);
                Permitir(32, false);
                Permitir(33, false);
                Permitir(34, false);

                tb_login.Text = string.Empty;
                tb_senha.Text = string.Empty;

                tb_login.Enabled = true;
                tb_senha.Enabled = true;

                btn_logar.Text = "Logar";

                tb_login.Focus();
            }
        }

        private void Carregar_Cadastro(int FUN_CODIGO)
        {
            Funcionario funcionario = new Funcionario(FUN_CODIGO);

            if (funcionario.FUN_CODIGO > 0)
            {
                tb_login.Text = funcionario.FUN_LOGIN;
                tb_senha.Text = funcionario.FUN_SENHA;

                tb_login.Enabled = false;
                tb_senha.Enabled = false;

                this.Text = Titulo_Tela("Inicio");
                btn_logar.Text = "Logout";
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }
    }
}