using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BO
{
    public class SubGrupo_Produtos 
    {
        #region Fields
        private int        _SGP_ID = 0;
        private int        _SGP_CODIGO; 
        private int        _SGP_GRUPO;                                                   
        private string     _SGP_NOME;   
        private string     _SGP_OBS;                                                     
                                                                                                                           
        private StringBuilder _sb;                                                                                         
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        private SqlCommand cmd;
        private SubGrupo_ProdutoLoadType _typeLoad;                                                                                          
        #endregion                                                                                                         
                                                                                                                           
        #region Properties
                                                                                                        
        public int SGP_ID                                                      
        {
            get { return _SGP_ID; }
            set { _SGP_ID = value; }                                                                     
        }

        public int SGP_CODIGO
        {
            get { return _SGP_CODIGO; }
            set { _SGP_CODIGO = value; }
        }                                                                          
        
        public int SGP_GRUPO                                                      
        {                                                                          
            get { return _SGP_GRUPO; }                                            
            set { _SGP_GRUPO = value; }                                                                     
        }

        public string SGP_NOME                                                                            
        {                                                                                          
            get { return _SGP_NOME; }                                                                
            set { _SGP_NOME = value; }                                                                    
        }

        public string SGP_OBS                                                                      
        {                                                                                                
            get { return _SGP_OBS; }                                                                
            set { _SGP_OBS = value; }                                                               
        }                                                                                                
                                                                                                         
                                                                                                                 
        #endregion                                                                                      
                                                                                                             
        #region Constructors
        public SubGrupo_Produtos() { }

        public SubGrupo_Produtos(int SGP_ID)                                                                                  
        {
            this._SGP_ID = SGP_ID;
            this._typeLoad = SubGrupo_ProdutoLoadType.LoadById;
            this.Load();
        }

        public SubGrupo_Produtos(int SGP_CODIGO, int SGP_GRUPO)
        {
            this._SGP_CODIGO = SGP_CODIGO;
            this._SGP_GRUPO = SGP_GRUPO;
            this._typeLoad = SubGrupo_ProdutoLoadType.LoadByGrupo_SubGrupo;
            this.Load();

        }  
        
        public SubGrupo_Produtos( int SGP_ID,
                             int SGP_CODIGO,
                             int    SGP_GRUPO,
                             string SGP_NOME,
                             string SGP_OBS)
        {
            this._SGP_ID = SGP_ID;
            this._SGP_NOME = SGP_NOME;
            this._SGP_CODIGO = SGP_CODIGO;
            this._SGP_GRUPO = SGP_GRUPO;
            this._SGP_OBS = SGP_OBS;
        }  
        
        #endregion                                                                                                                       
                                                                                                                                         
        #region Methods
        private void Load()
        {
            try
            {
                switch (this._typeLoad)
                {
                   
                    case SubGrupo_ProdutoLoadType.LoadByGrupo_SubGrupo:
                        this.cmd = new SqlCommand("SELECT SGP_ID,SGP_CODIGO,SGP_GRUPO, SGP_NOME, SGP_OBS FROM SubGrupo_Produto WHERE SGP_CODIGO=@SGP_CODIGO AND SGP_GRUPO=@SGP_GRUPO ", this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@SGP_CODIGO", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._SGP_CODIGO;
                        this.cmd.Parameters.Add("@SGP_GRUPO", SqlDbType.Int);
                        this.cmd.Parameters[1].Value = this._SGP_GRUPO;
                        break;
                    case SubGrupo_ProdutoLoadType.LoadById:
                        this.cmd = new SqlCommand("SELECT SGP_ID,SGP_CODIGO,SGP_GRUPO, SGP_NOME, SGP_OBS FROM SubGrupo_Produto WHERE SGP_ID=@SGP_ID ", this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@SGP_ID", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._SGP_ID;
                        break;
                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    try { this.SGP_ID     = dr.GetSqlInt32(0).Value;} catch   {this.SGP_ID     = 0;}
                    try { this.SGP_CODIGO = dr.GetSqlInt32(1).Value;} catch   {this.SGP_CODIGO = 0;}
                    try { this.SGP_GRUPO  = dr.GetSqlInt32(2).Value;} catch   {this.SGP_GRUPO  = 0;}
                    try { this.SGP_NOME   = dr.GetSqlString(3).Value;} catch  {this.SGP_NOME   = "";}
                    try { this.SGP_OBS    = dr.GetSqlString(4).Value;} catch  {this.SGP_OBS    = "";}
                }
                else
                {
                    SGP_CODIGO = 0;
                    SGP_GRUPO = 0;
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

        public static bool Verificar_SubGrupo_Produto(int SGP_CODIGO, int SGP_GRUPO)                                                                             
        {                                                                                                                                
            SqlConnection static_conn = new SqlConnection(Connection.ConnectionString);                                                  
            SqlCommand static_cmd;                                                                                                       
            StringBuilder sb = new StringBuilder();                                                                                      
                                                                                                                                         
         try                                                                                                                             
            {
                sb.Append("SELECT SGP_ID,SGP_CODIGO,SGP_GRUPO,SGP_NOME,SGP_OBS FROM SubGrupo_Produto WHERE (SGP_CODIGO = @SGP_CODIGO AND SGP_GRUPO = @SGP_GRUPO) ");                                                                    
                static_cmd = new SqlCommand(sb.ToString(), static_conn);                                                                                         
                static_cmd.CommandType = CommandType.Text;
                static_cmd.Parameters.Add("@SGP_CODIGO", SqlDbType.Int);
                static_cmd.Parameters[0].Value = SGP_CODIGO;
                static_cmd.Parameters.Add("@SGP_GRUPO", SqlDbType.Int);
                static_cmd.Parameters[1].Value = SGP_GRUPO;                                                                                                   
                                                                                                                                                                 
                static_conn.Open();                                                                                                                              
                SqlDataReader dr = static_cmd.ExecuteReader();                                                                                                   
                if (dr.HasRows)                                                                                                                                  
                {                                                                                                                                                
                    dr.Read();                                                                                                                                   
                    if (dr.GetSqlInt32(0) > 0)                                                                                                                      
                    {                                                                                                                                            
                        return true;                                                                                                                             
                    }                                                                                                                                            
                    else                                                                                                                                         
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (static_conn.State == ConnectionState.Open) static_conn.Close();
            }
        }

        public void Salvar()
        {
            try
            {
                this._sb = new StringBuilder();
                if (this._SGP_ID == 0)
                {
                    this._sb.Append("INSERT INTO SubGrupo_Produto (SGP_CODIGO,SGP_GRUPO,SGP_NOME,SGP_OBS) ");
                    this._sb.Append("VALUES ( @SGP_CODIGO,@SGP_GRUPO,@SGP_NOME,@SGP_OBS) ");
                    this._sb.Append("SET @SGP_ID = @@IDENTITY ");


                }
                else
                {
                    this._sb.Append("UPDATE SubGrupo_Produto  SET SGP_NOME = @SGP_NOME, SGP_OBS = @SGP_OBS ");
                    this._sb.Append("WHERE SGP_ID=@SGP_ID ");
                }

                this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@SGP_ID", SqlDbType.Int);
                this.cmd.Parameters[0].Value = SGP_ID;
                this.cmd.Parameters[0].Direction = ParameterDirection.InputOutput;
                this.cmd.Parameters.Add("@SGP_CODIGO", SqlDbType.Int);
                this.cmd.Parameters[1].Value = SGP_CODIGO;
                this.cmd.Parameters.Add("@SGP_GRUPO", SqlDbType.Int);
                this.cmd.Parameters[2].Value = SGP_GRUPO;
                this.cmd.Parameters.Add("@SGP_NOME", SqlDbType.VarChar);
                this.cmd.Parameters[3].Value = SGP_NOME;
                this.cmd.Parameters.Add("@SGP_OBS", SqlDbType.VarChar);
                this.cmd.Parameters[4].Value = SGP_OBS;                                

                this.con.Open();                                                                                    
                this.cmd.ExecuteNonQuery();                                                                         
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

        public void Deletar(int GRP_CODIGO)
        {
            try
            {
                this.cmd = new SqlCommand("DELETE FROM SubGrupo_Produto WHERE SGP_ID = @SGP_ID", this.con);
                this.cmd.CommandType = CommandType.Text;

                this.cmd.Parameters.Add("@SGP_ID", SqlDbType.Int);
                this.cmd.Parameters[0].Value = SGP_ID;

                this.con.Open();
                this.cmd.ExecuteNonQuery();
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
}
