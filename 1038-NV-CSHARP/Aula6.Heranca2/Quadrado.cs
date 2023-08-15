using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6.Heranca2
{
    internal class Quadrado : Retangulo
    {
        public Quadrado(double lado, string cor) : base(lado, lado, cor)
        {

        }
    }
}
