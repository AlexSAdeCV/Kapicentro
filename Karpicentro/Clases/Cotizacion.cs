using Karpicentro.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Karpicentro
{
    public class Cotizacion
    {
        public string TipodeMadera { get; set; }
        public double[] Medidas { get; set; }
        public bool Personalizado { get; set; }
        public string Mensaje { get; set; }

        public Cotizacion() 
        {
            Medidas = new double[3];
        }

        public bool MostrarMedidas(int r)
        {
            bool exito = false;
            DataTable Productos = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"select alto, largo, ancho from Cotizacion where IDCotizacion = IDCotizacion";

                CmdSQL = new SqlCommand(Cadena, Conectar);
                CmdSQL.Parameters.AddWithValue("@IDCotizacion", r);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(Productos);

                    r -= 1;

                    if (Productos.Rows.Count > 0)
                    {
                        Medidas[0] = Convert.ToDouble(Productos.Rows[r]["Alto"]);
                        Medidas[1] = Convert.ToDouble(Productos.Rows[r]["Ancho"]);
                        Medidas[2] = Convert.ToDouble(Productos.Rows[r]["Largo"]);

                        exito = true;
                    }

                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }

            return exito;
        }

        public double PrecioMadera(int s)
        {
            DataTable Almacen = new DataTable();
            double precio = 0;

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "Select precioparahacermueble from Almacen where IDAlmacen = @IDAlmacen";
                cmdSelect = new SqlCommand(sentencia, conexion);

                cmdSelect.Parameters.AddWithValue("@IDAlmacen",s);

                try
                {
                    
                    adapterLibros.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapterLibros.Fill(Almacen);

                    precio = Convert.ToDouble(Almacen.Rows[0]["precioparahacermueble"]);

                }
                catch (Exception ex)
                {
                    Mensaje =(ex.Message);
                }
            }
            return precio;
        }
    }
}
