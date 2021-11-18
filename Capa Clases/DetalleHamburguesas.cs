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
    public class DetalleHamburguesa
    {
        private int id;
        private string nombre;
        private int cantidad;

        [Browsable(false)]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public DetalleHamburguesa(int auxID, string auxNombre,int auxCantidad)
        {
            ID = auxID;
            Nombre = auxNombre;
            Cantidad = auxCantidad;
        }

        public static void creartabla()
        {
            MySQL.ExecuteNonQuery(
                "create table if not exists `tabla_PartesHamburguesas` (" +
                "id int auto_increment," +
                "primary key (id)," +
                "nombre varchar(50))",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "insert ignore into tabla_PartesHamburguesas (" +
                "id," +
                "nombre" +
                ")values(" +
                1 + "," +
                "'pan')",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "insert ignore into tabla_PartesHamburguesas (" +
                "id," +
                "nombre" +
                ")values(" +
                2 + "," +
                "'paty de carne')",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "insert ignore into tabla_PartesHamburguesas (" +
                "id," +
                "nombre" +
                ")values(" +
                3 + "," +
                "'paty de pollo')",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "insert ignore into tabla_PartesHamburguesas (" +
                "id," +
                "nombre" +
                ")values(" +
                4 + "," +
                "'queso')",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "insert ignore into tabla_PartesHamburguesas (" +
                "id," +
                "nombre" +
                ")values(" +
                5 + "," +
                "'lechuga')",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "insert ignore into tabla_PartesHamburguesas (" +
                "id," +
                "nombre" +
                ")values(" +
                6 + "," +
                "'tomate')",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "insert ignore into tabla_PartesHamburguesas (" +
                "id," +
                "nombre" +
                ")values(" +
                7 + "," +
                "'cebolla')",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "insert ignore into tabla_PartesHamburguesas (" +
                "id," +
                "nombre" +
                ")values(" +
                8 + "," +
                "'pepino')",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                    "create table if not exists `tabla_DetalleHamburguesa` (" +
                    "id int auto_increment," +
                    "primary key (id)," +
                    "id_hamburguesa int," +
                    "id_partes int," +
                    "INDEX (id_hamburguesa)," +
                    "FOREIGN KEY (id_hamburguesa) " +
                    "REFERENCES tabla_Articulos(id) " +
                    "ON DELETE CASCADE," +
                    "INDEX (id_partes)," +
                    "FOREIGN KEY (id_partes) " +
                    "REFERENCES tabla_PartesHamburguesas(id) " +
                    "ON DELETE CASCADE," +
                    "cantidad int);",
                    BaseDeDatos.Nombre
                    );
        }

        public static void añadir(int auxID_Hamburguesa, int cantidad_pan, int cantidad_patycarne, int cantidad_patypollo, int cantidad_queso, int cantidad_lechuga, int cantidad_tomate, int cantidad_cebolla, int cantidad_pepino)
        {
            MySQL.ExecuteNonQuery(
                "insert into tabla_DetalleHamburguesa (" +
                "id_hamburguesa," +
                "id_partes," +
                "cantidad" +
                ")values(" +
                auxID_Hamburguesa + "," +
                1 + "," +
                cantidad_pan + ")",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "insert into tabla_DetalleHamburguesa (" +
                "id_hamburguesa," +
                "id_partes," +
                "cantidad" +
                ")values(" +
                auxID_Hamburguesa + "," +
                2 + "," +
                cantidad_patycarne + ")",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "insert into tabla_DetalleHamburguesa (" +
                "id_hamburguesa," +
                "id_partes," +
                "cantidad" +
                ")values(" +
                auxID_Hamburguesa + "," +
                3 + "," +
                cantidad_patypollo + ")",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "insert into tabla_DetalleHamburguesa (" +
                "id_hamburguesa," +
                "id_partes," +
                "cantidad" +
                ")values(" +
                auxID_Hamburguesa + "," +
                4 + "," +
                cantidad_queso + ")",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "insert into tabla_DetalleHamburguesa (" +
                "id_hamburguesa," +
                "id_partes," +
                "cantidad" +
                ")values(" +
                auxID_Hamburguesa + "," +
                5 + "," +
                cantidad_lechuga + ")",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "insert into tabla_DetalleHamburguesa (" +
                "id_hamburguesa," +
                "id_partes," +
                "cantidad" +
                ")values(" +
                auxID_Hamburguesa + "," +
                6 + "," +
                cantidad_tomate + ")",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "insert into tabla_DetalleHamburguesa (" +
                "id_hamburguesa," +
                "id_partes," +
                "cantidad" +
                ")values(" +
                auxID_Hamburguesa + "," +
                7 + "," +
                cantidad_cebolla + ")",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "insert into tabla_DetalleHamburguesa (" +
                "id_hamburguesa," +
                "id_partes," +
                "cantidad" +
                ")values(" +
                auxID_Hamburguesa + "," +
                8 + "," +
                cantidad_pepino + ")",
                BaseDeDatos.Nombre
                );
        }

        public static void editar(int auxID_Hamburguesa, int cantidad_pan, int cantidad_patycarne, int cantidad_patypollo, int cantidad_queso, int cantidad_lechuga, int cantidad_tomate, int cantidad_cebolla, int cantidad_pepino)
        {
            MySQL.ExecuteNonQuery(
                "update tabla_DetalleHamburguesa set " +
                "cantidad = " + cantidad_pan + " " +
                "where id_hamburguesa = " + auxID_Hamburguesa + " " +
                "and id_partes = 1",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "update tabla_DetalleHamburguesa set " +
                "cantidad = " + cantidad_patycarne + " " +
                "where id_hamburguesa = " + auxID_Hamburguesa + " " +
                "and id_partes = 2",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "update tabla_DetalleHamburguesa set " +
                "cantidad = " + cantidad_patypollo + " " +
                "where id_hamburguesa = " + auxID_Hamburguesa + " " +
                "and id_partes = 3",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "update tabla_DetalleHamburguesa set " +
                "cantidad = " + cantidad_queso + " " +
                "where id_hamburguesa = " + auxID_Hamburguesa + " " +
                "and id_partes = 4",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "update tabla_DetalleHamburguesa set " +
                "cantidad = " + cantidad_lechuga + " " +
                "where id_hamburguesa = " + auxID_Hamburguesa + " " +
                "and id_partes = 5",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "update tabla_DetalleHamburguesa set " +
                "cantidad = " + cantidad_tomate + " " +
                "where id_hamburguesa = " + auxID_Hamburguesa + " " +
                "and id_partes = 6",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "update tabla_DetalleHamburguesa set " +
                "cantidad = " + cantidad_cebolla + " " +
                "where id_hamburguesa = " + auxID_Hamburguesa + " " +
                "and id_partes = 7",
                BaseDeDatos.Nombre
                );
            MySQL.ExecuteNonQuery(
                "update tabla_DetalleHamburguesa set " +
                "cantidad = " + cantidad_pepino + " " +
                "where id_hamburguesa = " + auxID_Hamburguesa + " " +
                "and id_partes = 8",
                BaseDeDatos.Nombre
                );
        }

        public static List<DetalleHamburguesa> tabla(int auxID_Hamburguesa)
        {
            string consulta = "select ";
            consulta += "tabla_DetalleHamburguesa.id,";
            consulta += "tabla_PartesHamburguesas.nombre,";
            consulta += "tabla_DetalleHamburguesa.cantidad ";
            consulta += "from tabla_DetalleHamburguesa ";
            consulta += "left join tabla_PartesHamburguesas ";
            consulta += "on tabla_PartesHamburguesas.id = tabla_DetalleHamburguesa.id_partes ";
            consulta += "where tabla_DetalleHamburguesa.cantidad != 0 ";
            consulta += "and tabla_DetalleHamburguesa.id_hamburguesa = " + auxID_Hamburguesa;

            MySqlDataReader datos = MySQL.ExecuteReader(consulta, BaseDeDatos.Nombre);
            List<DetalleHamburguesa> lista = new List<DetalleHamburguesa>();
            while (datos.Read())
            {
                lista.Add(new DetalleHamburguesa(
                    Convert.ToInt32(datos["id"]),
                    datos["nombre"].ToString(),
                    Convert.ToInt32(datos["cantidad"])
                    ));
            }
            return lista;
        }
    }
}
