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
using System.Data.SqlClient;

namespace capaDatos
{
    public class CDConexion
    {
        //Implemento el ptrón Singleton para hacer la concexion a la db
        
        private static CDConexion _instance;
        private static readonly object _lock = new object();
        private MySqlConnection _connection;

        private CDConexion()
        {
            // Aquí se inicializa la conexión a la base de datos
            _connection = new MySqlConnection("Server=127.0.0.1;User=ariel;Password=Mastera953!;Port=3306;database=palabras");
            _connection.Open();
        }

        public static CDConexion Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new CDConexion();
                    }
                    return _instance;
                }
            }
        }

        public MySqlConnection GetConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
            return _connection;
        }

    }

   
}
