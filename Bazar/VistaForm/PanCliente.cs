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
    public partial class PanCliente : Form
    {
        Principal principal = new Principal();
        public PanCliente()
        {
            InitializeComponent();
        }

        //Boton para carrar arriba a la derecha 
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            PanPrincipal irprincipal = new PanPrincipal();
            irprincipal.Show();
            this.Hide();
        }

        //Boton para ir a dar de alta un cliente
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanAltaClientes PanAlta = new PanAltaClientes();
            PanAlta.ShowDialog();
        }

        //cuando carga la pantalla 
        private void PanCliente_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            PersistenciaDato instanciaPersistencia = new PersistenciaDato();
            instanciaPersistencia.InicializarArchivo();
            Principal instanciaPrincipal = new Principal();
            instanciaPrincipal.RellenarLista();

            dataGridView1.DataSource = instanciaPrincipal.ValidarCliente();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Boton para dar de baja un cliente
        private void BBajaCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }
            else
            {
                // busco el seleccionado
                Cliente CliSelec = dataGridView1.SelectedRows[0].DataBoundItem as Cliente;
                principal = new Principal();
                principal.BajaCliente(CliSelec.idCliente);
                MessageBox.Show("Baja exitosa");

                PanCliente irGrilla = new PanCliente();
                irGrilla.Show();
                this.Hide();
            }
        }

        //Boton para modificar un cliente 
        private void BModificarCliente_Click(object sender, EventArgs e)
        {
            PanModificarCliente clienteModificado = new PanModificarCliente();
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            } else {
                foreach (DataGridViewRow indice in dataGridView1.SelectedRows)
                {
                    int idClienteModificado = Convert.ToInt32(indice.Cells[0].Value);

                    clienteModificado.BNombreMCliente.Text = indice.Cells[3].Value.ToString();
                    clienteModificado.BApellidoMCliente.Text = indice.Cells[6].Value.ToString();
                    clienteModificado.BDniMCliente.Text = indice.Cells[1].Value.ToString();
                    clienteModificado.BDireccionMCliente.Text = indice.Cells[4].Value.ToString();
                    clienteModificado.BEmailMCliente.Text = indice.Cells[5].Value.ToString();
                    clienteModificado.BCuilMCliente.Text = indice.Cells[2].Value.ToString();
                    clienteModificado.BIdMCliente.Text = idClienteModificado.ToString();
                }
            }

            clienteModificado.Show();  
            this.Hide();
        }

        //Boton para la busqueda de cliente por ID
        private void BBuscar_Click(object sender, EventArgs e)
        {
            int idcliente = int.Parse(textBoxBuscar.Text);
            dataGridView1.DataSource = principal.BuscarClientePorID(idcliente);
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        //Boton para buscar un cliente por nombre
        private void BBuscarNombre_Click(object sender, EventArgs e)
        {
            string nombrecliente = textBoxBNombre.Text;
            dataGridView1.DataSource = principal.BuscarProductoPorNombre(nombrecliente);
        }
    }
}
