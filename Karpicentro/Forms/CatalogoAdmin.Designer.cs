namespace Karpicentro.Forms
{
    partial class CatalogoAdmin
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
            this.components = new System.ComponentModel.Container();
            this.BtnRegreso = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnlinserstar = new System.Windows.Forms.Panel();
            this.NupExistencia = new System.Windows.Forms.NumericUpDown();
            this.CmbMadera = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
            this.LblNombreM = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Pnlinserstar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NupExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegreso
            // 
            this.BtnRegreso.AutoSize = true;
            this.BtnRegreso.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegreso.FlatAppearance.BorderSize = 0;
            this.BtnRegreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegreso.Font = new System.Drawing.Font("SimSun-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegreso.ForeColor = System.Drawing.Color.Black;
            this.BtnRegreso.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.BtnRegreso.IconColor = System.Drawing.Color.Black;
            this.BtnRegreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegreso.Location = new System.Drawing.Point(53, 37);
            this.BtnRegreso.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegreso.Name = "BtnRegreso";
            this.BtnRegreso.Size = new System.Drawing.Size(172, 66);
            this.BtnRegreso.TabIndex = 53;
            this.BtnRegreso.Text = "Regresar";
            this.BtnRegreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegreso.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(240, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 47);
            this.label1.TabIndex = 52;
            this.label1.Text = "Catalogo";
            // 
            // Pnlinserstar
            // 
            this.Pnlinserstar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Pnlinserstar.BackColor = System.Drawing.Color.Transparent;
            this.Pnlinserstar.Controls.Add(this.NupExistencia);
            this.Pnlinserstar.Controls.Add(this.CmbMadera);
            this.Pnlinserstar.Controls.Add(this.label2);
            this.Pnlinserstar.Controls.Add(this.BtnCancelar);
            this.Pnlinserstar.Controls.Add(this.BtnEliminar);
            this.Pnlinserstar.Controls.Add(this.BtnModificar);
            this.Pnlinserstar.Controls.Add(this.lblExistencia);
            this.Pnlinserstar.Controls.Add(this.BtnGuardar);
            this.Pnlinserstar.Controls.Add(this.BtnAgregar);
            this.Pnlinserstar.Controls.Add(this.lblStock);
            this.Pnlinserstar.Controls.Add(this.TxtPrecioVenta);
            this.Pnlinserstar.Controls.Add(this.LblNombreM);
            this.Pnlinserstar.Controls.Add(this.TxtNombre);
            this.Pnlinserstar.ForeColor = System.Drawing.Color.Black;
            this.Pnlinserstar.Location = new System.Drawing.Point(31, 126);
            this.Pnlinserstar.Margin = new System.Windows.Forms.Padding(0);
            this.Pnlinserstar.Name = "Pnlinserstar";
            this.Pnlinserstar.Size = new System.Drawing.Size(534, 326);
            this.Pnlinserstar.TabIndex = 51;
            // 
            // NupExistencia
            // 
            this.NupExistencia.Location = new System.Drawing.Point(279, 103);
            this.NupExistencia.Name = "NupExistencia";
            this.NupExistencia.Size = new System.Drawing.Size(120, 22);
            this.NupExistencia.TabIndex = 30;
            // 
            // CmbMadera
            // 
            this.CmbMadera.FormattingEnabled = true;
            this.CmbMadera.Location = new System.Drawing.Point(279, 45);
            this.CmbMadera.Name = "CmbMadera";
            this.CmbMadera.Size = new System.Drawing.Size(150, 24);
            this.CmbMadera.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Precio de Venta";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.Location = new System.Drawing.Point(256, 225);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(111, 33);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Location = new System.Drawing.Point(334, 159);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(111, 36);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.Location = new System.Drawing.Point(187, 159);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(119, 36);
            this.BtnModificar.TabIndex = 5;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.BackColor = System.Drawing.Color.Transparent;
            this.lblExistencia.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencia.ForeColor = System.Drawing.Color.Black;
            this.lblExistencia.Location = new System.Drawing.Point(275, 79);
            this.lblExistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(119, 20);
            this.lblExistencia.TabIndex = 11;
            this.lblExistencia.Text = "Existencia";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Black;
            this.BtnGuardar.Location = new System.Drawing.Point(123, 225);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(111, 33);
            this.BtnGuardar.TabIndex = 7;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Location = new System.Drawing.Point(51, 159);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(111, 36);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.Black;
            this.lblStock.Location = new System.Drawing.Point(275, 22);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(163, 20);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "Tipo de Madera";
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Location = new System.Drawing.Point(31, 103);
            this.TxtPrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(171, 22);
            this.TxtPrecioVenta.TabIndex = 2;
            // 
            // LblNombreM
            // 
            this.LblNombreM.AutoSize = true;
            this.LblNombreM.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreM.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreM.ForeColor = System.Drawing.Color.Black;
            this.LblNombreM.Location = new System.Drawing.Point(27, 22);
            this.LblNombreM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreM.Name = "LblNombreM";
            this.LblNombreM.Size = new System.Drawing.Size(218, 20);
            this.LblNombreM.TabIndex = 0;
            this.LblNombreM.Text = "Nombre del Producto";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(32, 48);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(213, 22);
            this.TxtNombre.TabIndex = 0;
            // 
            // DgvProductos
            // 
            this.DgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.GridColor = System.Drawing.Color.Black;
            this.DgvProductos.Location = new System.Drawing.Point(627, 123);
            this.DgvProductos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.RowTemplate.Height = 24;
            this.DgvProductos.Size = new System.Drawing.Size(789, 329);
            this.DgvProductos.TabIndex = 50;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CatalogoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 683);
            this.Controls.Add(this.BtnRegreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pnlinserstar);
            this.Controls.Add(this.DgvProductos);
            this.Name = "CatalogoAdmin";
            this.Text = "Catalogo";
            this.Pnlinserstar.ResumeLayout(false);
            this.Pnlinserstar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NupExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnRegreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnlinserstar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox TxtPrecioVenta;
        private System.Windows.Forms.Label LblNombreM;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbMadera;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.NumericUpDown NupExistencia;
    }
}