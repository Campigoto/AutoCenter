using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BO
{
    public class Fornecedor
    {
        #region Fields
        private int      _FOR_CODIGO ;
        private Cidade   _FOR_CIDADE;
        private int      _FOR_INATIVO;
        private int      _FOR_ULT_COMPRA;
        private int      _FOR_PESSOA;
        private string   _FOR_CEP;
        private string   _FOR_NOME = "";
        private string   _FOR_BAIRRO;
        private string   _FOR_LOGRADOURO;
        private string   _FOR_FONE;
        private string   _FOR_CELULAR;
        private string   _FOR_EMAIL;
        private string   _FOR_OBS;
        private DateTime _FOR_CADASTRO;
        private string   _FOR_CONTATO;
        private string   _FOR_CPF_CNPJ;
        private string   _FOR_INSC_ESTADUAL;

        private StringBuilder _sb;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        private SqlCommand cmd;
        private FornecedorLoadType _typeLoad;
        #endregion

        #region Properties
        public int FOR_CODIGO
        {
            get { return _FOR_CODIGO; }
            set { _FOR_CODIGO = value; }                                                                     
        }                                                                                                    

       

        public int FOR_INATIVO
        {
            get { return _FOR_INATIVO; }
            set { _FOR_INATIVO = value; }                                              
        }                                                                              
                                                                          
        public int FOR_PESSOA
        {                                                                              
            get { return _FOR_PESSOA; }                                                
            set { _FOR_PESSOA = value; }                                               
        }                                                                                 
                                                                            
        public string FOR_CEP
        {                                                                                 
            get { return _FOR_CEP; }                                                      
            set { _FOR_CEP = value; }                                                     
        }                                                                                 

        public string FOR_NOME
        {                                                                                                 
            get { return _FOR_NOME; }                                                                      
            set { _FOR_NOME = value; }                                                                    
        }                                                                                                
                                                                                             
        public string FOR_BAIRRO
        {                                                                                                
            get { return _FOR_BAIRRO; }                                                                  
            set { _FOR_BAIRRO = value; }                                                                 
        }

        public string FOR_LOGRADOURO
        {
            get { return _FOR_LOGRADOURO; }
            set { _FOR_LOGRADOURO = value; }                                                              
        }

        public string FOR_FONE
        {
            get { return _FOR_FONE; }
            set { _FOR_FONE = value; }                                                                                  
        }

        public string FOR_CONTATO
        {
            get { return _FOR_CONTATO; }
            set { _FOR_CONTATO = value; }                                                                                  
        }

        public string FOR_CELULAR
        {
            get { return _FOR_CELULAR; }
            set { _FOR_CELULAR = value; }
        }

        public string FOR_EMAIL
        {
            get { return _FOR_EMAIL; }
            set { _FOR_EMAIL = value; }
        }
                                                                                                   
        public string FOR_OBS
        {                                                                                                      
            get { return _FOR_OBS; }                                                                           
            set { _FOR_OBS = value; }                                                                          
        }

        public DateTime FOR_CADASTRO
        {
            get { return _FOR_CADASTRO; }
            set { _FOR_CADASTRO = value; }                                                                                         
        }

        public int FOR_ULT_COMPRA
        {
            get { return _FOR_ULT_COMPRA; }
            set { _FOR_ULT_COMPRA = value; }
        }

        //public int FOR_CIDADE
        //{
        //    get { return _FOR_CIDADE; }
        //    set { _FOR_CIDADE = value; }
        //}

        public Cidade FOR_CIDADE
        {
            get { return _FOR_CIDADE; }
            set { _FOR_CIDADE = value; }
        }
        public int FOR_CIDADE_CID_CODIGO
        {
            get { return _FOR_CIDADE.CID_ID; }
        }

        public string FOR_CIDADE_CID_NOME
        {
            get
            {
                try { return _FOR_CIDADE.CID_NOME; }
                catch { return ""; }
            }
        }

        public string FOR_CPF_CNPJ
        {
            get { return _FOR_CPF_CNPJ; }
            set { _FOR_CPF_CNPJ = value; }
        }

        public string FOR_INSC_ESTADUAL
        {
            get { return _FOR_INSC_ESTADUAL; }
            set { _FOR_INSC_ESTADUAL = value; }
        }                                              
        #endregion                                                                                      
                                                                                                             
        #region Constructors
        public Fornecedor() { }                                                                                 
                                                                                                             
        public Fornecedor(int FOR_CODIGO)
        {
            this._FOR_CODIGO = FOR_CODIGO; 
            this.Carregar();
        }

        public Fornecedor(int FOR_CODIGO, 
                          int FOR_CIDADE, 
                          int FOR_INATIVO,    
                          int FOR_ULT_COMPRA,   
                          int FOR_PESSOA,   
                          string FOR_CEP,   
                          string FOR_NOME,    
                          string FOR_BAIRRO,   
                          string FOR_LOGRADOURO,   
                          string FOR_FONE,   
                          string FOR_CELULAR,   
                          string FOR_EMAIL,    
                          string FOR_CONTATO,    
                          string FOR_OBS,   
                          DateTime FOR_CADASTRO,
                          string FOR_CPF_CNPJ,
                          string FOR_INSC_ESTADUAL)  
           
        {                    
            this._FOR_CODIGO = FOR_CODIGO;
            this._FOR_CIDADE = new Cidade(FOR_CIDADE);
            this._FOR_INATIVO = FOR_INATIVO;
            this._FOR_ULT_COMPRA = FOR_ULT_COMPRA;
            this._FOR_PESSOA = FOR_PESSOA;
            this._FOR_CEP = FOR_CEP;
            this._FOR_NOME = FOR_NOME;
            this._FOR_BAIRRO = FOR_BAIRRO;
            this._FOR_LOGRADOURO = FOR_LOGRADOURO;
            this._FOR_FONE = FOR_FONE;
            this._FOR_CELULAR = FOR_CELULAR;
            this._FOR_EMAIL = FOR_EMAIL;
            this._FOR_CONTATO = FOR_CONTATO;
            this._FOR_OBS = FOR_OBS;
            this._FOR_CADASTRO = FOR_CADASTRO;
            this._FOR_CPF_CNPJ = FOR_CPF_CNPJ;
            this._FOR_INSC_ESTADUAL = FOR_INSC_ESTADUAL;
        }
        #endregion                                                                                                                       
                                                                                                                                         
        #region Methods
        public void Carregar()
        {                                                                                                                                
         try
            {
                this._sb = new StringBuilder();
                this._sb.Append("SELECT FOR_CODIGO, FOR_CIDADE,FOR_INATIVO,FOR_ULT_COMPRA,FOR_PESSOA,FOR_CEP,FOR_NOME,FOR_BAIRRO, ");
                this._sb.Append("FOR_LOGRADOURO,FOR_FONE,FOR_CELULAR,FOR_EMAIL,FOR_CONTATO,FOR_OBS,FOR_CADASTRO,FOR_CPF_CNPJ,FOR_INSC_ESTADUAL FROM Fornecedor ");
                this._sb.Append("WHERE (FOR_CODIGO = @FOR_CODIGO) ");
                this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@FOR_CODIGO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = this._FOR_CODIGO;

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    try { 
                        this._FOR_CODIGO = dr.GetSqlInt32(0).Value;
                    }
                    catch { this._FOR_CODIGO = 0; }

                    this._FOR_CIDADE = new Cidade(dr.GetSqlInt32(1).Value);
                    try {
                    this._FOR_INATIVO = dr.GetSqlInt32(2).Value;}
                    catch { this._FOR_INATIVO = 0; }
                    try {
                    this._FOR_ULT_COMPRA = dr.GetSqlInt32(3).Value;}
                    catch { this._FOR_ULT_COMPRA = 0; }
                    try {
                    this._FOR_PESSOA = dr.GetSqlInt32(4).Value;}
                    catch { this._FOR_PESSOA = 0; }
                    try {
                    this._FOR_CEP = dr.GetSqlString(5).Value;}
                    catch { this._FOR_CEP = ""; }
                    try {
                    this._FOR_NOME = dr.GetSqlString(6).Value;}
                    catch { this._FOR_NOME = ""; }
                    try {
                    this._FOR_BAIRRO = dr.GetSqlString(7).Value;}
                    catch { this._FOR_BAIRRO = ""; }
                    try {
                    this._FOR_LOGRADOURO = dr.GetSqlString(8).Value;}
                    catch { this._FOR_LOGRADOURO = ""; }
                    try {
                    this._FOR_FONE = dr.GetSqlString(9).Value;}
                    catch { this._FOR_FONE = ""; }
                    try {
                    this._FOR_CELULAR = dr.GetSqlString(10).Value;}
                    catch { this._FOR_CELULAR = ""; }
                    try {
                    this._FOR_EMAIL = dr.GetSqlString(11).Value;}
                    catch { this._FOR_EMAIL = ""; }
                    try{
                    this._FOR_CONTATO = dr.GetSqlString(12).Value;}
                    catch { this._FOR_CONTATO = ""; }
                    try {
                    this._FOR_OBS = dr.GetSqlString(13).Value;}
                    catch { this._FOR_OBS = ""; }
                    try {
                        this._FOR_CADASTRO = dr.GetSqlDateTime(14).Value; }
                    catch { this._FOR_CADASTRO = DateTime.Now; }
                    try {
                        this._FOR_CPF_CNPJ = dr.GetSqlString(15).Value;
                    }
                    catch { this._FOR_CPF_CNPJ = ""; }
                    try
                    {
                        this._FOR_INSC_ESTADUAL = dr.GetSqlString(16).Value;
                    }
                    catch { this._FOR_INSC_ESTADUAL = ""; }
                }
                else
                {
                    this._FOR_CODIGO = 0;
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
                if (this.FOR_CODIGO == 0)
                {
                    this._sb = new StringBuilder();
                    this._sb.Append("INSERT INTO Fornecedor ( FOR_CIDADE,FOR_INATIVO,FOR_ULT_COMPRA,FOR_PESSOA,FOR_CEP,FOR_NOME,FOR_BAIRRO,FOR_LOGRADOURO,FOR_FONE,FOR_CELULAR,FOR_EMAIL,FOR_CONTATO,FOR_OBS,FOR_CADASTRO,FOR_CPF_CNPJ,FOR_INSC_ESTADUAL )");
                    this._sb.Append("VALUES (  @FOR_CIDADE,@FOR_INATIVO,@FOR_ULT_COMPRA,@FOR_PESSOA,@FOR_CEP,@FOR_NOME,@FOR_BAIRRO,@FOR_LOGRADOURO,@FOR_FONE,@FOR_CELULAR,@FOR_EMAIL,@FOR_CONTATO,@FOR_OBS,@FOR_CADASTRO,@FOR_CPF_CNPJ,@FOR_INSC_ESTADUAL)");
                    this._sb.Append("SET @FOR_CODIGO = @@IDENTITY ");
                }
                else
                {
                    this._sb.Append("UPDATE Fornecedor SET FOR_CIDADE=@FOR_CIDADE,FOR_INATIVO=@FOR_INATIVO,FOR_ULT_COMPRA=@FOR_ULT_COMPRA,FOR_PESSOA=@FOR_PESSOA,FOR_CEP=@FOR_CEP,FOR_NOME=@FOR_NOME,FOR_BAIRRO=@FOR_BAIRRO,FOR_LOGRADOURO=@FOR_LOGRADOURO,FOR_FONE=@FOR_FONE,FOR_CELULAR=@FOR_CELULAR,FOR_EMAIL=@FOR_EMAIL,FOR_CONTATO=@FOR_CONTATO,FOR_OBS=@FOR_OBS,FOR_CADASTRO=@FOR_CADASTRO,FOR_CPF_CNPJ=@FOR_CPF_CNPJ,FOR_INSC_ESTADUAL=@FOR_INSC_ESTADUAL ");
                    this._sb.Append("WHERE FOR_CODIGO=@FOR_CODIGO");
                }
               
                this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;                                        
                this.cmd.Parameters.Add("@FOR_CODIGO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = FOR_CODIGO;
                this.cmd.Parameters[0].Direction = ParameterDirection.InputOutput;  
                                     
                this.cmd.Parameters.Add("@FOR_CIDADE", SqlDbType.Int);                          
                this.cmd.Parameters[1].Value = FOR_CIDADE.CID_ID;                                      
                this.cmd.Parameters.Add("@FOR_INATIVO", SqlDbType.Int);
                this.cmd.Parameters[2].Value = FOR_INATIVO;
                this.cmd.Parameters.Add("@FOR_ULT_COMPRA", SqlDbType.Int);
                this.cmd.Parameters[3].Value = FOR_ULT_COMPRA;                                     
                this.cmd.Parameters.Add("@FOR_PESSOA", SqlDbType.Int);                          
                this.cmd.Parameters[4].Value = FOR_PESSOA;                                      
                this.cmd.Parameters.Add("@FOR_CEP", SqlDbType.VarChar);                         
                this.cmd.Parameters[5].Value = FOR_CEP;                                         
                this.cmd.Parameters.Add("@FOR_NOME", SqlDbType.VarChar);                        
                this.cmd.Parameters[6].Value = FOR_NOME;                                  
                this.cmd.Parameters.Add("@FOR_BAIRRO", SqlDbType.VarChar);
                this.cmd.Parameters[7].Value = FOR_BAIRRO;
                this.cmd.Parameters.Add("@FOR_LOGRADOURO", SqlDbType.VarChar);
                this.cmd.Parameters[8].Value = FOR_LOGRADOURO;
                this.cmd.Parameters.Add("@FOR_FONE", SqlDbType.VarChar);
                this.cmd.Parameters[9].Value = FOR_FONE;
                this.cmd.Parameters.Add("@FOR_CELULAR", SqlDbType.Text);
                this.cmd.Parameters[10].Value = FOR_CELULAR;
                this.cmd.Parameters.Add("@FOR_EMAIL", SqlDbType.Text);
                this.cmd.Parameters[11].Value = FOR_EMAIL;
                this.cmd.Parameters.Add("@FOR_OBS", SqlDbType.Text);
                this.cmd.Parameters[12].Value = FOR_OBS;
                this.cmd.Parameters.Add("@FOR_CADASTRO", SqlDbType.DateTime);
                this.cmd.Parameters[13].Value = FOR_CADASTRO;
                this.cmd.Parameters.Add("@FOR_CONTATO", SqlDbType.VarChar);
                this.cmd.Parameters[14].Value = FOR_CONTATO;
                this.cmd.Parameters.Add("@FOR_CPF_CNPJ", SqlDbType.VarChar);
                this.cmd.Parameters[15].Value = FOR_CPF_CNPJ;
                this.cmd.Parameters.Add("@FOR_INSC_ESTADUAL", SqlDbType.VarChar);
                this.cmd.Parameters[16].Value = FOR_INSC_ESTADUAL;

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

        public void Deletar(int FOR_CODIGO)
        {
            try
            {
                this.cmd = new SqlCommand("DELETE FROM Fornecedor WHERE FOR_CODIGO = @FOR_CODIGO", this.con);
                this.cmd.CommandType = CommandType.Text;

                this.cmd.Parameters.Add("@FOR_CODIGO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = FOR_CODIGO;

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
