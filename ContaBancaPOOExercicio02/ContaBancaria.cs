using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaPOOExercicio02
{
    internal class ContaBancaria
    {
        public string NumeroConta;
        public string Titular;
        public double Saldo=0;

        public void Depositar(double valor)
        {
            Saldo = Saldo+ valor;
        }

    }
}
