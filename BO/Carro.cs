using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public class Carro
    {
        #region Fields

        private int _CAR_ID;
        private string _CAR_PLACA;
        private string _CAR_MARCA;
        private string _CAR_MODELO;
        private string _CAR_COR;
        private int _CAR_ANO;
        private Cliente _ID_CLIENTE;
        private long _CAR_KM_CADA_TROCA_OLEO;
        private long _CAR_KM_ULTIMA_TROCA_OLEO;
        private long _CAR_KM_CADA_TROCA_CORREIA;
        private long _CAR_KM_ULTIMA_TROCA_CORREIA;
      
        private StringBuilder _sb;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        private SqlCommand cmd;
        #endregion

        #region Properties

        public int CAR_ID
        {
            get { return _CAR_ID; }
            set { _CAR_ID = value; }
        }

        public string CAR_PLACA
        {
            get { return _CAR_PLACA; }
            set { _CAR_PLACA = value; }
        }

        public string CAR_MARCA
        {
            get { return _CAR_MARCA; }
            set { _CAR_MARCA = value; }
        }

        public string CAR_MODELO
        {
            get { return _CAR_MODELO; }
            set { _CAR_MODELO = value; }
        }

        public string CAR_COR
        {
            get { return _CAR_COR; }
            set { _CAR_COR = value; }
        }

        public int CAR_ANO
        {
            get { return _CAR_ANO; }
            set { _CAR_ANO = value; }
        }

        public long CAR_KM_CADA_TROCA_OLEO 
        {
            get {

                if (_CAR_KM_CADA_TROCA_OLEO == null)
                    return 0;

                return _CAR_KM_CADA_TROCA_OLEO;  
            }

            set { _CAR_KM_CADA_TROCA_OLEO = value;  }
        }

        public long CAR_KM_ULTIMA_TROCA_OLEO
        {
            get {

                if (_CAR_KM_ULTIMA_TROCA_OLEO == null)
                    return 0;

                return _CAR_KM_ULTIMA_TROCA_OLEO; 
            }
            set { _CAR_KM_ULTIMA_TROCA_OLEO = value; }
        }

        public long CAR_KM_CADA_TROCA_CORREIA
        {
            get
            {

                if (_CAR_KM_CADA_TROCA_CORREIA == null)
                    return 0;

                return _CAR_KM_CADA_TROCA_CORREIA;
            }

            set { _CAR_KM_CADA_TROCA_CORREIA = value; }
        }

        public long CAR_KM_ULTIMA_TROCA_CORREIA
        {
            get
            {

                if (_CAR_KM_ULTIMA_TROCA_CORREIA == null)
                    return 0;

                return _CAR_KM_ULTIMA_TROCA_CORREIA;
            }
            set { _CAR_KM_ULTIMA_TROCA_CORREIA = value; }
        }

        #endregion

        #region Constructors

        public Carro() { }

        public Carro(string PLACA) 
        { 
            this._CAR_PLACA = PLACA; 
            this.Carregar(); 
        }

        
        public Carro(  
                int ID, 
                string PLACA, 
                string MARCA, 
                string MODELO, 
                string COR, 
                int ANO,
                long KM_CADA_TROCA_OLEO,
                long ULTIMA_TROCA_OLEO,
                long KM_CADA_TROCA_CORREIA,
                long ULTIMA_TROCA_CORREIA
            )
        {
            this._CAR_ID = ID;
            this._CAR_PLACA = PLACA;
            this._CAR_MARCA = MARCA;
            this._CAR_MODELO = MODELO;
            this._CAR_COR = COR;
            this._CAR_ANO = ANO;
            this._CAR_KM_CADA_TROCA_OLEO = KM_CADA_TROCA_OLEO;
            this._CAR_KM_ULTIMA_TROCA_OLEO = ULTIMA_TROCA_OLEO;
            this._CAR_KM_CADA_TROCA_CORREIA = KM_CADA_TROCA_CORREIA;
            this._CAR_KM_ULTIMA_TROCA_CORREIA = ULTIMA_TROCA_CORREIA;
        }

        #endregion

        #region Methods

        public void Carregar()
        {
            try
            {
                this._sb = new StringBuilder();
                this._sb.Append(@"SELECT CAR_ID, CAR_PLACA, CAR_MARCA, CAR_MODELO, CAR_COR, CAR_ANO, CAR_KM_CADA_TROCA_OLEO, CAR_KM_ULTIMA_TROCA_OLEO,
                                  CAR_KM_CADA_TROCA_CORREIA, CAR_KM_ULTIMA_TROCA_CORREIA");
                this._sb.Append(" FROM CARRO WHERE CAR_PLACA = @CAR_PLACA");
                this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@CAR_PLACA", SqlDbType.VarChar);
                this.cmd.Parameters[0].Value = this._CAR_PLACA;

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    this._CAR_ID = dr.IsDBNull(0) ? 0 : dr.GetSqlInt32(0).Value;
                    this._CAR_PLACA = dr.IsDBNull(1) ? "" : dr.GetSqlString(1).Value;
                    this._CAR_MARCA = dr.IsDBNull(2) ? "" : dr.GetSqlString(2).Value;
                    this._CAR_MODELO = dr.IsDBNull(3) ? "" : dr.GetSqlString(3).Value;
                    this._CAR_COR = dr.IsDBNull(4) ? "" : dr.GetSqlString(4).Value;
                    this._CAR_ANO = dr.IsDBNull(5) ? 0 : dr.GetSqlInt32(5).Value;
                    this._CAR_KM_CADA_TROCA_OLEO = dr.IsDBNull(6) ? 0 : dr.GetSqlInt64(6).Value;
                    this._CAR_KM_ULTIMA_TROCA_OLEO = dr.IsDBNull(7) ? 0 : dr.GetSqlInt64(7).Value;
                    this._CAR_KM_CADA_TROCA_CORREIA = dr.IsDBNull(8) ? 0 : dr.GetSqlInt64(8).Value;
                    this._CAR_KM_ULTIMA_TROCA_CORREIA = dr.IsDBNull(9) ? 0 : dr.GetSqlInt64(9).Value;
                }
                else
                {
                    this._CAR_ID = 0;
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
                if (this.CAR_ID == 0)
                {
                    this._sb = new StringBuilder();
                    this._sb.Append("INSERT INTO Carro ( CAR_PLACA , CAR_MARCA , CAR_MODELO , CAR_COR, CAR_ANO, CAR_KM_CADA_TROCA_OLEO, CAR_KM_ULTIMA_TROCA_OLEO, CAR_KM_CADA_TROCA_CORREIA, CAR_KM_ULTIMA_TROCA_CORREIA) ");
                    this._sb.Append("VALUES (  @CAR_PLACA , @CAR_MARCA , @CAR_MODELO , @CAR_COR , @CAR_ANO, @CAR_KM_CADA_TROCA_OLEO, @CAR_KM_ULTIMA_TROCA_OLEO, @CAR_KM_CADA_TROCA_CORREIA, @CAR_KM_ULTIMA_TROCA_CORREIA ) ");
                }
                else
                {
                    this._sb.Append(@"UPDATE Carro 
                                      SET CAR_PLACA=@CAR_PLACA, 
                                          CAR_MARCA=@CAR_MARCA, 
                                          CAR_MODELO=@CAR_MODELO, 
                                          CAR_COR=@CAR_COR, 
                                          CAR_ANO=@CAR_ANO,
                                          CAR_KM_CADA_TROCA_OLEO=@CAR_KM_CADA_TROCA_OLEO,
                                          CAR_KM_ULTIMA_TROCA_OLEO=@CAR_KM_ULTIMA_TROCA_OLEO,
                                          CAR_KM_CADA_TROCA_CORREIA=@CAR_KM_CADA_TROCA_CORREIA, 
                                          CAR_KM_ULTIMA_TROCA_CORREIA=@CAR_KM_ULTIMA_TROCA_CORREIA");

                    this._sb.Append(" WHERE CAR_ID=@CAR_ID");
                }

                this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@CAR_PLACA", SqlDbType.VarChar);
                this.cmd.Parameters[0].Value = CAR_PLACA;
                this.cmd.Parameters[0].Direction = ParameterDirection.InputOutput;

                this.cmd.Parameters.Add("@CAR_MARCA", SqlDbType.VarChar);
                this.cmd.Parameters[1].Value = CAR_MARCA;
                this.cmd.Parameters.Add("@CAR_MODELO", SqlDbType.VarChar);
                this.cmd.Parameters[2].Value = CAR_MODELO;
                this.cmd.Parameters.Add("@CAR_COR", SqlDbType.VarChar);
                this.cmd.Parameters[3].Value = CAR_COR;
                this.cmd.Parameters.Add("@CAR_ANO", SqlDbType.Int);
                this.cmd.Parameters[4].Value = CAR_ANO;

                this.cmd.Parameters.Add("@CAR_ID",SqlDbType.Int);
                this.cmd.Parameters[5].Value = CAR_ID;

                this.cmd.Parameters.Add("@CAR_KM_CADA_TROCA_OLEO", SqlDbType.BigInt);
                this.cmd.Parameters[6].Value = CAR_KM_CADA_TROCA_OLEO;

                this.cmd.Parameters.Add("@CAR_KM_ULTIMA_TROCA_OLEO", SqlDbType.BigInt);
                this.cmd.Parameters[7].Value = CAR_KM_ULTIMA_TROCA_OLEO;

                this.cmd.Parameters.Add("@CAR_KM_CADA_TROCA_CORREIA", SqlDbType.BigInt);
                this.cmd.Parameters[8].Value = CAR_KM_CADA_TROCA_CORREIA;

                this.cmd.Parameters.Add("@CAR_KM_ULTIMA_TROCA_CORREIA", SqlDbType.BigInt);
                this.cmd.Parameters[9].Value = CAR_KM_ULTIMA_TROCA_CORREIA;

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

        public void Deletar(string PLACA)
        {
            try
            {
                this.cmd = new SqlCommand("DELETE FROM Carro WHERE CAR_PLACA = @CAR_PLACA", this.con);
                this.cmd.CommandType = CommandType.Text;

                this.cmd.Parameters.Add("@CAR_PLACA", SqlDbType.VarChar);
                this.cmd.Parameters[0].Value = PLACA;

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
