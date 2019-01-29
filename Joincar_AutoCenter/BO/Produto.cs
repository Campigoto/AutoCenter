using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BO
{
    public class Produto
    {
        #region Fields
        private int      _PRO_CODIGO = 0;
        private GrupoProduto _PRO_GRUPO;                                                                                                       
        private int      _PRO_INATIVO;                                                           
        private int      _PRO_ULT_COMPRA;                                                       
        private string   _PRO_NOME;                                                         
        private string   _PRO_REFERENCIA;
        private string   _PRO_UNIDADE;                                                                                                                     
        private string   _PRO_OBS;      
        private float    _PRO_PRECO_COMPRA;                                                            
        private float    _PRO_ESTOQUE;
        private float    _PRO_EST_MINIMO;
        private SubGrupo_Produtos _PRO_SUBGRUPO;

        private DateTime _COM_DATA = DateTime.Parse("01/01/1800");
        //Usado meramente para atualizar o estoque
        private float _PRO_EST_ATUAL = 0;
        private StringBuilder _sb;                                                                                         
        private SqlConnection con = new SqlConnection(Connection.ConnectionString);
        private SqlCommand cmd;
        private ProdutoLoadType _typeLoad;                                                                                         
        #endregion                                                                                                         
                                                                                                                           
        #region Properties
        public int PRO_CODIGO
        {                                                                                                                  
            get { return _PRO_CODIGO; }                                                                                    
            set { _PRO_CODIGO = value; }                                                                                     
        }                                                                                                    
                                                             
        public int PRO_INATIVO
        {                                                                          
            get { return _PRO_INATIVO; }                                           
            set { _PRO_INATIVO = value; }                                              
        }                                                                              

        public int PRO_ULT_COMPRA
        {                                                                              
            get { return _PRO_ULT_COMPRA; }                                                
            set { _PRO_ULT_COMPRA = value; }                                               
        }                                                                                 
                                                                          
        public string PRO_REFERENCIA
        {                                                                                 
            get { return _PRO_REFERENCIA; }                                                      
            set { _PRO_REFERENCIA = value; }                                                     
        }                                                                                 
                                                                
        public string PRO_NOME
        {                                                                                          
            get { return _PRO_NOME; }                                                                
            set { _PRO_NOME = value; }                                                                    
        }                                                                                                
                                                                                                         
        public string PRO_UNIDADE
        {                                                                                                
            get { return _PRO_UNIDADE; }                                                                
            set 
            {
                if (value.Length > 6)
                {
                    _PRO_UNIDADE = value.Substring(0, 6); 
                }
                else
                {
                    _PRO_UNIDADE = value; 
                }
            }                                                               
        }                                                                                                
                                                                                           
        public float PRO_PRECO_COMPRA
        {                                                                                                
            get { return _PRO_PRECO_COMPRA; }                                                                  
            set { _PRO_PRECO_COMPRA = value; }                                                                 
        }

        public string PRO_PRECO_COMPRA_FORMATADO
        {
            get { return _PRO_PRECO_COMPRA.ToString("0.000"); }
        }

        public float PRO_ESTOQUE
        {                                                                            
            get { return _PRO_ESTOQUE; }                                          
            set { _PRO_ESTOQUE = value; }                                                             
        }

        public string PRO_ESTOQUE_FORMATADO
        {
            get { return _PRO_ESTOQUE.ToString("0.000"); }
        }

        public string PRO_EST_ATUAL
        {
            get { return _PRO_EST_ATUAL.ToString("0.000"); }
            set { _PRO_EST_ATUAL = float.Parse(value); }
        }
                                                                       
        public float PRO_EST_MINIMO
        {                                                                                       
            get { return _PRO_EST_MINIMO; }                                                        
            set { _PRO_EST_MINIMO = value; }                                                                                 
        }                                                                                       
                                                                                                              
        public string PRO_OBS
        {                                                                                                                     
            get { return _PRO_OBS; }                                                                                          
            set { _PRO_OBS = value; }                                                                                         
        }

        public SubGrupo_Produtos PRO_SUBGRUPO
        {
            get { return _PRO_SUBGRUPO; }
            set { _PRO_SUBGRUPO = value;}
        }

        public int PRO_SUBGRUPO_SGP_CODIGO
            {
                get { return _PRO_SUBGRUPO.SGP_CODIGO; }
            }

        public int PRO_SUBGRUPO_SGP_ID
            {
                get { return _PRO_SUBGRUPO.SGP_ID; }
            }

        public string PRO_SUBGRUPO_SGP_NOME
            {
                get { return _PRO_SUBGRUPO.SGP_NOME; }
            }

        public GrupoProduto PRO_GRUPO
        {
            get { return _PRO_GRUPO; }
            set { _PRO_GRUPO = value; }
        }

        public int PRO_GRUPO_GRP_CODIGO
        {
            get { return _PRO_GRUPO.GRP_CODIGO; }
        }
       
        public string PRO_GRUPO_GRP_NOME
        {
            get { return _PRO_GRUPO.GRP_NOME; }
        }

        public string COM_DATA_FORMATADA
        {
            get 
            {
                if (_COM_DATA.ToString("dd/MM/yyyy") != "01/01/1800")
                {
                    return _COM_DATA.ToString("dd/MM/yyyy");
                }
                else
                {
                    return "";
                }
            }
        }                                                                                                            
        #endregion                                                                                      
                                                                                                             
        #region Constructors
        public Produto() { }                                                                                 
                                                                                                             
        public Produto(int PRO_CODIGO)                                                                                  
        {
            this._PRO_CODIGO = PRO_CODIGO;
            this._typeLoad = ProdutoLoadType.LoadById;  
            this.Load();                                                                                 
        }

        public Produto(string PRO_NOME)
        {
          this._PRO_NOME = PRO_NOME;
        }

        public Produto(int PRO_CODIGO,
            int    PRO_GRUPO,
            int    PRO_INATIVO,
            int    PRO_ULT_COMPRA,
            string PRO_NOME,
            string PRO_REFERENCIA,
            string PRO_UNIDADE,
            string PRO_OBS,
            float  PRO_PRECO_COMPRA,
            float  PRO_ESTOQUE,
            float  PRO_EST_MINIMO,
            int    PRO_SUBGRUPO,
            DateTime COM_DATA)
        {
            this._PRO_CODIGO      = PRO_CODIGO;
            this._PRO_GRUPO       = new GrupoProduto(PRO_GRUPO);
            this._PRO_INATIVO     = PRO_INATIVO;
            this._PRO_ULT_COMPRA  = PRO_ULT_COMPRA;
            this._PRO_NOME        = PRO_NOME;
            this._PRO_REFERENCIA  = PRO_REFERENCIA;
            this._PRO_UNIDADE     = PRO_UNIDADE;
            this._PRO_OBS         = PRO_OBS;
            this._PRO_PRECO_COMPRA= PRO_PRECO_COMPRA;
            this._PRO_ESTOQUE     = PRO_ESTOQUE;
            this._PRO_EST_ATUAL   = PRO_ESTOQUE;
            this._PRO_EST_MINIMO  = PRO_EST_MINIMO;
            this._PRO_SUBGRUPO = new SubGrupo_Produtos(PRO_SUBGRUPO, PRO_GRUPO);
            this._COM_DATA = COM_DATA;
        }
        
        #endregion                                                                                                                       
                                                                                                                                         
        #region Methods
        public static bool Verificar_Produto(int PRO_CODIGO)                                                                             
        {                                                                                                                                
            SqlConnection static_conn = new SqlConnection(Connection.ConnectionString);                                                  
            SqlCommand static_cmd;                                                                                                       
            StringBuilder sb = new StringBuilder();                                                                                      
                                                                                                                                         
         try                                                                                                                             
            {
                sb.Append("SELECT PRO_CODIGO, PRO_GRUPO,PRO_INATIVO,PRO_ULT_COMPRA,PRO_NOME,PRO_REFERENCIA,PRO_UNIDADE,PRO_OBS,PRO_PRECO_COMPRA ,PRO_ESTOQUE,PRO_EST_MINIMO,PRO_SUBGRUPO FROM Produto ");
                sb.Append("WHERE (PRO_CODIGO = @PRO_CODIGO) ");                                                                    
                static_cmd = new SqlCommand(sb.ToString(), static_conn);                                                                                         
                static_cmd.CommandType = CommandType.Text;                                                                                                       
                static_cmd.Parameters.Add("@PRO_CODIGO", SqlDbType.Int);                                                                                         
                static_cmd.Parameters[0].Value = PRO_CODIGO;                                                                                                     
                                                                                                                                                                 
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
                if (this.PRO_CODIGO == 0)
                {
                    this._sb.Append("INSERT INTO Produto ( PRO_GRUPO, PRO_INATIVO, PRO_ULT_COMPRA, PRO_NOME, PRO_REFERENCIA, PRO_UNIDADE, PRO_OBS, PRO_PRECO_COMPRA ,PRO_ESTOQUE, PRO_EST_MINIMO,PRO_SUBGRUPO) ");
                    this._sb.Append("VALUES ( @PRO_GRUPO,@PRO_INATIVO,@PRO_ULT_COMPRA,@PRO_NOME,@PRO_REFERENCIA,@PRO_UNIDADE,@PRO_OBS,@PRO_PRECO_COMPRA,@PRO_ESTOQUE,@PRO_EST_MINIMO,@PRO_SUBGRUPO ) ");
                    this._sb.Append("SET @PRO_CODIGO = @@IDENTITY ");
                }
                else
                {

                    this._sb.Append("UPDATE Produto SET PRO_GRUPO=@PRO_GRUPO, PRO_INATIVO=@PRO_INATIVO, PRO_ULT_COMPRA=@PRO_ULT_COMPRA, PRO_NOME=@PRO_NOME, PRO_REFERENCIA=@PRO_REFERENCIA, PRO_UNIDADE=@PRO_UNIDADE, PRO_OBS=@PRO_OBS, PRO_PRECO_COMPRA=@PRO_PRECO_COMPRA ,PRO_ESTOQUE=@PRO_ESTOQUE, PRO_EST_MINIMO=@PRO_EST_MINIMO,PRO_SUBGRUPO=@PRO_SUBGRUPO ");
                    this._sb.Append("WHERE PRO_CODIGO=@PRO_CODIGO");
                }
                    
                this.cmd = new SqlCommand(this._sb.ToString(), this.con);
                this.cmd.CommandType = CommandType.Text;                                      
                this.cmd.Parameters.Add("@PRO_CODIGO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = PRO_CODIGO;
                this.cmd.Parameters[0].Direction = ParameterDirection.InputOutput;                                         
                this.cmd.Parameters.Add("@PRO_GRUPO", SqlDbType.Int);
                this.cmd.Parameters[1].Value = PRO_GRUPO.GRP_CODIGO;                                             
                this.cmd.Parameters.Add("@PRO_INATIVO", SqlDbType.Int);                               
                this.cmd.Parameters[2].Value = PRO_INATIVO;                                           
                this.cmd.Parameters.Add("@PRO_ULT_COMPRA", SqlDbType.Int);                                
                this.cmd.Parameters[3].Value = PRO_ULT_COMPRA;
                this.cmd.Parameters.Add("@PRO_NOME", SqlDbType.VarChar);
                this.cmd.Parameters[4].Value = PRO_NOME;
                this.cmd.Parameters.Add("@PRO_REFERENCIA", SqlDbType.VarChar);
                this.cmd.Parameters[5].Value = PRO_REFERENCIA;                
                this.cmd.Parameters.Add("@PRO_UNIDADE", SqlDbType.VarChar);   
                this.cmd.Parameters[6].Value = PRO_UNIDADE;                   
                this.cmd.Parameters.Add("@PRO_OBS", SqlDbType.Text);          
                this.cmd.Parameters[7].Value = PRO_OBS;                       
                this.cmd.Parameters.Add("@PRO_PRECO_COMPRA", SqlDbType.Float);
                this.cmd.Parameters[8].Value = PRO_PRECO_COMPRA;              
                this.cmd.Parameters.Add("@PRO_ESTOQUE", SqlDbType.Float);     
                this.cmd.Parameters[9].Value = PRO_ESTOQUE;                   
                this.cmd.Parameters.Add("@PRO_EST_MINIMO", SqlDbType.Float);  
                this.cmd.Parameters[10].Value = PRO_EST_MINIMO;               
                this.cmd.Parameters.Add("@PRO_SUBGRUPO", SqlDbType.Int);      
                this.cmd.Parameters[11].Value = PRO_SUBGRUPO.SGP_CODIGO;
                                                                              
                this.con.Open();                                                  
                if (cmd.ExecuteNonQuery() > 0)
                {
                    this._PRO_CODIGO = int.Parse(cmd.Parameters[0].Value.ToString());
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

        public void Deletar(int PRO_CODIGO)
        {
            try
            {
                this.cmd = new SqlCommand("DELETE FROM Produto WHERE PRO_CODIGO = @PRO_CODIGO", this.con);
                this.cmd.CommandType = CommandType.Text;

                this.cmd.Parameters.Add("@PRO_CODIGO", SqlDbType.Int);
                this.cmd.Parameters[0].Value = PRO_CODIGO;

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

                    case ProdutoLoadType.LoadById:
                        this.cmd = new SqlCommand("SELECT PRO_CODIGO, PRO_GRUPO,PRO_INATIVO,PRO_ULT_COMPRA,PRO_NOME,PRO_REFERENCIA,PRO_UNIDADE,PRO_OBS,PRO_PRECO_COMPRA ,PRO_ESTOQUE,PRO_EST_MINIMO,PRO_SUBGRUPO FROM Produto WHERE PRO_CODIGO = @PRO_CODIGO", this.con);
                        this.cmd.CommandType = CommandType.Text;
                        this.cmd.Parameters.Add("@PRO_CODIGO", SqlDbType.Int);
                        this.cmd.Parameters[0].Value = this._PRO_CODIGO;
                        break;

                }

                this.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                  this._PRO_CODIGO        = dr.GetSqlInt32(0).Value;
                  try
                  {
                      this._PRO_GRUPO = new GrupoProduto(dr.GetSqlInt32(1).Value);
                  }
                  catch (Exception)
                  {
                      this._PRO_GRUPO = new GrupoProduto();
                  }
                  this._PRO_INATIVO       = dr.GetSqlInt32(2).Value;                     
                  this._PRO_ULT_COMPRA    = dr.GetSqlInt32(3).Value;                     
                  this._PRO_NOME          = dr.GetSqlString(4).Value;                    
                  this._PRO_REFERENCIA    = dr.GetSqlString(5).Value;                    
                  this._PRO_UNIDADE       = dr.GetSqlString(6).Value;                    
                  this._PRO_OBS           = dr.GetSqlString(7).Value;                    
                  this._PRO_PRECO_COMPRA  = float.Parse(dr.GetSqlDouble(8).ToString());  
                  this._PRO_ESTOQUE       = float.Parse(dr.GetSqlDouble(9).ToString());
                  this._PRO_EST_ATUAL     = float.Parse(dr.GetSqlDouble(9).ToString());  
                  this._PRO_EST_MINIMO    = float.Parse(dr.GetSqlDouble(10).ToString());
                  try
                  {
                      this._PRO_SUBGRUPO = new SubGrupo_Produtos(dr.GetSqlInt32(11).Value, dr.GetSqlInt32(1).Value);
                  }
                  catch (Exception)
                  {
                      this._PRO_SUBGRUPO = new SubGrupo_Produtos();
                  }
                }
                else
                    this._PRO_CODIGO = 0;
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
