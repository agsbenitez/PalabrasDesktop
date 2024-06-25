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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Reflection;
using System.Collections;

namespace capaDatos
{
    public class Usuario
    {
       
        //Metodo 1 para crear el hash de la password
        //https://stackoverflow.com/questions/4181198/how-to-hash-a-password
        //debo almacenar el salt aleatorio, necesario par reproducir la pass
        private string PasswordSalt
        {
            get
            {
                var rng = new RNGCryptoServiceProvider();
                var buff = new byte[32];
                rng.GetBytes(buff);
                return Convert.ToBase64String(buff);
            }
        }

        private string encodePassword(string password, string salt)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] src = Encoding.Unicode.GetBytes(salt);
            byte[] dst = new byte[src.Length + bytes.Length];
            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);
            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inarray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inarray);
        }

        public DataSet nivelUsuario(int id_usuario)
        {

            //Se instancia la conecxion con el patron singleton
            MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();

            string Query = "SELECT usuario.id_dificultad FROM palabras.usuario" +
                            " where usuario.id_usuario = " + id_usuario.ToString() + ";";


            //se instacia el adaptador
            MySqlDataAdapter adapter;
            //se instancia el dataset
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            //necesario para la correcta representación de los datos
            //se le pone un nombre al dataset porque estos puden tener una o mas tablas
            adapter.Fill(dataSet, "Participantes");
            mySqlConnection.Close();
            return dataSet;

        }


        public void crear(CEUsuario cEUsuario)
        {
            //Se instancia la conecxion con el patron singleton
            MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();

            String fecha = cEUsuario.fecha_nacimiento.ToString("dd/M/yyyy");

            //deboo hasshear la psssword invocando a algún metodo que lo haga y almasenando solo el hash
            String salt = PasswordSalt;
            String hashedPassword1 = encodePassword(cEUsuario.password, salt);

           


            string Query = "INSERT INTO usuario " +
              "(`apellido`, `nombre`, `dni`, `email`, `fecha_nacimiento`, `Id_perfil`, `establecimiento`,`grado`, `password`, `salt`, `id_dificultad`)" +
                " VALUES " +
                "('" + cEUsuario.apellido + "', '" + cEUsuario.nombre + "', '" + cEUsuario.dni+ "', '" + cEUsuario.email +
                "', str_to_date('" + fecha + "', '%d/%m/%Y'),'" + cEUsuario.id_perfil + "', '" + cEUsuario.entidad + "', '" + cEUsuario.grado + "', '" + hashedPassword1 + "', '" + salt + "', '" + cEUsuario.id_dificultad +  "');";
            

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

        public void editar(CEUsuario cEUsuario)
        {
            //Se instancia la conecxion con el patron singleton
            MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();
            //Se abre la conecxion
            //mySqlConnection.Open();

            String salt = PasswordSalt;
            String hashedPassword1 = encodePassword(cEUsuario.password, salt);

            String fecha = cEUsuario.fecha_nacimiento.ToString("dd/M/yyyy");
            string Query = "UPDATE usuario SET" +
                " `apellido`='" + cEUsuario.apellido + "'," +
                " `nombre`='" + cEUsuario.nombre + "'," +
                " `dni`='" + cEUsuario.dni + "'," +
                " `email`='" + cEUsuario.email + "'," +
                " `fecha_nacimiento`=" + "str_to_date('" + fecha + "', '%d/%m/%Y')" + "," +
                " `Id_perfil`='" + cEUsuario.id_perfil + "',"+
                " `establecimiento`='" + cEUsuario.entidad + "'," +
                " `grado`='" + cEUsuario.grado + "', " +
                " `password`='" + hashedPassword1 + "', " +
                " `salt`='" + salt + "', " +
                " `id_dificultad`='" + cEUsuario.id_dificultad + "' " +
                " WHERE `id_usuario`='" + cEUsuario.id_usuario +"'";


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

        public DataSet recupearPassword(int usuario)
        {
            //Se instancia la conecxion con el patron singleton
            MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection(); 
            string Query =  "SELECT usuario.password, usuario.salt FROM palabras.usuario" +
                            " where usuario.dni = " + usuario + ";";


            //se instacia el adaptador
            MySqlDataAdapter adapter;
            //se instancia el dataset
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            //necesario para la correcta representación de los datos
            //se le pone un nombre al dataset porque estos puden tener una o mas tablas
            adapter.Fill(dataSet, "pass_salt");
            mySqlConnection.Close();
            return dataSet;
        }

        

        public bool passwordMach(string p_almacenada, string p_ingresada, string salt)
        {
            /*
             * funcion que verifica la pass ingresada contra la pass almacenda
             */
            string passIngreHash = this.encodePassword(p_ingresada, salt);
            if (passIngreHash == p_almacenada)
            {
                return true;
            }

            return false;
            
        }


        public void borrar(CEUsuario cEUsuario)
        {
            //Se instancia la conecxion
            MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();

            //Se abre la conecxion
            //mySqlConnection.Open();
            string Query = "UPDATE usuario SET" +
                " `borrado`= 1 " +
                "WHERE `id_usuario`='" + cEUsuario.id_usuario + "'";


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


        public DataSet listaUsuarios()
        {
            //Se instancia la conecxion
            MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();

            //Se abre la conecxion
            //mySqlConnection.Open();
            string Query = "SELECT`usuario`.`id_usuario`,  `usuario`.`apellido`, `usuario`.`nombre`, `usuario`.`dni`," +
                "`usuario`.`email`,  `usuario`.`fecha_nacimiento`, `usuario`.`establecimiento`, `usuario`.`grado`," +
                "`usuario`.`id_dificultad`, `dificultad`.`descripcion`, `usuario`.`Id_perfil`, `usuario`.`borrado`, `perfil`.`id`," +
                "`perfil`.`Descripcion` FROM `palabras`.`usuario` INNER JOIN `palabras`.`perfil` on " +
                "`usuario`.`id_perfil` = `perfil`.`id` " +
                " INNER JOIN `dificultad` on `usuario`.`id_dificultad` = `dificultad`.`id_dificultad` " +
                "WHERE `usuario`.`borrado` = 0 or `usuario`.`borrado` is null LIMIT 1000;";

            //se instacia el adaptador
            MySqlDataAdapter adapter;
            //se instancia el dataset
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            //necesario para la correcta representación de los datos
            //se le pone un nombre al dataset porque estos puden tener una o mas tablas
            adapter.Fill(dataSet, "usuarios");
            mySqlConnection.Close();
            return dataSet;

          
        }

        public DataSet listaUsuariosBorrados()
        {
            MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();

            //mySqlConnection.Open();
            string Query = "SELECT `usuario`.`id_usuario`, `usuario`.`apellido`, `usuario`.`nombre`, `usuario`.`dni`, "+
                " `usuario`.`email`, `usuario`.`fecha_nacimiento`, `usuario`.`establecimiento`, `usuario`.`grado`,  `usuario`.`Id_perfil`,  `usuario`.`borrado`, " +
                " `perfil`.`id`, `perfil`.`Descripcion` FROM `palabras`.`usuario` INNER JOIN " +
                " `palabras`.`perfil` on `usuario`.`id_perfil` = `perfil`.`id` INNER JOIN "+
                " `dificultad` on `usuario`.`id_dificultad` = `dificultad`.`id_dificultad`  LIMIT 1000;";
            MySqlDataAdapter adapter;
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            adapter.Fill(dataSet, "usuarios");
            mySqlConnection.Close();
            return dataSet;
            
        }


        

        public DataSet primarios()
        {
            MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();

           ////mySqlConnection.Open();
            string Query = "SELECT" +
                " `usuario`.`id_perfil`, " +
                " `usuario`.`id_usuario`," +
                " `usuario`.`apellido`," +
                " `usuario`.`Nombre`," +
                " `usuario`.`establecimiento`" +
                " FROM `palabras`.`usuario` where id_perfil = 4 and id_dificultad = 4 and borrado = 0";
            MySqlDataAdapter adapter;
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            adapter.Fill(dataSet, "primarios");
            mySqlConnection.Close();
            return dataSet;
        }


        public DataSet secundarios()
        {
            MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();

            ////mySqlConnection.Open();
            string Query = "SELECT" +
                " `usuario`.`id_perfil`, " +
                " `usuario`.`id_usuario`," +
                " `usuario`.`apellido`," +
                " `usuario`.`Nombre`," +
                " `usuario`.`establecimiento`" +
                " FROM `palabras`.`usuario` where id_perfil = 4 and id_dificultad = 5 and borrado = 0";
            MySqlDataAdapter adapter;
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            adapter.Fill(dataSet, "primarios");
            mySqlConnection.Close();
            return dataSet;
        }


        public DataSet obtenerUsuario(int id_usuario)
        {
            MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();

            //mySqlConnection.Open();
            string Query = "SELECT" +
                " `usuario`.`id_perfil`, " +
                " `usuario`.`id_usuario`," +
                " Concat(`usuario`.`apellido`,' ', `usuario`.`Nombre`) as full_name" +
                " FROM `palabras`.`usuario` where id_usuario = " + id_usuario + ";";
            MySqlDataAdapter adapter;
            DataSet dataSet = new DataSet();
            adapter = new MySqlDataAdapter(Query, mySqlConnection);
            adapter.Fill(dataSet, "participante");
            mySqlConnection.Close();
            return dataSet;

        }


        public DataSet obtenerUsuarioPA(string usuario_buscar)
        {
            MySqlConnection mySqlConnection = CDConexion.Instance.GetConnection();

            using (MySqlCommand mySqlCommand = new MySqlCommand("GetUsuarios", mySqlConnection))
            {
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("@usuario_buscar", usuario_buscar);

                // Crear el adaptador de datos
                MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
                DataSet dataSet = new DataSet();

                // Llenar el DataSet con los resultados del procedimiento almacenado
                adapter.Fill(dataSet, "usuarios");

                // Cerrar la conexión
                mySqlConnection.Close();

                return dataSet;
            }

        }


        //esto no va acá lo devo poner en palabras


        //esto no va acá lo devo poner en palabras


    }


}

   

