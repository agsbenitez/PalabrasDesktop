using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class CEUsuario
    {
        public int id_usuario { get; set; }
        public string apellido { get; set;}
        public string nombre { get; set; }
        public int dni { get; set;}
        public string email { get; set;}
        public DateTime fecha_alta { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public int borrado { get; set; }
        public int id_perfil  { get; set;}
        public string password { get; set;}
        public string salt { get; set; }
        public string entidad { get; set;}    
        public string grado { get; set;}
        public int id_dificultad { get; set; }
      
    }

  
}
