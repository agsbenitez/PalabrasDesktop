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
    public class CNPermisos
    {
        CDPermisos CDPermisos = new CDPermisos();
        

        
        //public void CrearUsuario(CEUsuario usuario)
        //{
            //CDUsuario.Crear(usuario);

        //}

        public void Editarpermisos(CEPermisos permisos)
        {
            CDPermisos.Editar(permisos);

        }

        public void BorrarUsuario(CEUsuario usuario)
        {
            //CDUsuario.Borrar(usuario);

        }

        public DataSet Permisos(int id_perfil)
        {
            /*
             * Devuelva la lista de Permisos de un Perfil
             */
            return CDPermisos.listaPermisos(id_perfil);

        }


        public DataTable getpermis()
        {
            //Devuelve la lista de permisos apra un perfil de usuario
            CNUsuario cNUsuario = new CNUsuario();
            CNLogOnUser cNLogOnUser = new CNLogOnUser();
            CNPerfil cNPerfil = new CNPerfil();
            //se obtiene el dni de Pseudo coocki
            string dni = cNLogOnUser.userActive();


            //Desactivo provisoramiente se recupera el perfuil del usuario
            DataSet perfil_usuario = cNPerfil.returnPerfil(int.Parse(dni));
            DataTable table = perfil_usuario.Tables[0];
            DataRow dataRow = table.Rows[0];
            int perfil = int.Parse(dataRow[1].ToString());
            CNPermisos cNPermisos = new CNPermisos();
            //se recupran los permisos para un perfil
            DataSet permisos = cNPermisos.Permisos(perfil);
            DataTable permis = permisos.Tables["permisos"];
            return permis;
        }

       
        

        

       
    }
    
}
