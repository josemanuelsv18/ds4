using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_88
{
    class ClassConcreta1 : ClassAbstracta
    {
        protected override string tomarValor()
        {
            return "ClassConcreta1";
        }
        public override string prefixValor(string prefix)
        {
            return $"{prefix}ClassConcreta1";
        }
    }

}
