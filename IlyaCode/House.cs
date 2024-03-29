﻿using System;
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
        static char s = '█';
        public static void Do()
        {
            string str = Console.ReadLine();
            s = str.Length > 0 ? str[0] : '█';
            while (true)
            {
                for (int k = 0; k < 50; k++)
                {
                    Paint(k, k / 2);
                }
                for (int k = 0; k < 50; k++)
                {
                    Paint(k + 50, 24 - k / 2);
                }
                for (int k = 0; k < 100; k++)
                {
                    Paint(100 - k, 0);
                }
            }
        }

        public static void Paint(int x, int y)
        {
            for (int i = 0; i <= y; i++)
            {
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 1; i <= c; i++)
            {
                for (int j = 1; j <= c - i + x; j++)
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
                for (int j = 1; j <= x; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= c * 2 - 1; j++)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
            Thread.Sleep(10);
            Console.Clear();
        }
    }
}
