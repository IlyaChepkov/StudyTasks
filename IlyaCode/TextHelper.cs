namespace IlyaCode
{
    internal static class TextHelper
    {
        public static void Do()
        {
            Console.WriteLine("Привет");
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Приятно познакомиться, " + name);
            Console.WriteLine("Чем могу тебе помочь, " + name + "?");
            string command = Console.ReadLine();
            if (command == "Запусти калькулятор")
            {
                Console.Clear();
                Calc.Do();
                Console.Clear();
            }
            else
            {
                if (command == "Расскажи историю")
                {
                    Console.Clear();
                    Console.WriteLine($"Ехал {name} через реку");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"Видит {name} в реке рак");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"Сунул {name} руку в реку");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"Рак за руку {name} цап");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    if (command == "Ни чем")
                    {
                        Console.WriteLine("Ну тогда я пошла!");
                        Console.WriteLine("И не пиши мне больше!!!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Я тебя невразумею");
                    }
                }
            }
            Console.WriteLine("Я устала");
            Console.WriteLine("Пока, {0}", name);
            Console.WriteLine("Пиши ещё!");
        }
    }
}
