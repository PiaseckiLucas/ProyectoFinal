using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using MySqlConnector;

namespace Capa_Clases
{
    public class Combo
    {
        private int id;
        private string nombre;
        private string descripcion;

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

        public Combo(int auxID, string auxNombre, string auxDescripcion)
        {
            ID = auxID;
            Nombre = auxNombre;
            Descripcion = auxDescripcion;
        }

        public static void creartabla()
        {
            MySQL.ExecuteNonQuery(
                    "create table if not exists `tabla_Combos` (" +
                    "id int auto_increment," +
                    "primary key (id)," +
                    "nombre varchar(50)," +
                    "descripcion tinytext);",
                    BaseDeDatos.Nombre
                    );
        }

        public static void añadir(string auxNombre, string auxDescripcion)
        {
            MySQL.ExecuteNonQuery(
                "insert into tabla_Combos (" +
                "nombre," +
                "descripcion" +
                ")values(" +
                "'" + auxNombre + "'," +
                "'" + auxDescripcion + "')",
                BaseDeDatos.Nombre
                );
        }

        public static void editar(int auxID, string auxNombre, string auxDescripcion)
        {
            MySQL.ExecuteNonQuery(
                "update tabla_Combos set " +
                "nombre = '" + auxNombre + "'," +
                "descripcion = '" + auxDescripcion + "' " +
                "where id = " + auxID,
                BaseDeDatos.Nombre
                );
        }

        public static void borrar(int auxID)
        {
            MySQL.ExecuteNonQuery(
                "delete from tabla_Combos " +
                "where id = " + auxID,
                BaseDeDatos.Nombre
                );
        }

        public static int ultimaID()
        {
            string consulta = "select max(id) from tabla_Combos;";
            return Convert.ToInt32(MySQL.ExecuteScalar(consulta, BaseDeDatos.Nombre));
        }

        public static List<Combo> tabla(object[] filtros)
        {
            string consulta = "select * from tabla_Combos";
            int contador = 0;
            for (int i = 0; i < 2; i++)
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
                    }

                    contador++;
                }
            }
            MySqlDataReader datos = MySQL.ExecuteReader(consulta, BaseDeDatos.Nombre);
            List<Combo> lista = new List<Combo>();
            while (datos.Read())
            {
                lista.Add(new Combo(
                    Convert.ToInt32(datos["id"]),
                    datos["nombre"].ToString(),
                    datos["descripcion"].ToString()
                    ));
            }
            return lista;
        }
    }
}
