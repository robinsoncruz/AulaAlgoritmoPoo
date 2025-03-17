using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooCalculo
{
    public class Calculo
    {
        public double ValorA;
        public double ValorB;
        private  double Soma;
        public void CalcularSoma()
        {       
            Soma = ValorB + ValorA;
            Console.Write(Soma);
            Console.ReadLine();
        }

        public void CalcularDivisao()
        {
            Soma = ValorB / ValorA;
            Console.Write(Soma);
            Console.ReadLine();
        }


    }
}

