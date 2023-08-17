using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7.Polimorfismo
{
    internal class Harpia : Ave
    {
        public override void emitirSom()
        {
            Console.WriteLine("Aaaaaaaaiiiiiih");
        }

        public override void voar()
        {
            //...
        }
    }
}
