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
    public class CDPermisos
    {
        string cadenaConexion = "Server=127.0.0.1;User=ariel;Password=Mastera953!;Port=3306;database=palabras";

            public void Editar(CEPermisos cEPermisos)
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();
            
            string Query = "UPDATE permisos SET" +
                " `alta_usuario_admin`= " + cEPermisos.alta_usuario_admin + "," +
                " `modificacion_usuario`= " + cEPermisos.modificacion_usuario + "," +
                " `baja_usuario`= " + cEPermisos.baja_usuario + "," +
                " `alta_usuario`= " + cEPermisos.alta_usuario + "," +
                " `alta_palabras`= " + cEPermisos.alta_palabras + "," +
                " `modificacion_palabras`= " + cEPermisos.modificacion_palabras + "," +
                " `baja_palabras`= " + cEPermisos.baja_palabras + "," +
                " `nuevo_juego`= " + cEPermisos.nuevo_juego + "," +
                " `reportes`= " + cEPermisos.reportes + "," +
                " `backup`= " + cEPermisos.backup + "," +
                " `listado_palabras`= " + cEPermisos.listado_palabras + "," +
                " `permisos`= " + cEPermisos.permisos + 
                " WHERE `id_perfil_permisos`= " + cEPermisos.id_pefil_permisos + "";


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

        
        public DataSet listaPermisos(int id_perfil)
        {
            //Se instancia la conecxion
           MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            ////mySqlConnection.Open();
            string Query = "SELECT" +
                "`permisos`.`id`," +
                "`permisos`.`id_perfil_permisos`, " +
                "`permisos`.`alta_usuario_admin`, " +
                "`permisos`.`modificacion_usuario`," +
                "`permisos`.`baja_usuario`, " +
                "`permisos`.`alta_usuario`, " +
                "`permisos`.`alta_palabras`, " +
                "`permisos`.`modificacion_palabras`, " +
                "`permisos`.`baja_palabras`, " +
                "`permisos`.`nuevo_juego`, " +
                "`permisos`.`reportes`, " +
                "`permisos`.`backup`, " +
                "`permisos`.`listado_palabras`, " +
                "`permisos`.`permisos` " +
                " FROM `palabras`.`permisos` INNER JOIN `palabras`.`perfil` on" +
                " `permisos`.`id_perfil_permisos` = `perfil`.`id`" +
                " WHERE `permisos`.`id_perfil_permisos` =" + id_perfil + " LIMIT 1000";
            //se instacia el adaptador
            MySqlDataAdapter adapter;
            //se instancia el dataset
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            //necesario para la correcta representación de los datos
            //se le pone un nombre al dataset porque estos puden tener una o mas tablas
            adapter.Fill(dataSet, "permisos");
            mySqlConnection.Close();
            return dataSet;

          
        }

        
    }

   
}
