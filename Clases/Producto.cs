using System;

namespace SistemaVeterinariaPatitasYPelos.Clases
{
    /// <summary>
    /// Clase que representa un producto o insumo de la veterinaria.
    /// Autor: Irving Lopez
    /// Fecha: 21/10/2025
    /// </summary>
    public class Producto
    {
        // Identificador único del producto (PK)
        public int IdProducto { get; set; }

        // Nombre del producto
        public string Nombre { get; set; }

        // Tipo de producto (Vacuna, Medicamento, Comida, Juguete, Higiene)
        public string Tipo { get; set; }

        // Precio unitario
        public decimal Precio { get; set; }

        // Cantidad en inventario
        public int Stock { get; set; }

        // Comentarios adicionales
        public string Comentarios { get; set; }

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Producto() { }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Producto(int idProducto, string nombre, string tipo, decimal precio, int stock, string comentarios)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Tipo = tipo;
            Precio = precio;
            Stock = stock;
            Comentarios = comentarios;
        }
    }
}
