using iText.Kernel.Geom;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using Karpicentro.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using iText.IO.Image;
using iText.Layout;
using iText.Kernel.Pdf.Extgstate;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Drawing.Printing;
using iText.Bouncycastleconnector;

namespace Karpicentro.Forms
{
    public partial class VistaProducto : Form
    {
        public int id;
        public double precio, preciof;
        public string Nombre;
        public int x = 0;
        public VistaProducto()
        {
            InitializeComponent();
            VaciarCampos();
            DesHabilitar();
        }

        public void Lbl_Fotos_Click(object sender, EventArgs e)
        {

        }

        private void VistaProducto_Load(object sender, EventArgs e)
        {
            LLenar();
        }

        private void LLenar()
        {
            Productos Pr = new Productos();
            Pr.IDProducto = id;
            if (id != 1)
                Pr.IDProducto -= 1;
            if (Pr.MostrarCatalogo())
            {
                LblNombreM.Text = Pr.Nombre;
                lblDescripcion.Text = Pr.Descripcion;
                LblPrecio.Text = Pr.PrecioVenta.ToString();
                LblMedidas.Text = $"Medidas\n{Pr.Medidas[0]} X {Pr.Medidas[1]} x {Pr.Medidas[2]}";
                LblExstencia.Text = /*"Existencia: " + */Pr.Existencia.ToString();
                numericUpDown1.Maximum = Pr.Existencia;
            }

        }

        private void VaciarCampos()
        {
            foreach (Control c in Pnlinserstar.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }

        private void Habilitar()
        {
            foreach (Control c in PnlTotal.Controls)
            {
                if (c is Control)
                {
                    c.Enabled = true;
                    c.Visible = true;
                }
            }
        }

        private void DesHabilitar()
        {
            foreach (Control c in PnlTotal.Controls)
            {
                if (c is Control)
                {
                    c.Enabled = false;
                    c.Visible = false;
                }
            }
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            Venta vt = new Venta();
            Productos pr = new Productos();

            Habilitar();

            vt.idproducto = pr.IDProducto;

            int cantidadinicial = Convert.ToInt32(LblExstencia.Text);
            int cantidadcomprada = Convert.ToInt32(numericUpDown1.Value);
            precio = Convert.ToDouble(LblPrecio.Text);

            if (cantidadcomprada > 1)
            {
                preciof = cantidadcomprada * precio;
                vt.preciofinal = preciof;
                LblTotal.Text = $"Total\n$ {vt.preciofinal}";

                int cantidadfinal = cantidadinicial - cantidadcomprada;
                Productos.cantidadfinal = cantidadfinal;
                vt.CantidadComprada = cantidadinicial;

            }
            else
            {
                LblTotal.Text = $"Total\n$ {LblPrecio.Text}";
                preciof = Convert.ToDouble(LblPrecio.Text);
            }
        }

        private void BtnTerminarVenta_Click(object sender, EventArgs e)
        {
            Venta vt = new Venta();
            Productos pr = new Productos();

            Nombre = InicioSesion.Usuario;

            //InicioSesion.UsuarioF = 1;

            DialogResult Resultado = MessageBox.Show("¿Desea terminar la venta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Resultado == DialogResult.Yes)
            {
                int final = Productos.cantidadfinal;
                if (id != 1)
                    pr.IDProducto = id - 1;
                pr.IDProducto = id;

                if (pr.ActualizarExistencia(final))
                {
                    vt.idproducto = id;
                    vt.idempleado = InicioSesion.UsuarioF;
                    vt.preciofinal = preciof;
                    vt.Fecha = DateTime.Now.ToString("yyyy") + "/" + DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("dd");

                    if (vt.VenderProducto())
                    {
                        MessageBox.Show("Se realizo la venta adecuadamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                Resultado = MessageBox.Show("¿Desea ticket de la venta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Resultado == DialogResult.Yes)
                {
                    IPDF(Convert.ToString(vt.Sacaridventa()), Nombre);
                }
            }

        }

        public void IPDF(string id, string user)
        {
            SaveFileDialog GuardaArchivoPdf = new SaveFileDialog();
            int cant = Convert.ToInt32(numericUpDown1.Value);
            string rp = @"Factura Nº " + x++;
            GuardaArchivoPdf.Filter = "Archivos PDF|*.pdf";
            GuardaArchivoPdf.FileName = @"Factura Nº " + x++;
            if (GuardaArchivoPdf.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(GuardaArchivoPdf.FileName, FileMode.Create))
                {
                    PdfWriter pdfWriter = new PdfWriter(stream);
                    PdfDocument pdfDocument = new PdfDocument(pdfWriter);
                    PageSize pageSize = PageSize.A7.Rotate();

                    Document MiDocumento = new Document(pdfDocument);
                    PdfCanvas canvas = new PdfCanvas(pdfDocument.AddNewPage());

                    MiDocumento.Add(new Paragraph("************************************************"));
                    MiDocumento.Add(new Paragraph("Factura Nº: " + x++));
                    MiDocumento.Add(new Paragraph("Fecha: " + DateTime.Now));
                    MiDocumento.Add(new Paragraph("************************************************"));

                    MiDocumento.Add(new Paragraph("Cantidad      Producto                Precio"));
                    MiDocumento.Add(new Paragraph(cant + "            " + LblNombreM.Text + "              $" + LblPrecio.Text));

                    MiDocumento.Add(new Paragraph("************************************************"));
                    MiDocumento.Add(new Paragraph("TOTAL:                             $" + LblTotal.Text));
                    MiDocumento.Add(new Paragraph("************************************************"));
                    MiDocumento.Add(new Paragraph("Gracias por su compra"));
                    MiDocumento.Close();
                }

            }
        }

        private void VistaProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
        }

        private void IbtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
