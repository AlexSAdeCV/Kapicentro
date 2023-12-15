namespace Karpicentro.Forms
{
    partial class VistaProducto
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
            this.Pnlinserstar = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblMedidas = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.LblNombreM = new System.Windows.Forms.Label();
            this.BtnComprar = new System.Windows.Forms.Button();
            this.BtnCambio = new FontAwesome.Sharp.IconButton();
            this.Lbl_Fotos = new System.Windows.Forms.Label();
            this.IbtnRegresar = new FontAwesome.Sharp.IconButton();
            this.PicboxProducto = new System.Windows.Forms.PictureBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnTerminarVenta = new System.Windows.Forms.Button();
            this.PnlTotal = new System.Windows.Forms.Panel();
            this.DgvProducto = new System.Windows.Forms.DataGridView();
            this.Pnlinserstar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicboxProducto)).BeginInit();
            this.PnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnlinserstar
            // 
            this.Pnlinserstar.BackColor = System.Drawing.Color.Transparent;
            this.Pnlinserstar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnlinserstar.Controls.Add(this.groupBox1);
            this.Pnlinserstar.Controls.Add(this.LblNombreM);
            this.Pnlinserstar.ForeColor = System.Drawing.Color.White;
            this.Pnlinserstar.Location = new System.Drawing.Point(514, 143);
            this.Pnlinserstar.Margin = new System.Windows.Forms.Padding(4);
            this.Pnlinserstar.Name = "Pnlinserstar";
            this.Pnlinserstar.Size = new System.Drawing.Size(652, 275);
            this.Pnlinserstar.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.LblPrecio);
            this.groupBox1.Controls.Add(this.LblMedidas);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 164);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(332, 113);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblPrecio
            // 
            this.LblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.LblPrecio.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.ForeColor = System.Drawing.Color.Black;
            this.LblPrecio.Location = new System.Drawing.Point(7, 113);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(153, 48);
            this.LblPrecio.TabIndex = 11;
            this.LblPrecio.Text = "PRECIO\r\n    $ 5390.00,\r\n\r\n";
            // 
            // LblMedidas
            // 
            this.LblMedidas.BackColor = System.Drawing.Color.Transparent;
            this.LblMedidas.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedidas.ForeColor = System.Drawing.Color.Black;
            this.LblMedidas.Location = new System.Drawing.Point(329, 26);
            this.LblMedidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMedidas.Name = "LblMedidas";
            this.LblMedidas.Size = new System.Drawing.Size(261, 68);
            this.LblMedidas.TabIndex = 10;
            this.LblMedidas.Text = "Medidas\r\n\r\n40 x 48 x 99 cms\r\n\r\n\r\n";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(7, 26);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(261, 82);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Silla con diseño vanguardista,  \r\nIdeal para complementar tu espacio. \r\n\r\n";
            // 
            // LblNombreM
            // 
            this.LblNombreM.AutoSize = true;
            this.LblNombreM.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreM.Font = new System.Drawing.Font("Sitka Heading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreM.ForeColor = System.Drawing.Color.Black;
            this.LblNombreM.Location = new System.Drawing.Point(22, 0);
            this.LblNombreM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreM.Name = "LblNombreM";
            this.LblNombreM.Size = new System.Drawing.Size(164, 32);
            this.LblNombreM.TabIndex = 7;
            this.LblNombreM.Text = "SILLA LUSIANA";
            // 
            // BtnComprar
            // 
            this.BtnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.BtnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComprar.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComprar.ForeColor = System.Drawing.Color.White;
            this.BtnComprar.Location = new System.Drawing.Point(534, 445);
            this.BtnComprar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnComprar.Name = "BtnComprar";
            this.BtnComprar.Size = new System.Drawing.Size(249, 33);
            this.BtnComprar.TabIndex = 24;
            this.BtnComprar.Text = "Comprar";
            this.BtnComprar.UseVisualStyleBackColor = false;
            this.BtnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // BtnCambio
            // 
            this.BtnCambio.BackColor = System.Drawing.Color.Transparent;
            this.BtnCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambio.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCambio.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.BtnCambio.IconColor = System.Drawing.Color.Black;
            this.BtnCambio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCambio.Location = new System.Drawing.Point(230, 541);
            this.BtnCambio.Name = "BtnCambio";
            this.BtnCambio.Size = new System.Drawing.Size(67, 45);
            this.BtnCambio.TabIndex = 36;
            this.BtnCambio.UseVisualStyleBackColor = false;
            // 
            // Lbl_Fotos
            // 
            this.Lbl_Fotos.ImageIndex = 0;
            this.Lbl_Fotos.Location = new System.Drawing.Point(96, 188);
            this.Lbl_Fotos.Name = "Lbl_Fotos";
            this.Lbl_Fotos.Size = new System.Drawing.Size(325, 328);
            this.Lbl_Fotos.TabIndex = 35;
            this.Lbl_Fotos.Click += new System.EventHandler(this.Lbl_Fotos_Click);
            // 
            // IbtnRegresar
            // 
            this.IbtnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.IbtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IbtnRegresar.ForeColor = System.Drawing.Color.Black;
            this.IbtnRegresar.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.IbtnRegresar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.IbtnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnRegresar.IconSize = 30;
            this.IbtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IbtnRegresar.Location = new System.Drawing.Point(55, 45);
            this.IbtnRegresar.Name = "IbtnRegresar";
            this.IbtnRegresar.Size = new System.Drawing.Size(172, 61);
            this.IbtnRegresar.TabIndex = 34;
            this.IbtnRegresar.Text = "Regresar";
            this.IbtnRegresar.UseVisualStyleBackColor = false;
            // 
            // PicboxProducto
            // 
            this.PicboxProducto.Location = new System.Drawing.Point(120, 169);
            this.PicboxProducto.Name = "PicboxProducto";
            this.PicboxProducto.Size = new System.Drawing.Size(320, 366);
            this.PicboxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicboxProducto.TabIndex = 40;
            this.PicboxProducto.TabStop = false;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(114, 35);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(95, 33);
            this.LblTotal.TabIndex = 41;
            this.LblTotal.Text = "Total";
            // 
            // BtnTerminarVenta
            // 
            this.BtnTerminarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.BtnTerminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTerminarVenta.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTerminarVenta.ForeColor = System.Drawing.Color.White;
            this.BtnTerminarVenta.Location = new System.Drawing.Point(52, 117);
            this.BtnTerminarVenta.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnTerminarVenta.Name = "BtnTerminarVenta";
            this.BtnTerminarVenta.Size = new System.Drawing.Size(249, 33);
            this.BtnTerminarVenta.TabIndex = 42;
            this.BtnTerminarVenta.Text = "Terminar Venta";
            this.BtnTerminarVenta.UseVisualStyleBackColor = false;
            this.BtnTerminarVenta.Click += new System.EventHandler(this.BtnTerminarVenta_Click);
            // 
            // PnlTotal
            // 
            this.PnlTotal.Controls.Add(this.LblTotal);
            this.PnlTotal.Controls.Add(this.BtnTerminarVenta);
            this.PnlTotal.Location = new System.Drawing.Point(774, 511);
            this.PnlTotal.Name = "PnlTotal";
            this.PnlTotal.Size = new System.Drawing.Size(348, 211);
            this.PnlTotal.TabIndex = 43;
            // 
            // DgvProducto
            // 
            this.DgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducto.Location = new System.Drawing.Point(564, 13);
            this.DgvProducto.Name = "DgvProducto";
            this.DgvProducto.RowTemplate.Height = 24;
            this.DgvProducto.Size = new System.Drawing.Size(240, 150);
            this.DgvProducto.TabIndex = 44;
            // 
            // VistaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 759);
            this.Controls.Add(this.DgvProducto);
            this.Controls.Add(this.PnlTotal);
            this.Controls.Add(this.PicboxProducto);
            this.Controls.Add(this.BtnComprar);
            this.Controls.Add(this.Pnlinserstar);
            this.Controls.Add(this.BtnCambio);
            this.Controls.Add(this.Lbl_Fotos);
            this.Controls.Add(this.IbtnRegresar);
            this.Name = "VistaProducto";
            this.Text = "VistaProducto";
            this.Load += new System.EventHandler(this.VistaProducto_Load);
            this.Pnlinserstar.ResumeLayout(false);
            this.Pnlinserstar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicboxProducto)).EndInit();
            this.PnlTotal.ResumeLayout(false);
            this.PnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Pnlinserstar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblMedidas;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button BtnComprar;
        private System.Windows.Forms.Label LblNombreM;
        private FontAwesome.Sharp.IconButton BtnCambio;
        private FontAwesome.Sharp.IconButton IbtnRegresar;
        public System.Windows.Forms.Label Lbl_Fotos;
        public System.Windows.Forms.PictureBox PicboxProducto;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnTerminarVenta;
        private System.Windows.Forms.Panel PnlTotal;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView DgvProducto;
    }
}