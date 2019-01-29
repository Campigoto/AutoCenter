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
    public partial class FrmHistorico_Lancamento : Frm_Master
    {
        public FrmHistorico_Lancamento()
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Cadastro de Lançamento");
            gb_historico.Text = Titulo_Grupo("Cadastro");

            Carregar_DGV();
        }

        private void Carregar_DGV()
        {
            Historico_LancamentoCollection Historico_Lancamento_todos;

            if (tb_descricao.Text != string.Empty)
            {
                Historico_Lancamento_todos = new Historico_LancamentoCollection(Historico_LancamentoLoadType.LoadByHistorico_LancamentoDESCRICAO, tb_descricao.Text);
            }
            else
            {
                Historico_Lancamento_todos = new Historico_LancamentoCollection(true);
            }
            dgv_Historico_Lancamento.AutoGenerateColumns = false;
            dgv_Historico_Lancamento.DataSource = Historico_Lancamento_todos;
        }

        private void Carregar_Cadastro(string HIS_CODIGO)
        {
            Historico_Lancamento Historico_Lancamento = new Historico_Lancamento(HIS_CODIGO);

            if (int.Parse(Historico_Lancamento.HIS_CODIGO) > 0)
            {
                tb_codigo.Text    = Historico_Lancamento.HIS_CODIGO;
                tb_descricao.Text = Historico_Lancamento.HIS_DESCRICAO;

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
            tb_descricao.Text = string.Empty;

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

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            Carregar_DGV();
        }
      
        private void tb_codigo_Leave(object sender, EventArgs e)
        {
            if (tb_codigo.Enabled && tb_codigo.Text != string.Empty)
            {
                Carregar_Cadastro(tb_codigo.Text);

                tb_descricao.Focus();
            }
        }
        
        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tb_codigo.Enabled && tb_codigo.Text != string.Empty)
            {
                Carregar_Cadastro(tb_codigo.Text);

                tb_descricao.Focus();
            }
        }
       
        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (tb_descricao.Text == string.Empty)
            {
                MessageBox.Show("Descrição obrigatória!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_descricao.Focus();
            } 
            else
            if (tb_codigo.Text == string.Empty)
            {
                MessageBox.Show("Código obrigatório!", "3Pratos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_descricao.Focus();
            }
            else
            {
                Historico_Lancamento lancamento;

                if (tb_codigo.Text == string.Empty)
                {
                    lancamento = new Historico_Lancamento();
                }
                else
                {
                    lancamento = new Historico_Lancamento(tb_codigo.Text);
                }

                lancamento.HIS_DESCRICAO = tb_descricao.Text;
                lancamento.HIS_CODIGO = tb_codigo.Text;
                lancamento.Salvar();

                Log log = new Log();
                log.LOG_USUARIO = Global.FUN_CODIGO;
                log.LOG_DATA = DateTime.Now;
                log.LOG_TELA = this.Text;
                if (tb_codigo.Text == string.Empty)
                {
                    log.LOG_DESCRICAO = "Cadastrou o histórico de lançamento de código: " + lancamento.HIS_CODIGO.ToString() + " e descrição: " + lancamento.HIS_DESCRICAO + ".";
                }
                else
                {
                    log.LOG_DESCRICAO = "Alterou o histórico de lançamento de código: " + lancamento.HIS_CODIGO.ToString() + " e descrição: " + lancamento.HIS_DESCRICAO + ".";
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

                tb_codigo.Text = lancamento.HIS_CODIGO.ToString();
                tb_codigo.Enabled = false;

                tb_descricao.Focus();
            }
        }

        private void tb_descricao_TextChanged_1(object sender, EventArgs e)
        {
            Carregar_DGV();
        }

        private void dgv_Historico_Lancamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Carregar_Cadastro(dgv_Historico_Lancamento.Rows[e.RowIndex].Cells[0].Value.ToString());
            tb_descricao.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();

            tb_descricao.Focus();
        }
    }
}
