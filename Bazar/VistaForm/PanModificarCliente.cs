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
    public partial class PanModificarCliente : Form
    {
        Principal principal = new Principal();

        public PanModificarCliente()
        {
            InitializeComponent();
        }

        //Boton para cerrar arriba a la derecha
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Boton para cancelar la modificacion 
        private void button6_Click(object sender, EventArgs e)
        {
            PanCliente irmenu = new PanCliente();
            irmenu.Show();
            this.Hide();
        }

        //Boton para modificar cliente
        private void BGuardarModificacion_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro de que quieres modifcarlo?", "Modificar cliente", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Cliente ClienteModificado = new Cliente();

                ClienteModificado.nombre = BNombreMCliente.Text;
                ClienteModificado.apellido = BApellidoMCliente.Text;
                ClienteModificado.dni = int.Parse(BDniMCliente.Text);
                ClienteModificado.direccion = BDireccionMCliente.Text;
                ClienteModificado.email = BEmailMCliente.Text;
                ClienteModificado.cuil = BCuilMCliente.Text;
                ClienteModificado.idCliente = int.Parse(BIdMCliente.Text);

                principal = new Principal();
                principal.RellenarLista();
                principal.ModificarCliente(ClienteModificado, int.Parse(BIdMCliente.Text));

                PanCliente irmenu = new PanCliente();
                irmenu.Show();
                this.Hide();
            }
            
        }

        private void PanModificarCliente_Load(object sender, EventArgs e)
        {

        }

        private void BNombreMCliente_TextChanged(object sender, EventArgs e)
        {

        }

        //validacion solamente para letras 

        //Valdiar Nombre cliente
        private void BNombreMCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        // validar solamente numeros

        //Validar DNI cliente
        private void BDniMCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BDniMCliente.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Validar CUIL cliente
        private void BCuilMCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BCuilMCliente.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Validar ID cliente
        private void BIdMCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BIdMCliente.Text.Contains(".")))
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
