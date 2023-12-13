namespace Karpicentro.Forms
{
    partial class Login
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
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TxtContraseña = new CustomControls.RJControls.RJTextBox();
            this.TxtUsuario = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.BtnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.Location = new System.Drawing.Point(486, 266);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(82, 32);
            this.BtnIngresar.TabIndex = 20;
            this.BtnIngresar.Text = "Iniciar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BackColor = System.Drawing.Color.White;
            this.TxtContraseña.BorderColor = System.Drawing.Color.Black;
            this.TxtContraseña.BorderFocusColor = System.Drawing.Color.Black;
            this.TxtContraseña.BorderRadius = 0;
            this.TxtContraseña.BorderSize = 2;
            this.TxtContraseña.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.ForeColor = System.Drawing.Color.Black;
            this.TxtContraseña.Location = new System.Drawing.Point(369, 217);
            this.TxtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.TxtContraseña.Multiline = false;
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.TxtContraseña.PasswordChar = true;
            this.TxtContraseña.PlaceholderColor = System.Drawing.Color.Black;
            this.TxtContraseña.PlaceholderText = "Contraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(298, 28);
            this.TxtContraseña.TabIndex = 19;
            this.TxtContraseña.UnderlinedStyle = true;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.White;
            this.TxtUsuario.BorderColor = System.Drawing.Color.Black;
            this.TxtUsuario.BorderFocusColor = System.Drawing.Color.Black;
            this.TxtUsuario.BorderRadius = 0;
            this.TxtUsuario.BorderSize = 2;
            this.TxtUsuario.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.Black;
            this.TxtUsuario.Location = new System.Drawing.Point(369, 169);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsuario.Multiline = false;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.TxtUsuario.PasswordChar = false;
            this.TxtUsuario.PlaceholderColor = System.Drawing.Color.Black;
            this.TxtUsuario.PlaceholderText = "Usuario";
            this.TxtUsuario.Size = new System.Drawing.Size(298, 28);
            this.TxtUsuario.TabIndex = 18;
            this.TxtUsuario.UnderlinedStyle = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.BackgroundImage = global::Karpicentro.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 448);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnIngresar;
        private CustomControls.RJControls.RJTextBox TxtContraseña;
        private CustomControls.RJControls.RJTextBox TxtUsuario;
    }
}