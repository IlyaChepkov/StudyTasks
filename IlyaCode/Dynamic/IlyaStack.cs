namespace IlyaCode
{
    internal class IlyaStack<T>
    {
        int lenght = 0;
        IlyaStackNode<T> top;

        public int Lenght
        {
            get { return lenght; }
        }

        public bool IsEmpty
        {
            get { return lenght == 0; }
        }

        class IlyaStackNode<T>
        {
            public T data;
            public IlyaStackNode<T> next;
        }

        public void Push(T value)
        {
            IlyaStackNode<T> ilyaStackNode = new IlyaStackNode<T>
            {
                data = value,
                next = top
            };
            top = ilyaStackNode;
            lenght++;
        }

        public T Pop()
        {
            if (top == null) throw new Exception("Стек пустой");
            T value = top.data;
            top = top.next;
            lenght--;
            return value;
        }

        public T Peek()
        {
            if (top == null) throw new Exception("Стек пустой");
            return top.data;
        }
    }
}
