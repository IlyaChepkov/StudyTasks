using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCode
{
    internal static class House
    {
        const Byte c = 5;
        public static void Do()
        {
            string str = Console.ReadLine();
            char s = str.Length > 0 ? str[0] : '█';
            while (true)
            {
                for (int k = 0; k < 100; k++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    for (int i = 1; i <= c; i++)
                    {
                        for (int j = 1; j <= c - i + k; j++)
                        {
                            Console.Write(' ');
                        }
                        for (int j = 1; j <= i * 2 - 1; j++)
                        {
                            Console.Write(s);
                        }
                        Console.WriteLine();
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    for (int i = 1; i <= c; i++)
                    {
                        for (int j = 1; j <= k; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= c * 2 - 1; j++)
                        {
                            Console.Write(s);
                        }
                        Console.WriteLine();
                    }
                    Thread.Sleep(1);
                    Console.Clear();
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
