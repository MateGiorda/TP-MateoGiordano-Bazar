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
    public partial class PanAltaClientes : Form
    {
        Cliente clienteNuevo = new Cliente();
        Principal principal = new Principal();
        public PanAltaClientes()
        {
            InitializeComponent();
        }

        //Boton para cerrar arriba a la derecha 
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanAltaClientes_Load(object sender, EventArgs e)
        {

        }

        //Boton para dar de alta un cliente
        private void button1_Click(object sender, EventArgs e)
        {
            clienteNuevo = new Cliente();
            clienteNuevo.nombre = BNombreCliente.Text;
            clienteNuevo.apellido = BApellidoCliente.Text;
            clienteNuevo.dni = int.Parse(BDniCliente.Text);
            clienteNuevo.direccion = BDireccionCliente.Text;
            clienteNuevo.email = BEmailCliente.Text;
            clienteNuevo.cuil = BCuilCliente.Text;
            clienteNuevo.idCliente = int.Parse(BIdCliente.Text);

            principal = new Principal();
            principal.RellenarLista();
            principal.AltaCliente(clienteNuevo, clienteNuevo.idCliente);

            PanCliente irmenu = new PanCliente();
            irmenu.Show();
            this.Hide();
        }

        //Boton para cancelar un alta
        private void button6_Click(object sender, EventArgs e)
        {
            PanCliente irmenu = new PanCliente();
            irmenu.Show();
            this.Hide();
        }

        private void BApellidoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        //Validacion de datos solamente numericos 

        //Validar DNI cliente
        private void BDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                //condicion para solo números
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                //para tecla backspace
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                /*verifica que pueda ingresar punto y también que solo pueda ingresar un punto*/
                else if ((e.KeyChar == '.') && (!BDniCliente.Text.Contains(".")))
                {
                    e.Handled = false;
                }
                //si no se cumple nada de lo anterior entonces que no lo deje pasar
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se admiten datos numéricos", "validación de números",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            }

        //Validar CUIL cliente
        private void BCuilCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if ((e.KeyChar == '.') && (!BCuilCliente.Text.Contains(".")))
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

        //Validar ID cliente
        private void BIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if ((e.KeyChar == '.') && (!BIdCliente.Text.Contains(".")))
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

        //Validacion para solamente letras

        //Validar nombre cliente
        private void BNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // condicion para solo números 
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BIdCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
