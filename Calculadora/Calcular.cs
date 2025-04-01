using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calcular
    {
        public double Resultado;
        public double CalcularSoma(double A, double B=0)
        {
            Resultado = A + B;
            return Resultado;
        }
        public void ImprimirResultado()
        {
            Console.WriteLine(Resultado);
            Console.ReadLine();
        }

            



    }
}
