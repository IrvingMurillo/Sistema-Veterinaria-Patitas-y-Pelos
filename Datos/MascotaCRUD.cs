using System;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaVeterinariaPatitasYPelos.Clases;

namespace SistemaVeterinariaPatitasYPelos.Datos
{
    /// <summary>
    /// Clase para realizar operaciones CRUD sobre la tabla Mascotas en la base de datos.
    /// Incluye la obtención de las mascotas junto con el nombre completo del cliente propietario.
    /// Autor: Irving Lopez
    /// Fecha: 24/10/2025
    /// </summary>
    public class MascotasCRUD
    {
        // Instancia de la clase de conexión a la base de datos
        private readonly Conexion conexion;

        /// <summary>
        /// Constructor de la clase MascotasCRUD.
        /// Inicializa la conexión a la base de datos.
        /// </summary>
        public MascotasCRUD()
        {
            conexion = new Conexion();
        }

        /// <summary>
        /// Obtiene todas las mascotas de la base de datos junto con el nombre completo del cliente propietario.
        /// Se utiliza un DataTable para almacenar temporalmente los resultados.
        /// </summary>
        /// <returns>DataTable con todas las mascotas y nombre del cliente.</returns>
        public DataTable ObtenerTodasMascotas()
        {
            // Creamos un DataTable vacío donde se almacenarán las mascotas
            DataTable dtMascotas = new DataTable();

            try
            {
                // Abrimos la conexión a la base de datos
                if (conexion.AbrirConexion())
                {
                    // Consulta SQL que une Mascotas con Clientes para mostrar el nombre completo del dueño
                    string query = @"
                        SELECT 
                            m.id_mascota,
                            CONCAT(c.nombres, ' ', c.apellidos) AS nombre_cliente,
                            m.nombre AS nombre_mascota,
                            m.especie,
                            m.raza,
                            m.fecha_nacimiento,
                            m.sexo,
                            m.comentarios
                        FROM Mascotas m
                        INNER JOIN Clientes c ON m.id_cliente = c.id_cliente
                        ORDER BY m.nombre
                    ";

                    // Creamos un comando con la consulta y la conexión
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion.GetConnection()))
                    {
                        // Adaptador para llenar el DataTable con los resultados de la consulta
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dtMascotas); // Llenamos el DataTable
                        }
                    }

                    // Mensaje opcional para depuración: número de filas obtenidas
                    Console.WriteLine("Cantidad de mascotas obtenidas: " + dtMascotas.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                // Captura de errores y mensaje en consola
                Console.WriteLine("Error al obtener mascotas: " + ex.Message);
            }
            finally
            {
                // Cerramos la conexión en cualquier caso para liberar recursos
                conexion.CerrarConexion();
            }

            // Retornamos el DataTable con las mascotas
            return dtMascotas;
        }
    }
}
