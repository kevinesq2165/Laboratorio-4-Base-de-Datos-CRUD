using System.Drawing.Imaging;
using System.IO;
using System.Collections.Generic;


namespace Problema1_Productos
{
    public partial class Form1 : Form
    {
        private List<Producto> listaProductos;
        private Dictionary<string, object> myProducto = new Dictionary<string, object>();
        private List<(TextBox txt, IValidadorCampo validador)> camposValidar = new();

        public Form1()
        {
            InitializeComponent();
            listaProductos = new List<Producto>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }
        private void cargarProductos(string filtro = "")
        {
            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();
            listaProductos = Conexion.GetProductos(filtro);

            foreach (var prod in listaProductos)
            {
                Image img = null;

                if (prod.Imagen != null && prod.Imagen.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(prod.Imagen))
                    {
                        using (Bitmap bmp = new Bitmap(ms))
                        {
                            img = new Bitmap(bmp);
                        }
                    }
                }

                dgvProductos.Rows.Add(prod.Id, prod.Nombre, prod.Precio, prod.Cantidad, img);
            }
        }

        private bool datosCorrectos()
        {
            camposValidar.Clear();

            camposValidar.Add((txtNombre, new ValidadorTexto()));
            camposValidar.Add((txtPrecio, new ValidadorDecimal()));
            camposValidar.Add((txtCantidad, new ValidadorEntero()));

            foreach (var item in camposValidar)
            {
                if (!item.validador.EsValido(item.txt.Text))
                {
                    errorProvider1.SetError(item.txt, item.validador.MensajeError);
                    return false;
                }
                else
                {
                    errorProvider1.SetError(item.txt, string.Empty);
                }
            }

            return true;
        }

        private byte[] ImageToByteArray(Image? image)
        {
            if (image == null)
                return null;

            using (MemoryStream mMemoryStream = new MemoryStream())
            {
                image.Save(mMemoryStream, ImageFormat.Png);
                return mMemoryStream.ToArray();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo..");
            this.Close();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
            {
                return;
            }

            myProducto["Nombre"] = txtNombre.Text.Trim();
            myProducto["Precio"] = decimal.Parse(txtPrecio.Text.Trim());
            myProducto["Cantidad"] = int.Parse(txtCantidad.Text.Trim());
            myProducto["Imagen"] = ImageToByteArray(pbImagen.Image);

            if (Conexion.InsertSeguro("productos", myProducto))
            {
                MessageBox.Show("Se ha guardado satisfactoriamente el registro");
                cargarProductos();
            }
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar imagen del producto";
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbImagen.Image = Image.FromFile(openFileDialog.FileName);
                    pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void txt_Busqueda_TextChanged(object sender, EventArgs e)
        {
            cargarProductos(txtBusqueda.Text.Trim());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un producto para eliminar");
                return;
            }

            int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["id"].Value);

            DialogResult confirmacion = MessageBox.Show("¿Seguro que quieres eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirmacion == DialogResult.Yes)
            {
                if (Conexion.EliminarProducto(id))
                {
                    MessageBox.Show("Producto eliminado");
                    cargarProductos();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            pbImagen.Image = null;
        }
        private int idSeleccionado = 0;
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

            idSeleccionado = Convert.ToInt32(fila.Cells["id"].Value);
            txtNombre.Text = Convert.ToString(fila.Cells["Producto"].Value);
            txtPrecio.Text = Convert.ToDecimal(fila.Cells["Precio"].Value).ToString();
            txtCantidad.Text = Convert.ToInt32(fila.Cells["Cantidad"].Value).ToString();

            if (fila.Cells["Imagen"].Value != null)
            {
                pbImagen.Image = (Image)fila.Cells["Imagen"].Value;
            }
            else
            {
                pbImagen.Image = null;
            }
           btnGuardar.Enabled = false;
           btnModificar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un producto del grid para modificar");
                return;
            }

            if (!datosCorrectos())
            {
                return;
            }

            myProducto["Nombre"] = txtNombre.Text.Trim();
            myProducto["Precio"] = decimal.Parse(txtPrecio.Text.Trim());
            myProducto["Cantidad"] = int.Parse(txtCantidad.Text.Trim());
            myProducto["Imagen"] = ImageToByteArray(pbImagen.Image);

            if (Conexion.ModificarSeguro("productos", myProducto, idSeleccionado))
            {
                MessageBox.Show("Producto modificado correctamente");
                cargarProductos();
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
