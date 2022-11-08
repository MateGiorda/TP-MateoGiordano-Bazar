namespace VistaForm
{
    partial class PanEmpleados
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
            this.button3 = new System.Windows.Forms.Button();
            this.BModificarEmpleado = new System.Windows.Forms.Button();
            this.BBajaEmpleado = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCerrar = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.BBuscar = new System.Windows.Forms.Button();
            this.textBoxBNombre = new System.Windows.Forms.TextBox();
            this.BBuscarNombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPLEADOS";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(14, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "ALTA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BModificarEmpleado
            // 
            this.BModificarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BModificarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BModificarEmpleado.FlatAppearance.BorderSize = 0;
            this.BModificarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BModificarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BModificarEmpleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BModificarEmpleado.ForeColor = System.Drawing.Color.White;
            this.BModificarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BModificarEmpleado.Location = new System.Drawing.Point(526, 380);
            this.BModificarEmpleado.Name = "BModificarEmpleado";
            this.BModificarEmpleado.Size = new System.Drawing.Size(250, 40);
            this.BModificarEmpleado.TabIndex = 5;
            this.BModificarEmpleado.Text = "MODIFICAR";
            this.BModificarEmpleado.UseVisualStyleBackColor = false;
            this.BModificarEmpleado.Click += new System.EventHandler(this.button2_Click);
            // 
            // BBajaEmpleado
            // 
            this.BBajaEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BBajaEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BBajaEmpleado.FlatAppearance.BorderSize = 0;
            this.BBajaEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BBajaEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBajaEmpleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBajaEmpleado.ForeColor = System.Drawing.Color.White;
            this.BBajaEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBajaEmpleado.Location = new System.Drawing.Point(270, 380);
            this.BBajaEmpleado.Name = "BBajaEmpleado";
            this.BBajaEmpleado.Size = new System.Drawing.Size(250, 40);
            this.BBajaEmpleado.TabIndex = 4;
            this.BBajaEmpleado.Text = "BAJA";
            this.BBajaEmpleado.UseVisualStyleBackColor = false;
            this.BBajaEmpleado.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleadoDataGridViewTextBoxColumn,
            this.sueldoDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.cuilDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empleadoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(762, 279);
            this.dataGridView1.TabIndex = 7;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "idEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            this.idEmpleadoDataGridViewTextBoxColumn.Width = 87;
            // 
            // sueldoDataGridViewTextBoxColumn
            // 
            this.sueldoDataGridViewTextBoxColumn.DataPropertyName = "sueldo";
            this.sueldoDataGridViewTextBoxColumn.HeaderText = "sueldo";
            this.sueldoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sueldoDataGridViewTextBoxColumn.Name = "sueldoDataGridViewTextBoxColumn";
            this.sueldoDataGridViewTextBoxColumn.Width = 63;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "dni";
            this.dniDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.Width = 46;
            // 
            // cuilDataGridViewTextBoxColumn
            // 
            this.cuilDataGridViewTextBoxColumn.DataPropertyName = "cuil";
            this.cuilDataGridViewTextBoxColumn.HeaderText = "cuil";
            this.cuilDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cuilDataGridViewTextBoxColumn.Name = "cuilDataGridViewTextBoxColumn";
            this.cuilDataGridViewTextBoxColumn.Width = 48;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 67;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Width = 75;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 56;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.Width = 68;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(LogicaNet.Empleado);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Gray;
            this.btnCerrar.Location = new System.Drawing.Point(771, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 17);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxBuscar.Location = new System.Drawing.Point(132, 345);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(233, 20);
            this.textBoxBuscar.TabIndex = 17;
            // 
            // BBuscar
            // 
            this.BBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BBuscar.FlatAppearance.BorderSize = 0;
            this.BBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.Color.White;
            this.BBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBuscar.Location = new System.Drawing.Point(14, 342);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(105, 23);
            this.BBuscar.TabIndex = 16;
            this.BBuscar.Text = "Buscar ID";
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // textBoxBNombre
            // 
            this.textBoxBNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxBNombre.Location = new System.Drawing.Point(543, 345);
            this.textBoxBNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBNombre.Name = "textBoxBNombre";
            this.textBoxBNombre.Size = new System.Drawing.Size(233, 20);
            this.textBoxBNombre.TabIndex = 19;
            // 
            // BBuscarNombre
            // 
            this.BBuscarNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BBuscarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BBuscarNombre.FlatAppearance.BorderSize = 0;
            this.BBuscarNombre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BBuscarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarNombre.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarNombre.ForeColor = System.Drawing.Color.White;
            this.BBuscarNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBuscarNombre.Location = new System.Drawing.Point(425, 342);
            this.BBuscarNombre.Name = "BBuscarNombre";
            this.BBuscarNombre.Size = new System.Drawing.Size(105, 22);
            this.BBuscarNombre.TabIndex = 18;
            this.BBuscarNombre.Text = "Buscar Nombre";
            this.BBuscarNombre.UseVisualStyleBackColor = false;
            this.BBuscarNombre.Click += new System.EventHandler(this.BBuscarNombre_Click);
            // 
            // PanEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxBNombre);
            this.Controls.Add(this.BBuscarNombre);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BModificarEmpleado);
            this.Controls.Add(this.BBajaEmpleado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.PanEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BModificarEmpleado;
        private System.Windows.Forms.Button BBajaEmpleado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.TextBox textBoxBNombre;
        private System.Windows.Forms.Button BBuscarNombre;
    }
}