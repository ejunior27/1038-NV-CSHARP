using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7.Polimorfismo
{
    internal class Rinoceronte : Animal
    {
        public override Medidas Medidas { get; set; }

        public override void emitirSom()
        {            
            Console.WriteLine("groooooon");
        }
    }
}
