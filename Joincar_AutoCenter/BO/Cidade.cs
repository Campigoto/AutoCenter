using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
   public class Cidade
   {
        #region Fields
        private int    _CID_CODIGO = 0;
        private string _CID_NOME;
        private string _CID_UF;
                                                               
        private SqlCommand cmd;
        private CidadeLoadType _loadType;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Properties
        public int CID_CODIGO
        {                                                                    
            get { return _CID_CODIGO; }                                         
            set { _CID_CODIGO = value; }                                        
        }
        public string CID_NOME
         {                                 
            get { return _CID_NOME; }   
            set { _CID_NOME = value; }
         }
        public string CID_UF
        {
            get { return _CID_UF; }
            set { _CID_UF = value; }
        }                 
        #endregion                                                                                        
                                                                                                   
        #region Constructors
        public Cidade() { }

        public Cidade(int CID_CODIGO)
        {                                                                                      
            this._loadType = CidadeLoadType.LoadById;
            this._CID_CODIGO = CID_CODIGO;                                                   
            this.Load();                                                                       
        }

       public Cidade(int CID_CODIGO, string CID_NOME, string CID_UF)                      
        {
            this._CID_CODIGO = CID_CODIGO;
            this._CID_NOME   = CID_NOME;
            this._CID_UF     = CID_UF;
        }                                                                      
        #endregion

        #region Methods
        public void Delete()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Cidade	WHERE CID_CODIGO = @_CID_CODIGO", this.con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IDCIDADE", SqlDbType.Int);
                cmd.Parameters[0].Value = this._CID_CODIGO;

                this.con.Open();
                cmd.ExecuteNonQuery();
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

        private void Load()
        {
            try
            {
                switch (this._loadType)
                {
                    case CidadeLoadType.LoadById:
                        this.cmd = new SqlCommand("SELECT CID_CODIGO, CID_NOME, CID_UF FROM CIDADE WHERE CID_CODIGO = @CID_CODIGO", this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@CID_CODIGO", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._CID_CODIGO;
                        break;
                    case CidadeLoadType.LoadByCidadeNome:
                        this.cmd = new SqlCommand("SELECT CID_CODIGO, CID_NOME, CID_UF FROM CIDADE WHERE CID_NOME = @CID_NOME", this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@CID_NOME", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._CID_NOME;
                        break;

                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();  
                    this._CID_CODIGO   = dr.GetSqlInt32(0).Value;
                    this._CID_NOME       = dr.GetSqlString(1).Value;
                    this._CID_UF         = dr.GetSqlString(2).Value;
                }                           
                else
                    this._CID_CODIGO = 0;
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

        public void Save()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if (this._CID_CODIGO == 0)
                {


                    sb.Append("INSERT INTO CIDADE (CID_NOME, CID_UF ) ");
                    sb.Append("VALUES ( @CID_NOME, @CID_UF ) ");
                    sb.Append("SET @CID_CODIGO = @@IDENTITY ");
                }
                else
                {
                    sb.Append("UPDATE CIDADE SET  CID_NOME=@CID_NOME, CID_UF=@CID_UF ");
                    sb.Append("WHERE CID_CODIGO = @CID_CODIGO ");
                }                                                                                            
                SqlCommand cmd = new SqlCommand(sb.ToString(), this.con );                                   
                                                                                                          
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@CID_CODIGO", SqlDbType.Int);                                         
                cmd.Parameters[0].Value = this._CID_CODIGO;                                              
                cmd.Parameters[0].Direction = ParameterDirection.InputOutput;

                cmd.Parameters.Add("@CID_NOME", SqlDbType.VarChar);
                cmd.Parameters[1].Value = this._CID_NOME;

                cmd.Parameters.Add("@CID_UF", SqlDbType.VarChar);  
                cmd.Parameters[2].Value =this._CID_UF;  
                                           
                this.con.Open();                                                                                 
                if (cmd.ExecuteNonQuery() > 0)                                                                     
                {                                                                                                  
                    this._CID_CODIGO = int.Parse(cmd.Parameters[0].Value.ToString());                            
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
}
