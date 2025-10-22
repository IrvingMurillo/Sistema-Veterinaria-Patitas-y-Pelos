using System;

namespace SistemaVeterinariaPatitasYPelos.Clases
{
    /// <summary>
    /// Clase que representa una vacunación aplicada a una mascota.
    /// Autor: Irving Lopez
    /// Fecha: 21/10/2025
    /// </summary>
    public class Vacunacion
    {
        // Identificador único de la vacunación (PK)
        public int IdVacunacion { get; set; }

        // Mascota que recibe la vacuna (FK)
        public Mascota Mascota { get; set; }

        // Producto (vacuna) aplicado (FK)
        public Producto Producto { get; set; }

        // Fecha de aplicación de la vacuna
        public DateTime Fecha { get; set; }

        // Comentarios adicionales
        public string Comentarios { get; set; }

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Vacunacion() { }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Vacunacion(int idVacunacion, Mascota mascota, Producto producto,
                          DateTime fecha, string comentarios)
        {
            IdVacunacion = idVacunacion;
            Mascota = mascota;
            Producto = producto;
            Fecha = fecha;
            Comentarios = comentarios;
        }
    }
}
