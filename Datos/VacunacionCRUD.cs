using System;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaVeterinariaPatitasYPelos.Clases;

namespace SistemaVeterinariaPatitasYPelos.Datos
{
    /// <summary>
    /// Clase para realizar operaciones CRUD sobre la tabla Vacunacion en la base de datos.
    /// Autor: Irving Lopez
    /// Fecha: 24/10/2025
    /// </summary>
    class VacunacionCRUD
    {
        // Instancia de la clase de conexión a la base de datos
        private readonly Conexion conexion;

        /// <summary>
        /// Constructor de la clase VacunacionCRUD.
        /// Inicializa la conexión a la base de datos.
        /// </summary>
        public VacunacionCRUD()
        {
            conexion = new Conexion();
        }

        /// <summary>
        /// Obtiene todos los registros de vacunaciones de la base de datos.
        /// Se utiliza un DataTable para almacenar temporalmente los resultados.
        /// </summary>
        /// <returns>DataTable con todas las vacunaciones registradas.</returns>
        public DataTable ObtenerTodasVacunaciones()
        {
            // Creamos un DataTable vacío donde se almacenarán las vacunaciones
            DataTable dtVacunaciones = new DataTable();

            try
            {
                // Abrimos la conexión a la base de datos
                if (conexion.AbrirConexion())
                {
                    // Consulta SQL para obtener las vacunaciones con información legible
                    string query = @"
                        SELECT 
                            v.id_vacunacion,
                            m.nombre AS nombre_mascota,
                            p.nombre AS nombre_producto,
                            v.fecha,
                            v.comentarios
                        FROM Vacunacion v
                        INNER JOIN Mascotas m ON v.id_mascota = m.id_mascota
                        INNER JOIN Productos p ON v.id_producto = p.id_producto
                        ORDER BY v.fecha DESC
                    ";

                    // Creamos un comando con la consulta y la conexión
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion.GetConnection()))
                    {
                        // Adaptador para llenar el DataTable con los resultados de la consulta
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dtVacunaciones); // Llenamos el DataTable
                        }
                    }

                    // Mensaje opcional para depuración: número de filas obtenidas
                    Console.WriteLine("Cantidad de vacunaciones obtenidas: " + dtVacunaciones.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                // Captura de errores y mensaje en consola
                Console.WriteLine("Error al obtener vacunaciones: " + ex.Message);
            }
            finally
            {
                // Cerramos la conexión en cualquier caso para liberar recursos
                conexion.CerrarConexion();
            }

            // Retornamos el DataTable con las vacunaciones
            return dtVacunaciones;
        }
    }
}
