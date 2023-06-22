namespace IlyaCode
{
    internal class Dynamic
    {
        public static void Do()
        {
            Console.WriteLine("Введите номер задачи");
            Console.Write("Dynamic");
            byte taskNumber = Convert.ToByte(Console.ReadLine());
            try
            {
                typeof(Dynamic).GetMethod("Dynamic" + taskNumber).Invoke(null, null);
            }
            catch { }
        }

        public static void Dynamic1()
        {
            var value = new SimpleIlyaNode<int>
            {
                data = 1,
                next = new SimpleIlyaNode<int> { data = 2 }
            };
            Console.WriteLine(value.data);
            Console.WriteLine(value.next.data);
        }

        public static void Dynamic2()
        {
            var value = new SimpleIlyaNode<int>
            {
                data = 1,
                next = new SimpleIlyaNode<int>
                {
                    data = 2,
                    next = new SimpleIlyaNode<int>
                    {
                        data = 3,
                        next = new SimpleIlyaNode<int>
                        {
                            data = 4,
                            next = new SimpleIlyaNode<int>
                            {
                                data = 5
                            }
                        }
                    }
                }
            };
            int count = 0;
            while (value != null)
            {
                Console.WriteLine(value.data);
                value = value.next;
                count++;
            }
            Console.WriteLine(count);
        }

        public static void Dynamic3()
        {
            IlyaStack<int> stack = GetRandomStack(0);
            int d = int.Parse(Console.ReadLine());
            stack.Push(d);
        }

        public static void Dynamic4()
        {
            IlyaStack<int> stack = new IlyaStack<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                stack.Push(value);
            }
        }

        public static void Dynamic5()
        {
            IlyaStack<int> stack = GetRandomStack(1);
            Console.WriteLine(stack.Pop());
        }

        public static void Dynamic6()
        {
            IlyaStack<int> stack = GetRandomStack(10);
            for (int i = 0; i < 9; i++)
                Console.WriteLine(stack.Pop());
        }
        public static void Dynamic7()
        {
            IlyaStack<int> stack = GetRandomStack(0);
            int lenght = stack.Lenght;
            while (!stack.IsEmpty)
                Console.WriteLine(stack.Pop());
            Console.WriteLine(lenght);
        }

        public static void Dynamic8()
        {
            IlyaStack<int> stack1 = GetRandomStack(1);
            IlyaStack<int> stack2 = GetRandomStack(1);
            while (!stack1.IsEmpty)
                stack2.Push(stack1.Pop());
        }

        public static void Dynamic9()
        {
            IlyaStack<int> stack1 = GetRandomStack(1);
            IlyaStack<int> stack2 = GetRandomStack(1);
            while (!stack1.IsEmpty && stack1.Peek() % 2 == 1)
                stack2.Push(stack1.Pop());
        }

        public static void Dynamic10()
        {
            IlyaStack<int> stack = GetRandomStack(1);
            IlyaStack<int> stack1 = new IlyaStack<int>();
            IlyaStack<int> stack2 = new IlyaStack<int>();
            while (!stack1.IsEmpty)
            {
                if (stack.Peek() % 2 == 1)
                {
                    stack2.Push(stack.Pop());
                }
                else
                {
                    stack1.Push(stack.Pop());
                }
            }
        }

        public static void Dynamic11()
        {
            IlyaStack<int> stack = GetRandomStack(0);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                stack.Push(value);
            }
        }

        public static void Dynamic12()
        {
            IlyaStack<int> stack = GetRandomStack(5);
            for (int i = 0; i < 5; i++)
                Console.WriteLine(stack.Pop());
        }

        public static void Dynamic13()
        {
            IlyaStack<int> stack = GetRandomStack(0);
            for (int i = 0; i < 5 && !stack.IsEmpty; i++)
                Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.IsEmpty);
        }

        public static IlyaStack<int> GetRandomStack(int min)
        {
            IlyaStack<int> stack = new IlyaStack<int>();
            Random random = new Random();
            int n = random.Next(min, 100);
            for (int i = 0; i < n; i++)
            {
                int value = random.Next(int.MinValue, int.MaxValue);
                stack.Push(value);
            }
            return stack;
        }
    }
}
