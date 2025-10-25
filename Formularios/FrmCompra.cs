using SistemaVeterinariaPatitasYPelos.Datos;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVeterinariaPatitasYPelos.Formularios
{
    /// <summary>
    /// Formulario para gestionar las compras realizadas en la veterinaria.
    /// Autor: Irving Lopez
    /// Fecha: 25/10/2025
    /// </summary>
    public partial class FmrCompra : Form
    {
        /// <summary>
        /// Instancia de la clase CompraCRUD para manejar compras.
        /// </summary>
        private readonly CompraCRUD compraCRUD;

        /// <summary>
        /// Instancia de la clase DetalleCompraCRUD para manejar detalles de compras.
        /// </summary>
        private readonly DetalleCompraCRUD detalleCRUD;

        /// <summary>
        /// Constructor del formulario FmrCompra.
        /// Inicializa los componentes visuales y asocia el evento Load.
        /// </summary>
        public FmrCompra()
        {
            InitializeComponent();
            this.Load += FmrCompra_Load;

            compraCRUD = new CompraCRUD();
            detalleCRUD = new DetalleCompraCRUD();
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
        /// Configura la columna "ver_detalle" como un botón amarillo con hover.
        /// </summary>
        private void MostrarCompras()
        {
            // Obtener todas las compras usando CompraCRUD
            DataTable dt = compraCRUD.ObtenerTodasCompras();

            // Verificamos si se obtuvieron registros
            if (dt.Rows.Count > 0)
            {
                // Asignamos el DataTable como origen de datos del DataGridView
                DgvCompras.DataSource = dt;

                // Asociar eventos solo una vez
                DgvCompras.CellClick -= DgvCompras_CellClick;
                DgvCompras.CellClick += DgvCompras_CellClick;

                DgvCompras.CellPainting -= DgvCompras_CellPainting;
                DgvCompras.CellPainting += DgvCompras_CellPainting;
            }
            else
            {
                // Mostramos un mensaje si no se encontraron compras
                MessageBox.Show("No se encontraron compras registradas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgvCompras.DataSource = null;
            }
        }

        /// <summary>
        /// Evento que se ejecuta al pintar cada celda del DataGridView.
        /// Permite simular un botón amarillo en la columna "ver_detalle" con efecto hover.
        /// Mantiene el texto centrado y la fuente Arial.
        /// </summary>
        private void DgvCompras_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Verificar fila válida y columna "ver_detalle"
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && DgvCompras.Columns[e.ColumnIndex].Name == "ver_detalle")
            {
                e.Handled = true;

                // Colores base y hover
                Color backColor = Color.Yellow;
                Color foreColor = Color.Black;

                // Si la celda está seleccionada, cambiar color a hover
                if (DgvCompras.CurrentCell != null &&
                    DgvCompras.CurrentCell.RowIndex == e.RowIndex &&
                    DgvCompras.CurrentCell.ColumnIndex == e.ColumnIndex)
                {
                    backColor = Color.Gold;
                }

                // Dibujar fondo
                using (SolidBrush brush = new SolidBrush(backColor))
                    e.Graphics.FillRectangle(brush, e.CellBounds);

                // Dibujar texto centrado
                TextRenderer.DrawText(
                    e.Graphics,
                    "Ver detalle",
                    new Font("Arial", 8.25F, FontStyle.Bold),
                    e.CellBounds,
                    foreColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );

                // Dibujar borde estilo plano
                e.Graphics.DrawRectangle(Pens.Black, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en una celda del DataGridView.
        /// Permite mostrar el detalle de la compra si se presiona el botón "ver_detalle".
        /// </summary>
        private void DgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la fila sea válida y que la columna sea "ver_detalle"
            if (e.RowIndex >= 0 && DgvCompras.Columns[e.ColumnIndex].Name == "ver_detalle")
            {
                int idCompra = Convert.ToInt32(DgvCompras.Rows[e.RowIndex].Cells["id_compra"].Value);
                MostrarDetalleCompra(idCompra);
            }
        }

        /// <summary>
        /// Método que muestra los productos de la compra seleccionada.
        /// Incluye el nombre, tipo, cantidad, precio unitario y subtotal de cada producto.
        /// </summary>
        /// <param name="idCompra">ID de la compra seleccionada.</param>
        private void MostrarDetalleCompra(int idCompra)
        {
            // Obtener detalle de la compra usando DetalleCompraCRUD
            DataTable dtDetalle = detalleCRUD.ObtenerPorCompra(idCompra);

            // Verificar si hay productos en el detalle
            if (dtDetalle.Rows.Count > 0)
            {
                // Construir mensaje para mostrar en MessageBox
                string mensaje = "";
                foreach (DataRow row in dtDetalle.Rows)
                {
                    string producto = row["Producto"].ToString();
                    string tipo = row["Tipo"].ToString();
                    int cantidad = Convert.ToInt32(row["Cantidad"]);
                    decimal precioUnitario = Convert.ToDecimal(row["Precio_Unitario"]);
                    decimal subtotal = Convert.ToDecimal(row["Subtotal"]);

                    mensaje += $"- {producto} ({tipo}) x {cantidad} unidades: ${precioUnitario} c/u, Subtotal: ${subtotal}\n";
                }

                // Mostrar detalle en MessageBox
                MessageBox.Show(mensaje, "Detalle de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Mensaje si no se encontraron productos
                MessageBox.Show("No se encontraron productos para esta compra.", "Detalle vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
