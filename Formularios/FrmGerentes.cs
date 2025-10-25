using SistemaVeterinariaPatitasYPelos.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaVeterinariaPatitasYPelos.Formularios
{
    /// <summary>
    /// Formulario para gestionar los gerentes de la veterinaria.
    /// Autor: Irving Lopez
    /// Fecha: 24/10/2025
    /// </summary>
    public partial class FmrGerentes : Form
    {
        /// <summary>
        /// Constructor del formulario FmrGerentes.
        /// Inicializa los componentes visuales y asocia el evento Load.
        /// </summary>
        public FmrGerentes()
        {
            InitializeComponent();
            this.Load += FmrGerentes_Load;
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario FmrGerentes.
        /// Inicializa la visualización de los gerentes en el DataGridView.
        /// </summary>
        private void FmrGerentes_Load(object sender, EventArgs e)
        {
            // Llama al método que obtiene y muestra los gerentes
            MostrarGerentes();
        }

        /// <summary>
        /// Método que obtiene todos los gerentes de la base de datos y los muestra en el DataGridView.
        /// </summary>
        private void MostrarGerentes()
        {
            // Creamos una instancia de la clase GerenteCRUD para acceder a los métodos de la base de datos
            GerenteCRUD gerenteCRUD = new GerenteCRUD();

            // Obtenemos todos los registros de gerentes en un DataTable
            DataTable dt = gerenteCRUD.ObtenerTodosGerentes();

            // Verificamos si se obtuvieron registros
            if (dt.Rows.Count > 0)
            {
                // Asignamos el DataTable como origen de datos del DataGridView
                DgvGerentes.DataSource = dt;
            }
            else
            {
                // Mostramos un mensaje si no se encontraron gerentes
                MessageBox.Show("No se encontraron gerentes.");
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
        /// Evento para agregar un nuevo gerente.
        /// </summary>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para insertar un nuevo gerente
        }

        /// <summary>
        /// Evento para modificar el gerente seleccionado.
        /// </summary>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para modificar un gerente existente
        }

        /// <summary>
        /// Evento para eliminar el gerente seleccionado.
        /// </summary>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para eliminar un gerente
        }

        /// <summary>
        /// Evento para buscar gerentes según un criterio.
        /// </summary>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para buscar gerentes
        }
    }
}
