using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCode
{
    internal static class Tree
    {
        public static void Do()
        {
            Byte c = Convert.ToByte(Console.ReadLine());
            string str = Console.ReadLine();
            char s = str.Length > 0 ? str[0] : '█';
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 1; i <= c; i++)
            {
                for (int j = 1; j <= c - i; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
        }
    }
}
