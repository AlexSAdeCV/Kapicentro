using Karpicentro.Clases;
using Org.BouncyCastle.Asn1.Ocsp;
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
using System.Windows.Annotations;
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
            LblID.Text = (ImagenActual + 1).ToString();

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
                LblID.Text = (ImagenActual + 1).ToString();
            }
            else
            {
                PcbImgProducto.Image = imagenespic[ImagenActual = ((ImagenActual - 1) % imagenespic.Count)];
                LblID.Text = (ImagenActual + 1).ToString();
            }

            timer1.Start();
        }

        private void BtnAdelante_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            if (ImagenActual == 0)
            {
                Image img = imagenespic.Last();
                PcbImgProducto.Image = img;
                LblID.Text = ImagenActual.ToString();
            }
            PcbImgProducto.Image = imagenespic[ImagenActual = ((ImagenActual + 1) % imagenespic.Count)];
            LblID.Text = (ImagenActual + 1).ToString();

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
            LblID.Text = (ImagenActual + 1).ToString();
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (ValidaCamposBuscar())
            {
                if (Convert.ToInt32(textBox1.Text) > EncontrarIDMax())
                {
                    MessageBox.Show($"No Existe el registro {textBox1.Text}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                }
                else
                {
                    Image img = imagenespic[Convert.ToInt32(textBox1.Text) - 1];
                    PcbImgProducto.Image = img;
                    LblID.Text = (Convert.ToInt32(textBox1.Text)).ToString();
                    ImagenActual = Convert.ToInt32(textBox1.Text) - 1;

                    timer1.Start();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private int EncontrarIDMax()
        {
            int Idp = 0;

            DataTable Productos = new DataTable();
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "select MAX(IDProducto) as id from Producto";
                cmdSelect = new SqlCommand(sentencia, conexion);

                try
                {
                    adapterLibros.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapterLibros.Fill(Productos);

                    string temporal = Productos.Rows[0]["id"].ToString();

                    if (temporal == "")
                        Idp = 1;
                    else
                        Idp = (Int32)Productos.Rows[0]["id"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return Idp;
        }

        private bool ValidaCamposBuscar()
        {
            bool valido = true;
            if (textBox1.Text.Length <= 0)
            {
                errorProvider1.SetError(textBox1, "Campo no puede estar en blanco");
                valido = false;
            }
            return valido;
        }
    }
}
