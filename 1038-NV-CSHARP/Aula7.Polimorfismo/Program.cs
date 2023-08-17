namespace Aula7.Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Polimorfismo
            // -Várias formas

            //Complexidade Ciclomática
            //Quanto mais IFs/Switchs no seu código, mais complexidade ciclomática ele terá

            //Pagamento pagamento = new CartaoDeCredito
            //{
            //    Valor = 100,
            //    Descricao = "internet"                
            //};

            //pagamento.pagar();

            //Console.WriteLine(pagamento.ToString());


            ////..

            //pagamento = new Pix
            //{
            //    Valor = 50,
            //    Descricao = "agua"
            //};

            //pagamento.pagar();

            //Console.WriteLine(pagamento.ToString());

            Animal a1 = new Rinoceronte
            {
                Cor = "Branco",
                Genero = "Fêmea",
                Raca = "Rinoceronte Branco",
                Medidas = new Medidas
                {
                    Peso = 3600,
                    Altura = 5
                }
            };

            a1.emitirSom();

            Console.WriteLine();

            Console.WriteLine(a1.ToString());

            Animal a2 = new Harpia
            {
                Cor = "Branco e Marron",
                Genero = "Macho",
                Raca = "Brasileira"
            };

            a2.emitirSom();
            Console.WriteLine();

            Animal a3 = new Camelo
            {
                Cor = "Bege",
                Genero = "Fêmea",
                Raca = "kharai dromadaire"
            };

            a3.emitirSom();

            Console.WriteLine();

            Console.WriteLine(a3.ToString());            
        }
    }
}