using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "AUMENTO SALARIAL";
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            int op;
            double oldSal, newSal, diff;
        INICIO:
            Console.Clear();
            Console.SetCursorPosition(35, 2);
            Console.WriteLine("╔══════════════════════════╗");
            Console.SetCursorPosition(35, 3);
            Console.WriteLine("║    Digite seu salário    ║");
            Console.SetCursorPosition(35, 4);
            Console.WriteLine("╠══════════════════════════╣");
            Console.SetCursorPosition(35, 5);
            Console.WriteLine("║ R$:                      ║");                     
            Console.SetCursorPosition(35, 6);
            Console.WriteLine("╚══════════════════════════╝");
            Console.SetCursorPosition(41, 5);
            oldSal = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.SetCursorPosition(35, 2);
            Console.WriteLine("╔══════════════════════════╗");
            Console.SetCursorPosition(35, 3);
            Console.WriteLine("║   Selecione seu cargo    ║");
            Console.SetCursorPosition(35, 4);
            Console.WriteLine("╠══════════════════════════╣");
            Console.SetCursorPosition(35, 5);
            Console.WriteLine("║ 1- Gerente               ║");
            Console.SetCursorPosition(35, 6);
            Console.WriteLine("║ 2- Analista              ║");
            Console.SetCursorPosition(35, 7);
            Console.WriteLine("║ 3- Técnico               ║");
            Console.SetCursorPosition(35, 8);
            Console.WriteLine("║ 4- Outro                 ║");
            Console.SetCursorPosition(35, 9);
            Console.WriteLine("║    ->   <-               ║");
            Console.SetCursorPosition(35, 10);
            Console.WriteLine("╚══════════════════════════╝");
            Console.SetCursorPosition(43, 9);
            op = Convert.ToInt32(Console.ReadLine());            

            switch (op)
            {
                case 1:

                    Console.Clear();
                    newSal = oldSal + ((oldSal * 10) / 100);
                    diff = newSal - oldSal;
                    Console.SetCursorPosition(35, 2);
                    Console.WriteLine("╔══════════════════════════╗");
                    Console.SetCursorPosition(35, 3);
                    Console.WriteLine("║        Relatório         ║");
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
                    Console.WriteLine("╚══════════════════════════╝");
                    Console.SetCursorPosition(36, 5);
                    Console.WriteLine("Salário antigo: R$:{0}", oldSal);
                    Console.SetCursorPosition(36, 6);
                    Console.WriteLine("Salário novo: R$:{0}", newSal);
                    Console.SetCursorPosition(36, 7);
                    Console.WriteLine("Diferença: R$:{0}", diff);
                    break;

                case 2:

                    Console.Clear();
                    newSal = oldSal + ((oldSal * 20) / 100);
                    diff = newSal - oldSal;
                    Console.SetCursorPosition(35, 2);
                    Console.WriteLine("╔══════════════════════════╗");
                    Console.SetCursorPosition(35, 3);
                    Console.WriteLine("║        Relatório         ║");
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
                    Console.WriteLine("╚══════════════════════════╝");
                    Console.SetCursorPosition(36, 5);
                    Console.WriteLine("Salário antigo: R$:{0}", oldSal);
                    Console.SetCursorPosition(36, 6);
                    Console.WriteLine("Salário novo: R$:{0}", newSal);
                    Console.SetCursorPosition(36, 7);
                    Console.WriteLine("Diferença: R$:{0}", diff);
                    break;

                case 3:

                    Console.Clear();
                    newSal = oldSal + ((oldSal * 30) / 100);
                    diff = newSal - oldSal;
                    Console.SetCursorPosition(35, 2);
                    Console.WriteLine("╔══════════════════════════╗");
                    Console.SetCursorPosition(35, 3);
                    Console.WriteLine("║        Relatório         ║");
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
                    Console.WriteLine("╚══════════════════════════╝");
                    Console.SetCursorPosition(36, 5);
                    Console.WriteLine("Salário antigo: R$:{0}", oldSal);
                    Console.SetCursorPosition(36, 6);
                    Console.WriteLine("Salário novo: R$:{0}", newSal);
                    Console.SetCursorPosition(36, 7);
                    Console.WriteLine("Diferença: R$:{0}", diff);
                    break;

                case 4:

                    Console.Clear();
                    newSal = oldSal + ((oldSal * 40) / 100);
                    diff = newSal - oldSal;
                    Console.SetCursorPosition(35, 2);
                    Console.WriteLine("╔══════════════════════════╗");
                    Console.SetCursorPosition(35, 3);
                    Console.WriteLine("║        Relatório         ║");
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
                    Console.WriteLine("╚══════════════════════════╝");
                    Console.SetCursorPosition(36, 5);
                    Console.WriteLine("Salário antigo: R$:{0}", oldSal);
                    Console.SetCursorPosition(36, 6);
                    Console.WriteLine("Salário novo: R$:{0}", newSal);
                    Console.SetCursorPosition(36, 7);
                    Console.WriteLine("Diferença: R$:{0}", diff);
                    break;
                default:                    
                    goto INICIO;
            }
            Console.ReadKey();
        }
    }
}
