using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient; 

namespace BO
{
    public class GrupoProdutoCollection : List<GrupoProduto>
    {
        #region Fields
        private int _GRP_CODIGO;
        private string _GRP_OBS;
        private string _GRP_NOME;
        private GrupoProdutoLoadType _typeLoad;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public GrupoProdutoCollection() { }

        public GrupoProdutoCollection(bool isLoad)
        {
            this._typeLoad = GrupoProdutoLoadType.LoadAll;
            if (isLoad) this.Load();
        }

        public GrupoProdutoCollection(int GRP_CODIGO)
        {
            this._typeLoad = GrupoProdutoLoadType.LoadById;
            this._GRP_CODIGO = GRP_CODIGO;                                                   
            this.Load();                                                                       
        }                                                                                  

        public GrupoProdutoCollection(string GRP_NOME)
        {
            this._GRP_NOME = GRP_NOME;
            this._typeLoad = GrupoProdutoLoadType.LoadByGrupoProdutoNome;
            this.Load();
        }

        public GrupoProdutoCollection(GrupoProdutoLoadType TIPO, string GRP_NOME)
        {
            this._GRP_NOME = GRP_NOME;
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
                    case GrupoProdutoLoadType.LoadAll:
                        this.cmd = new SqlCommand("SELECT GRP_CODIGO, GRP_NOME, GRP_OBS FROM Grupo_Produto", this.con);
                        cmd.CommandType = CommandType.Text;
                        break;
                    case GrupoProdutoLoadType.LoadByGrupoProdutoNome:
                        this.cmd = new SqlCommand("SELECT GRP_CODIGO, GRP_NOME, GRP_OBS FROM Grupo_Produto WHERE GRP_NOME COLLATE Latin1_General_CI_AI LIKE '%' + @GRP_NOME + '%'", this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@GRP_NOME", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._GRP_NOME;
                        break;

                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();                     
                while (dr.Read())                                           
                {
                   
                    this.Add(new GrupoProduto (dr.IsDBNull(0) ? 0  : dr.GetSqlInt32(0).Value,
                                               dr.IsDBNull(1) ? ""  : dr.GetSqlString(1).Value,
                                               dr.IsDBNull(2) ? "" : dr.GetSqlString(2).Value));                     
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
    
    public enum GrupoProdutoLoadType
    {
        LoadAll,
        LoadById,
        LoadByGrupoProdutoNome
    }
}
