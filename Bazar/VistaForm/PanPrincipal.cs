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
    public partial class PanPrincipal : Form
    {
        public PanPrincipal()
        {
            InitializeComponent();
        }

        //Boton de las tres lines que parece el menu
        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 1;
            }
            else
                MenuVertical.Width = 250;
        }

        //Boton para cerrar arriba a la derecha 
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Boton para maximizar 
        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        //Boton para restaurar una vez que se maximiza 
        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        //Boton para minimizar
        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Boton de productos de la derecha
        private void btnprod_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanProductos frmproductos = new PanProductos();
            frmproductos.ShowDialog();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
             
        }

        //Boton de clientes de la derecha
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanCliente frmclientes = new PanCliente();
            frmclientes.ShowDialog();
        }

        //Boton de empleados de la derecha
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanEmpleados frmempleados = new PanEmpleados();
            frmempleados.ShowDialog();
        }

        //Boton de proveedores de la derecha
        private void btnProvedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanProveedor frmproveedor = new PanProveedor();
            frmproveedor.ShowDialog();
        }
    }
}
