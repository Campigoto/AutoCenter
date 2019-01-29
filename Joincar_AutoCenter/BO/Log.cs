using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
   public class Log
   {
        #region Fields
        private int    _LOG_CODIGO = 0;
       private int _LOG_USUARIO;
       private DateTime _LOG_DATA;
        private string _LOG_TELA;
        private string _LOG_DESCRICAO;

       StringBuilder sb;                        
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Properties
        public int LOG_CODIGO
        {                                                                    
            get { return _LOG_CODIGO; }                                         
            set { _LOG_CODIGO = value; }                                        
        }
       public int LOG_USUARIO
       {
           get { return _LOG_USUARIO; }
           set { _LOG_USUARIO = value; }
       }
       public DateTime LOG_DATA
       {
           get { return _LOG_DATA; }
           set { _LOG_DATA = value; }
       }
        public string LOG_TELA
         {                                 
            get { return _LOG_TELA; }   
            set { _LOG_TELA = value; }
         }
        public string LOG_DESCRICAO
        {
            get { return _LOG_DESCRICAO; }
            set 
            {
                if (value.Length > 500)
                {
                    _LOG_DESCRICAO = value.Substring(0, 497) + "..."; 
                }
                else
                {
                    _LOG_DESCRICAO = value; 
                }
                
            }
        }                 
        #endregion                                                                                        
                                                                                                   
        #region Constructors
        public Log() { }
        #endregion

        #region Methods
        public void Save()
        {
            try
            {
                sb = new StringBuilder();
                sb.Append("INSERT INTO Log (LOG_USUARIO, LOG_DATA, LOG_TELA, LOG_DESCRICAO) ");
                sb.Append("VALUES ( @LOG_USUARIO, @LOG_DATA, @LOG_TELA, @LOG_DESCRICAO ) ");
                sb.Append("SET @LOG_CODIGO = @@IDENTITY ");
                cmd = new SqlCommand(sb.ToString(), this.con );                                   
                                                                                                          
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@LOG_CODIGO", SqlDbType.Int);
                cmd.Parameters[0].Value = this._LOG_CODIGO;
                cmd.Parameters[0].Direction = ParameterDirection.InputOutput;
                cmd.Parameters.Add("@LOG_USUARIO", SqlDbType.Int);
                cmd.Parameters[1].Value = this._LOG_USUARIO;
                cmd.Parameters.Add("@LOG_DATA", SqlDbType.DateTime);
                cmd.Parameters[2].Value = this._LOG_DATA;
                cmd.Parameters.Add("@LOG_TELA", SqlDbType.VarChar);
                cmd.Parameters[3].Value = this._LOG_TELA;
                cmd.Parameters.Add("@LOG_DESCRICAO", SqlDbType.VarChar);
                cmd.Parameters[4].Value =this._LOG_DESCRICAO;
                                           
                this.con.Open();                                                                                 
                if (cmd.ExecuteNonQuery() > 0)                                                                     
                {                                                                                                  
                    this._LOG_CODIGO = int.Parse(cmd.Parameters[0].Value.ToString());                            
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
