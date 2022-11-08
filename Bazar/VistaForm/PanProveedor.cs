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
    public partial class PanProveedor : Form
    {
        Principal principal = new Principal();
     
        public PanProveedor()
        {
            InitializeComponent();
        }

        //Boton de arriba a la derecha para cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            PanPrincipal irprincipal = new PanPrincipal();
            irprincipal.Show();
            this.Hide();
        }

        //Boton de Alta que dirige a la pantalla de alta
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanAltaProveedor frmloguin = new PanAltaProveedor();
            frmloguin.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //Boton para dar de baja un proveedor
        private void BBajaProveedor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un proveedor");
                return;
            } else
            {
                // busco el seleccionado
                Proveedor ProvSelec = dataGridView1.SelectedRows[0].DataBoundItem as Proveedor;
                principal = new Principal();
                principal.BajaProveedor(ProvSelec.idProveedor);
                MessageBox.Show("Baja exitosa");

                PanProveedor irGrilla = new PanProveedor();
                irGrilla.Show();
                this.Hide();
            }
        }

        private void PanProveedor_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            PersistenciaDato instanciaPersistencia = new PersistenciaDato();
            instanciaPersistencia.InicializarArchivo();
            Principal instanciaPrincipal = new Principal();
            instanciaPrincipal.RellenarLista();

            dataGridView1.DataSource = instanciaPrincipal.ValidarProveedor();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Boton para modificar proveedor
        private void BModificarProveedor_Click(object sender, EventArgs e)
        {
            PanModificarProveedor proveedorModificado = new PanModificarProveedor();
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un proveedor");
                return;
            }
            else
            {
                foreach (DataGridViewRow indice in dataGridView1.SelectedRows)
                {
                    int idProveedorModificado = Convert.ToInt32(indice.Cells[0].Value);

                    proveedorModificado.BNombreMProveedor.Text = indice.Cells[3].Value.ToString();
                    proveedorModificado.BApellidoMProveedor.Text = indice.Cells[6].Value.ToString();
                    proveedorModificado.BDniMProveedor.Text = indice.Cells[1].Value.ToString();
                    proveedorModificado.BDireccionMProveedor.Text = indice.Cells[4].Value.ToString();
                    proveedorModificado.BEmailMProveedor.Text = indice.Cells[5].Value.ToString();
                    proveedorModificado.BCuilMProveedor.Text = indice.Cells[2].Value.ToString();
                    proveedorModificado.BIdMproveedor.Text = idProveedorModificado.ToString();
                }

                this.Hide();
                proveedorModificado.Show();
            }
        }

        //Boton para buscar un proveedor por ID
        private void BBuscar_Click(object sender, EventArgs e)
        {
            int idproveedor = int.Parse(textBoxBuscar.Text);
            dataGridView1.DataSource = principal.BuscarProveedorPorID(idproveedor);
        }

        //Boton para buscar un proveedor por nombre
        private void BBuscarNombre_Click(object sender, EventArgs e)
        {
            string nombreproveedor = textBoxBNombre.Text;
            dataGridView1.DataSource = principal.BuscarProductoPorNombre(nombreproveedor);
        }
    }
}
