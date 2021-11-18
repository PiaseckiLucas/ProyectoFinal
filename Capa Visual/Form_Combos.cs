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
    public partial class Form_Combos : Form
    {
        private object[] filtros = new object[2] { null, null };

        public Form_Combos()
        {
            InitializeComponent();
        }

        public void CargarTablaDeCombos()
        {
            dataGridView_combos.DataSource = null;
            dataGridView_combos.DataSource = Combo.tabla(filtros);
        }

        public void CargarTablaDeArticulos()
        {
            dataGridView_articulos.DataSource = null;
            dataGridView_articulos.DataSource = Articulo.tabla(new object[] { null, null, null, null });
        }

        public void CargarTablaDeDetalles()
        {
            dataGridView_detallecombos.DataSource = null;
            dataGridView_detallecombos.DataSource = DetalleCombo.tabla(((Combo)dataGridView_combos.SelectedRows[0].DataBoundItem).ID);
        }

        private void boton_agregar_Click(object sender, EventArgs e)
        {
            Combo.añadir(textbox_nombre1.Text,textBox_descripcion1.Text);
            for(int i = 0; i < dataGridView_articulos.SelectedRows.Count; i++)
            {
                DetalleCombo.añadir(Combo.ultimaID(), ((Articulo)dataGridView_articulos.SelectedRows[i].DataBoundItem).ID, 0);
            }
            CargarTablaDeCombos();
        }

        private void boton_editar_Click(object sender, EventArgs e)
        {
            Combo.editar(((Combo)dataGridView_combos.SelectedRows[0].DataBoundItem).ID, textbox_nombre1.Text, textBox_descripcion1.Text);
            DetalleCombo.borrar(((Combo)dataGridView_combos.SelectedRows[0].DataBoundItem).ID);
            for (int i = 0; i < dataGridView_articulos.SelectedRows.Count; i++)
            {
                DetalleCombo.añadir(Combo.ultimaID(), ((Articulo)dataGridView_articulos.SelectedRows[i].DataBoundItem).ID, 0);
            }
            CargarTablaDeCombos();
        }

        private void boton_borrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_combos.SelectedRows.Count; i++)
                Combo.borrar(((Combo)dataGridView_combos.SelectedRows[i].DataBoundItem).ID);
            CargarTablaDeCombos();
        }

        private void Form_Combos_VisibleChanged(object sender, EventArgs e)
        {
            CargarTablaDeCombos();
            CargarTablaDeArticulos();
        }

        private void dataGridView_combos_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_detallecombos.DataSource = null;
            if (dataGridView_combos.SelectedRows.Count == 1)
            {
                dataGridView_detallecombos.DataSource = DetalleCombo.tabla(((Combo)dataGridView_combos.SelectedRows[0].DataBoundItem).ID);
            }
        }

        private void dataGridView_detallecombos_SelectionChanged(object sender, EventArgs e)
        {
            cambiarCantidad = false;
            numericUpDown_cantidad.Value = 0;
            if(dataGridView_detallecombos.SelectedRows.Count == 1)
            {
                numericUpDown_cantidad.Value = ((DetalleCombo)dataGridView_detallecombos.SelectedRows[0].DataBoundItem).Cantidad;
            }
            cambiarCantidad = true;
        }

        public bool cambiarCantidad = true;
        private void numericUpDown_cantidad_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView_detallecombos.SelectedRows.Count == 1 && cambiarCantidad)
            {
                DetalleCombo.editarCantidad(((DetalleCombo)dataGridView_detallecombos.SelectedRows[0].DataBoundItem).ID, Convert.ToInt32(numericUpDown_cantidad.Value));
                CargarTablaDeDetalles();
            }
        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
            if (checkBox_nombre.Checked) filtros[0] = textBox_nombre2.Text;
            else filtros[0] = null;
            if (checkBox_descripcion.Checked) filtros[1] = textBox_descripcion2.Text;
            else filtros[1] = null;
            CargarTablaDeCombos();
        }
    }
}
