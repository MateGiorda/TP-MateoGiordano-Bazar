namespace VistaForm
{
    partial class PanModificarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanModificarCliente));
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.BGuardarModificacion = new System.Windows.Forms.Button();
            this.BCancelarModificacion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BIdMCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BCuilMCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BEmailMCliente = new System.Windows.Forms.TextBox();
            this.BDireccionMCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BDniMCliente = new System.Windows.Forms.TextBox();
            this.BApellidoMCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BNombreMCliente = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(749, 8);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(25, 25);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 59;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // BGuardarModificacion
            // 
            this.BGuardarModificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BGuardarModificacion.FlatAppearance.BorderSize = 0;
            this.BGuardarModificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BGuardarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardarModificacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardarModificacion.ForeColor = System.Drawing.Color.White;
            this.BGuardarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardarModificacion.Location = new System.Drawing.Point(406, 402);
            this.BGuardarModificacion.Name = "BGuardarModificacion";
            this.BGuardarModificacion.Size = new System.Drawing.Size(250, 40);
            this.BGuardarModificacion.TabIndex = 56;
            this.BGuardarModificacion.Text = "Guardar";
            this.BGuardarModificacion.UseVisualStyleBackColor = false;
            this.BGuardarModificacion.Click += new System.EventHandler(this.BGuardarModificacion_Click);
            // 
            // BCancelarModificacion
            // 
            this.BCancelarModificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BCancelarModificacion.FlatAppearance.BorderSize = 0;
            this.BCancelarModificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BCancelarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelarModificacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelarModificacion.ForeColor = System.Drawing.Color.White;
            this.BCancelarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCancelarModificacion.Location = new System.Drawing.Point(100, 402);
            this.BCancelarModificacion.Name = "BCancelarModificacion";
            this.BCancelarModificacion.Size = new System.Drawing.Size(250, 40);
            this.BCancelarModificacion.TabIndex = 55;
            this.BCancelarModificacion.Text = "Cancelar";
            this.BCancelarModificacion.UseVisualStyleBackColor = false;
            this.BCancelarModificacion.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(251, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 38);
            this.label8.TabIndex = 53;
            this.label8.Text = "Modificar cliente";
            // 
            // BIdMCliente
            // 
            this.BIdMCliente.Location = new System.Drawing.Point(142, 304);
            this.BIdMCliente.Name = "BIdMCliente";
            this.BIdMCliente.Size = new System.Drawing.Size(333, 20);
            this.BIdMCliente.TabIndex = 57;
            this.BIdMCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BIdMCliente_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(94, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 22);
            this.label9.TabIndex = 58;
            this.label9.Text = "ID";
            // 
            // BCuilMCliente
            // 
            this.BCuilMCliente.Location = new System.Drawing.Point(142, 267);
            this.BCuilMCliente.Name = "BCuilMCliente";
            this.BCuilMCliente.Size = new System.Drawing.Size(333, 20);
            this.BCuilMCliente.TabIndex = 43;
            this.BCuilMCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BCuilMCliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(71, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 47;
            this.label2.Text = "CUIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(64, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 22);
            this.label6.TabIndex = 51;
            this.label6.Text = "Email";
            // 
            // BEmailMCliente
            // 
            this.BEmailMCliente.Location = new System.Drawing.Point(142, 224);
            this.BEmailMCliente.Name = "BEmailMCliente";
            this.BEmailMCliente.Size = new System.Drawing.Size(333, 20);
            this.BEmailMCliente.TabIndex = 45;
            // 
            // BDireccionMCliente
            // 
            this.BDireccionMCliente.Location = new System.Drawing.Point(142, 185);
            this.BDireccionMCliente.Name = "BDireccionMCliente";
            this.BDireccionMCliente.Size = new System.Drawing.Size(333, 20);
            this.BDireccionMCliente.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(26, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 50;
            this.label5.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(80, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 46;
            this.label1.Text = "DNI";
            // 
            // BDniMCliente
            // 
            this.BDniMCliente.Location = new System.Drawing.Point(142, 146);
            this.BDniMCliente.Name = "BDniMCliente";
            this.BDniMCliente.Size = new System.Drawing.Size(333, 20);
            this.BDniMCliente.TabIndex = 41;
            this.BDniMCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BDniMCliente_KeyPress);
            // 
            // BApellidoMCliente
            // 
            this.BApellidoMCliente.Location = new System.Drawing.Point(142, 107);
            this.BApellidoMCliente.Name = "BApellidoMCliente";
            this.BApellidoMCliente.Size = new System.Drawing.Size(333, 20);
            this.BApellidoMCliente.TabIndex = 40;
            this.BApellidoMCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BNombreMCliente_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(40, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 49;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(41, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nombre";
            // 
            // BNombreMCliente
            // 
            this.BNombreMCliente.Location = new System.Drawing.Point(142, 70);
            this.BNombreMCliente.Name = "BNombreMCliente";
            this.BNombreMCliente.Size = new System.Drawing.Size(333, 20);
            this.BNombreMCliente.TabIndex = 39;
            this.BNombreMCliente.TextChanged += new System.EventHandler(this.BNombreMCliente_TextChanged);
            this.BNombreMCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BNombreMCliente_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // PanModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BIdMCliente);
            this.Controls.Add(this.BGuardarModificacion);
            this.Controls.Add(this.BCancelarModificacion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BEmailMCliente);
            this.Controls.Add(this.BCuilMCliente);
            this.Controls.Add(this.BDireccionMCliente);
            this.Controls.Add(this.BDniMCliente);
            this.Controls.Add(this.BApellidoMCliente);
            this.Controls.Add(this.BNombreMCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanModificarCliente";
            this.Text = "PanModificarCliente";
            this.Load += new System.EventHandler(this.PanModificarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.Button BGuardarModificacion;
        private System.Windows.Forms.Button BCancelarModificacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox BIdMCliente;
        public System.Windows.Forms.TextBox BCuilMCliente;
        public System.Windows.Forms.TextBox BEmailMCliente;
        public System.Windows.Forms.TextBox BDireccionMCliente;
        public System.Windows.Forms.TextBox BDniMCliente;
        public System.Windows.Forms.TextBox BApellidoMCliente;
        public System.Windows.Forms.TextBox BNombreMCliente;
    }
}