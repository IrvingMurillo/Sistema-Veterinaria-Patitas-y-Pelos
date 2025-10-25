using SistemaVeterinariaPatitasYPelos.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaVeterinariaPatitasYPelos.Formularios
{
    /// <summary>
    /// Formulario para gestionar las mascotas registradas en la veterinaria.
    /// Autor: Irving Lopez
    /// Fecha: 24/10/2025
    /// </summary>
    public partial class FmrMascotas : Form
    {
        /// <summary>
        /// Constructor del formulario FmrMascotas.
        /// Inicializa los componentes visuales y asocia el evento Load.
        /// </summary>
        public FmrMascotas()
        {
            InitializeComponent();
            this.Load += FmrMascotas_Load;
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario FmrMascotas.
        /// Inicializa la visualización de las mascotas en el DataGridView.
        /// </summary>
        private void FmrMascotas_Load(object sender, EventArgs e)
        {
            // Llama al método que obtiene y muestra las mascotas
            MostrarMascotas();
        }

        /// <summary>
        /// Método que obtiene todas las mascotas de la base de datos y las muestra en el DataGridView.
        /// </summary>
        private void MostrarMascotas()
        {
            // Creamos una instancia de la clase MascotasCRUD para acceder a los métodos de la base de datos
            MascotasCRUD mascotasCRUD = new MascotasCRUD();

            // Obtenemos todos los registros de mascotas en un DataTable
            DataTable dt = mascotasCRUD.ObtenerTodasMascotas();

            // Verificamos si se obtuvieron registros
            if (dt.Rows.Count > 0)
            {
                // Asignamos el DataTable como origen de datos del DataGridView
                DgvMascotas.DataSource = dt;
            }
            else
            {
                // Mostramos un mensaje si no se encontraron mascotas
                MessageBox.Show("No se encontraron mascotas.");
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
        /// Evento para agregar una nueva mascota.
        /// </summary>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para insertar una nueva mascota
        }

        /// <summary>
        /// Evento para modificar la mascota seleccionada.
        /// </summary>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para modificar una mascota existente
        }

        /// <summary>
        /// Evento para eliminar la mascota seleccionada.
        /// </summary>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para eliminar una mascota
        }

        /// <summary>
        /// Evento para buscar mascotas según un criterio (por nombre, especie, cliente, etc.).
        /// </summary>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para buscar mascotas
        }
    }
}
