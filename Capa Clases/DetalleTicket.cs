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
    public class DetalleTicket
    {
        private int id;
        private int id_ticket;
        private int cantidad;
        private string producto;
        private decimal precio_unitario;
        private decimal total;

        [Browsable(false)]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [Browsable(false)]
        public int ID_Combo
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        [Browsable(false)]
        public int ID_Ticket
        {
            get { return id_ticket; }
            set { id_ticket = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public decimal Precio_Unitario
        {
            get { return precio_unitario; }
            set { precio_unitario = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public DetalleTicket(int auxID, int auxID_Ticket, int auxCantidad, string auxProducto, decimal auxPrecio_Unitario, decimal auxTotal)
        {
            ID = auxID;
            ID_Ticket = auxID_Ticket;
            cantidad = auxCantidad;
            Producto = auxProducto;
            Precio_Unitario = auxPrecio_Unitario;
            Total = auxTotal;
        }

        public static void creartabla()
        {
            MySQL.ExecuteNonQuery(
                    "create table if not exists `tabla_DetalleTicket` (" +
                    "id int auto_increment," +
                    "primary key (id)," +
                    "id_ticket int," +
                    "INDEX (id_ticket)," +
                    "FOREIGN KEY (id_ticket) " +
                    "REFERENCES tabla_tickets(id) " +
                    "ON DELETE CASCADE," +
                    "cantidad int," +
                    "producto varchar(50)," +
                    "precio_unitario decimal(10,2)," +
                    "total decimal(10,2));",
                    BaseDeDatos.Nombre
                    );
        }

        public static void añadir(int auxID_Ticket, int auxCantidad, string auxProducto, decimal auxPrecio_Unitario, decimal auxTotal)
        {
            MySQL.ExecuteNonQuery("insert into tabla_DetalleTicket (id_ticket,cantidad,producto,precio_unitario,total)values('" + auxID_Ticket + "','" + auxCantidad + "','" + auxProducto + "','" + auxPrecio_Unitario + "','" + auxTotal + "')",

                BaseDeDatos.Nombre
                );
        }

        public static List<DetalleTicket> tabla(int auxID_Ticket)
        {
            string consulta = "select * from tabla_DetalleTicket where id_ticket = " + auxID_Ticket;

            MySqlDataReader datos = MySQL.ExecuteReader(consulta, BaseDeDatos.Nombre);
            List<DetalleTicket> lista = new List<DetalleTicket>();
            while (datos.Read())
            {
                lista.Add(new DetalleTicket(
                    Convert.ToInt32(datos["id"]),
                    Convert.ToInt32(datos["id_ticket"]),
                    Convert.ToInt32(datos["cantidad"]),
                    datos["producto"].ToString(),
                    Convert.ToDecimal(datos["precio_unitario"]),
                    Convert.ToDecimal(datos["total"])
                    ));
            }
            return lista;
        }
    }
}
