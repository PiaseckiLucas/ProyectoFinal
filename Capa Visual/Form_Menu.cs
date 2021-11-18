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
    public partial class Form_Menu : Form
    {
        Form_Articulos f_invetario;
        Form_Combos f_combos;
        Form_Ventas f_ventas;

        public Form_Menu()
        {
            InitializeComponent();

            BaseDeDatos.crear("McDonalds");

            Articulo.creartabla();
            DetalleHamburguesa.creartabla();
            Combo.creartabla();
            DetalleCombo.creartabla();
            Ticket.creartabla();
            DetalleTicket.creartabla();

            f_invetario = new Form_Articulos();
            f_invetario.TopLevel = false;
            f_invetario.Dock = DockStyle.Fill;
            panel_formulario.Controls.Add(f_invetario);
            f_invetario.Hide();
            f_invetario.BringToFront();

            f_combos = new Form_Combos();
            f_combos.TopLevel = false;
            f_combos.Dock = DockStyle.Fill;
            panel_formulario.Controls.Add(f_combos);
            f_combos.Hide();
            f_combos.BringToFront();

            f_ventas = new Form_Ventas();
            f_ventas.TopLevel = false;
            f_ventas.Dock = DockStyle.Fill;
            panel_formulario.Controls.Add(f_ventas);
            f_ventas.Hide();
            f_ventas.BringToFront();
        }
        int m, mx, my;
        private void boton_inventario_Click(object sender, EventArgs e)
        {
            bool aux = f_invetario.Visible;
            foreach (Form x in panel_formulario.Controls.OfType<Form>())
                x.Visible = false;
            f_invetario.Visible = !aux;
            
        }

        private void boton_Combos_Click(object sender, EventArgs e)
        {
            bool aux = f_combos.Visible;
            foreach (Form x in panel_formulario.Controls.OfType<Form>())
                x.Visible = false;
            f_combos.Visible = !aux;
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Boton_minimizar_Click(object sender, EventArgs e)
        {
            {
                this.WindowState= FormWindowState.Minimized;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void boton_Ventas_Click(object sender, EventArgs e)
        {
            bool aux = f_ventas.Visible;
            foreach (Form x in panel_formulario.Controls.OfType<Form>())
                x.Visible = false;
            f_ventas.Visible = !aux;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
