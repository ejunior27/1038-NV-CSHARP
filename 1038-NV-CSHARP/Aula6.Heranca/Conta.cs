using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6.Heranca
{
    public class Conta
    {
        private long Numero { get; set; }
        public string Titular { get; set; }
        private int Agencia { get; set; }
        protected double Saldo { get; set; }

        //public Conta()
        //{           
        //    Saldo = 0;
        //    Numero = 1;
        //    Agencia = 101;
        //}       

        public string extrato(int intervalo)
        {
            return default;
        }

        public double verSaldo()
        {
            return Saldo;
        }

        public double sacar(double valor)
        {
            Saldo -= valor;

            return Saldo;
        }

        public double depositar(double valor)
        {
            Saldo += valor;

            return Saldo;
        }
    }
}
