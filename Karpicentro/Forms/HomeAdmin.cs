using Karpicentro.Forms.Admin;
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
    public partial class HomeAdmin : Form
    {
        private Form Hijo = null;

        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            AbrirHijo(new MenuAdmin());
        }

        private void BtnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            AbrirHijo(new Empleados());
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            AbrirHijo(new Proveedores());
        }

        private void BtnAlmacen_Click(object sender, EventArgs e)
        {
            AbrirHijo(new Almacens());
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AbrirHijo(new CatalogoAdmin());
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            AbrirHijo(new MenuAdmin());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirHijo(Form Hijito)
        {
            if (Hijo != null)
                Hijo.Close();
            else
            {
                Hijo = Hijito;
                Hijito.TopLevel = false;
                Hijito.FormBorderStyle = FormBorderStyle.None;
                Hijito.Dock = DockStyle.Fill;
                PanelFormSecundario.Controls.Add(Hijito);
                PanelFormSecundario.Tag = Hijito;
                Hijito.BringToFront();
                Hijito.Show();
                Hijo = null;
            }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AbrirHijo(new Clientes());
        }
    }
}
