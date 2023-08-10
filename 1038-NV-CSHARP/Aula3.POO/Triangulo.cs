using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3.POO
{
    internal class Triangulo
    {
        public double ladoA;
        public double ladoB;
        public double ladoC;
        public double area;

        public double CalcularArea()
        {
            double p = (ladoA + ladoB + ladoC) / 2;
            return Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
        }
    }
}
