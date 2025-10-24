using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVeterinariaPatitasYPelos.Datos;

namespace SistemaVeterinariaPatitasYPelos.Formularios
{
    /// <summary>
    /// Formulario para gestionar las compras realizadas en la veterinaria.
    /// Autor: Irving Lopez
    /// Fecha: 23/10/2025
    /// </summary>
    public partial class FmrCompra : Form
    {
        /// <summary>
        /// Constructor del formulario FmrCompra.
        /// Inicializa los componentes visuales y asocia el evento Load.
        /// </summary>
        public FmrCompra()
        {
            InitializeComponent();
            this.Load += FmrCompra_Load;
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario FmrCompra.
        /// Inicializa la visualización de las compras en el DataGridView.
        /// </summary>
        private void FmrCompra_Load(object sender, EventArgs e)
        {
            // Llama al método que obtiene y muestra las compras
            MostrarCompras();
        }

        /// <summary>
        /// Método que obtiene todas las compras de la base de datos y las muestra en el DataGridView.
        /// </summary>
        private void MostrarCompras()
        {
            // Creamos una instancia de la clase CompraCRUD para acceder a los métodos de la base de datos
            CompraCRUD compraCRUD = new CompraCRUD();

            // Obtenemos todos los registros de compras en un DataTable
            DataTable dt = compraCRUD.ObtenerTodasCompras();

            // Verificamos si se obtuvieron registros
            if (dt.Rows.Count > 0)
            {
                // Asignamos el DataTable como origen de datos del DataGridView
                DgvCompras.DataSource = dt;
            }
            else
            {
                // Mostramos un mensaje si no se encontraron compras
                MessageBox.Show("No se encontraron compras.");
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
        /// Evento para agregar una nueva compra.
        /// </summary>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para insertar una nueva compra
        }

        /// <summary>
        /// Evento para modificar la compra seleccionada.
        /// </summary>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para modificar una compra existente
        }

        /// <summary>
        /// Evento para eliminar la compra seleccionada.
        /// </summary>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para eliminar una compra
        }

        /// <summary>
        /// Evento para buscar compras según un criterio.
        /// </summary>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Aquí se agregará la lógica para buscar compras
        }
    }
}
