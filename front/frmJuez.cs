using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace front
{
    public partial class frmJuez : Form
    {
        public DataTable participantes;
        public int id_juegoFrmjuez;
        public int index = 0;
        public frmJuez(int id_juego, DataTable dt)
        {
            InitializeComponent();
            participantes = dt;
            id_juegoFrmjuez = id_juego;
            if (participantes.Rows.Count==1)
            {
                btnSigJugador.Enabled = false;
            }
            frmBigScreen frmBigScreen = new frmBigScreen();
            frmBigScreen.Show();
        }

       
        

        public void iniciarTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 1000;
            timer1.Start();

        }

        private int duration = 30;
        private void count_down(object sender, EventArgs e)
        {
            //instancio ell fomulario bigscrren para acceder a su instacia y poder enviar el nombre del alumno participante
            frmBigScreen instanciaBigScrren = frmBigScreen.Instancia;

            if (duration == 0)
            {
                timer1.Stop();
            }
            else if (duration > 0)
            {
                duration--;
                lblTime.Text = duration.ToString();
                instanciaBigScrren.Timer(lblTime.Text);

            }

        }

        public class Palabra
        {
            public string Palabras { get; set; }
            public int Id_palabra { get; set; }
            public bool Correcto { get; set; }
            public int Tiempo { get; set; }    

            public override string ToString()
            {
                return this.Palabras;
            }

        }



        private void frmJuez_Load(object sender, EventArgs e)
        {
            MessageBox.Show(index.ToString());
            partida(index);
            grpBPalabrasAlumno.Left = (this.ClientSize.Width - grpBPalabrasAlumno.Width) / 2;
            grpBPalabrasAlumno.Top = (this.ClientSize.Height - grpBPalabrasAlumno.Height) / 2;
        }

        public void partida(int index)
        {
            //con el id del alumno encontrar su nombre, y las palabras asigandas
            CNUsuario cNUsuario = new CNUsuario();
            CNPalabras_asignada_jugador cNPalabras_Asignada = new CNPalabras_asignada_jugador();
            int id_participante = Convert.ToInt32(participantes.Rows[index]["id_usuario"].ToString());
            DataSet ds = cNUsuario.obtenerUsuario(id_participante);
            lblAlumno.Text = ds.Tables["participante"].Rows[0]["full_name"].ToString();
            //instancio ell fomulario bigscrren para acceder a su instacia y poder enviar el nombre del alumno participante
            frmBigScreen instanciaBigScrren = frmBigScreen.Instancia;
                if (instanciaBigScrren != null)
                {
                    instanciaBigScrren.ActualizarJugador(lblAlumno.Text);
                
                }

            //obtener las palabras para ese jugador y cargarlas en los label del check box ver el id

            DataSet palabras = cNPalabras_Asignada.palabrasjugador(id_participante);

            if (checkedListBox1.Items.Count > 0)
            {
                checkedListBox1.Items.Clear();
            }
            foreach (DataRow item in palabras.Tables["palabrasxjugador"].Rows)
            {
                
                checkedListBox1.Items.Add(
                    new Palabra
                    {
                        Palabras = item["palabra"].ToString(),
                        Id_palabra = Convert.ToInt32(item["id_palabras"].ToString()),
                        Correcto = false,
                        Tiempo = 0
                    });
            }

        }

        private void checkedListBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //abrir bigScreen y enviarle los datos del alumno y la palabra
            string palabra_sel = checkedListBox1.Text;
            frmBigScreen instanciaBigScrren = frmBigScreen.Instancia;
            if(instanciaBigScrren != null)
            {
                instanciaBigScrren.ActualizarPalabra(palabra_sel);
            }
            this.duration = 30;
            timer1.Stop();  
            this.iniciarTimer();           


        }

        private void btnFinJuego_Click(object sender, EventArgs e)
        {
            CNJuego cNJuego = new CNJuego();
            frmBigScreen instanciaBigScrren = frmBigScreen.Instancia;
            timer1.Stop();
            //grabar la partida del jugador, enviar todos los datos para que se graben
            if (index <= participantes.Rows.Count - 1)
            {
                EnviarDatos();
            }

             DataSet ds = cNJuego.juegoActivo();

            if (ds.Tables[0].Rows.Count > 0)
            {
                int id_juego = Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
                DialogResult respuesta = MessageBox.Show("Hay Juegos en activos, si sale se perderán", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (respuesta == DialogResult.OK)
                {
                    cNJuego.finjuegoActivo(id_juego);
                    btnSigJugador.Enabled = false;

                    //quizás debería mostar resultado del juego
                    
                    this.Close();
                    instanciaBigScrren.Close();
                }

            }

        }

        public void EnviarDatos()
        {
            CNPalabras_asignada_jugador cNPalabras_Asignada_Jugador = new CNPalabras_asignada_jugador();
            int id_juego = id_juegoFrmjuez;
            int id_partcipante = Convert.ToInt32(participantes.Rows[index]["id_usuario"].ToString());
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                Palabra pala = (Palabra)itemChecked;
                cNPalabras_Asignada_Jugador.datosPartida(id_juego, id_partcipante, pala.Id_palabra, pala.Tiempo, pala.Correcto);
               
            }
            
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Palabra pal_sel = (Palabra)checkedListBox1.Items[e.Index];

            pal_sel.Tiempo = Convert.ToInt32(lblTime.Text);
            pal_sel.Correcto = true;
            timer1.Stop();
            


        }

        private void btnSigJugador_Click(object sender, EventArgs e)
        {
            EnviarDatos();

            index = index + 1 ;

            if (index<=participantes.Rows.Count-1)
            
            {
                //lblindexJugador.Text = Convert.ToString(Convert.ToInt32(lblindexJugador.Text) + 1);
                //cargar el proximo jugador para la partida actual
                int id_juego = id_juegoFrmjuez;
                partida(index);
                // CNJuego cNJuego = new CNJuego();
                //int id_participante = cNJuego.NextPaticipante(id_juego);    
            }
            else
            {
                MessageBox.Show("Fin del Juego");
            }


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
