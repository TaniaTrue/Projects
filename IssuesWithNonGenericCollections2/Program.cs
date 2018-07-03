using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNonGenericCollections2
{
    class Program
    {
        static void SimpleBoxUnboxOp()
        {
            int myInt = 25;
            object boxedInt = myInt;
            int unboxedInt = (int)boxedInt;
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        static void Main(string[] args)
        {
            Node first = new Node { Value = 3 };
            Node middle = new Node { Value = 5 };
            first.Next = middle;
            Node last = new Node { Value = 7};
            middle.Next = last;

            PrintList(first);
            Console.ReadLine();

        }

        private static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }

    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }
        public T Value { get; internal set; }
       
        /// Ссылка на следующий узел списка (если узел последний, то null).
        public LinkedListNode<T> Next { get; internal set; }
    }

    public class LinkedList<T> : ICollection<T>
    {
        private LinkedListNode<T> _head;
        private LinkedListNode<T> _tail;
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
