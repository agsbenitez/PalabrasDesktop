using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using capaDatos;
using System.Data;
using System.Security.Permissions;


//En esta capa se define la logica de Negocio de la Entidad
//Validaciones necesarias para que la entidad esté conciderada correcata
namespace capaNegocio
{
    public class CNJuego
    {
        CDJuego cDJuego =  new CDJuego();
        CDJuego_detalle cDJuego_detalle = new CDJuego_detalle();
        CDPalabras_asignadas_jugador cDPalabras_Asignadas_Jugador = new CDPalabras_asignadas_jugador();
        Palabras cDPalabras = new Palabras();
        Usuario cDUsuario = new Usuario();
        public int nuevoJuego(DataTable usuarios)
        {
            DateTime fecha_inicio = DateTime.Now;
            long id_juego = cDJuego.nuevoJuego(fecha_inicio); //crear es script para crear el juego , deve devolver el id de juego creado
            // debo llamar a juego_detalle y con los participantes crear el detalle del juego
            foreach (DataRow item in usuarios.Rows)
            {
                int id_participante = Convert.ToInt32(item[1].ToString());
                int dificultad_participante = Convert.ToInt32(cDUsuario.nivelUsuario(id_participante).Tables["Participantes"].Rows[0]["id_dificultad"]); 
                cDJuego_detalle.NuevoJuegoDetalle(id_juego, id_participante);
                //debo obtener una palabra al azar de la base que no esté sorteda.
                //debo llamar a palabras_asignadas_jugador
                for (int i = 0; i < 5; i++)
                {
                    
                    DataSet palabra = cDPalabras.palabraAzar(dificultad_participante);
                    DataTable tablepalabra = palabra.Tables[0];
                    int id_palabra = Convert.ToInt32(tablepalabra.Rows[0]["id"].ToString());
                    cDPalabras_Asignadas_Jugador.Palabras(id_juego, id_participante, id_palabra);
                    //bloquear la palabra.
                    cDPalabras.palabraSorteada(id_palabra);
                }
                
            }
            return Convert.ToInt32(id_juego);
        }


        public DataSet juegoActivo()
        {
            return cDJuego.juegoActivo();
        }

        public DataSet nextPaticipante(int id_juego)
        {
            return cDPalabras_Asignadas_Jugador.NextPaticipante(id_juego);
        }


        public void finjuegoActivo(int id_juego)
        {
            cDJuego.finjuegoActivo(id_juego);
            //quizás haya que liberar alas parlabras selecionadas
            cDPalabras.liberarPalabras();
        }

        public DataSet mejorJugador()
        {
            return cDJuego.obtenerMejorUsuario();

        }

        public DataSet cantidadJuegos()
        {
            //return cDJuego.ObtenerCantidadJuegos();
            return cDJuego.obtenerCantidadJuegos();

        }
        
    }

    


}
