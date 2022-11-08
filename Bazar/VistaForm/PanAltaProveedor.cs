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
    public partial class PanAltaProveedor : Form
    {
        Proveedor proveedorNuevo = new Proveedor();
        Principal principal = new Principal();
        public PanAltaProveedor()
        {
            InitializeComponent();
        }

        // para cerrar arriba a la derecha 
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanAltaProveedor_Load(object sender, EventArgs e)
        {

        }

        //Boton que da de alta a un proveedor
        private void button1_Click(object sender, EventArgs e)
        {
            proveedorNuevo = new Proveedor();
            proveedorNuevo.nombre = BNombreProveedor.Text;
            proveedorNuevo.apellido = BApellidoProveedor.Text;
            proveedorNuevo.dni = int.Parse(BDniProveedor.Text);
            proveedorNuevo.direccion = BDireccionProveedor.Text;
            proveedorNuevo.email = BEmailProveedor.Text;
            proveedorNuevo.cuil = BCuilProveedor.Text;
            proveedorNuevo.idProveedor = int.Parse(BIdproveedor.Text);

            principal = new Principal();
            principal.RellenarLista();
            principal.AltaProveedor(proveedorNuevo, proveedorNuevo.idProveedor);

            PanProveedor irmenu = new PanProveedor();
            irmenu.Show();
            this.Hide();
        }

        //Boton cancelar alta
        private void BCancelarAlta_Click(object sender, EventArgs e)
        {
            PanProveedor irmenu = new PanProveedor();
            irmenu.Show();
            this.Hide();
        }

        //validacion solamente por letras 

        //Validar nombre proveedor
        private void BNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
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

        //Validar apellido proveedor
        private void BApellidoProveedor_KeyPress(object sender, KeyPressEventArgs e)
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

        //validacion solamente por numeros 

        //Validar DNI proveedor
        private void BDniProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BDniProveedor.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Validar CUIL proveedor
        private void BCuilProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BCuilProveedor.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Validar ID proveedor
        private void BIdproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BIdproveedor.Text.Contains(".")))
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
