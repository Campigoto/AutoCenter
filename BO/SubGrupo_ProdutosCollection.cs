using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BO
{
    public class SubGrupo_ProdutosCollection : List<SubGrupo_Produtos>
    {

        #region Fields
        private int _SGP_ID;
        private int _SGP_CODIGO;
        private int _SGP_GRUPO;
        private string _SGP_NOME;
        private string _SGP_OBS;
        private SubGrupo_ProdutoLoadType _typeLoad;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public SubGrupo_ProdutosCollection() { }

        public SubGrupo_ProdutosCollection(bool isLoad)
        {
            this._typeLoad = SubGrupo_ProdutoLoadType.LoadAll;
            if (isLoad) this.Load();
        }

        public SubGrupo_ProdutosCollection(int SGP_CODIGO)
        {
            this._typeLoad = SubGrupo_ProdutoLoadType.LoadById;
            this._SGP_CODIGO = SGP_CODIGO;                                                   
            this.Load();                                                                       
        }
        public SubGrupo_ProdutosCollection(int SGP_CODIGO, int SGP_GRUPO)
        {
            this._typeLoad = SubGrupo_ProdutoLoadType.LoadByGrupo_SubGrupo;
            this._SGP_CODIGO = SGP_CODIGO;
            this._SGP_GRUPO = SGP_GRUPO; 
            this.Load();
        }

        public SubGrupo_ProdutosCollection(SubGrupo_ProdutoLoadType TIPO, int SGP_GRUPO)
        {
            this._SGP_GRUPO = SGP_GRUPO;
            this._typeLoad = TIPO;
            this.Load();
        }

        public SubGrupo_ProdutosCollection(SubGrupo_ProdutoLoadType TIPO, string SGP_NOME)
        {
            this._SGP_NOME = SGP_NOME;
            this._typeLoad = TIPO;
            this.Load();
        }

        public SubGrupo_ProdutosCollection(SubGrupo_ProdutoLoadType TIPO, string SGP_NOME, int SGP_GRUPO)
        {
            this._SGP_NOME = SGP_NOME;
            this._SGP_GRUPO = SGP_GRUPO;
            this._typeLoad = TIPO;
            this.Load();
        }
        
        #endregion
     
        #region Methods
        private void Load()
        {
            try
            {
                switch (this._typeLoad)
                {
                    case SubGrupo_ProdutoLoadType.LoadAll:
                        this.cmd = new SqlCommand("SELECT SGP_ID,SGP_CODIGO,SGP_CODIGO, SGP_NOME, SGP_OBS FROM SubGrupo_Produto", this.con);
                        cmd.CommandType = CommandType.Text;
                        break;
                    case SubGrupo_ProdutoLoadType.LoadByGrupo_SubGrupo:
                        this.cmd = new SqlCommand("SELECT SGP_ID,SGP_CODIGO,SGP_GRUPO, SGP_NOME, SGP_OBS FROM SubGrupo_Produto WHERE SGP_CODIGO=@SGP_CODIGO AND SGP_GRUPO=@SGP_GRUPO", this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@SGP_CODIGO", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._SGP_CODIGO;
                        this.cmd.Parameters.Add("@SGP_GRUPO", SqlDbType.Int);
                        this.cmd.Parameters[1].Value = this._SGP_GRUPO;
                        break;
                    case SubGrupo_ProdutoLoadType.LoadBySubGrupo_ProdutoNome:
                        this.cmd = new SqlCommand("SELECT SGP_ID,SGP_CODIGO,SGP_GRUPO, SGP_NOME, SGP_OBS FROM SubGrupo_Produto WHERE SGP_NOME COLLATE Latin1_General_CI_AI LIKE '%' + @SGP_NOME + '%'", this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@SGP_NOME", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._SGP_NOME;
                        break;
                    case SubGrupo_ProdutoLoadType.LoadByNome_Grupo:
                        this.cmd = new SqlCommand("SELECT SGP_ID,SGP_CODIGO,SGP_GRUPO, SGP_NOME, SGP_OBS FROM SubGrupo_Produto WHERE  (SGP_GRUPO = @SGP_GRUPO AND SGP_NOME COLLATE Latin1_General_CI_AI LIKE '%' + @SGP_NOME + '%') ", this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@SGP_NOME", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._SGP_NOME;
                        this.cmd.Parameters.Add("@SGP_GRUPO", SqlDbType.Int);
                        this.cmd.Parameters[1].Value = this._SGP_GRUPO;
                        break;
                    case SubGrupo_ProdutoLoadType.LoadBySubGrupo_LoadByGrupo:
                        this.cmd = new SqlCommand("SELECT SGP_ID,SGP_CODIGO,SGP_GRUPO, SGP_NOME, SGP_OBS FROM SubGrupo_Produto WHERE SGP_GRUPO=@SGP_GRUPO", this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@SGP_GRUPO", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._SGP_GRUPO;
                        break;

                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();                     
                while (dr.Read())                                           
                {

                    this.Add(new SubGrupo_Produtos(dr.IsDBNull(0) ? 0  : dr.GetSqlInt32(0).Value,
                                                   dr.IsDBNull(1) ? 0 : dr.GetSqlInt32(1).Value,
                                                   dr.IsDBNull(2) ? 0 : dr.GetSqlInt32(2).Value,
                                                   dr.IsDBNull(3) ? "" : dr.GetSqlString(3).Value,
                                                   dr.IsDBNull(4) ? "" : dr.GetSqlString(4).Value));                     
                }                               
            } 
                                  
            catch (Exception ex)                
            {
                throw ex;
            }
            finally
            {
                if (this.con.State == ConnectionState.Open) this.con.Close();
            }
        }
        #endregion
    }
    
    public enum SubGrupo_ProdutoLoadType
    {
        LoadAll,
        LoadById,
        LoadBySubGrupo_ProdutoNome,
        LoadByGrupo_ProdutoCodigo,
        LoadByGrupo_SubGrupo,
        LoadByNome_Grupo,
        LoadBySubGrupo_LoadByGrupo
        
   
    }
}
