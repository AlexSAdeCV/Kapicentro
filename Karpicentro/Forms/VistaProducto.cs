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

namespace Karpicentro.Forms
{
    public partial class VistaProducto : Form
    {
        public int id;
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

            vt.idproducto = pr.IDProducto;

            int cantidadinicial = 
            Habilitar();

            LblTotal.Text = $"Total\n$ {LblPrecio.Text}";
        }

        private void BtnTerminarVenta_Click(object sender, EventArgs e)
        {
            Venta vt = new Venta();
            Productos pr = new Productos();

            DialogResult Resultado = MessageBox.Show("¿Desea terminar la venta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Resultado == DialogResult.Yes)
            {
                vt.idproducto = pr.IDProducto;
                vt.idempleado = InicioSesion.UsuarioF;
                vt.PrecioProducto = Convert.ToInt32(LblTotal.Text);
                vt.Fecha = DateTime.Now.ToString("yyyy") + "/" + DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("dd");

                if (vt.VenderProducto())
                {
                    
                }

            }

        }

    }
}
