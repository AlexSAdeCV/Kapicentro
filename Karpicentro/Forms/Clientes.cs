using CustomControls.RJControls;
using Karpicentro.Clases;
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
    public partial class Clientes : Form
    {
        int op;
        public Clientes()
        {
            InitializeComponent();
            MostrarClientes();
            Mostrar(1, false, Color.Gray);
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);

            op = 1;
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            int renglon;
            string id, idmad;

            renglon = DgvClientes.CurrentRow.Index;
            id = DgvClientes.Rows[renglon].Cells[0].Value.ToString();

            Mostrar(2, true, Color.White);

            DataTable Productos = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "Select * from Clientes where IDCliente = @id";
                cmdSelect = new SqlCommand(sentencia, conexion);
                cmdSelect.Parameters.AddWithValue("@id",Convert.ToInt32(id));

                try
                {
                    adapterLibros.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapterLibros.Fill(Productos);
                    TxtNombre.Text = Productos.Rows[0]["Nombre"].ToString();
                    TxtAP.Text = Productos.Rows[0]["ApellidoPaterno"].ToString();
                    TxtAM.Text = Productos.Rows[0]["ApellidoMaterno"].ToString();
                    TxtCalle.Text = Productos.Rows[0]["Calle"].ToString();
                    TxtDelegacion.Text = Productos.Rows[0]["Delegacion"].ToString();
                    TxtCP.Text = Productos.Rows[0]["CodigoPostal"].ToString();
                    TxtNE.Text = Productos.Rows[0]["NoExterior"].ToString();
                    TxtTelefono.Text = Productos.Rows[0]["Telefono"].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            op = 2;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            int renglon;
            string id;

            renglon = DgvClientes.CurrentRow.Index;
            id = DgvClientes.Rows[renglon].Cells[0].Value.ToString();
            cl.IDCliente = Convert.ToInt32(id);

            DialogResult Resultado = MessageBox.Show("¿Desea elimar el registro " + id + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                if (cl.Eliminar())
                {
                    MessageBox.Show("Registro eliminado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarClientes();
                    HabilitaBotones();
                    Mostrar(1, false, Color.Gray);
                }
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();

            int renglon;
            string id;

            if (ValidarCamposBlanco())
            {
                errorProvider1.Clear();
                switch (op)
                {
                    case 1:
                        cl.Nombre = TxtNombre.Text;
                        cl.PApellido = TxtAP.Text;
                        cl.MApellido = TxtAM.Text;
                        cl.Calle = TxtCalle.Text;
                        cl.Delegacion = TxtDelegacion.Text;
                        cl.Cp = TxtCP.Text;
                        cl.NoExterior = TxtNE.Text;
                        cl.Telefono = TxtTelefono.Text;

                        if (cl.Insertar())
                        {
                            MessageBox.Show("Registro agregado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarClientes();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }
                        break;
                    case 2:
                        renglon = DgvClientes.CurrentRow.Index;
                        id = DgvClientes.Rows[renglon].Cells[0].Value.ToString();
                        cl.IDCliente = Convert.ToInt32(id);
                        cl.Nombre = TxtNombre.Text;
                        cl.PApellido = TxtAP.Text;
                        cl.MApellido = TxtAM.Text;
                        cl.Calle = TxtCalle.Text;
                        cl.Delegacion = TxtDelegacion.Text;
                        cl.Cp = TxtCP.Text;
                        cl.NoExterior = TxtNE.Text;
                        cl.Telefono = TxtTelefono.Text;

                        if (cl.Actualizar())
                        {
                            MessageBox.Show("Registro modificado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarClientes();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }
                        break;
                }
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Mostrar(1, false, Color.Gray);
            LimpiaCampos();
            errorProvider1.Clear();
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


        private void MostrarClientes()
        {
            Cliente cl = new Cliente();

            //DgvAlmacen.AutoSize = true;
            DgvClientes.DataSource = cl.MostrarClientes();
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

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
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
    }
}
