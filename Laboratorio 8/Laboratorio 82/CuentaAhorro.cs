using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_82
{
    public class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(string pntIdCuenta) : base(pntIdCuenta)
        {
        }

        public override void CalcularIntereses()
        {
            System.Console.WriteLine(
                "CuentaAhorro.CalcularIntereses() efectuado para " +
                "la cuenta {0}", getIdCuenta());
        }
    }
}
