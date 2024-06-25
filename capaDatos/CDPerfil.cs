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

namespace capaDatos
{
    public class CDPerfil
    {
        public DataSet listaPerfiles()
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();
            string Query = "SELECT * FROM `palabras`.`perfil` LIMIT 1000";
            //se instacia el adaptador
            MySqlDataAdapter adapter;
            //se instancia el dataset
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            //necesario para la correcta representación de los datos
            //se le pone un nombre al dataset porque estos puden tener una o mas tablas
            adapter.Fill(dataSet, "perfiles");
            mySqlConnection.Close();
            return dataSet;

          
        }

        public DataSet listaPerfiles(bool removeAdmin)
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();
            string Query = "SELECT * FROM `palabras`.`perfil` where Descripcion <> 'Administrador'";
            //se instacia el adaptador
            MySqlDataAdapter adapter;
            //se instancia el dataset
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            //necesario para la correcta representación de los datos
            //se le pone un nombre al dataset porque estos puden tener una o mas tablas
            adapter.Fill(dataSet, "perfiles");
            mySqlConnection.Close();
            return dataSet;
        }

        public DataSet GetPerfil(int dni_usuario)
        {
            MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();

            ////mySqlConnection.Open();
            string Query = "SELECT" +
                " `usuario`.`Id_perfil`, " +
                " `perfil`.`id`," +
                " `perfil`.`Descripcion`" +
                " FROM `palabras`.`usuario` INNER JOIN `palabras`.`perfil` on" +
                " `usuario`.`id_perfil` = `perfil`.`id` where `usuario`.`dni` = " + dni_usuario.ToString() + " ;";
            MySqlDataAdapter adapter;
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            adapter.Fill(dataSet, "prfil_usuario");
            mySqlConnection.Close();
            return dataSet;
        }

    }

   
}
