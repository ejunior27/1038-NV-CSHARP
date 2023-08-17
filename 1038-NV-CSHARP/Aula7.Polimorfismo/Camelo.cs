using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7.Polimorfismo
{
    internal class Camelo : Animal
    {
        public override void emitirSom()
        {            
            Console.WriteLine("brããã");
            base.emitirSom();
        }
    }
}
