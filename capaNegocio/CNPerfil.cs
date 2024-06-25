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
    public class CNPerfil
    {
        CDPerfil cDPerfil = new CDPerfil();


        public DataSet perfiles()
        {
            /*
             * Devuelve la lista de perfiles
             */
            return cDPerfil.listaPerfiles();

        }

        public DataSet perfiles(bool removeAdmin)
        {
            /*
             * Devuelve la lista de perfiles
             */
            return cDPerfil.listaPerfiles(removeAdmin);

        }

        public DataSet returnPerfil(int dni_usuario)
        {
            DataSet perfil_usuario = cDPerfil.GetPerfil(dni_usuario);
            return perfil_usuario;
        }


    }
    
}
