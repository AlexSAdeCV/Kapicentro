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
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Karpicentro.Forms
{
    public partial class VistaProducto : Form
    {
        public int id;
        public double precio, preciof;
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

            }

        }

    }
}
