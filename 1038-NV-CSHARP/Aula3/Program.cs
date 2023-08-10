namespace Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try-catch-finally
            int resultado = 0;

            try
            {
                int dividendo = 10;
                int divisor = 0;                               

                //int valor = Convert.ToInt32("a");

                //exceção de divisão por zero
                resultado = dividendo / divisor;

                Console.WriteLine($"Resultado: {resultado}");
            }
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Erro: Não é possível dividir por zero - {ex.StackTrace}");
            //}            
            catch(Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                //throw new Exception("Ocorreu um erro forçado");
                //throw ex;
                throw;
            }
            finally
            {
                //encerramento de possíveis conexões (banco de dados, arquivos..)
                Console.WriteLine("Programa encerrado.");
                Console.ReadKey();
            }            
        }
    }
}