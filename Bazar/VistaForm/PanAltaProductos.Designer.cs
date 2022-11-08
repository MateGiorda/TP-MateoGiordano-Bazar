namespace VistaForm
{
    partial class PanAltaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanAltaProductos));
            this.BNombreProducto = new System.Windows.Forms.TextBox();
            this.BPrecioProducto = new System.Windows.Forms.TextBox();
            this.BCantidadProducto = new System.Windows.Forms.TextBox();
            this.BDescripcionProducto = new System.Windows.Forms.TextBox();
            this.BMaterialProducto = new System.Windows.Forms.TextBox();
            this.BIdProducto = new System.Windows.Forms.TextBox();
            this.BColorProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BCancelarAlta = new System.Windows.Forms.Button();
            this.GuardarAlta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BNombreProducto
            // 
            this.BNombreProducto.Location = new System.Drawing.Point(161, 85);
            this.BNombreProducto.Name = "BNombreProducto";
            this.BNombreProducto.Size = new System.Drawing.Size(333, 20);
            this.BNombreProducto.TabIndex = 0;
            this.BNombreProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.BNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BNombreProducto_KeyPress);
            // 
            // BPrecioProducto
            // 
            this.BPrecioProducto.Location = new System.Drawing.Point(161, 123);
            this.BPrecioProducto.Name = "BPrecioProducto";
            this.BPrecioProducto.Size = new System.Drawing.Size(333, 20);
            this.BPrecioProducto.TabIndex = 1;
            this.BPrecioProducto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.BPrecioProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BPrecioProducto_KeyPress);
            // 
            // BCantidadProducto
            // 
            this.BCantidadProducto.Location = new System.Drawing.Point(161, 162);
            this.BCantidadProducto.Name = "BCantidadProducto";
            this.BCantidadProducto.Size = new System.Drawing.Size(333, 20);
            this.BCantidadProducto.TabIndex = 2;
            this.BCantidadProducto.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.BCantidadProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BCantidadProducto_KeyPress);
            // 
            // BDescripcionProducto
            // 
            this.BDescripcionProducto.Location = new System.Drawing.Point(161, 201);
            this.BDescripcionProducto.Name = "BDescripcionProducto";
            this.BDescripcionProducto.Size = new System.Drawing.Size(333, 20);
            this.BDescripcionProducto.TabIndex = 3;
            this.BDescripcionProducto.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // BMaterialProducto
            // 
            this.BMaterialProducto.Location = new System.Drawing.Point(161, 283);
            this.BMaterialProducto.Name = "BMaterialProducto";
            this.BMaterialProducto.Size = new System.Drawing.Size(333, 20);
            this.BMaterialProducto.TabIndex = 4;
            this.BMaterialProducto.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // BIdProducto
            // 
            this.BIdProducto.Location = new System.Drawing.Point(161, 325);
            this.BIdProducto.Name = "BIdProducto";
            this.BIdProducto.Size = new System.Drawing.Size(333, 20);
            this.BIdProducto.TabIndex = 5;
            this.BIdProducto.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.BIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BIdProducto_KeyPress);
            // 
            // BColorProducto
            // 
            this.BColorProducto.Location = new System.Drawing.Point(161, 239);
            this.BColorProducto.Name = "BColorProducto";
            this.BColorProducto.Size = new System.Drawing.Size(333, 20);
            this.BColorProducto.TabIndex = 6;
            this.BColorProducto.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Material";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(114, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(287, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 38);
            this.label8.TabIndex = 14;
            this.label8.Text = "Alta Productos";
            // 
            // BCancelarAlta
            // 
            this.BCancelarAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BCancelarAlta.FlatAppearance.BorderSize = 0;
            this.BCancelarAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BCancelarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelarAlta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelarAlta.ForeColor = System.Drawing.Color.White;
            this.BCancelarAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCancelarAlta.Location = new System.Drawing.Point(118, 398);
            this.BCancelarAlta.Name = "BCancelarAlta";
            this.BCancelarAlta.Size = new System.Drawing.Size(250, 40);
            this.BCancelarAlta.TabIndex = 16;
            this.BCancelarAlta.Text = "Cancelar";
            this.BCancelarAlta.UseVisualStyleBackColor = false;
            this.BCancelarAlta.Click += new System.EventHandler(this.BCancelarAlta_Click);
            // 
            // GuardarAlta
            // 
            this.GuardarAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.GuardarAlta.FlatAppearance.BorderSize = 0;
            this.GuardarAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.GuardarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarAlta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarAlta.ForeColor = System.Drawing.Color.White;
            this.GuardarAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarAlta.Location = new System.Drawing.Point(424, 398);
            this.GuardarAlta.Name = "GuardarAlta";
            this.GuardarAlta.Size = new System.Drawing.Size(250, 40);
            this.GuardarAlta.TabIndex = 17;
            this.GuardarAlta.Text = "Guardar";
            this.GuardarAlta.UseVisualStyleBackColor = false;
            this.GuardarAlta.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(540, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(766, 9);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(25, 25);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 18;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // PanAltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.GuardarAlta);
            this.Controls.Add(this.BCancelarAlta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BColorProducto);
            this.Controls.Add(this.BIdProducto);
            this.Controls.Add(this.BMaterialProducto);
            this.Controls.Add(this.BDescripcionProducto);
            this.Controls.Add(this.BCantidadProducto);
            this.Controls.Add(this.BPrecioProducto);
            this.Controls.Add(this.BNombreProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanAltaProductos";
            this.Text = "PanAltaProductos";
            this.Load += new System.EventHandler(this.PanAltaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BNombreProducto;
        private System.Windows.Forms.TextBox BPrecioProducto;
        private System.Windows.Forms.TextBox BCantidadProducto;
        private System.Windows.Forms.TextBox BDescripcionProducto;
        private System.Windows.Forms.TextBox BMaterialProducto;
        private System.Windows.Forms.TextBox BIdProducto;
        private System.Windows.Forms.TextBox BColorProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BCancelarAlta;
        private System.Windows.Forms.Button GuardarAlta;
        private System.Windows.Forms.PictureBox iconcerrar;
    }
}