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

        public void HacerCotizacion()
        {
            Medidas = new double[3];
        }

        public DataTable MostrarCotizacion()
        {
            DataTable Almacen = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"Select * from Cotizacion";

                CmdSQL = new SqlCommand(Cadena, Conectar);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(Almacen);
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }

            return Almacen;
        }

        public bool MostrarCatalogo(int r)
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
                        Medidas[0] = Convert.ToDouble(Productos.Rows[r]["Nombre"]);
                        Medidas[1] = Convert.ToDouble(Productos.Rows[r]["Nombre"]);
                        Medidas[2] = Convert.ToDouble(Productos.Rows[r]["Nombre"]);

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
    }
}
