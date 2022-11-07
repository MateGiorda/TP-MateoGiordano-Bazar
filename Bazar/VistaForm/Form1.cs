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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Entramos haciendo doble click en el formulario, cuando carga puede aparecer lo que está aca dentro

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Se realiza cunado hacemos click en el font
        }

        private void Boton1_Click(object sender, EventArgs e)
        {
            // deberiamos ir a la lista de usuario y rescatar el que tiene el mismo nombre del texto
            //validan la contraseña

            if (txtUsuario.Text.Length > 0) {        
            MessageBox.Show("Hola, está por ingrsar al sistema: " + txtUsuario.Text);
            }
            else
            {
                MessageBox.Show("Ingrese nombre");
            }    
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
