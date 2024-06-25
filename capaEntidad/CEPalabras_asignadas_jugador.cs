using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class CEPalabras_asignanadas_jugador
    {
        public int id { get; set; }
        public int id_participante { get; set; }
        public int id_juego {  get; set; }
        public int id_palabras { get; set; }
        public bool correcto { get; set; }
        public string tiempo_respuesta { get; set; }
        
    }
}
