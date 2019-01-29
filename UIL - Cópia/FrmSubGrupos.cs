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
    public partial class FrmSubGrupos : Frm_Master
    {
        public int GrupoAtual = 0;

        public FrmSubGrupos()
        {
            InitializeComponent();
            dgv_SubGrupo_Produtos.AutoGenerateColumns = false;

            this.Text = Titulo_Tela("Cadastro de Subgrupo");
            gb_subgrupo.Text = Titulo_Grupo("Cadastro");

            Carrega_Grupo();
            Carregar_DGV();
        }

        private void Carrega_Grupo()
        {
            GrupoProdutoCollection grupoData = new GrupoProdutoCollection(true);
            cb_grupo.DataSource = grupoData;
            cb_grupo.DisplayMember = "GRP_NOME";
            cb_grupo.ValueMember = "GRP_CODIGO";
            GrupoAtual = int.Parse(cb_grupo.SelectedValue.ToString());
        }

        private void Carregar_DGV()
        {

                SubGrupo_ProdutosCollection SubGrupo_Produtos_todos;
             
                if (tb_nome.Text != string.Empty)
                {
                    SubGrupo_Produtos_todos = new SubGrupo_ProdutosCollection(SubGrupo_ProdutoLoadType.LoadByNome_Grupo, tb_nome.Text, GrupoAtual);
                }
                else
                {
                    SubGrupo_Produtos_todos = new SubGrupo_ProdutosCollection(SubGrupo_ProdutoLoadType.LoadBySubGrupo_LoadByGrupo, GrupoAtual);
                    
                    //SubGrupo_Produtos_todos = new SubGrupo_ProdutosCollection(true);
                }

                dgv_SubGrupo_Produtos.DataSource = SubGrupo_Produtos_todos;
            
            
        }

        private void Carregar_Cadastro(int SGP_CODIGO, int SGP_GRUPO)
        {
            SubGrupo_Produtos SubGrupo_Produtos = new SubGrupo_Produtos(SGP_CODIGO, SGP_GRUPO);

            if (SubGrupo_Produtos.SGP_CODIGO > 0)
            {
                tb_codigo.Text = SubGrupo_Produtos.SGP_CODIGO.ToString();
                tb_nome.Text = SubGrupo_Produtos.SGP_NOME.ToUpper();
                cb_grupo.SelectedItem = SubGrupo_Produtos.SGP_GRUPO;

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
            tb_obs.Text = string.Empty;
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

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tb_codigo.Enabled && tb_codigo.Text != string.Empty)
            {
                Carregar_Cadastro(int.Parse(tb_codigo.Text),GrupoAtual);

                tb_nome.Focus();
            }
        }

        private void cb_grupo_SelectedIndexChanged(object sender, EventArgs e)
        {
          try
          {
              GrupoAtual = int.Parse(cb_grupo.SelectedValue.ToString());
          }

          catch
          { 
             
              GrupoAtual = 0;
          } 
            
          Carregar_DGV();
        }

        private void cb_grupo_SelectedValueChanged(object sender, EventArgs e)
        {
            
           try
          {
              GrupoAtual = int.Parse(cb_grupo.SelectedValue.ToString());
          }

          catch
          { 
             
              GrupoAtual = 0;
          } 
           

          
        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {

            try
            {
                GrupoAtual = int.Parse(cb_grupo.SelectedValue.ToString());
            }

            catch
            {

                GrupoAtual = 0;
            }

            Carregar_DGV();
        }

        private void dgv_SubGrupo_Produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Carregar_Cadastro(int.Parse(dgv_SubGrupo_Produtos.Rows[e.RowIndex].Cells[0].Value.ToString()), GrupoAtual);
                tb_nome.Focus();
            }
        }

        private void tb_codigo_Leave(object sender, EventArgs e)
        {
             Carregar_Cadastro(int.Parse(tb_codigo.Text), GrupoAtual);

                tb_nome.Focus();
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
                SubGrupo_Produtos subgrupo;

                if (tb_codigo.Text == string.Empty)
                {
                    subgrupo = new SubGrupo_Produtos();
                    SubGrupo_ProdutosCollection SubGrupo_Produtos_Todos = new SubGrupo_ProdutosCollection(SubGrupo_ProdutoLoadType.LoadBySubGrupo_LoadByGrupo, GrupoAtual);

                    subgrupo.SGP_CODIGO = SubGrupo_Produtos_Todos.Count + 1;
                }
                else
                {
                    subgrupo = new SubGrupo_Produtos(int.Parse(tb_codigo.Text), GrupoAtual);
                }
                subgrupo.SGP_GRUPO = GrupoAtual;
                subgrupo.SGP_NOME = tb_nome.Text.ToUpper();
                subgrupo.SGP_OBS = tb_obs.Text.ToUpper();
                subgrupo.Salvar();

                Log log = new Log();
                log.LOG_USUARIO = Global.FUN_CODIGO;
                log.LOG_DATA = DateTime.Now;
                log.LOG_TELA = this.Text;
                if (tb_codigo.Text == string.Empty)
                {
                    log.LOG_DESCRICAO = "Cadastrou o subgrupo de código: " + subgrupo.SGP_CODIGO.ToString() + " e nome: " + subgrupo.SGP_NOME + ".";
                }
                else
                {
                    log.LOG_DESCRICAO = "Alterou o subgrupo de código: " + subgrupo.SGP_CODIGO.ToString() + " e nome: " + subgrupo.SGP_NOME + ".";
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

                tb_codigo.Text = subgrupo.SGP_CODIGO.ToString();
                tb_codigo.Enabled = false;

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
