using Karpicentro.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karpicentro.Forms
{
    public partial class Catalogo : Form
    {
        private List<Image> imagenespic;
        private int ImagenActual;

        public Catalogo()
        {
            InitializeComponent();
            imagenespic = Imagenes();

            ImagenActual = 0;

            PcbImgProducto.Image = imagenespic[0];

            timer1.Interval = 3000;
            timer1.Start();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            if (ImagenActual == 0)
            {
                Image img = imagenespic.Last();
                PcbImgProducto.Image = img;
                ImagenActual = imagenespic.Count() - 1;
            }
            else
                PcbImgProducto.Image = imagenespic[ImagenActual = ((ImagenActual - 1) % imagenespic.Count)];

            timer1.Start();
        }

        private void BtnAdelante_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            if (ImagenActual == 0)
            {
                Image img = imagenespic.Last();
                PcbImgProducto.Image = img;
            }

            PcbImgProducto.Image = imagenespic[ImagenActual = ((ImagenActual + 1) % imagenespic.Count)];

            timer1.Start();
        }

        private void BtnComprar_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();

            VistaProducto vp = new VistaProducto();

            vp.id = ImagenActual + 1;

            vp.ShowDialog();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ImagenActual = (ImagenActual + 1) % imagenespic.Count;

            PcbImgProducto.Image = imagenespic[ImagenActual];
        }

        private List<Image> Imagenes() 
        {
            List<Image> imagen = new List<Image>();

            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand command;
                string Sentencia;

                Sentencia = @"Select Imagen from Producto";
                command = new SqlCommand(Sentencia, Con);

                Con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    byte[] imageBytes = (byte[])reader["Imagen"];
                    MemoryStream memoryStream = new MemoryStream(imageBytes);
                    imagen.Add(Image.FromStream(memoryStream));
                }
            }
            return imagen;
        }
    }
}
