using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Clases
{
    public class CrudBarco
    {
        public CrudBarco()
        {
            
        }

        private MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection("Server=localhost; Database=sp_labo; User ID=root; Password=;SslMode=none;");
        }

        public List<Barco> SeleccionarBarcos()
        {
            List<Barco> listaBarco = new List<Barco>();

            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = $"SELECT * FROM Barcos";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nombre = reader.GetString("nombre");
                    string tipo = reader.GetString("tipo");
                    int costo = reader.GetInt32("costo");
                    bool estadoReparado = reader.GetBoolean("estadoReparado");
                    string operacion = reader.GetString("operacion");
                    int tripulacion = reader.GetInt32("tripulacion");

                    Enum.TryParse(tipo, out ETipoBarco tipoBarco);
                    Enum.TryParse(operacion, out EOperacion operacionBarco);

                    Barco barco;

                    if (tipoBarco == ETipoBarco.Marina)
                    {
                        barco = new Marina(estadoReparado, nombre, operacionBarco, tripulacion);
                        barco.Costo = costo;
                    }
                    else
                    {
                        barco = new Pirata(estadoReparado, nombre, operacionBarco, tripulacion);
                        barco.Costo = costo;
                    }
                    listaBarco.Add(barco);
                }
            }
            return listaBarco;
        }

        public void InsertarBarco(Barco barco)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "INSERT INTO Barcos (nombre, tipo, costo, estadoReparado, operacion, tripulacion)" +
                    "VALUES(@nombre, @tipo, @costo, @estadoReparado, @operacion, @tripulacion)";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@nombre", barco.Nombre);
                if(barco is Marina)
                {
                    comando.Parameters.AddWithValue("@tipo", "Marina");
                }
                else
                {
                    comando.Parameters.AddWithValue("@tipo", "Pirata");
                }
                comando.Parameters.AddWithValue("@costo", barco.Costo);
                comando.Parameters.AddWithValue("@estadoReparado", barco.EstadoReparado);
                comando.Parameters.AddWithValue("@operacion", barco.Operacion);
                comando.Parameters.AddWithValue("@tripulacion", barco.Tripulacion);


                comando.ExecuteNonQuery();
            }
        }

        public void ModificarBarco(Barco barco)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "UPDATE Barcos SET tipo=@tipo, costo=@costo, estadoReparado=@estadoReparado, operacion=@operacion, tripulacion=@tripulacion WHERE nombre=@nombre";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@nombre", barco.Nombre);
                if (barco is Marina)
                {
                    comando.Parameters.AddWithValue("@tipo", "Marina");
                }
                else
                {
                    comando.Parameters.AddWithValue("@tipo", "Pirata");
                }
                comando.Parameters.AddWithValue("@costo", barco.Costo);
                comando.Parameters.AddWithValue("@estadoReparado", barco.EstadoReparado);
                comando.Parameters.AddWithValue("@operacion", barco.Operacion);
                comando.Parameters.AddWithValue("@tripulacion", barco.Tripulacion);


                comando.ExecuteNonQuery();
            }
        }

        public void EliminarBarco(string nombre)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "DELETE FROM Barcos WHERE nombre = @nombre";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@nombre", nombre);

                comando.ExecuteNonQuery();
            }
        }
    }
}
