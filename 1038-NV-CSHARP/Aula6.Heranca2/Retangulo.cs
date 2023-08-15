using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6.Heranca2
{
    internal class Retangulo : Figura
    {
        private double lado1;
        private double lado2;

        public Retangulo(double lado1, double lado2, string cor)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.cor = cor;
        }

        public void setLado1(double lado1)
        {
            this.lado1 = lado1;
        }

        public void setLado2(double lado2)
        {
            this.lado2 = lado2;
        }

        public double getLado1()
        {
            return lado1;
        }

        public double getLado2()
        {
            return lado2;
        }

        public double area()
        {
            return lado1 * lado2;
        }

    }
}
