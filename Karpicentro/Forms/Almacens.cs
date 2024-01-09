using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Karpicentro.Forms
{
    public partial class Almacens : Form
    {
        int op = 0;
        public Almacens()
        {
            InitializeComponent(); 

            MostrarAlmacen();
            Mostrar(1,false, Color.Gray);
            CargaProveedores();
        }

        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);


            op = 1;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int renglon;
            string id, idprov;

            renglon = DgvAlmacen.CurrentRow.Index;
            id = DgvAlmacen.Rows[renglon].Cells[0].Value.ToString();

            Mostrar(2, true, Color.White);

            DataTable Almacen = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "Select TipoMadera, Stock, precioparahacermueble from Almacen where IDAlmacen = @id";
                cmdSelect = new SqlCommand(sentencia, conexion);
                cmdSelect.Parameters.AddWithValue("@id", Convert.ToInt32(id));

                try
                {
                    adapterLibros.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapterLibros.Fill(Almacen);
                    TxtNombre.Text = Almacen.Rows[0]["TipoMadera"].ToString();
                    TxtStock.Text = Almacen.Rows[0]["Stock"].ToString();
                    TxtPrecio.Text = Almacen.Rows[0]["precioparahacermueble"].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            idprov = DgvAlmacen.Rows[renglon].Cells[5].Value.ToString();

            CmbProveedores.SelectedIndex = Convert.ToInt32(idprov) - 1;

            op = 2;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Almacen Al = new Almacen();
            int renglon;
            string id;

            renglon = DgvAlmacen.CurrentRow.Index;
            id = DgvAlmacen.Rows[renglon].Cells[0].Value.ToString();
            Al.idalmacen = Convert.ToInt32(id);

            DialogResult Resultado = MessageBox.Show("¿Desea elimar el registro " + id + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                if (Al.Eliminar())
                {
                    MessageBox.Show("Registro eliminado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarAlmacen();
                    HabilitaBotones();
                    Mostrar(1, false, Color.Gray);
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Almacen Al = new Almacen();
            int renglon;
            string id;

            if (ValidaCampos())
            {
                errorProvider1.Clear();
                switch (op)
                {
                    case 1:

                        Al.Nombre = TxtNombre.Text;
                        Al.CantidadMaterial = Convert.ToInt32(TxtStock.Text);
                        Al.Proveedor = Convert.ToInt32(CmbProveedores.SelectedValue);
                        Al.precio = Convert.ToDouble(TxtPrecio.Text);

                        if (Al.Insertar())
                        {
                            MessageBox.Show("Registro agregado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarAlmacen();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }

                        break;
                    case 2:
                        renglon = DgvAlmacen.CurrentRow.Index;
                        id = DgvAlmacen.Rows[renglon].Cells[0].Value.ToString();
                        Al.Nombre = TxtNombre.Text;
                        Al.CantidadMaterial = Convert.ToInt32(TxtStock.Text);
                        Al.Proveedor = Convert.ToInt32(CmbProveedores.SelectedValue);
                        Al.precio = Convert.ToDouble(TxtPrecio.Text);
                        Al.idalmacen = Convert.ToInt32(id);

                        if (Al.Modificar())
                        {
                            MessageBox.Show("Registro modificado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarAlmacen();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }
                        break;
                    case 3:
                        Al.Nombre = TxtNombre.Text;
                        Al.CantidadMaterial = Convert.ToInt32(TxtStock.Text);
                        Al.Proveedor = Convert.ToInt32(CmbProveedores.SelectedValue);
                        Al.precio = Convert.ToDouble(TxtPrecio.Text);
                        Al.idalmacen = Convert.ToInt32(textBox1.Text);

                        if (Al.Modificar())
                        {
                            MessageBox.Show("Registro modificado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarAlmacen();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }

                        textBox1.Text = "";
                        break;
                }
            }
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Mostrar(1, false, Color.Gray);
            LimpiaCampos();
            textBox1.Text = "";
            errorProvider1.Clear();
            CmbProveedores.SelectedIndex = 0;
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


        private void MostrarAlmacen()
        {
            Almacen almacen = new Almacen();

            DgvAlmacen.AutoSize = true;
            DgvAlmacen.DataSource = almacen.MostrarAlmacen();
            DgvAlmacen.Columns[5].Visible = false;
        }

        private void CargaProveedores()
        {
            DataTable Almacen = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "Select * from Proveedor";

                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapterLibros.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapterLibros.Fill(Almacen);
                    CmbProveedores.DataSource = Almacen;
                    CmbProveedores.DisplayMember = Almacen.Columns[1].ToString();
                    CmbProveedores.ValueMember = Almacen.Columns[0].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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
                    string id, idprov;

                    renglon = DgvAlmacen.CurrentRow.Index;
                    id = DgvAlmacen.Rows[renglon].Cells[0].Value.ToString();

                    Mostrar(2, true, Color.White);

                    DataTable Almacen = new DataTable();

                    using (SqlConnection conexion = Conexion.Conectar())
                    {
                        SqlCommand cmdSelect;
                        SqlDataAdapter adapterLibros = new SqlDataAdapter();

                        string sentencia = "Select TipoMadera, Stock, precioparahacermueble, idprov from Almacen where IDAlmacen = @id";
                        cmdSelect = new SqlCommand(sentencia, conexion);
                        cmdSelect.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));

                        try
                        {
                            adapterLibros.SelectCommand = cmdSelect;
                            conexion.Open();
                            adapterLibros.Fill(Almacen);
                            TxtNombre.Text = Almacen.Rows[0]["TipoMadera"].ToString();
                            TxtStock.Text = Almacen.Rows[0]["Stock"].ToString();
                            TxtPrecio.Text = Almacen.Rows[0]["precioparahacermueble"].ToString();
                            CmbProveedores.SelectedIndex = (Int32)Almacen.Rows[0]["precioparahacermueble"] - 1;

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

        private int EncontrarIDMax()
        {
            int Idp = 0;

            DataTable Productos = new DataTable();
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "select MAX(IDAlmacen) as id from Almacen";
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
