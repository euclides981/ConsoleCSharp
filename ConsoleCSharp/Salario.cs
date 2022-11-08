using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCSharp
{
    internal class Salario
    {
        public static void Main()
        {
            Console.WriteLine("Digite valor da hora trabalhada:");

            decimal valorHora = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite quantidade de horas trabalhadas:");

            decimal qtdHoras = Convert.ToDecimal(Console.ReadLine());

            decimal valorTotal = valorHora * qtdHoras;

            Console.WriteLine("Valor Total é de: " + valorTotal);
            
            Console.WriteLine();

            Pausa.pausaMenu();

        }
    }
}
