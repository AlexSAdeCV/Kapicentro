using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using iText.StyledXmlParser.Node;
using iText.Commons.Actions;

namespace Karpicentro.Clases
{
    internal class Productos
    {
        public string Nombre { get; set; }
        public int TipoMadera { get; set; }
        public string TipoMadera2 { get; set; }
        public string Descripcion { get; set; }
        public double PrecioVenta { get; set; }
        public double[] Medidas { get; set; }
        public int Existencia { get; set; }
        public int IDProducto { get; set; }
        public string Mensaje { get; set; }

        public Productos()
        {
            Medidas = new double[3];
        }

        public bool Insertar()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"insert into Producto values (@Nombre, @TipoMadera, @PrecioV, @Existencia)";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@Nombre", Nombre);
                CMDSql.Parameters.AddWithValue("@TipoMadera", TipoMadera);
                CMDSql.Parameters.AddWithValue("@PrecioV", PrecioVenta);
                CMDSql.Parameters.AddWithValue("@Existencia", Existencia);

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

        public bool Actualizar()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"update Producto set Nombre = @Nombre, idmadera = @idmadera, PrecioV = @PrecioV, Existencia = @Existencia  where IDProducto = @IDProducto";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@Nombre", Nombre);
                CMDSql.Parameters.AddWithValue("@idmadera", TipoMadera);
                CMDSql.Parameters.AddWithValue("@PrecioV", PrecioVenta);
                CMDSql.Parameters.AddWithValue("@Existencia", Existencia);
                CMDSql.Parameters.AddWithValue("@IDProducto", IDProducto);

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

        public bool Eliminar()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"delete from Producto where IDProducto = @IDProducto";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@IDProducto", IDProducto);

                try
                {
                    Con.Open();

                    resultado = CMDSql.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        Mensaje = "Eliminacion exitosa";
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

        public DataTable MostrarProductos()
        {
            DataTable Productos = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"select IDProducto, Nombre, TipoMadera, PrecioV, Existencia from Producto inner join Almacen on idmadera = IDAlmacen";

                CmdSQL = new SqlCommand(Cadena, Conectar);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(Productos);
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }

            return Productos;
        }

        public bool MostrarCatalogo()
        {
            bool exito = false;
            DataTable Productos = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"select IDProducto,Nombre, Descripcion, TipoMadera, PrecioV, Alto, Largo, Ancho, Existencia from Producto inner join Almacen on idmadera = IDAlmacen";

                CmdSQL = new SqlCommand(Cadena, Conectar);
                CmdSQL.Parameters.AddWithValue("@IDProducto", IDProducto);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(Productos);

                    IDProducto -= 1;

                    if (Productos.Rows.Count > 0)
                    {
                        Nombre = Productos.Rows[IDProducto]["Nombre"].ToString();
                        Descripcion = Productos.Rows[IDProducto]["Descripcion"].ToString();
                        TipoMadera2 = Productos.Rows[IDProducto]["TipoMadera"].ToString();
                        PrecioVenta = Convert.ToDouble(Productos.Rows[IDProducto]["PrecioV"]);
                        Medidas[0] = Convert.ToDouble(Productos.Rows[IDProducto]["Alto"]);
                        Medidas[1] = Convert.ToDouble(Productos.Rows[IDProducto]["Largo"]);
                        Medidas[2] = Convert.ToDouble(Productos.Rows[IDProducto]["Ancho"]);
                        Existencia = Convert.ToInt32(Productos.Rows[IDProducto]["Existencia"]);

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
