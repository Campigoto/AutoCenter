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
    public partial class Frm_Rel_Produtos : Frm_Master
    {
        int GrupoAtual = 0;
        int SubGrupoAtual = 0;

        public Frm_Rel_Produtos()
        {
            InitializeComponent();

            this.Text = Titulo_Tela("Relatório de Produtos");

            // Carrega Grupo
            GrupoProdutoCollection grupo_todos_temp = new GrupoProdutoCollection(true);
            GrupoProdutoCollection grupo_todos = new GrupoProdutoCollection();
            GrupoProduto grupo_temp = new GrupoProduto();
            grupo_temp.GRP_CODIGO = 0;
            grupo_temp.GRP_NOME = "Todos";
            grupo_temp.GRP_OBS = "";
            grupo_todos.Add(grupo_temp);

            foreach (GrupoProduto grupo in grupo_todos_temp)
            {

                grupo_todos.Add(grupo);

            }
            cb_grupo.DataSource = grupo_todos;
            cb_grupo.DisplayMember = "GRP_NOME";
            cb_grupo.ValueMember = "GRP_CODIGO";
            Carrega_SubGrupo(0);



        }

        private void Carrega_SubGrupo(int grupo)
        {
            // Carrega SubGrupo
            if (grupo > 0)
            {
                SubGrupo_ProdutosCollection subgrupo_todos_temp = new SubGrupo_ProdutosCollection(SubGrupo_ProdutoLoadType.LoadBySubGrupo_LoadByGrupo, grupo);
                SubGrupo_ProdutosCollection subgrupo_todos = new SubGrupo_ProdutosCollection();
                SubGrupo_Produtos subgrupo_temp = new SubGrupo_Produtos();
                subgrupo_temp.SGP_CODIGO = 0;
                subgrupo_temp.SGP_GRUPO = 0;
                subgrupo_temp.SGP_NOME = "Todos";
                subgrupo_temp.SGP_OBS = "";
                subgrupo_temp.SGP_ID = 0;
                subgrupo_todos.Add(subgrupo_temp);
                foreach (SubGrupo_Produtos subgrupo in subgrupo_todos_temp)
                {

                    subgrupo_todos.Add(subgrupo);

                }

                cb_subgrupo.DataSource = subgrupo_todos;
                cb_subgrupo.DisplayMember = "SGP_NOME";
                cb_subgrupo.ValueMember = "SGP_CODIGO";
                cb_subgrupo.Select();
                if (cb_subgrupo.Items.Count == 0)             //SelectedIndex > 0)
                {
                    cb_subgrupo.Text = "";
                }
            }
            else
            {
                SubGrupo_ProdutosCollection subgrupo_todos_temp = new SubGrupo_ProdutosCollection();
                SubGrupo_ProdutosCollection subgrupo_todos = new SubGrupo_ProdutosCollection();
                SubGrupo_Produtos subgrupo_temp = new SubGrupo_Produtos();
                subgrupo_temp.SGP_CODIGO = 0;
                subgrupo_temp.SGP_GRUPO = 0;
                subgrupo_temp.SGP_NOME = "Todos";
                subgrupo_temp.SGP_OBS = "";
                subgrupo_temp.SGP_ID = 0;
                subgrupo_todos.Add(subgrupo_temp);
                cb_subgrupo.DataSource = subgrupo_todos;
                cb_subgrupo.DisplayMember = "SGP_NOME";
                cb_subgrupo.ValueMember = "SGP_CODIGO";
                cb_subgrupo.Select();
                if (cb_subgrupo.Items.Count == 0)             //SelectedIndex > 0)
                {
                    cb_subgrupo.Text = "";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVisualizador form = new FrmVisualizador(int.Parse(cb_grupo.SelectedValue.ToString()), int.Parse(cb_subgrupo.SelectedValue.ToString()));
            form.Show();
            this.Enabled = false;


        }

        private void cb_grupo_SelectedValueChanged(object sender, EventArgs e)
        {
            int grupo = 0;
            try
            {
                grupo = int.Parse(cb_grupo.SelectedValue.ToString());
                Carrega_SubGrupo(grupo);
            }
            catch { grupo = 0; }
        }

       
        private void cb_subgrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_grupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
