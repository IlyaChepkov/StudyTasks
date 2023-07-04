using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCode
{
    internal class IlyaCicleList<T>
    {
        int lenght = 0;
        int currentIndex = -1;
        IlyaListNode<T> first;
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
            get { return current.next == first; }
        }

        public bool IsFirst
        {
            get { return current == first; }
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

        public IlyaCicleList(IlyaListNode<T> first)
        {
            this.first = first;
            current = first;
            currentIndex = current == null ? -1 : 0;
            if (first != null)
            {
                lenght = 1;
                for (var i = first.next; i != first; i = i.next)
                    lenght++;
            }
            else
                lenght = 0;
        }

        public IlyaCicleList()
        {
            first = null;
            current = null;
            currentIndex = -1;
            lenght = 0;
        }

        public void Add(T value)
        {
            IlyaListNode<T> ilyaListNode = new IlyaListNode<T>();
            ilyaListNode.data = value;
            ilyaListNode.next = first == null ? ilyaListNode : first;
            ilyaListNode.prev = first == null ? ilyaListNode : first.prev;
            if(first == null)
            {
                first = ilyaListNode;
            }
            else
            {
                first.prev.next = ilyaListNode;
                first.prev = ilyaListNode;
            }
            current = first.prev;
            lenght++;
            currentIndex = lenght - 1;
        }

        public void Next(int k)
        {
            for (int i = 0; i < k; i++)
            {
                first = first.next;
            }
        }

        public void Prev(int k)
        {
            for (int i = 0; i < k; i++)
            {
                first = first.prev;
            }
        }

        public void ToFirst()
        {
            current = first;
            currentIndex = 0;
        }

        public void ToLast()
        {
            current = first.prev;
            currentIndex = lenght - 1;
        }

        public void ToNext()
        {
            current = current.next;
            currentIndex = currentIndex == lenght - 1 ? 0 : currentIndex + 1;
        }

        public void ToPrev()
        {
            current = current.prev;
            currentIndex = currentIndex == 0 ? lenght - 1 : currentIndex - 1;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > lenght) throw new Exception("Индекс не существует");
            IlyaListNode<T> ilyaListNode = GetElem(index);
            if (index == 0)
            {
                first = first.next;
                first.prev = first.prev.prev;
                first.prev.next = first;
                current = first;
            }
            if (index == lenght - 1)
            {
                first.prev = first.prev.prev;
                first.prev.next = first;
                current = first.prev;
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

        public IlyaCicleList<T> Split(int index)
        {
            IlyaCicleList<T> second = new IlyaCicleList<T>();
            IlyaListNode<T> ilyaListNode = GetElem(index);
            var newLast = ilyaListNode.prev;
            second.first = ilyaListNode;
            second.first.prev = first.prev;
            second.first.prev.next = second.first;
            second.current = ilyaListNode;
            second.currentIndex = 0;
            second.lenght = lenght - index;
            if (index == 0)
            {
                first = null;
                current = null;
            }
            else
            {
                first.prev = newLast;
                newLast.next = first;
                current = first.prev;
            }
            lenght = index;
            currentIndex = lenght > 0 ? lenght - 1 : -1;
            return second;
        }

        public void InsertFirst(T value)
        {
            IlyaListNode<T> ilyaListNode = new IlyaListNode<T>
            {
                data = value,
                next = first,
                prev = first.prev
            };
            first.prev = ilyaListNode;
            first = ilyaListNode;
            first.prev.next = ilyaListNode;
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
                    startElem = first.prev;
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
                    startElem = first.prev;
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
