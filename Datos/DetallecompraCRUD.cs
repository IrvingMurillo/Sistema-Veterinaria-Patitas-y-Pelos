using System;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaVeterinariaPatitasYPelos.Clases;

namespace SistemaVeterinariaPatitasYPelos.Datos
{
    /// <summary>
    /// Clase para operaciones sobre el detalle de compras.
    /// Solo lectura por ahora.
    /// Autor: Irving Lopez
    /// Fecha: 25/10/2025
    /// </summary>
    public class DetalleCompraCRUD
    {
        /// <summary>
        /// Instancia de la clase Conexion para manejar la conexión a MySQL.
        /// </summary>
        private readonly Conexion conexion;

        /// <summary>
        /// Constructor que inicializa la conexión.
        /// </summary>
        public DetalleCompraCRUD()
        {
            conexion = new Conexion();
        }

        /// <summary>
        /// Obtiene los productos asociados a una compra específica.
        /// Incluye cantidad, precio unitario y subtotal.
        /// </summary>
        /// <param name="idCompra">ID de la compra.</param>
        /// <returns>DataTable con productos, cantidad, precio unitario y subtotal.</returns>
        public DataTable ObtenerPorCompra(int idCompra)
        {
            DataTable dtDetalle = new DataTable();

            try
            {
                // Abrir la conexión
                if (conexion.AbrirConexion())
                {
                    string query = @"
                        SELECT 
                            p.nombre AS Producto,
                            p.tipo AS Tipo,
                            dc.cantidad AS Cantidad,
                            dc.precio_unitario AS Precio_Unitario,
                            dc.subtotal AS Subtotal
                        FROM DetalleCompra dc
                        INNER JOIN Productos p ON dc.id_producto = p.id_producto
                        WHERE dc.id_compra = @idCompra;";

                    // Ejecutar la consulta
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@idCompra", idCompra);

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dtDetalle);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar error en consola si falla
                Console.WriteLine("Error al obtener detalle de compra: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                conexion.CerrarConexion();
            }

            return dtDetalle;
        }
    }
}
