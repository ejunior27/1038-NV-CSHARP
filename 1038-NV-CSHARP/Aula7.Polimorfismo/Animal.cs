using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7.Polimorfismo
{
    internal class Animal
    {
        //propriedade
        public string Raca { get; set; }
        public string Cor { get; set; }        
        public string Genero { get; set; }
        public virtual Medidas Medidas { get; set; } = new Medidas();


        public virtual void emitirSom()
        {
            Console.WriteLine("...");
        }

        public override string? ToString()
        {
            return $"Raça: {Raca} - Cor: {Cor} - Peso: {Medidas.Peso} - Gênero: {Genero}";
        }
    }
}
