using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using MySqlConnector;
//using MySql.Data.MySqlClient;

namespace Capa_Clases
{
    public static class BaseDeDatos
    {
        private static string nombre = "";
        public static string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public static void crear(string nombreBase)
        {
            if (nombre == "")
            {
                MySQL.ExecuteNonQuery("create database if not exists " + nombreBase);
                nombre = nombreBase;
            }
        }
    }
}
