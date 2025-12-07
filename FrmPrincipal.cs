using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Facturation
{
    public partial class FrmPrincipal : Form
    {

        private void AbrirFormularioEnPanel(Form formHijo)
        {
            // Limpiar el panel de controles anteriores (si es necesario)
            this.pncentral.Controls.Clear();

            // Configurar el formulario hijo para que se comporte como un control
            formHijo.TopLevel = false; // Indica que no es una ventana de nivel superior

            // Añadir el formulario hijo a la colección de controles del panel
            this.pncentral.Controls.Add(formHijo);

            // Mostrar el formulario
            formHijo.Show();
        }
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmFacturacion());
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {

        }
    }
}
