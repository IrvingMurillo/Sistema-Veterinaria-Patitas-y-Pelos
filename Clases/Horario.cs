using System;

namespace SistemaVeterinariaPatitasYPelos.Clases
{
    /// <summary>
    /// Clase que representa un horario de atención de un veterinario.
    /// Autor: Irving Lopez
    /// Fecha: 21/10/2025
    /// </summary>
    public class Horario
    {
        // Identificador único del horario (PK)
        public int IdHorario { get; set; }

        // Veterinario asignado a este horario (FK)
        public Veterinario Veterinario { get; set; }

        // Fecha del horario
        public DateTime Fecha { get; set; }

        // Hora de inicio
        public TimeSpan HoraInicio { get; set; }

        // Hora de fin
        public TimeSpan HoraFin { get; set; }

        // Indica si el horario está disponible
        public bool Disponible { get; set; }

        // Comentarios adicionales
        public string Comentarios { get; set; }

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Horario() { }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Horario(int idHorario, Veterinario veterinario, DateTime fecha, TimeSpan horaInicio,
                       TimeSpan horaFin, bool disponible, string comentarios)
        {
            IdHorario = idHorario;
            Veterinario = veterinario;
            Fecha = fecha;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            Disponible = disponible;
            Comentarios = comentarios;
        }
    }
}
