using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TiendaJugos.Core.Entidades
{
    
    public class Conexion
    {
        public MySqlConnection connection;

        public Conexion() { 
        
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new MySqlConnection(connectionString);
        }
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
    }

}
