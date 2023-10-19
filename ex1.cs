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
            int op, a, b, c, f, m, v, vo, t, ac, ac2;
            double x1, x2, delta;
        INICIO:

            Console.SetCursorPosition(35, 2);
            Console.WriteLine("╔══════════════════════════╗");
            Console.SetCursorPosition(35, 3);
            Console.WriteLine("║    ESCOLHA A FÓRMULA     ║");
            Console.SetCursorPosition(35, 4);
            Console.WriteLine("╠══════════════════════════╣");
            Console.SetCursorPosition(35, 5);
            Console.WriteLine("║ 1- Bhaskara              ║");
            Console.SetCursorPosition(35, 6);
            Console.WriteLine("║ 2- Força                 ║");
            Console.SetCursorPosition(35, 7);
            Console.WriteLine("║ 3- Velocidade            ║");
            Console.SetCursorPosition(35, 8);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(35, 9);
            Console.WriteLine("║                          ║");
            Console.SetCursorPosition(35, 10);
            Console.WriteLine("╚══════════════════════════╝");

            Console.SetCursorPosition(37, 9);
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {

                case 1:
                    Console.Clear();
                    Console.SetCursorPosition(35, 2);
                    Console.WriteLine("╔══════════════════════════╗");
                    Console.SetCursorPosition(35, 3);
                    Console.WriteLine("║     DECLARE a, b e c     ║");
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("╠══════════════════════════╣");
                    Console.SetCursorPosition(35, 5);
                    Console.WriteLine("║                          ║");
                    Console.SetCursorPosition(35, 6);
                    Console.WriteLine("║                          ║");
                    Console.SetCursorPosition(35, 7);
                    Console.WriteLine("║                          ║");
                    Console.SetCursorPosition(35, 8);
                    Console.WriteLine("║                          ║");
                    Console.SetCursorPosition(35, 9);
                    Console.WriteLine("║                          ║");
                    Console.SetCursorPosition(35, 10);
                    Console.WriteLine("╚══════════════════════════╝");

                    Console.SetCursorPosition(37, 6);
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.SetCursorPosition(37, 7);
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.SetCursorPosition(37, 8);
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    delta = Math.Pow(b, 2) - 4 * a * c;
                    x1 = -b + Math.Sqrt(delta) / (2 * a);
                    x2 = -b - Math.Sqrt(delta) / (2 * a);

                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("╔══════════════════════════╗");
                    Console.SetCursorPosition(35, 5);
                    Console.WriteLine("║                          ║");
                    Console.SetCursorPosition(35, 6);
                    Console.WriteLine("║                          ║");
                    Console.SetCursorPosition(35, 7);
                    Console.WriteLine("║                          ║");
                    Console.SetCursorPosition(35, 8);
                    Console.WriteLine("║                          ║");
                    Console.SetCursorPosition(35, 9);
                    Console.WriteLine("║                          ║");
                    Console.SetCursorPosition(35, 10);
                    Console.WriteLine("╚══════════════════════════╝");
                    Console.SetCursorPosition(37, 6);
                    Console.WriteLine("Resultado:");
                    Console.SetCursorPosition(37, 7);
                    Console.WriteLine("x1 = {0}",x1);
                    Console.SetCursorPosition(37, 8);
                    Console.WriteLine("x2 = {0}",x2);
                    break;

                case 2:
                    Console.Clear();
                    Console.SetCursorPosition(35, 2);
                    Console.WriteLine("╔═════════════════════════════════╗");
                    Console.SetCursorPosition(35, 3);
                    Console.WriteLine("║  Declare a massa e a aceleração ║");
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("╠═════════════════════════════════╣");
                    Console.SetCursorPosition(35, 5);
                    Console.WriteLine("║                                 ║");
                    Console.SetCursorPosition(35, 6);
                    Console.WriteLine("║                                 ║");
                    Console.SetCursorPosition(35, 7);
                    Console.WriteLine("║                                 ║");
                    Console.SetCursorPosition(35, 8);
                    Console.WriteLine("║                                 ║");
                    Console.SetCursorPosition(35, 9);
                    Console.WriteLine("║                                 ║");
                    Console.SetCursorPosition(35, 10);
                    Console.WriteLine("╚═════════════════════════════════╝");

                    Console.SetCursorPosition(36, 6);
                    m = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(36, 7);
                    ac = Convert.ToInt32(Console.ReadLine());

                    f = m * ac;
                    Console.Clear();
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("╔══════════════════════════╗");
                    Console.SetCursorPosition(35, 5);
                    Console.WriteLine("║                          ║");
                    Console.SetCursorPosition(35, 6);
                    Console.WriteLine("║                          ║");
                    Console.SetCursorPosition(35, 7);
                    Console.WriteLine("║                          ║");
                    Console.SetCursorPosition(35, 8);
                    Console.WriteLine("║                          ║");
                    Console.SetCursorPosition(35, 9);
                    Console.WriteLine("║                          ║");
                    Console.SetCursorPosition(35, 10);
                    Console.WriteLine("╚══════════════════════════╝");
                    Console.SetCursorPosition(37, 6);
                    Console.WriteLine("Força = {0}",f);
                  
                    break;

                case 3:
                    Console.Clear();
                    Console.SetCursorPosition(35, 2);
                    Console.WriteLine("╔═══════════════════════════════════╗");
                    Console.SetCursorPosition(35, 3);
                    Console.WriteLine("║    Declare a velocidade inicial,  ║");
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("║     a aceleração e o tempo        ║");
                    Console.SetCursorPosition(35, 5);
                    Console.WriteLine("╠═══════════════════════════════════╣");
                    Console.SetCursorPosition(35, 6);
                    Console.WriteLine("║                                   ║");
                    Console.SetCursorPosition(35, 7);
                    Console.WriteLine("║                                   ║");
                    Console.SetCursorPosition(35, 8);
                    Console.WriteLine("║                                   ║");
                    Console.SetCursorPosition(35, 9);
                    Console.WriteLine("║                                   ║");
                    Console.SetCursorPosition(35, 10);
                    Console.WriteLine("╚═══════════════════════════════════╝");

                    Console.SetCursorPosition(36, 6);
                    vo = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(36, 7);
                    ac2 = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(36, 8);
                    t = Convert.ToInt32(Console.ReadLine());

                    v = vo + (ac2 * t);
                    Console.SetCursorPosition(36, 9);
                    Console.WriteLine("Velocidade = {0}", v);

                    break;
                default:
                    goto INICIO;
            }
            Console.ReadKey();
            
        }
    }
}
