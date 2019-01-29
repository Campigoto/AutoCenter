using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BO
{
    public class ClienteCollection : List<Cliente>
    {
        #region Fields
        private int _CLI_CODIGO;
        private int _ORDER;
        private string _CLI_NOME;
        private StringBuilder _sb;
        private ClienteLoadType _typeLoad;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public ClienteCollection() { }

        public ClienteCollection(bool isLoad, int ORDER)
        {
            this._typeLoad = ClienteLoadType.LoadAll;
            this._ORDER = ORDER;
            if (isLoad) this.Load();
        }

        public ClienteCollection(int CLI_CODIGO, int ORDER)
        {
            this._typeLoad = ClienteLoadType.LoadById;
            this._CLI_CODIGO = CLI_CODIGO;
            this._ORDER = ORDER;                            
            this.Load();                                                                       
        }

        public ClienteCollection(string CLI_NOME, int ORDER)
        {
            this._CLI_NOME = CLI_NOME;
            this._typeLoad = ClienteLoadType.LoadByNome;
            this._ORDER = ORDER;
            this.Load();
        }

        public ClienteCollection(ClienteLoadType TIPO, string CLI_NOME, int ORDER)
        {
            this._CLI_NOME = CLI_NOME;
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
                this._sb = new StringBuilder();
                this._sb.Append("SELECT CLI_CODIGO, CLI_CIDADE,CLI_INATIVO,CLI_PESSOA,CLI_CEP,CLI_NOME,CLI_FANTASIA,CLI_BAIRRO,CLI_LOGRADOURO,");
                this._sb.Append("CLI_FONE,CLI_CELULAR,CLI_EMAIL,CLI_CONTATO,CLI_CPF_CNPJ,CLI_INSC_ESTADUAL,CLI_OBS,CLI_CADASTRO FROM CLIENTE ");
                this._sb.Append("LEFT JOIN Cidade ON CLI_CIDADE = CID_CODIGO ");
                switch (this._typeLoad)
                {
                    case ClienteLoadType.LoadAll:
                        this._sb.Append(Order());
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;
                        break;
                    case ClienteLoadType.LoadByNome:
                        this._sb.Append("WHERE CLI_NOME COLLATE Latin1_General_CI_AI LIKE '%' + @CLI_NOME + '%' ");
                        this._sb.Append(Order());
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@CLI_NOME", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._CLI_NOME;
                        break;
                    case ClienteLoadType.LoadById:
                        this._sb.Append("WHERE CLI_CODIGO = @CLI_CODIGO ");
                        this._sb.Append(Order());
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@CLI_CODIGO", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._CLI_CODIGO;
                        break;
                }

                this.con.Open();                                                                                      //CLI_CODIGO                     int CLI_CODIGO,   
                SqlDataReader dr = cmd.ExecuteReader();                                                                //CLI_CIDADE                     int CLI_CIDADE,   
                while (dr.Read())                                                                                      // CLI_INATIVO                   int CLI_INATIVO,      
                {                                                                                                      //CLI_PESSOA                     int CLI_PESSOA,     
                                                                                                                        //CLI_CEP                        string CLI_CEP,     
                    this.Add(new Cliente(dr.IsDBNull(0) ? 0 : dr.GetSqlInt32(0).Value,                                 //CLI_NOME                       string CLI_NOME,   
                                          dr.IsDBNull(1) ? 0 : dr.GetSqlInt32(1).Value,                                //CLI_FANTASIA                   string CLI_FANTASIA,  
                                          dr.IsDBNull(2) ? 0 : dr.GetSqlInt32(2).Value,                                //CLI_BAIRRO                     string CLI_BAIRRO,     
                                          dr.IsDBNull(3) ? 0 : dr.GetSqlInt32(3).Value,                                //CLI_LOGRADOU RO                string CLI_LOGRADOURO,   
                                          dr.IsDBNull(4) ? "" : dr.GetSqlString(4).Value,                              //CLI_FONE                       string CLI_FONE,     
                                          dr.IsDBNull(5) ? "" : dr.GetSqlString(5).Value,                              //CLI_CELULAR                    string CLI_CELULAR,     
                                          dr.IsDBNull(6) ? "" : dr.GetSqlString(6).Value,                              //CLI_EMAIL                      string CLI_EMAIL,      
                                          dr.IsDBNull(7) ? "" : dr.GetSqlString(7).Value,                              //CLI_CONTATO                    string CLI_CONTATO,  
                                          dr.IsDBNull(8) ? "" : dr.GetSqlString(8).Value,                              //CLI_CPF_CNPJ                   string CLI_CPF_CNPJ,  
                                          dr.IsDBNull(9) ? "" : dr.GetSqlString(9).Value,                             //CLI_INSC_ESTADUAL               string CLI_INSC_ESTADUAL,
                                          dr.IsDBNull(10) ? "" : dr.GetSqlString(10).Value,                            //CLI_OBS                         string CLI_OBS,
                                          dr.IsDBNull(11) ? "" : dr.GetSqlString(11).Value,                            //CLI_CADASTRO                    DateTime CLI_CADASTRO ) 
                                          dr.IsDBNull(12) ? "" : dr.GetSqlString(12).Value,
                                          dr.IsDBNull(13) ? "" : dr.GetSqlString(13).Value,
                                          dr.IsDBNull(14) ? "" : dr.GetSqlString(14).Value,
                                          dr.IsDBNull(15) ? "" : dr.GetSqlString(15).Value,              
                                          dr.IsDBNull(16) ? DateTime.Now : dr.GetSqlDateTime(16).Value)); 
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
                    ordenado += "CLI_CODIGO ";
                    break;
                case 1:
                    ordenado += "CLI_NOME ";
                    break;
                case 2:
                    ordenado += "CID_NOME ";
                    break;
                case 3:
                    ordenado += "CLI_FONE ";
                    break;
                case 4:
                    ordenado += "CLI_CONTATO ";
                    break;
                default:
                    ordenado += "CLI_NOME ";
                    break;
            }
            return ordenado;
        }
        #endregion
    }

    public enum ClienteLoadType
    {
        LoadAll,
        LoadById,
        LoadByNome
    }
}
