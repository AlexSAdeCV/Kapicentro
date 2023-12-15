using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karpicentro.Forms.Empleado
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            Llenardgv();
        }

        public void Llenardgv()
        {
            Venta venta = new Venta();

            DgvVentas.AutoSize = true;
            DgvVentas.DataSource = venta.MostrarVentas();
        }
    }
}
