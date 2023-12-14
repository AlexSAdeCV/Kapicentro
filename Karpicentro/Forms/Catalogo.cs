using Karpicentro.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karpicentro.Forms
{
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            VistaProducto vp = new VistaProducto();
            vp.id = 1;
            vp.PicboxProducto.Image = pictureBox2.Image;

            vp.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            VistaProducto vp = new VistaProducto();
            vp.id = 2;
            vp.PicboxProducto.Image = pictureBox2.Image;

            vp.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            VistaProducto vp = new VistaProducto();

            vp.PicboxProducto.Image = pictureBox3.Image;

            vp.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            VistaProducto vp = new VistaProducto();

            vp.PicboxProducto.Image = pictureBox4.Image;

            vp.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            VistaProducto vp = new VistaProducto();

            vp.PicboxProducto.Image = pictureBox5.Image;

            vp.ShowDialog();
        }

        private void BtnCotizacion_Click(object sender, EventArgs e)
        {
            Cotizaciones cotizaciones = new Cotizaciones();

            cotizaciones.ShowDialog();
        }
    }
}
