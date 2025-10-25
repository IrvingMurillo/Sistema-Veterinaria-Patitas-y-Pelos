using SistemaVeterinariaPatitasYPelos.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaVeterinariaPatitasYPelos.Formularios
{
    /// <summary>
    /// Formulario para gestionar los productos de la veterinaria.
    /// Autor: Irving Lopez
    /// Fecha: 24/10/2025
    /// </summary>
    public partial class FmrProductos : Form
    {
        /// <summary>
        /// Constructor del formulario FmrProductos.
        /// Inicializa los componentes visuales y asocia el evento Load.
        /// </summary>
        public FmrProductos()
        {
            InitializeComponent();
            this.Load += FmrProductos_Load;
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario FmrProductos.
        /// Inicializa la visualización de los productos en el DataGridView.
        /// </summary>
        private void FmrProductos_Load(object sender, EventArgs e)
        {
            // Llama al método que obtiene y muestra los productos
            MostrarProductos();
        }

        /// <summary>
        /// Método que obtiene todos los productos de la base de datos y los muestra en el DataGridView.
        /// </summary>
        private void MostrarProductos()
        {
            // Creamos una instancia de la clase ProductoCRUD para acceder a los métodos de la base de datos
            ProductoCRUD productoCRUD = new ProductoCRUD();

            // Obtenemos todos los registros de productos en un DataTable
            DataTable dt = productoCRUD.ObtenerTodosProductos();

            // Verificamos si se obtuvieron registros
            if (dt.Rows.Count > 0)
            {
                // Asignamos el DataTable como origen de datos del DataGridView
                DgvProductos.DataSource = dt;
            }
            else
            {
                // Mostramos un mensaje si no se encontraron productos
                MessageBox.Show("No se encontraron productos.");
            }
        }

        /// <summary>
        /// Cierra el formulario al presionar el botón Salir.
        /// </summary>
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento para agregar un nuevo producto.
        /// </summary>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para insertar un nuevo producto
        }

        /// <summary>
        /// Evento para modificar el producto seleccionado.
        /// </summary>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para modificar un producto existente
        }

        /// <summary>
        /// Evento para eliminar el producto seleccionado.
        /// </summary>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para eliminar un producto
        }

        /// <summary>
        /// Evento para buscar productos según un criterio.
        /// </summary>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para buscar productos
        }
    }
}
