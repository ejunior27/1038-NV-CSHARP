using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        //WriteLine("Hello, World!");
        //Write("Olá, Mundo ");
        //Write("Oi");

        //string algumaCoisa = ReadLine();

        //WriteLine(algumaCoisa);

        //var qualquerCoisa = 1;
        //string palavra;
        //string outraPalavra = "ola";

        //bool completa = false; //true
        //char genero = 'F';
        //char letra = '\u0041';
        //byte numeroPequeno = 12;
        //int numeroMedio = 1212121212;
        //long numeroGrande = 1212121212121212121;
        //float numeroEnorme = 1212121212121212112;
        //float numeroQuebrado = 1212.1212121F;
        //double numeroEnorme2 = 121211212121212121;
        //double numeroQuebrado2 = 12121.121212;

        //string texto = "asçkldjfskdjf skdjfksd çlsdjfopjs pçsodjf";

        //Object obj = "nome";
        //Object obj2 = 4.5f;

        //int[] numeros = new int[10];
        //numeros[3] = 9;

        //int[] numeros2 = new int[3] { 1, 2, 3 };

        //int[,] matriz = new int[3, 3];

        //matriz[1, 1] = 3;
        ////indices
        ////começam de 0

        //string[] nomes;
        //nomes = new string[1];
        //nomes[0] = "eduardo";

        //nomes de variáveis
        //Não podemos usar dígito na primeira letra do nome da variável
        //Não utilizar acentos ou til
        //Não utilizar espaços
        //Sugestão: use nomes que façam sentido

        //Camel Case: lastNameEskdkd (parametros, variaves dentro de metodos)
        //Pascal Case: LastName (namespaces, classes, propridades)
        //Padrão _lastName (atributos "internos" de classes)

        //var 1teste = 1;
        //var solida = true;
        //var minha casa = "";

        //var joas1 = "";
        //var joas2 = "";

        //var fazDeTudo = "";

        //int n2 = 3 + 4;
        //int n3 = 4 - 1;
        //int n4 = 4 / 2;
        //int n5 = 2 * 2;
        //int n6 = 17 % 3;

        //primeiro * e /
        //segundo + e -

        //double n7 = (3.2 + 4.2) * 2;

        //WriteLine(n7);

        //Atribuição
        // = , += , -= , *= , /= , %= ,

        //var numero = 5;

        //numero = numero + 1;
        //numero %= 1;

        //int a = 1;
        //a = a++; //incrementa
        //a = a--; //decrementa

        //string nome = "teste";

        //int i = 1;
        //int j = 2;

        //if (i == j)
        //{            
        //    WriteLine(nome);              
        //}

        //if (false)
        //{

        //}
        //else
        //{
        //    WriteLine("não é igual");
        //}

        //string nome = "ASDFJasdfakskAKS";

        //switch (nome.ToLower()) //==
        //{
        //    case "eduardo":
        //        {
        //            WriteLine("nome do prof");
        //            break;
        //        }            
        //    case "luciana":
        //        {
        //            WriteLine("nome da aluna");
        //            break;
        //        }
        //    default:
        //        {
        //            WriteLine("nome desconhecido");
        //            break;
        //        }
        //}

        //IF ERRADO
        //var a = 1;
        //var B = 2;
        //if (a == 1) 
        //{
        //    WriteLine("Variável A é igual a 1");
        //}
        //else if (a == 2)
        //{
        //    WriteLine("Variável A é igual a 1");
        //}
        //else
        //{
        //    WriteLine("Variável A é igual a 1");
        //}

        ////SWITCH ERRADO
        //switch ("batata frita")
        //{
        //    case (a > b):
        //        {
        //            WriteLine("Variável A é igual a 1");
        //            break;
        //        }
        //    case (a < b):
        //        {
        //            WriteLine("Variável A é igual a 1");
        //            break;
        //        }
        //    case (a == b):
        //        {
        //            WriteLine("Variável A é igual a 1");
        //            break;
        //        }
        //    default:
        //        {
        //            echo "A é alguma coisa não comparável com B";
        //        }
        //}


        //for e foreach

        int[] numeros = new int[4];

        //for (int i = 0; i < numeros.Length; i++)
        //{
        //    WriteLine(numeros[i]);
        //}

        //foreach(int i in numeros)
        //{
        //    WriteLine(numeros[i]);
        //}

        //while e do while
        //bool achou = false;

        //while (!achou)
        //{
        //    if (numeros[1] > 1)
        //    {
        //        achou = true;
        //    }
        //}

        //do
        //{
        //    if (numeros[1] > 1)
        //    {
        //        achou = true;
        //    }
        //} while (!achou);

        Dictionary<string, string> dic = new Dictionary<string, string>();

        dic.Add("1", "eduardo");
        dic.Add("1", "liliane");

        var c = dic["1"];
        var a = dic.TryGetValue("1", out string b);

        var e = dic.ContainsValue("eduardo");
        var f = dic.ContainsKey("eduardo");

        dic.Remove("2");

        dic.Count();
        dic.Clear();
        

        
        //...
        //WriteLine(nome);

        ReadKey();
    }
}