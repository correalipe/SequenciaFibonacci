namespace SequenciaFibonacci;
class Program
{

    //Check and operation of the informed term
    private static void sequenciaFibonacci(int enesimo)
    {
        //Variables
        int primeiro = 0;
        int segundo = 1;
        int x;

        //First term of the sequence check
        if (enesimo == 0)
        {
            Console.WriteLine("O número é: 0");
        }
        //Second term of the sequence check
        else if (enesimo == 1)
        {
            Console.WriteLine("O número é: 1");
        }
        //Loop, calculus and output
        else
        {
            for (int i = 0; i < enesimo; i++)
            {
                x = primeiro + segundo;
                primeiro = segundo;
                segundo = x;
            }
            Console.WriteLine("O {0}º termo trás o número {1} e esse número faz parte da sequência.", enesimo, primeiro);
        }
    }
        

    //Try & catch
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                //Input
                Console.WriteLine("Insira um número (termo) para calcular: ");
                int x = int.Parse(Console.ReadLine());
                //Calculator ref
                sequenciaFibonacci(x);
            }

                //Invalid input
            catch
            {
                Console.WriteLine("Inválido. Tente novamente.");
            }
        }
    }
}