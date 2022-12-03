using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaJugos.Core.Entidades
{
    public class Venta
    {
        public int Id { get; set; }
        public string Folio { get; set; }
        public Jugo Jugo { get; set; }
        public Usuario Usuario { get; set; }
        public double Total { get; set; }

        public static List<Venta> GetAll()
        { 
            List<Venta> ventas = new List<Venta>();
            try
            {
                Conexion conexion = new Conexion();
                if (conexion.OpenConnection())
                {
                    string query = "SELECT id, folio, idjugo, idusuario, total FROM venta;";

                    MySqlCommand command = new MySqlCommand(query, conexion.connection);

                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Venta venta = new Venta();
                        venta.Id = int.Parse(dataReader["id"].ToString());
                        venta.Folio = dataReader["folio"].ToString();
                    }

                }
            }catch(Exception ex)
            {
                throw ex;
            }
            return ventas;
        }

    }
}
