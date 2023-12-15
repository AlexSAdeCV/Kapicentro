using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karpicentro.Forms
{
    public partial class Cotizaciones : Form
    {
        double Precio = 1300;
        int seleccion = 0;
        public Cotizaciones()
        {
            InitializeComponent();
            CargaComboMadera();
        }   

        private void BtnRegreso_Click(object sender, EventArgs e)
        {
            seleccion = 1;
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

        private void IcbtnMesa_Click(object sender, EventArgs e)
        {
            TxtAlto.Text = "70";
            TxtAncho.Text = "50";
            TxtLargo.Text = "50";
        }

        private void IcbtnBuro_Click(object sender, EventArgs e)
        {
            TxtAlto.Text = "70";
            TxtAncho.Text = "50";
            TxtLargo.Text = "50";
        }

        private void IcbtnTaburete_Click(object sender, EventArgs e)
        {
            TxtAlto.Text = "70";
            TxtAncho.Text = "50";
            TxtLargo.Text = "50";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //if (TxtLargo.Text )
        }

        private void Llenartextbox()
        {
            Cotizacion ct = new Cotizacion();
            switch (seleccion)
            {
                case 0:
                    //if (ct.MostrarCotizacion(seleccion))
                    //{
                        
                    //}
                    break; 
                case 1:
                    break;
            }
        }
    }
}
