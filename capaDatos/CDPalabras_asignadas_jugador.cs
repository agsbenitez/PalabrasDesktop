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
using Org.BouncyCastle.Utilities.Collections;
using System.Runtime.InteropServices;
using System.Net;

namespace capaDatos
{
    public class CDPalabras_asignadas_jugador
    {
        string cadenaConexion = "Server=127.0.0.1;User=ariel;Password=Mastera953!;Port=3306;database=palabras";

    

        public void Palabras(long id_juego, long id_participante, int id_palabra)
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();



            string Query = "INSERT INTO palabras_asignadas_participante " +
              "(`id_participante`, `id_juego`, `id_palabras`)" +
                " VALUES" +
                "('" + id_participante + "', '" + id_juego + "', '" + id_palabra + "');";
            

            //se instacia la ejecucion de una query
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            //se ejecuta la query
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return;
            }
            
            mySqlConnection.Close();
           
        }

       

        
        public DataSet listaPalabrasJugador(long id_juego, long id_participante)
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();
            string Query = "SELECT palabras_asignadas_participante.id, palabras_asignadas_participante.id_participante, " +
                "palabras_asignadas_participante.id_juego, palabras_asignadas_participante.id_palabras, palabras.palabra," +
                "palabras_asignadas_participante.correcto, palabras_asignadas_participante.tiempo_respuesta " +
                "From palabras_asignadas_participante inner join palabras on " +
                "palabras_asignadas_participante.id_palabras = palabras.id where id_juego = " + id_juego + " and id_participante =" + id_participante + "; ";

            //se instacia el adaptador
            MySqlDataAdapter adapter;
            //se instancia el dataset
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            //necesario para la correcta representación de los datos
            //se le pone un nombre al dataset porque estos puden tener una o mas tablas
            adapter.Fill(dataSet, "palabrasxjugador");
            mySqlConnection.Close();
            return dataSet;

          
        }

        public void datosPartida(int id_juego, int id_jugador, int id_palabra, int tiempo, bool correcto)
        {
            
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();


            string Query = "UPDATE `palabras`.`palabras_asignadas_participante`" +
                "SET `correcto` = " + Convert.ToString(Convert.ToInt32(correcto)) +
                ", `tiempo_respuesta`= " + tiempo.ToString() + 
                " WHERE (`id_juego` = '" + id_juego.ToString() + "' and  `id_participante`= '" + id_jugador.ToString() + "' and id_palabras = '" + id_palabra.ToString() + "');";


            //se instacia la ejecucion de una query
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            //se ejecuta la query
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return;
            }

        }


        public DataSet NextPaticipante(int id_juego)
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();
            string Query = "SELECT palabras_asignadas_participante.id, palabras_asignadas_participante.id_participante, " +
                "palabras_asignadas_participante.id_juego, palabras_asignadas_participante.id_palabras, palabras.palabra," +
                "palabras_asignadas_participante.correcto, palabras_asignadas_participante.tiempo_respuesta " +
                "From palabras_asignadas_participante inner join palabras on " +
                "palabras_asignadas_participante.id_palabras = palabras.id where id_juego = " + id_juego + "; ";

            //se instacia el adaptador
            MySqlDataAdapter adapter;
            //se instancia el dataset
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            //necesario para la correcta representación de los datos
            //se le pone un nombre al dataset porque estos puden tener una o mas tablas
            adapter.Fill(dataSet, "palabrasxjugador");
            mySqlConnection.Close();
            return dataSet;

        }
    }

   
}
