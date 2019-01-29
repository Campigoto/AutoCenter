using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BO
{
    public class FornecedorCollection : List<Fornecedor>
    {
        #region Fields
        private int _FOR_CODIGO;
        private int _ORDER;
        private string _FOR_NOME;
        private StringBuilder _sb;
        private FornecedorLoadType _typeLoad;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public FornecedorCollection() { }

        public FornecedorCollection(bool isLoad, int ORDER)
        {
            this._typeLoad = FornecedorLoadType.LoadAll;
            this._ORDER = ORDER;
            if (isLoad) this.Carregar();
        }

        public FornecedorCollection(int FOR_CODIGO, int ORDER)
        {
            this._typeLoad = FornecedorLoadType.LoadById;
            this._FOR_CODIGO = FOR_CODIGO;
            this._ORDER = ORDER;
            this.Carregar();                                                                       
        }

        public FornecedorCollection(string FOR_NOME, int ORDER)
        {
            this._FOR_NOME = FOR_NOME;
            this._typeLoad = FornecedorLoadType.LoadByNome;
            this._ORDER = ORDER;
            this.Carregar();
        }

        public FornecedorCollection(FornecedorLoadType TIPO, string FOR_NOME, int ORDER)
        {
            this._FOR_NOME = FOR_NOME;
            this._typeLoad = TIPO;
            this._ORDER = ORDER;
            this.Carregar();
        }
        #endregion
     
        #region Methods
        private void Carregar()
        {
            try
            {
                this._sb = new StringBuilder();
                this._sb.Append("SELECT FOR_CODIGO, FOR_CIDADE, FOR_INATIVO, FOR_ULT_COMPRA, FOR_PESSOA, FOR_CEP, ");
                this._sb.Append("FOR_NOME, FOR_BAIRRO, FOR_LOGRADOURO, FOR_FONE, FOR_CELULAR, FOR_EMAIL, FOR_CONTATO, ");
                this._sb.Append("FOR_OBS, FOR_CADASTRO,FOR_CPF_CNPJ,FOR_INSC_ESTADUAL FROM Fornecedor ");
                this._sb.Append("LEFT JOIN Cidade ON FOR_CIDADE = CID_CODIGO ");
                switch (this._typeLoad)
                {
                    case FornecedorLoadType.LoadAll:
                        this._sb.Append(Order());
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        cmd.CommandType = CommandType.Text;
                        break;
                    case FornecedorLoadType.LoadByNome:
                        this._sb.Append("WHERE FOR_NOME COLLATE Latin1_General_CI_AI LIKE '%' + @FOR_NOME + '%' ");
                        this._sb.Append(Order());
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@FOR_NOME", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._FOR_NOME;
                        break;
                    case FornecedorLoadType.LoadById:
                        this._sb.Append("WHERE FOR_CODIGO = @FOR_CODIGO ");
                        this._sb.Append(Order());
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@FOR_CODIGO", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._FOR_CODIGO;
                        break;

                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
          
                while (dr.Read())                                           
                {
                    this.Add(new Fornecedor (dr.IsDBNull(0) ? 0  : dr.GetSqlInt32(0).Value,
                                             dr.IsDBNull(1) ? 0  : dr.GetSqlInt32(1).Value,
                                             dr.IsDBNull(2) ? 0  : dr.GetSqlInt32(2).Value,
                                             dr.IsDBNull(3) ? 0  : dr.GetSqlInt32(3).Value,  
                                             dr.IsDBNull(4) ? 0  : dr.GetSqlInt32(4).Value,  
                                             dr.IsDBNull(5) ? ""  : dr.GetSqlString(5).Value,  
                                             dr.IsDBNull(6) ? ""  : dr.GetSqlString(6).Value,  
                                             dr.IsDBNull(7) ? ""  : dr.GetSqlString(7).Value,  
                                             dr.IsDBNull(8) ? ""  : dr.GetSqlString(8).Value,  
                                             dr.IsDBNull(9) ? ""  : dr.GetSqlString(9).Value,  
                                             dr.IsDBNull(10) ? ""  : dr.GetSqlString(10).Value,  
                                             dr.IsDBNull(11) ? ""  : dr.GetSqlString(11).Value,  
                                             dr.IsDBNull(12) ? ""  : dr.GetSqlString(12).Value,  
                                             dr.IsDBNull(13) ? ""  : dr.GetSqlString(13).Value,   
                                             dr.IsDBNull(14) ? DateTime.Now  : dr.GetSqlDateTime(14).Value,
                                             dr.IsDBNull(15) ? ""  : dr.GetSqlString(15).Value,
                                             dr.IsDBNull(16) ? ""  : dr.GetSqlString(16).Value));  
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
                    ordenado += "FOR_CODIGO ";
                    break;
                case 1:
                    ordenado += "FOR_NOME ";
                    break;
                case 2:
                    ordenado += "CID_NOME ";
                    break;
                case 3:
                    ordenado += "FOR_FONE ";
                    break;
                case 4:
                    ordenado += "FOR_CONTATO ";
                    break;
                default:
                    ordenado += "FOR_NOME ";
                    break;
            }
            return ordenado;
        }
        #endregion
    }

    public enum FornecedorLoadType
    {
        LoadAll,
        LoadById,
        LoadByNome
    }
}
