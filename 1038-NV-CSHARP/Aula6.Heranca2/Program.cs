namespace Aula6.Heranca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo1 = new Retangulo(5, 3, "azul");
            Retangulo retangulo2 = new Retangulo(8, 9, "vermelho");

            Console.WriteLine($"Retangulo1: lado1={retangulo1.getLado1()} " +
                $"lado2={retangulo1.getLado2()} cor={retangulo1.getCor()}");

            Console.WriteLine($"Retangulo2: lado1={retangulo2.getLado1()} " +
                $"lado2={retangulo2.getLado2()} cor={retangulo2.getCor()}");

            Quadrado quadrado1 = new(10, "amarelo");

            Console.WriteLine($"Quadrado1: lado={quadrado1.getLado2()} " +
                $" cor={quadrado1.getCor()}");
        }
    }
}