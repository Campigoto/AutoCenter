using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BO
{
   public class Produtos_Compra
   {
        #region Fields
       private int _PC_COMPRA = 0;
       private int _PC_ITEM = 0;
       private int _PC_PRODUTO;
       private string _PC_UNIDADE;
       private float _PC_QTDE;
       private float _PC_PRECO_COMPRA;
       private float _PC_TOTAL;

       private string _PRO_NOME = "";
       private StringBuilder _CONSULTA;
        private SqlCommand cmd;
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        #endregion

        #region Properties
       public int PC_COMPRA
        {
            get { return _PC_COMPRA; }
            set { _PC_COMPRA = value; }                                        
        }
       public int PC_ITEM
       {
           get { return _PC_ITEM; }
           set { _PC_ITEM = value; }
       }
       public int PC_PRODUTO
       {
           get { return _PC_PRODUTO; }
           set { _PC_PRODUTO = value; }
       }
       public int PC_PRODUTO_FORMATADO
       {
           get { return _PC_PRODUTO; }
       }
       public string PC_UNIDADE
       {
           get { return _PC_UNIDADE; }
           set { _PC_UNIDADE = value; }
       }
       public string PC_UNIDADE_FORMATADO
       {
           get { return _PC_UNIDADE; }
       }
       public float PC_QTDE
       {
           get { return _PC_QTDE; }
           set { _PC_QTDE = value; }
       }
       public string PC_QTDE_FORMATADO
       {
           get 
           { 
               return _PC_QTDE.ToString("0.00"); 
           }
           set { _PC_QTDE = float.Parse(value); }
       }
       public float PC_PRECO_COMPRA
       {
           get { return _PC_PRECO_COMPRA; }
           set { _PC_PRECO_COMPRA = value; }
       }
       public string PC_PRECO_COMPRA_FORMATADO
       {
           get
           {
               return _PC_PRECO_COMPRA.ToString("0.00");
           }
           set { _PC_PRECO_COMPRA = float.Parse(value); }
       }
       public float PC_TOTAL
       {
           get
           {
               return _PC_QTDE * _PC_PRECO_COMPRA;
           }
           set { _PC_TOTAL = value; }
       }
       public string PC_TOTAL_FORMATADO
       {
           get
           {
               return PC_TOTAL.ToString("0.00");
           }
       }

       public string PRO_NOME
       {
           get { return _PRO_NOME; }
           set { _PRO_NOME = value; }
       }

       public string PRO_NOME_FORMATADO
       {
           get { return _PRO_NOME; }
       }
        #endregion                                                                                        
                                                                                                   
        #region Constructors
        public Produtos_Compra() { }

       public Produtos_Compra(int PC_COMPRA, int PC_ITEM, int PC_PRODUTO, string PC_UNIDADE, 
           float PC_QTDE, float PC_PRECO_COMPRA, float PC_TOTAL, string PRO_NOME)
        {
            this._PC_COMPRA = PC_COMPRA;
            this._PC_ITEM = PC_ITEM;
            this._PC_PRODUTO = PC_PRODUTO;
            this._PC_UNIDADE = PC_UNIDADE;
            this._PC_QTDE = PC_QTDE;
            this._PC_PRECO_COMPRA = PC_PRECO_COMPRA;
            this._PC_TOTAL = PC_TOTAL;
            this._PRO_NOME = PRO_NOME;
        }                                                                      
        #endregion

        #region Methods
        public void Salvar()
        {
            try
            {
                this._CONSULTA = new StringBuilder();
                this._CONSULTA.Append("INSERT INTO Produtos_Compra ( PC_COMPRA, PC_ITEM, PC_PRODUTO, PC_UNIDADE, PC_QTDE, ");
                this._CONSULTA.Append("PC_PRECO_COMPRA, PC_TOTAL ) ");
                this._CONSULTA.Append("VALUES ( @PC_COMPRA, @PC_ITEM, @PC_PRODUTO, @PC_UNIDADE, @PC_QTDE, ");
                this._CONSULTA.Append("@PC_PRECO_COMPRA, @PC_TOTAL ) ");
                SqlCommand cmd = new SqlCommand(this._CONSULTA.ToString(), this.con);                                   
                                                                                                          
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@PC_COMPRA", SqlDbType.Int);
                cmd.Parameters[0].Value = this._PC_COMPRA;
                cmd.Parameters[0].Direction = ParameterDirection.InputOutput;
                cmd.Parameters.Add("@PC_ITEM", SqlDbType.Int);
                cmd.Parameters[1].Value = this._PC_ITEM;
                cmd.Parameters.Add("@PC_PRODUTO", SqlDbType.Int);
                cmd.Parameters[2].Value = this._PC_PRODUTO;
                cmd.Parameters.Add("@PC_UNIDADE", SqlDbType.VarChar);
                cmd.Parameters[3].Value = this._PC_UNIDADE;
                cmd.Parameters.Add("@PC_QTDE", SqlDbType.Float);
                cmd.Parameters[4].Value = this._PC_QTDE;
                cmd.Parameters.Add("@PC_PRECO_COMPRA", SqlDbType.Float);
                cmd.Parameters[5].Value = this._PC_PRECO_COMPRA;
                cmd.Parameters.Add("@PC_TOTAL", SqlDbType.Float);
                cmd.Parameters[6].Value = this._PC_TOTAL;
    
                this.con.Open();
                cmd.ExecuteNonQuery();                                                                                            
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
