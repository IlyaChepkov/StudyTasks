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
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 1; i <= c / 2; i++)
            {
                for (int j = 1; j <= c * 2 / 3; j++)
                {
                    Console.Write(" ");
                }
                for (int j = c * 2 / 3; j <= (4 * c) / 3; j++)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
