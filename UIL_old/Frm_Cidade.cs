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
    public partial class Frm_Cidade : Frm_Master
    {
        public Frm_Cidade()
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Cadastro de Cidade");
            gb_cidade.Text = Titulo_Grupo("Cadastro");

            cb_uf.SelectedItem = "SC";

            Carregar_DGV();
        }

        private void Carregar_DGV()
        {
            CidadeCollection  cidade_todos;

            if (tb_nome.Text != string.Empty)
            {
                cidade_todos = new CidadeCollection(CidadeLoadType.LoadByCidadeNome, tb_nome.Text);
            }
            else
            {
                cidade_todos = new CidadeCollection(true);
            }

            dgv_cidade.DataSource = cidade_todos;
            
        }

        private void Carregar_Cadastro(int CID_CODIGO)
        {
            Cidade cidade = new Cidade(CID_CODIGO);

            if (cidade.CID_CODIGO > 0)
            {
                tb_codigo.Text = cidade.CID_CODIGO.ToString();
                tb_nome.Text = cidade.CID_NOME;
                cb_uf.SelectedItem = cidade.CID_UF;

                tb_codigo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Registro não encontrado!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_codigo.Text = string.Empty;
            }
        }

        private void Limpar()
        {
            tb_codigo.Text = string.Empty;
            tb_nome.Text = string.Empty;
            cb_uf.SelectedItem = "SC";

            tb_codigo.Enabled = true;
        }

        private void dgv_cidade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Carregar_Cadastro(int.Parse(dgv_cidade.Rows[e.RowIndex].Cells[0].Value.ToString()));

            tb_nome.Focus();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == string.Empty)
            {
                MessageBox.Show("Nome obrigatório!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_nome.Focus();
            }
            else
            {
                Cidade cidade;

                if (tb_codigo.Text == string.Empty)
                {
                    cidade = new Cidade();
                }
                else
                {
                    cidade = new Cidade(int.Parse(tb_codigo.Text));
                }

                cidade.CID_NOME = tb_nome.Text;
                cidade.CID_UF = cb_uf.SelectedItem.ToString();
                cidade.Save();

                Carregar_DGV();

                Log log = new Log();
                log.LOG_USUARIO = Global.FUN_CODIGO;
                log.LOG_DATA = DateTime.Now;
                log.LOG_TELA = this.Text;
                if (tb_codigo.Text == string.Empty)
                {
                    log.LOG_DESCRICAO = "Cadastrou a cidade de código: " + cidade.CID_CODIGO.ToString() + " e nome: " + cidade.CID_NOME + ".";
                }
                else
                {
                    log.LOG_DESCRICAO = "Alterou a cidade de código: " + cidade.CID_CODIGO.ToString() + " e nome: " + cidade.CID_NOME + ".";
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

                tb_codigo.Text = cidade.CID_CODIGO.ToString();
                tb_codigo.Enabled = false;

                tb_nome.Focus();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();

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

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {
            Carregar_DGV();
        }
    }
}