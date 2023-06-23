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

        public static void Dynamic14()
        {
            IlyaQueue<int> queue = new IlyaQueue<int>();
            for (int i = 0; i < 10; i++)
            {
                int value = int.Parse(Console.ReadLine());
                queue.Enqueue(value);
            }
        }

        public static void Dynamic15()
        {
            IlyaQueue<int> queue1 = new IlyaQueue<int>();
            IlyaQueue<int> queue2 = new IlyaQueue<int>();
            for (int i = 0; i < 10; i += 2)
            {
                int value = int.Parse(Console.ReadLine());
                queue1.Enqueue(value);
                value = int.Parse(Console.ReadLine());
                queue2.Enqueue(value);
            }
        }

        public static void Dynamic16()
        {
            IlyaQueue<int> queue1 = new IlyaQueue<int>();
            IlyaQueue<int> queue2 = new IlyaQueue<int>();
            for (int i = 0; i < 10; i += 2)
            {
                int value = int.Parse(Console.ReadLine());
                if (value % 2 == 1)
                    queue1.Enqueue(value);
                else
                    queue2.Enqueue(value);
            }
        }

        public static void Dynamic17()
        {
            IlyaQueue<int> queue = GetRandomQueue(0);
            int value = int.Parse(Console.ReadLine());
            queue.Enqueue(value);
        }

        public static void Dynamic18()
        {
            IlyaQueue<int> queue = GetRandomQueue(0);
            int value = int.Parse(Console.ReadLine());
            queue.Enqueue(value);
            Console.WriteLine(queue.Dequeue());
        }

        public static void Dynamic19()
        {
            IlyaQueue<int> queue = GetRandomQueue(0);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n && !queue.IsEmpty; i++)
                Console.WriteLine(queue.Dequeue());
        }

        public static void Dynamic20()
        {
            IlyaQueue<int> queue = GetRandomQueue(1);
            while (!queue.IsEmpty && queue.Peek() % 2 == 1)
                Console.WriteLine(queue.Dequeue());
        }

        public static void Dynamic21()
        {
            IlyaQueue<int> queue1 = GetRandomQueue(1);
            IlyaQueue<int> queue2 = GetRandomQueue(1);
            while (!queue1.IsEmpty)
                queue2.Enqueue(queue1.Dequeue());
        }

        public static void Dynamic22()
        {
            int n = int.Parse(Console.ReadLine());
            IlyaQueue<int> queue1 = GetRandomQueue(1);
            IlyaQueue<int> queue2 = GetRandomQueue(1);
            for (int i = 0; !queue1.IsEmpty && i < n; i++)
                queue2.Enqueue(queue1.Dequeue());
        }

        public static void Dynamic23()
        {
            IlyaQueue<int> queue1 = GetRandomQueue(1);
            IlyaQueue<int> queue2 = GetRandomQueue(1);
            while (!queue1.IsEmpty && queue1.Peek() % 2 == 1)
                queue2.Enqueue(queue1.Dequeue());
        }

        public static void Dynamic24()
        {
            IlyaQueue<int> queue1 = GetRandomQueue(1);
            IlyaQueue<int> queue2 = GetRandomQueue(1);
            IlyaQueue<int> queue3 = new IlyaQueue<int>();
            while (!queue1.IsEmpty)
            {
                queue3.Enqueue(queue1.Dequeue());
                queue3.Enqueue(queue2.Dequeue());
            }
        }

        public static void Dynamic25()
        {
            IlyaQueue<int> queue1 = GetRandomQueue(1);
            IlyaQueue<int> queue2 = GetRandomQueue(1);
            IlyaQueue<int> queue3 = new IlyaQueue<int>();
            while (!queue1.IsEmpty && !queue2.IsEmpty)
            {
                if (queue1.Peek() < queue2.Peek())
                    queue3.Enqueue(queue1.Dequeue());
                else
                    queue3.Enqueue(queue2.Dequeue());
            }
            while (!queue1.IsEmpty)
                queue3.Enqueue(queue1.Dequeue());
            while (!queue2.IsEmpty)
                queue3.Enqueue(queue2.Dequeue());
        }

        public static void Dynamic26()
        {
            IlyaQueue<int> queue = GetRandomQueue(1);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                queue.Enqueue(value);
            }
        }

        public static void Dynamic27()
        {
            IlyaQueue<int> queue = GetRandomQueue(5);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }

        public static void Dynamic28()
        {
            IlyaQueue<int> queue = GetRandomQueue(0);
            for (int i = 0; i < 5 && !queue.IsEmpty; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.WriteLine(queue.IsEmpty);
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

        public static IlyaQueue<int> GetRandomQueue(int min)
        {
            IlyaQueue<int> queue = new IlyaQueue<int>();
            Random random = new Random();
            int n = random.Next(min, 100);
            for (int i = 0; i < n; i++)
            {
                int value = random.Next(int.MinValue, int.MaxValue);
                queue.Enqueue(value);
            }
            return queue;
        }
    }
}
