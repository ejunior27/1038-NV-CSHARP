using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7.Polimorfismo
{
    internal class CartaoDeCredito : Pagamento
    {
        public override void pagar()
        {
            base.pagar();
            Console.WriteLine($"Conta {Descricao} paga com cartão de crédito");
        }        
    }
}
