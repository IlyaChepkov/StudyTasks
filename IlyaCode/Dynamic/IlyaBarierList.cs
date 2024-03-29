﻿namespace IlyaCode
{
    internal class IlyaBarierList<T>
    {
        int lenght = 0;
        int currentIndex = -1;
        IlyaListNode<T> barier;
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
            get { return current == barier.prev; }
        }

        public bool IsFirst
        {
            get { return current == barier.next; }
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

        public IlyaBarierList(IlyaListNode<T> barier)
        {
            this.barier = barier;
            current = barier;
            currentIndex = -1;
            lenght = 0;
            for (var i = barier.next; i != barier; i = i.next)
                lenght++;
        }

        public IlyaBarierList()
        {
            barier = new IlyaListNode<T>();
            barier.next = barier;
            barier.prev = barier;
            current = barier;
            currentIndex = -1;
            lenght = 0;
        }

        public void Add(T value)
        {
            IlyaListNode<T> ilyaListNode = new IlyaListNode<T>();
            ilyaListNode.data = value;
            ilyaListNode.next = barier;
            ilyaListNode.prev = barier.prev;
            barier.prev.next = ilyaListNode;
            barier.prev = ilyaListNode;
            current = barier.prev;
            lenght++;
            currentIndex = lenght - 1;
        }

        public void AddRange(IlyaBarierList<T> list)
        {
            if (list.lenght == 0) return;
            barier.prev.next = list.barier.next;
            list.barier.next.prev = barier.prev;
            barier.prev = list.barier.prev;
            list.barier.prev.next = barier;
            current = barier;
            lenght += list.lenght;
            currentIndex = -1;
            list.barier.next = list.barier;
            list.barier.prev = list.barier;
            list.current = list.barier;
            list.currentIndex = -1;
            list.lenght = 0;
        }


        public void ToFirst()
        {
            current = barier.next;
            currentIndex = barier.next == barier ? -1 : 0;
        }

        public void ToLast()
        {
            current = barier.prev;
            currentIndex = barier.prev == barier ? -1 : lenght - 1;
        }

        public void ToNext()
        {
            current = current.next;
            currentIndex = currentIndex == lenght - 1 ? -1 : currentIndex + 1;
        }

        public void ToPrev()
        {
            current = current.prev;
            currentIndex = currentIndex == 0 ? -1 : currentIndex - 1;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > lenght) throw new Exception("Индекс не существует");
            IlyaListNode<T> ilyaListNode = GetElem(index);
            if (index == 0)
            {
                barier.next = barier.next.next;
                barier.next.prev = barier;
                current = barier.next;
            }
            if (index == lenght - 1)
            {
                barier.prev = barier.prev.prev;
                barier.prev.next = barier;
                current = barier.prev;
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

        public IlyaBarierList<T> Split(int index)
        {
            IlyaBarierList<T> second = new IlyaBarierList<T>();
            IlyaListNode<T> ilyaListNode = GetElem(index);
            var newLast = ilyaListNode.prev;
            second.barier.next = ilyaListNode;
            second.barier.prev = barier.prev;
            second.barier.prev.next = second.barier;
            second.current = second.barier;
            second.currentIndex = -1;
            second.lenght = lenght - index;
            barier.prev = newLast;
            newLast.next = barier;
            current = barier;
            lenght = index;
            currentIndex = -1;
            return second;
        }

        public void InsertFirst(T value)
        {
            IlyaListNode<T> ilyaListNode = new IlyaListNode<T>
            {
                data = value,
                next = barier.next,
                prev = barier
            };
            barier.next = ilyaListNode;
            barier.next.next.prev = ilyaListNode;
            current = barier.next;
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
                    startElem = barier.prev;
                }
            }
            else
            {
                if (index < lenght - index - 1)
                {
                    startIndex = 0;
                    startElem = barier.next;
                }
                else
                {
                    startIndex = lenght - 1;
                    startElem = barier.prev;
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
