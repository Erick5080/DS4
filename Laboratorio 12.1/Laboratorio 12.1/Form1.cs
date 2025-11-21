namespace Laboratorio_12._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double velocidad = Convert.ToDouble(txtVelocidad.Text);
                double tiempo = Convert.ToDouble(txtTiempo.Text);
                double distancia = velocidad * tiempo;
                txtResultado.Text = distancia.ToString("F2"); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para la Velocidad y el Tiempo.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResultado.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtVelocidad.Text = "";
            txtTiempo.Text = ""; 
            txtResultado.Text = "";

            txtVelocidad.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}