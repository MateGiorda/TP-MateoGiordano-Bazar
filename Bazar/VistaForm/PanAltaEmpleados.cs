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
    public partial class PanAltaEmpleados : Form
    {
        Empleado empleadoNuevo = new Empleado();
        Principal principal = new Principal();
        public PanAltaEmpleados()
        {
            InitializeComponent();
        }

        //Boton para cerrar arriba a la derecha 
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Boton para dar de alta un empleado
        private void button1_Click(object sender, EventArgs e)
        {
            empleadoNuevo = new Empleado();
            empleadoNuevo.nombre = BNombreEmpleado.Text;
            empleadoNuevo.apellido = BApellidoEmpleado.Text;
            empleadoNuevo.dni = int.Parse(BDniEmpleado.Text);
            empleadoNuevo.direccion = BDireccionEmpleado.Text;
            empleadoNuevo.email = BEmailEmpleado.Text;
            empleadoNuevo.cuil = BCuilEmpleado.Text;
            empleadoNuevo.sueldo = int.Parse(BSueldoEmpleado.Text);
            empleadoNuevo.idEmpleado = int.Parse(BIdEmpleado.Text);

            principal = new Principal();
            principal.RellenarLista();
            principal.AltaEmpleado(empleadoNuevo, empleadoNuevo.idEmpleado);

            PanEmpleados irmenu = new PanEmpleados();
            irmenu.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BCuilEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanAltaEmpleados_Load(object sender, EventArgs e)
        {

        }

        //Boton para cancelar un alta
        private void BCancelarAlta_Click(object sender, EventArgs e)
        {
            PanEmpleados irmenu = new PanEmpleados();
            irmenu.Show();
            this.Hide();
        }

        //Validacion solamente letras

        //Validar nombre empleado
        private void BNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        //Validar apellido empleado 
        private void BApellidoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        //Validacion solamente numeros

        //Validar DNI empleado
        private void BDniEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BDniEmpleado.Text.Contains(".")))
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
        private void BCuilEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BCuilEmpleado.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Validar sueldo empleado
        private void BSueldoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BSueldoEmpleado.Text.Contains(".")))
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
        private void BIdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BIdEmpleado.Text.Contains(".")))
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
