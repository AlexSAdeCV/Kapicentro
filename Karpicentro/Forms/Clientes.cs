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
            Mostrar(2, true, Color.White);

            op = 2;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            int renglon;
            string id;

            renglon = DgvAlmacen.CurrentRow.Index;
            id = DgvAlmacen.Rows[renglon].Cells[0].Value.ToString();
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
                        cl.Nombre = Txt_Nombre.Text;
                        cl.PApellido = Txt_AP.Text;
                        cl.MApellido = Txt_AM.Text;
                        cl.Calle = Txt_Calle.Text;
                        cl.Delegacion = TxtDelegacion.Text;
                        cl.Cp = Txt_CP.Text;
                        cl.NoExterior = Txt_NE.Text;
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
                        renglon = DgvAlmacen.CurrentRow.Index;
                        id = DgvAlmacen.Rows[renglon].Cells[0].Value.ToString();
                        cl.IDCliente = Convert.ToInt32(id);
                        cl.Nombre = Txt_Nombre.Text;
                        cl.PApellido = Txt_AP.Text;
                        cl.MApellido = Txt_AM.Text;
                        cl.Calle = Txt_Calle.Text;
                        cl.Delegacion = TxtDelegacion.Text;
                        cl.Cp = Txt_CP.Text;
                        cl.NoExterior = Txt_NE.Text;
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
            DgvAlmacen.DataSource = cl.MostrarClientes();
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
