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
    public partial class FrmGrupos : Frm_Master
    {
        public FrmGrupos()
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Cadastro de Grupo");
            gb_grupo.Text = Titulo_Grupo("Cadastro");

            Carregar_DGV();
        }

        private void Carregar_DGV()
        {
            GrupoProdutoCollection GrupoProduto_todos;

            if (tb_nome.Text != string.Empty)
            {
                GrupoProduto_todos = new GrupoProdutoCollection(GrupoProdutoLoadType.LoadByGrupoProdutoNome, tb_nome.Text);
            }
            else
            {
                GrupoProduto_todos = new GrupoProdutoCollection(true);
            }

            dgv_GrupoProduto.DataSource = GrupoProduto_todos;
        }

        private void Carregar_Cadastro(int GRP_CODIGO)
        {
            GrupoProduto GrupoProduto = new GrupoProduto(GRP_CODIGO);

            if (GrupoProduto.GRP_CODIGO > 0)
            {
                tb_codigo.Text = GrupoProduto.GRP_CODIGO.ToString();
                tb_nome.Text = GrupoProduto.GRP_NOME.ToUpper();
                tb_obs.Text = GrupoProduto.GRP_OBS.ToUpper();

                tb_codigo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Registro não encontrado!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_codigo.Text = string.Empty;
            }
        }

        private void Limpar()
        {
            tb_codigo.Text = string.Empty;
            tb_nome.Text = string.Empty;
            tb_obs.Text = "";

            tb_codigo.Enabled = true;
        }
       
        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {
            Carregar_DGV();
        }

        private void dgv_GrupoProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Carregar_Cadastro(int.Parse(dgv_GrupoProduto.Rows[e.RowIndex].Cells[0].Value.ToString()));

                tb_nome.Focus();
            }
        }

        private void tb_codigo_Leave(object sender, EventArgs e)
        {
            if (tb_codigo.Enabled && tb_codigo.Text != string.Empty)
            {
                Carregar_Cadastro(int.Parse(tb_codigo.Text));

                tb_nome.Focus();
            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == string.Empty)
            {
                MessageBox.Show("Nome obrigatório!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_nome.Focus();
            }
            else
            {
                GrupoProduto grupo;

                if (tb_codigo.Text == string.Empty)
                {
                    grupo = new GrupoProduto();
                    tb_codigo.Text = "0";
                }
                else
                {
                    grupo = new GrupoProduto(int.Parse(tb_codigo.Text));
                }

                grupo.GRP_NOME = tb_nome.Text.ToUpper();
                grupo.GRP_OBS = tb_obs.Text.ToUpper();
                grupo.Salvar(int.Parse(tb_codigo.Text));

                Log log = new Log();
                log.LOG_USUARIO = Global.FUN_CODIGO;
                log.LOG_DATA = DateTime.Now;
                log.LOG_TELA = this.Text;
                if (tb_codigo.Text == string.Empty)
                {
                    log.LOG_DESCRICAO = "Cadastrou o grupo de código: " + grupo.GRP_CODIGO.ToString() + " e descrição: " + grupo.GRP_NOME + ".";
                }
                else
                {
                    log.LOG_DESCRICAO = "Alterou o grupo de código: " + grupo.GRP_CODIGO.ToString() + " e descrição: " + grupo.GRP_NOME + ".";
                }
                log.Save();

                Carregar_DGV();

                if (Configuracoes.Default.Mensagem_Gravar == true)
                {
                    if (tb_codigo.Text == string.Empty)
                    {
                        MessageBox.Show("Cadastro efetuado com sucesso!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Alteração efetuada com sucesso!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                tb_codigo.Text = grupo.GRP_CODIGO.ToString();
                tb_codigo.Enabled = false;

                tb_nome.Focus();
            }
        }
       
        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tb_codigo.Enabled && tb_codigo.Text != string.Empty)
            {
                Carregar_Cadastro(int.Parse(tb_codigo.Text));

                tb_nome.Focus();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();

            tb_nome.Focus();
        }
    }
}
