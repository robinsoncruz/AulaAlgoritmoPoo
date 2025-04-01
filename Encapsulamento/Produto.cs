using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Produto
    {
        public string  Nome { get; set; }
        public double preco { get; set; }
        public double quantidade { private get; set; }
        public double quanttidadetotal { get; private set; }
        


    }
}
