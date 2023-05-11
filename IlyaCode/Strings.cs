using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCode
{
    internal class Strings
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            Console.Write("String");
            byte taskNumber = Convert.ToByte(Console.ReadLine());
            try
            {
                typeof(Strings).GetMethod("String" + taskNumber).Invoke(null, null);
            }
            catch { }

        }

        public static void String1()
        {
            string s = Console.ReadLine();
            Console.WriteLine((int)s[0]);
        }

        public static void String2()
        {
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((char)s);
        }

        public static void String3()
        {
            string s = Console.ReadLine();
            Console.WriteLine(s[0] - 1);
            Console.WriteLine(s[0] + 1);
        }
        public static void String4()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((char)('A' + i));
            }
        }

        public static void String5()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((char)('z' - i));
            }
        }

        public static void String6()
        {
            char c = Console.ReadLine()[0];
            if (Char.IsDigit(c))
            {
                Console.WriteLine("digit");
            }
            else
            {
                c = Char.ToLower(c);
                if (c >= 'a' && c <= 'z')
                {
                    Console.WriteLine("lat");
                }
                else
                {
                    Console.WriteLine("rus");
                }
            }
        }

        public static void String7()
        {
            string s = Console.ReadLine();
            Console.WriteLine((int)s[0]);
            Console.WriteLine((int)s[^1]);
        }

        public static void String8()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            char c = Console.ReadLine()[0];
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s += c;
            }
            Console.WriteLine(s);
        }
        public static void String9()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string c = Console.ReadLine()[0].ToString()
                + Console.ReadLine()[0];
            string s = "";
            for (int i = 0; i < n; i += 2)
            {
                s += c;
            }
            Console.WriteLine(s);
        }

        public static void String10()
        {
            string s = Console.ReadLine();
            string output = "";
            for (int i = 0; i < s.Length; i++)
            {
                output += s[^(i + 1)];
            }
            Console.WriteLine(output);
        }

        public static void String11()
        {
            string s = Console.ReadLine();
            string output = "";
            for (int i = 0; i < s.Length; i++)
            {
                output += s[i];
                if (i < s.Length - 1)
                {
                    output += ' ';
                }
            }
            Console.WriteLine(output);
        }
        public static void String12()
        {
            string s = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            string output = "";
            string space = "";
            for (int i = 0; i < n; i++) space += '*';
            for (int i = 0; i < s.Length; i++)
            {
                output += s[i];
                if (i < s.Length - 1)
                {
                    output += space;
                }
            }
            Console.WriteLine(output);
        }

        public static void String13()
        {
            string s = Console.ReadLine();
            int count = 0;
            foreach (char c in s)
            {
                if (Char.IsDigit(c))
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество цифр в строке: {count}");
        }

        public static void String14()
        {
            string s = Console.ReadLine();
            int count = 0;
            foreach (char c in s)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество прописных латинских букв в строке: {count}");
        }
        public static void String15()
        {
            string s = Console.ReadLine();
            int count = 0;
            foreach (char c in s)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'а' && c <= 'я'))
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество строчных букв в строке: {count}");
        }

        public static void String16()
        {
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    s = s.Replace(s[i], Char.ToLower(s[i]));
                }
            }
            Console.WriteLine($"Новая строка: {s}");
        }

        // Предполагается что во входной строке только русские и латинские буквы
        public static void String17()
        {
            string s = Console.ReadLine();
            s = s.ToUpper();
            Console.WriteLine($"Новая строка: {s}");
        }

        public static void String18()
        {
            string s = Console.ReadLine();
            for (int  i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'а' && s[i] <= 'я'))
                {
                    s = s.Remove(i) + Char.ToUpper(s[i]) + s.Substring(i + 1);
                }
                else
                {
                    if ((s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'А' && s[i] <= 'Я'))
                    {
                        s = s.Remove(i) + Char.ToLower(s[i]) + s.Substring(i + 1);
                    }
                }
            }
            Console.WriteLine($"Новая строка: {s}");
        }

        public static void String19()
        {
            string s = Console.ReadLine();
            int i;
            if(int.TryParse(s, out i))
            {
                Console.WriteLine(1);
            }
            else
            {
                double d;
                if (double.TryParse(s, out d))
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }

        public static void String20()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            string s = number.ToString();
            for(int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
                if (i < s.Length - 1)
                {
                    Console.Write(' ');
                }
            }
        }
        public static void String21()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            string s = number.ToString();
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[^(i + 1)]);
                if (i < s.Length - 1)
                {
                    Console.Write(' ');
                }
            }
        }

        public static void String22()
        {
            string s = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i] - '0';
            }
            Console.WriteLine(sum);
        }
        public static void String23()
        {
            string s = Console.ReadLine();
            int res = s[0] - '0';
            for (int i = 1; i < s.Length; i += 2)
            {
                if (s[i] == '+')
                {
                    res += s[i + 1] - '0';
                }
                else
                {
                    res -= s[i + 1] - '0';
                }
            }
            Console.WriteLine(res);
        }
        public static void String24()
        {
            string s = Console.ReadLine();
            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                res += (int)Math.Pow(2, i) * (s[^(i + 1)] - '0');
            }
            Console.WriteLine(res);
        }

        public static void String25()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            string output = "";
            while(number > 1)
            {
                output = number % 2 + output;
                number /= 2;
            }
            Console.WriteLine('1' + output);
        }
        public static void String26()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            string output = Console.ReadLine();
            if (number < output.Length)
            {
                output = output.Remove(number);
            }
            while (output.Length < number)
            {
                output = '.' + output;
            }
            Console.WriteLine(output);
        }
        public static void String27()
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string output = input1.Remove(number1) + input2.Substring(input2.Length - number2);
            Console.WriteLine(output);
        }

        public static void String28()
        {
            char c = Console.ReadLine()[0];
            string input = Console.ReadLine();
            string output = input.Replace(c.ToString(), c.ToString() + c);
            Console.WriteLine(output);
        }

        public static void String29()
        {
            char c = Console.ReadLine()[0];
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string output = input1.Replace(c.ToString(), input2 + c);
            Console.WriteLine(output);
        }

        public static void String30()
        {
            char c = Console.ReadLine()[0];
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string output = input1.Replace(c.ToString(), c + input2);
            Console.WriteLine(output);
        }
        public static void String31()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            Console.WriteLine(input1.IndexOf(input2) != -1);
        }

        public static void String32()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int output = (input1.Length - input1.Replace(input2, "").Length) / input2.Length;
            Console.WriteLine(output);
        }

        public static void String33()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int indexOf = input1.IndexOf(input2);
            string output = input1;
            if (indexOf != -1)
            {
                output = input1.Remove(indexOf) + input1.Substring(indexOf + input2.Length);
            }
            Console.WriteLine(output);
        }

        public static void String34()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int indexOf = input1.LastIndexOf(input2);
            string output = input1;
            if (indexOf != -1)
            {
                output = input1.Remove(indexOf) + input1.Substring(indexOf + input2.Length);
            }
            Console.WriteLine(output);
        }

        public static void String35()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            Console.WriteLine(input1.Replace(input2, ""));
        }
    }
}
