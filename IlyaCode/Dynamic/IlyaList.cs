namespace IlyaCode
{
    internal class IlyaList<T>
    {
        int lenght = 0;
        int currentIndex = -1;
        IlyaListNode<T> first;
        IlyaListNode<T> last;
        IlyaListNode<T> current;

        public int Count
        {
            get { return lenght; }
        }

        public bool IsEmpty
        {
            get { return lenght == 0; }
        }

        public bool IsLast
        {
            get { return current.next == null; }
        }

        public bool IsFirst
        {
            get { return current.prev == null; }
        }

        public T this[int index]
        {
            get
            {
                current = GetElem(index);
                return current.data;
            }
            set
            {
                current = GetElem(index);
                current.data = value;
            }
        }

        public IlyaCicleList<T> ToCicle()
        {
            last.next = first;
            first.prev = last;
            IlyaCicleList<T> ilyaCicleList = new IlyaCicleList<T>(first);
            first = null;
            last = null;
            current = null;
            lenght = 0;
            currentIndex = -1;
            return ilyaCicleList;
        }

        public IlyaBarierList<T> ToBarier()
        {
            IlyaListNode<T> barier = new IlyaListNode<T>();
            barier.next = first;
            barier.prev = last;
            first.prev = barier;
            last.next = barier;
            IlyaBarierList<T> ilyaBarierList = new IlyaBarierList<T>(barier);
            first = null;
            last = null;
            current = null;
            lenght = 0;
            currentIndex = -1;
            return ilyaBarierList;
        }

        public void Add(T value)
        {
            IlyaListNode<T> ilyaListNode = new IlyaListNode<T>
            {
                data = value,
                next = null,
                prev = last
            };
            if (lenght == 0)
            {
                first = ilyaListNode;
            }
            else
            {
                last.next = ilyaListNode;
            }
            last = ilyaListNode;
            current = last;
            lenght++;
            currentIndex = lenght - 1;
        }

        public void AddRange(IlyaList<T> list)
        {
            if (first != null)
                last.next = list.first;
            else
            {
                first = list.first;
                last = list.last;
                current = list.current;
            }
            if (list.first != null)
            {
                list.first.prev = last;
                last = list.last;
                current = list.first;
            }
            lenght += list.lenght;
            currentIndex = lenght - list.lenght;
            list.first = null;
            list.last = null;
            list.current = null;
        }

        public void InsertRange(IlyaList<T> list, int index)
        {
            if (index == lenght) AddRange(list);
            if (index < 0 || index > lenght) throw new Exception("Индекс не существует");
            var list2 = Split(index);
            AddRange(list);
            AddRange(list2);
        }

        public void Move(IlyaList<T> list, int index1, int index2)
        {
            if (index1 < 0 || index1 >= lenght) throw new Exception("Индекс не существует");
            if (index2 < 0 || index2 > list.lenght) throw new Exception("Индекс не существует");
            var ilyaListNode = GetElem(index1);
            current = ilyaListNode;
            currentIndex = index1;
            RemoveAt(index1);
            if (list.first == null)
            {
                ilyaListNode.next = null;
                ilyaListNode.prev = null;
                list.first = ilyaListNode;
                list.last = ilyaListNode;
                list.current = ilyaListNode;
                list.lenght = 1;
                currentIndex = 0;
                return;
            }
            if (index2 != list.lenght)
            {
                list.current = GetElem(index2);
                if (list.current.prev != null)
                {
                    list.current.prev.next = ilyaListNode;
                    ilyaListNode.prev = list.current.prev;
                }
                else
                {
                    list.first = ilyaListNode;
                    ilyaListNode.prev = null;
                }
                list.current.prev = ilyaListNode;
                ilyaListNode.next = list.current;
            }
            else
            {
                list.last.next = ilyaListNode;
                ilyaListNode.prev = list.last;
                list.last = list.last.next;
                ilyaListNode.next = null;
            }
        }

        public void ToFirst()
        {
            current = first;
            currentIndex = 0;
        }

        public void ToLast()
        {
            current = last;
            currentIndex = lenght - 1;
        }

        public void ToNext()
        {
            current = current.next;
            currentIndex++;
        }

        public void ToPrev()
        {
            current = current.prev;
            currentIndex--;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > lenght) throw new Exception("Индекс не существует");
            IlyaListNode<T> ilyaListNode = GetElem(index);
            if (index == 0)
            {
                first = first.next;
                first.prev = null;
                current = first;
            }
            if (index == lenght - 1)
            {
                last = last.prev;
                last.next = null;
                current = last;
            }
            if (index > 0 && index < lenght - 1)
            {
                ilyaListNode.prev.next = ilyaListNode.next;
                ilyaListNode.next.prev = ilyaListNode.prev;
                current = ilyaListNode.next;
            }
            lenght--;
            currentIndex = lenght > 0 ? index : -1;
        }

        public IlyaList<T> Split(int index)
        {
            IlyaList<T> second = new IlyaList<T>();
            IlyaListNode<T> ilyaListNode = GetElem(index);
            second.first = ilyaListNode;
            second.last = last;
            second.current = ilyaListNode;
            second.currentIndex = 0;
            second.lenght = lenght - index;
            if (index == 0) first = null;
            last = ilyaListNode.prev;
            current = last;
            lenght = index;
            currentIndex = lenght > 0 ? lenght - 1 : -1;
            second.first.prev = null;
            if (last != null) last.next = null;
            return second;
        }

        public void InsertFirst(T value)
        {
            IlyaListNode<T> ilyaListNode = new IlyaListNode<T>
            {
                data = value,
                next = first,
                prev = null
            };
            first.prev = ilyaListNode;
            first = ilyaListNode;
            current = first;
            lenght++;
            currentIndex = 0;
        }

        public void Insert(T value, int index)
        {
            if (index == lenght) Add(value);
            if (index == 0) InsertFirst(value);
            if (index < 0 || index > lenght) throw new Exception("Индекс не существует");
            IlyaListNode<T> startElem = GetElem(index);
            IlyaListNode<T> ilyaListNode = new IlyaListNode<T>
            {
                data = value,
                next = startElem,
                prev = startElem.prev
            };
            startElem.prev = ilyaListNode;
            startElem.prev.prev.next = ilyaListNode;
            current = ilyaListNode;
            lenght++;
            currentIndex = index;
        }

        private IlyaListNode<T> GetElem(int index)
        {
            IlyaListNode<T> startElem;
            int startIndex;
            if (Math.Abs(currentIndex - index) < index)
            {
                if (Math.Abs(currentIndex - index) < lenght - index - 1)
                {
                    startIndex = currentIndex;
                    startElem = current;
                }
                else
                {
                    startIndex = lenght - 1;
                    startElem = last;
                }
            }
            else
            {
                if (index < lenght - index - 1)
                {
                    startIndex = 0;
                    startElem = first;
                }
                else
                {
                    startIndex = lenght - 1;
                    startElem = last;
                }
            }
            for (int i = Math.Abs(index - startIndex); i > 0; i--)
            {
                startElem = index - startIndex > 0 ? startElem.next : startElem.prev;
            }
            return startElem;
        }
    }
}
