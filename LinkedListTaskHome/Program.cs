using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTaskHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> list = new MyStack<int>();
            list.Push(1);
            list.Push(2);
            list.Push(3);

            Console.WriteLine("Peek: " + list.Peek());


            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        class MyStack<T> : IEnumerable<T>
        {
            private List<T> list;
            public int Count ;

            public MyStack()
            {
                list = new List<T>();
            }

            public void Push(T item)
            {
                list.Add(item);
            }

            public T Pop()
            {
                if (Count == 0)
                {
                    Console.WriteLine("Stack boshdur");
                }
                T LastItem = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return LastItem;
            }

            public T Peek()
            {
                if (Count == 0)
                {
                    Console.WriteLine("Stack boshdur");
                }
                return list[list.Count - 1];
            }
            public IEnumerator<T> GetEnumerator()
            {
                return ((IEnumerable<T>)list).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<T>)list).GetEnumerator();
            }
        }
    }
}
