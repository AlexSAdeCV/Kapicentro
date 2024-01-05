using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karpicentro
{
    public class Proveedor
    {
        public int IDProveedor { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Delegacion { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string Cp { get; set; }
        public string PContacto { get; set; }
        public string Mensaje { get; set; }

        public bool AgregarProveedor()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;
                Sentencia = @"insert into Proveedor values (@NombreProv, @Colonia, @Delegacion, @Calle, @C_Postal, @Telefono, @PersonaContacto)";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@NombreProv", Nombre);
                CMDSql.Parameters.AddWithValue("@Colonia", Colonia);
                CMDSql.Parameters.AddWithValue("@Delegacion", Delegacion);
                CMDSql.Parameters.AddWithValue("@Calle", Calle);
                CMDSql.Parameters.AddWithValue("@C_Postal", Cp);
                CMDSql.Parameters.AddWithValue("@Telefono", Telefono);
                CMDSql.Parameters.AddWithValue("@PersonaContacto", PContacto);

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

        public bool ModificarProveedor()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;
                Sentencia = @"update Proveedor set NombreProv = @NombreProv, Colonia = @Colonia, Delegacion = @Delegacion, Calle = @Calle, C_Postal = @C_Postal, Telefono = @Telefono, PersonaContacto = @PersonaContacto where IDProveedor =  @IDProveedor";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@NombreProv", Nombre);
                CMDSql.Parameters.AddWithValue("@Colonia", Colonia);
                CMDSql.Parameters.AddWithValue("@Delegacion", Delegacion);
                CMDSql.Parameters.AddWithValue("@Calle", Calle);
                CMDSql.Parameters.AddWithValue("@C_Postal", Cp);
                CMDSql.Parameters.AddWithValue("@Telefono", Telefono);
                CMDSql.Parameters.AddWithValue("@PersonaContacto", PContacto);
                CMDSql.Parameters.AddWithValue("@IDProveedor", IDProveedor);

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

                Sentencia = @"delete from Proveedor where IDProveedor = @IDProveedor";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@IDProveedor", IDProveedor);


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

        public DataTable MostrarProveedores()
        {
            DataTable Proveedores = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"Select * from Proveedor";

                CmdSQL = new SqlCommand(Cadena, Conectar);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(Proveedores);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return Proveedores;
        }

        public DataTable Obtenerid()
        {
            DataTable Proveedores = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"Select * from Almacen where idprov = @IDProveedor";

                CmdSQL = new SqlCommand(Cadena, Conectar);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(Proveedores);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return Proveedores;
        }



        public bool EliminarRegAlmacen()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"delete from Almacen where idprov = @IDProveedor";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@IDProveedor", IDProveedor);


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
    }
}
