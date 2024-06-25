using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//se importa la clase MySql para hace la conecxion a la base
using MySql.Data.MySqlClient;
using capaEntidad;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;

namespace capaDatos
{
    public class CDLogOnUser
    {
        string cadenaConexion = "Server=127.0.0.1;User=ariel;Password=Mastera953!;Port=3306;database=palabras";

       public void Crear(CELogOnUser cELogOnUser)
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            ////mySqlConnection.Open();

            String Query = "insert into log_on_user (dni_user, log) values (" + cELogOnUser.dni_user + ", " + cELogOnUser.log + ");";


            //se instacia la ejecucion de una query
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            //se ejecuta la query
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
                return;
            }
            
            mySqlConnection.Close();
        }

    


        public void LogOut(string usuario)
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();
            string Query = "DELETE FROM log_on_user WHERE" +
                " `dni_user` = " + usuario + ";"; 


            //se instacia la ejecucion de una query
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            //se ejecuta la query
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
                return;
            }

            mySqlConnection.Close();
            
        }

        public DataSet logedUser(string usuario)
        {

            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            ////mySqlConnection.Open();

            String Query = "SELECT * FROM log_on_user  where dni_user = " + int.Parse(usuario) + ";";

            //se instacia el adaptador
            MySqlDataAdapter adapter;
            //se instancia el dataset
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            //necesario para la correcta representación de los datos
            //se le pone un nombre al dataset porque estos puden tener una o mas tablas
            adapter.Fill(dataSet, "log_user");
            mySqlConnection.Close();
            return dataSet;
        }




    }

   
}
