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
using System.Collections;
using System.Data.SqlClient;

namespace capaDatos
{
    public class CDJuego_detalle
    {
        string cadenaConexion = "Server=127.0.0.1;User=ariel;Password=Mastera953!;Port=3306;database=palabras";

        //Metodo 1 para crear el hash de la password
        //https://stackoverflow.com/questions/4181198/how-to-hash-a-password
        //debo almacenar el salt aleatorio, necesario par reproducir la pass
       


        public void NuevoJuegoDetalle(long id_juego, long id_participante)
        {
            
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();
            
            string Query = "INSERT INTO juego_detalle " +
              "(`id_juego`, `id_participante`)" +
                " VALUES" +
                "('" + id_juego + "', '" + id_participante + "');";
            

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
            }

            mySqlConnection.Close();
            //MessageBox.Show("Registro creado");
            
        }



        public DataSet JugadoresdelJuego(int id_juego)
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();

            //mySqlConnection.Open();

            string Query = "SELECT juego_detalle.id, juego_detalle.id_participante," +
                "concat(usuario.apellido,' ',usuario.nombre)  as full_name " +
                "FROM palabras.juego_detalle INNER JOIN usuario ON " +
                "juego_detalle.id_participante = usuario.id_usuario WHERE id_juego = " + id_juego + ";";

            //se instacia el adaptador
            MySqlDataAdapter adapter;
            //se instancia el dataset
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            //necesario para la correcta representación de los datos
            //se le pone un nombre al dataset porque estos puden tener una o mas tablas
            adapter.Fill(dataSet, "jugadoresdeljuego");
            mySqlConnection.Close();
            return dataSet;

        }

    }

   
}
