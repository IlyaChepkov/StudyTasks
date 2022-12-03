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
            for(int i = 0; i < 10; i++)
            {
                for(int j = i; j < 10; j++)
                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}
