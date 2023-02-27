using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DB_MAPR
{
    class Conexionbd
    {
        string cadena = "Data Source=srv-data2;Initial Catalog=DB_MAPR;Integrated Security=True";
        public SqlConnection conectarbd = new SqlConecction();

        public Conexionbd()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarbd.open();
                Console.WriteLine("Conexion Exitosa")
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo de conexion"ex.Message);
            }
        }

        public void cerrar()
        {
            conectarbd.close();
        }
        }









        // Método para insertar un nuevo registro en la tabla DVR
        public void insertar_dvr(string descripcion)
        {
            SqlCommand command = new SqlCommand("insertar_dvr", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@descripcion", descripcion);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Método para eliminar un registro de la tabla DVR
        public void eliminar_dvr(int codigo)
        {
            SqlCommand command = new SqlCommand("eliminar_dvr", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@codigo_dvr", codigo);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Método para actualizar un registro de la tabla DVR
        public void actualizar_dvr(int codigo, string descripcion)
        {
            SqlCommand command = new SqlCommand("actualizar_dvr", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@codigo_dvr", codigo);
            command.Parameters.AddWithValue("@descripcion", descripcion);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Método para insertar un nuevo registro en la tabla DVR
        public void insertar_dvr(string descripcion)
        {
            SqlCommand command = new SqlCommand("insertar_dvr", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@descripcion", descripcion);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Método para eliminar un registro de la tabla DVR
        public void eliminar_dvr(int codigo)
        {
            SqlCommand command = new SqlCommand("eliminar_dvr", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@codigo_dvr", codigo);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Método para actualizar un registro de la tabla DVR
        public void actualizar_dvr(int codigo, string descripcion)
        {
            SqlCommand command = new SqlCommand("actualizar_dvr", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@codigo_dvr", codigo);
            command.Parameters.AddWithValue("@descripcion", descripcion);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }