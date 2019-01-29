using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BO
{
    public class Operacao
    {
        #region Fields
        private int _OPE_CODIGO;
        private string _OPE_NOME;

        private StringBuilder _sb;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        private SqlCommand cmd;
        #endregion

        #region Properties
        public int OPE_CODIGO
        {
            get { return _OPE_CODIGO; }
            set { _OPE_CODIGO = value; }
        }

        public string OPE_NOME
        {
            get { return _OPE_NOME; }
            set { _OPE_NOME = value; }
        }
        #endregion

        #region Constructors
        public Operacao() { }

        public Operacao(int OPE_CODIGO, string OPE_NOME)
        {
            this._OPE_CODIGO = OPE_CODIGO;
            this._OPE_NOME = OPE_NOME;
        }
        #endregion

        #region Methods
        public static bool Verificar_Operacao(int OF_OPERACAO, int OF_FUNCIONARIO)
        {
            SqlConnection static_conn = new SqlConnection(Connection.ConnectionString);
            SqlCommand static_cmd;
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append("SELECT OF_OPERACAO, FUN_CODIGO FROM Operacoes_Funcionario ");
                sb.Append("WHERE (OF_OPERACAO = @OF_OPERACAO) AND (OF_FUNCIONARIO = @OF_FUNCIONARIO) ");
                static_cmd = new SqlCommand(sb.ToString(), static_conn);
                static_cmd.CommandType = CommandType.Text;
                static_cmd.Parameters.Add("@OF_OPERACAO", SqlDbType.Int);
                static_cmd.Parameters[0].Value = OF_OPERACAO;
                static_cmd.Parameters.Add("@OF_FUNCIONARIO", SqlDbType.Int);
                static_cmd.Parameters[1].Value = OF_FUNCIONARIO;

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

        public void Salvar(int OF_OPERACAO, int OF_FUNCIONARIO)
        {
            try
            {
                this._sb = new StringBuilder();
                this._sb.Append("INSERT INTO Operacoes_Funcionario ( OF_OPERACAO, OF_FUNCIONARIO ) ");
                this._sb.Append("VALUES ( @OF_OPERACAO, @OF_FUNCIONARIO ) ");

                this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@OF_OPERACAO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = OF_OPERACAO;
                this.cmd.Parameters.Add("@OF_FUNCIONARIO", SqlDbType.Int);
                this.cmd.Parameters[1].Value = OF_FUNCIONARIO;

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

        public void Deletar(int OF_OPERACAO, int OF_FUNCIONARIO)
        {
            try
            {
                this.cmd = new SqlCommand("DELETE FROM Operacoes_Funcionario WHERE OF_OPERACAO = @OF_OPERACAO AND OF_FUNCIONARIO = @OF_FUNCIONARIO ", this.con);
                this.cmd.CommandType = CommandType.Text;

                this.cmd.Parameters.Add("@OF_OPERACAO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = OF_OPERACAO;
                this.cmd.Parameters.Add("@OF_FUNCIONARIO", SqlDbType.Int);
                this.cmd.Parameters[1].Value = OF_FUNCIONARIO;

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

