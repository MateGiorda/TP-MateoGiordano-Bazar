using FormularioParaBazar;
using LogicaNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace VistaForm
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

         private void txtuser_TextChanged(object sender, EventArgs e)
        {
            // deberiamos ir a la lista de usuario y rescatar el que tiene el mismo nombre del texto
            //validan la contraseña

            /*if (txtuser.Text.Length > 0)
            {
                MessageBox.Show("Hola, está por ingrsar al sistema: " + txtuser.Text);
            }
            else
            {
                MessageBox.Show("Ingrese nombre");
            }
            */
        }

         private bool validarUsuario(string nombre, string clave)
        {
            // me voy a la base de usuarios a revisar par aese nombre y para esa clave
            // por ahora, lo hago a mano

            return (nombre == "Mateo") && (clave == "cacho");
            }
        

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Length > 0)
            {
                // deberían ir a la lista de usuarios, y rescatar el que tiene el mismo del TExt
                // validan el password.

                if (validarUsuario(txtuser.Text.Trim(), txtpass.Text.Trim()))
                {
                    this.Hide();
                    PanPrincipal frmloguin = new PanPrincipal();
                    frmloguin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o clave Incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de Usuario");
            }
            
    }

        private void Loguin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            PersistenciaDato instanciaPersistencia = new PersistenciaDato();
            instanciaPersistencia.InicializarArchivo();
            Principal instanciaPrincipal = new Principal();
            instanciaPrincipal.RellenarLista();
        }

        //Se puede agregar la funcion de arrastrar con en el mouse la pantalla (ver video)
    }
}

