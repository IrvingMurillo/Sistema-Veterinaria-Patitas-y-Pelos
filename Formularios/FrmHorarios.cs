using SistemaVeterinariaPatitasYPelos.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaVeterinariaPatitasYPelos.Formularios
{
    /// <summary>
    /// Formulario para gestionar los horarios de los veterinarios.
    /// Autor: Irving Lopez
    /// Fecha: 24/10/2025
    /// </summary>
    public partial class FmrHorarios : Form
    {
        /// <summary>
        /// Constructor del formulario FmrHorarios.
        /// Inicializa los componentes visuales y asocia el evento Load.
        /// </summary>
        public FmrHorarios()
        {
            InitializeComponent();
            this.Load += FmrHorarios_Load;
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario FmrHorarios.
        /// Inicializa la visualización de los horarios en el DataGridView.
        /// </summary>
        private void FmrHorarios_Load(object sender, EventArgs e)
        {
            // Llama al método que obtiene y muestra los horarios
            MostrarHorarios();
        }

        /// <summary>
        /// Método que obtiene todos los horarios de la base de datos y los muestra en el DataGridView.
        /// </summary>
        private void MostrarHorarios()
        {
            // Creamos una instancia de la clase HorariosCRUD para acceder a los métodos de la base de datos
            HorariosCRUD horariosCRUD = new HorariosCRUD();

            // Obtenemos todos los registros de horarios en un DataTable
            DataTable dt = horariosCRUD.ObtenerTodosHorarios();

            // Verificamos si se obtuvieron registros
            if (dt.Rows.Count > 0)
            {
                // Asignamos el DataTable como origen de datos del DataGridView
                DgvHorarios.DataSource = dt;
            }
            else
            {
                // Mostramos un mensaje si no se encontraron horarios
                MessageBox.Show("No se encontraron horarios.");
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
        /// Evento para agregar un nuevo horario.
        /// </summary>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para insertar un nuevo horario
        }

        /// <summary>
        /// Evento para modificar el horario seleccionado.
        /// </summary>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para modificar un horario existente
        }

        /// <summary>
        /// Evento para eliminar el horario seleccionado.
        /// </summary>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para eliminar un horario
        }

        /// <summary>
        /// Evento para buscar horarios según un criterio.
        /// </summary>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para buscar horarios
        }
    }
}
