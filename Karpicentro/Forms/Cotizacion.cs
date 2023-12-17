using iText.Kernel.Pdf.Canvas.Parser.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karpicentro.Forms
{
    public partial class Cotizaciones : Form
    {
        double Precio = 0;
        int seleccion = 0;
        public Cotizaciones()
        {
            InitializeComponent();
            CargaComboMadera();
            Mostrar(1, false, Color.Gray);
            DeshabilitarCmb(1, false, Color.Gray);
            BtnCancelar.Enabled = false;
            BtnCancelar.BackColor = Color.Gray;
        }

        private void BtnRegreso_Click(object sender, EventArgs e)
        {
            seleccion = 1;
            Llenartextbox();
            Mostrar(2, true, Color.White);
            habilitarcmb(1);
        }

        private void IcbtnBuro_Click(object sender, EventArgs e)
        {
            seleccion = 2;
            Llenartextbox();
            Mostrar(2, true, Color.White);
            habilitarcmb(1);
        }

        private void IcbtnTaburete_Click(object sender, EventArgs e)
        {
            seleccion = 3;
            Llenartextbox();
            Mostrar(2, true, Color.White);
            habilitarcmb(1);
        }

        private void IcbtnMesa_Click(object sender, EventArgs e)
        {
            seleccion = 4;
            Llenartextbox();
            Mostrar(2, true, Color.White);
            habilitarcmb(1);
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

        private void Llenartextbox()
        {
            Cotizacion ct = new Cotizacion();
            switch (seleccion)
            {
                case 1:
                    LblPrecio.Text = "$ 000.00";
                    if (ct.MostrarMedidas(seleccion))
                    {
                        TxtAlto.Text = ct.Medidas[0].ToString();
                        TxtAncho.Text = ct.Medidas[1].ToString();
                        TxtLargo.Text = ct.Medidas[2].ToString();
                        Precio = 1300;
                        LblPrecio.Text = "$ " + Precio.ToString();
                    }
                    break;
                case 2:
                    LblPrecio.Text = "$ 000.00";
                    if (ct.MostrarMedidas(seleccion))
                    {
                        TxtAlto.Text = ct.Medidas[0].ToString();
                        TxtAncho.Text = ct.Medidas[1].ToString();
                        TxtLargo.Text = ct.Medidas[2].ToString();
                        Precio = 1300;
                        LblPrecio.Text = "$ " + Precio.ToString();
                    }
                    break;
                case 3:
                    LblPrecio.Text = "$ 000.00";
                    if (ct.MostrarMedidas(seleccion))
                    {
                        TxtAlto.Text = ct.Medidas[0].ToString();
                        TxtAncho.Text = ct.Medidas[1].ToString();
                        TxtLargo.Text = ct.Medidas[2].ToString();
                        Precio = 1300;
                        LblPrecio.Text = "$ " + Precio.ToString();
                    }
                    break;
                case 4:
                    LblPrecio.Text = "$ 000.00";
                    if (ct.MostrarMedidas(seleccion))
                    {
                        TxtAlto.Text = ct.Medidas[0].ToString();
                        TxtAncho.Text = ct.Medidas[1].ToString();
                        TxtLargo.Text = ct.Medidas[2].ToString();
                        Precio = 1300;
                        LblPrecio.Text = "$ " + Precio.ToString();
                    }
                    break;
            }
        }

        public void Mostrar(int s,bool tf, Color color)
        {
            foreach (Control c in groupBox2.Controls)
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

                switch (s)
                {
                    case 1:
                        BtnGuardarMedidas.Enabled = false;
                        BtnGuardarMedidas.BackColor = color;
                        //BtnCancelar.Enabled = false;

                        break;
                    case 2:
                        BtnGuardarMedidas.Enabled = true;
                        BtnGuardarMedidas.BackColor = color;
                        //BtnCancelar.Enabled = true;

                        break;
                }
            }
        }

        public void comprobarcambios()
        {
            double altotxt, anchotxt, largotxt;
            Cotizacion ct = new Cotizacion();

            altotxt = Convert.ToDouble(TxtAlto.Text);
            anchotxt = Convert.ToDouble(TxtAncho.Text);
            largotxt = Convert.ToDouble(TxtLargo.Text);

            switch (seleccion)
            {
                case 1:
                    if (ct.MostrarMedidas(seleccion))
                    {
                        if (altotxt - ct.Medidas[0] > ct.Medidas[0])
                        {
                            double variacion = altotxt - ct.Medidas[0];

                            Precio += 100;

                            for (int i = 100; variacion > i; i += 100)
                            {
                                if (variacion > i)
                                {
                                    Precio += 500;
                                }
                            }
                            LblPrecio.Text = "$ " + Precio.ToString();
                        }
                        if (anchotxt - ct.Medidas[1] > ct.Medidas[1])
                        {
                            double variacion = anchotxt - ct.Medidas[1];

                            Precio += 100;

                            for (int i = 100; variacion > i; i += 100)
                            {
                                if (variacion > i)
                                {
                                    Precio += 500;
                                }
                            }
                            LblPrecio.Text = "$ " + Precio.ToString();
                        }
                        if (largotxt - ct.Medidas[2] > ct.Medidas[2])
                        {
                            double variacion = largotxt - ct.Medidas[2];

                            Precio += 100;

                            for (int i = 100; variacion > i; i += 100)
                            {
                                if (variacion > i)
                                {
                                    Precio += 500;
                                }
                            }
                            LblPrecio.Text = "$ " + Precio.ToString();
                        }
                    }
                    break;
                case 2:
                    if (ct.MostrarMedidas(seleccion))
                    {
                        if (altotxt - ct.Medidas[0] > ct.Medidas[0])
                        {
                            double variacion = altotxt - ct.Medidas[0];

                            Precio += 100;

                            for (int i = 100; variacion > i; i += 100)
                            {
                                if (variacion > i)
                                {
                                    Precio += 500;
                                }
                            }
                            LblPrecio.Text = "$ " + Precio.ToString();
                        }
                        if (anchotxt - ct.Medidas[1] > ct.Medidas[1])
                        {
                            double variacion = anchotxt - ct.Medidas[1];

                            Precio += 100;

                            for (int i = 100; variacion > i; i += 100)
                            {
                                if (variacion > i)
                                {
                                    Precio += 500;
                                }
                            }
                            LblPrecio.Text = "$ " + Precio.ToString();
                        }
                        if (largotxt - ct.Medidas[2] > ct.Medidas[2])
                        {
                            double variacion = largotxt - ct.Medidas[2];

                            Precio += 100;

                            for (int i = 100; variacion > i; i += 100)
                            {
                                if (variacion > i)
                                {
                                    Precio += 500;
                                }
                            }
                            LblPrecio.Text = "$ " + Precio.ToString();
                        }
                    }
                    break;
                case 3:
                    if (ct.MostrarMedidas(seleccion))
                    {
                        if (altotxt - ct.Medidas[0] > ct.Medidas[0])
                        {
                            double variacion = altotxt - ct.Medidas[0];

                            Precio += 100;

                            for (int i = 100; variacion > i; i += 100)
                            {
                                if (variacion > i)
                                {
                                    Precio += 500;
                                }
                            }
                            LblPrecio.Text = "$ " + Precio.ToString();
                        }
                        if (anchotxt - ct.Medidas[1] > ct.Medidas[1])
                        {
                            double variacion = anchotxt - ct.Medidas[1];

                            Precio += 100;

                            for (int i = 100; variacion > i; i += 100)
                            {
                                if (variacion > i)
                                {
                                    Precio += 500;
                                }
                            }
                            LblPrecio.Text = "$ " + Precio.ToString();
                        }
                        if (largotxt - ct.Medidas[2] > ct.Medidas[2])
                        {
                            double variacion = largotxt - ct.Medidas[2];

                            Precio += 100;

                            for (int i = 100; variacion > i; i += 100)
                            {
                                if (variacion > i)
                                {
                                    Precio += 500;
                                }
                            }
                            LblPrecio.Text = "$ " + Precio.ToString();
                        }
                    }
                    break;
                case 4:
                    if (ct.MostrarMedidas(seleccion))
                    {
                        if (altotxt - ct.Medidas[0] > ct.Medidas[0])
                        {
                            double variacion = altotxt - ct.Medidas[0];

                            Precio += 100;

                            for (int i = 100; variacion > i; i += 100)
                            {
                                if (variacion > i)
                                {
                                    Precio += 500;
                                }
                            }
                            LblPrecio.Text = "$ " + Precio.ToString();
                        }
                        if (anchotxt - ct.Medidas[1] > ct.Medidas[1])
                        {
                            double variacion = anchotxt - ct.Medidas[1];

                            Precio += 100;

                            for (int i = 100; variacion > i; i += 100)
                            {
                                if (variacion > i)
                                {
                                    Precio += 500;
                                }
                            }
                            LblPrecio.Text = "$ " + Precio.ToString();
                        }
                        if (largotxt - ct.Medidas[2] > ct.Medidas[2])
                        {
                            double variacion = largotxt - ct.Medidas[2];

                            Precio += 100;

                            for (int i = 100; variacion > i; i += 100)
                            {
                                if (variacion > i)
                                {
                                    Precio += 500;
                                }
                            }
                            LblPrecio.Text = "$ " + Precio.ToString();
                        }
                    }
                    break;
            }
        }

        private void BtnGuardarMedidas_Click(object sender, EventArgs e)
        {
            comprobarcambios();
            DeshabilitarMedidas(1, false, Color.Gray);
            habilitarcmb(2);
            BtnCancelar.Enabled = true;
            BtnCancelar.BackColor = Color.White;    
        }

        public void DeshabilitarMedidas(int s, bool tf, Color color)
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.BackColor = color;
                    c.Enabled = tf;
                }

                switch (s)
                {
                    case 1:
                        BtnGuardarMedidas.Enabled = false;
                        BtnGuardarMedidas.BackColor = color;
                        break;
                }
            }
        }

        public void habilitarcmb(int s2)
        {
            foreach (Control c in groupBox2.Controls)
            {
                switch (s2)
                {
                    case 1:
                        CmbMadera.Enabled = false;
                        CmbTratamientos.Enabled = false;
                        BtnGuardarCmb.Enabled = false;
                        BtnGuardarCmb.BackColor = Color.White;
                        break;
                    case 2:
                        CmbMadera.Enabled = true;
                        CmbTratamientos.Enabled = true;
                        BtnGuardarCmb.Enabled = true;
                        break;
                }
            }
        }

        private void BtnGuardarCmb_Click(object sender, EventArgs e)
        {
            Cotizacion ct = new Cotizacion();

            Precio += ct.PrecioMadera(Convert.ToInt32(CmbMadera.SelectedIndex) + 1);

            switch (CmbTratamientos.SelectedIndex)
            {
                case 0:
                    Precio += 800;
                    break;
                case 1:
                    Precio += 1000;
                    break;
                case 2:
                    Precio += 1200;
                    break;
            }

            LblPrecio.Text = "$ " + Precio.ToString();
            DeshabilitarCmb(1, false, Color.Gray);
            BtnCancelar.Enabled = true;

        }

        public void DeshabilitarCmb(int s, bool tf, Color color)
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is ComboBox)
                {
                    c.Enabled = tf;
                }

                switch (s)
                {
                    case 1:
                        BtnGuardarCmb.Enabled = false;
                        BtnGuardarCmb.BackColor = color;
                        break;
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarMedidas(1, false, Color.Gray);
            DeshabilitarCmb(1, false, Color.Gray);
            Limpiartxt();
            Precio = 1300;
            LblPrecio.Text = "$ " + Precio.ToString();
            BtnCancelar.Enabled = false;
            BtnCancelar.BackColor = Color.Gray;
        }

        public void Limpiartxt()
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = " cm";
                }
            }
        }
    }
}
