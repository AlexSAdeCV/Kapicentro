using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;


            op = 1;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);
            BtnAgregar.Enabled = false;
            BtnEliminar.Enabled = false;

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

            switch (op)
            {
                case 1:
                    Al.Nombre = TxtNombre.Text;
                    Al.CantidadMaterial = Convert.ToInt32(TxtStock.Text);
                    Al.Proveedor = TxtProveedor.Text;

                    if (ValidaCampos(1))
                    {
                        QuitarValidacion();
                        if (Al.Insertar())
                        {
                            MessageBox.Show("Registro agregado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarAlmacen();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }
                    }
                    break;
                case 2:
                    renglon = DgvAlmacen.CurrentRow.Index;
                    id = DgvAlmacen.Rows[renglon].Cells[0].Value.ToString();
                    Al.Nombre = TxtNombre.Text;
                    Al.CantidadMaterial = Convert.ToInt32(TxtStock.Text);
                    Al.idalmacen = Convert.ToInt32(id);

                    if (ValidaCampos(2))
                    {
                        QuitarValidacion();
                        if (Al.Modificar())
                        {
                            MessageBox.Show("Registro modificado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarAlmacen();
                            HabilitaBotones();
                            Mostrar(1, false, Color.Gray);
                        }
                    }
                    break;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Mostrar(1, false, Color.Gray);
            LimpiaCampos();
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
                errorProvider1.SetError(TxtProveedor, "Este campo no debe estar vacio");
                errorProvider1.SetError(TxtStock, "Este campo no debe estar vacio");
            }
            if (op == 2)
            {
                errorProvider1.SetError(TxtNombre, "Este campo no debe estar vacio");
                errorProvider1.SetError(TxtProveedor, "Este campo no debe estar vacio");
                errorProvider1.SetError(TxtStock, "Este campo no debe estar vacio");
            }
            return valido;
        }

        private void QuitarValidacion()
        {
            errorProvider1.SetError(TxtNombre, "");
            errorProvider1.SetError(TxtProveedor, "");
            errorProvider1.SetError(TxtStock, "");
        }

        private void MostrarAlmacen()
        {
            Almacen almacen = new Almacen();

            DgvAlmacen.AutoSize = true;
            DgvAlmacen.DataSource = almacen.MostrarAlmacen();
        }
    }
}
