﻿using System;
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
    public class Empleado
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

                Cadena = @"Select Nombre + ' ' +ApellidoPaterno +  ' ' +ApellidoMaterno as Nombre, Telefono, Calle + ' ' + NoExterior + ' ' + CodigoPostal as Domicilio, Sueldo from Empleados";

                CmdSQL = new SqlCommand(Cadena, Conectar);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(Empleados);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

                Sentencia = @"insert into Empleados values (@Usuario, @Contrasena, @Puesto, @Sueldo, @Nombre, @PApellido, @SApellido, @Calle, @Telefono, @CP, @NExterior)";
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
                        MessageBox.Show("Empleado elimidado exitosamente");

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }



        public void ConstruirProducto()
        {
        }

        public void VenderProductos()
        {
        }

        public void HacerProductos()
        {
        }

        public void HacerCotizacion()
        {
        }
    }
}
