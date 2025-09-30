using System;

namespace Laboratorio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("    LABORATORIO 9 - PROGRAMACIÓN ORIENTADA A OBJETOS");
            Console.WriteLine("==================================================");
            
            bool continuar = true;
            
            while (continuar)
            {
                try
                {
                    MostrarMenu();
                    int opcion = LeerOpcion();
                    
                    switch (opcion)
                    {
                        case 1:
                            EjecutarProducto();
                            break;
                        case 2:
                            EjecutarTriangulo();
                            break;
                        case 3:
                            EjecutarNumerosAleatorios();
                            break;
                        case 4:
                            EjecutarArreglosAleatorios();
                            break;
                        case 5:
                            Console.WriteLine("\n¡Gracias por usar el programa!");
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("\nOpción no válida. Intente nuevamente.");
                            break;
                    }
                    
                    if (continuar)
                    {
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nError inesperado: {ex.Message}");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        
        static void MostrarMenu()
        {
            Console.WriteLine("\nMENÚ PRINCIPAL");
            Console.WriteLine("1. Producto (Precio y forma de pago)");
            Console.WriteLine("2. Triángulo (Validación y área)");
            Console.WriteLine("3. Números aleatorios (Pares/divisibles entre 3)");
            Console.WriteLine("4. Arreglos aleatorios (No repetidos)");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción (1-5): ");
        }
        
        static int LeerOpcion()
        {
            try
            {
                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int opcion))
                {
                    throw new FormatException("Debe ingresar un número válido.");
                }
                return opcion;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer la opción: {ex.Message}");
                return -1; // Opción inválida
            }
        }
        
        static void EjecutarProducto()
        {
            try
            {
                Console.WriteLine("\n================= MÓDULO PRODUCTO =================");
                Producto producto = new Producto();
                
                bool datosValidos = false;
                while (!datosValidos)
                {
                    try
                    {
                        // Pedir precio
                        Console.Write("Ingrese el precio del producto (valor positivo): $");
                        string? precioInput = Console.ReadLine();
                        if (string.IsNullOrEmpty(precioInput) || !double.TryParse(precioInput, out double precio))
                        {
                            throw new ArgumentException("Debe ingresar un número válido.");
                        }
                        producto.EstablecerPrecio(precio);
                        
                        // Pedir forma de pago
                        Console.Write("Ingrese la forma de pago (efectivo/tarjeta): ");
                        string? formaPagoInput = Console.ReadLine();
                        if (string.IsNullOrEmpty(formaPagoInput))
                        {
                            throw new ArgumentException("Debe ingresar una forma de pago.");
                        }
                        producto.EstablecerFormaPago(formaPagoInput);
                        
                        // Pedir número de cuenta si es necesario
                        if (producto.RequiereNumeroCuenta())
                        {
                            Console.Write("Ingrese el número de cuenta (máximo 16 dígitos): ");
                            string? numeroCuentaInput = Console.ReadLine();
                            if (string.IsNullOrEmpty(numeroCuentaInput))
                            {
                                throw new ArgumentException("Debe ingresar un número de cuenta.");
                            }
                            producto.EstablecerNumeroCuenta(numeroCuentaInput);
                        }
                        
                        datosValidos = producto.EsValido();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        Console.WriteLine("\n¿Desea intentar nuevamente? (s/n): ");
                        string? respuestaInput = Console.ReadLine();
                        string respuesta = respuestaInput?.ToLower().Trim() ?? "n";
                        if (respuesta != "s" && respuesta != "si")
                        {
                            Console.WriteLine("Regresando al menú principal...");
                            return;
                        }
                    }
                }
                
                // Mostrar información del producto
                Console.WriteLine("\n=== INFORMACIÓN DEL PRODUCTO ===");
                Console.WriteLine(producto.ObtenerResumen());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en el módulo Producto: {ex.Message}");
            }
        }
        
        static void EjecutarTriangulo()
        {
            try
            {
                Console.WriteLine("\n================= MÓDULO TRIÁNGULO =================");
                Triangulo triangulo = new Triangulo();
                
                bool datosValidos = false;
                while (!datosValidos)
                {
                    try
                    {
                        Console.Write("Ingrese el primer lado del triángulo: ");
                        string? lado1Input = Console.ReadLine();
                        if (string.IsNullOrEmpty(lado1Input) || !double.TryParse(lado1Input, out double lado1))
                        {
                            throw new ArgumentException("Debe ingresar un número válido para el primer lado.");
                        }
                        
                        Console.Write("Ingrese el segundo lado del triángulo: ");
                        string? lado2Input = Console.ReadLine();
                        if (string.IsNullOrEmpty(lado2Input) || !double.TryParse(lado2Input, out double lado2))
                        {
                            throw new ArgumentException("Debe ingresar un número válido para el segundo lado.");
                        }
                        
                        Console.Write("Ingrese el tercer lado del triángulo: ");
                        string? lado3Input = Console.ReadLine();
                        if (string.IsNullOrEmpty(lado3Input) || !double.TryParse(lado3Input, out double lado3))
                        {
                            throw new ArgumentException("Debe ingresar un número válido para el tercer lado.");
                        }
                        
                        triangulo.EstablecerLados(lado1, lado2, lado3);
                        datosValidos = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        Console.WriteLine("\n¿Desea intentar nuevamente? (s/n): ");
                        string? respuestaInput = Console.ReadLine();
                        string respuesta = respuestaInput?.ToLower().Trim() ?? "n";
                        if (respuesta != "s" && respuesta != "si")
                        {
                            Console.WriteLine("Regresando al menú principal...");
                            return;
                        }
                    }
                }
                
                // Mostrar resultados del triángulo
                Console.WriteLine("\n=== INFORMACIÓN DEL TRIÁNGULO ===");
                Console.WriteLine(triangulo.ObtenerResumen());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en el módulo Triángulo: {ex.Message}");
            }
        }
        
        static void EjecutarNumerosAleatorios()
        {
            try
            {
                Console.WriteLine("\n================= MÓDULO NÚMEROS ALEATORIOS =================");
                Console.WriteLine("Generando números hasta encontrar uno par o divisible entre 3...");
                
                Aleatorios aleatorios = new Aleatorios();
                var resultado = aleatorios.BuscarNumeroParODivisibleEntre3();
                
                Console.WriteLine("\nNúmeros generados:");
                for (int i = 0; i < resultado.NumerosGenerados.Count; i++)
                {
                    Console.WriteLine($"Intento {i + 1}: {resultado.NumerosGenerados[i]}");
                }
                
                Console.WriteLine($"\n¡Encontrado! El número {resultado.NumeroEncontrado} es ");
                if (resultado.EsPar)
                    Console.Write("par");
                if (resultado.EsDivisibleEntre3)
                {
                    if (resultado.EsPar)
                        Console.Write(" y ");
                    Console.Write("divisible entre 3");
                }
                Console.WriteLine($" (encontrado en {resultado.Intentos} intentos)");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en el módulo Números Aleatorios: {ex.Message}");
            }
        }
        
        static void EjecutarArreglosAleatorios()
        {
            try
            {
                Console.WriteLine("\n================= MÓDULO ARREGLOS ALEATORIOS =================");
                
                Console.Write("Ingrese el tamaño del primer arreglo: ");
                string? tamano1Input = Console.ReadLine();
                if (string.IsNullOrEmpty(tamano1Input) || !int.TryParse(tamano1Input, out int tamano1) || tamano1 <= 0)
                {
                    throw new ArgumentException("El tamaño debe ser un número positivo.");
                }
                
                Console.Write("Ingrese el tamaño del segundo arreglo: ");
                string? tamano2Input = Console.ReadLine();
                if (string.IsNullOrEmpty(tamano2Input) || !int.TryParse(tamano2Input, out int tamano2) || tamano2 <= 0)
                {
                    throw new ArgumentException("El tamaño debe ser un número positivo.");
                }

                Console.Write("Ingrese el valor mínimo para los números: ");
                string? minInput = Console.ReadLine();
                if (string.IsNullOrEmpty(minInput) || !int.TryParse(minInput, out int min))
                {
                    throw new ArgumentException("Debe ingresar un número válido.");
                }
                
                Console.Write("Ingrese el valor máximo para los números: ");
                string? maxInput = Console.ReadLine();
                if (string.IsNullOrEmpty(maxInput) || !int.TryParse(maxInput, out int max))
                {
                    throw new ArgumentException("Debe ingresar un número válido.");
                }

                Aleatorios aleatorios = new Aleatorios();
                var resultado = aleatorios.GenerarArreglosNoRepetidos(tamano1, tamano2, min, max);
                
                Console.WriteLine($"\nPrimer arreglo (tamaño {tamano1}):");
                Console.WriteLine(Aleatorios.ArregloAString(resultado.PrimerArreglo));
                
                Console.WriteLine($"\nSegundo arreglo (tamaño {tamano2}):");
                Console.WriteLine(Aleatorios.ArregloAString(resultado.SegundoArreglo));
                
                if (resultado.IntentosParaGenerar >= 100)
                {
                    Console.WriteLine("\nAdvertencia: Se alcanzó el límite de intentos. Los arreglos podrían ser similares.");
                }
                else
                {
                    Console.WriteLine($"\nArreglos generados correctamente (intentos: {resultado.IntentosParaGenerar})");
                    Console.WriteLine($"Los arreglos son diferentes: {(resultado.SonDiferentes ? "Sí" : "No")}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en el módulo Arreglos Aleatorios: {ex.Message}");
            }
        }
    }
}
