using Karpicentro.Clases;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Karpicentro.Forms
{
    public partial class CatalogoAdmin : Form
    {
        int op, idp;

        public CatalogoAdmin()
        {
            InitializeComponent();

            MostarCatalago();
            CargaComboMadera();
            Mostrar(1, false, Color.DarkGray);
            PcbImagen.Visible = false;
            BtnSeleccionar.Visible = false;
            LblID.Visible = false;  
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            OfdImagen.Filter = "Imagenes| *.jpg; *.png";
            OfdImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            OfdImagen.Title = "Elija Imagen";

            if (ValidaCampos())
            {
                if (OfdImagen.ShowDialog() == DialogResult.OK)
                {
                    PcbImagen.Visible = true;
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);

            idp = EncontrarIDMax();

            LblID.Visible = true;
            LblID.Text = $"ID: {idp}";

            op = 1;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int renglon;
            string id, idmad;

            renglon = DgvProductos.CurrentRow.Index;
            id = DgvProductos.Rows[renglon].Cells[0].Value.ToString();

            Mostrar(2, true, Color.White);

            DataTable Productos = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "Select * from Producto where IDProducto = @id";
                cmdSelect = new SqlCommand(sentencia, conexion);
                cmdSelect.Parameters.AddWithValue("@id",Convert.ToInt32(id));

                try
                {
                    adapterLibros.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapterLibros.Fill(Productos);
                    LblID.Visible = true;
                    LblID.Text = $"ID: {Productos.Rows[0]["IDProducto"].ToString()}";
                    TxtNombre.Text = Productos.Rows[0]["Nombre"].ToString();
                    TxtPrecioVenta.Text = Productos.Rows[0]["PrecioV"].ToString();
                    TxtDescripcion.Text = Productos.Rows[0]["Descripcion"].ToString();
                    TxtAlto.Text = Productos.Rows[0]["Alto"].ToString();
                    TxtLargo.Text = Productos.Rows[0]["Largo"].ToString();
                    TxtAncho.Text = Productos.Rows[0]["Ancho"].ToString();
                    MemoryStream ms = new MemoryStream((Byte[])Productos.Rows[0]["Imagen"]);
                    Bitmap bm = new Bitmap(ms);
                    PcbImagen.Visible = true;
                    PcbImagen.Image = bm;
                    NupExistencia.Value = (Int32)Productos.Rows[0]["Existencia"];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            idmad = DgvProductos.Rows[renglon].Cells[5].Value.ToString();

            CmbMadera.SelectedIndex = Convert.ToInt32(idmad) - 1;

            op = 2;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Productos Pr = new Productos();
            MemoryStream ms = new MemoryStream();
            int renglon;
            string id;

            if (ValidaCampos())
            {
                errorProvider1.Clear();
                switch (op)
                {
                    case 1:
                        Pr.IDProducto = idp;
                        Pr.Nombre = TxtNombre.Text;
                        Pr.TipoMadera = Convert.ToInt32(CmbMadera.SelectedValue);
                        Pr.PrecioVenta = Convert.ToInt32(TxtPrecioVenta.Text);
                        Pr.Existencia = Convert.ToInt32(NupExistencia.Value);
                        Pr.Descripcion = TxtDescripcion.Text;
                        Pr.Medidas[0] = Convert.ToDouble(TxtAlto.Text);
                        Pr.Medidas[1] = Convert.ToDouble(TxtLargo.Text);
                        Pr.Medidas[2] = Convert.ToDouble(TxtAncho.Text);
                        PcbImagen.Image.Save(ms, ImageFormat.Jpeg);
                        Pr.Imagen = ms.ToArray();

                        if (Pr.Insertar())
                        {
                            MessageBox.Show("Registro agregado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostarCatalago();
                            HabilitaBotones();
                            PicBox(1);
                            Mostrar(1, false, Color.Gray);
                            PcbImagen.Image = null;
                            LblID.Visible = false;
                        }
                        break;
                    case 2:
                        renglon = DgvProductos.CurrentRow.Index;
                        id = DgvProductos.Rows[renglon].Cells[0].Value.ToString();
                        Pr.Nombre = TxtNombre.Text;
                        Pr.TipoMadera = Convert.ToInt32(CmbMadera.SelectedValue);
                        Pr.PrecioVenta = Convert.ToDouble(TxtPrecioVenta.Text);
                        Pr.Descripcion = TxtDescripcion.Text;
                        Pr.Medidas[0] = Convert.ToDouble(TxtAlto.Text);
                        Pr.Medidas[1] = Convert.ToDouble(TxtLargo.Text);
                        Pr.Medidas[2] = Convert.ToDouble(TxtAncho.Text);
                        PcbImagen.Image.Save(ms, ImageFormat.Jpeg);
                        Pr.Imagen = ms.ToArray();
                        Pr.Existencia = Convert.ToInt32(NupExistencia.Value);
                        Pr.IDProducto = Convert.ToInt32(id);

                        if (Pr.Actualizar())
                        {
                            MessageBox.Show("Registro actualizado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostarCatalago();
                            HabilitaBotones();
                            PicBox(1);
                            Mostrar(1, false, Color.Gray);
                        }
                        break;
                }

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
            PicBox(1);
            LblID.Visible = false;
            errorProvider1.Clear();
            CmbMadera.SelectedIndex = 0;
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
                if (c is PictureBox)
                {
                    PictureBox x;
                    x = (PictureBox)c;
                    x.Image = null; 
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown x;
                    x = (NumericUpDown)c;
                    x.Value = 0;
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

                    BtnGuardar.BackColor = Color.DarkGray;
                    BtnCancelar.BackColor = Color.DarkGray;

                    BtnAgregar.BackColor = Color.White;
                    BtnModificar.BackColor = Color.White;
                    BtnEliminar.BackColor = Color.White;
                    break;
                case 2:
                    BtnGuardar.Enabled = true;
                    BtnCancelar.Enabled = true;

                    BtnGuardar.BackColor = Color.White;
                    BtnCancelar.BackColor = Color.White;

                    BtnAgregar.BackColor = Color.DarkGray;
                    BtnModificar.BackColor = Color.DarkGray;
                    BtnEliminar.BackColor = Color.DarkGray;
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

        private void MostarCatalago()
        {
            Productos productos = new Productos();

            DgvProductos.AutoSize = true;
            DgvProductos.DataSource = productos.MostrarProductos();
            DgvProductos.Columns[5].Visible = false;
        }

        private void TxtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true; 
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf(".") > -1) //aqui nos detecta el punto decimal; lo del sender as text box nos sirve para detectar todas la textbox pero es necesario pasar el codigo al evento de la textbox
                e.Handled = true;
        }

        private void TxtAlto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void TxtLargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void TxtAncho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void NupExistencia_ValueChanged(object sender, EventArgs e)
        {
            PicBox(2);
        }

        private void PicBox(int op)
        {
            switch (op)
            {
                case 1:
                    BtnSeleccionar.Enabled = false;
                    BtnSeleccionar.Visible = false;
                    break; 
                case 2:
                    BtnSeleccionar.Enabled = true;
                    BtnSeleccionar.Visible = true;
                    break;
            }
        }

        private void OfdImagen_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                Image img = Image.FromFile(OfdImagen.FileName);

                errorProvider1.Clear();
                PcbImagen.Image = img;
            }
            catch (OutOfMemoryException ex)
            {
                string Mensaje = "No se pudo cargar la imagen. Posiblemente sea demasiado grande.";

                errorProvider1.SetError(BtnSeleccionar, Mensaje);
            }
        }

        private int EncontrarIDMax()
        {
            int Idp = 0;

            DataTable Productos = new DataTable();
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "select MAX(IDProducto) as id from Producto";
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
                        Idp = (Int32)Productos.Rows[0]["id"] + 1;
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
