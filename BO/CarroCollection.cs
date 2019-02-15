using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
    public class CarroCollection : List<Carro>
    {
        #region Fields
        private int _CAR_ID = 0;
        private int _ORDER;
        private CarroLoadType _typeLoad;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Constructors
        public CarroCollection() { }

        public CarroCollection(bool isLoad, int ORDER)
        {
            this._typeLoad = CarroLoadType.LoadAll;
            this._ORDER = ORDER;
            if (isLoad) this.Load();
        }

        public CarroCollection(int CAR_ID, int ORDER)
        {
            this._typeLoad = CarroLoadType.LoadById;
            this._CAR_ID = CAR_ID;
            this._ORDER = ORDER;
            this.Load();
        }

        #endregion

        #region Methods
        private void Load()
        {
            try
            {
                string query = @"SELECT CAR_ID, 
                                    CAR_PLACA, 
                                    CAR_MARCA, 
                                    CAR_MODELO, 
                                    CAR_COR, 
                                    CAR_ANO, 
                                    CAR_KM_CADA_TROCA_OLEO, 
                                    CAR_KM_ULTIMA_TROCA_OLEO,
                                    CAR_KM_CADA_TROCA_CORREIA, 
                                    CAR_KM_ULTIMA_TROCA_CORREIA 
                                FROM CARRO ";
                switch (this._typeLoad)
                {
                    case CarroLoadType.LoadAll:
                        this.cmd = new SqlCommand(query + Order(), this.con);
                        cmd.CommandType = CommandType.Text;
                        break;
                    case CarroLoadType.LoadById:
                        this.cmd = new SqlCommand(query + " WHERE CAR_ID = @CAR_ID " + Order(), this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@CAR_ID", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._CAR_ID;
                        break;
                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.Add(new Carro(
                                        dr.IsDBNull(0) ? 0  : dr.GetSqlInt32(0).Value,
                                        dr.IsDBNull(1) ? "" : dr.GetSqlString(1).Value,
                                        dr.IsDBNull(2) ? "" : dr.GetSqlString(2).Value,
                                        dr.IsDBNull(3) ? "" : dr.GetSqlString(3).Value,
                                        dr.IsDBNull(4) ? "" : dr.GetSqlString(4).Value,
                                        dr.IsDBNull(5) ? 0  : dr.GetSqlInt32(5).Value,
                                        dr.IsDBNull(6) ? 0 : dr.GetSqlInt64(6).Value,
                                        dr.IsDBNull(7) ? 0 : dr.GetSqlInt64(7).Value,
                                        dr.IsDBNull(8) ? 0 : dr.GetSqlInt64(8).Value,
                                        dr.IsDBNull(9) ? 0 : dr.GetSqlInt64(9).Value
                                       )
                            );
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
                case 1:
                    ordenado += "CAR_PLACA ";
                    break;
                case 2:
                    ordenado += "CAR_MARCA ";
                    break;
                case 3:
                    ordenado += "CAR_MODELO";
                    break;
                case 4:
                    ordenado += "CAR_COR";
                    break;
                default:
                    ordenado += "CAR_ANO";
                    break;
            }
            return ordenado;
        }
        #endregion

        public enum CarroLoadType
        {
            LoadAll,
            LoadById
        }
    }
}
