using System;
using System.Collections.Generic;

namespace SistemaVeterinariaPatitasYPelos.Clases
{
    /// <summary>
    /// Clase que representa una compra de productos por la clínica o cliente.
    /// Autor: Irving Lopez
    /// Fecha: 21/10/2025
    /// </summary>
    public class Compra
    {
        // Identificador único de la compra (PK)
        public int IdCompra { get; set; }

        // Fecha de la compra
        public DateTime Fecha { get; set; }

        // Comentarios adicionales
        public string Comentarios { get; set; }

        // Lista de detalles de la compra
        public List<DetalleCompra> Detalles { get; set; } = new List<DetalleCompra>();

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Compra() { }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Compra(int idCompra, DateTime fecha, string comentarios)
        {
            IdCompra = idCompra;
            Fecha = fecha;
            Comentarios = comentarios;
        }

        /// <summary>
        /// Calcula el total de la compra sumando los subtotales de los detalles
        /// </summary>
        public decimal Total()
        {
            decimal total = 0;
            foreach (var detalle in Detalles)
            {
                total += detalle.Subtotal;
            }
            return total;
        }
    }
}
