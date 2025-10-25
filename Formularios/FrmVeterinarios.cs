using SistemaVeterinariaPatitasYPelos.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaVeterinariaPatitasYPelos.Formularios
{
    /// <summary>
    /// Formulario para gestionar los veterinarios de la veterinaria.
    /// Autor: Irving Lopez
    /// Fecha: 24/10/2025
    /// </summary>
    public partial class FmrVeterinarios : Form
    {
        /// <summary>
        /// Constructor del formulario FmrVeterinarios.
        /// Inicializa los componentes visuales y asocia el evento Load.
        /// </summary>
        public FmrVeterinarios()
        {
            InitializeComponent();
            this.Load += FmrVeterinarios_Load;
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario FmrVeterinarios.
        /// Inicializa la visualización de los veterinarios en el DataGridView.
        /// </summary>
        private void FmrVeterinarios_Load(object sender, EventArgs e)
        {
            // Llama al método que obtiene y muestra los veterinarios
            MostrarVeterinarios();
        }

        /// <summary>
        /// Método que obtiene todos los veterinarios de la base de datos y los muestra en el DataGridView.
        /// </summary>
        private void MostrarVeterinarios()
        {
            // Creamos una instancia de la clase VeterinarioCRUD para acceder a los métodos de la base de datos
            VeterinarioCRUD veterinarioCRUD = new VeterinarioCRUD();

            // Obtenemos todos los registros de veterinarios en un DataTable
            DataTable dt = veterinarioCRUD.ObtenerTodosVeterinarios();

            // Verificamos si se obtuvieron registros
            if (dt.Rows.Count > 0)
            {
                // Asignamos el DataTable como origen de datos del DataGridView
                DgvVeterinarios.DataSource = dt;
            }
            else
            {
                // Mostramos un mensaje si no se encontraron veterinarios
                MessageBox.Show("No se encontraron veterinarios.");
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
        /// Evento para agregar un nuevo veterinario.
        /// </summary>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para insertar un nuevo veterinario
        }

        /// <summary>
        /// Evento para modificar el veterinario seleccionado.
        /// </summary>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para modificar un veterinario existente
        }

        /// <summary>
        /// Evento para eliminar el veterinario seleccionado.
        /// </summary>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para eliminar un veterinario
        }

        /// <summary>
        /// Evento para buscar veterinarios según un criterio.
        /// </summary>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para buscar veterinarios
        }
    }
}
