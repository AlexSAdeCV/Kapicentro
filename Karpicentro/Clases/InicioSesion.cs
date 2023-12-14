using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using System.Windows.Forms;

namespace Karpicentro
{
    internal class InicioSesion
    {
        public static int Nivel { get; set; }
        public static int UsuarioF { get; set; }
        public static string Usuario { get; set; }

        public static bool IniciaSesion(string Usuario, string Contaseña)
        {
            DataTable UsuariosDT = new DataTable();
            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"Select * from Empleados where Usuario = @idusuario and Contraseña = @contra";

                CmdSQL = new SqlCommand(Cadena, Conectar);

                CmdSQL.Parameters.AddWithValue("@idusuario", Usuario);
                CmdSQL.Parameters.AddWithValue("@contra", Contaseña);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(UsuariosDT);

                    if (UsuariosDT.Rows.Count > 0)
                    {
                        Nivel = Convert.ToInt32(UsuariosDT.Rows[0]["idpuesto"]);
                        UsuarioF = Convert.ToInt32(UsuariosDT.Rows[0]["IDEmpleado"]);
                        Usuario = UsuariosDT.Rows[0]["Nombre"].ToString();

                        return true;
                    }
                    else
                        MessageBox.Show("Usuario y/p Contraseña son invalidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }
    }
}
