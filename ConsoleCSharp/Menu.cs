using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCSharp
{
    internal class Menu
    {
        public static void itens()
        {
            Console.WriteLine("   _____                                 _        \r\n  / ____|                               | |       \r\n | |        ___    _ __    ___    ___   | |   ___ \r\n | |       / _ \\  | '_ \\  / __|  / _ \\  | |  / _ \\\r\n | |____  | (_) | | | | | \\__ \\ | (_) | | | |  __/\r\n  \\_____|  \\___/  |_| |_| |___/  \\___/  |_|  \\___|\r\n                                                  \r\n                                                  \r\n   _____     _  _                                 \r\n  / ____|  _| || |_                               \r\n | |      |_  __  _|                              \r\n | |       _| || |_                               \r\n | |____  |_  __  _|                              \r\n  \\_____|   |_||_|                                \r\n                                                  \r\n                                                  \r\n");
            Console.WriteLine(" || Aproveite nossa Aplicação ||");
            Console.WriteLine("");
            Console.WriteLine(" || Escolha um Item ||");
            Console.WriteLine("");
            Console.WriteLine(" || Digite [ 1 ] para Tabuada ||");
            Console.WriteLine(" || Digite [ 2 ] para Salário ||");
            Console.Beep();

            Escolha.escolha();
        }
    }
}
