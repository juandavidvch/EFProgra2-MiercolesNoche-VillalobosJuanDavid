using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace EFProgra2
{
    public class Modelo
    {
        string conexion = "Data Source=localhost;Initial Catalog=bd_colegio;Integrated Security=True";
        SqlConnection sqlconn;

        public void conectar()
        {
            sqlconn = new SqlConnection(conexion);
            try
            {
                sqlconn.Open();
            }
            catch(Exception e)
            {
                var message = MessageBox.Show("Conexion fallida! Error: " + e.Message.ToString());
            }
        }
        public void desconectar()
        {
            sqlconn.Close();
        }

        public void ejecutar(string sql)
        {
            SqlCommand sqlcomm = new SqlCommand();
            conectar();
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = sql;
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.ExecuteNonQuery();
            desconectar();
        }

        public DataTable llenar(string sql)
        {
            conectar();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            desconectar();
            return dt;
        }
    }
    
}
