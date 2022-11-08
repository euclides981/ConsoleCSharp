using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCSharp
{
    internal class Tabuada
    {
        public static void Main()
        {
            Console.WriteLine("Digite um número para executar a tabuada");

            int numeroTabuada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <=10 ; i++)
            {
                Console.WriteLine(numeroTabuada + " X " + i + " = " + numeroTabuada * i);
            }

            Pausa.pausaMenu();
        }
    }
}
