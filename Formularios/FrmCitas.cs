using SistemaVeterinariaPatitasYPelos.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaVeterinariaPatitasYPelos.Formularios
{
    /// <summary>
    /// Formulario para gestionar las citas programadas en la veterinaria.
    /// Autor: Irving Lopez
    /// Fecha: 23/10/2025
    /// </summary>
    public partial class FmrCitas : Form
    {
        /// <summary>
        /// Constructor del formulario FmrCitas.
        /// Inicializa los componentes visuales y asocia el evento Load.
        /// </summary>
        public FmrCitas()
        {
            InitializeComponent();
            this.Load += FmrCitas_Load;
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario FmrCitas.
        /// Inicializa la visualización de las citas en el DataGridView.
        /// </summary>
        private void FmrCitas_Load(object sender, EventArgs e)
        {
            // Llama al método que obtiene y muestra las citas
            MostrarCitas();
        }

        /// <summary>
        /// Método que obtiene todas las citas de la base de datos y las muestra en el DataGridView.
        /// </summary>
        private void MostrarCitas()
        {
            // Creamos una instancia de la clase CitasCRUD para acceder a los métodos de la base de datos
            CitaCRUD CitaCRUD = new CitaCRUD();

            // Obtenemos todos los registros de citas en un DataTable
            DataTable dt = CitaCRUD.ObtenerTodasCitas();

            // Verificamos si se obtuvieron registros
            if (dt.Rows.Count > 0)
            {
                // Asignamos el DataTable como origen de datos del DataGridView
                DgvCitas.DataSource = dt;
            }
            else
            {
                // Mostramos un mensaje si no se encontraron citas
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
        /// Evento para agregar una nueva cita.
        /// </summary>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para insertar una nueva cita
        }

        /// <summary>
        /// Evento para modificar la cita seleccionada.
        /// </summary>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para modificar una cita existente
        }

        /// <summary>
        /// Evento para eliminar la cita seleccionada.
        /// </summary>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para eliminar una cita
        }

        /// <summary>
        /// Evento para buscar citas según un criterio.
        /// </summary>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para buscar citas
        }
    }
}
