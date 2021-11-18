using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Clases;

namespace Capa_Visual
{
    public partial class Form_Articulos : Form
    {
        private object[] filtros = new object[4] { null, null, null, null };

        public Form_Articulos()
        {
            InitializeComponent();
        }

        private void CargarTabla()
        {
            dataGridView_articulos.DataSource = null;
            dataGridView_articulos.DataSource = Articulo.tabla(filtros);
        }

        private void boton_agregar_Click(object sender, EventArgs e)
        {
            Articulo.añadir(textbox_nombre1.Text, textBox_descripcion1.Text, Convert.ToInt32(numericUpDown_stock1.Value), numericUpDown_precio1.Value, checkBox_es_hamburguesa1.Checked);
            if (checkBox_es_hamburguesa1.Checked)
            {
                DetalleHamburguesa.añadir(Articulo.ultimaID(), Convert.ToInt32(numericUpDown_pan.Value), Convert.ToInt32(numericUpDown_patycarne.Value), Convert.ToInt32(numericUpDown_patypollo.Value), Convert.ToInt32(numericUpDown_queso.Value), Convert.ToInt32(numericUpDown_lechuga.Value), Convert.ToInt32(numericUpDown_tomate.Value), Convert.ToInt32(numericUpDown_cebolla.Value), Convert.ToInt32(numericUpDown_pepino.Value));
            }
            CargarTabla();
        }

        private void boton_editar_Click(object sender, EventArgs e)
        {
            if(((Articulo)dataGridView_articulos.SelectedRows[0].DataBoundItem).Es_Hamburguesa == checkBox_es_hamburguesa1.Checked)
            {
                Articulo.editar(((Articulo)dataGridView_articulos.SelectedRows[0].DataBoundItem).ID, textbox_nombre1.Text, textBox_descripcion1.Text, Convert.ToInt32(numericUpDown_stock1.Value), numericUpDown_precio1.Value);
                if (((Articulo)dataGridView_articulos.SelectedRows[0].DataBoundItem).Es_Hamburguesa)
                {
                    DetalleHamburguesa.editar(((Articulo)dataGridView_articulos.SelectedRows[0].DataBoundItem).ID, Convert.ToInt32(numericUpDown_pan.Value), Convert.ToInt32(numericUpDown_patycarne.Value), Convert.ToInt32(numericUpDown_patypollo.Value), Convert.ToInt32(numericUpDown_queso.Value), Convert.ToInt32(numericUpDown_lechuga.Value), Convert.ToInt32(numericUpDown_tomate.Value), Convert.ToInt32(numericUpDown_cebolla.Value), Convert.ToInt32(numericUpDown_pepino.Value));
                }
            }
            CargarTabla();
        }

        private void boton_borrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_articulos.SelectedRows.Count; i++)
                Articulo.borrar(((Articulo)dataGridView_articulos.SelectedRows[i].DataBoundItem).ID);
            CargarTabla();
        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
            if (checkBox_nombre.Checked) filtros[0] = textBox_nombre2.Text;
            else filtros[0] = null;
            if (checkBox_descripcion.Checked) filtros[1] = textBox_descripcion2.Text;
            else filtros[1] = null;
            if (checkBox_stock.Checked) filtros[2] = numericUpDown_stock2.Text;
            else filtros[2] = null;
            if (checkBox_precio.Checked) filtros[3] = numericUpDown_precio2.Text;
            else filtros[3] = null;
            CargarTabla();
        }

        private void Form_Articulos_VisibleChanged(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void dataGridView_articulos_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_hamburguesa.DataSource = null;
            if(dataGridView_articulos.SelectedRows.Count == 1)
            {
                if (((Articulo)dataGridView_articulos.SelectedRows[0].DataBoundItem).Es_Hamburguesa)
                {
                    dataGridView_hamburguesa.DataSource = DetalleHamburguesa.tabla(((Articulo)dataGridView_articulos.SelectedRows[0].DataBoundItem).ID);
                }
            }
        }
    }
}
