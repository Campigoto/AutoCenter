using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public class Cep
    {
        #region Fields
        private int _CEP_ID;
        private string _NOME_RUA;
        private string _BAIRRO;
        private string _CEP_LOCAL;
        private string _COD_ESTADO;
        private string _TIPO_LOGRADOURO;
        private string _COD_CIDADE;
        private string _COMPLEMENTO;
        private Cidade _CID_ID;

        private StringBuilder _sb;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        private SqlCommand cmd;
        #endregion

        #region Properties
        public int CEP_ID
        {
            get { return _CEP_ID; }
            set { _CEP_ID = value; }
        }
        public string NOME_RUA
        {
            get { return _NOME_RUA; }
            set { _NOME_RUA = value; }
        }
        public string BAIRRO
        {
            get { return _BAIRRO; }
            set { _BAIRRO = value; }
        }
        public string CEP_LOCAL
        {
            get { return _CEP_LOCAL; }
            set { _CEP_LOCAL = value; }
        }
        public string COD_ESTADO
        {
            get { return _COD_ESTADO; }
            set { _COD_ESTADO = value; }
        }
        public string TIPO_LOGRADOURO
        {
            get { return _TIPO_LOGRADOURO; }
            set { _TIPO_LOGRADOURO = value; }
        }
        public string COD_CIDADE
        {
            get { return _COD_CIDADE; }
            set { _COD_CIDADE = value; }
        }
        public string COMPLEMENTO
        {
            get { return _COMPLEMENTO; }
            set { _COMPLEMENTO = value; }
        }
        public Cidade CID_ID
        {
            get { return _CID_ID; }
            set { _CID_ID = value; }
        }
        #endregion

        #region Constructors

        public Cep(){}

        public Cep(int CEP_ID)
        {
            this._CEP_ID = CEP_ID;
        }

        public Cep(
                    int CEP_ID,
                    string NOME_RUA,
                    string BAIRRO,
                    string CEP_LOCAL,
                    string COD_ESTADO,
                    string TIPO_LOGRADOURO,
                    string COD_CIDADE,
                    string COMPLEMENTO            
                  ) 
        {
            this._CEP_ID = CEP_ID;
            this._NOME_RUA = NOME_RUA;
            this._BAIRRO = BAIRRO;
            this._CEP_LOCAL = CEP_LOCAL;
            this._COD_ESTADO = COD_ESTADO;
            this._TIPO_LOGRADOURO = TIPO_LOGRADOURO;
            this._COD_CIDADE = COD_CIDADE;
            this._COMPLEMENTO = COMPLEMENTO;
        }
            
        #endregion

        #region Methods

        public void Carregar()
        {
            try 
            {
                this._sb = new StringBuilder();
                _sb.Append("SELECT CEP_ID, NMRUA, BAIRROINIC, CEPLOCAL, CODEST, TPLOG, CODCID, COMPLEM");
                _sb.Append(" WHERE CEP_ID = @CEP_ID ");
                this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@CEP_ID", SqlDbType.Int);
                this.cmd.Parameters[0].Value = this._CEP_ID;

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    try { this._CEP_ID = CEP_ID = dr.GetSqlInt32(0).Value; } catch { this._CEP_ID = 0; }
                    try { this._NOME_RUA = dr.GetSqlString(1).Value; } catch { this._NOME_RUA = ""; }
                    try { this._BAIRRO = dr.GetSqlString(2).Value; } catch { this._BAIRRO = ""; }
                    try { this._CEP_LOCAL = dr.GetSqlString(3).Value; } catch { this._CEP_LOCAL = ""; }
                    try { this._COD_ESTADO = dr.GetSqlString(4).Value; } catch { this._COD_ESTADO = ""; }
                    try { this._TIPO_LOGRADOURO = dr.GetSqlString(5).Value; } catch { this._TIPO_LOGRADOURO = ""; }
                    try { this._COD_CIDADE = dr.GetSqlString(6).Value; } catch { this._COD_CIDADE = ""; }
                    try { this._COMPLEMENTO = dr.GetSqlString(7).Value; } catch { this._COMPLEMENTO = ""; }
                    try { this._CID_ID = new Cidade(dr.GetSqlInt32(6).Value); } catch { this._CID_ID = new Cidade(); }
                }
                else
                {
                    this._CEP_ID = 0;
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
                if (this._CEP_ID == 0)
                {
                    this._sb.Append("INSERT INTO CEP ( NMRUA, BAIRROINIC, CEPLOCAL, CODEST, TPLOG, CODCID, COMPLEM) ");
                    this._sb.Append(" VALUES         (@NMRUA, @BAIRRO, @CEPLOCAL, @CODEST, @TPLOG, @CODCID, @COMPLEM) ");
                }
                else
                {
                    this._sb.Append("UPDATE CEP SET  ");
                    this._sb.Append("NMRUA=@NMRUA,BAIRROINIC=@BAIRRO,CEPLOCAL=@CEPLOCAL,CODEST=@CODEST,TPLOG=@TPLOG,CODCID=@CODCID,COMPLEM=@COMPLEM ");
                }

                this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;                         
                this.cmd.Parameters.Add("@NMRUA", SqlDbType.VarChar);
                this.cmd.Parameters[0].Value = this._NOME_RUA;
                this.cmd.Parameters.Add("@BAIRRO", SqlDbType.VarChar);
                this.cmd.Parameters[1].Value = this._BAIRRO;
                this.cmd.Parameters.Add("@CEPLOCAL", SqlDbType.VarChar);
                this.cmd.Parameters[2].Value = this._CEP_LOCAL;
                this.cmd.Parameters.Add("@CODEST",SqlDbType.VarChar);
                this.cmd.Parameters[3].Value = this._COD_ESTADO;
                this.cmd.Parameters.Add("@TPLOG", SqlDbType.VarChar);
                this.cmd.Parameters[4].Value = this._TIPO_LOGRADOURO;
                this.cmd.Parameters.Add("@CODCID",SqlDbType.VarChar);
                this.cmd.Parameters[5].Value = this._COD_CIDADE;
                this.cmd.Parameters.Add("@COMPLEM",SqlDbType.VarChar);
                this.cmd.Parameters[6].Value = this._COMPLEMENTO;

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

        public void Deletar(int CEP_ID)
        {
            try
            {
                this.cmd = new SqlCommand("DELETE FROM CEP WHERE CEP_ID = @CEP_ID", this.con);
                this.cmd.CommandType = CommandType.Text;

                this.cmd.Parameters.Add("@CEP_ID", SqlDbType.Int);
                this.cmd.Parameters[0].Value = CEP_ID;

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
