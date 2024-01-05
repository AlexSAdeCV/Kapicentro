using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Karpicentro.Clases
{
    internal class Empleadoo
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public int Puesto { get; set; }
        public double Sueldo { get; set; }

        public string Nombre { get; set; }
        public string PApellido { get; set; }
        public string SApellido { get; set; }

        public string Calle { get; set; }
        public string Telefono { get; set; }
        public string CP { get; set; }
        public string NExterior { get; set; }

        public string Mensaje { get; set; }


        public DataTable MostrarEmpleados()
        {
            DataTable Empleados = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"Select IDEmpleado, Nombre + ' ' +ApellidoPaterno +  ' ' +ApellidoMaterno as Nombre, Telefono, Calle + ' ' + NoExterior + ' ' + CodigoPostal as Domicilio, Sueldo, Identificacion as Puesto, Puesto as idpuesto from Empleados inner join Puestos on idpuesto = Puesto";

                CmdSQL = new SqlCommand(Cadena, Conectar);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(Empleados);
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }

            return Empleados;
        }

        public bool InsertarEmpleado()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"insert into Empleados values (@Usuario, @Contrasena, @Puesto, @Nombre, @PApellido, @SApellido, @Telefono, @Calle, @NExterior, @CP, @Sueldo)";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@Usuario", Usuario);
                CMDSql.Parameters.AddWithValue("@Contrasena", Contrasena);
                CMDSql.Parameters.AddWithValue("@Puesto", Puesto);
                CMDSql.Parameters.AddWithValue("@Sueldo", Sueldo);
                CMDSql.Parameters.AddWithValue("@Nombre", Nombre);
                CMDSql.Parameters.AddWithValue("@PApellido", PApellido);
                CMDSql.Parameters.AddWithValue("@SApellido", SApellido);
                CMDSql.Parameters.AddWithValue("@Calle", Calle);
                CMDSql.Parameters.AddWithValue("@Telefono", Telefono);
                CMDSql.Parameters.AddWithValue("@CP", CP);
                CMDSql.Parameters.AddWithValue("@NExterior", NExterior);

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

        public bool Actualizar(int i)
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"update Empleados set usuario = @Usuario, Contraseña = @Contrasena, idpuesto = @Puesto, Sueldo = @Sueldo, Nombre = @Nombre, ApellidoPaterno = @PApellido, ApellidoMaterno = @SApellido, Calle = @Calle, Telefono = @Telefono, CodigoPostal =  @CP, NoExterior = @NExterior Where IDEmpleado = @IDEmpleado";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@Usuario", Usuario);
                CMDSql.Parameters.AddWithValue("@Contrasena", Contrasena);
                CMDSql.Parameters.AddWithValue("@Puesto", Puesto);
                CMDSql.Parameters.AddWithValue("@Sueldo", Sueldo);
                CMDSql.Parameters.AddWithValue("@Nombre", Nombre);
                CMDSql.Parameters.AddWithValue("@PApellido", PApellido);
                CMDSql.Parameters.AddWithValue("@SApellido", SApellido);
                CMDSql.Parameters.AddWithValue("@Calle", Calle);
                CMDSql.Parameters.AddWithValue("@Telefono", Telefono);
                CMDSql.Parameters.AddWithValue("@CP", CP);
                CMDSql.Parameters.AddWithValue("@NExterior", NExterior);
                CMDSql.Parameters.AddWithValue("@IDEmpleado", i);

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

        public bool Eliminar_Tabla(int i)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                int filasafectadas;
                string sentencia = @"delete from Empleados where IDEmpleado = @id";
                cmdCreate = new SqlCommand(sentencia, conexion);
                cmdCreate.Parameters.AddWithValue("@id", Convert.ToString(i));
                try
                {
                    conexion.Open();
                    filasafectadas = cmdCreate.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return false;
        }
    }
}
