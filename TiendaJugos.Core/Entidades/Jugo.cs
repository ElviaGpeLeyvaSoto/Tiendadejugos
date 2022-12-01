using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaJugos.Core.Entidades
{
    public class Jugo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public static List<Jugo> GetAll()
        {
            List<Jugo> jugos = new List<Jugo>();
            try
            {
                Conexion conexion = new Conexion();
                if (conexion.OpenConnection())
                {
                    string query = "SELECT id, nombre, descripcion, precio, cantidad FROM jugo;";

                    MySqlCommand command = new MySqlCommand(query, conexion.connection);

                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Jugo jugo = new Jugo();
                        jugo.Id = int.Parse(dataReader["id"].ToString());
                        jugo.Nombre = dataReader["nombre"].ToString();
                        jugo.Descripcion = dataReader["descripcion"].ToString();
                        jugo.Precio = double.Parse(dataReader["precio"].ToString());
                        jugo.Cantidad = int.Parse(dataReader["cantidad"].ToString());

                        jugos.Add(jugo);
                    }
                    dataReader.Close();
                    conexion.CloseConnection();
                }

            } catch (Exception ex) {


                throw ex;
            }
            return jugos;
        }
        public static Jugo GetById(int id)
        {
            Jugo jugo = new Jugo();
            try
            {
                Conexion conexion = new Conexion();
                if (conexion.OpenConnection())
                {
                    string query = "SELECT id, nombre, descripcion, precio, cantidad FROM jugo WHERE id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conexion.connection);
                    cmd.Parameters.AddWithValue("@id", id);

                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        jugo.Id = int.Parse(dataReader["id"].ToString());
                        jugo.Nombre = dataReader["nombre"].ToString();
                        jugo.Descripcion = dataReader["descripcion"].ToString();
                        jugo.Precio = double.Parse(dataReader["precio"].ToString());
                        jugo.Cantidad = int.Parse(dataReader["cantidad"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return jugo;
        }

    }
}
