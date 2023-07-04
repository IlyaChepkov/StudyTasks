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

        public static void Dynamic29()
        {
            IlyaList<int> list = GetRandomList(3);
            Random random = new Random();
            int n = random.Next(1, list.Count - 1);
            Console.WriteLine(list[n - 1]);
            Console.WriteLine(list[n + 1]);
        }

        public static void Dynamic30()
        {
            IlyaQueue<int> queue = GetRandomQueue(1);
            IlyaList<int> list = new IlyaList<int>();
            while (!queue.IsEmpty) list.Add(queue.Dequeue());
        }

        public static void Dynamic31()
        {
            IlyaList<int> list = GetRandomList(1);
            Console.WriteLine(list.Count);
        }

        public static void Dynamic32()
        {
            int d1 = int.Parse(Console.ReadLine());
            int d2 = int.Parse(Console.ReadLine());
            IlyaList<int> list = GetRandomList(1);
            list.InsertFirst(d1);
            list.Add(d2);
        }

        public static void Dynamic33()
        {
            int d = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            IlyaList<int> list = GetRandomList(1);
            list.Insert(d, index);
        }

        public static void Dynamic34()
        {
            int d = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            IlyaList<int> list = GetRandomList(1);
            list.Insert(d, index + 1);
        }

        public static void Dynamic35()
        {
            IlyaList<int> list = GetRandomList(2);
            list.InsertFirst(list[0]);
            list.Insert(list[list.Count - 1], list.Count - 1);
        }

        public static void Dynamic36()
        {
            IlyaList<int> list = GetRandomList(2);
            list.Insert(list[0], 1);
            list.Add(list[list.Count - 1]);
        }

        public static void Dynamic37()
        {
            IlyaList<int> list = GetRandomList(1);
            for (int i = 0; i < list.Count; i += 3) 
                list.Insert(list[i], i);
        }

        public static void Dynamic38()
        {
            IlyaList<int> list = GetRandomList(1);
            for (int i = 0; i < list.Count; i += 3)
                list.Insert(list[i], i + 1);
        }

        public static void Dynamic39()
        {
            IlyaList<int> list = GetRandomList(1);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 1)
                {
                    list.Insert(list[i], i);
                    i++;
                }
            }
        }

        public static void Dynamic40()
        {
            IlyaList<int> list = GetRandomList(1);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 1)
                {
                    list.Insert(list[i], i + 1);
                    i++;
                }
            }
        }

        public static void Dynamic41()
        {
            IlyaList<int> list = GetRandomList(1);
            int index = int.Parse(Console.ReadLine());
            list.RemoveAt(index);
        }

        public static void Dynamic42()
        {
            IlyaList<int> list = GetRandomList(2);
            for (int i = 0; i < list.Count; i++)
                list.RemoveAt(i);
        }

        public static void Dynamic43()
        {
            IlyaList<int> list = GetRandomList(1);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 1)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }

        public static void Dynamic44()
        {
            IlyaList<int> list = GetRandomList(1);
            int index = int.Parse(Console.ReadLine());
            list.Add(list[index]);
            list.RemoveAt(index);
        }

        public static void Dynamic45()
        {
            IlyaList<int> list = GetRandomList(1);
            int index = int.Parse(Console.ReadLine());
            list.InsertFirst(list[index]);
            list.RemoveAt(index + 1);
        }

        public static void Dynamic46()
        {
            IlyaList<int> list = GetRandomList(1);
            int k = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            if (index + k + 1 >= list.Count)
                list.Add(list[index]);
            else
                list.Insert(list[index], index + k + 1);
            list.RemoveAt(index);
        }

        public static void Dynamic47()
        {
            IlyaList<int> list = GetRandomList(1);
            int k = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            if (index - k <= 0)
                list.InsertFirst(list[index]);
            else
                list.Insert(list[index], index - k);
            list.RemoveAt(index + 1);
        }

        public static void Dynamic48()
        {
            IlyaList<int> list = GetRandomList(1);
            int index1 = int.Parse(Console.ReadLine());
            int index2 = int.Parse(Console.ReadLine());
            int bufer = list[index1];
            list[index1] = list[index2];
            list[index2] = bufer;
        }

        public static void Dynamic49()
        {
            IlyaList<int> list = GetRandomList(1);
            for (int i = 0; i < list.Count; i++)
            { 
                list.Add(list[i]);
                list.RemoveAt(i);
            }
        }

        public static void Dynamic50()
        {
            IlyaList<int> list = GetRandomList(1);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 1)
                {
                    list.Add(list[i]);
                    list.RemoveAt(i);
                    i--;
                }
            }
        }

        public static void Dynamic51()
        {
            IlyaList<int> list1 = GetRandomList(1);
            IlyaList<int> list2 = GetRandomList(1);
            int index = int.Parse(Console.ReadLine());
            list2.InsertRange(list1, index);
        }

        public static void Dynamic52()
        {
            IlyaList<int> list1 = GetRandomList(1);
            IlyaList<int> list2 = GetRandomList(1);
            int index = int.Parse(Console.ReadLine());
            list2.InsertRange(list1, index + 1);
        }

        public static void Dynamic53()
        {
            IlyaList<int> list1 = GetRandomList(1);
            int index1 = int.Parse(Console.ReadLine());
            int index2 = int.Parse(Console.ReadLine());
            IlyaList<int> list2 = list1.Split(index1);
            IlyaList<int> list3 = list2.Split(index2 + 1);
            list1.AddRange(list3);
        }

        public static void Dynamic54()
        {
            IlyaList<int> list1 = GetRandomList(1);
            int index1 = int.Parse(Console.ReadLine());
            int index2 = int.Parse(Console.ReadLine());
            IlyaList<int> list2 = list1.Split(index1 + 1);
            IlyaList<int> list3 = list2.Split(index2);
            list1.AddRange(list3);
        }

        public static void Dynamic55()
        {
            IlyaList<int> list1 = GetRandomList(1);
            IlyaCicleList<int> cicleList = list1.ToCicle();
        }

        public static void Dynamic56()
        {
            IlyaList<int> list = GetRandomList(2);
            IlyaCicleList<int> cicleList1 = list.ToCicle();
            IlyaCicleList<int> cicleList2 = cicleList1.Split(cicleList1.Count / 2);
        }

        public static void Dynamic57()
        {
            IlyaList<int> list = GetRandomList(1);
            IlyaCicleList<int> cicleList1 = list.ToCicle();
            int k = int.Parse(Console.ReadLine());
            cicleList1.Next(k);
        }

        public static void Dynamic58()
        {
            IlyaList<int> list = GetRandomList(1);
            IlyaCicleList<int> cicleList1 = list.ToCicle();
            int k = int.Parse(Console.ReadLine());
            cicleList1.Prev(k);
        }

        public static void Dynamic59()
        {
            IlyaList<int> list = GetRandomList(1);
            int d = int.Parse(Console.ReadLine());
            list.Add(d);
        }

        public static void Dynamic60()
        {
            IlyaList<int> list = GetRandomList(1);
            int d = int.Parse(Console.ReadLine());
            list.InsertFirst(d);
        }
        public static void Dynamic61()
        {
            IlyaList<int> list = GetRandomList(1);
            int index = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                int d = int.Parse(Console.ReadLine());
                list.Insert(d, index);
            }
        }

        public static void Dynamic62()
        {
            IlyaList<int> list = GetRandomList(1);
            int index = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                int d = int.Parse(Console.ReadLine());
                list.Insert(d, index + 1);
            }
        }

        public static void Dynamic63()
        {
            IlyaList<int> list = GetRandomList(1);
            for (int i = 0; i < list.Count; i += 2)
            {
                list[i] = 0;
            }
        }

        public static void Dynamic64()
        {
            IlyaList<int> list = GetRandomList(1);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    Console.WriteLine(list[list.Count - i - 1]);
                }
            }
        }

        public static void Dynamic65()
        {
            IlyaList<int> list = GetRandomList(1);
            int index = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                list.RemoveAt(index);
            }
        }

        public static void Dynamic66()
        {
            IlyaList<int> list = GetRandomList(1);
            int index = int.Parse(Console.ReadLine());
            var list2 = list.Split(index);
        }

        public static void Dynamic67()
        {
            IlyaList<int> list1 = GetRandomList(1);
            IlyaList<int> list2 = GetRandomList(1);
            list1.AddRange(list2);
        }

        public static void Dynamic68()
        {
            IlyaList<int> list1 = GetRandomList(1);
            IlyaList<int> list2 = GetRandomList(1);
            int index = int.Parse(Console.ReadLine());
            list1.InsertRange(list2, index);
        }

        public static void Dynamic69()
        {
            IlyaList<int> list1 = GetRandomList(1);
            IlyaList<int> list2 = GetRandomList(1);
            int index1 = int.Parse(Console.ReadLine());
            int index2 = int.Parse(Console.ReadLine());
            list1.Move(list2, index1, index2);
        }

        public static void Dynamic70()
        {
            IlyaList<int> list = GetRandomList(1);
            IlyaBarierList<int> barierList = list.ToBarier();
        }

        public static void Dynamic71()
        {
            IlyaList<int> list = GetRandomList(1);
            IlyaBarierList<int> barierList1 = list.ToBarier();
            int index = int.Parse(Console.ReadLine());
            IlyaBarierList<int> barierList2 = barierList1.Split(index);
        }

        public static void Dynamic72()
        {
            IlyaList<int> list1 = GetRandomList(1);
            IlyaBarierList<int> barierList1 = list1.ToBarier();
            IlyaList<int> list2 = GetRandomList(1);
            IlyaBarierList<int> barierList2 = list2.ToBarier();
            barierList1.AddRange(barierList2);
        }

        public static void Dynamic73()
        {
            IlyaList<int> list1 = GetRandomList(1);
            IlyaBarierList<int> barierList1 = list1.ToBarier();
            IlyaList<int> list2 = GetRandomList(1);
            IlyaBarierList<int> barierList2 = list2.ToBarier();
            barierList2.AddRange(barierList1);
        }

        public static void Dynamic74()
        {
            IlyaList<int> list = GetRandomList(1);
            IlyaBarierList<int> barierList = list.ToBarier();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int d = int.Parse(Console.ReadLine());
                barierList.Add(d);
            }
        }

        public static void Dynamic75()
        {
            IlyaList<int> list = GetRandomList(1);
            IlyaBarierList<int> barierList = list.ToBarier();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int d = int.Parse(Console.ReadLine());
                barierList.InsertFirst(d);
            }
        }

        public static void Dynamic76()
        {
            IlyaList<int> list = GetRandomList(1);
            IlyaBarierList<int> barierList = list.ToBarier();
            int index = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                int d = int.Parse(Console.ReadLine());
                barierList.Insert(d, index);
            }
        }

        public static void Dynamic77()
        {
            IlyaList<int> list = GetRandomList(1);
            IlyaBarierList<int> barierList = list.ToBarier();
            int index = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                int d = int.Parse(Console.ReadLine());
                barierList.Insert(d, index + 1);
            }
        }

        public static void Dynamic78()
        {
            IlyaList<int> list = GetRandomList(1);
            IlyaBarierList<int> barierList = list.ToBarier();
            int index = int.Parse(Console.ReadLine());
            for (int i = 0; i < barierList.Count; i += 2)
            {
                barierList[i] = 0;
            }
            Console.WriteLine(barierList.Count);
        }

        public static void Dynamic79()
        {
            IlyaList<int> list = GetRandomList(1);
            IlyaBarierList<int> barierList = list.ToBarier();
            for (int i = 0; i < barierList.Count; i++)
            {
                if (barierList[barierList.Count - i - 1] % 2 == 0)
                    Console.WriteLine(barierList[barierList.Count - i - 1]);
            }
            Console.WriteLine(barierList.Count);
        }

        public static void Dynamic80()
        {
            IlyaList<int> list = GetRandomList(1);
            IlyaBarierList<int> barierList = list.ToBarier();
            int index = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                barierList.RemoveAt(index);
            }
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

        public static IlyaList<int> GetRandomList(int min)
        {
            IlyaList<int> list = new IlyaList<int>();
            Random random = new Random();
            int n = random.Next(min, 100);
            for (int i = 0; i < n; i++)
            {
                int value = random.Next(int.MinValue, int.MaxValue);
                list.Add(value);
            }
            return list;
        }
    }
}
