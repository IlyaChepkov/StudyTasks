namespace IlyaCode
{
    public static class For
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("For1");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < k; i++)
                        {
                            Console.WriteLine(n);
                        }
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("For2");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        for (int i = a; i <= b; i++)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine(b - a + 1);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("For3");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        for (int i = a; i <= b; i++)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine(b - a + 1);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("For4");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        for (int i = a; i <= b; i++)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine(b - a + 1);
                    }
                    break;
            }
        }
    }
}
