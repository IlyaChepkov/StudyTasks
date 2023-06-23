using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaCode
{
    internal class IlyaQueue<T>
    {
        int lenght = 0;
        IlyaQueueNode<T> head;
        IlyaQueueNode<T> tail;

        public int Lenght
        {
            get { return lenght; }
        }

        public bool IsEmpty
        {
            get { return lenght == 0; }
        }

        public void Enqueue(T value)
        {
            IlyaQueueNode<T> ilyaQueueNode = new IlyaQueueNode<T>
            {
                data = value,
                next = null
            };
            if (IsEmpty)
            {
                head = ilyaQueueNode;
            }
            else
            {
                tail.next = ilyaQueueNode;
            }
            tail = ilyaQueueNode;
            lenght++;
        }

        public T Dequeue()
        {
            if (IsEmpty) throw new Exception("Oчередь пустая");
            T value = head.data;
            head = head.next;
            if (head == null) tail = null;
            lenght--;
            return value;
        }

        public T Peek()
        {
            if (IsEmpty) throw new Exception("Oчередь пустая");
            return head.data;
        }

        class IlyaQueueNode<T>
        {
            public T data;
            public IlyaQueueNode<T> next;
        }
    }
}
