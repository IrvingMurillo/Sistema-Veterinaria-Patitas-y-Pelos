using SistemaVeterinariaPatitasYPelos.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaVeterinariaPatitasYPelos.Formularios
{
    /// <summary>
    /// Formulario para gestionar las vacunaciones aplicadas en la veterinaria.
    /// Autor: Irving Lopez
    /// Fecha: 24/10/2025
    /// </summary>
    public partial class FmrVacunaciones : Form
    {
        /// <summary>
        /// Constructor del formulario FmrVacunaciones.
        /// Inicializa los componentes visuales y asocia el evento Load.
        /// </summary>
        public FmrVacunaciones()
        {
            InitializeComponent();
            this.Load += FmrVacunaciones_Load;
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario FmrVacunaciones.
        /// Inicializa la visualización de las vacunaciones en el DataGridView.
        /// </summary>
        private void FmrVacunaciones_Load(object sender, EventArgs e)
        {
            // Llama al método que obtiene y muestra las vacunaciones
            MostrarVacunaciones();
        }

        /// <summary>
        /// Método que obtiene todas las vacunaciones de la base de datos y las muestra en el DataGridView.
        /// </summary>
        private void MostrarVacunaciones()
        {
            // Creamos una instancia de la clase VacunacionCRUD para acceder a los métodos de la base de datos
            VacunacionCRUD vacunacionCRUD = new VacunacionCRUD();

            // Obtenemos todos los registros de vacunaciones en un DataTable
            DataTable dt = vacunacionCRUD.ObtenerTodasVacunaciones();

            // Verificamos si se obtuvieron registros
            if (dt.Rows.Count > 0)
            {
                // Asignamos el DataTable como origen de datos del DataGridView
                DgvVacunaciones.DataSource = dt;
            }
            else
            {
                // Mostramos un mensaje si no se encontraron vacunaciones
                MessageBox.Show("No se encontraron vacunaciones registradas.");
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
        /// Evento para agregar una nueva vacunación.
        /// </summary>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para insertar una nueva vacunación
        }

        /// <summary>
        /// Evento para modificar la vacunación seleccionada.
        /// </summary>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para modificar una vacunación existente
        }

        /// <summary>
        /// Evento para eliminar la vacunación seleccionada.
        /// </summary>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para eliminar una vacunación
        }

        /// <summary>
        /// Evento para buscar vacunaciones según un criterio.
        /// </summary>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para buscar vacunaciones
        }
    }
}
