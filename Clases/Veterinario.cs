using System;

namespace SistemaVeterinariaPatitasYPelos.Clases
{
    /// <summary>
    /// Clase que representa a un veterinario de la clínica.
    /// Autor: Irving Lopez
    /// Fecha: 21/10/2025
    /// </summary>
    public class Veterinario
    {
        // Identificador único del veterinario (PK)
        public int IdVeterinario { get; set; }

        // Nombres del veterinario
        public string Nombres { get; set; }

        // Apellidos del veterinario
        public string Apellidos { get; set; }

        // Teléfono de contacto
        public string Telefono { get; set; }

        // Correo electrónico
        public string Email { get; set; }

        // Especialidad del veterinario
        public string Especialidad { get; set; }

        // Fecha de contratación
        public DateTime FechaContratacion { get; set; }

        // Comentarios adicionales
        public string Comentarios { get; set; }

        // Usuario para login
        public string Usuario { get; set; }

        // Contraseña en hash
        public string Contrasena { get; set; }

        // Permisos separados por coma
        public string Permisos { get; set; }

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Veterinario() { }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Veterinario(int idVeterinario, string nombres, string apellidos, string telefono,
                           string email, string especialidad, DateTime fechaContratacion,
                           string comentarios, string usuario, string contrasena, string permisos)
        {
            IdVeterinario = idVeterinario;
            Nombres = nombres;
            Apellidos = apellidos;
            Telefono = telefono;
            Email = email;
            Especialidad = especialidad;
            FechaContratacion = fechaContratacion;
            Comentarios = comentarios;
            Usuario = usuario;
            Contrasena = contrasena;
            Permisos = permisos;
        }
    }
}
