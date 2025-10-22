using System;

namespace SistemaVeterinariaPatitasYPelos.Clases
{
    /// <summary>
    /// Clase que representa un detalle dentro de un servicio.
    /// Puede ser una cita, vacunación o compra.
    /// Autor: Irving Lopez
    /// Fecha: 21/10/2025
    /// </summary>
    public class DetalleServicio
    {
        // Identificador único del detalle de servicio (PK)
        public int IdDetalleServicio { get; set; }

        // Servicio al que pertenece este detalle (FK)
        public Servicio Servicio { get; set; }

        // Compra asociada (opcional)
        public Compra Compra { get; set; }

        // Cita asociada (opcional)
        public Cita Cita { get; set; }

        // Vacunación asociada (opcional)
        public Vacunacion Vacunacion { get; set; }

        // Subtotal de este detalle
        public decimal Subtotal { get; set; }

        // Comentarios adicionales
        public string Comentarios { get; set; }

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public DetalleServicio() { }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public DetalleServicio(int idDetalleServicio, Servicio servicio, Compra compra,
                               Cita cita, Vacunacion vacunacion, decimal subtotal, string comentarios)
        {
            IdDetalleServicio = idDetalleServicio;
            Servicio = servicio;
            Compra = compra;
            Cita = cita;
            Vacunacion = vacunacion;
            Subtotal = subtotal;
            Comentarios = comentarios;
        }
    }
}
