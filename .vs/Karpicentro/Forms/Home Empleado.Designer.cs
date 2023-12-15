namespace Karpicentro.Forms
{
    partial class Home_Empleado
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
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.BtnHome = new FontAwesome.Sharp.IconButton();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnCatalogo = new FontAwesome.Sharp.IconButton();
            this.BtnVentas = new FontAwesome.Sharp.IconButton();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelFormSecundario = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelBotones.SuspendLayout();
            this.PanelFormSecundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBotones
            // 
            this.PanelBotones.BackColor = System.Drawing.Color.Transparent;
            this.PanelBotones.Controls.Add(this.BtnHome);
            this.PanelBotones.Controls.Add(this.LblNombre);
            this.PanelBotones.Controls.Add(this.BtnCatalogo);
            this.PanelBotones.Controls.Add(this.BtnVentas);
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBotones.ForeColor = System.Drawing.SystemColors.Control;
            this.PanelBotones.Location = new System.Drawing.Point(0, 0);
            this.PanelBotones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(1616, 102);
            this.PanelBotones.TabIndex = 7;
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.Transparent;
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.BtnHome.IconColor = System.Drawing.Color.White;
            this.BtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(1426, 0);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(190, 102);
            this.BtnHome.TabIndex = 4;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(733, 36);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(126, 46);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "label1";
            // 
            // BtnCatalogo
            // 
            this.BtnCatalogo.BackColor = System.Drawing.Color.Transparent;
            this.BtnCatalogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnCatalogo.FlatAppearance.BorderSize = 0;
            this.BtnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCatalogo.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCatalogo.IconChar = FontAwesome.Sharp.IconChar.Opencart;
            this.BtnCatalogo.IconColor = System.Drawing.Color.White;
            this.BtnCatalogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCatalogo.Location = new System.Drawing.Point(196, 0);
            this.BtnCatalogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCatalogo.Name = "BtnCatalogo";
            this.BtnCatalogo.Size = new System.Drawing.Size(190, 102);
            this.BtnCatalogo.TabIndex = 1;
            this.BtnCatalogo.Text = "Catalogo";
            this.BtnCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCatalogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCatalogo.UseVisualStyleBackColor = false;
            this.BtnCatalogo.Click += new System.EventHandler(this.BtnCatalogo_Click);
            // 
            // BtnVentas
            // 
            this.BtnVentas.BackColor = System.Drawing.Color.Transparent;
            this.BtnVentas.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnVentas.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.BtnVentas.IconColor = System.Drawing.Color.White;
            this.BtnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.Location = new System.Drawing.Point(0, 0);
            this.BtnVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(196, 102);
            this.BtnVentas.TabIndex = 0;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVentas.UseVisualStyleBackColor = false;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("SimSun-ExtB", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(81, 107);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(305, 86);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "Bienvenido,\r\nAdministrador\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(840, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 56);
            this.label2.TabIndex = 16;
            this.label2.Text = "\"Karpicentro: where excellence in \r\ncarpentry finds it\'s home.\"\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelFormSecundario
            // 
            this.PanelFormSecundario.AutoSize = true;
            this.PanelFormSecundario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.PanelFormSecundario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelFormSecundario.Controls.Add(this.pictureBox3);
            this.PanelFormSecundario.Controls.Add(this.pictureBox2);
            this.PanelFormSecundario.Controls.Add(this.label2);
            this.PanelFormSecundario.Controls.Add(this.lblUsuario);
            this.PanelFormSecundario.Cursor = System.Windows.Forms.Cursors.No;
            this.PanelFormSecundario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormSecundario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PanelFormSecundario.Location = new System.Drawing.Point(0, 102);
            this.PanelFormSecundario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PanelFormSecundario.Name = "PanelFormSecundario";
            this.PanelFormSecundario.Size = new System.Drawing.Size(1616, 775);
            this.PanelFormSecundario.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Karpicentro.Properties.Resources.TablonMInecraft;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(1176, 401);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(189, 172);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Karpicentro.Properties.Resources.LineaBlanca;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(709, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 559);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Home_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1616, 877);
            this.Controls.Add(this.PanelFormSecundario);
            this.Controls.Add(this.PanelBotones);
            this.Name = "Home_Empleado";
            this.Text = "Home_Empleado";
            this.PanelBotones.ResumeLayout(false);
            this.PanelBotones.PerformLayout();
            this.PanelFormSecundario.ResumeLayout(false);
            this.PanelFormSecundario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelBotones;
        private FontAwesome.Sharp.IconButton BtnCatalogo;
        private FontAwesome.Sharp.IconButton BtnVentas;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel PanelFormSecundario;
        private FontAwesome.Sharp.IconButton BtnHome;
    }
}