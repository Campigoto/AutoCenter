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
        int ORDER = 1;

        public Frm_Cidade()
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Cadastro de Cidade");
            gb_cidade.Text = Titulo_Grupo("Cadastro");

            cb_uf.SelectedItem = "SC";

            Global.CID_ID = 0;

            Carregar_DGV();
        }

        private void Carregar_DGV()
        {
            CidadeCollection  cidade_todos;

            if (tb_nome.Text != string.Empty)
            {
                cidade_todos = new CidadeCollection(CidadeLoadType.LoadByCidadeNome, tb_nome.Text, ORDER);
            }
            else
            {
                cidade_todos = new CidadeCollection(true, ORDER);
            }

            dgv_cidade.DataSource = cidade_todos;
            dgv_cidade.Columns[0].Visible = false;
            
        }

        private void Carregar_Cadastro(int CID_ID)
        {
            Cidade cidade = new Cidade(CID_ID);

            if (cidade.CID_ID > 0)
            {
                Global.CID_ID = cidade.CID_ID;
                tb_codigo.Text = cidade.CID_CODIGO.ToUpper();
                tb_nome.Text = cidade.CID_NOME.ToUpper();
                cb_uf.SelectedItem = cidade.CID_UF;

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
            cb_uf.SelectedItem = "SC";

            tb_codigo.Enabled = true;
        }

        private void dgv_cidade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Carregar_Cadastro(int.Parse(dgv_cidade.Rows[e.RowIndex].Cells[0].Value.ToString()));
                tb_nome.Focus();
                Global.CID_ID = int.Parse(dgv_cidade.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            else
            {
                ORDER = e.ColumnIndex;
                Carregar_DGV();
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
                Cidade cidade;

                if   (Global.CID_ID == 0)
                    //(tb_codigo.Text == string.Empty)
                {
                    cidade = new Cidade();
                }
                else
                {
                    cidade = new Cidade(Global.CID_ID); //int.Parse(tb_codigo.Text));
                }

                cidade.CID_CODIGO = tb_codigo.Text;
                cidade.CID_NOME = tb_nome.Text.ToUpper();
                cidade.CID_UF = cb_uf.SelectedItem.ToString();
                cidade.Save();

                Global.CID_ID = 0;
                Limpar();
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
                        MessageBox.Show("Cadastro efetuado com sucesso!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Alteração efetuada com sucesso!", "Joincar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (Global.CID_ID == 0)
            {
                Carregar_DGV();
            }
        }
    }
}