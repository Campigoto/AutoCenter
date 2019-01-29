using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient; 

namespace BO
{
     public class GrupoProduto
    {
        #region Fields
        private int _GRP_CODIGO;
        private string _GRP_NOME;
        private string _GRP_OBS;

        private StringBuilder _sb;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        private SqlCommand cmd;
        private GrupoProdutoLoadType _typeLoad;
        #endregion

        #region Properties
        public int GRP_CODIGO
        {
            get { return _GRP_CODIGO; }
            set { _GRP_CODIGO = value; }
        }

        public string GRP_NOME
        {
            get { return _GRP_NOME; }
            set { _GRP_NOME = value; }
        }

        public string GRP_OBS
        {
            get { return _GRP_OBS; }
            set { _GRP_OBS = value; }
        }
        #endregion

        #region Constructors
        public GrupoProduto() { }

        public GrupoProduto(int GRP_CODIGO)
        {
            this._GRP_CODIGO = GRP_CODIGO;
            this._typeLoad = GrupoProdutoLoadType.LoadById;
           
            this.Load();     
        }
        public GrupoProduto(string GRP_NOME)
        {
          this._GRP_NOME = GRP_NOME;
        }

        public GrupoProduto(int GRP_CODIGO, string GRP_NOME, string GRP_OBS)
        {
            this._GRP_CODIGO = GRP_CODIGO;
            this._GRP_NOME   = GRP_NOME;
            this._GRP_OBS    = GRP_OBS;
        }
        #endregion

        #region Methods
        public static bool Verificar_GrupoProduto(int GRP_CODIGO)
        {
            SqlConnection static_conn = new SqlConnection(Connection.ConnectionString);
            SqlCommand static_cmd;
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append("SELECT GRP_CODIGO, GRP_NOME, GRP_OBS FROM Grupo_Produto ");
                sb.Append("WHERE (GRP_CODIGO = @GRP_CODIGO) ");
                static_cmd = new SqlCommand(sb.ToString(), static_conn);
                static_cmd.CommandType = CommandType.Text;
                static_cmd.Parameters.Add("@GRP_CODIGO", SqlDbType.Int);
                static_cmd.Parameters[0].Value = GRP_CODIGO;

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

        public void Salvar(int GRP_CODIGO)
        {
            try
            {
                this._sb = new StringBuilder();
                if (this._GRP_CODIGO == 0)
                {
                    this._sb.Append("INSERT INTO Grupo_Produto ( GRP_NOME, GRP_OBS ) ");
                    this._sb.Append("VALUES ( @GRP_NOME, @GRP_OBS ) ");
                    this._sb.Append("SET @GRP_CODIGO = @@IDENTITY ");


                }
                else
                {
                    this._sb.Append("UPDATE Grupo_Produto  SET GRP_NOME = @GRP_NOME, GRP_OBS = @GRP_OBS   ");
                    this._sb.Append("WHERE GRP_CODIGO=@GRP_CODIGO");
                }

                this.cmd = new SqlCommand(this._sb.ToString(), this.con);

                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@GRP_CODIGO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = GRP_CODIGO;
                this.cmd.Parameters.Add("@GRP_NOME", SqlDbType.VarChar);
                this.cmd.Parameters[1].Value = GRP_NOME;
                this.cmd.Parameters.Add("@GRP_OBS", SqlDbType.VarChar);
                this.cmd.Parameters[2].Value = GRP_OBS;

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

        public void Deletar(int GRP_CODIGO)
        {
            try
            {
                this.cmd = new SqlCommand("DELETE FROM Grupo_Produto WHERE GRP_CODIGO = @GRP_CODIGO", this.con);
                this.cmd.CommandType = CommandType.Text;

                this.cmd.Parameters.Add("@GRP_CODIGO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = GRP_CODIGO;

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
                    case GrupoProdutoLoadType.LoadAll:
                        this.cmd = new SqlCommand("SELECT GRP_CODIGO, GRP_NOME, GRP_OBS FROM Grupo_Produto", this.con);
                        cmd.CommandType = CommandType.Text;
                        break;
                    case GrupoProdutoLoadType.LoadById:
                        this.cmd = new SqlCommand("SELECT GRP_CODIGO, GRP_NOME, GRP_OBS FROM Grupo_Produto WHERE GRP_CODIGO = @GRP_CODIGO", this.con);
                        cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@GRP_CODIGO", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._GRP_CODIGO;
                        break;
                    case GrupoProdutoLoadType.LoadByGrupoProdutoNome:
                        this.cmd = new SqlCommand("SELECT GRP_CODIGO, GRP_NOME, GRP_OBS FROM Grupo_Produto WHERE GRP_NOME  COLLATE Latin1_General_CI_AI LIKE '%' + @GRP_NOME + '%'", this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@GRP_NOME", SqlDbType.VarChar);
                        this.cmd.Parameters[0].Value = this._GRP_NOME;
                        break;

                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();  
                    this._GRP_CODIGO =  dr.GetSqlInt32(0).Value;
                    this._GRP_NOME   = dr.GetSqlString(1).Value;
                    this._GRP_OBS    = dr.GetSqlString(2).Value;
                }
                else
                    this._GRP_CODIGO = 0;
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
