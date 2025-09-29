using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_72
{
    class JuegoDeDados
    {
        private Dado dado1, dado2, dado3;

        public JuegoDeDados()
        {
            dado1 = new Dado();
            dado2 = new Dado();
            dado3 = new Dado();
        }

        public void Jugar()
        {
            dado1.Tirar();
            dado1.imprimir();
            dado2.Tirar();
            dado2.imprimir();
            dado3.Tirar();
            dado3.imprimir();
            if(dado1.retornarValor() == dado2.retornarValor() && dado1.retornarValor() == dado3.retornarValor())
            {
                Console.WriteLine("Ganó");
            }
            else
            {
                Console.WriteLine("Perdió");
            }
            Console.ReadKey();
        }
    }
}
