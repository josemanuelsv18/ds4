using System;

namespace Laboratorio_9
{
    public class Triangulo
    {
        public double Lado1 { get; private set; }
        public double Lado2 { get; private set; }
        public double Lado3 { get; private set; }

        public Triangulo()
        {
            Lado1 = 0;
            Lado2 = 0;
            Lado3 = 0;
        }

        public Triangulo(double lado1, double lado2, double lado3)
        {
            EstablecerLados(lado1, lado2, lado3);
        }

        public void EstablecerLados(double lado1, double lado2, double lado3)
        {
            if (lado1 <= 0)
                throw new ArgumentException("El primer lado debe ser un número positivo.");
            if (lado2 <= 0)
                throw new ArgumentException("El segundo lado debe ser un número positivo.");
            if (lado3 <= 0)
                throw new ArgumentException("El tercer lado debe ser un número positivo.");

            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public bool EsTrianguloValido()
        {
            // Un triángulo es válido si la suma de dos lados es mayor al tercer lado
            return (Lado1 + Lado2 > Lado3) && 
                   (Lado1 + Lado3 > Lado2) && 
                   (Lado2 + Lado3 > Lado1);
        }

        public double CalcularArea()
        {
            if (!EsTrianguloValido())
            {
                throw new InvalidOperationException("No se puede calcular el área de un triángulo inválido.");
            }

            // Usar la fórmula de Herón
            double semiperimetro = (Lado1 + Lado2 + Lado3) / 2;
            double area = Math.Sqrt(semiperimetro * (semiperimetro - Lado1) * 
                                   (semiperimetro - Lado2) * (semiperimetro - Lado3));
            return area;
        }

        public double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }

        public string ObtenerTipoTriangulo()
        {
            if (!EsTrianguloValido())
                return "Inválido";

            if (Lado1 == Lado2 && Lado2 == Lado3)
                return "Equilátero";
            else if (Lado1 == Lado2 || Lado2 == Lado3 || Lado1 == Lado3)
                return "Isósceles";
            else
                return "Escaleno";
        }

        public string ObtenerResumen()
        {
            string resumen = $"Lado 1: {Lado1}\nLado 2: {Lado2}\nLado 3: {Lado3}\n";
            
            if (EsTrianguloValido())
            {
                resumen += "Estado: Válido\n";
                resumen += $"Tipo: {ObtenerTipoTriangulo()}\n";
                resumen += $"Perímetro: {CalcularPerimetro():F2}\n";
                resumen += $"Área: {CalcularArea():F2} unidades cuadradas";
            }
            else
            {
                resumen += "Estado: Inválido\n";
                resumen += "Razón: La suma de dos lados debe ser mayor al tercer lado";
            }
            
            return resumen;
        }
    }
}