using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6.Heranca.ContasDerivadas
{
    public class ContaPessoaFisica : Conta
    {
        public string Cpf { get; set; }
        public double ChequeEspecial { get; set; }

        public ContaPessoaFisica(string cpf) : base()
        {
            Cpf = cpf;
            ChequeEspecial = 1000;
        }

        public double validarChequeEspecial(double valor)
        {
            if (valor <= ChequeEspecial)
            {
                Saldo += valor;
                return Saldo;
            }

            Console.WriteLine($"Valor acima do limite de {ChequeEspecial}");

            return Saldo;
        }
    }
}
