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
    public class CNJuego_detalle
    {
        CDJuego_detalle cDJuego_detalle =  new CDJuego_detalle();
        public void NuevoJuegoDetalle(long id_juego, DataTable participantes)
        {
            /*
             * con el id_juego y con la tabla de participantes debo insertarlos en la tabla juego_detalle
             */

            //por cada participante que viene en el datatable lo inserto en el detalle de juego
            foreach (DataRow row in participantes.Rows)
            {
                cDJuego_detalle.NuevoJuegoDetalle(id_juego, Convert.ToInt64(row["id_participante"]));
            }
        }

        public DataSet JugadoresdelJuego(int id_juego)
        {

            return cDJuego_detalle.JugadoresdelJuego(id_juego);
        }



    }


}
