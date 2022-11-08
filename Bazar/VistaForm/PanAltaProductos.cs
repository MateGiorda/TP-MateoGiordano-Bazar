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
    public partial class PanAltaProductos : Form
    {
        Producto productoNuevo = new Producto();
        Principal principal = new Principal();
        public PanAltaProductos()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Boton para cerrar arriba a la derecha 
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Boton para dar de alta un producto 
        private void button1_Click(object sender, EventArgs e)
        {
            productoNuevo = new Producto();
            productoNuevo.nombreProd = BNombreProducto.Text;
            productoNuevo.precio = int.Parse(BPrecioProducto.Text);
            productoNuevo.cantidad = int.Parse(BCantidadProducto.Text);
            productoNuevo.descripcion = BDescripcionProducto.Text;
            productoNuevo.color = BColorProducto.Text;
            productoNuevo.material = BMaterialProducto.Text;
            productoNuevo.idProducto = int.Parse(BIdProducto.Text);

            principal = new Principal();
            principal.RellenarLista();
            principal.AltaProducto(productoNuevo, productoNuevo.idProducto);

            PanProductos irmenu = new PanProductos();
            irmenu.Show();
            this.Hide();
        }

        private void PanAltaProductos_Load(object sender, EventArgs e)
        {

        }

        //Boton para cancelar el alta
        private void BCancelarAlta_Click(object sender, EventArgs e)
        {
            PanProductos irmenu = new PanProductos();
            irmenu.Show();
            this.Hide();
        }

        // validacion solamente letras

        //Validar nombre producto
        private void BNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
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

        //validacion solamente numeros

        //Validar precio producto
        private void BPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BPrecioProducto.Text.Contains(".")))
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
        private void BCantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BCantidadProducto.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Validar ID de producto
        private void BIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BCantidadProducto.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
