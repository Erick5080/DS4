namespace LABORATORIO_12._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota2_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtNota3_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double nota1 = Convert.ToDouble(txtNota1.Text);
                double nota2 = Convert.ToDouble(txtNota2.Text);
                double nota3 = Convert.ToDouble(txtNota3.Text);
                double promedio = (nota1 + nota2 + nota3)/3;
                txtResultado.Text = promedio.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos válidos para las Notas.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResultado.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtResultado.Text = "";

            txtNota1.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}