namespace Karpicentro.Forms
{
    partial class HomeAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelFormSecundario = new System.Windows.Forms.Panel();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.BtnSalir = new FontAwesome.Sharp.IconButton();
            this.BtnClientes = new FontAwesome.Sharp.IconButton();
            this.BtnHome = new FontAwesome.Sharp.IconButton();
            this.BtnProductos = new FontAwesome.Sharp.IconButton();
            this.BtnAlmacen = new FontAwesome.Sharp.IconButton();
            this.BtnProveedor = new FontAwesome.Sharp.IconButton();
            this.BtnAgregarEmpleados = new FontAwesome.Sharp.IconButton();
            this.PanelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFormSecundario
            // 
            this.PanelFormSecundario.AutoSize = true;
            this.PanelFormSecundario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.PanelFormSecundario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelFormSecundario.Cursor = System.Windows.Forms.Cursors.No;
            this.PanelFormSecundario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormSecundario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PanelFormSecundario.Location = new System.Drawing.Point(0, 83);
            this.PanelFormSecundario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelFormSecundario.Name = "PanelFormSecundario";
            this.PanelFormSecundario.Size = new System.Drawing.Size(1259, 630);
            this.PanelFormSecundario.TabIndex = 6;
            // 
            // PanelBotones
            // 
            this.PanelBotones.BackColor = System.Drawing.Color.Transparent;
            this.PanelBotones.Controls.Add(this.BtnSalir);
            this.PanelBotones.Controls.Add(this.BtnClientes);
            this.PanelBotones.Controls.Add(this.BtnHome);
            this.PanelBotones.Controls.Add(this.BtnProductos);
            this.PanelBotones.Controls.Add(this.BtnAlmacen);
            this.PanelBotones.Controls.Add(this.BtnProveedor);
            this.PanelBotones.Controls.Add(this.BtnAgregarEmpleados);
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBotones.ForeColor = System.Drawing.SystemColors.Control;
            this.PanelBotones.Location = new System.Drawing.Point(0, 0);
            this.PanelBotones.Margin = new System.Windows.Forms.Padding(2);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(1259, 83);
            this.PanelBotones.TabIndex = 5;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.BtnSalir.IconColor = System.Drawing.Color.White;
            this.BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(975, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(114, 83);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnClientes.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.BtnClientes.IconColor = System.Drawing.Color.White;
            this.BtnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(613, 0);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(170, 83);
            this.BtnClientes.TabIndex = 5;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnHome.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.BtnHome.IconColor = System.Drawing.Color.White;
            this.BtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(1089, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(170, 83);
            this.BtnHome.TabIndex = 4;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnProductos.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.BtnProductos.IconColor = System.Drawing.Color.White;
            this.BtnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.Location = new System.Drawing.Point(443, 0);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(170, 83);
            this.BtnProductos.TabIndex = 3;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnAlmacen
            // 
            this.BtnAlmacen.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAlmacen.FlatAppearance.BorderSize = 0;
            this.BtnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlmacen.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAlmacen.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.BtnAlmacen.IconColor = System.Drawing.Color.White;
            this.BtnAlmacen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlmacen.Location = new System.Drawing.Point(289, 0);
            this.BtnAlmacen.Name = "BtnAlmacen";
            this.BtnAlmacen.Size = new System.Drawing.Size(154, 83);
            this.BtnAlmacen.TabIndex = 2;
            this.BtnAlmacen.Text = "Almacen";
            this.BtnAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAlmacen.UseVisualStyleBackColor = true;
            this.BtnAlmacen.Click += new System.EventHandler(this.BtnAlmacen_Click);
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.BackColor = System.Drawing.Color.Transparent;
            this.BtnProveedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnProveedor.FlatAppearance.BorderSize = 0;
            this.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedor.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnProveedor.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.BtnProveedor.IconColor = System.Drawing.Color.White;
            this.BtnProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedor.Location = new System.Drawing.Point(147, 0);
            this.BtnProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Size = new System.Drawing.Size(142, 83);
            this.BtnProveedor.TabIndex = 1;
            this.BtnProveedor.Text = "Proveedor";
            this.BtnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProveedor.UseVisualStyleBackColor = false;
            this.BtnProveedor.Click += new System.EventHandler(this.BtnProveedor_Click);
            // 
            // BtnAgregarEmpleados
            // 
            this.BtnAgregarEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarEmpleados.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAgregarEmpleados.FlatAppearance.BorderSize = 0;
            this.BtnAgregarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarEmpleados.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAgregarEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.BtnAgregarEmpleados.IconColor = System.Drawing.Color.White;
            this.BtnAgregarEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregarEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarEmpleados.Location = new System.Drawing.Point(0, 0);
            this.BtnAgregarEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregarEmpleados.Name = "BtnAgregarEmpleados";
            this.BtnAgregarEmpleados.Size = new System.Drawing.Size(147, 83);
            this.BtnAgregarEmpleados.TabIndex = 0;
            this.BtnAgregarEmpleados.Text = "Empleados";
            this.BtnAgregarEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregarEmpleados.UseVisualStyleBackColor = false;
            this.BtnAgregarEmpleados.Click += new System.EventHandler(this.BtnAgregarEmpleados_Click);
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1259, 713);
            this.Controls.Add(this.PanelFormSecundario);
            this.Controls.Add(this.PanelBotones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeAdmin";
            this.Text = "HomeAdmin";
            this.Load += new System.EventHandler(this.HomeAdmin_Load);
            this.PanelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelFormSecundario;
        private System.Windows.Forms.Panel PanelBotones;
        private FontAwesome.Sharp.IconButton BtnProductos;
        private FontAwesome.Sharp.IconButton BtnAlmacen;
        private FontAwesome.Sharp.IconButton BtnProveedor;
        private FontAwesome.Sharp.IconButton BtnAgregarEmpleados;
        private FontAwesome.Sharp.IconButton BtnHome;
        private FontAwesome.Sharp.IconButton BtnClientes;
        private FontAwesome.Sharp.IconButton BtnSalir;
    }
}