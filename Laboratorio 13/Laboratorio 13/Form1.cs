using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laboratorio_13
{
    public partial class Form1 : Form
    {
        private SqlConnection conexion;

        public Form1()
        {
            InitializeComponent();

            string connectionString =
                @"Server=DESKTOP-HAE2KFA\SQLEXPRESS;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";

            conexion = new SqlConnection(connectionString);
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                    MessageBox.Show("Se abrió la conexión.");
                    CargarProductos();
                }
                else if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    MessageBox.Show("Se cerró la conexión.");

                    listBox1.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la operación de conexión: {ex.Message}");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CargarProductos()
        {
            string consultaSQL = "SELECT ProductName FROM [dbo].[Products]";

            using (SqlConnection cargaConexion = new SqlConnection(conexion.ConnectionString))
            using (SqlCommand comando = new SqlCommand(consultaSQL, cargaConexion))
            {
                try
                {
                    cargaConexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        listBox1.Items.Clear();
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader["ProductName"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar productos: {ex.Message}");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}