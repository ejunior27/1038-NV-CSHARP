using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7.Polimorfismo
{
    internal class Pagamento
    {
        public double Valor { get; set; }
        public string Descricao { get; set; }
        
        public virtual void pagar() 
        {
            Console.WriteLine("Iniciando processo de pagamento...");
        }

        public override string? ToString()
        {
            return $"Valor da conta {Descricao} = {Valor}";
        }
    }
}
