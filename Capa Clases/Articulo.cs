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
    public class Articulo
    {
        private int id;
        private string nombre;
        private string descripcion;
        private int stock;
        private decimal precio;
        private bool es_hamburguesa;

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

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public bool Es_Hamburguesa
        {
            get { return es_hamburguesa; }
            set { es_hamburguesa = value; }
        }

        public Articulo(int auxID, string auxNombre, string auxDescripcion, int auxStock, decimal auxPrecio, bool auxEs_Hamburguesa)
        {
            ID = auxID;
            Nombre = auxNombre;
            Descripcion = auxDescripcion;
            Stock = auxStock;
            Precio = auxPrecio;
            es_hamburguesa = auxEs_Hamburguesa;
        }

        public Articulo(int auxID)
        {
            string consulta = "select * from tabla_Articulos where id = " + auxID;
            MySqlDataReader datos = MySQL.ExecuteReader(consulta, BaseDeDatos.Nombre);
            while (datos.Read())
            {
                ID = auxID;
                Nombre = datos["nombre"].ToString();
                Stock = Convert.ToInt32(datos["stock"]);
                Precio = Convert.ToDecimal(datos["precio"]);
            }
        }

        public static void creartabla()
        {
            MySQL.ExecuteNonQuery(
                    "create table if not exists `tabla_Articulos` (" +
                    "id int auto_increment," +
                    "primary key (id)," +
                    "nombre varchar(50)," +
                    "descripcion tinytext," +
                    "stock int," +
                    "precio decimal(10,2)," +
                    "es_hamburguesa tinyint(1));",
                    BaseDeDatos.Nombre
                    );
        }

        public static void añadir(string auxNombre,string auxDescripcion, int auxStock,decimal auxPrecio, bool auxEs_Hamburguesa)
        {
            MySQL.ExecuteNonQuery(
                "insert into tabla_Articulos (" +
                "nombre," +
                "descripcion," +
                "stock," +
                "precio," +
                "es_hamburguesa" +
                ")values(" +
                "'" + auxNombre + "'," +
                "'" + auxDescripcion + "'," +
                auxStock + "," +
                auxPrecio + "," +
                Convert.ToInt32(auxEs_Hamburguesa) + ")",
                BaseDeDatos.Nombre
                );
        }

        public static void editar(int auxID, string auxNombre, string auxDescripcion, int auxStock, decimal auxPrecio)
        {
            MySQL.ExecuteNonQuery(
                "update tabla_Articulos set " +
                "nombre = '" + auxNombre + "'," +
                "descripcion = '" + auxDescripcion + "'," +
                "stock = " + auxStock + "," +
                "precio = " + auxPrecio + " " +
                "where id = " + auxID,
                BaseDeDatos.Nombre
                );
        }

        public static void borrar(int auxID)
        {
            MySQL.ExecuteNonQuery(
                "delete from tabla_Articulos " +
                "where id = " + auxID,
                BaseDeDatos.Nombre
                );
        }

        public static int ultimaID()
        {
            string consulta = "select max(id) from tabla_Articulos;";
            return Convert.ToInt32(MySQL.ExecuteScalar(consulta, BaseDeDatos.Nombre));
        }

        public static void descontarStock(int auxID, int auxStock)
        {
            MySQL.ExecuteNonQuery(
                "update tabla_Articulos set " +
                "stock = " + auxStock + " " +
                "where id = " + auxID,
                BaseDeDatos.Nombre
                );
        }

        public static List<Articulo> tabla(object[] filtros)
        {
            string consulta = "select * from tabla_Articulos";
            int contador = 0;
            for (int i = 0; i < 4; i++)
            {
                if (filtros[i] != null)
                {
                    if (contador == 0) consulta += " where ";
                    else consulta += " and ";

                    switch (i)
                    {
                        case 0:
                            consulta += "`nombre` LIKE '%" + filtros[i].ToString() + "%'";
                            break;
                        case 1:
                            consulta += "`descripcion` LIKE '%" + filtros[i].ToString() + "%'";
                            break;
                        case 2:
                            consulta += "`stock` = " + filtros[i].ToString();
                            break;
                        case 3:
                            consulta += "`precio` = " + filtros[i].ToString();
                            break;
                        case 4:
                            consulta += "`es_hamburguesa` = " + filtros[i].ToString();
                            break;
                    }

                    contador++;
                }
            }
            MySqlDataReader datos = MySQL.ExecuteReader(consulta,BaseDeDatos.Nombre);
            List<Articulo> lista = new List<Articulo>();
            while (datos.Read())
            {
                lista.Add(new Articulo(
                    Convert.ToInt32(datos["id"]),
                    datos["nombre"].ToString(),
                    datos["descripcion"].ToString(),
                    Convert.ToInt32(datos["stock"]),
                    Convert.ToDecimal(datos["precio"]),
                    Convert.ToBoolean(datos["es_hamburguesa"])
                    ));
            }
            return lista;
        }
    }
}
