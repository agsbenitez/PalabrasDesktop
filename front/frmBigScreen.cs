using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static front.frmBigScreen;

namespace front
{
    public partial class frmBigScreen : Form
    {

        public static frmBigScreen Instancia { get; private set; }
        public frmBigScreen()
        {
            InitializeComponent();
            Instancia = this;
            
            
            //lblPalabra.Text = palabra_sel;

        }
        public void ActualizarJugador(string jugador)
        {
            lblJugador.Text = jugador;
        }

        public void ActualizarPalabra(string palabra)
        {
            lblPalabra.Text = palabra;
        }

        public void Timer(string tiempo)
        {
            lblTimer.Text = tiempo;
        }

        public void Close(string tiempo)
        {
            this.Close();
        }






        private void frmBigScreen_Load(object sender, EventArgs e)
        {
            lblPalabra.Left = (this.ClientSize.Width - lblPalabra.Width) / 2;
            lblPalabra.Top = (this.ClientSize.Height - lblPalabra.Height) / 2;
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
