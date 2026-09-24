namespace Problema1_Productos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvProductos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewImageColumn();
            imageList1 = new ImageList(components);
            lblNombre = new Label();
            lblCantidad = new Label();
            lblPrecio = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            txtBusqueda = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            pbestatica = new PictureBox();
            label1 = new Label();
            txtNombre = new TextBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            lblId = new Label();
            txtId = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lblImagen = new Label();
            pbImagen = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbestatica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { id, Producto, Precio, Cantidad, Imagen });
            dgvProductos.Location = new Point(51, 294);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(518, 130);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Imagen
            // 
            Imagen.HeaderText = "Imagen";
            Imagen.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Imagen.Name = "Imagen";
            Imagen.Width = 125;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cerrar-sesion.png");
            imageList1.Images.SetKeyName(1, "limpiar.png");
            imageList1.Images.SetKeyName(2, "borrar.png");
            imageList1.Images.SetKeyName(3, "editar.png");
            imageList1.Images.SetKeyName(4, "disco-flexible.png");
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(50, 119);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = SystemColors.ButtonHighlight;
            lblCantidad.Location = new Point(50, 195);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.ForeColor = SystemColors.ButtonHighlight;
            lblPrecio.Location = new Point(50, 156);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(txtBusqueda);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(51, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 53);
            panel1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(349, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(102, 19);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(220, 23);
            txtBusqueda.TabIndex = 8;
            txtBusqueda.TextChanged += txt_Busqueda_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(18, 18);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 0;
            label2.Text = "Búsqueda:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(pbestatica);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(618, 82);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // pbestatica
            // 
            pbestatica.Image = (Image)resources.GetObject("pbestatica.Image");
            pbestatica.Location = new Point(400, 31);
            pbestatica.Name = "pbestatica";
            pbestatica.Size = new Size(32, 32);
            pbestatica.SizeMode = PictureBoxSizeMode.StretchImage;
            pbestatica.TabIndex = 16;
            pbestatica.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(50, 31);
            label1.Name = "label1";
            label1.Size = new Size(239, 32);
            label1.TabIndex = 15;
            label1.Text = "CRUD de productos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 119);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(282, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(107, 187);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(282, 23);
            txtCantidad.TabIndex = 7;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(107, 153);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(282, 23);
            txtPrecio.TabIndex = 8;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = SystemColors.ButtonHighlight;
            lblId.Location = new Point(50, 94);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 14;
            lblId.Text = "id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(107, 90);
            txtId.Name = "txtId";
            txtId.Size = new Size(282, 23);
            txtId.TabIndex = 15;
            // 
            // btnGuardar
            // 
            btnGuardar.ImageIndex = 4;
            btnGuardar.ImageList = imageList1;
            btnGuardar.Location = new Point(50, 449);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(97, 38);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Agregar";
            btnGuardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.ImageIndex = 3;
            btnModificar.ImageList = imageList1;
            btnModificar.Location = new Point(153, 449);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(97, 38);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ImageIndex = 2;
            btnEliminar.ImageList = imageList1;
            btnEliminar.Location = new Point(256, 449);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 38);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.ImageIndex = 1;
            btnLimpiar.ImageList = imageList1;
            btnLimpiar.Location = new Point(359, 449);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(97, 38);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.ImageIndex = 0;
            btnSalir.ImageList = imageList1;
            btnSalir.Location = new Point(462, 449);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(97, 38);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button5_Click;
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.ForeColor = SystemColors.ButtonHighlight;
            lblImagen.Location = new Point(416, 98);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(50, 15);
            lblImagen.TabIndex = 21;
            lblImagen.Text = "Imágen:";
            // 
            // pbImagen
            // 
            pbImagen.BackColor = SystemColors.AppWorkspace;
            pbImagen.Image = (Image)resources.GetObject("pbImagen.Image");
            pbImagen.Location = new Point(452, 116);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(107, 91);
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagen.TabIndex = 17;
            pbImagen.TabStop = false;
            pbImagen.Click += pbImagen_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(611, 499);
            Controls.Add(pbImagen);
            Controls.Add(lblImagen);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombre);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(lblNombre);
            Controls.Add(dgvProductos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbestatica).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private ImageList imageList1;
        private Label lblNombre;
        private Label lblCantidad;
        private Label lblPrecio;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtNombre;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Label lblId;
        private TextBox txtId;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label1;
        private Label lblImagen;
        private PictureBox pbestatica;
        private PictureBox pictureBox3;
        private TextBox txtBusqueda;
        private Label label2;
        private PictureBox pbImagen;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewImageColumn Imagen;
        private ErrorProvider errorProvider1;
    }
}
