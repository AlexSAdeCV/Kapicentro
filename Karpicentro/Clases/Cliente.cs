using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Karpicentro
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string PApellido { get; set; }
        public string MApellido { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string Cp { get; set; }
        public string Delegacion { get; set; }
        public string Colonia { get; set; }
        public int IDCliente { get; set; }
        public string Mensaje { get; set; }

        public bool Insertar()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"insert into Clientes values (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Telefono, @Calle, @NoExterior, @CodigoPostal, @Delegacion)";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@Nombre", Nombre);
                CMDSql.Parameters.AddWithValue("@ApellidoPaterno", PApellido);
                CMDSql.Parameters.AddWithValue("@ApellidoMaterno", MApellido);
                CMDSql.Parameters.AddWithValue("@Telefono", Telefono);
                CMDSql.Parameters.AddWithValue("@Calle", Calle);
                CMDSql.Parameters.AddWithValue("@NoExterior", NoExterior);
                CMDSql.Parameters.AddWithValue("@CodigoPostal", Cp);
                CMDSql.Parameters.AddWithValue("@Delegacion", Delegacion);

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

                Sentencia = @"update Clientes set Nombre = @Nombre,ApellidoPaterno = @ApellidoPaterno, ApellidoMaterno = @ApellidoMaterno, Telefono = @Telefono, Calle = @Calle, NoExterior = @NoExterior, CodigoPostal = @CodigoPostal, Delegacion = @Delegacion Where IDCliente = @IDCliente";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@Nombre", Nombre);
                CMDSql.Parameters.AddWithValue("@ApellidoPaterno", PApellido);
                CMDSql.Parameters.AddWithValue("@ApellidoMaterno", MApellido);
                CMDSql.Parameters.AddWithValue("@Telefono", Telefono);
                CMDSql.Parameters.AddWithValue("@Calle", Calle);
                CMDSql.Parameters.AddWithValue("@NoExterior", NoExterior);
                CMDSql.Parameters.AddWithValue("@CodigoPostal", Cp);
                CMDSql.Parameters.AddWithValue("@Delegacion", Delegacion);
                CMDSql.Parameters.AddWithValue("@IDCliente", IDCliente);

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

                Sentencia = @"delete from Clientes where IDCliente = @IDCliente";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@IDCliente", IDCliente);


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

        public DataTable MostrarClientes()
        {
            DataTable Almacen = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"select IDCliente, (Nombre + ' ' + ApellidoMaterno + ' ' + ApellidoMaterno) as 'Nombre Completo', Telefono, (Calle + ', ' + NoExterior + ', ' + CodigoPostal + ', ' + Delegacion) as Calle from Clientes";

                CmdSQL = new SqlCommand(Cadena, Conectar);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(Almacen);
                }
                catch (Exception ex)
                {
                    Mensaje = (ex.Message);
                }
            }

            return Almacen;
        }
    }
}
