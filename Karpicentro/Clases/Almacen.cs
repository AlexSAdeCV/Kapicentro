using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static iText.Signatures.LtvVerification;
using System.Windows.Forms;

namespace Karpicentro
{
    public class Almacen
    {
        public string Nombre { get; set; }
        public int Proveedor { get; set; }
        public int CantidadMaterial { get; set; }
        public string Mensaje { get; set; }
        public int idalmacen { get; set; }
        public double precio { get; set; }

        public bool Insertar()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"insert into Almacen values (@TipoMadera, @Stock, @precioparahacermueble, @idproveedor)";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@TipoMadera", Nombre);
                CMDSql.Parameters.AddWithValue("@Stock", CantidadMaterial);
                CMDSql.Parameters.AddWithValue("@precioparahacermueble", precio);
                CMDSql.Parameters.AddWithValue("@idproveedor", Proveedor);

                try
                {
                    Con.Open();

                    resultado = CMDSql.ExecuteNonQuery();
                    if (resultado > 0)
                    {

                        Exito = true;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return Exito;
        }

        public bool Modificar()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"update Almacen set TipoMadera = @TipoMadera, Stock = @Stock,  precioparahacermueble = @precioparahacermueble ,idproveedor = @idproveedor where IDAlmacen = @IDAlmacen";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@Stock", CantidadMaterial);
                CMDSql.Parameters.AddWithValue("@TipoMadera", Nombre);
                CMDSql.Parameters.AddWithValue("@idproveedor", Proveedor);
                CMDSql.Parameters.AddWithValue("@precioparahacermueble", precio);
                CMDSql.Parameters.AddWithValue("@IDAlmacen", idalmacen);


                try
                {
                    Con.Open();

                    resultado = CMDSql.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        Mensaje = "Se agrego el nuevo tipo de madera";
                        Exito = true;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return Exito;
        }

        public bool Eliminar()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"delete from Almacen where IDAlmacen = @IDAlmacen";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@IDAlmacen", idalmacen);


                try
                {
                    Con.Open();

                    resultado = CMDSql.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        Mensaje = "Se agrego el nuevo tipo de madera";
                        Exito = true;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return Exito;
        }

        public DataTable MostrarAlmacen()
        {
            DataTable Almacen = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = "Select IDAlmacen, TipoMadera, stock, precioparahacermueble as Precio, NombreProv as Proveedor, IDProveedor from Almacen inner join Proveedor on idprov = IDProveedor";

                CmdSQL = new SqlCommand(Cadena, Conectar);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(Almacen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return Almacen;
        }
    }
}
