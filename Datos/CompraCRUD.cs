using System;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaVeterinariaPatitasYPelos.Clases;

namespace SistemaVeterinariaPatitasYPelos.Datos
{
    /// <summary>
    /// Clase para operaciones CRUD sobre la tabla Compra.
    /// Solo lectura por ahora.
    /// Autor: Irving Lopez
    /// Fecha: 25/10/2025
    /// </summary>
    public class CompraCRUD
    {
        /// <summary>
        /// Instancia de la clase Conexion para manejar la conexión a MySQL.
        /// </summary>
        private readonly Conexion conexion;

        /// <summary>
        /// Constructor de CompraCRUD.
        /// Inicializa la conexión a la base de datos.
        /// </summary>
        public CompraCRUD()
        {
            conexion = new Conexion();
        }

        /// <summary>
        /// Obtiene todas las compras registradas en la base de datos.
        /// Incluye productos comprados, cantidad total y total de la compra.
        /// La columna de detalle no se incluye aquí, se maneja desde el formulario.
        /// </summary>
        /// <returns>DataTable con todas las compras y su resumen.</returns>
        public DataTable ObtenerTodasCompras()
        {
            DataTable dtCompras = new DataTable();

            try
            {
                // Abrir la conexión
                if (conexion.AbrirConexion())
                {
                    // Consulta para obtener las compras con productos y totales
                    string query = @"
                        SELECT 
                            c.id_compra AS id_compra,
                            c.fecha AS fecha,
                            GROUP_CONCAT(p.nombre SEPARATOR ', ') AS productos_comprados,
                            IFNULL(SUM(dc.cantidad), 0) AS cantidad_total,
                            IFNULL(SUM(dc.subtotal), 0) AS total_compra,
                            c.comentarios AS comentarios
                        FROM Compra c
                        LEFT JOIN DetalleCompra dc ON c.id_compra = dc.id_compra
                        LEFT JOIN Productos p ON dc.id_producto = p.id_producto
                        GROUP BY c.id_compra, c.fecha, c.comentarios
                        ORDER BY c.id_compra DESC;";

                    // Ejecutar la consulta
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion.GetConnection()))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dtCompras);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar error en consola si falla
                Console.WriteLine("Error al obtener compras: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                conexion.CerrarConexion();
            }

            return dtCompras;
        }
    }
}
