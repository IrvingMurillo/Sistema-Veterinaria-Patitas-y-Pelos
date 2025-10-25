using System;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaVeterinariaPatitasYPelos.Clases;

namespace SistemaVeterinariaPatitasYPelos.Datos
{
    /// <summary>
    /// Clase para realizar operaciones CRUD sobre la tabla Gerentes en la base de datos.
    /// Autor: Irving Lopez
    /// Fecha: 24/10/2025
    /// </summary>
    class GerenteCRUD
    {
        // Instancia de la clase de conexión a la base de datos
        private readonly Conexion conexion;

        /// <summary>
        /// Constructor de la clase GerenteCRUD.
        /// Inicializa la conexión a la base de datos.
        /// </summary>
        public GerenteCRUD()
        {
            conexion = new Conexion();
        }

        /// <summary>
        /// Obtiene todos los registros de gerentes de la base de datos.
        /// Se utiliza un DataTable para almacenar temporalmente los resultados.
        /// </summary>
        /// <returns>DataTable con todos los registros de la tabla Gerentes.</returns>
        public DataTable ObtenerTodosGerentes()
        {
            // Creamos un DataTable vacío donde se almacenarán los gerentes
            DataTable dtGerentes = new DataTable();

            try
            {
                // Abrimos la conexión a la base de datos
                if (conexion.AbrirConexion())
                {
                    // Consulta SQL para obtener todos los gerentes
                    string query = "SELECT * FROM Gerentes";

                    // Creamos un comando con la consulta y la conexión
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion.GetConnection()))
                    {
                        // Adaptador para llenar el DataTable con los resultados de la consulta
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dtGerentes); // Llenamos el DataTable
                        }
                    }

                    // Mensaje opcional para depuración: número de filas obtenidas
                    Console.WriteLine("Cantidad de filas obtenidas: " + dtGerentes.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                // Captura de errores y mensaje en consola
                Console.WriteLine("Error al obtener gerentes: " + ex.Message);
            }
            finally
            {
                // Cerramos la conexión en cualquier caso para liberar recursos
                conexion.CerrarConexion();
            }

            // Retornamos el DataTable con los gerentes
            return dtGerentes;
        }
    }
}
