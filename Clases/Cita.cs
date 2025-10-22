using System;

namespace SistemaVeterinariaPatitasYPelos.Clases
{
    /// <summary>
    /// Clase que representa una cita programada para una mascota.
    /// Autor: Irving Lopez
    /// Fecha: 21/10/2025
    /// </summary>
    public class Cita
    {
        // Identificador único de la cita (PK)
        public int IdCita { get; set; }

        // Mascota asociada a la cita (FK)
        public Mascota Mascota { get; set; }

        // Veterinario asignado a la cita (FK)
        public Veterinario Veterinario { get; set; }

        // Horario reservado para la cita (FK)
        public Horario Horario { get; set; }

        // Fecha y hora de creación de la cita
        public DateTime Fecha { get; set; }

        // Comentarios adicionales sobre la cita
        public string Comentarios { get; set; }

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Cita() { }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Cita(int idCita, Mascota mascota, Veterinario veterinario, Horario horario,
                    DateTime fecha, string comentarios)
        {
            IdCita = idCita;
            Mascota = mascota;
            Veterinario = veterinario;
            Horario = horario;
            Fecha = fecha;
            Comentarios = comentarios;
        }
    }
}
