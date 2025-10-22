using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaVeterinariaPatitasYPelos.Clases
{
    class Conexion
    {
        // Cadena de conexión a la base de datos MySQL
        // readonly: significa que solo se puede asignar al declarar o en el constructor
        private readonly string connectionString = "server=localhost;port=3306;user=root;password=Admin123;database=patitas_pelos;";

        // Objeto que representa la conexión a la base de datos
        private readonly MySqlConnection connection;

        // Constructor de la clase
        // Se ejecuta al crear un objeto de tipo Conexion
        public Conexion()
        {
            connection = new MySqlConnection(connectionString); // Crear la conexión con la cadena indicada
        }

        // Método para abrir la conexión
        public bool AbrirConexion()
        {
            try
            {
                connection.Open(); // Intenta abrir la conexión
                Console.WriteLine("Conexión abierta correctamente.");
                return true; // Retorna true si se abre correctamente
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return false; // Retorna false si hay error
            }
        }

        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            try
            {
                connection.Close(); // Intenta cerrar la conexión
                Console.WriteLine("Conexión cerrada correctamente.");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }

        // Método para obtener el objeto de conexión
        // Esto es útil si quieres ejecutar consultas SQL directamente
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
