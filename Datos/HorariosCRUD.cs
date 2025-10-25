using System;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaVeterinariaPatitasYPelos.Clases;

namespace SistemaVeterinariaPatitasYPelos.Datos
{
    /// <summary>
    /// Clase para realizar operaciones CRUD sobre la tabla Horario en la base de datos.
    /// Incluye la obtención de los horarios junto con el nombre completo del veterinario asignado.
    /// Autor: Irving Lopez
    /// Fecha: 24/10/2025
    /// </summary>
    public class HorariosCRUD
    {
        // Instancia de la clase de conexión a la base de datos
        private readonly Conexion conexion;

        /// <summary>
        /// Constructor de la clase HorariosCRUD.
        /// Inicializa la conexión a la base de datos.
        /// </summary>
        public HorariosCRUD()
        {
            conexion = new Conexion();
        }

        /// <summary>
        /// Obtiene todos los horarios de la base de datos.
        /// Incluye información del veterinario asignado a cada horario.
        /// Se utiliza un DataTable para almacenar temporalmente los resultados.
        /// </summary>
        /// <returns>DataTable con todos los registros de la tabla Horario y nombre del veterinario.</returns>
        public DataTable ObtenerTodosHorarios()
        {
            // Creamos un DataTable vacío donde se almacenarán los horarios
            DataTable dtHorarios = new DataTable();

            try
            {
                // Abrimos la conexión a la base de datos
                if (conexion.AbrirConexion())
                {
                    // Consulta SQL que une Horario con Veterinarios para mostrar el nombre completo
                    string query = @"
                        SELECT 
                            h.id_horario,
                            CONCAT(v.nombres, ' ', v.apellidos) AS nombre_veterinario,
                            h.fecha,
                            h.hora_inicio,
                            h.hora_fin,
                            h.disponible,
                            h.comentarios
                        FROM Horario h
                        INNER JOIN Veterinarios v ON h.id_veterinario = v.id_veterinario
                        ORDER BY h.fecha, h.hora_inicio
                    ";

                    // Creamos un comando con la consulta y la conexión
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion.GetConnection()))
                    {
                        // Adaptador para llenar el DataTable con los resultados de la consulta
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dtHorarios); // Llenamos el DataTable
                        }
                    }

                    // Mensaje opcional para depuración: número de filas obtenidas
                    Console.WriteLine("Cantidad de horarios obtenidos: " + dtHorarios.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                // Captura de errores y mensaje en consola
                Console.WriteLine("Error al obtener horarios: " + ex.Message);
            }
            finally
            {
                // Cerramos la conexión en cualquier caso para liberar recursos
                conexion.CerrarConexion();
            }

            // Retornamos el DataTable con los horarios
            return dtHorarios;
        }
    }
}
