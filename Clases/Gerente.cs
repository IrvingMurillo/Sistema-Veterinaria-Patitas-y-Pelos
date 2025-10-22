using System;

namespace SistemaVeterinariaPatitasYPelos.Clases
{
    /// <summary>
    /// Clase que representa a un gerente o administrador del sistema.
    /// Autor: Irving Lopez
    /// Fecha: 21/10/2025
    /// </summary>
    public class Gerente
    {
        // Identificador único del gerente (PK)
        public int IdGerente { get; set; }

        // Nombres del gerente
        public string Nombres { get; set; }

        // Apellidos del gerente
        public string Apellidos { get; set; }

        // Teléfono de contacto
        public string Telefono { get; set; }

        // Correo electrónico
        public string Email { get; set; }

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
        public Gerente() { }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Gerente(int idGerente, string nombres, string apellidos, string telefono,
                       string email, DateTime fechaContratacion, string comentarios,
                       string usuario, string contrasena, string permisos)
        {
            IdGerente = idGerente;
            Nombres = nombres;
            Apellidos = apellidos;
            Telefono = telefono;
            Email = email;
            FechaContratacion = fechaContratacion;
            Comentarios = comentarios;
            Usuario = usuario;
            Contrasena = contrasena;
            Permisos = permisos;
        }
    }
}
