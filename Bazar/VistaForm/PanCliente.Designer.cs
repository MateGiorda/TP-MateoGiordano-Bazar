namespace VistaForm
{
    partial class PanCliente
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
            this.BModificarCliente = new System.Windows.Forms.Button();
            this.BBajaCliente = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.BBuscar = new System.Windows.Forms.Button();
            this.textBoxBNombre = new System.Windows.Forms.TextBox();
            this.BBuscarNombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CLIENTES";
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
            this.button3.Location = new System.Drawing.Point(15, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "ALTA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BModificarCliente
            // 
            this.BModificarCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BModificarCliente.FlatAppearance.BorderSize = 0;
            this.BModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BModificarCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BModificarCliente.ForeColor = System.Drawing.Color.White;
            this.BModificarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BModificarCliente.Location = new System.Drawing.Point(527, 381);
            this.BModificarCliente.Name = "BModificarCliente";
            this.BModificarCliente.Size = new System.Drawing.Size(250, 40);
            this.BModificarCliente.TabIndex = 5;
            this.BModificarCliente.Text = "MODIFICAR";
            this.BModificarCliente.UseVisualStyleBackColor = false;
            this.BModificarCliente.Click += new System.EventHandler(this.BModificarCliente_Click);
            // 
            // BBajaCliente
            // 
            this.BBajaCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BBajaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BBajaCliente.FlatAppearance.BorderSize = 0;
            this.BBajaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BBajaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBajaCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBajaCliente.ForeColor = System.Drawing.Color.White;
            this.BBajaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBajaCliente.Location = new System.Drawing.Point(271, 381);
            this.BBajaCliente.Name = "BBajaCliente";
            this.BBajaCliente.Size = new System.Drawing.Size(250, 40);
            this.BBajaCliente.TabIndex = 4;
            this.BBajaCliente.Text = "BAJA";
            this.BBajaCliente.UseVisualStyleBackColor = false;
            this.BBajaCliente.Click += new System.EventHandler(this.BBajaCliente_Click);
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
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.idClienteDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.cuilDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(752, 276);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.Width = 72;
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
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(LogicaNet.Cliente);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxBuscar.Location = new System.Drawing.Point(133, 346);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(233, 20);
            this.textBoxBuscar.TabIndex = 19;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
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
            this.BBuscar.Location = new System.Drawing.Point(15, 342);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(105, 23);
            this.BBuscar.TabIndex = 18;
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
            this.textBoxBNombre.TabIndex = 21;
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
            this.BBuscarNombre.TabIndex = 20;
            this.BBuscarNombre.Text = "Buscar Nombre";
            this.BBuscarNombre.UseVisualStyleBackColor = false;
            this.BBuscarNombre.Click += new System.EventHandler(this.BBuscarNombre_Click);
            // 
            // PanCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxBNombre);
            this.Controls.Add(this.BBuscarNombre);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BModificarCliente);
            this.Controls.Add(this.BBajaCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.PanCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BModificarCliente;
        private System.Windows.Forms.Button BBajaCliente;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
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