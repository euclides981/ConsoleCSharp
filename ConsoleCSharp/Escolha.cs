using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCSharp
{
    internal class Escolha
    {

        public static void escolha()
        {
            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(option);

            if (option == 1)
            {
                Tabuada.Main();                
            }
            if (option == 2)
            {
                Salario.Main();
            }
            else
            {
                Imc.Main();                
            }
            Console.ReadLine();
        }

        

    }
}
