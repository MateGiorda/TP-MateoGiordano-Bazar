using FormularioParaBazar;
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
    public partial class Carga : Form
    {
        public Carga()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            label1.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                PanPrincipal frmloguin = new PanPrincipal(); 
                frmloguin.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Carga_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
