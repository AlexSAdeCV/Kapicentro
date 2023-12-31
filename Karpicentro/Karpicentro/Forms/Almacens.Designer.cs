﻿namespace Karpicentro.Forms
{
    partial class Almacens
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
            this.label1 = new System.Windows.Forms.Label();
            this.Pnlinserstar = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.LblNombreM = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.DgvAlmacen = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnRegreso = new FontAwesome.Sharp.IconButton();
            this.Pnlinserstar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(283, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 47);
            this.label1.TabIndex = 48;
            this.label1.Text = "Almacen";
            // 
            // Pnlinserstar
            // 
            this.Pnlinserstar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Pnlinserstar.BackColor = System.Drawing.Color.Transparent;
            this.Pnlinserstar.Controls.Add(this.BtnCancelar);
            this.Pnlinserstar.Controls.Add(this.BtnEliminar);
            this.Pnlinserstar.Controls.Add(this.BtnModificar);
            this.Pnlinserstar.Controls.Add(this.lblProveedor);
            this.Pnlinserstar.Controls.Add(this.BtnGuardar);
            this.Pnlinserstar.Controls.Add(this.TxtProveedor);
            this.Pnlinserstar.Controls.Add(this.BtnAgregar);
            this.Pnlinserstar.Controls.Add(this.lblStock);
            this.Pnlinserstar.Controls.Add(this.TxtStock);
            this.Pnlinserstar.Controls.Add(this.LblNombreM);
            this.Pnlinserstar.Controls.Add(this.TxtNombre);
            this.Pnlinserstar.Location = new System.Drawing.Point(67, 178);
            this.Pnlinserstar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pnlinserstar.Name = "Pnlinserstar";
            this.Pnlinserstar.Size = new System.Drawing.Size(481, 460);
            this.Pnlinserstar.TabIndex = 45;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(237, 288);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(111, 33);
            this.BtnCancelar.TabIndex = 26;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(315, 222);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(111, 36);
            this.BtnEliminar.TabIndex = 25;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(168, 222);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(119, 36);
            this.BtnModificar.TabIndex = 23;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lblProveedor.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProveedor.Location = new System.Drawing.Point(27, 142);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(141, 20);
            this.lblProveedor.TabIndex = 11;
            this.lblProveedor.Text = "ID Proveedor";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(104, 288);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(111, 33);
            this.BtnGuardar.TabIndex = 22;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.Location = new System.Drawing.Point(32, 167);
            this.TxtProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.Size = new System.Drawing.Size(379, 22);
            this.TxtProveedor.TabIndex = 10;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(32, 222);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(111, 36);
            this.BtnAgregar.TabIndex = 20;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStock.Location = new System.Drawing.Point(27, 82);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(64, 20);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "Stock";
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(32, 108);
            this.TxtStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(379, 22);
            this.TxtStock.TabIndex = 8;
            this.TxtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStock_KeyPress);
            // 
            // LblNombreM
            // 
            this.LblNombreM.AutoSize = true;
            this.LblNombreM.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreM.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreM.ForeColor = System.Drawing.SystemColors.Control;
            this.LblNombreM.Location = new System.Drawing.Point(27, 22);
            this.LblNombreM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreM.Name = "LblNombreM";
            this.LblNombreM.Size = new System.Drawing.Size(218, 20);
            this.LblNombreM.TabIndex = 7;
            this.LblNombreM.Text = "Nombre del Material";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(32, 48);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(379, 22);
            this.TxtNombre.TabIndex = 6;
            // 
            // DgvAlmacen
            // 
            this.DgvAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAlmacen.BackgroundColor = System.Drawing.Color.White;
            this.DgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAlmacen.GridColor = System.Drawing.Color.Black;
            this.DgvAlmacen.Location = new System.Drawing.Point(596, 200);
            this.DgvAlmacen.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DgvAlmacen.Name = "DgvAlmacen";
            this.DgvAlmacen.RowHeadersWidth = 51;
            this.DgvAlmacen.RowTemplate.Height = 24;
            this.DgvAlmacen.Size = new System.Drawing.Size(779, 332);
            this.DgvAlmacen.TabIndex = 44;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BtnRegreso
            // 
            this.BtnRegreso.AutoSize = true;
            this.BtnRegreso.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegreso.FlatAppearance.BorderSize = 0;
            this.BtnRegreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegreso.Font = new System.Drawing.Font("SimSun-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegreso.ForeColor = System.Drawing.Color.White;
            this.BtnRegreso.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.BtnRegreso.IconColor = System.Drawing.Color.White;
            this.BtnRegreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegreso.Location = new System.Drawing.Point(96, 46);
            this.BtnRegreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRegreso.Name = "BtnRegreso";
            this.BtnRegreso.Size = new System.Drawing.Size(172, 66);
            this.BtnRegreso.TabIndex = 49;
            this.BtnRegreso.Text = "Regresar";
            this.BtnRegreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegreso.UseVisualStyleBackColor = false;
            // 
            // Almacens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1691, 694);
            this.Controls.Add(this.BtnRegreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pnlinserstar);
            this.Controls.Add(this.DgvAlmacen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Almacens";
            this.Text = "Almacens";
            this.Pnlinserstar.ResumeLayout(false);
            this.Pnlinserstar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnRegreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnlinserstar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtProveedor;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Label LblNombreM;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DataGridView DgvAlmacen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}