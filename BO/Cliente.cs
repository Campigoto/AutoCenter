using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BO
{
    public class Cliente
    {
        #region Fields
        private int      _CLI_CODIGO;
        private Cidade   _CLI_CIDADE;
        private int      _CLI_INATIVO;
        private int      _CLI_PESSOA;
        private string   _CLI_CEP;
        private string   _CLI_NOME;
        private string   _CLI_FANTASIA;
        private string   _CLI_BAIRRO;
        private string   _CLI_LOGRADOURO;
        private string   _CLI_FONE;
        private string   _CLI_CELULAR;
        private string   _CLI_EMAIL;
        private string   _CLI_CONTATO;
        private string   _CLI_CPF_CNPJ;
        private string   _CLI_INSC_ESTADUAL;
        private string   _CLI_OBS;
        private DateTime _CLI_CADASTRO;

        private StringBuilder _sb;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        private SqlCommand cmd;
        #endregion

        #region Properties
        public int CLI_CODIGO
        {
            get { return _CLI_CODIGO; }
            set { _CLI_CODIGO = value; }                                                                     
        }                                                                                                    

        public Cidade CLI_CIDADE
        {
            get { return _CLI_CIDADE; }
            set { _CLI_CIDADE = value; }
        }
        public int CLI_CIDADE_CID_ID
        {
            get { return _CLI_CIDADE.CID_ID; }
        }

        public string CLI_CIDADE_CID_NOME
        {
            get
            {
                try { return _CLI_CIDADE.CID_NOME; }
                catch { return ""; }
            }
        }   


        public int CLI_INATIVO
        {
            get { return _CLI_INATIVO; }
            set { _CLI_INATIVO = value; }                                              
        }                                                                              
                                                                                       
        public int CLI_PESSOA
        {                                                                              
            get { return _CLI_PESSOA; }                                                
            set { _CLI_PESSOA = value; }                                               
        }                                                                                 
                                                                                         
        public string CLI_CEP
        {                                                                                 
            get { return _CLI_CEP; }                                                      
            set { _CLI_CEP = value; }                                                     
        }                                                                                 
                                                                                       
        public string CLI_NOME
        {                                                                                                 
            get { return _CLI_NOME; }                                                                      
            set { _CLI_NOME = value; }                                                                    
        }                                                                                                
                                                                                                         
        public string CLI_FANTASIA
        {                                                                                                
            get { return _CLI_FANTASIA; }                                                                
            set { _CLI_FANTASIA = value; }                                                               
        }                                                                                                
                                                                                                         
        public string CLI_BAIRRO
        {                                                                                                
            get { return _CLI_BAIRRO; }                                                                  
            set { _CLI_BAIRRO = value; }                                                                 
        }

        public string CLI_LOGRADOURO
        {
            get { return _CLI_LOGRADOURO; }
            set { _CLI_LOGRADOURO = value; }                                                              
        }

        public string CLI_FONE
        {
            get { return _CLI_FONE; }
            set { _CLI_FONE = value; }
        }

        public string CLI_CELULAR
        {
            get { return _CLI_CELULAR; }
            set { _CLI_CELULAR = value; }
        }

        public string CLI_EMAIL
        {
            get { return _CLI_EMAIL; }
            set { _CLI_EMAIL = value; }
        }

        public string CLI_CONTATO
        {
            get { return _CLI_CONTATO; }
            set { _CLI_CONTATO = value; }                                                                                  
        }

        public string CLI_CPF_CNPJ
        {
            get { return _CLI_CPF_CNPJ; }                                                                                     
            set { _CLI_CPF_CNPJ = value; }                                                                         
        }                                                                                                                  
                                                                                                                            
        public string CLI_INSC_ESTADUAL
        {                                                                                                                     
            get { return _CLI_INSC_ESTADUAL; }                                                                                   
            set { _CLI_INSC_ESTADUAL = value; }                                                                                   
        }                                                                                                                    
                                                                                                                             
        public string CLI_OBS
        {                                                                                                                   
            get { return _CLI_OBS; }                                                                                        
            set { _CLI_OBS = value; }                                                                                         
        }

        public DateTime CLI_CADASTRO
        {
            get { return _CLI_CADASTRO; }
            set { _CLI_CADASTRO = value; }                                                                                         
        }                                                                                                                        
        #endregion                                                                                      
                                                                                                             
        #region Constructors
        public Cliente() { }                                                                                 
                                                                                                             
        public Cliente(int CLI_CODIGO)                                                                                  
        {                                                                                                                                
            this._CLI_CODIGO = CLI_CODIGO;
            this.Carregar();

        }
        public Cliente(int CLI_CODIGO, 
                       int CLI_CIDADE, 
                       int CLI_INATIVO,    
                       int CLI_PESSOA,   
                       string CLI_CEP,   
                       string CLI_NOME, 
                       string CLI_FANTASIA,
                       string CLI_BAIRRO,   
                       string CLI_LOGRADOURO,   
                       string CLI_FONE,   
                       string CLI_CELULAR,   
                       string CLI_EMAIL,    
                       string CLI_CONTATO,
                       string CLI_CPF_CNPJ,
                       string CLI_INSC_ESTADUAL,
                       string CLI_OBS,
                       DateTime CLI_CADASTRO )   
        {                    
            this._CLI_CODIGO = CLI_CODIGO;
            this._CLI_CIDADE = new Cidade(CLI_CIDADE);
            this._CLI_INATIVO = CLI_INATIVO;
            this._CLI_PESSOA = CLI_PESSOA;
            this._CLI_CEP = CLI_CEP;
            this._CLI_NOME = CLI_NOME;
            this._CLI_FANTASIA = CLI_FANTASIA;
            this._CLI_BAIRRO = CLI_BAIRRO;
            this._CLI_LOGRADOURO = CLI_LOGRADOURO;
            this._CLI_FONE = CLI_FONE;
            this._CLI_CELULAR = CLI_CELULAR;
            this._CLI_EMAIL = CLI_EMAIL;
            this._CLI_CONTATO = CLI_CONTATO;
            this._CLI_CPF_CNPJ = CLI_CPF_CNPJ;
            this._CLI_INSC_ESTADUAL = CLI_INSC_ESTADUAL;
            this._CLI_OBS = CLI_OBS;
            this._CLI_CADASTRO = CLI_CADASTRO;
        }
                                                                                                                           
        #endregion                                                                                                                       
                                                                                                                                         
        #region Methods
        public void Carregar()
        {
            try
            {
                this._sb = new StringBuilder();
                this._sb.Append("SELECT CLI_CODIGO, CLI_CIDADE,CLI_INATIVO,CLI_PESSOA,CLI_CEP,CLI_NOME,CLI_FANTASIA,CLI_BAIRRO, ");
                this._sb.Append("CLI_LOGRADOURO,CLI_FONE,CLI_CELULAR,CLI_EMAIL,CLI_CONTATO,CLI_CPF_CNPJ,CLI_INSC_ESTADUAL,CLI_OBS,CLI_CADASTRO FROM Cliente ");
                this._sb.Append("WHERE (CLI_CODIGO = @CLI_CODIGO) ");
                this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@CLI_CODIGO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = this._CLI_CODIGO;

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    try { this._CLI_CODIGO = dr.GetSqlInt32(0).Value;} catch { this._CLI_CODIGO = 0;}
                    try { this._CLI_CIDADE = new Cidade(dr.GetSqlInt32(1).Value); } catch {this._CLI_CIDADE = new Cidade(); }
                    try { this._CLI_INATIVO = dr.GetSqlInt32(2).Value;}catch {this._CLI_INATIVO = 0;}
                    try { this._CLI_PESSOA = dr.GetSqlInt32(3).Value;} catch {this._CLI_PESSOA = 0;}
                    try { this._CLI_CEP = dr.GetSqlString(4).Value;} catch { this._CLI_CEP = ""; }
                    try { this._CLI_NOME = dr.GetSqlString(5).Value;} catch { this._CLI_NOME = ""; }
                    try { this._CLI_FANTASIA = dr.GetSqlString(6).Value; } catch {this._CLI_FANTASIA = ""; }
                    try { this._CLI_BAIRRO = dr.GetSqlString(7).Value;} catch {this._CLI_BAIRRO = ""; }
                    try { this._CLI_LOGRADOURO = dr.GetSqlString(8).Value;} catch { this._CLI_LOGRADOURO = ""; }
                    try { this._CLI_FONE = dr.GetSqlString(9).Value; }  catch { this._CLI_FONE = ""; }
                    try { this._CLI_CELULAR = dr.GetSqlString(10).Value; } catch { this._CLI_CELULAR = ""; }
                    try { this._CLI_EMAIL = dr.GetSqlString(11).Value; } catch {this._CLI_EMAIL = ""; }
                    try { this._CLI_CONTATO = dr.GetSqlString(12).Value; } catch { this._CLI_CONTATO = ""; }
                    try { this._CLI_CPF_CNPJ = dr.GetSqlString(13).Value; } catch {this._CLI_CPF_CNPJ = "";}
                    try { this._CLI_INSC_ESTADUAL = dr.GetSqlString(14).Value; } catch {this._CLI_INSC_ESTADUAL = ""; }
                    try { this._CLI_OBS = dr.GetSqlString(15).Value; } catch { this._CLI_OBS = ""; }
                    try { this._CLI_CADASTRO = dr.GetSqlDateTime(16).Value;  } catch {  this._CLI_CADASTRO = DateTime.Now;  }
                }
                else
                {
                    this._CLI_CODIGO = 0;
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

        public void Salvar()
        {
            try
            {
                this._sb = new StringBuilder();
                if (this.CLI_CODIGO == 0)
                {
                    this._sb.Append("INSERT INTO CLIENTE ( CLI_CIDADE,CLI_INATIVO,CLI_PESSOA,CLI_CEP,CLI_NOME,CLI_FANTASIA,CLI_BAIRRO  ");
                    this._sb.Append(",CLI_LOGRADOURO,CLI_FONE,CLI_CELULAR,CLI_EMAIL,CLI_CONTATO,CLI_CPF_CNPJ,CLI_INSC_ESTADUAL,CLI_OBS,CLI_CADASTRO ) ");
                    this._sb.Append("VALUES ( @CLI_CIDADE,@CLI_INATIVO,@CLI_PESSOA,@CLI_CEP,@CLI_NOME,@CLI_FANTASIA,@CLI_BAIRRO ");
                    this._sb.Append(",@CLI_LOGRADOURO,@CLI_FONE,@CLI_CELULAR,@CLI_EMAIL,@CLI_CONTATO,@CLI_CPF_CNPJ,@CLI_INSC_ESTADUAL,@CLI_OBS,@CLI_CADASTRO ) ");
                    this._sb.Append("SET @CLI_CODIGO = @@IDENTITY ");
                }
                else
                {
                    this._sb.Append("UPDATE CLIENTE SET  ");
                    this._sb.Append("CLI_CIDADE=@CLI_CIDADE,CLI_INATIVO=@CLI_INATIVO,CLI_PESSOA=@CLI_PESSOA,CLI_CEP=@CLI_CEP,CLI_NOME=@CLI_NOME,CLI_FANTASIA=@CLI_FANTASIA,CLI_BAIRRO=@CLI_BAIRRO ");
                    this._sb.Append(",CLI_LOGRADOURO=@CLI_LOGRADOURO,CLI_FONE=@CLI_FONE,CLI_CELULAR=@CLI_CELULAR,CLI_EMAIL=@CLI_EMAIL,CLI_CONTATO=@CLI_CONTATO,CLI_CPF_CNPJ=@CLI_CPF_CNPJ,CLI_INSC_ESTADUAL=@CLI_INSC_ESTADUAL,CLI_OBS=@CLI_OBS,CLI_CADASTRO=@CLI_CADASTRO ");
                    this._sb.Append("WHERE CLI_CODIGO=@CLI_CODIGO");
                }

                this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;                                       
                this.cmd.Parameters.Add("@CLI_CODIGO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = CLI_CODIGO;
                this.cmd.Parameters[0].Direction = ParameterDirection.InputOutput;                                   //0_CLI_CODIGO;   
                this.cmd.Parameters.Add("@CLI_CIDADE", SqlDbType.Int);                                               //1_CLI_CIDADE;
                this.cmd.Parameters[1].Value = CLI_CIDADE.CID_ID;                                                //2_CLI_INATIVO;
                this.cmd.Parameters.Add("@CLI_INATIVO", SqlDbType.Int);                                              //3_CLI_PESSOA;
                this.cmd.Parameters[2].Value = CLI_INATIVO;                                                          //4_CLI_CEP;
                this.cmd.Parameters.Add("@CLI_PESSOA", SqlDbType.Int);                                               //5_CLI_NOME;
                this.cmd.Parameters[3].Value = CLI_PESSOA;                                                           //6_CLI_FANTASIA;
                this.cmd.Parameters.Add("@CLI_CEP", SqlDbType.VarChar);                                              //7_CLI_BAIRRO;
                this.cmd.Parameters[4].Value = CLI_CEP;                                                              //8_CLI_LOGRADOURO;
                this.cmd.Parameters.Add("@CLI_NOME", SqlDbType.VarChar);                                             //9_CLI_FONE;
                this.cmd.Parameters[5].Value = CLI_NOME;                                                             //10_CLI_celular  
                this.cmd.Parameters.Add("@CLI_FANTASIA", SqlDbType.VarChar);                                         //11 _CLI_email
                this.cmd.Parameters[6].Value = CLI_FANTASIA;                                                         //12_CLI_CONTATO;
                this.cmd.Parameters.Add("@CLI_BAIRRO", SqlDbType.VarChar);                                           //13_CLI_CPF_CNPJ;
                this.cmd.Parameters[7].Value = CLI_BAIRRO;                                                           //14_CLI_INSC_ESTADUAL
                this.cmd.Parameters.Add("@CLI_LOGRADOURO", SqlDbType.VarChar);                                       //15_CLI_OBS;    
                this.cmd.Parameters[8].Value = CLI_LOGRADOURO;                                                       //16_CLI_CADASTRO;    
                this.cmd.Parameters.Add("@CLI_FONE", SqlDbType.VarChar);                                          
                this.cmd.Parameters[9].Value = CLI_FONE;
                this.cmd.Parameters.Add("@CLI_CELULAR",SqlDbType.VarChar);
                this.cmd.Parameters[10].Value = CLI_CELULAR;
                this.cmd.Parameters.Add("@CLI_EMAIL", SqlDbType.VarChar);
                this.cmd.Parameters[11].Value = CLI_EMAIL;                                          
                this.cmd.Parameters.Add("@CLI_CONTATO", SqlDbType.VarChar);                                       
                this.cmd.Parameters[12].Value = CLI_CONTATO;                                                      
                this.cmd.Parameters.Add("@CLI_CPF_CNPJ", SqlDbType.VarChar);                                      
                this.cmd.Parameters[13].Value = CLI_CPF_CNPJ;
                this.cmd.Parameters.Add("@CLI_INSC_ESTADUAL", SqlDbType.VarChar);                                      
                this.cmd.Parameters[14].Value = CLI_INSC_ESTADUAL;                                                
                this.cmd.Parameters.Add("@CLI_OBS", SqlDbType.Text);                                              
                this.cmd.Parameters[15].Value = CLI_OBS;                                                          
                this.cmd.Parameters.Add("@CLI_CADASTRO", SqlDbType.DateTime);                                     
                this.cmd.Parameters[16].Value = CLI_CADASTRO;                                                     
                                                                                                                  
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

        public void Deletar(int CLI_CODIGO)
        {
            try
            {
                this.cmd = new SqlCommand("DELETE FROM CLIENTE WHERE CLI_CODIGO = @CLI_CODIGO", this.con);
                this.cmd.CommandType = CommandType.Text;

                this.cmd.Parameters.Add("@CLI_CODIGO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = CLI_CODIGO;

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
