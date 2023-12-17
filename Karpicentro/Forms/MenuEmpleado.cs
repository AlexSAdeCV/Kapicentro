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
    public partial class MenuEmpleado : Form
    {
        public MenuEmpleado()
        {
            InitializeComponent();
        }

        private void MenuEmpleado_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Hola Empleado\nComo va su dia";
        }
    }
}
