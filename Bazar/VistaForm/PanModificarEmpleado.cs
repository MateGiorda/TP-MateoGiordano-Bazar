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
    public partial class PanModificarEmpleado : Form
    {
        Principal principal = new Principal();

        public PanModificarEmpleado()
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
            PanEmpleados irmenu = new PanEmpleados();
            irmenu.Show();
            this.Hide();
        }

        //Boton para modoficar empleado
        private void BModificarEmpleado_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro de que quieres modifcarlo?", "Modificar empleado", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Empleado empleadoModificado = new Empleado();

                empleadoModificado.nombre = BNombreMEmpleado.Text;
                empleadoModificado.apellido = BApellidoMEmpleado.Text;
                empleadoModificado.dni = int.Parse(BDniMEmpleado.Text);
                empleadoModificado.direccion = BDireccionMEmpleado.Text;
                empleadoModificado.email = BEmailMEmpleado.Text;
                empleadoModificado.cuil = BCuilMEmpleado.Text;
                empleadoModificado.sueldo = int.Parse(BSueldoMEmpleado.Text);
                empleadoModificado.idEmpleado = int.Parse(BIdMEmpleado.Text);

                principal = new Principal();
                principal.RellenarLista();
                principal.ModificarEmpleado(empleadoModificado, int.Parse(BIdMEmpleado.Text));

                PanEmpleados irmenu = new PanEmpleados();
                irmenu.Show();
                this.Hide();
            }
        }

        //validar solamente letras 

        //Validar nombre empleado
        private void BNombreMEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        //Validar DNI empleado
        private void BDniMEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BDniMEmpleado.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Validar CUIL empleado 
        private void BCuilMEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BCuilMEmpleado.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Validar Sueldo empleado
        private void BSueldoMEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BSueldoMEmpleado.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Validar ID empleado
        private void BIdMEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BIdMEmpleado.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void PanModificarEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
    }


