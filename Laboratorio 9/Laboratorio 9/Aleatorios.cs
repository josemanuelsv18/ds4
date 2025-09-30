using System;
using System.Collections.Generic;

namespace Laboratorio_9
{
    public class Aleatorios
    {
        private Random random;

        public Aleatorios()
        {
            random = new Random();
        }

        public int GenerarNumeroAleatorio(int min = 1, int max = 100)
        {
            if (min >= max)
                throw new ArgumentException("El valor mínimo debe ser menor al máximo.");
            
            return random.Next(min, max + 1);
        }

        public int[] GenerarArregloAleatorio(int tamaño, int min, int max)
        {
            if (tamaño <= 0)
                throw new ArgumentException("El tamaño del arreglo debe ser positivo.");
            
            if (min >= max)
                throw new ArgumentException("El valor mínimo debe ser menor al máximo.");

            int[] arreglo = new int[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                arreglo[i] = random.Next(min, max + 1);
            }
            return arreglo;
        }

        public class ResultadoBusquedaNumero
        {
            public int NumeroEncontrado { get; set; }
            public int Intentos { get; set; }
            public List<int> NumerosGenerados { get; set; }
            public bool EsPar { get; set; }
            public bool EsDivisibleEntre3 { get; set; }

            public ResultadoBusquedaNumero()
            {
                NumerosGenerados = new List<int>();
            }
        }

        public ResultadoBusquedaNumero BuscarNumeroParODivisibleEntre3()
        {
            var resultado = new ResultadoBusquedaNumero();
            int numero;
            
            do
            {
                numero = GenerarNumeroAleatorio();
                resultado.NumerosGenerados.Add(numero);
                resultado.Intentos++;
            } 
            while (numero % 2 != 0 && numero % 3 != 0);
            
            resultado.NumeroEncontrado = numero;
            resultado.EsPar = numero % 2 == 0;
            resultado.EsDivisibleEntre3 = numero % 3 == 0;
            
            return resultado;
        }

        public class ResultadoArreglosNoRepetidos
        {
            public int[] PrimerArreglo { get; set; }
            public int[] SegundoArreglo { get; set; }
            public int IntentosParaGenerar { get; set; }
            public bool SonDiferentes { get; set; }

            public ResultadoArreglosNoRepetidos()
            {
                PrimerArreglo = new int[0];
                SegundoArreglo = new int[0];
            }
        }

        public ResultadoArreglosNoRepetidos GenerarArreglosNoRepetidos(int tamaño1, int tamaño2, int min, int max)
        {
            var resultado = new ResultadoArreglosNoRepetidos();
            
            resultado.PrimerArreglo = GenerarArregloAleatorio(tamaño1, min, max);
            
            // Asegurar que los arreglos sean diferentes
            do
            {
                resultado.SegundoArreglo = GenerarArregloAleatorio(tamaño2, min, max);
                resultado.IntentosParaGenerar++;
            } 
            while (SonArreglosIguales(resultado.PrimerArreglo, resultado.SegundoArreglo) && resultado.IntentosParaGenerar < 100);
            
            resultado.SonDiferentes = !SonArreglosIguales(resultado.PrimerArreglo, resultado.SegundoArreglo);
            
            return resultado;
        }

        private bool SonArreglosIguales(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;
                
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }
            return true;
        }

        public static string ArregloAString(int[] arreglo)
        {
            if (arreglo == null || arreglo.Length == 0)
                return "[]";

            string resultado = "[";
            for (int i = 0; i < arreglo.Length; i++)
            {
                resultado += arreglo[i];
                if (i < arreglo.Length - 1)
                    resultado += ", ";
            }
            resultado += "]";
            return resultado;
        }
    }
}