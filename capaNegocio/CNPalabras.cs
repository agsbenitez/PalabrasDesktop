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
using capaNegocio;


//En esta capa se define la logica de Negocio de la Entidad
//Validaciones necesarias para que la entidad esté conciderada correcata
namespace capaNegocio
{
    public class CNPalabras
    {
        Palabras cDPalabras = new Palabras();


        public void nuevaPalabra(CEPalabras palabra)
        {
            cDPalabras.crearPalabra(palabra);
        }
        public void editarPalabra(CEPalabras palabra)
        {
            cDPalabras.editar(palabra);
        }

        public DataSet obtenerPalabras()
        {
             return cDPalabras.listarPalabras();
            //return cDPalabras.listaPalabras();
        }

        public void borradoLogico(CEPalabras cEPalabra)
        {
            cDPalabras.borrar(cEPalabra);
        }

        public DataSet palabrasIncorrecta()
        {

        //Mover a palabras
            return cDPalabras.obtenerPalabrasIncorrecta();

        }

        public DataSet palabraCorrecta()
        {

            //buscar de la capa de DAtos de usuario y ponerlo en la capa de palabra
            return cDPalabras.obtenerPalabraCorrecta();

        }


    }
}

