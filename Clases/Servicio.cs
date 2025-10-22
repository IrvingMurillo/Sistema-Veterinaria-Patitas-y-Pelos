using System;
using System.Collections.Generic;

namespace SistemaVeterinariaPatitasYPelos.Clases
{
    /// <summary>
    /// Clase que representa un servicio realizado a un cliente.
    /// Puede incluir citas, vacunaciones y compras.
    /// Autor: Irving Lopez
    /// Fecha: 21/10/2025
    /// </summary>
    public class Servicio
    {
        // Identificador único del servicio (PK)
        public int IdServicio { get; set; }

        // Cliente que recibe el servicio (FK)
        public Cliente Cliente { get; set; }

        // Fecha de creación del servicio
        public DateTime Fecha { get; set; }

        // Total del servicio
        public decimal Total { get; set; }

        // Comentarios adicionales
        public string Comentarios { get; set; }

        // Detalles del servicio (cita, vacunación, compra)
        public List<DetalleServicio> Detalles { get; set; }

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Servicio()
        {
            Detalles = new List<DetalleServicio>();
        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Servicio(int idServicio, Cliente cliente, DateTime fecha, decimal total, string comentarios)
        {
            IdServicio = idServicio;
            Cliente = cliente;
            Fecha = fecha;
            Total = total;
            Comentarios = comentarios;
            Detalles = new List<DetalleServicio>();
        }
    }
}
