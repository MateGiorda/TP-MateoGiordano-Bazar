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
    public partial class PanEmpleados : Form
    {
        Principal principal = new Principal();
        public PanEmpleados()
        {
            InitializeComponent();
        }

        //Boton para cerrar arriba a la derecha
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            PanPrincipal irprincipal = new PanPrincipal();
            irprincipal.Show();
            this.Hide();
        }

        //Boton para dar de alta un empleado
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanAltaEmpleados frmloguin = new PanAltaEmpleados();
            frmloguin.ShowDialog();
        }

        //Cuando carga
        private void PanEmpleados_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            PersistenciaDato instanciaPersistencia = new PersistenciaDato();
            instanciaPersistencia.InicializarArchivo();
            Principal instanciaPrincipal = new Principal();
            instanciaPrincipal.RellenarLista();

            dataGridView1.DataSource = instanciaPrincipal.ValidarEmpleado();
        }

        //Boton para dar de baja un empleado
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado");
                return;
            }
            else
            {
                // busco el seleccionado
                Empleado EmpSelec = dataGridView1.SelectedRows[0].DataBoundItem as Empleado;
                principal = new Principal();
                principal.BajaEmpleado(EmpSelec.idEmpleado);
                MessageBox.Show("Baja exitosa");

                PanEmpleados irGrilla = new PanEmpleados();
                irGrilla.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanModificarEmpleado empleadoModificado = new PanModificarEmpleado();

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado");
                return;
            }
            else
            {
                foreach (DataGridViewRow indice in dataGridView1.SelectedRows)
                {
                    int idEmpleadoModificado = Convert.ToInt32(indice.Cells[0].Value);

                    empleadoModificado.BNombreMEmpleado.Text = indice.Cells[4].Value.ToString();
                    empleadoModificado.BApellidoMEmpleado.Text = indice.Cells[7].Value.ToString();
                    empleadoModificado.BDniMEmpleado.Text = indice.Cells[2].Value.ToString();
                    empleadoModificado.BDireccionMEmpleado.Text = indice.Cells[5].Value.ToString();
                    empleadoModificado.BEmailMEmpleado.Text = indice.Cells[6].Value.ToString();
                    empleadoModificado.BCuilMEmpleado.Text = indice.Cells[3].Value.ToString();
                    empleadoModificado.BSueldoMEmpleado.Text = indice.Cells[1].Value.ToString();
                    empleadoModificado.BIdMEmpleado.Text = idEmpleadoModificado.ToString();
                }
                this.Hide();
                empleadoModificado.Show();
            }
        }

        //Boton para buscar un empleado por ID
        private void BBuscar_Click(object sender, EventArgs e)
        {
            int idempleado = int.Parse(textBoxBuscar.Text);
            dataGridView1.DataSource = principal.BuscarEmpleadoPorID(idempleado);
        }

        //Boton para buscar un empleado por nombre
        private void BBuscarNombre_Click(object sender, EventArgs e)
        {
            string nombreempleado = textBoxBNombre.Text;
            dataGridView1.DataSource = principal.BuscarProductoPorNombre(nombreempleado);
        }
    }
}
