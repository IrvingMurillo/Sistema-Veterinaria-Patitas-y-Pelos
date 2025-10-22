using System;

namespace SistemaVeterinariaPatitasYPelos.Clases
{
    /// <summary>
    /// Clase que representa un pago realizado por un servicio.
    /// Autor: Irving Lopez
    /// Fecha: 21/10/2025
    /// </summary>
    public class Pago
    {
        // Identificador único del pago (PK)
        public int IdPago { get; set; }

        // Servicio asociado al pago (FK)
        public Servicio Servicio { get; set; }

        // Fecha del pago
        public DateTime Fecha { get; set; }

        // Monto pagado
        public decimal Monto { get; set; }

        // Método de pago (Efectivo, Tarjeta, Transferencia)
        public string MetodoPago { get; set; }

        // Comentarios adicionales
        public string Comentarios { get; set; }

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Pago() { }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Pago(int idPago, Servicio servicio, DateTime fecha, decimal monto, string metodoPago, string comentarios)
        {
            IdPago = idPago;
            Servicio = servicio;
            Fecha = fecha;
            Monto = monto;
            MetodoPago = metodoPago;
            Comentarios = comentarios;
        }
    }
}
