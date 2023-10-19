using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "É O CALCULAS";
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            int op, x, y, r;
            INICIO:

            Console.SetCursorPosition(35, 2);
            Console.WriteLine("╔══════════════════════════╗");
            Console.SetCursorPosition(35, 3);
            Console.WriteLine("║    ESCOLHA O CÁLCULO     ║");
            Console.SetCursorPosition(35, 4);
            Console.WriteLine("╠══════════════════════════╣");
            Console.SetCursorPosition(35, 5);
            Console.WriteLine("║ 1- Adição                ║");
            Console.SetCursorPosition(35, 6);
            Console.WriteLine("║ 2- Subtração             ║");
            Console.SetCursorPosition(35, 7);
            Console.WriteLine("║ 3- Multiplicação         ║");
            Console.SetCursorPosition(35, 8);
            Console.WriteLine("║ 4- Divisão               ║");
            Console.SetCursorPosition(35, 9);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(35, 10);
            Console.WriteLine("╚══════════════════════════╝");
            Console.SetCursorPosition(40, 9);
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {

                case 1:
                    Console.Clear();
                    Console.SetCursorPosition(35, 2);
                    Console.WriteLine("╔═══════════════════╗");
                    Console.SetCursorPosition(35, 3);
                    Console.WriteLine("║     Adição        ║");
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("╠═══════════════════╣");
                    Console.SetCursorPosition(35, 5);
                    Console.WriteLine("║                   ║");
                    Console.SetCursorPosition(35, 6);
                    Console.WriteLine("║                   ║");
                    Console.SetCursorPosition(35, 7);
                    Console.WriteLine("║                   ║");
                    Console.SetCursorPosition(35, 8);
                    Console.WriteLine("╚═══════════════════╝");

                    Console.SetCursorPosition(37, 5);
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.SetCursorPosition(37, 6);
                    y = Convert.ToInt32(Console.ReadLine());

                    r = x + y;
                    Console.SetCursorPosition(37, 7);
                    Console.WriteLine("Resultado: {0}", r);

                    break;

                case 2:
                    Console.Clear();
                    Console.SetCursorPosition(35, 2);
                    Console.WriteLine("╔═══════════════════╗");
                    Console.SetCursorPosition(35, 3);
                    Console.WriteLine("║     Subtração     ║");
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("╠═══════════════════╣");
                    Console.SetCursorPosition(35, 5);
                    Console.WriteLine("║                   ║");
                    Console.SetCursorPosition(35, 6);
                    Console.WriteLine("║                   ║");
                    Console.SetCursorPosition(35, 7);
                    Console.WriteLine("║                   ║");
                    Console.SetCursorPosition(35, 8);
                    Console.WriteLine("╚═══════════════════╝");

                    Console.SetCursorPosition(37, 5);
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.SetCursorPosition(37, 6);
                    y = Convert.ToInt32(Console.ReadLine());

                    r = x - y;
                    Console.SetCursorPosition(37, 7);
                    Console.WriteLine("Resultado: {0}", r);

                    break;

                case 3:
                    Console.Clear();
                    Console.SetCursorPosition(35, 2);
                    Console.WriteLine("╔═══════════════════╗");
                    Console.SetCursorPosition(35, 3);
                    Console.WriteLine("║   Multiplicação   ║");
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("╠═══════════════════╣");
                    Console.SetCursorPosition(35, 5);
                    Console.WriteLine("║                   ║");
                    Console.SetCursorPosition(35, 6);
                    Console.WriteLine("║                   ║");
                    Console.SetCursorPosition(35, 7);
                    Console.WriteLine("║                   ║");
                    Console.SetCursorPosition(35, 8);
                    Console.WriteLine("╚═══════════════════╝");

                    Console.SetCursorPosition(37, 5);
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.SetCursorPosition(37, 6);
                    y = Convert.ToInt32(Console.ReadLine());

                    r = x * y;
                    Console.SetCursorPosition(37, 7);
                    Console.WriteLine("Resultado: {0}", r);

                    break;

                case 4:
                    Console.Clear();
                    Console.SetCursorPosition(35, 2);
                    Console.WriteLine("╔═══════════════════╗");
                    Console.SetCursorPosition(35, 3);
                    Console.WriteLine("║     Divisão       ║");
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("╠═══════════════════╣");
                    Console.SetCursorPosition(35, 5);
                    Console.WriteLine("║                   ║");
                    Console.SetCursorPosition(35, 6);
                    Console.WriteLine("║                   ║");
                    Console.SetCursorPosition(35, 7);
                    Console.WriteLine("║                   ║");
                    Console.SetCursorPosition(35, 8);
                    Console.WriteLine("╚═══════════════════╝");

                    Console.SetCursorPosition(37, 5);
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.SetCursorPosition(37, 6);
                    y = Convert.ToInt32(Console.ReadLine());

                    r = x / y;
                    Console.SetCursorPosition(37, 7);
                    Console.WriteLine("Resultado: {0}", r);

                    break;
                default:
                    goto INICIO;
            }
            Console.ReadKey();

        }
    }
}
