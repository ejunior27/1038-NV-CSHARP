using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6.Heranca2
{
    internal class Figura
    {
        protected string cor;

        public void setCor(string cor)
        {
            this.cor = cor;
        }

        public string getCor()
        {
            return cor;
        }
    }
}
