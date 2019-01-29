using System;
using System.Collections.Generic;                                                                    
using System.Text;                                                                                   
using System.Data;                                                                                   
using System.Data.SqlClient;                         
                                                                                                     
namespace BO                                                                                         
{                                                                                                    
    public class ProdutoCollection : List<Produto>                                                   
    {                                                                                                
        #region Fields
        private int _PRO_CODIGO;
        private int _ORDER;
        private string _PRO_NOME;
        private string _PRO_CODIGO_ORIGINAL1;
        private ProdutoLoadType _typeLoad;
        private SqlCommand cmd;
        private StringBuilder _CONSULTA;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public ProdutoCollection() { }                                                                                             
                                                                                                                                   
        public ProdutoCollection(bool isLoad, int ORDER)                                                                                      
        {                                                                                                                          
            this._typeLoad = ProdutoLoadType.LoadAll;
            this._ORDER = ORDER;                                                               
            if (isLoad) this.Load();                                                                                               
        }

        public ProdutoCollection(int PRO_CODIGO, int ORDER)                                                                                   
        {                                                                                                                          
            this._typeLoad = ProdutoLoadType.LoadById;                                                                             
            this._PRO_CODIGO = PRO_CODIGO;
            this._ORDER = ORDER;                       
            this.Load();                                                                       
        }

        public ProdutoCollection(string PRO_NOME, int ORDER)
        {
            this._PRO_NOME = PRO_NOME;
            this._typeLoad = ProdutoLoadType.LoadByNome;
            this._ORDER = ORDER;
            this.Load();
        }

        //public ProdutoCollection(string PRO_CODIGO_ORIGINAL1) //, int ORDER)
        //{
        //    this._PRO_CODIGO_ORIGINAL1 = PRO_CODIGO_ORIGINAL1;
        //    this._typeLoad = ProdutoLoadType.LoadByFabr;
        //   // this._ORDER = ORDER;
        //    this.Load();
        //}
        public ProdutoCollection(ProdutoLoadType TIPO, string PRO_NOME, int ORDER)
        {
            if (TIPO == ProdutoLoadType.LoadByFabr)
                this._PRO_CODIGO_ORIGINAL1 = PRO_NOME;
            else
            this._PRO_NOME = PRO_NOME;
            this._typeLoad = TIPO;
            this._ORDER = ORDER;
            this.Load();
        }
        #endregion
     
