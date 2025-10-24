using System;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaVeterinariaPatitasYPelos.Clases;

namespace SistemaVeterinariaPatitasYPelos.Datos
{
    class CompraCRUD
    {
        // Instancia de la clase de conexión a la base de datos
        private readonly Conexion conexion;

        /// <summary>
        /// Constructor de la clase CompraCRUD.
        /// Inicializa la conexión a la base de datos.
        /// </summary>
        public CompraCRUD()
        {
            conexion = new Conexion();
        }

        /// <summary>
        /// Obtiene todos los registros de citas de la base de datos.
        /// Se utiliza un DataTable para almacenar temporalmente los resultados.
        /// </summary>
        /// <returns>DataTable con todos los registros de la tabla Citas.</returns>
        public DataTable ObtenerTodasCompras()
        {
            // Creamos un DataTable vacío donde se almacenarán los clientes
            DataTable dtCompras = new DataTable();

            try
            {
                // Abrimos la conexión a la base de datos
                if (conexion.AbrirConexion())
                {
                    // Consulta SQL para obtener todos los compras
                    string query = "SELECT * FROM Compra";

                    // Creamos un comando con la consulta y la conexión
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion.GetConnection()))
                    {
                        // Adaptador para llenar el DataTable con los resultados de la consulta
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dtCompras); // Llenamos el DataTable
                        }
                    }

                    // Mensaje opcional para depuración: número de filas obtenidas
                    Console.WriteLine("Cantidad de filas obtenidas: " + dtCompras.Rows.Count);
                }
            }
            catch (Exception ex)
            {
                // Captura de errores y mensaje en consola
                Console.WriteLine("Error al obtener compras: " + ex.Message);
            }
            finally
            {
                // Cerramos la conexión en cualquier caso para liberar recursos
                conexion.CerrarConexion();
            }

            // Retornamos el DataTable con los clientes
            return dtCompras;
        }
    }
}
