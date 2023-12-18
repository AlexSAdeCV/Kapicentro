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
        }
        

        public void Mostrar(int s,bool tf,Color color)
        {
            foreach(Control c in this.Pnlinserstar.Controls)
            {
                c.Enabled = tf;
                if (c is TextBox || c is RJComboBox )
                {
                    c.BackColor = color;
                    c.Text = "";
                    Cbox_IdPuesto.Text = "";
                    Cbox_IdPuesto.BackColor = color;

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
            MostrarEmpleados();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);
            op = 1;
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
                        empleado.Usuario = Txt_Usuario.Text;
                        empleado.Contrasena = Txt_Contrasena.Text;
                        empleado.Puesto = Convert.ToInt32(Cbox_IdPuesto.SelectedIndex.ToString()) + 1;

                        empleado.Nombre = Txt_Nombre.Text;
                        empleado.PApellido = Txt_AP.Text;
                        empleado.SApellido = Txt_AM.Text;

                        empleado.Calle = Txt_Calle.Text;
                        empleado.Telefono = Txt_Telefono.Text;
                        empleado.CP = Txt_CP.Text;
                        empleado.NExterior = Txt_NE.Text;

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
                        renglon = DgvAlmacen.CurrentRow.Index;
                        id = DgvAlmacen.Rows[renglon].Cells[0].Value.ToString();
                        empleado.Usuario = Txt_Usuario.Text;
                        empleado.Contrasena = Txt_Contrasena.Text;
                        empleado.Puesto = Convert.ToInt32(Cbox_IdPuesto.SelectedIndex.ToString()) + 1;

                        empleado.Nombre = Txt_Nombre.Text;
                        empleado.PApellido = Txt_AP.Text;
                        empleado.SApellido = Txt_AM.Text;

                        empleado.Calle = Txt_Calle.Text;
                        empleado.Telefono = Txt_Telefono.Text;
                        empleado.CP = Txt_CP.Text;
                        empleado.NExterior = Txt_NE.Text;

                        if (empleado.Actualizar(Convert.ToInt32(id)))
                        {
                            MessageBox.Show("Registro modificado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            MostrarEmpleados();
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

        //Metodos
        private void MostrarEmpleados()
        {
            //DgvAlmacen.AutoSize = true;
            DgvAlmacen.DataSource = empleado.MostrarEmpleados();
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

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            int RenglonSeleccionado = DgvAlmacen.CurrentRow.Index;
            int Id = Convert.ToInt32(DgvAlmacen.Rows[RenglonSeleccionado].Cells[0].Value.ToString());
            DialogResult Resultado = MessageBox.Show("¿Desea eliminar al Empleado con Id " + Id + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                empleado.Eliminar_Tabla(Id);
            }
            Mostrar(1, false, Color.Gray);
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

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);
            op = 2;
        }
    }
}
