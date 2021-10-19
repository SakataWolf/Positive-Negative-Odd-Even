using System;

namespace Par_Impar_Negativo_Positivo
{
    class Program
    {
        static void Main(string[] args)
        {
            String S;
            int n = 1, p = 0, i = 0, p1 = 0, n1 = 0,s;//declaração de variaveis

            Console.WriteLine("Par Impar Positivo Negativo");//Titulo
            do//Iniciação do Loop
            {
                Console.WriteLine("\nDigite um valor:");
                n = int.Parse(Console.ReadLine());//Aplicação do valor na variavel n
                if (n % 2 == 0)//Se o resto da divisão do valor de n for igual a 0 o número é par
                {
                    p++;
                }
                else//Caso contrário é impar
                {
                    i++;
                }
                if (n >= 0)//Se o valor de n for maior ou igual a 0 o número é positivo
                {
                    p1++;
                }
                else//Caso contrário é negativo
                {
                    n1++;
                }
                Console.WriteLine("Deseja continuar ? (1)Sim (2)Não");
                s = int.Parse(Console.ReadLine());
            } while (s!=2); //Fim do Loop

            //Mostrar o resutado para o usuário
            Console.WriteLine("\n\nQtd.Pares: " + p);
            Console.WriteLine("\n\nQtd.Impares: " + i);
            Console.WriteLine("\n\nQtd.Positivos: " + p1);
            Console.WriteLine("\n\nQtd.Negativos: " + n1);
            Console.ReadKey();
        }
    }
}
