using FormularioParaBazar;
using LogicaNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class PanModificarProducto : Form
    {
        Principal principal = new Principal();

        public PanModificarProducto()
        {
            InitializeComponent();
        }

        //Boton para cerrar arriba a la derecha
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Boton para cancelar la modificacion 
        private void BCancelarModificacion_Click(object sender, EventArgs e)
        {
            PanProductos irmenu = new PanProductos();
            irmenu.Show();
            this.Hide();
        }

        //Boton para guardar la modificacion 
        private void BGuardarModificacion_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro de que quieres modifcarlo?", "Modificar producto", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Producto ProductoModificado = new Producto();

                ProductoModificado.nombreProd = BNombreMProducto.Text;
                ProductoModificado.precio = int.Parse(BPrecioMProducto.Text);
                ProductoModificado.cantidad = int.Parse(BCantidadMProducto.Text);
                ProductoModificado.descripcion = BDescripcionMProducto.Text;
                ProductoModificado.color = BColorMProducto.Text;
                ProductoModificado.material = BMaterialMProducto.Text;
                ProductoModificado.idProducto = int.Parse(BIdMProducto.Text);

                principal = new Principal();
                principal.RellenarLista();
                principal.ModificarProducto(ProductoModificado, int.Parse(BIdMProducto.Text));

                PanProductos irmenu = new PanProductos();
                irmenu.Show();
                this.Hide();
            }
        }

        //validar solamente letras 

        //Validar Nombre producto
        private void BNombreMProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //validar solamente numeros

        //Validar Precio producto
        private void BPrecioMProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BPrecioMProducto.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Validar Cantidad de productos
        private void BCantidadMProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BCantidadMProducto.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Validar ID producto
        private void BIdMProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BIdMProducto.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void PanModificarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
