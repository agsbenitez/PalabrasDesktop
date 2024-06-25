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


//En esta capa se define la logica de Negocio de la Entidad
//Validaciones necesarias para que la entidad esté conciderada correcata
namespace capaNegocio
{
    public class CNPalabras_asignada_jugador
    {
        CDPalabras_asignadas_jugador cDPalabras_Asignadas_Jugador = new CDPalabras_asignadas_jugador();
        CDJuego cNJuego = new CDJuego();

        public DataSet palabrasjugador(int id_jugador)
        {
            DataSet ds = cNJuego.juegoActivo();
            int id_juego = Convert.ToInt32(ds.Tables["juego_activo"].Rows[0]["id"].ToString());
            return cDPalabras_Asignadas_Jugador.listaPalabrasJugador(id_juego, id_jugador);
        }


        public void datosPartida(int id_juego, int id_jugador, int id_palabra, int tiempo, bool correcto)
        {
            CDPalabras_asignadas_jugador cDPalabras_Asignadas_Jugador = new CDPalabras_asignadas_jugador();
            cDPalabras_Asignadas_Jugador.datosPartida(id_juego, id_jugador, id_palabra, tiempo, correcto);
        }

    }



    
}
