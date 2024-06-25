using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class CEPermisos
    {
        public int id { get; set; }
        public int id_pefil_permisos { get; set; }
        public bool  alta_usuario_admin {  get; set; }
        public bool modificacion_usuario { get; set; }
        public bool baja_usuario { get; set; }
        public bool alta_usuario { get; set; }
        public bool alta_palabras { get; set; }
        public bool modificacion_palabras { get; set; }
        public bool baja_palabras { get; set; }
        public bool nuevo_juego {  get; set; }
        public bool reportes {  get; set; }
        public bool backup {  get; set; }
        public bool listado_palabras { get; set; }
        public bool permisos { get; set; }
        
    }
}
