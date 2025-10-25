using System;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaVeterinariaPatitasYPelos.Clases;

namespace SistemaVeterinariaPatitasYPelos.Datos
{
    /// <summary>
    /// Clase para realizar operaciones CRUD sobre la tabla Productos en la base de datos.
    /// Autor: Irving Lopez
    /// Fecha: 24/10/2025
    /// </summary>
    class ProductoCRUD
    {
        // Instancia de la clase de conexión a la base de datos
        private readonly Conexion conexion;

        /// <summary>
        /// Constructor de la clase ProductoCRUD.
        /// Inicializa la conexión a la base de datos.
        /// </summary>
        public ProductoCRUD()
        {
            conexion = new Conexion();
        }

        /// <summary>
        /// Obtiene todos los registros de productos de la base de datos.
        /// Se utiliza un DataTable para almacenar temporalmente los resultados.
        /// </summary>
        /// <returns>DataTable con todos los registros de la tabla Productos.</returns>
        public DataTable ObtenerTodosProductos()
        {
            // Creamos un DataTable vacío donde se almacenarán los productos
            DataTable dtProductos = new DataTable();

            try
            {
                // Abrimos la conexión a la base de datos
                if (conexion.AbrirConexion())
                {
                    // Consulta SQL para obtener todos los productos
                    string query = "SELECT * FROM Productos";

                    // Creamos un comando con la consulta y la conexión
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion.GetConnection()))
                    {
                        // Adaptador para llenar el DataTable con los resultados de la consulta
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dtProductos); // Llenamos el DataTable
                        }
                    }

                    // Mensaje opcional para depuración: número de filas obtenidas
                    Console.WriteLine("Cantidad de filas obtenidas: " + dtProductos.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                // Captura de errores y mensaje en consola
                Console.WriteLine("Error al obtener productos: " + ex.Message);
            }
            finally
            {
                // Cerramos la conexión en cualquier caso para liberar recursos
                conexion.CerrarConexion();
            }

            // Retornamos el DataTable con los productos
            return dtProductos;
        }
    }
}
