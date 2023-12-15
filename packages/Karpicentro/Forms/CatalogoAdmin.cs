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
    public partial class CatalogoAdmin : Form
    {
        int op;
        public CatalogoAdmin()
        {
            InitializeComponent();

            MostarCatalago();
            CargaComboMadera();
            Mostrar(1, false, Color.Gray);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);

            op = 1;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);

            op = 2;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Productos Pr = new Productos();
            int renglon;
            string id;

            switch (op)
            {
                case 1:
                    Pr.Nombre = TxtNombre.Text;
                    Pr.TipoMadera = Convert.ToInt32(CmbMadera.SelectedValue);
                    Pr.PrecioVenta = Convert.ToInt32(TxtPrecioVenta.Text);
                    Pr.Existencia = Convert.ToInt32(NupExistencia.Value);
                    Pr.Descripcion = TxtDescripcion.Text;
                    Pr.Medidas[0] = Convert.ToDouble(TxtAlto.Text);
                    Pr.Medidas[1] = Convert.ToDouble(TxtLargo.Text);
                    Pr.Medidas[2] = Convert.ToDouble(TxtAncho.Text);

                    if (ValidaCampos(1))
                    {
                        QuitarValidacion();
                        if (Pr.Insertar())
                        {
                            MessageBox.Show("Registro agregado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostarCatalago();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }
                    }
                    break;
                case 2:
                    renglon = DgvProductos.CurrentRow.Index;
                    id = DgvProductos.Rows[renglon].Cells[0].Value.ToString();
                    Pr.Nombre = TxtNombre.Text;
                    Pr.TipoMadera = Convert.ToInt32(CmbMadera.SelectedValue);
                    Pr.PrecioVenta = Convert.ToInt32(TxtPrecioVenta.Text);
                    Pr.Existencia = Convert.ToInt32(NupExistencia.Value);
                    Pr.IDProducto = Convert.ToInt32(id);

                    if (ValidaCampos(1))
                    {
                        QuitarValidacion();
                        if (Pr.Actualizar())
                        {
                            MessageBox.Show("Registro actualizado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostarCatalago();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }
                    }

                    break;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Productos pr = new Productos();
            int renglon;
            string id;

            renglon = DgvProductos.CurrentRow.Index;
            id = DgvProductos.Rows[renglon].Cells[0].Value.ToString();
            pr.IDProducto = Convert.ToInt32(id);

            DialogResult Resultado = MessageBox.Show("¿Desea elimar el registro " + id + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                if (pr.Eliminar())
                {
                    MessageBox.Show("Registro eliminado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostarCatalago();
                    HabilitaBotones();
                    Mostrar(1, false, Color.Gray);
                }
                else
                {
                    MessageBox.Show(pr.Mensaje);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Mostrar(1, false, Color.Gray);
            LimpiaCampos();
        }

        private void CargaComboMadera()
        {
            DataTable Almacen = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "Select * from Almacen";

                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapterLibros.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapterLibros.Fill(Almacen);
                    CmbMadera.DataSource = Almacen;
                    CmbMadera.DisplayMember = Almacen.Columns[1].ToString();
                    CmbMadera.ValueMember = Almacen.Columns[0].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        private bool ValidaCampos(int op)
        {
            bool valido = true;
            if (op == 1)
            {
                errorProvider1.SetError(TxtNombre, "Este campo no debe estar vacio");
                errorProvider1.SetError(TxtPrecioVenta, "Este campo no debe estar vacio");
            }
            return valido;
        }

        private void QuitarValidacion()
        {
            errorProvider1.SetError(TxtNombre, "");
            errorProvider1.SetError(TxtPrecioVenta, "");
        }

        private void MostarCatalago()
        {
            Productos productos = new Productos();

            DgvProductos.AutoSize = true;
            DgvProductos.DataSource = productos.MostrarProductos();
        }
    }
}
