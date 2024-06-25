using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;

namespace front
{
    public partial class frmPalabraCorrecta : Form
    {
        CNUsuario cNUsuario = new CNUsuario();
        CNPalabras cNPalabras = new CNPalabras();
        CNJuego cNJuego = new CNJuego();
        public frmPalabraCorrecta()
        {
            InitializeComponent();
        }

        private void btnPalabraCorrecta_Click(object sender, EventArgs e)
        {
            cargarGridPalabraCorrecta();
        }
       


        private void lblPalabraCorrecta_Click(object sender, EventArgs e)
        {

        }

        private void frmPalabraCorrecta_Load(object sender, EventArgs e)
        {

        }

        private void btnPalabraIncorrecta_Click(object sender, EventArgs e)
        {
            cargarGridIncorrecta();
        }
        public void cargarGridIncorrecta()
        {
            //moví el metodo a cNPalabras
            dataGridView1.DataSource = cNPalabras.palabrasIncorrecta().Tables["usuario"];

        }

        private void btnMejorParticipante_Click(object sender, EventArgs e)
        {
            cargarGrid();
        }

        public void cargarGrid()
        {
            dataGridView1.DataSource = cNJuego.mejorJugador().Tables["usuario"];


        }

        private void btnPalabra_Click(object sender, EventArgs e)
        {
            cargarGridPalabraCorrecta();
        }
        public void cargarGridPalabraCorrecta()
        {
            dataGridView1.DataSource = cNPalabras.palabraCorrecta().Tables["usuario"];

        }

        private void btnCantidadJegos_Click(object sender, EventArgs e)
        {
            cargarGridCantidadJuegos();
            
        }
        public void cargarGridCantidadJuegos()
        {
            dataGridView1.DataSource = cNJuego.cantidadJuegos().Tables["usuario"];

        }
    }
}




