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
    public class Palabras
    {
        string CadenaConexion = "Server=127.0.0.1;User=ariel;Password=Mastera953!;Port=3306;database=palabras";

        public void crearPalabra(CEPalabras cEPalabras)
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();

            string Query = "INSERT INTO `palabras`.`palabras` (`idDificultad`, `descripcion`) VALUES " +
                "('" + cEPalabras.idDificultad + "', '" + cEPalabras.descripcion + "');";
            // MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
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
            MessageBox.Show("Registro creado");
        }

       
        public DataSet listarPalabras()
        {
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();
            string Query = "select * from `palabras` limit 1000;";
            MySqlDataAdapter Adapter;
            DataSet dataSet = new DataSet();

            Adapter = new MySqlDataAdapter(Query, mySqlConnection);
            Adapter.Fill(dataSet, "tbl");

            return dataSet;
        }

        public DataSet getPalabrasSimilares(string palabraBuscar)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion))
            {

                // Se abre la conexión
                //mySqlConnection.Open();

                // Crear el comando para el procedimiento almacenado
                using (MySqlCommand mySqlCommand = new MySqlCommand("GetPalabrasSimilares", mySqlConnection))
                {
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    mySqlCommand.Parameters.AddWithValue("@palabra_buscar", palabraBuscar);

                    // Crear el adaptador de datos
                    MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
                    DataSet dataSet = new DataSet();

                    // Llenar el DataSet con los resultados del procedimiento almacenado
                    adapter.Fill(dataSet);

                    return dataSet;
                }
            }
        }


        public DataSet obtenerPalabrasIncorrecta()
        {
            MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();

            //mySqlConnection.Open();
            string Query = "SELECT " +
                           "pap.id_palabras, " +
                           "p.palabra AS descripcion_palabra, " +
                           "COUNT(*) AS total_incorrectas " +
                           "FROM palabras_asignadas_participante pap " +
                           "INNER JOIN palabras p ON pap.id_palabras = p.id " +
                           "WHERE pap.correcto = 0 " +
                           "GROUP BY pap.id_palabras, p.palabra " +
                           "ORDER BY total_incorrectas DESC " +
                           "LIMIT 5";

            MySqlDataAdapter adapter;
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            adapter.Fill(dataSet, "usuario");
            mySqlConnection.Close();
            return dataSet;

        }


        public DataSet palabraAzar(int dificultad_participante)
        {
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();
            string Query = "select id from `palabras` where sorteado = 0 and id_dificultad = '" + dificultad_participante.ToString() + "' order by RAND() LIMIT 1;";
            MySqlDataAdapter Adapter;
            DataSet dataSet = new DataSet();

            Adapter = new MySqlDataAdapter(Query, mySqlConnection);
            Adapter.Fill(dataSet, "id_palabra");

            return dataSet;
        }

        public void palabraSorteada(int id_palabra)
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();

            string Query = "UPDATE `palabras` SET  `sorteado`= 1 WHERE `id`= " + id_palabra + ";";


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

        public void editar(CEPalabras cEPalabras)
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();

            string Query = "UPDATE `palabras` SET  `descripcion`= '" + cEPalabras.descripcion + "',`idDificultad` = '" + cEPalabras.idDificultad + "' WHERE `idPalabra`= " + cEPalabras.id +";";


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
            MessageBox.Show("Registro Actualizado");
        }

        public void borrar(CEPalabras cEPalabra)
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();
            string Query = "UPDATE palabras SET" +
                " `borrado`= cEPalabra.borrado" +
                "WHERE `idPalabra`='" + cEPalabra.id + "'";

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
            MessageBox.Show("Palabra Actualizado");
        }


        public DataSet listaPalabras()
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();

            string Query = "SELECT " +
                " `palabras`.`idPalabra`," +
                " `palabras`.`idDificultad`," +
                " `palabras`.`descripcion`," +
                " FROM `palabras`";
            //se instacia el adaptador
            MySqlDataAdapter adapter;
            //se instancia el dataset
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            //necesario para la correcta representación de los datos
            //se le pone un nombre al dataset porque estos puden tener una o mas tablas
            adapter.Fill(dataSet, "palabras");
            mySqlConnection.Close();
            return dataSet;
        }


        public void liberarPalabras()
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();

            string Query = "UPDATE `palabras`.`palabras` SET `sorteado` = '0' WHERE(`sorteado` = '1');";
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


        public DataSet obtenerPalabraCorrecta()
        {
            using (MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection())
            {
                //mySqlConnection.Open();

                string query = @"SELECT
                            pap.id_palabras,
                            p.palabra AS descripcion_palabra,
                            COUNT(*) AS total_correctas
                        FROM
                            Palabras_asignadas_participante pap
                        INNER JOIN
                            palabras p ON pap.id_palabras = p.id
                        WHERE
                            pap.correcto = 1
                        GROUP BY
                            pap.id_palabras, p.palabra
                        ORDER BY
                            total_correctas DESC
                        LIMIT 1";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, mySqlConnection))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "usuario");
                    return dataSet;
                }
            }
        }

    }

   
}
