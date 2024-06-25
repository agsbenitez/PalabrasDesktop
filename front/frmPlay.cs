using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace front
{
    public partial class frmPlay : Form
    {
        public frmPlay(int id_juego)
        {
            InitializeComponent();
            lblNJuego.Text = id_juego.ToString();   
        }

        private void FrmPlay_Load(object sender, EventArgs e)

        {
            /*
             * AL cARGAR E FORMULARIO DEBO CONSULTAR EN LA TABLA DE JUEGOS CUAL ES EL JUEGO ACTIVO Y CON ESE ID,
             * RECUPERAR LOS JUGADORES QUE PARTCIPAN, ESTO DESDE LA TABLA DETALLE JUEGO
             * CON ESTO SOLO SE CARGA EL COMBO.
             * 
             * AL SELECCIIONAR UN PARCIPANTE SE DEBE OBTENER LA LISTA DE PALABRAS PARA EL JUGADOR Y ENVIARA
             */

            CNJuego cNJuego = new CNJuego();
            CNJuego_detalle cNJuego_Detalle = new CNJuego_detalle();
            DataSet ds = cNJuego.juegoActivo();
            int id_juego = Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());

            DataSet dsJugadore = cNJuego_Detalle.JugadoresdelJuego(id_juego);
            
            cmbJugadores.DataSource = dsJugadore.Tables["jugadoresdeljuego"];
            cmbJugadores.ValueMember = "id_participante";
            cmbJugadores.DisplayMember = "full_name";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * debo ver el id del participante seleccionado y rescatar el grupo de palabras para ese jugador
             * de la tabla de palabras por participantes según el id de juego activo
             * Todo esto debo pasarselo al las dos pantallas, a la de juez y a bigScreen
            */
                        
            int id_participante = Convert.ToInt32(cmbJugadores.SelectedValue.ToString());

            //enviar el parametro id_participante a las pantallas
            //frmBigScreen frmBigScreen = new frmBigScreen();
            int id_juego = Convert.ToInt32(lblNJuego.Text);
            //frmJuez frmJuez = new frmJuez(id_juego, id_participante);
            //frmJuez.MdiParent = this.MdiParent;
            //frmJuez.Show();
            //frmBigScreen.Show();
        }
    }
}
