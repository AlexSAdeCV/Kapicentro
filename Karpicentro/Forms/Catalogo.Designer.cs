namespace Karpicentro.Forms
{
    partial class Catalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PcbImgProducto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAdelante = new FontAwesome.Sharp.IconButton();
            this.BtnAtras = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnComprar = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImgProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PcbImgProducto
            // 
            this.PcbImgProducto.Location = new System.Drawing.Point(314, 142);
            this.PcbImgProducto.Name = "PcbImgProducto";
            this.PcbImgProducto.Size = new System.Drawing.Size(356, 329);
            this.PcbImgProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbImgProducto.TabIndex = 0;
            this.PcbImgProducto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 28.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "--Catalogo--";
            // 
            // BtnAdelante
            // 
            this.BtnAdelante.BackColor = System.Drawing.Color.Black;
            this.BtnAdelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdelante.Font = new System.Drawing.Font("SimSun-ExtB", 28.2F, System.Drawing.FontStyle.Bold);
            this.BtnAdelante.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAdelante.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.BtnAdelante.IconColor = System.Drawing.Color.White;
            this.BtnAdelante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAdelante.Location = new System.Drawing.Point(717, 232);
            this.BtnAdelante.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdelante.Name = "BtnAdelante";
            this.BtnAdelante.Size = new System.Drawing.Size(50, 132);
            this.BtnAdelante.TabIndex = 37;
            this.BtnAdelante.UseVisualStyleBackColor = false;
            this.BtnAdelante.Click += new System.EventHandler(this.BtnAdelante_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.Black;
            this.BtnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtras.Font = new System.Drawing.Font("SimSun-ExtB", 28.2F, System.Drawing.FontStyle.Bold);
            this.BtnAtras.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAtras.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.BtnAtras.IconColor = System.Drawing.Color.White;
            this.BtnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAtras.Location = new System.Drawing.Point(199, 232);
            this.BtnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(50, 132);
            this.BtnAtras.TabIndex = 38;
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(754, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(831, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "arpicentro";
            // 
            // BtnComprar
            // 
            this.BtnComprar.BackColor = System.Drawing.Color.Black;
            this.BtnComprar.BackgroundColor = System.Drawing.Color.Black;
            this.BtnComprar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnComprar.BorderRadius = 25;
            this.BtnComprar.BorderSize = 0;
            this.BtnComprar.FlatAppearance.BorderSize = 0;
            this.BtnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComprar.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComprar.ForeColor = System.Drawing.Color.White;
            this.BtnComprar.Location = new System.Drawing.Point(417, 486);
            this.BtnComprar.Name = "BtnComprar";
            this.BtnComprar.Size = new System.Drawing.Size(157, 55);
            this.BtnComprar.TabIndex = 42;
            this.BtnComprar.Text = "Comprar";
            this.BtnComprar.TextColor = System.Drawing.Color.White;
            this.BtnComprar.UseVisualStyleBackColor = false;
            this.BtnComprar.Click += new System.EventHandler(this.BtnComprar_Click_1);
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 713);
            this.Controls.Add(this.BtnComprar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnAdelante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PcbImgProducto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            ((System.ComponentModel.ISupportInitialize)(this.PcbImgProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PcbImgProducto;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnAdelante;
        private FontAwesome.Sharp.IconButton BtnAtras;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJButton BtnComprar;
    }
}