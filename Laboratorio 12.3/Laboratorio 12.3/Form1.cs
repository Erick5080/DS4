using System;
namespace Laboratorio_12._3


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtLadoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLadoB_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtLadoC_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtResultSemiP_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAreaTriangulo_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSemiPerimetro_Click(object sender, EventArgs e)
        {
            try
            {
                double LadoA = Convert.ToDouble(txtLadoA.Text);
                double LadoB = Convert.ToDouble(txtLadoB.Text);
                double LadoC = Convert.ToDouble(txtLadoC.Text);
                double semiPerimetro = (LadoA + LadoB + LadoC) / 2;
                txtResultSemiP.Text = semiPerimetro.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para la Semiperimetro.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResultSemiP.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                double LadoA = Convert.ToDouble(txtLadoA.Text);
                double LadoB = Convert.ToDouble(txtLadoB.Text);
                double LadoC = Convert.ToDouble(txtLadoC.Text);

                if (LadoA <= 0 || LadoB <= 0 || LadoC <= 0)
                {
                    MessageBox.Show("Los lados del triángulo deben ser valores positivos.", "Error de Lados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAreaTriangulo.Text = "";
                    return;
                }

                if (LadoA + LadoB <= LadoC || LadoA + LadoC <= LadoB || LadoB + LadoC <= LadoA)
                {
                    MessageBox.Show("Los lados ingresados no forman un triángulo.", "Error de Triángulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAreaTriangulo.Text = "";
                    return;
                }

                double semiPerimetro = (LadoA + LadoB + LadoC) / 2;
                double subFormula = semiPerimetro * (semiPerimetro - LadoA) * (semiPerimetro - LadoB) * (semiPerimetro - LadoC);

                if (subFormula < 0)
                {
                    subFormula = 0;
                }

                double Area = Math.Sqrt(subFormula);
                txtAreaTriangulo.Text = Area.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para el Área.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAreaTriangulo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLadoA.Text = "";
            txtLadoB.Text = "";
            txtLadoC.Text = "";
            txtResultSemiP.Text = "";
            txtAreaTriangulo.Text = "";
            txtLadoA.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
