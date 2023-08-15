using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6.Heranca.ContasDerivadas
{
    //extendendo a classe Conta para a classe ContaPessoaJuridica ":"
    public class ContaPessoaJuridica : Conta
    {
        private double LimiteEmprestimo { get; set; }

        public ContaPessoaJuridica() : base()
        {
            LimiteEmprestimo = 100000;
        }

        public double emprestar(double valor)
        {
            if (valor <= LimiteEmprestimo)
            {
                Saldo += valor;
                return Saldo;
            }

            Console.WriteLine($"Valor acima do limite de {LimiteEmprestimo}");

            return Saldo;
        }
    }
}
