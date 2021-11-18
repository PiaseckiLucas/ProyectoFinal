using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;
//using MySql.Data.MySqlClient;

namespace Capa_Datos
{
    public class MySQL
    {
        private static string conexion = "Server=localhost; User=root;port=3307; SslMode = none;";

        public static void ExecuteNonQuery(string commandText)
        {
            MySqlConnection conn = new MySqlConnection(conexion);
            MySqlCommand cmd = new MySqlCommand(commandText, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void ExecuteNonQuery(string commandText, string dataBase)
        {
            MySqlConnection conn = new MySqlConnection(conexion + "database = " + dataBase);
            MySqlCommand cmd = new MySqlCommand(commandText, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static object ExecuteScalar(string commandText)
        {
            MySqlConnection conn = new MySqlConnection(conexion);
            MySqlCommand cmd = new MySqlCommand(commandText, conn);
            conn.Open();
            object scalar = cmd.ExecuteScalar();
            conn.Close();
            return scalar;
        }

        public static object ExecuteScalar(string commandText, string dataBase)
        {
            MySqlConnection conn = new MySqlConnection(conexion + "database = " + dataBase);
            MySqlCommand cmd = new MySqlCommand(commandText, conn);
            conn.Open();
            object scalar = cmd.ExecuteScalar();
            conn.Close();
            return scalar;
        }

        public static MySqlDataReader ExecuteReader(string commandText)
        {
            MySqlConnection conn = new MySqlConnection(conexion);
            using (MySqlCommand cmd = new MySqlCommand(commandText, conn))
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
        }

        public static MySqlDataReader ExecuteReader(string commandText, string dataBase)
        {
            MySqlConnection conn = new MySqlConnection(conexion + "database = " + dataBase);
            using (MySqlCommand cmd = new MySqlCommand(commandText, conn))
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
        }
    }
}