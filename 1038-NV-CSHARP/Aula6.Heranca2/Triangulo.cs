using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6.Heranca2
{
    internal class Triangulo : Figura
    {
        private double Base;
        private double altura;

        public Triangulo(double Base, double altura, string cor)
        {
            this.Base = Base;
            this.altura = altura;
            this.cor = cor;
        }

        public void setBase(double Base)
        {
            this.Base = Base;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public double getBase()
        {
            return Base;
        }

        public double getAltura()
        {
            return altura;
        }

        public double area()
        {
            return default;
        }
    }
}
