using CustomControls.RJControls;
using Karpicentro.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karpicentro;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Annotations;
using RJCodeAdvance.RJControls;

namespace Karpicentro.Forms
{
    public partial class Empleados : Form
    {
        Empleadoo empleado = new Empleadoo();
        int op;
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
            Mostrar(1,false,Color.Gray);
            CargaIDpuesto();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);
            op = 1;
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (DgvEmpleados.Rows.Count < 0)
            {
                MessageBox.Show($"Debe de seleccionar un registro primero", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int renglon;
                string id, idpuesto;

                renglon = DgvEmpleados.CurrentRow.Index;
                id = DgvEmpleados.Rows[renglon].Cells[0].Value.ToString();

                Mostrar(2, true, Color.White);

                DataTable Productos = new DataTable();

                using (SqlConnection conexion = Conexion.Conectar())
                {
                    SqlCommand cmdSelect;
                    SqlDataAdapter adapterLibros = new SqlDataAdapter();

                    string sentencia = "Select usuario, Contraseña, Nombre, ApellidoPaterno, ApellidoMaterno, Telefono, Calle, NoExterior, CodigoPostal, Sueldo from Empleados where IDEmpleado = @id";
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@id", Convert.ToInt32(id));

                    try
                    {
                        adapterLibros.SelectCommand = cmdSelect;
                        conexion.Open();
                        adapterLibros.Fill(Productos);
                        TxtUsuario.Text = Productos.Rows[0]["usuario"].ToString();
                        TxtContrasena.Text = Productos.Rows[0]["Contraseña"].ToString();
                        TxtNombre.Text = Productos.Rows[0]["Nombre"].ToString();
                        TxtAP.Text = Productos.Rows[0]["ApellidoPaterno"].ToString();
                        TxtAM.Text = Productos.Rows[0]["ApellidoMaterno"].ToString();
                        TxtTelefono.Text = Productos.Rows[0]["Telefono"].ToString();
                        TxtCalle.Text = Productos.Rows[0]["Calle"].ToString();
                        TxtNE.Text = Productos.Rows[0]["NoExterior"].ToString();
                        TxtCP.Text = Productos.Rows[0]["CodigoPostal"].ToString();
                        TxtSueldo.Text = Productos.Rows[0]["Sueldo"].ToString();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if ((Int32)DgvEmpleados.Rows[renglon].Cells[6].Value == 1)
                    CmbIDPuesto.Text = "Administrador";
                else
                    CmbIDPuesto.SelectedIndex = 1;

                op = 2;
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            int RenglonSeleccionado = DgvEmpleados.CurrentRow.Index;
            int Id = Convert.ToInt32(DgvEmpleados.Rows[RenglonSeleccionado].Cells[0].Value.ToString());
            DialogResult Resultado = MessageBox.Show("¿Desea eliminar al Empleado con Id " + Id + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                empleado.Eliminar_Tabla(Id);
                MostrarEmpleados();
                HabilitaBotones();
                Mostrar(1, false, Color.Gray);
            }
            Mostrar(1, false, Color.Gray);
        }

        public void Mostrar(int s,bool tf,Color color)
        {
            foreach(Control c in this.Pnlinserstar.Controls)
            {
                c.Enabled = tf;
                if (c is TextBox || c is ComboBox )
                {
                    c.BackColor = color;
                    c.Text = "";
                    CmbIDPuesto.BackColor = color;

                }
                if(c is Button)
                {
                    if(tf == true)
                    {
                        c.Enabled = false;
                    }
                    else
                    {
                        c.Enabled = true;
                    }    
                }
            }

            switch (s)
            {
                case 1:
                    Btn_Guardar.Enabled = false;
                    Btn_Cancelar.Enabled = false;
                    
                    break;
                case 2:
                    Btn_Guardar.Enabled= true;
                    Btn_Cancelar.Enabled = true;
                    break;
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            int renglon;
            string id;

            if (ValidarCamposBlanco())
            {
                errorProvider1.Clear();
                switch (op)
                {
                    case 1:
                        empleado.Usuario = TxtUsuario.Text;
                        empleado.Contrasena = TxtContrasena.Text;
                        empleado.Puesto = Convert.ToInt32(CmbIDPuesto.SelectedIndex.ToString()) + 1;
                        empleado.Sueldo = Convert.ToDouble(TxtSueldo.Text);

                        empleado.Nombre = TxtNombre.Text;
                        empleado.PApellido = TxtAP.Text;
                        empleado.SApellido = TxtAM.Text;

                        empleado.Calle = TxtCalle.Text;
                        empleado.Telefono = TxtTelefono.Text;
                        empleado.CP = TxtCP.Text;
                        empleado.NExterior = TxtNE.Text;

                        if (empleado.InsertarEmpleado())
                        {
                            MessageBox.Show("Registro agregado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarEmpleados();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }
                        break;
                    case 2:
                        renglon = DgvEmpleados.CurrentRow.Index;
                        id = DgvEmpleados.Rows[renglon].Cells[0].Value.ToString();
                        empleado.Usuario = TxtUsuario.Text;
                        empleado.Contrasena = TxtContrasena.Text;
                        empleado.Puesto = Convert.ToInt32(CmbIDPuesto.SelectedIndex.ToString()) + 1;
                        empleado.Sueldo = Convert.ToDouble(TxtSueldo.Text);

                        empleado.Nombre = TxtNombre.Text;
                        empleado.PApellido = TxtAP.Text;
                        empleado.SApellido = TxtAM.Text;

                        empleado.Calle = TxtCalle.Text;
                        empleado.Telefono = TxtTelefono.Text;
                        empleado.CP = TxtCP.Text;
                        empleado.NExterior = TxtNE.Text;

                        if (empleado.Actualizar(Convert.ToInt32(id)))
                        {
                            MessageBox.Show("Registro modificado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarEmpleados();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }
                        break;
                    case 3:
                        empleado.Usuario = TxtUsuario.Text;
                        empleado.Contrasena = TxtContrasena.Text;
                        empleado.Puesto = Convert.ToInt32(CmbIDPuesto.SelectedIndex.ToString()) + 1;
                        empleado.Sueldo = Convert.ToDouble(TxtSueldo.Text);

                        empleado.Nombre = TxtNombre.Text;
                        empleado.PApellido = TxtAP.Text;
                        empleado.SApellido = TxtAM.Text;

                        empleado.Calle = TxtCalle.Text;
                        empleado.Telefono = TxtTelefono.Text;
                        empleado.CP = TxtCP.Text;
                        empleado.NExterior = TxtNE.Text;

                        if (empleado.Actualizar(Convert.ToInt32(textBox1.Text)))
                        {
                            MessageBox.Show("Registro modificado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarEmpleados();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }

                        textBox1.Text = "";
                        break;
                }
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Mostrar(1, false, Color.Gray);
            LimpiaCampos();
            textBox1.Text = "";
            errorProvider1.Clear();
            CmbIDPuesto.SelectedIndex = 0;
        }

        //Metodos
        private void MostrarEmpleados()
        {
            //DgvAlmacen.AutoSize = true;
            DgvEmpleados.DataSource = empleado.MostrarEmpleados();
            DgvEmpleados.Columns[6].Visible = false;
        }
        private bool ValidarCamposBlanco()
        {
            bool valido = true;
            foreach (Control c in Pnlinserstar.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text.Length <= 0)
                    {
                        errorProvider1.SetError(c, "Campo no puede estar en blanco");
                        valido = false;
                    }
                }
            }
            return valido;
        }

        private void LimpiaCampos()
        {
            foreach (Control c in Pnlinserstar.Controls)
            {
                if (c is TextBox)
                {
                    TextBox x;
                    x = (TextBox)c;
                    x.Clear();
                }
            }
        }

        private void HabilitaBotones()
        {
            foreach (Control b in Pnlinserstar.Controls)
            {
                if (b is Button)
                {
                    b.Enabled = true;
                }
            }
        }

        private void Txt_CP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void Txt_NE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void Txt_Sueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void CargaIDpuesto()
        {
            DataTable Almacen = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "Select * from Puestos";

                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapterLibros.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapterLibros.Fill(Almacen);
                    CmbIDPuesto.DataSource = Almacen;
                    CmbIDPuesto.DisplayMember = Almacen.Columns[1].ToString();
                    CmbIDPuesto.ValueMember = Almacen.Columns[0].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidaCamposBuscar())
            {
                if (Convert.ToInt32(textBox1.Text) > EncontrarIDMax())
                {
                    MessageBox.Show($"No Existe el registro {textBox1.Text}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                }
                else
                {
                    errorProvider1.Clear();
                    int renglon;
                    string id;

                    renglon = DgvEmpleados.CurrentRow.Index;
                    id = DgvEmpleados.Rows[renglon].Cells[0].Value.ToString();

                    Mostrar(2, true, Color.White);

                    DataTable Productos = new DataTable();

                    using (SqlConnection conexion = Conexion.Conectar())
                    {
                        SqlCommand cmdSelect;
                        SqlDataAdapter adapterLibros = new SqlDataAdapter();

                        string sentencia = "Select usuario, Contraseña, Nombre, ApellidoPaterno, ApellidoMaterno, Telefono, Calle, NoExterior, CodigoPostal, Sueldo, idpuesto from Empleados where IDEmpleado = @id";
                        cmdSelect = new SqlCommand(sentencia, conexion);
                        cmdSelect.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));

                        try
                        {
                            adapterLibros.SelectCommand = cmdSelect;
                            conexion.Open();
                            adapterLibros.Fill(Productos);
                            TxtUsuario.Text = Productos.Rows[0]["usuario"].ToString();
                            TxtContrasena.Text = Productos.Rows[0]["Contraseña"].ToString();
                            TxtNombre.Text = Productos.Rows[0]["Nombre"].ToString();
                            TxtAP.Text = Productos.Rows[0]["ApellidoPaterno"].ToString();
                            TxtAM.Text = Productos.Rows[0]["ApellidoMaterno"].ToString();
                            TxtTelefono.Text = Productos.Rows[0]["Telefono"].ToString();
                            TxtCalle.Text = Productos.Rows[0]["Calle"].ToString();
                            TxtNE.Text = Productos.Rows[0]["NoExterior"].ToString();
                            TxtCP.Text = Productos.Rows[0]["CodigoPostal"].ToString();
                            TxtSueldo.Text = Productos.Rows[0]["Sueldo"].ToString();
                            CmbIDPuesto.SelectedIndex = (Int32)Productos.Rows[0]["idpuesto"] - 1;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    op = 3;
                }
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private bool ValidaCamposBuscar()
        {
            bool valido = true;
            if (textBox1.Text.Length <= 0)
            {
                errorProvider1.SetError(textBox1, "Campo no puede estar en blanco");
                valido = false;
            }
            return valido;
        }

        private int EncontrarIDMax()
        {
            int Idp = 0;

            DataTable Productos = new DataTable();
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "select MAX(IDEmpleado) as id from Empleados";
                cmdSelect = new SqlCommand(sentencia, conexion);

                try
                {
                    adapterLibros.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapterLibros.Fill(Productos);

                    string temporal = Productos.Rows[0]["id"].ToString();

                    if (temporal == "")
                        Idp = 1;
                    else
                        Idp = (Int32)Productos.Rows[0]["id"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return Idp;
        }

        private bool ValidaCamposModificar()
        {
            bool valido = true;
            if (textBox1.Text.Length <= 0)
            {
                errorProvider1.SetError(textBox1, "Campo no puede estar en blanco");
                valido = false;
            }
            return valido;
        }
    }
}
