using System;

namespace SistemaVeterinariaPatitasYPelos.Clases
{
    /// <summary>
    /// Clase que representa el detalle de una compra.
    /// Autor: Irving Lopez
    /// Fecha: 21/10/2025
    /// </summary>
    public class DetalleCompra
    {
        // Identificador único del detalle de compra (PK)
        public int IdDetalleCompra { get; set; }

        // Compra a la que pertenece este detalle (FK)
        public Compra Compra { get; set; }

        // Producto comprado (FK)
        public Producto Producto { get; set; }

        // Cantidad comprada
        public int Cantidad { get; set; }

        // Precio por unidad
        public decimal PrecioUnitario { get; set; }

        // Subtotal calculado (Cantidad * PrecioUnitario)
        public decimal Subtotal => Cantidad * PrecioUnitario;

        // Comentarios adicionales
        public string Comentarios { get; set; }

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public DetalleCompra() { }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public DetalleCompra(int idDetalleCompra, Compra compra, Producto producto, int cantidad, decimal precioUnitario, string comentarios)
        {
            IdDetalleCompra = idDetalleCompra;
            Compra = compra;
            Producto = producto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Comentarios = comentarios;
        }
    }
}
