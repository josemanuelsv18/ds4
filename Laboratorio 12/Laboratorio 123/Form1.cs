using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSemiperimetro_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtLadoA.Text) ||
                string.IsNullOrWhiteSpace(txtLadoB.Text) ||
                string.IsNullOrWhiteSpace(txtLadoC.Text))
            {
                MessageBox.Show("Por favor, ingrese los 3 lados del triángulo.", "Datos incompletos",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que los valores sean numéricos y positivos
            double ladoA, ladoB, ladoC;
            if (!double.TryParse(txtLadoA.Text, out ladoA) ||
                !double.TryParse(txtLadoB.Text, out ladoB) ||
                !double.TryParse(txtLadoC.Text, out ladoC))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Datos inválidos",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que los lados sean positivos
            if (ladoA <= 0 || ladoB <= 0 || ladoC <= 0)
            {
                MessageBox.Show("Los lados deben ser valores positivos.", "Datos inválidos",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que sea un triángulo válido (desigualdad triangular)
            if (!EsTrianguloValido(ladoA, ladoB, ladoC))
            {
                MessageBox.Show("Los lados ingresados no forman un triángulo válido.\n" +
                              "La suma de dos lados debe ser mayor que el tercer lado.",
                              "Triángulo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular el semiperímetro: s = (a + b + c) / 2
            double semiperimetro = (ladoA + ladoB + ladoC) / 2;
            txtSemiperimetro.Text = semiperimetro.ToString("F2");
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtLadoA.Text) ||
                string.IsNullOrWhiteSpace(txtLadoB.Text) ||
                string.IsNullOrWhiteSpace(txtLadoC.Text))
            {
                MessageBox.Show("Por favor, ingrese los 3 lados del triángulo.", "Datos incompletos",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que los valores sean numéricos y positivos
            double ladoA, ladoB, ladoC;
            if (!double.TryParse(txtLadoA.Text, out ladoA) ||
                !double.TryParse(txtLadoB.Text, out ladoB) ||
                !double.TryParse(txtLadoC.Text, out ladoC))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Datos inválidos",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que los lados sean positivos
            if (ladoA <= 0 || ladoB <= 0 || ladoC <= 0)
            {
                MessageBox.Show("Los lados deben ser valores positivos.", "Datos inválidos",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que sea un triángulo válido
            if (!EsTrianguloValido(ladoA, ladoB, ladoC))
            {
                MessageBox.Show("Los lados ingresados no forman un triángulo válido.\n" +
                              "La suma de dos lados debe ser mayor que el tercer lado.",
                              "Triángulo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular el semiperímetro
            double s = (ladoA + ladoB + ladoC) / 2;

            // Calcular el área usando la fórmula de Herón: √[s(s-a)(s-b)(s-c)]
            double area = Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));
            txtArea.Text = area.ToString("F2");
        }

        // Método para validar si los lados forman un triángulo válido
        private bool EsTrianguloValido(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los textBox
            txtLadoA.Text = "";
            txtLadoB.Text = "";
            txtLadoC.Text = "";
            txtSemiperimetro.Text = "";
            txtArea.Text = "";

            // Colocar el foco en el primer textBox
            txtLadoA.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Salir de la aplicación
            Application.Exit();
        }
    }
}