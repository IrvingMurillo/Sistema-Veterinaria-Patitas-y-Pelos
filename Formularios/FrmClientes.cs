using SistemaVeterinariaPatitasYPelos.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaVeterinariaPatitasYPelos.Formularios
{
    /// <summary>
    /// Formulario para gestionar los clientes de la veterinaria.
    /// Autor: Irving Lopez
    /// Fecha: 23/10/2025
    /// </summary>
    public partial class FmrClientes : Form
    {
        /// <summary>
        /// Constructor del formulario FmrClientes.
        /// Inicializa los componentes visuales y asocia el evento Load.
        /// </summary>
        public FmrClientes()
        {
            InitializeComponent();
            this.Load += FmrClientes_Load;
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario FmrClientes.
        /// Inicializa la visualización de los clientes en el DataGridView.
        /// </summary>
        private void FmrClientes_Load(object sender, EventArgs e)
        {
            // Llama al método que obtiene y muestra los clientes
            MostrarClientes();
        }

        /// <summary>
        /// Método que obtiene todos los clientes de la base de datos y los muestra en el DataGridView.
        /// </summary>
        private void MostrarClientes()
        {
            // Creamos una instancia de la clase ClienteCRUD para acceder a los métodos de la base de datos
            ClienteCRUD clienteCRUD = new ClienteCRUD();

            // Obtenemos todos los registros de clientes en un DataTable
            DataTable dt = clienteCRUD.ObtenerTodosClientes();

            // Verificamos si se obtuvieron registros
            if (dt.Rows.Count > 0)
            {
                // Asignamos el DataTable como origen de datos del DataGridView
                DgvClientes.DataSource = dt;
            }
            else
            {
                // Mostramos un mensaje si no se encontraron clientes
                MessageBox.Show("No se encontraron clientes.");
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
        /// Evento para agregar un nuevo cliente.
        /// </summary>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para insertar un nuevo cliente
        }

        /// <summary>
        /// Evento para modificar el cliente seleccionado.
        /// </summary>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para modificar un cliente existente
        }

        /// <summary>
        /// Evento para eliminar el cliente seleccionado.
        /// </summary>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para eliminar un cliente
        }

        /// <summary>
        /// Evento para buscar clientes según un criterio.
        /// </summary>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para buscar clientes
        }
    }
}
