using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6.Heranca2
{
    internal class Circulo : Figura
    {
        private double raio;

        public Circulo(double raio, string cor)
        {
            this.raio = raio;
            this.cor = cor;
        }

        public void setRaio(double raio)
        {
            this.raio = raio;
        }

        public double getRaio()
        {
            return raio;
        }

        public double area()
        {
            return default;
        }

        public double getDiametro()
        {
            return default;
        }
    }
}
