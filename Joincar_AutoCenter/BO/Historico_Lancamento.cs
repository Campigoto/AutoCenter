using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient; 

namespace BO
{
    public class Historico_Lancamento
    {
         #region Fields
        private int _HIS_ID;
        private string _HIS_CODIGO;
        private string _HIS_DESCRICAO;

        private StringBuilder _sb;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        private SqlCommand cmd;
        private Historico_LancamentoLoadType _typeLoad;
        #endregion

        #region Properties
        public string HIS_CODIGO
        {
            get { return _HIS_CODIGO; }
            set { _HIS_CODIGO = value; }
        }

        public string HIS_DESCRICAO
        {
            get { return _HIS_DESCRICAO; }
            set { _HIS_DESCRICAO = value; }
        }

        public int HIS_ID
        {
            get { return _HIS_ID; }
            set { _HIS_ID = value; }
        }
        #endregion

        #region Constructors
        public Historico_Lancamento() { }

        public Historico_Lancamento(int HIS_ID)
        {
            this._HIS_ID = HIS_ID;
            this._typeLoad = Historico_LancamentoLoadType.LoadById;
            this.Load();     
        }
       

        public Historico_Lancamento(string HIS_CODIGO)
        {
            this._HIS_CODIGO = HIS_CODIGO;
            this._typeLoad = Historico_LancamentoLoadType.LoadByCodigo;
            this.Load();     
        }

        public Historico_Lancamento(int HIS_ID, string HIS_CODIGO, string HIS_DESCRICAO)
        {
            this._HIS_CODIGO = HIS_CODIGO;
            this._HIS_DESCRICAO   = HIS_DESCRICAO;
            this._HIS_ID    = HIS_ID;
        }
        #endregion

        #region Methods
        public static bool Verificar_Historico_Lancamento(string HIS_CODIGO)
        {
            SqlConnection static_conn = new SqlConnection(Connection.ConnectionString);
            SqlCommand static_cmd;
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append("SELECT HIS_ID,HIS_CODIGO, HIS_DESCRICAO  FROM Historico_Lancamento ");
                sb.Append("WHERE (HIS_CODIGO = @HIS_CODIGO) ");
                static_cmd = new SqlCommand(sb.ToString(), static_conn);
                static_cmd.CommandType = CommandType.Text;
                static_cmd.Parameters.Add("@HIS_CODIGO", SqlDbType.VarChar);
                static_cmd.Parameters[0].Value = HIS_CODIGO;

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

        public void Salvar()
        {
            try
            {
                this._sb = new StringBuilder();
                if (this._HIS_ID == 0)
                {
                    this._sb.Append("INSERT INTO Historico_Lancamento ( HIS_CODIGO, HIS_DESCRICAO  ) ");
                    this._sb.Append("VALUES ( @HIS_CODIGO  ,@HIS_DESCRICAO) ");
                    this._sb.Append("SET @HIS_ID = @@IDENTITY ");


                }
                else
                {
                    this._sb.Append("UPDATE Historico_Lancamento  SET HIS_CODIGO=@HIS_CODIGO, HIS_DESCRICAO = @HIS_DESCRICAO    ");
                    this._sb.Append("WHERE HIS_ID = @HIS_ID");
                }

                this.cmd = new SqlCommand(this._sb.ToString(), this.con);

                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@HIS_ID", SqlDbType.Int);
                this.cmd.Parameters[0].Value = HIS_ID;
                this.cmd.Parameters[0].Direction = ParameterDirection.InputOutput;
                this.cmd.Parameters.Add("@HIS_CODIGO", SqlDbType.VarChar);
                this.cmd.Parameters[1].Value = HIS_CODIGO;
                this.cmd.Parameters.Add("@HIS_DESCRICAO", SqlDbType.VarChar);
                this.cmd.Parameters[2].Value = HIS_DESCRICAO;

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

        public void Deletar(int HIS_CODIGO)
        {
            try
            {
                this.cmd = new SqlCommand("DELETE FROM Historico_Lancamento WHERE HIS_ID = @HIS_ID", this.con);
                this.cmd.CommandType = CommandType.Text;

                this.cmd.Parameters.Add("@HIS_ID", SqlDbType.Int);
                this.cmd.Parameters[0].Value = HIS_CODIGO;

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
        private void Load()
        {
            try
            {
                switch (this._typeLoad)
                {
                    case Historico_LancamentoLoadType.LoadAll:
                        this.cmd = new SqlCommand("SELECT HIS_ID, HIS_CODIGO, HIS_DESCRICAO FROM Historico_Lancamento", this.con);
                        cmd.CommandType = CommandType.Text;
                        break;
                    case Historico_LancamentoLoadType.LoadById:
                        this.cmd = new SqlCommand("SELECT HIS_ID,HIS_CODIGO, HIS_DESCRICAO FROM Historico_Lancamento WHERE  HIS_ID = @HIS_ID", this.con);
                        cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@HIS_ID", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this.HIS_ID;
                        break;
                    case Historico_LancamentoLoadType.LoadByCodigo:
                        this.cmd = new SqlCommand("SELECT HIS_ID,HIS_CODIGO, HIS_DESCRICAO FROM Historico_Lancamento WHERE  HIS_CODIGO = @HIS_CODIGO", this.con);
                        cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@HIS_CODIGO", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this.HIS_CODIGO;
                        break;
                    case Historico_LancamentoLoadType.LoadByHistorico_LancamentoDESCRICAO:
                        this.cmd = new SqlCommand("SELECT HIS_ID, HIS_CODIGO, HIS_DESCRICAO  FROM Historico_Lancamento WHERE HIS_DESCRICAO  COLLATE Latin1_General_CI_AI LIKE '%' + @HIS_DESCRICAO + '%'", this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@HIS_DESCRICAO", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._HIS_DESCRICAO;
                        break;

                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    this._HIS_ID          = dr.GetSqlInt32(0).Value;
                    this._HIS_CODIGO      = dr.GetSqlString(1).Value;
                    this._HIS_DESCRICAO   = dr.GetSqlString(2).Value;
                }
                else
                    this._HIS_ID = 0;
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
