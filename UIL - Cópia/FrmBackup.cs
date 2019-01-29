using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using Microsoft.SqlServer.Management.Smo;
using System.Data.SqlClient;
using BO;
namespace UIL
{
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            label1.Text = @textBox1.Text;

            //string stringConnection = Connection.ConnectionString; //@"Data Source=CAMPIGOTO_NOTE\SQLEXPRESS;Initial Catalog=Joincar;User ID=sa;Pwd=036239"; 
            // SqlConnection cn = new SqlConnection(stringConnection);
            //try
            //{
            //    cn.Open();
            //    SqlCommand cd = new SqlCommand();
            //    cd.CommandText = "BACKUP DATABASE [Joincar] TO DISK = 'F:\\backup.bak' WITH DIFFERENTIAL";
            //    cd.Connection = cn;
            //    cd.ExecuteNonQuery();

                
            //}
            //catch (Exception ex)
            //{
            //    lblMsg.Text = ex.Message;
            //}
            //finally
            //{
            //    cn.Close(); 
            //    lblMsg.Text = "Backup Finalizado.......";
            //}
             
             
             
          



        }
    }
}
