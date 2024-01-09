using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karpicentro.Forms
{
    public partial class Proveedores : Form
    {
        int op;

        public Proveedores()
        {
            InitializeComponent();

            MostrarProveedor();
            Mostrar(1, false, Color.Gray);
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

        public void Mostrar(int s, bool tf, Color color)
        {
            foreach (Control c in this.Pnlinserstar.Controls)
            {
                c.Enabled = tf;
                if (c is TextBox)
                {
                    c.BackColor = color;
                }
                if (c is Button)
                {
                    if (tf == true)
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
                    BtnGuardar.Enabled = false;
                    BtnCancelar.Enabled = false;

                    break;
                case 2:
                    BtnGuardar.Enabled = true;
                    BtnCancelar.Enabled = true;
                    break;
            }

        }

        private bool ValidaCampos()
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

        private void QuitarValidacion()
        {
            errorProvider1.SetError(TxtNombre, "");
            errorProvider1.SetError(TxtDelegacion, "");
            errorProvider1.SetError(TxtColonia, "");
            errorProvider1.SetError(TxtCP, "");
            errorProvider1.SetError(TxtTelefono, "");
            errorProvider1.SetError(TxtPContacto, "");
        }
        private void MostrarProveedor()
        {
            Proveedor proveedor = new Proveedor();

            //DgvProveedor.AutoSize = true;
            DgvProveedor.DataSource = proveedor.MostrarProveedores();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);

            op = 1;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Proveedor Pv = new Proveedor();
            int renglon;
            string id;

            if (ValidaCampos())
            {
                errorProvider1.Clear();

                switch (op)
                {
                    case 1:
                        Pv.Nombre = TxtNombre.Text;
                        Pv.Delegacion = TxtDelegacion.Text;
                        Pv.Colonia = TxtColonia.Text;
                        Pv.Calle = TxtCalle.Text;
                        Pv.Cp = TxtCP.Text;
                        Pv.Telefono = TxtTelefono.Text;
                        Pv.PContacto = TxtPContacto.Text;

                        if (Pv.AgregarProveedor())
                        {
                            MessageBox.Show("Registro agregado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarProveedor();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }


                        break;
                    case 2:
                        renglon = DgvProveedor.CurrentRow.Index;
                        id = DgvProveedor.Rows[renglon].Cells[0].Value.ToString();
                        Pv.IDProveedor = Convert.ToInt32(id);
                        Pv.Nombre = TxtNombre.Text;
                        Pv.Delegacion = TxtDelegacion.Text;
                        Pv.Colonia = TxtColonia.Text;
                        Pv.Calle = TxtCalle.Text;
                        Pv.Cp = TxtCP.Text;
                        Pv.Telefono = TxtTelefono.Text;
                        Pv.PContacto = TxtPContacto.Text;

                        if (Pv.ModificarProveedor())
                        {
                            MessageBox.Show("Registro modificado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarProveedor();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }
                        break;
                    case 3:
                        Pv.IDProveedor = Convert.ToInt32(textBox1.Text);
                        Pv.Nombre = TxtNombre.Text;
                        Pv.Delegacion = TxtDelegacion.Text;
                        Pv.Colonia = TxtColonia.Text;
                        Pv.Calle = TxtCalle.Text;
                        Pv.Cp = TxtCP.Text;
                        Pv.Telefono = TxtTelefono.Text;
                        Pv.PContacto = TxtPContacto.Text;

                        if (Pv.ModificarProveedor())
                        {
                            MessageBox.Show("Registro modificado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarProveedor();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }

                        textBox1.Text = "";
                        break;
                }

            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int renglon;
            string id, idmad;

            renglon = DgvProveedor.CurrentRow.Index;
            id = DgvProveedor.Rows[renglon].Cells[0].Value.ToString();

            Mostrar(2, true, Color.White);

            DataTable Productos = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "Select * from Proveedor where IDProveedor = @id";
                cmdSelect = new SqlCommand(sentencia, conexion);
                cmdSelect.Parameters.AddWithValue("@id", Convert.ToInt32(id));

                try
                {
                    adapterLibros.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapterLibros.Fill(Productos);
                    TxtNombre.Text = Productos.Rows[0]["NombreProv"].ToString();
                    TxtCalle.Text = Productos.Rows[0]["Calle"].ToString();
                    TxtDelegacion.Text = Productos.Rows[0]["Delegacion"].ToString();
                    TxtColonia.Text = Productos.Rows[0]["Colonia"].ToString();
                    TxtCP.Text = Productos.Rows[0]["C_Postal"].ToString();
                    TxtTelefono.Text = Productos.Rows[0]["Telefono"].ToString();
                    TxtPContacto.Text = Productos.Rows[0]["PersonaContacto"].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            op = 2;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Proveedor pv = new Proveedor();
            int renglon;
            string id;

            renglon = DgvProveedor.CurrentRow.Index;
            id = DgvProveedor.Rows[renglon].Cells[0].Value.ToString();
            pv.IDProveedor = Convert.ToInt32(id);

            DialogResult Resultado = MessageBox.Show("¿Desea elimar el registro " + id + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                DialogResult Resultad2 = MessageBox.Show("¿Si quiere eliminar a este proveedor debe elimnar los registros del almacen ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultad2 == DialogResult.Yes)
                {
                    if (pv.EliminarRegAlmacen())
                    {
                        if (pv.Eliminar())
                        {
                            MessageBox.Show("Registro eliminado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarProveedor();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }
                    }
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Mostrar(1, false, Color.Gray);
            LimpiaCampos();
            textBox1.Text = "";
            errorProvider1.Clear();
        }

        private void TxtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
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
                    string id, idmad;

                    renglon = DgvProveedor.CurrentRow.Index;
                    id = DgvProveedor.Rows[renglon].Cells[0].Value.ToString();

                    Mostrar(2, true, Color.White);

                    DataTable Productos = new DataTable();

                    using (SqlConnection conexion = Conexion.Conectar())
                    {
                        SqlCommand cmdSelect;
                        SqlDataAdapter adapterLibros = new SqlDataAdapter();

                        string sentencia = "Select * from Proveedor where IDProveedor = @id";
                        cmdSelect = new SqlCommand(sentencia, conexion);
                        cmdSelect.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));

                        try
                        {
                            adapterLibros.SelectCommand = cmdSelect;
                            conexion.Open();
                            adapterLibros.Fill(Productos);
                            TxtNombre.Text = Productos.Rows[0]["NombreProv"].ToString();
                            TxtCalle.Text = Productos.Rows[0]["Calle"].ToString();
                            TxtDelegacion.Text = Productos.Rows[0]["Delegacion"].ToString();
                            TxtColonia.Text = Productos.Rows[0]["Colonia"].ToString();
                            TxtCP.Text = Productos.Rows[0]["C_Postal"].ToString();
                            TxtTelefono.Text = Productos.Rows[0]["Telefono"].ToString();
                            TxtPContacto.Text = Productos.Rows[0]["PersonaContacto"].ToString();

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

                string sentencia = "select MAX(IDProveedor) as id from Proveedor";
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
    }
}
