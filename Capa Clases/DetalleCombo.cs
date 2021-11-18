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
    public class DetalleCombo
    {
        private int id;
        private int id_combo;
        private int id_articulo;
        private string nombre;
        private string descripcion;
        private int cantidad; 

        [Browsable(false)]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [Browsable(false)]
        public int ID_Combo
        {
            get { return id_combo; }
            set { id_combo = value; }
        }

        [Browsable(false)]
        public int ID_Articulo
        {
            get { return id_articulo; }
            set { id_articulo = value; }
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

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public DetalleCombo(int auxID, int auxID_Combo, int auxID_Articulo, string auxNombre, string auxDescripcion, int auxCantidad)
        {
            ID = auxID;
            ID_Combo = auxID_Combo;
            ID_Articulo = auxID_Articulo;
            Nombre = auxNombre;
            Descripcion = auxDescripcion;    
            Cantidad = auxCantidad;
        }

        public static void creartabla()
        {
            MySQL.ExecuteNonQuery(
                    "create table if not exists `tabla_DetalleCombo` (" +
                    "id int auto_increment," +
                    "primary key (id)," +
                    "id_combo int," +
                    "id_articulo int," +
                    "INDEX (id_articulo)," +
                    "FOREIGN KEY (id_articulo) " +
                    "REFERENCES tabla_Articulos(id) " +
                    "ON DELETE CASCADE," +
                    "INDEX (id_combo)," +
                    "FOREIGN KEY (id_combo) " +
                    "REFERENCES tabla_Combos(id) " +
                    "ON DELETE CASCADE," +
                    "cantidad int);",
                    BaseDeDatos.Nombre
                    );
        }

        public static void añadir(int auxID_Combo, int auxID_Articulo, int auxCantidad)
        {
            MySQL.ExecuteNonQuery(
                "insert into tabla_DetalleCombo (" +
                "id_combo," +
                "id_articulo," +
                "cantidad" +
                ")values(" +
                auxID_Combo + "," +
                auxID_Articulo + "," +
                auxCantidad + ")",
                BaseDeDatos.Nombre
                );
        }

        public static void editarCantidad(int auxID, int auxCantidad)
        {
            MySQL.ExecuteNonQuery(
                "update tabla_DetalleCombo set " +
                "cantidad = " + auxCantidad + " " +
                "where id = " + auxID,
                BaseDeDatos.Nombre
                );
        }

        public static void borrar(int auxID_Combo)
        {
            MySQL.ExecuteNonQuery(
                "delete from tabla_DetalleCombo " +
                "where id_combo = " + auxID_Combo,
                BaseDeDatos.Nombre
                );
        }

        public static List<DetalleCombo> tabla(int auxID_Combo)
        {
            string consulta = "select ";
            consulta += "tabla_DetalleCombo.id,";
            consulta += "tabla_DetalleCombo.id_combo,";
            consulta += "tabla_DetalleCombo.id_articulo,";
            consulta += "tabla_Articulos.nombre,";
            consulta += "tabla_Articulos.descripcion,";
            consulta += "tabla_DetalleCombo.cantidad ";
            consulta += "from tabla_DetalleCombo ";
            consulta += "left join tabla_Articulos ";
            consulta += "on tabla_Articulos.id = tabla_DetalleCombo.id_articulo ";
            consulta += "where tabla_DetalleCombo.id_combo = " + auxID_Combo;

            MySqlDataReader datos = MySQL.ExecuteReader(consulta, BaseDeDatos.Nombre);
            List<DetalleCombo> lista = new List<DetalleCombo>();
            while (datos.Read())
            {
                lista.Add(new DetalleCombo(
                    Convert.ToInt32(datos["id"]),
                    Convert.ToInt32(datos["id_combo"]),
                    Convert.ToInt32(datos["id_articulo"]),
                    datos["nombre"].ToString(),
                    datos["descripcion"].ToString(),
                    Convert.ToInt32(datos["cantidad"])
                    ));
            }
            return lista;
        }
    }
}
