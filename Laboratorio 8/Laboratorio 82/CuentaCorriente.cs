using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_82
{
    public class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(string pntIdCuenta) : base(pntIdCuenta)
        {
        }

        public override void CalcularIntereses()
        {
            System.Console.WriteLine(
                "CuentaCorriente.CalcularIntereses() efectuado para " +
                "la cuenta {0}", getIdCuenta());
        }
    }
}
