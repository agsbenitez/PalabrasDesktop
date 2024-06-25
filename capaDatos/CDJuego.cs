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

namespace capaDatos
{
    public class CDJuego
    {
        
        //Metodo 1 para crear el hash de la password
        //https://stackoverflow.com/questions/4181198/how-to-hash-a-password
        //debo almacenar el salt aleatorio, necesario par reproducir la pass



        public long nuevoJuego(DateTime fecha_inicio)
        {

            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();

            String fecha = fecha_inicio.ToString("dd/M/yyyy");

            string Query = "INSERT INTO juego " +
              "(`fecha_inicio`)" +
                " VALUES" +
                "(" + " str_to_date('" + fecha + "', '%d/%m/%Y')" + ");";


            //se instacia la ejecucion de una query
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            //se ejecuta la query
            long lastid;
            try
            {
                mySqlCommand.ExecuteNonQuery();
                lastid = mySqlCommand.LastInsertedId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
                lastid = -1;


            }

            mySqlConnection.Close();
            //MessageBox.Show("Registro creado");
            return lastid;
        }



        public DataSet juegoActivo()
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();

            string Query = "SELECT id from juego where fecha_fin is null ;";
            //se instacia el adaptador
            MySqlDataAdapter adapter;
            //se instancia el dataset
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            //necesario para la correcta representación de los datos
            //se le pone un nombre al dataset porque estos puden tener una o mas tablas
            adapter.Fill(dataSet, "juego_activo");
            mySqlConnection.Close();
            return dataSet;
        }


        public void finjuegoActivo(int id_juego)
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();
            String fecha_fin = DateTime.Now.ToString("dd/M/yyyy");

            string Query = "UPDATE `palabras`.`juego` SET `fecha_fin` =" +
                " str_to_date('" + fecha_fin + "', '%d/%m/%Y')" + " WHERE(`id` =" + id_juego + ");";
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
            //MessageBox.Show("Registro Actualizado");

        }

        public DataSet obtenerCantidadJuegos()
        {
            using (MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection())
            {
                //mySqlConnection.Open();

                string query = "SELECT COUNT(DISTINCT id_juego) FROM juego_detalle";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, mySqlConnection))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "usuario");
                    return dataSet;
                }
            }
        }

        public DataSet obtenerMejorUsuario()
        {
            MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();

            //mySqlConnection.Open();
            string Query = "SELECT " +
                           "`u`.`apellido`, " +
                           "`u`.`nombre`, " +
                           "`u`.`dni`, " +
                           "`u`.`email`, " +
                           "`u`.`establecimiento`, " +
                           "`u`.`grado`, " +
                           "`u`.`fecha_nacimiento`, " +
                           "COUNT(pap.id) AS total_palabras_correctas " +
                           "FROM `usuario` u " +
                           "INNER JOIN `palabras_asignadas_participante` pap ON u.id_usuario = pap.id_participante " +
                           "WHERE pap.correcto = 1 " +
                           "GROUP BY u.id_usuario, u.apellido, u.nombre " +
                           "ORDER BY total_palabras_correctas DESC LIMIT 1";

            MySqlDataAdapter adapter;
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            adapter.Fill(dataSet, "usuario");
            mySqlConnection.Close();
            return dataSet;


        }
    }

   
}
