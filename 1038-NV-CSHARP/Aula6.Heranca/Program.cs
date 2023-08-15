using Aula6.Heranca.ContasDerivadas;

namespace Aula6.Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Herança

            /*
             -Relação "é-um/uma"
             -Superclasse (classe base)
             -Subclasse (classe derivada/filha)
             -Extensão
             -É uma associação entre classes (e não objetos)
             */

            //instanciando
            //Conta conta1 = new Conta();

            //Conta conta1 = new ContaPessoaJuridica();
            ContaPessoaJuridica conta1 = new ContaPessoaJuridica();
            ContaPessoaFisica conta2 = new ContaPessoaFisica("111111");



            conta1.Titular = "Marianna";            

            //conta2.Numero = 1;
            //conta2.Agencia = 101;
            //conta2.Titular = "Liliane";
            //conta2.Saldo = 0;
            //conta2.ChequeEspecial = 1000;
        }
    }

    
    
    

    
}