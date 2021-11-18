using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Capa_Clases;

namespace Capa_Visual
{
    public partial class Form_Ventas : Form
    {
        public Form_Ventas()
        {
            InitializeComponent();
        }

        public void CargarTablaDeCombos()
        {
            dataGridView_combos.DataSource = null;
            dataGridView_combos.DataSource = Combo.tabla(new object[] { null, null, null, null });
        }

        public void CargarTablaDeVentas()
        {
            dataGridView_ventas.DataSource = null;
            dataGridView_ventas.DataSource = Ticket.tabla();
            dataGridView_ventas.Columns[0].Visible = false;
        }

        private void Form_Ventas_VisibleChanged(object sender, EventArgs e)
        {
            CargarTablaDeVentas();
            CargarTablaDeCombos();
        }

        private void dataGridView_combos_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_detallecombos.DataSource = null;
            if (dataGridView_combos.SelectedRows.Count == 1)
            {
                dataGridView_detallecombos.DataSource = DetalleCombo.tabla(((Combo)dataGridView_combos.SelectedRows[0].DataBoundItem).ID);
            }
        }

        private void boton_vender_Click(object sender, EventArgs e)
        {
            if(dataGridView_combos.SelectedRows.Count == 1)
            {
                bool vender = true;
                List<string> productos = new List<string>();
                List<int> cantidades = new List<int>();
                List<decimal> precios = new List<decimal>();
                decimal total = 0;
                foreach (DataGridViewRow fila in dataGridView_detallecombos.Rows)
                {
                    Articulo auxArticulo = new Articulo(((DetalleCombo)fila.DataBoundItem).ID_Articulo);
                    int cantidad = ((DetalleCombo)fila.DataBoundItem).Cantidad;
                    if (cantidad > auxArticulo.Stock)
                    {
                        vender = false;
                        break;
                    }
                    Articulo.descontarStock(auxArticulo.ID, auxArticulo.Stock - cantidad);
                    cantidades.Add(cantidad);
                    productos.Add(auxArticulo.Nombre);
                    precios.Add(auxArticulo.Precio);
                    total += auxArticulo.Precio * cantidad;
                }
                if (vender)
                {
                    Ticket.añadir(total);
                    for(int i = 0; i < productos.Count; i++)
                    {
                        DetalleTicket.añadir(Ticket.ultimaID(), cantidades[i], productos[i], precios[i], cantidades[i] * precios[i]);
                    }
                    CargarTablaDeVentas();

                }
                else
                {
                    MessageBox.Show("No se puede vender, no hay suficientes articulos en el stock.");
                }
            }
        }

        private void dataGridView_ventas_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_detalleVentas.DataSource = null;
            if (dataGridView_ventas.SelectedRows.Count == 1)
            {
                dataGridView_detalleVentas.DataSource = DetalleTicket.tabla(((Ticket)dataGridView_ventas.SelectedRows[0].DataBoundItem).ID);
            }
        }

        private void dataGridView_ventas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DialogResult result = MessageBox.Show("¿Quiere generar un ticket?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                if (index >= 0)
                {
                    string code = dataGridView_ventas.Rows[index].Cells[0].Value.ToString();
                    string Fecha = dataGridView_ventas.Rows[index].Cells[1].Value.ToString();
                    string PrecioTotal = dataGridView_ventas.Rows[index].Cells[2].Value.ToString();

                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = string.Format("TICKET {0}.pdf", code);


                    string PaginaHTML_Texto = Properties.Resources.Ticket.ToString();

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CODE", code);
                    //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHAT", Fecha);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

                    string filas = string.Empty;

                    foreach (DataGridViewRow row in dataGridView_detalleVentas.Rows)
                    {
                        filas += "<tr>";
                        filas += "<td>" + row.Cells[0].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells[1].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells[2].Value.ToString() + "</td>";

                        filas += "</tr>";
                    }
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", PrecioTotal.ToString());

                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                        {
                            //Creamos un nuevo documento y lo definimos como PDF
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(new Phrase(""));

                            //Agregamos la imagen del banner al documento
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.PH, System.Drawing.Imaging.ImageFormat.Png);
                            img.ScaleToFit(60, 60);
                            img.Alignment = iTextSharp.text.Image.UNDERLYING;

                            //img.SetAbsolutePosition(10,100);
                            img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                            pdfDoc.Add(img);


                            //pdfDoc.Add(new Phrase("Hola Mundo"));
                            using (StringReader sr = new StringReader(PaginaHTML_Texto))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                            }

                            pdfDoc.Close();
                            stream.Close();
                        }
                    }
                }

            }

        }
    }
}
