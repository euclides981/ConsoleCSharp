using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCSharp
{
    internal class Pausa
    {
        public static void pausaMenu()
        {
            Console.WriteLine("Digite 1  - Para Fazer outra Analise.\nDigite Qualquer outro Para Sair");

            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                Menu.itens();
            }
            else
            {
                Environment.Exit(0);
            }

        }
    }
}
