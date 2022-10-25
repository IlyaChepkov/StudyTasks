using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCode
{
    public static class Calc
    {
        public static void Do()
        {
            Console.WriteLine("Ноль в качестве знака операции" +
                "\nзавершит работу программы");
            while (true)
            {
                Console.WriteLine("Знак (+,-,*,/,^): ");
                string s = Console.ReadLine();
                if (s == "0")
                {
                    break;
                }
                if (s == "+" || s == "-" || s == "*" || s == "/" || s == "^")
                {
                    Console.Write("x = ");
                    float x = Convert.ToSingle(Console.ReadLine());
                    Console.Write("y = ");
                    float y = Convert.ToSingle(Console.ReadLine());
                    switch (s)
                    {
                        case "+":
                            Console.WriteLine(x + y);
                            break;
                        case "-":
                            Console.WriteLine(x - y);
                            break;
                        case "*":
                            Console.WriteLine(x * y);
                            break;
                        case "/":
                            if (y != 0)
                            {
                                Console.WriteLine(x / y);
                            }
                            else
                            {
                                Console.WriteLine("Деление на ноль!");
                            }
                            break;
                        case "^":
                            Console.WriteLine(Math.Pow(x, y));
                            break;
                    }
                }
                else
                    Console.WriteLine("Неверный знак операции!");
            }
        }
    }
}
