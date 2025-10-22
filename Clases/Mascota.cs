using System;

namespace SistemaVeterinariaPatitasYPelos.Clases
{
    /// <summary>
    /// Clase que representa una mascota registrada en la veterinaria.
    /// Autor: Irving Lopez
    /// Fecha: 21/10/2025
    /// </summary>
    public class Mascota
    {
        // Identificador único de la mascota (PK)
        public int IdMascota { get; set; }

        // Identificador del cliente propietario (FK)
        public int IdCliente { get; set; }

        // Nombre de la mascota
        public string Nombre { get; set; }

        // Especie de la mascota
        public string Especie { get; set; }

        // Raza de la mascota
        public string Raza { get; set; }

        // Fecha de nacimiento
        public DateTime FechaNacimiento { get; set; }

        // Sexo de la mascota
        public string Sexo { get; set; }

        // Comentarios adicionales
        public string Comentarios { get; set; }

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Mascota() { }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Mascota(int idMascota, int idCliente, string nombre, string especie,
                       string raza, DateTime fechaNacimiento, string sexo, string comentarios)
        {
            IdMascota = idMascota;
            IdCliente = idCliente;
            Nombre = nombre;
            Especie = especie;
            Raza = raza;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            Comentarios = comentarios;
        }
    }
}
