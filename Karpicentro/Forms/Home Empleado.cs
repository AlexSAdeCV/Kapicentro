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
    public partial class Home_Empleado : Form
    {
        private Form Hijo = null;
        public Home_Empleado()
        {
            InitializeComponent();
            this.lblUsuario.Text = $"Hola Empleado {InicioSesion.UsuarioF.ToString()}\nComo va su dia";
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

        private void BtnVentas_Click(object sender, EventArgs e)
        {
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            AbrirHijo(new Catalogo());
        }
    }
}
