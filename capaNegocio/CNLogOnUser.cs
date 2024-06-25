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
    public class CNLogOnUser
    {
        CDLogOnUser CDLogOnUser =   new CDLogOnUser();
        
        public void Login(int usuario)
        {
            CELogOnUser cELogOnUser = new CELogOnUser();
            
            cELogOnUser.dni_user = usuario.ToString();
            cELogOnUser.log = true;
            CDLogOnUser.Crear(cELogOnUser);
        }


        public void Logout(int usuario)
        {
            CDLogOnUser.LogOut(usuario.ToString());
        }


        public String userActive()
        {
            string user = System.IO.File.ReadAllText("..\\loged.txt");
            DataSet logUser = CDLogOnUser.logedUser(user);
            DataTable table = logUser.Tables[0];
            string exprecion = "dni_user=" + user;
            DataRow[] rows = table.Select(exprecion);

            for (int i = 0; i < rows.Length; i++)
            {

                if (int.Parse(user) == int.Parse(rows[i][1].ToString()))
                {
                    return user;
                }
                Console.WriteLine();
            }
        
            return "false";

        }
    }
    
}