        #region Methods
        private void Load()
        {
            try
            {
                this._CONSULTA = new StringBuilder();
                this._CONSULTA.Append("SELECT PRO_CODIGO, PRO_GRUPO,GRP_NOME,PRO_INATIVO,PRO_ULT_COMPRA,PRO_NOME,PRO_REFERENCIA,PRO_UNIDADE, ");
                this._CONSULTA.Append("PRO_OBS,PRO_PRECO_COMPRA ,PRO_ESTOQUE,PRO_EST_MINIMO,PRO_SUBGRUPO,SGP_NOME,COM_DATA,");
                this._CONSULTA.Append("PRO_PRECO_VENDA,PRO_PRECO_VALOR,PRO_PERCENTUAL_GANHO,PRO_PERCENTUAL_IND_FABRICA,PRO_PRECO_TABELA," );
                this._CONSULTA.Append("PRO_PERCENTUAL_ABATE,PRO_CODIGO_ORIGINAL1,PRO_CODIGO_ORIGINAL,PRO_QTDADE_ULT_ENTR,PRO_DESCRICAO_LOCAL,PRO_ULTIMO_FORNECEDOR ");
                this._CONSULTA.Append("FROM Produto LEFT JOIN Compra ON PRO_ULT_COMPRA = COM_CODIGO ");
                this._CONSULTA.Append("LEFT JOIN Subgrupo_Produto ON PRO_SUBGRUPO = SGP_CODIGO ");
                this._CONSULTA.Append("LEFT JOIN Grupo_Produto ON PRO_GRUPO = GRP_CODIGO ");

         
                switch (this._typeLoad)
                {
                    case ProdutoLoadType.LoadAll:
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;
                        break;
                    case ProdutoLoadType.LoadByNome:
                        this._CONSULTA.Append("WHERE PRO_NOME COLLATE Latin1_General_CI_AI LIKE @PRO_NOME + '%' ");
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@PRO_NOME", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._PRO_NOME;
                        break;
                    case ProdutoLoadType.LoadById:
                        this._CONSULTA.Append("WHERE PRO_CODIGO = @PRO_CODIGO ");
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@PRO_CODIGO", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._PRO_CODIGO;
                        break;
                    case ProdutoLoadType.LoadByFabr:
                        this._CONSULTA.Append("WHERE PRO_CODIGO_ORIGINAL1 COLLATE Latin1_General_CI_AI LIKE @PRO_CODIGO_ORIGINAL1 + '%'  ");
                        this._CONSULTA.Append(Order());
                        this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@PRO_CODIGO_ORIGINAL1", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._PRO_CODIGO_ORIGINAL1;
                        break;

                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();                     
                while (dr.Read())                                           
                {
                    this.Add(new Produto(dr.IsDBNull(0) ? 0  : dr.GetSqlInt32(0).Value,                                         
                                         dr.IsDBNull(1) ? 0  : dr.GetSqlInt32(1).Value, 
                                         dr.IsDBNull(2) ? "" : dr.GetSqlString(2).Value,                    
                                         dr.IsDBNull(3) ? 0  : dr.GetSqlInt32(3).Value,                    
                                         dr.IsDBNull(4) ? 0  : dr.GetSqlInt32(4).Value,                    
                                         dr.IsDBNull(5) ? "" : dr.GetSqlString(5).Value,                   
                                         dr.IsDBNull(6) ? "" : dr.GetSqlString(6).Value,                   
                                         dr.IsDBNull(7) ? "" : dr.GetSqlString(7).Value,                   
                                         dr.IsDBNull(8) ? "" : dr.GetSqlString(8).Value,                   
                                         dr.IsDBNull(9) ? 0  : float.Parse(dr.GetSqlDouble(9).ToString()), 
                                         dr.IsDBNull(10) ? 0 : float.Parse(dr.GetSqlDouble(10).ToString()), 
                                         dr.IsDBNull(11) ? 0 : float.Parse(dr.GetSqlDouble(11).ToString()), 
                                         dr.IsDBNull(12) ? 0 : dr.GetSqlInt32(12).Value,
                                         dr.IsDBNull(13) ? "": dr.GetSqlString(13).Value,
                                         dr.IsDBNull(14) ? DateTime.Parse("01/01/1800") : dr.GetSqlDateTime(14).Value,
                                         dr.IsDBNull(15) ? 0 : float.Parse(dr.GetSqlDouble(15).ToString()),
                                         dr.IsDBNull(16) ? 0 : float.Parse(dr.GetSqlDouble(16).ToString()),
                                         dr.IsDBNull(17) ? 0 : float.Parse(dr.GetSqlDouble(17).ToString()),
                                         dr.IsDBNull(18) ? 0 : float.Parse(dr.GetSqlDouble(18).ToString()),
                                         dr.IsDBNull(19) ? 0 : float.Parse(dr.GetSqlDouble(19).ToString()),
                                         dr.IsDBNull(20) ? 0 : float.Parse(dr.GetSqlDouble(20).ToString()),                  
                                         dr.IsDBNull(21) ? "": dr.GetSqlString(21).Value,                   
                                         dr.IsDBNull(22) ? "": dr.GetSqlString(22).Value,
                                         dr.IsDBNull(23) ? 0 : float.Parse(dr.GetSqlDouble(23).ToString()),
                                         dr.IsDBNull(24) ? "": dr.GetSqlString(24).Value,
                                         dr.IsDBNull(25) ? 0 : dr.GetSqlInt32(25).Value));  
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

        private string Order()
        {
            string ordenado = "ORDER BY ";

            switch (this._ORDER)
            {
                case 0:
                    ordenado += "PRO_CODIGO ";
                    break;
                case 1:
                    ordenado += "PRO_NOME ";
                    break;
                case 2:
                    ordenado += "GRP_NOME ";
                    break;
                case 3:
                    ordenado += "SGP_NOME ";
                    break;
                case 4:
                    ordenado += "PRO_CODIGO_ORIGINAL1 ";
                    break;
                case 5:
                    ordenado += "PRO_PRECO_COMPRA ";
                    break;
                case 6:
                    ordenado += "PRO_ESTOQUE ";
                    break;
                case 7:
                    ordenado += "COM_DATA ";
                    break;
                default:
                    ordenado += "PRO_NOME ";
                    break;
            }
            return ordenado;
        }
        #endregion
    }

    public enum ProdutoLoadType
    {
        LoadAll,
        LoadById,
        LoadByNome,
        LoadByFabr

    }
}
