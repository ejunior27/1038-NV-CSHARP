namespace Aula3.POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa para ler as medidas dos lados de dois triângulos X e Y 
            (suponha medidas válidas). Em seguida, mostrar o valor das áreas dos dois 
            triângulos e dizer qual dos dois triângulos possui a maior área. 
            A fórmula para calcular a área de um triângulo a partir das medidas 
            de seus lados a, b e c é a seguinte (fórmula de Heron) 

            p = (a + b + c) / 2
             */

            Triangulo trianguloX = new();
            Triangulo trianguloY = new();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            trianguloX.ladoA = double.Parse(Console.ReadLine());
            trianguloX.ladoB = double.Parse(Console.ReadLine());
            trianguloX.ladoC = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            trianguloY.ladoA = double.Parse(Console.ReadLine());
            trianguloY.ladoB = double.Parse(Console.ReadLine());
            trianguloY.ladoC = double.Parse(Console.ReadLine());

            trianguloX.area = trianguloX.CalcularArea();
            trianguloY.area = trianguloY.CalcularArea();

            Console.WriteLine($"Área de X = {trianguloX.area}");
            Console.WriteLine($"Área de Y = {trianguloY.area}");

            if(trianguloX.area > trianguloY.area)
            {
                Console.WriteLine("Área de X é maior");
            }
            else
            {
                Console.WriteLine("Área de Y é maior");
            }
        }
    }    
}