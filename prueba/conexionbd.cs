using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DB_MAPR
{
    internal class conexionbd
    {
        string cadena = "Data Source=DESKTOP-S8V6F3S\\SQLEXPRESS;Initial Catalog=DB_MAPR;Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();
        public conexionbd()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eror de Conexion" + ex.Message);
            }
        }

        public void cerrar()
        {
            conectarbd.Close();
        }
    }
}


