using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
   public class Historico_Estoque_Preco
   {
        #region Fields
       private int _HEP_CODIGO = 0;
       private int _HEP_PRODUTO;
       private int _HEP_COMPRA;
       private int _HEP_USUARIO;
       private float _HEP_ESTOQUE_ANTERIOR;
       private float _HEP_ESTOQUE_ATUAL;
       private float _HEP_QTDE;
       private float _HEP_PRECO_UNITARIO;
       private float _HEP_PRECO_TOTAL;
       private DateTime _HEP_DATA;

       private string _FUN_NOME = "";
       private StringBuilder _CONSULTA;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Properties
       public int HEP_CODIGO
        {
            get { return _HEP_CODIGO; }
            set { _HEP_CODIGO = value; }                                        
        }
       public int HEP_PRODUTO
       {
           get { return _HEP_PRODUTO; }
           set { _HEP_PRODUTO = value; }
       }
       public int HEP_COMPRA
       {
           get { return _HEP_COMPRA; }
           set { _HEP_COMPRA = value; }
       }
       public string HEP_COMPRA_FORMATADO
       {
           get 
           {
               if (_HEP_COMPRA > 0)
               {
                   return _HEP_COMPRA.ToString();
               }
               else
               {
                   return "";
               }
           }
       }
       public int HEP_USUARIO
       {
           get { return _HEP_USUARIO; }
           set { _HEP_USUARIO = value; }
       }
       public string FUN_NOME
       {
           get { return _FUN_NOME; }
       }
       public float HEP_ESTOQUE_ANTERIOR
       {
           get { return _HEP_ESTOQUE_ANTERIOR; }
           set { _HEP_ESTOQUE_ANTERIOR = value; }
       }
       public string HEP_ESTOQUE_ANTERIOR_FORMATADO
       {
           get { return _HEP_ESTOQUE_ANTERIOR.ToString("0.000"); }
       }
       public float HEP_ESTOQUE_ATUAL
       {
           get { return _HEP_ESTOQUE_ATUAL; }
           set { _HEP_ESTOQUE_ATUAL = value; }
       }
       public string HEP_ESTOQUE_ATUAL_FORMATADO
       {
           get { return _HEP_ESTOQUE_ATUAL.ToString("0.000"); }
       }
       public float HEP_QTDE
       {
           get { return _HEP_QTDE; }
           set { _HEP_QTDE = value; }
       }
       public string HEP_QTDE_FORMATADO
       {
           get { return _HEP_QTDE.ToString("0.000"); }
       }
       public float HEP_PRECO_UNITARIO
       {
           get { return _HEP_PRECO_UNITARIO; }
           set { _HEP_PRECO_UNITARIO = value; }
       }
       public string HEP_PRECO_UNITARIO_FORMATADO
       {
           get { return _HEP_PRECO_UNITARIO.ToString("0.000"); }
       }
       public float HEP_PRECO_TOTAL
       {
           get { return _HEP_PRECO_TOTAL; }
           set { _HEP_PRECO_TOTAL = value; }
       }
       public string HEP_PRECO_TOTAL_FORMATADO
       {
           get { return _HEP_PRECO_TOTAL.ToString("0.000"); }
       }
       public DateTime HEP_DATA
       {
           get { return _HEP_DATA; }
           set { _HEP_DATA = value; }
       }
       public string HEP_DATA_FORMATADO
       {
           get { return _HEP_DATA.ToString("dd/MM/yyyy"); }
       }
       public string HEP_HORA_FORMATADO
       {
           get { return _HEP_DATA.ToString("HH:mm"); }
       }
       public string HEP_TIPO
       {
           get 
           {
               if (_HEP_ESTOQUE_ATUAL > _HEP_ESTOQUE_ANTERIOR)
               {
                   return "Entrada"; 
               }
               else
               {
                   return "Saída"; 
               }
           }
       }
        #endregion
                                                                                                   
        #region Constructors
        public Historico_Estoque_Preco() { }

       public Historico_Estoque_Preco(int HEP_CODIGO)
        {
            this._HEP_CODIGO = HEP_CODIGO;
            this.Salvar();                                                                       
        }

       public Historico_Estoque_Preco(int HEP_CODIGO, int HEP_PRODUTO, int HEP_COMPRA, int HEP_USUARIO, float HEP_ESTOQUE_ANTERIOR, 
           float HEP_ESTOQUE_ATUAL, float HEP_QTDE, float HEP_PRECO_UNITARIO, float HEP_PRECO_TOTAL, DateTime HEP_DATA, string FUN_NOME)
        {
            this._HEP_CODIGO = HEP_CODIGO;
            this._HEP_PRODUTO = HEP_PRODUTO;
            this._HEP_COMPRA = HEP_COMPRA;
            this._HEP_USUARIO = HEP_USUARIO;
            this._HEP_ESTOQUE_ANTERIOR = HEP_ESTOQUE_ANTERIOR;
            this._HEP_ESTOQUE_ATUAL = HEP_ESTOQUE_ATUAL;
            this._HEP_QTDE = HEP_QTDE;
            this._HEP_PRECO_UNITARIO = HEP_PRECO_UNITARIO;
            this._HEP_PRECO_TOTAL = HEP_PRECO_TOTAL;
            this._HEP_DATA = HEP_DATA;
            this._FUN_NOME = FUN_NOME;
        }                                                                      
        #endregion

        #region Methods
        private void Carregar()
        {
            try
            {
                this._CONSULTA = new StringBuilder();
                this._CONSULTA.Append("SELECT HEP_CODIGO, HEP_PRODUTO, HEP_COMPRA, HEP_USUARIO, HEP_ESTOQUE_ANTERIOR, ");
                this._CONSULTA.Append("HEP_ESTOQUE_ATUAL, HEP_QTDE, HEP_PRECO_UNITARIO, HEP_PRECO_TOTAL, HEP_DATA ");
                this._CONSULTA.Append("FROM Historico_Estoque_Preco WHERE HEP_CODIGO = @HEP_CODIGO ");
                this.cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;
                this.cmd.Parameters.Add("@HEP_CODIGO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = this._HEP_CODIGO;

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    this._HEP_CODIGO = dr.GetSqlInt32(0).Value;
                    this._HEP_PRODUTO = dr.GetSqlInt32(1).Value;
                    this._HEP_COMPRA = dr.GetSqlInt32(2).Value;
                    this._HEP_USUARIO = dr.GetSqlInt32(3).Value;
                    this._HEP_ESTOQUE_ANTERIOR = float.Parse(dr.GetSqlDouble(4).Value.ToString());
                    this._HEP_ESTOQUE_ATUAL = float.Parse(dr.GetSqlDouble(5).Value.ToString());
                    this._HEP_QTDE = float.Parse(dr.GetSqlDouble(6).Value.ToString());
                    this._HEP_PRECO_UNITARIO = float.Parse(dr.GetSqlDouble(7).Value.ToString());
                    this._HEP_PRECO_TOTAL = float.Parse(dr.GetSqlDouble(8).Value.ToString());
                    this._HEP_DATA = dr.GetSqlDateTime(9).Value;
                }                           
                else
                    this._HEP_CODIGO = 0;
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
                this._CONSULTA = new StringBuilder();
                if (this._HEP_CODIGO == 0)
                {

                    this._CONSULTA.Append("INSERT INTO Historico_Estoque_Preco ( HEP_PRODUTO, HEP_COMPRA, HEP_USUARIO, ");
                    this._CONSULTA.Append("HEP_ESTOQUE_ANTERIOR, HEP_ESTOQUE_ATUAL, HEP_QTDE, HEP_PRECO_UNITARIO, HEP_PRECO_TOTAL, HEP_DATA ) ");
                    this._CONSULTA.Append("VALUES ( @HEP_PRODUTO, @HEP_COMPRA, @HEP_USUARIO, ");
                    this._CONSULTA.Append("@HEP_ESTOQUE_ANTERIOR, @HEP_ESTOQUE_ATUAL, @HEP_QTDE, @HEP_PRECO_UNITARIO, @HEP_PRECO_TOTAL, @HEP_DATA ) ");
                    this._CONSULTA.Append("SET @HEP_CODIGO = @@IDENTITY ");
                }
                else
                {
                    this._CONSULTA.Append("UPDATE Historico_Estoque_Preco SET HEP_PRODUTO = @HEP_PRODUTO, HEP_COMPRA = @HEP_COMPRA, ");
                    this._CONSULTA.Append("HEP_USUARIO = @HEP_USUARIO, HEP_ESTOQUE_ANTERIOR = @HEP_ESTOQUE_ANTERIOR, ");
                    this._CONSULTA.Append("HEP_ESTOQUE_ATUAL = @HEP_ESTOQUE_ATUAL, HEP_QTDE = @HEP_QTDE, HEP_PRECO_UNITARIO = @HEP_PRECO_UNITARIO, HEP_PRECO_TOTAL = @HEP_PRECO_TOTAL, ");
                    this._CONSULTA.Append("HEP_DATA = @HEP_DATA WHERE HEP_CODIGO = @HEP_CODIGO ");
                }
                SqlCommand cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);                                   
                                                                                                          
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@HEP_CODIGO", SqlDbType.Int);
                cmd.Parameters[0].Value = this._HEP_CODIGO;
                cmd.Parameters[0].Direction = ParameterDirection.InputOutput;
                cmd.Parameters.Add("@HEP_PRODUTO", SqlDbType.Int);
                cmd.Parameters[1].Value = this._HEP_PRODUTO;
                cmd.Parameters.Add("@HEP_COMPRA", SqlDbType.Int);
                cmd.Parameters[2].Value = this._HEP_COMPRA;
                cmd.Parameters.Add("@HEP_USUARIO", SqlDbType.Int);
                cmd.Parameters[3].Value = this._HEP_USUARIO;

                cmd.Parameters.Add("@HEP_ESTOQUE_ANTERIOR", SqlDbType.Float);
                cmd.Parameters[4].Value = this._HEP_ESTOQUE_ANTERIOR;
                cmd.Parameters.Add("@HEP_ESTOQUE_ATUAL", SqlDbType.Float);
                cmd.Parameters[5].Value = this._HEP_ESTOQUE_ATUAL;
                cmd.Parameters.Add("@HEP_QTDE", SqlDbType.Float);
                cmd.Parameters[6].Value = this._HEP_QTDE;
                cmd.Parameters.Add("@HEP_PRECO_UNITARIO", SqlDbType.Float);
                cmd.Parameters[7].Value = this._HEP_PRECO_UNITARIO;
                cmd.Parameters.Add("@HEP_PRECO_TOTAL", SqlDbType.Float);
                cmd.Parameters[8].Value = this._HEP_PRECO_TOTAL;

                cmd.Parameters.Add("@HEP_DATA", SqlDbType.DateTime);
                cmd.Parameters[9].Value = this._HEP_DATA;
                                           
                this.con.Open();                                                                                 
                if (cmd.ExecuteNonQuery() > 0)                                                                     
                {
                    this._HEP_CODIGO = int.Parse(cmd.Parameters[0].Value.ToString());                            
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
}
