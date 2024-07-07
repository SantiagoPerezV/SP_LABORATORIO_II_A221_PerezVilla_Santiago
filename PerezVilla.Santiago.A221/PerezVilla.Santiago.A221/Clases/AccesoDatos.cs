using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Clases
{
    public static class AccesoDatos
    {
        static MySqlCommand command;
        static MySqlConnection connection;
        static string connectionString = "Server=localhost; Database=sp_labo; User ID=root; Password=;SslMode=none;";

        static AccesoDatos()
        {
        }

        public static bool Guardar(Barco barco)
        {
            bool retorno = false;

            using (connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO parcial (nombre, mensaje)" +
                    "VALUES(@nombre, @mensaje)";
                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", barco.Nombre);
                command.Parameters.AddWithValue("@mensaje", $"Se reparó el {barco.Nombre} a un costo de {barco.Costo} berries");

                retorno = true;

                command.ExecuteNonQuery();
            }
            return retorno;

        }

    }
}
