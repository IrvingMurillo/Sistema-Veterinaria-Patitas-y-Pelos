using System;

namespace SistemaVeterinariaPatitasYPelos.Clases
{
    /// <summary>
    /// Clase que representa a un cliente de la veterinaria.
    /// Autor: Irving Lopez
    /// Fecha: 21/10/2025
    /// </summary>
    public class Cliente
    {
        // Identificador único del cliente (PK)
        public int IdCliente { get; set; }

        // Nombres del cliente
        public string Nombres { get; set; }

        // Apellidos del cliente
        public string Apellidos { get; set; }

        // Teléfono de contacto
        public string Telefono { get; set; }

        // Correo electrónico
        public string Email { get; set; }

        // Dirección del clientes
        public string Direccion { get; set; }

        // Fecha de registro en la veterinaria
        public DateTime FechaRegistro { get; set; }

        // Comentarios adicionales
        public string Comentarios { get; set; }

        // Nombre de usuario para login
        public string Usuario { get; set; }

        // Contraseña (en hash)
        public string Contrasena { get; set; }

        // Lista de permisos separados por coma
        public string Permisos { get; set; }

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Cliente() { }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Cliente(int idCliente, string nombres, string apellidos, string telefono,
                       string email, string direccion, DateTime fechaRegistro,
                       string comentarios, string usuario, string contrasena, string permisos)
        {
            IdCliente = idCliente;
            Nombres = nombres;
            Apellidos = apellidos;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
            FechaRegistro = fechaRegistro;
            Comentarios = comentarios;
            Usuario = usuario;
            Contrasena = contrasena;
            Permisos = permisos;
        }
    }
}
