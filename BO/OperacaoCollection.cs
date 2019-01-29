using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BO
{
    public class OperacaoCollection : List<Operacao>
    {
        #region Fields
        private OperacaoLoadType _TIPO;
        private int _OF_FUNCIONARIO;

        private StringBuilder _sb;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        private SqlCommand cmd;
        #endregion

        #region Constructors
        public OperacaoCollection() { }

        public OperacaoCollection(bool isLoad)
        {
            if (isLoad)
            {
                this._TIPO = OperacaoLoadType.LoadAll;
                this.Carregar();
            }
        }

        public OperacaoCollection(OperacaoLoadType TIPO, int OF_FUNCIONARIO)
        {
            this._OF_FUNCIONARIO = OF_FUNCIONARIO;
            this._TIPO = TIPO;
            this.Carregar();
        }
        #endregion

        #region Methods
        private void Carregar()
        {
            try
            {
                this._sb = new StringBuilder();
                switch (this._TIPO)
                {
                    case OperacaoLoadType.LoadAll:
                        this._sb.Append("SELECT OPE_CODIGO, OPE_NOME ");
                        this._sb.Append("FROM Operacao ORDER BY OPE_NOME ");
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        break;

                    case OperacaoLoadType.LoadByOperacao:
                        this._sb.Append("SELECT OPE_CODIGO, OPE_NOME FROM Operacoes_Funcionario ");
                        this._sb.Append("LEFT JOIN Operacao ON OF_OPERACAO = OPE_CODIGO ");
                        this._sb.Append("WHERE OF_FUNCIONARIO = @OF_FUNCIONARIO ORDER BY OPE_NOME ");
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        this.cmd.Parameters.Add("@OF_FUNCIONARIO", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._OF_FUNCIONARIO;
                        break;

                    case OperacaoLoadType.LoadBySemOperacao:
                        this._sb.Append("SELECT OPE_CODIGO, OPE_NOME FROM Operacao ");
                        this._sb.Append("LEFT JOIN Operacoes_Funcionario ON OPE_CODIGO = OF_OPERACAO AND OF_FUNCIONARIO = @OF_FUNCIONARIO ");
                        this._sb.Append("WHERE COALESCE(OF_FUNCIONARIO, 0) = 0 ORDER BY OPE_NOME ");
                        this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                        this.cmd.Parameters.Add("@OF_FUNCIONARIO", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._OF_FUNCIONARIO;
                        break;
                }

                this.cmd.CommandType = CommandType.Text;
                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Operacao operacao = new Operacao(dr.GetInt32(0), dr.GetString(1));
                    this.Add(operacao);
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

    public enum OperacaoLoadType
    {
        LoadAll,
        LoadByOperacao,
        LoadBySemOperacao,
        LoadBySemFuncionario
    }
}
