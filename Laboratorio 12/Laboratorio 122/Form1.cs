using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_122
{
    public partial class txtNota2 : Form
    {
        public txtNota2()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNota1.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(txtNota3.Text))
            {
                MessageBox.Show("Por favor, ingrese las 3 notas.", "Datos incompletos",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que los valores sean numéricos
            double nota1, nota2, nota3;
            if (!double.TryParse(txtNota1.Text, out nota1) ||
                !double.TryParse(textBox1.Text, out nota2) ||
                !double.TryParse(txtNota3.Text, out nota3))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Datos inválidos",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que las notas estén en el rango válido (0-100)
            if (nota1 < 0 || nota1 > 100 || nota2 < 0 || nota2 > 100 || nota3 < 0 || nota3 > 100)
            {
                MessageBox.Show("Las notas deben estar entre 0 y 100.", "Rango inválido",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular el promedio
            double promedio = (nota1 + nota2 + nota3) / 3;

            // Mostrar el resultado
            txtResultado.Text = promedio.ToString("F2");

            // Opcional: Mostrar mensaje según el promedio
            string mensaje = "";
            if (promedio >= 90)
                mensaje = "¡Excelente!";
            else if (promedio >= 80)
                mensaje = "Muy Bueno";
            else if (promedio >= 70)
                mensaje = "Bueno";
            else if (promedio >= 60)
                mensaje = "Aprobado";
            else
                mensaje = "Reprobado";

            MessageBox.Show($"Promedio calculado: {promedio:F2}\n{mensaje}", "Resultado",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los textBox
            txtNota1.Text = "";
            textBox1.Text = "";
            txtNota3.Text = "";
            txtResultado.Text = "";

            // Colocar el foco en el primer textBox
            txtNota1.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Salir de la aplicación
            Application.Exit();
        }

    }
}