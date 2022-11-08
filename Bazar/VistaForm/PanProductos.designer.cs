namespace FormularioParaBazar
{
    partial class PanProductos
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
            this.BBajaProducto = new System.Windows.Forms.Button();
            this.BModificarProducto = new System.Windows.Forms.Button();
            this.BAltaProducto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCerrar = new System.Windows.Forms.Label();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.BBuscar = new System.Windows.Forms.Button();
            this.textBoxBNombre = new System.Windows.Forms.TextBox();
            this.BBuscarNombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTOS";
            // 
            // BBajaProducto
            // 
            this.BBajaProducto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BBajaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BBajaProducto.FlatAppearance.BorderSize = 0;
            this.BBajaProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BBajaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBajaProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBajaProducto.ForeColor = System.Drawing.Color.White;
            this.BBajaProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBajaProducto.Location = new System.Drawing.Point(271, 382);
            this.BBajaProducto.Name = "BBajaProducto";
            this.BBajaProducto.Size = new System.Drawing.Size(250, 40);
            this.BBajaProducto.TabIndex = 1;
            this.BBajaProducto.Text = "BAJA";
            this.BBajaProducto.UseVisualStyleBackColor = false;
            this.BBajaProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // BModificarProducto
            // 
            this.BModificarProducto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BModificarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BModificarProducto.FlatAppearance.BorderSize = 0;
            this.BModificarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BModificarProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BModificarProducto.ForeColor = System.Drawing.Color.White;
            this.BModificarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BModificarProducto.Location = new System.Drawing.Point(527, 382);
            this.BModificarProducto.Name = "BModificarProducto";
            this.BModificarProducto.Size = new System.Drawing.Size(250, 40);
            this.BModificarProducto.TabIndex = 2;
            this.BModificarProducto.Text = "MODIFICAR";
            this.BModificarProducto.UseVisualStyleBackColor = false;
            this.BModificarProducto.Click += new System.EventHandler(this.BModificarProducto_Click);
            // 
            // BAltaProducto
            // 
            this.BAltaProducto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BAltaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BAltaProducto.FlatAppearance.BorderSize = 0;
            this.BAltaProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BAltaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAltaProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAltaProducto.ForeColor = System.Drawing.Color.White;
            this.BAltaProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAltaProducto.Location = new System.Drawing.Point(15, 382);
            this.BAltaProducto.Name = "BAltaProducto";
            this.BAltaProducto.Size = new System.Drawing.Size(250, 40);
            this.BAltaProducto.TabIndex = 3;
            this.BAltaProducto.Text = "ALTA";
            this.BAltaProducto.UseVisualStyleBackColor = false;
            this.BAltaProducto.Click += new System.EventHandler(this.button3_Click);
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
            this.idProductoDataGridViewTextBoxColumn,
            this.nombreProdDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(15, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(762, 281);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.Width = 83;
            // 
            // nombreProdDataGridViewTextBoxColumn
            // 
            this.nombreProdDataGridViewTextBoxColumn.DataPropertyName = "nombreProd";
            this.nombreProdDataGridViewTextBoxColumn.HeaderText = "nombreProd";
            this.nombreProdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreProdDataGridViewTextBoxColumn.Name = "nombreProdDataGridViewTextBoxColumn";
            this.nombreProdDataGridViewTextBoxColumn.Width = 89;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 61;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 73;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 86;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 55;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "material";
            this.materialDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.Width = 68;
            // 
            // productoBindingSource2
            // 
            this.productoBindingSource2.DataSource = typeof(LogicaNet.Producto);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Gray;
            this.btnCerrar.Location = new System.Drawing.Point(774, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 17);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(LogicaNet.Producto);
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataSource = typeof(LogicaNet.Producto);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxBuscar.Location = new System.Drawing.Point(133, 347);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(233, 20);
            this.textBoxBuscar.TabIndex = 15;
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
            this.BBuscar.Location = new System.Drawing.Point(15, 343);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(105, 23);
            this.BBuscar.TabIndex = 14;
            this.BBuscar.Text = "Buscar ID";
            this.BBuscar.UseVisualStyleBackColor = false;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // textBoxBNombre
            // 
            this.textBoxBNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxBNombre.Location = new System.Drawing.Point(543, 346);
            this.textBoxBNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBNombre.Name = "textBoxBNombre";
            this.textBoxBNombre.Size = new System.Drawing.Size(233, 20);
            this.textBoxBNombre.TabIndex = 17;
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
            this.BBuscarNombre.Location = new System.Drawing.Point(425, 343);
            this.BBuscarNombre.Name = "BBuscarNombre";
            this.BBuscarNombre.Size = new System.Drawing.Size(105, 22);
            this.BBuscarNombre.TabIndex = 16;
            this.BBuscarNombre.Text = "Buscar Nombre";
            this.BBuscarNombre.UseVisualStyleBackColor = false;
            this.BBuscarNombre.Click += new System.EventHandler(this.BBuscarNombre_Click);
            // 
            // PanProductos
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
            this.Controls.Add(this.BAltaProducto);
            this.Controls.Add(this.BModificarProducto);
            this.Controls.Add(this.BBajaProducto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BBajaProducto;
        private System.Windows.Forms.Button BModificarProducto;
        private System.Windows.Forms.Button BAltaProducto;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private System.Windows.Forms.BindingSource productoBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.TextBox textBoxBNombre;
        private System.Windows.Forms.Button BBuscarNombre;
    }
}