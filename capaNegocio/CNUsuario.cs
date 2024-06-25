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
    public class CNUsuario
    {
        Usuario CDUsuario =   new Usuario();
        public bool validadorDatos(CEUsuario usuario)
        {
            bool resul = true;

            if (usuario.apellido == string.Empty)
            {
                resul = false;
                MessageBox.Show("El Apellido es Obligatorio");
            }
            
            if (usuario.nombre == string.Empty)
            {
                resul = false;  
                MessageBox.Show("El Nombre es Obligatorio");
            }

            if (usuario.dni == null)
            {
                resul = false;
                MessageBox.Show("El Dni es Obligatorio");
            }

            if (usuario.email == string.Empty)
            {
                MessageBox.Show("El Email  es Obligatorio");
            }

            return resul;
        }

        
        public void crearUsuario(CEUsuario usuario)
        {
            CDUsuario.crear(usuario);

        }

        public void editarUsuario(CEUsuario usuario)
        {
            CDUsuario.editar(usuario);

        }

        public void borrarUsuario(CEUsuario usuario)
        {
            CDUsuario.borrar(usuario);

        }

        //Cambiar nonmbre de del metodo para que se llame ListarUsuario
        public DataSet usuarios()
        {
            return CDUsuario.listaUsuarios();

        }

        public DataSet usuariosBorrados()
        {
            return CDUsuario.listaUsuariosBorrados();
        }


        public DataSet pass_Salt(int usuario)
        {
            return CDUsuario.recupearPassword(usuario);
        }

        public bool check_Pass(String passwordIngresada, string passwordAlamacenada, String salt)
        {
            //llamos a la funcion para pasar la pass ingresadad a hassheada y comparar
            if (CDUsuario.passwordMach(passwordAlamacenada, passwordIngresada, salt))
            {
                return true;
            }

            return false;
        }

        public bool login(int usuario, String passwordIngresada)
        {
            string pass = "";
            string salt = "";
            //pongo la Logica del Login
            //llamo a Pass_salt(usuario) y debo almacenar el resultado para hacer el chequeo
            DataSet dataSet = this.pass_Salt(usuario);
            foreach (DataRow dr in dataSet.Tables[0].Rows)
            { 
                pass = dr["password"].ToString();
                salt = dr["salt"].ToString();
            }
            
            if (this.check_Pass(passwordIngresada, pass, salt))
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public DataSet primarios()
        {
            return CDUsuario.primarios();
        }


        public DataSet secundarios()
        {
            return CDUsuario.secundarios();
        }

        public DataSet obtenerUsuario(int id_usuario)
        {
            return CDUsuario.obtenerUsuario(id_usuario);
        }


        public DataSet obtenerUsuarioPA(string usuario_buscar)
        {
            return CDUsuario.obtenerUsuarioPA(usuario_buscar);
        }


        //public DataSet palabrasIncorrecta()
        //{

        //Mover a palabras
        //return CDUsuario.ObtenerPalabrasIncorrecta();

        //}

        //mover a juegos


    }
    
}
