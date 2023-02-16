using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DB_MAPR
{
    class Conexion
    {
        private SqlConnection connection;

        // Cadena de conexión a la base de datos
        private string connectionString = "Data Source=172.30.240.56;Initial Catalog=DB_MAPR;Integrated Security=True";

        // Constructor de la clase, inicializa la conexión a la base de datos
        public Conexion()
        {
            connection = new SqlConnection(connectionString);
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