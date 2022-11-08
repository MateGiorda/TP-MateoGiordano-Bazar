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
using VistaForm;

namespace FormularioParaBazar
{
    public partial class PanProductos : Form
    {
        Principal principal = new Principal();
        public PanProductos()
        {
            InitializeComponent();
        }

        //Boton para dar de baja a un producto
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }
            else
            {
                // busco el seleccionado
                Producto ProSelec = dataGridView1.SelectedRows[0].DataBoundItem as Producto;
                principal = new Principal();
                principal.BajaProducto(ProSelec.idProducto);
                MessageBox.Show("Baja exitosa");

                PanProductos irGrilla = new PanProductos();
                irGrilla.Show();
                this.Hide();
            }
        }

        //Boton de arriba a la derecha para ir al principal
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            PanPrincipal irprincipal = new PanPrincipal();
            irprincipal.Show();
            this.Hide();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            PersistenciaDato instanciaPersistencia = new PersistenciaDato();
            instanciaPersistencia.InicializarArchivo();
            Principal instanciaPrincipal = new Principal();
            instanciaPrincipal.RellenarLista();

            dataGridView1.DataSource = instanciaPrincipal.ValidarProducto();
        }

        //Boton para dar de alta un producto
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanAltaProductos PanAlta = new PanAltaProductos();
            PanAlta.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BModificarProducto_Click(object sender, EventArgs e)
        {
            PanModificarProducto productoModificado = new PanModificarProducto();
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }
            else
            {
                foreach (DataGridViewRow indice in dataGridView1.SelectedRows)
                {
                    int idProductoModificado = Convert.ToInt32(indice.Cells[0].Value);

                    productoModificado.BNombreMProducto.Text = indice.Cells[1].Value.ToString();
                    productoModificado.BPrecioMProducto.Text = indice.Cells[2].Value.ToString();
                    productoModificado.BCantidadMProducto.Text = indice.Cells[3].Value.ToString();
                    productoModificado.BDescripcionMProducto.Text = indice.Cells[4].Value.ToString();
                    productoModificado.BColorMProducto.Text = indice.Cells[5].Value.ToString();
                    productoModificado.BMaterialMProducto.Text = indice.Cells[6].Value.ToString();
                    productoModificado.BIdMProducto.Text = idProductoModificado.ToString();
                }
                this.Hide();
                productoModificado.Show();
            }
        }

        //Boton para buscar un producto por ID

        private void BBuscar_Click(object sender, EventArgs e)
        {
            int idproducto = int.Parse(textBoxBuscar.Text);
            dataGridView1.DataSource = principal.BuscarProductoPorID(idproducto);
        }

        //Boton para Buscar un producto por nombre
        private void BBuscarNombre_Click(object sender, EventArgs e)
        {
            string nombreprod = textBoxBNombre.Text;
            dataGridView1.DataSource = principal.BuscarProductoPorNombre(nombreprod);
        }
    }
}
