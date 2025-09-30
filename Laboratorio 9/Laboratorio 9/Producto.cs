using System;

namespace Laboratorio_9
{
    public class Producto
    {        
        public double Precio { get; private set; }
        public string FormaPago { get; private set; }
        public string NumeroCuenta { get; private set; }

        public Producto()
        {
            Precio = 0;
            FormaPago = "";
            NumeroCuenta = "";
        }

        public void EstablecerPrecio(double precio)
        {
            if (precio <= 0)
            {
                throw new ArgumentException("El precio debe ser un número positivo.");
            }
            Precio = precio;
        }

        public void EstablecerFormaPago(string formaPago)
        {
            if (string.IsNullOrEmpty(formaPago))
            {
                throw new ArgumentException("La forma de pago no puede estar vacía.");
            }
            
            string formaPagoLower = formaPago.ToLower().Trim();
            if (formaPagoLower != "efectivo" && formaPagoLower != "tarjeta")
            {
                throw new ArgumentException("La forma de pago debe ser 'efectivo' o 'tarjeta'.");
            }
            
            FormaPago = formaPagoLower;
        }

        public void EstablecerNumeroCuenta(string numeroCuenta)
        {
            if (FormaPago != "tarjeta")
            {
                throw new InvalidOperationException("Solo se puede establecer número de cuenta para pagos con tarjeta.");
            }
            
            if (string.IsNullOrEmpty(numeroCuenta))
            {
                throw new ArgumentException("El número de cuenta no puede estar vacío para pagos con tarjeta.");
            }
            
            string numeroCuentaTrim = numeroCuenta.Trim();
            if (numeroCuentaTrim.Length > 16 || !EsNumerico(numeroCuentaTrim))
            {
                throw new ArgumentException("El número de cuenta debe tener máximo 16 dígitos numéricos.");
            }
            
            NumeroCuenta = numeroCuentaTrim;
        }

        private bool EsNumerico(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public bool RequiereNumeroCuenta()
        {
            return FormaPago == "tarjeta";
        }

        public bool EsValido()
        {
            return Precio > 0 && 
                   !string.IsNullOrEmpty(FormaPago) && 
                   (FormaPago == "efectivo" || (FormaPago == "tarjeta" && !string.IsNullOrEmpty(NumeroCuenta)));
        }

        public string ObtenerResumen()
        {
            string resumen = $"Precio: ${Precio:F2}\nForma de pago: {FormaPago}";
            if (FormaPago == "tarjeta")
            {
                resumen += $"\nNúmero de cuenta: {NumeroCuenta}";
            }
            return resumen;
        }
    }
}