using SistemaVeterinariaPatitasYPelos.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SistemaVeterinariaPatitasYPelos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Crear objeto de conexión
            Conexion db = new Conexion();

            // Intentar abrir la conexión
            if (db.AbrirConexion())
            {
                try
                {
                    // Contar la cantidad de clientes
                    string query = "SELECT COUNT(*) FROM Clientes";
                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    int totalClientes = Convert.ToInt32(cmd.ExecuteScalar());

                    // Mostrar mensaje con la cantidad
                    MessageBox.Show($"✅ Conexión exitosa.\nClientes registrados: {totalClientes}",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar la base de datos: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Cerrar la conexión
                    db.CerrarConexion();
                }
            }
            else
            {
                MessageBox.Show("❌ No se pudo conectar a la base de datos.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
