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
            this.BtnCatalogo = new FontAwesome.Sharp.IconButton();
            this.BtnVentas = new FontAwesome.Sharp.IconButton();
            this.PanelFormSecundario = new System.Windows.Forms.Panel();
            this.PanelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBotones
            // 
            this.PanelBotones.BackColor = System.Drawing.Color.Transparent;
            this.PanelBotones.Controls.Add(this.BtnHome);
            this.PanelBotones.Controls.Add(this.BtnCatalogo);
            this.PanelBotones.Controls.Add(this.BtnVentas);
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBotones.ForeColor = System.Drawing.SystemColors.Control;
            this.PanelBotones.Location = new System.Drawing.Point(0, 0);
            this.PanelBotones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(1212, 83);
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
            this.BtnHome.Location = new System.Drawing.Point(1070, 0);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(142, 83);
            this.BtnHome.TabIndex = 4;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
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
            this.BtnCatalogo.Location = new System.Drawing.Point(147, 0);
            this.BtnCatalogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCatalogo.Name = "BtnCatalogo";
            this.BtnCatalogo.Size = new System.Drawing.Size(142, 83);
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
            this.BtnVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(147, 83);
            this.BtnVentas.TabIndex = 0;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVentas.UseVisualStyleBackColor = false;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // PanelFormSecundario
            // 
            this.PanelFormSecundario.AutoSize = true;
            this.PanelFormSecundario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.PanelFormSecundario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelFormSecundario.Cursor = System.Windows.Forms.Cursors.No;
            this.PanelFormSecundario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormSecundario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PanelFormSecundario.Location = new System.Drawing.Point(0, 83);
            this.PanelFormSecundario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelFormSecundario.Name = "PanelFormSecundario";
            this.PanelFormSecundario.Size = new System.Drawing.Size(1212, 630);
            this.PanelFormSecundario.TabIndex = 8;
            // 
            // Home_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1212, 713);
            this.Controls.Add(this.PanelFormSecundario);
            this.Controls.Add(this.PanelBotones);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Home_Empleado";
            this.Text = "Home_Empleado";
            this.PanelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelBotones;
        private FontAwesome.Sharp.IconButton BtnCatalogo;
        private FontAwesome.Sharp.IconButton BtnVentas;
        private System.Windows.Forms.Panel PanelFormSecundario;
        private FontAwesome.Sharp.IconButton BtnHome;
    }
}