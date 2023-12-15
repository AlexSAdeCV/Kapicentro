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
        public VistaProducto()
        {
            InitializeComponent();
            VaciarCampos();
            DesHabilitar();
            Llenardgv();
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
            if (Pr.MostrarCatalogo())
            {
                LblNombreM.Text = Pr.Nombre;
                lblDescripcion.Text = Pr.Descripcion;
                LblPrecio.Text = Pr.PrecioVenta.ToString();
                LblMedidas.Text = $"Medidas\n{Pr.Medidas[0]} X {Pr.Medidas[1]} x {Pr.Medidas[2]}";
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

            int cantidadinicial = vt.Extraer_Catidad(id);
            int cantidadcomprada = Convert.ToInt32(numericUpDown1.Value);
            precio = Convert.ToDouble(LblPrecio.Text);

            if (cantidadcomprada > 1)
            {
                preciof = cantidadcomprada * precio;
                vt.preciofinal = preciof;
                LblTotal.Text = $"Total\n$ {vt.preciofinal}";

                int cantidadfinal = cantidadinicial - cantidadcomprada;
                vt.CantidadFintal = cantidadfinal;
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
                vt.idproducto = id;
                vt.idempleado = InicioSesion.UsuarioF;
                vt.preciofinal = preciof;
                vt.Fecha = DateTime.Now.ToString("yyyy") + "/" + DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("dd");

                if (vt.VenderProducto())
                {
                    MessageBox.Show("Se realizo la venta adecuadamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Resultado = MessageBox.Show("¿Desea ticket de la venta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                //if (Resultado == DialogResult.Yes)
                //{
                //    IPDF(Convert.ToString(vt.Sacaridventa()), Nombre);
                //}
            }

        }

        public void IPDF(string id, string user)
        {
            //El PDF se genera con una utileria llamad iText, la cual se tiene que incluir antes de utilizar.
            //para instalar ir a Herramientas -> admininistrador de paquetes Nuget -> Consola del administrador de paquetes Nuget
            //en el prompot pm> teclear el comando Install-Package itext7, dar enter y esperar

            //Mas información en https://kb.itextpdf.com/home/it7kb/examples
            //este es un ejemplo básico.

            Venta ventas = new Venta();
            SaveFileDialog GuardaArchivoPdf = new SaveFileDialog();
            string rp = @"Ticket No " + id + " " + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            GuardaArchivoPdf.Filter = "Archivos PDF|*.pdf";
            GuardaArchivoPdf.FileName = rp;
            if (GuardaArchivoPdf.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(GuardaArchivoPdf.FileName, FileMode.Create))
                {
                    PdfWriter pdfWriter = new PdfWriter(stream);
                    PdfDocument pdfDocument = new PdfDocument(pdfWriter);
                    PageSize pageSize = PageSize.A7.Rotate();

                    Document MiDocumento = new Document(pdfDocument);
                    PdfCanvas canvas = new PdfCanvas(pdfDocument.AddNewPage());

                    Table TblVenta = new Table(UnitValue.CreatePercentArray(6));

                    MiDocumento.Add(new Paragraph("Ticket No " + id + " " + DateTime.Now.ToLongDateString()));

                    if (DgvProducto.RowCount > 0)
                    {
                        for (int i = 0; i < DgvProducto.Columns.Count; i++)
                        {
                            TblVenta.AddHeaderCell(new Cell().SetKeepTogether(true).Add(new Paragraph(DgvProducto.Columns[i].Name)));
                        }
                        for (int row = 0; row < DgvProducto.RowCount; row++)
                        {

                            TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph(DgvProducto.Rows[row].Cells[0].Value.ToString()).SetMargins(0, 0, 0, 0)));
                            TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph(DgvProducto.Rows[row].Cells[1].Value.ToString()).SetMargins(0, 0, 0, 0)));
                            TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph(DgvProducto.Rows[row].Cells[2].Value.ToString()).SetMargins(0, 0, 0, 0)));
                            TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph(DgvProducto.Rows[row].Cells[3].Value.ToString()).SetMargins(0, 0, 0, 0)));
                            TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph(DgvProducto.Rows[row].Cells[4].Value.ToString()).SetMargins(0, 0, 0, 0)));
                            TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph(DgvProducto.Rows[row].Cells[5].Value.ToString()).SetMargins(0, 0, 0, 0)));
                        }
                        MiDocumento.Add(TblVenta);
                        MiDocumento.Add(new Paragraph("El total de la compra fue de $ " + LblTotal.Text + " MXN"));
                        MiDocumento.Add(new Paragraph("Que tenga excelente dia\n Lo antendio " + user));

                    }
                    else
                    {
                        TblVenta.AddHeaderCell(new Cell().SetKeepTogether(true).Add(new Paragraph("Error")));
                        TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph("No hay usuarios por listar")));
                        MiDocumento.Add(TblVenta);

                    }
                    MiDocumento.Close();
                }
            }
        }

        public void Llenardgv()
        {
            Venta venta = new Venta();
            DgvProducto.AutoSize = true;
            DgvProducto.DataSource = venta.MostrarVentas();
            DgvProducto.Visible = false;
        }
    }
}
