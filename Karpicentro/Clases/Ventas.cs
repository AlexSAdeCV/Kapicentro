﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karpicentro
{
    public class Venta
    {
        public int idproducto { get; set; }
        public double PrecioProducto { get; set; }
        public int idempleado { get; set; }
        public string Fecha { get; set; }
        public string Mensaje { get; set; }
        public int CantidadFintal { get; set; }
        public double preciofinal { get; set; }

        public bool VenderProducto()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"insert into Ventas values (@idproducto, @PrecioProducto, @idproveedor, @Fecha)";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@idproducto", idproducto);
                CMDSql.Parameters.AddWithValue("@PrecioProducto", preciofinal);
                CMDSql.Parameters.AddWithValue("@idproveedor", idempleado);
                CMDSql.Parameters.AddWithValue("@Fecha", Fecha);

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

        

        public int Extraer_Catidad(int id)
        {
            int cantidad = 0;
            DataTable Productos = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"select Existencia from Producto where IDProducto = idproducto";

                CmdSQL = new SqlCommand(Cadena, Conectar);
                CmdSQL.Parameters.AddWithValue("@idproducto", id);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(Productos);

                    if (Productos.Rows.Count > 0)
                    {
                        cantidad = Convert.ToInt32(Productos.Rows[id]["Existencia"]); 
                        return cantidad;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
                
            }
            return cantidad;
        }

        public bool Mod_Ex_PRO(int Existencia, int id)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;

                int filasafectadas;
                string sentencia = @"Update PRODUCTO set EXISTENCIA = @Existencia where IdPRODUCTO = @Id";
                cmdCreate = new SqlCommand(sentencia, conexion);

                cmdCreate.Parameters.AddWithValue("@Existencia", Existencia);
                cmdCreate.Parameters.AddWithValue("@Id", id);

                try
                {
                    conexion.Open();
                    filasafectadas = cmdCreate.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {
                        Mensaje = "Cantidad actualizada exitosamente";
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
