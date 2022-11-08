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
    public partial class PanModificarProveedor : Form
    {
        Principal principal = new Principal();

        public PanModificarProveedor()
        {
            InitializeComponent();
        }

        private void PanModificarProveedor_Load(object sender, EventArgs e)
        {

        }

        //Boton para cerrar arriba a la derecha 
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Boton para cancelar la modificacion
        private void BCancelarModificacion_Click(object sender, EventArgs e)
        {
            PanProveedor irmenu = new PanProveedor();
            irmenu.Show();
            this.Hide();
        }

        //Boton para modificar proveedor
        private void BGuardarModificacion_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro de que quieres modifcarlo?", "Modificar proveedor", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Proveedor proveedorModificado = new Proveedor();

                proveedorModificado.nombre = BNombreMProveedor.Text;
                proveedorModificado.apellido = BApellidoMProveedor.Text;
                proveedorModificado.dni = int.Parse(BDniMProveedor.Text);
                proveedorModificado.direccion = BDireccionMProveedor.Text;
                proveedorModificado.email = BEmailMProveedor.Text;
                proveedorModificado.cuil = BCuilMProveedor.Text;
                proveedorModificado.idProveedor = int.Parse(BIdMproveedor.Text);

                principal = new Principal();
                principal.RellenarLista();
                principal.ModificarProveedor(proveedorModificado, int.Parse(BIdMproveedor.Text));

                PanProveedor irmenu = new PanProveedor();
                irmenu.Show();
                this.Hide();
            }
        }

        //validar solamente letras

        //Validar nombre proveedor
        private void BNombreMProveedor_KeyPress(object sender, KeyPressEventArgs e)
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

        //Validar DNI proveedor
        private void BDniMProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BDniMProveedor.Text.Contains(".")))
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
        private void BCuilMProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BDniMProveedor.Text.Contains(".")))
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
        private void BIdMproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!BIdMproveedor.Text.Contains(".")))
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
