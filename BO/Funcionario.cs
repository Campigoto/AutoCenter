using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BO
{
    public class Funcionario
    {
        #region Fields
        private int _FUN_CODIGO = 0;
        private int _FUN_USUARIO;
        private int _FUN_INATIVO;
        private int _FUN_CIDADE;                                                                      
        private string _FUN_NOME;                                                                      
        private string _FUN_LOGIN;                                                                  
        private string _FUN_SENHA;
        private string _FUN_OBS;
        private DateTime _FUN_CADASTRO;
        private float _FUN_DESPESAS;

        private StringBuilder _CONSULTA;                                                                                             
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);                                            
        private SqlCommand cmd;                                                                                                
        #endregion                                                                                                             
                                                                                                                               
        #region Properties
        public int FUN_CODIGO
        {
            get { return _FUN_CODIGO; }
            set { _FUN_CODIGO = value; }
        }

        public int FUN_USUARIO
        {
            get { return _FUN_USUARIO; }
            set { _FUN_USUARIO = value; }
        }

        public string FUN_USUARIO_NOME
        {
            get 
            {
                if (_FUN_USUARIO == 1)
                {
                    return "Sim";
                }
                else
                {
                    return "Não";
                }
            }
        }

        public int FUN_CIDADE
        {
            get { return _FUN_CIDADE; }
            set { _FUN_CIDADE = value; }                                                                     
        }

        public int FUN_INATIVO
        {                                                                                                 
            get { return _FUN_INATIVO; }                                                                  
            set { _FUN_INATIVO = value; }                                                                 
        }                                                                                                 

        public string FUN_LOGIN
        {                                                                                                 
            get { return _FUN_LOGIN; }                                                                    
            set { _FUN_LOGIN = value; }                                               
        }                                                                                 
                                                                       
        public string FUN_SENHA
        {
            get { return _FUN_SENHA; }
            set { _FUN_SENHA = value; }                                                     
        }                                                                                 

        public string FUN_NOME
        {                                                                                                 
            get { return _FUN_NOME; }                                                                      
            set { _FUN_NOME = value; }                                                                    
        }

        public float FUN_DESPESAS
        {
            get { return _FUN_DESPESAS; }
            set { _FUN_DESPESAS = value; }
        }

        public string FUN_DESPESAS_FORMATADO
        {
            get 
            { 
                return _FUN_DESPESAS.ToString("0.00"); 
            }
        }                                                                                                                  
                                                                                                         
        public string FUN_OBS
        {                                                                                                                      
            get { return _FUN_OBS; }                                                                                           
            set { _FUN_OBS = value; }                                                                                          
        }                                                                                                                                   
                                                                                                                      
        public DateTime FUN_CADASTRO
        {                                                                                                                                   
            get { return _FUN_CADASTRO; }                                                                                                   
            set { _FUN_CADASTRO = value; }                                                                                                  
        }                                                                                                                                   
        #endregion                                                                                                                          
                                                                                                                                            
        #region Constructors
        public Funcionario() { }                                                                                                            
                                                                                                                                            
        public Funcionario(int FUN_CODIGO)
        {                                                                                                                                
            this._FUN_CODIGO = FUN_CODIGO;
            this.Carregar();                                                                                
        }

        public Funcionario(string FUN_LOGIN, string FUN_SENHA)
        {
            this._FUN_LOGIN = FUN_LOGIN;
            this._FUN_SENHA = FUN_SENHA;
            this.Carregar();
        }

        public Funcionario(int FUN_CODIGO, int FUN_USUARIO, int FUN_INATIVO, int FUN_CIDADE, string FUN_NOME, 
            string FUN_LOGIN, string FUN_SENHA, string FUN_OBS, DateTime FUN_CADASTRO, float FUN_DESPESAS)
        {
            this._FUN_CODIGO = FUN_CODIGO;
            this._FUN_USUARIO = FUN_USUARIO;
            this._FUN_INATIVO = FUN_INATIVO;
            this._FUN_CIDADE = FUN_CIDADE;
            this._FUN_NOME = FUN_NOME;
            this._FUN_LOGIN = FUN_LOGIN;
            this._FUN_SENHA = FUN_SENHA;
            this._FUN_OBS = FUN_OBS;
            this._FUN_CADASTRO = FUN_CADASTRO;
            this._FUN_DESPESAS = FUN_DESPESAS;
        }
        #endregion                                                                                                                       
                                                                                                                                         
        #region Methods
        public static bool Verificar_Funcionario(int FUN_CODIGO)
        {                                                                                                                                
            SqlConnection static_conn = new SqlConnection(Connection.ConnectionString);                                                  
            SqlCommand static_cmd;                                                                                                       
            StringBuilder sb = new StringBuilder();                                                                                      
                                                                                                                                         
         try                                                                                                                             
            {
                sb.Append("SELECT FUN_CODIGO,FUN_USUARIO,FUN_INATIVO, FUN_CIDADE,FUN_NOME,FUN_LOGIN,FUN_SENHA,FUN_OBS,FUN_CADASTRO,FUN_DESPESAS FROM Funcionario ");
                sb.Append("WHERE (FUN_CODIGO = @FUN_CODIGO) ");                                                                    
                static_cmd = new SqlCommand(sb.ToString(), static_conn);                                                                                         
                static_cmd.CommandType = CommandType.Text;                                                                                                       
                static_cmd.Parameters.Add("@FUN_CODIGO", SqlDbType.Int);                                                                                         
                static_cmd.Parameters[0].Value = FUN_CODIGO;                                                                                                     
                                                                                                                                                                 
                static_conn.Open();                                                                                                                              
                SqlDataReader dr = static_cmd.ExecuteReader();                                                                                                   
                if (dr.HasRows)                                                                                                                                  
                {                                                                                                                                              
                    dr.Read();                                                                                                                                  
                    if (dr.GetInt32(0) > 0)                                                                                                                      
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

        private void Carregar()
        {
            try
            {
                this._CONSULTA = new StringBuilder();
                this._CONSULTA.Append("SELECT FUN_CODIGO,FUN_USUARIO,FUN_INATIVO, FUN_CIDADE,FUN_NOME,FUN_LOGIN,FUN_SENHA,FUN_OBS,FUN_CADASTRO,FUN_DESPESAS FROM Funcionario ");
                if (this._FUN_CODIGO > 0)
                {
                    this._CONSULTA.Append("WHERE (FUN_CODIGO = @FUN_CODIGO) ");
                    this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                    this.cmd.CommandType = CommandType.Text;
                    this.cmd.Parameters.Add("@FUN_CODIGO", SqlDbType.Int);
                    this.cmd.Parameters[0].Value = this._FUN_CODIGO;
                }
                else
                {
                    this._CONSULTA.Append("WHERE (FUN_LOGIN = @FUN_LOGIN AND FUN_SENHA = @FUN_SENHA) ");
                    this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                    this.cmd.CommandType = CommandType.Text;
                    this.cmd.Parameters.Add("@FUN_LOGIN", SqlDbType.VarChar);
                    this.cmd.Parameters[0].Value = this._FUN_LOGIN;
                    this.cmd.Parameters.Add("@FUN_SENHA", SqlDbType.VarChar);
                    this.cmd.Parameters[1].Value = this._FUN_SENHA;
                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    this._FUN_CODIGO = dr.GetSqlInt32(0).Value;
                    this._FUN_USUARIO = dr.GetSqlInt32(1).Value;
                    this._FUN_INATIVO = dr.GetSqlInt32(2).Value;
                    this._FUN_CIDADE = dr.GetSqlInt32(3).Value;
                    this._FUN_NOME = dr.GetSqlString(4).Value;
                    this._FUN_LOGIN = dr.GetSqlString(5).Value;
                    this._FUN_SENHA = dr.GetSqlString(6).Value;
                    this._FUN_OBS = dr.GetSqlString(7).Value;
                    this._FUN_CADASTRO = dr.GetSqlDateTime(8).Value;
                    this._FUN_DESPESAS = float.Parse(dr.GetSqlDouble(9).Value.ToString());
                }
                else
                    this._FUN_CODIGO = 0;
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

        public void Salvar()
        {
            try
            {
                this._CONSULTA = new StringBuilder();
                if (this._FUN_CODIGO == 0)
                {
                    this._CONSULTA.Append("INSERT INTO Funcionario ( FUN_USUARIO,FUN_INATIVO, FUN_CIDADE,FUN_NOME,FUN_LOGIN,FUN_SENHA,FUN_OBS,FUN_CADASTRO,FUN_DESPESAS ) ");
                    this._CONSULTA.Append("VALUES ( @FUN_USUARIO,@FUN_INATIVO, @FUN_CIDADE,@FUN_NOME,@FUN_LOGIN,@FUN_SENHA,@FUN_OBS,@FUN_CADASTRO,@FUN_DESPESAS  ) ");
                    this._CONSULTA.Append("SET @FUN_CODIGO = @@IDENTITY ");
                }
                else
                {
                    this._CONSULTA.Append("UPDATE Funcionario SET FUN_USUARIO=@FUN_USUARIO,FUN_INATIVO=@FUN_INATIVO, FUN_CIDADE=@FUN_CIDADE,FUN_NOME=@FUN_NOME, ");
                    this._CONSULTA.Append("FUN_LOGIN = @FUN_LOGIN,FUN_SENHA = @FUN_SENHA,FUN_OBS = @FUN_OBS,FUN_CADASTRO = @FUN_CADASTRO,FUN_DESPESAS = @FUN_DESPESAS ");
                    this._CONSULTA.Append("WHERE FUN_CODIGO=@FUN_CODIGO ");
                }

                this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;                                        
                this.cmd.Parameters.Add("@FUN_CODIGO", SqlDbType.Int);                          
                this.cmd.Parameters[0].Value = FUN_CODIGO;
                this.cmd.Parameters[0].Direction = ParameterDirection.InputOutput;
                this.cmd.Parameters.Add("@FUN_USUARIO", SqlDbType.Int);
                this.cmd.Parameters[1].Value = FUN_USUARIO;                                                 
                this.cmd.Parameters.Add("@FUN_INATIVO", SqlDbType.Int);
                this.cmd.Parameters[2].Value = FUN_INATIVO;
                this.cmd.Parameters.Add("@FUN_CIDADE", SqlDbType.Int);
                this.cmd.Parameters[3].Value = FUN_CIDADE;
                this.cmd.Parameters.Add("@FUN_NOME", SqlDbType.VarChar);
                this.cmd.Parameters[4].Value = FUN_NOME;
                this.cmd.Parameters.Add("@FUN_LOGIN", SqlDbType.VarChar);                                        
                this.cmd.Parameters[5].Value = FUN_LOGIN;                                                     
                this.cmd.Parameters.Add("@FUN_SENHA", SqlDbType.VarChar);
                this.cmd.Parameters[6].Value = FUN_SENHA;
                this.cmd.Parameters.Add("@FUN_OBS", SqlDbType.VarChar);
                this.cmd.Parameters[7].Value = FUN_OBS;
                this.cmd.Parameters.Add("@FUN_CADASTRO", SqlDbType.DateTime);
                this.cmd.Parameters[8].Value = FUN_CADASTRO;   
                this.cmd.Parameters.Add("@FUN_DESPESAS", SqlDbType.Float);
                this.cmd.Parameters[9].Value = FUN_DESPESAS;
                                           
                this.con.Open();
                if (this.cmd.ExecuteNonQuery() > 0)
                {
                    this._FUN_CODIGO = int.Parse(cmd.Parameters[0].Value.ToString());
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

        public void Deletar(int FUN_CODIGO)
        {
            try
            {
                this.cmd = new SqlCommand("DELETE FROM Funcionario WHERE FUN_CODIGO = @FUN_CODIGO", this.con);
                this.cmd.CommandType = CommandType.Text;

                this.cmd.Parameters.Add("@FUN_CODIGO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = FUN_CODIGO;

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
