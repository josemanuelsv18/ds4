using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratorio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtVelocidad.Text) || string.IsNullOrWhiteSpace(txtTiempo.Text))
            {
                MessageBox.Show("Por favor, ingrese ambos valores: velocidad y tiempo.", "Datos incompletos",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que los valores sean numéricos
            double velocidad, tiempo;
            if (!double.TryParse(txtVelocidad.Text, out velocidad) || !double.TryParse(txtTiempo.Text, out tiempo))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Datos inválidos",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que los valores sean positivos
            if (velocidad < 0 || tiempo < 0)
            {
                MessageBox.Show("Por favor, ingrese valores positivos.", "Datos inválidos",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular la distancia: distancia = velocidad × tiempo
            double distancia = velocidad * tiempo;

            // Mostrar el resultado en el textBox de resultado
            txtRespuesta.Text = distancia.ToString("F2") + " unidades";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los textBox
            txtVelocidad.Text = "";
            txtTiempo.Text = "";
            txtRespuesta.Text = "";

            // Colocar el foco en el primer textBox
            txtVelocidad.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Salir de la aplicación
            Application.Exit();
        }
    }
}