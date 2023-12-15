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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "" && TxtContraseña.Text == "")
            {
                MessageBox.Show("Campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (InicioSesion.IniciaSesion(TxtUsuario.Text, TxtContraseña.Text))
                {
                    TxtContraseña.Text = "";
                    TxtUsuario.Text = "";
                    this.Hide();

                    if (InicioSesion.Nivel == 1)
                    {
                        HomeAdmin Ha = new HomeAdmin();
                        Ha.ShowDialog();
                    }
                    if (InicioSesion.Nivel == 2)
                    {
                        Home_Empleado home = new Home_Empleado();   
                        home.ShowDialog();
                    }
                }

                this.Show();
            }
        }

    }
}
